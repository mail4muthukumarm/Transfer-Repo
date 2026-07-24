// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Reliable.dsRequest
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.Reliable;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsRequest")]
[HelpKeyword("vs.data.DataSet")]
[GeneratedCode("System.Xml", "4.6.1586.0")]
[Serializable]
public class dsRequest : DataSet
{
  private dsRequest.RequestDataTable tableRequest;
  private dsRequest.LocationDataTable tableLocation;
  private dsRequest.SIC_CodesDataTable tableSIC_Codes;
  private dsRequest.ReportsDataTable tableReports;
  private DataRelation relationRequest_Location;
  private DataRelation relationLocation_SIC_Codes;
  private DataRelation relationLocation_Reports;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsRequest()
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
  protected dsRequest(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsRequest.RequestDataTable(dataSet.Tables[nameof (Request)]));
        if (dataSet.Tables[nameof (Location)] != null)
          base.Tables.Add((DataTable) new dsRequest.LocationDataTable(dataSet.Tables[nameof (Location)]));
        if (dataSet.Tables[nameof (SIC_Codes)] != null)
          base.Tables.Add((DataTable) new dsRequest.SIC_CodesDataTable(dataSet.Tables[nameof (SIC_Codes)]));
        if (dataSet.Tables[nameof (Reports)] != null)
          base.Tables.Add((DataTable) new dsRequest.ReportsDataTable(dataSet.Tables[nameof (Reports)]));
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
  public dsRequest.RequestDataTable Request => this.tableRequest;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRequest.LocationDataTable Location => this.tableLocation;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRequest.SIC_CodesDataTable SIC_Codes => this.tableSIC_Codes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRequest.ReportsDataTable Reports => this.tableReports;

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
    dsRequest dsRequest = (dsRequest) base.Clone();
    dsRequest.InitVars();
    dsRequest.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsRequest;
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
        base.Tables.Add((DataTable) new dsRequest.RequestDataTable(dataSet.Tables["Request"]));
      if (dataSet.Tables["Location"] != null)
        base.Tables.Add((DataTable) new dsRequest.LocationDataTable(dataSet.Tables["Location"]));
      if (dataSet.Tables["SIC_Codes"] != null)
        base.Tables.Add((DataTable) new dsRequest.SIC_CodesDataTable(dataSet.Tables["SIC_Codes"]));
      if (dataSet.Tables["Reports"] != null)
        base.Tables.Add((DataTable) new dsRequest.ReportsDataTable(dataSet.Tables["Reports"]));
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
    this.tableRequest = (dsRequest.RequestDataTable) base.Tables["Request"];
    if (initTable && this.tableRequest != null)
      this.tableRequest.InitVars();
    this.tableLocation = (dsRequest.LocationDataTable) base.Tables["Location"];
    if (initTable && this.tableLocation != null)
      this.tableLocation.InitVars();
    this.tableSIC_Codes = (dsRequest.SIC_CodesDataTable) base.Tables["SIC_Codes"];
    if (initTable && this.tableSIC_Codes != null)
      this.tableSIC_Codes.InitVars();
    this.tableReports = (dsRequest.ReportsDataTable) base.Tables["Reports"];
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
    this.DataSetName = nameof (dsRequest);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsRequest.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableRequest = new dsRequest.RequestDataTable();
    base.Tables.Add((DataTable) this.tableRequest);
    this.tableLocation = new dsRequest.LocationDataTable();
    base.Tables.Add((DataTable) this.tableLocation);
    this.tableSIC_Codes = new dsRequest.SIC_CodesDataTable();
    base.Tables.Add((DataTable) this.tableSIC_Codes);
    this.tableReports = new dsRequest.ReportsDataTable();
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
    dsRequest dsRequest = new dsRequest();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsRequest.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsRequest.GetSchemaSerializable();
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
    dsRequest.RequestRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void LocationRowChangeEventHandler(
    object sender,
    dsRequest.LocationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void SIC_CodesRowChangeEventHandler(
    object sender,
    dsRequest.SIC_CodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ReportsRowChangeEventHandler(
    object sender,
    dsRequest.ReportsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class RequestDataTable : DataTable, IEnumerable
  {
    private DataColumn columnClient_Code;
    private DataColumn columnPolicy_Number;
    private DataColumn columnRequest_Date;
    private DataColumn columnRequestor_Name;
    private DataColumn columnInsured_Name;
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
    private DataColumn columnRetailer_Contact_Name;
    private DataColumn columnRetailer_Contact_Phone;
    private DataColumn columnControl_Number;
    private DataColumn columnLineOfCoverage;
    private DataColumn columnUnit_Cost;
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
    public DataColumn Policy_NumberColumn => this.columnPolicy_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Request_DateColumn => this.columnRequest_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Requestor_NameColumn => this.columnRequestor_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_NameColumn => this.columnInsured_Name;

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
    public DataColumn Retailer_Contact_NameColumn => this.columnRetailer_Contact_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Retailer_Contact_PhoneColumn => this.columnRetailer_Contact_Phone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Control_NumberColumn => this.columnControl_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineOfCoverageColumn => this.columnLineOfCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Unit_CostColumn => this.columnUnit_Cost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Request_IdColumn => this.columnRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.RequestRow this[int index] => (dsRequest.RequestRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.RequestRowChangeEventHandler RequestRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.RequestRowChangeEventHandler RequestRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.RequestRowChangeEventHandler RequestRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.RequestRowChangeEventHandler RequestRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddRequestRow(dsRequest.RequestRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.RequestRow AddRequestRow(
      string Client_Code,
      string Policy_Number,
      string Request_Date,
      string Requestor_Name,
      string Insured_Name,
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
      string Agent_Contact_Phone,
      string Retailer_Contact_Name,
      string Retailer_Contact_Phone,
      string Control_Number,
      string LineOfCoverage,
      string Unit_Cost)
    {
      dsRequest.RequestRow row = (dsRequest.RequestRow) this.NewRow();
      object[] objArray = new object[24]
      {
        (object) Client_Code,
        (object) Policy_Number,
        (object) Request_Date,
        (object) Requestor_Name,
        (object) Insured_Name,
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
        (object) Retailer_Contact_Name,
        (object) Retailer_Contact_Phone,
        (object) Control_Number,
        (object) LineOfCoverage,
        (object) Unit_Cost,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRequest.RequestDataTable requestDataTable = (dsRequest.RequestDataTable) base.Clone();
      requestDataTable.InitVars();
      return (DataTable) requestDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsRequest.RequestDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClient_Code = this.Columns["Client_Code"];
      this.columnPolicy_Number = this.Columns["Policy_Number"];
      this.columnRequest_Date = this.Columns["Request_Date"];
      this.columnRequestor_Name = this.Columns["Requestor_Name"];
      this.columnInsured_Name = this.Columns["Insured_Name"];
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
      this.columnRetailer_Contact_Name = this.Columns["Retailer_Contact_Name"];
      this.columnRetailer_Contact_Phone = this.Columns["Retailer_Contact_Phone"];
      this.columnControl_Number = this.Columns["Control_Number"];
      this.columnLineOfCoverage = this.Columns["LineOfCoverage"];
      this.columnUnit_Cost = this.Columns["Unit_Cost"];
      this.columnRequest_Id = this.Columns["Request_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClient_Code = new DataColumn("Client_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClient_Code);
      this.columnPolicy_Number = new DataColumn("Policy_Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicy_Number);
      this.columnRequest_Date = new DataColumn("Request_Date", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequest_Date);
      this.columnRequestor_Name = new DataColumn("Requestor_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequestor_Name);
      this.columnInsured_Name = new DataColumn("Insured_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Name);
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
      this.columnRetailer_Contact_Name = new DataColumn("Retailer_Contact_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetailer_Contact_Name);
      this.columnRetailer_Contact_Phone = new DataColumn("Retailer_Contact_Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetailer_Contact_Phone);
      this.columnControl_Number = new DataColumn("Control_Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControl_Number);
      this.columnLineOfCoverage = new DataColumn("LineOfCoverage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineOfCoverage);
      this.columnUnit_Cost = new DataColumn("Unit_Cost", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnit_Cost);
      this.columnRequest_Id = new DataColumn("Request_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnRequest_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRequest_Id
      }, true));
      this.columnClient_Code.AllowDBNull = false;
      this.columnPolicy_Number.AllowDBNull = false;
      this.columnRequest_Date.AllowDBNull = false;
      this.columnRequestor_Name.AllowDBNull = false;
      this.columnInsured_Name.AllowDBNull = false;
      this.columnInsured_Address_1.AllowDBNull = false;
      this.columnInsured_City.AllowDBNull = false;
      this.columnInsured_State.AllowDBNull = false;
      this.columnInsured_Zipcode.AllowDBNull = false;
      this.columnAgent_Name.AllowDBNull = false;
      this.columnCarrier_Name.AllowDBNull = false;
      this.columnAgent_Contact.AllowDBNull = false;
      this.columnAgent_Contact_Phone.AllowDBNull = false;
      this.columnRetailer_Contact_Name.AllowDBNull = false;
      this.columnRetailer_Contact_Phone.AllowDBNull = false;
      this.columnControl_Number.AllowDBNull = false;
      this.columnRequest_Id.AutoIncrement = true;
      this.columnRequest_Id.AllowDBNull = false;
      this.columnRequest_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.RequestRow NewRequestRow() => (dsRequest.RequestRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRequest.RequestRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRequest.RequestRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RequestRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequest.RequestRowChangeEventHandler requestRowChangedEvent = this.RequestRowChangedEvent;
      if (requestRowChangedEvent == null)
        return;
      requestRowChangedEvent((object) this, new dsRequest.RequestRowChangeEvent((dsRequest.RequestRow) e.Row, e.Action));
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
      dsRequest.RequestRowChangeEventHandler rowChangingEvent = this.RequestRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRequest.RequestRowChangeEvent((dsRequest.RequestRow) e.Row, e.Action));
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
      dsRequest.RequestRowChangeEventHandler requestRowDeletedEvent = this.RequestRowDeletedEvent;
      if (requestRowDeletedEvent == null)
        return;
      requestRowDeletedEvent((object) this, new dsRequest.RequestRowChangeEvent((dsRequest.RequestRow) e.Row, e.Action));
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
      dsRequest.RequestRowChangeEventHandler rowDeletingEvent = this.RequestRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRequest.RequestRowChangeEvent((dsRequest.RequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveRequestRow(dsRequest.RequestRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRequest dsRequest = new dsRequest();
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
        FixedValue = dsRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (RequestDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRequest.GetSchemaSerializable();
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
  public class LocationDataTable : DataTable, IEnumerable
  {
    private DataColumn columnLocation_Address1;
    private DataColumn columnLocation_Address2;
    private DataColumn columnLocation_City;
    private DataColumn columnLocation_State;
    private DataColumn columnLocation_Zipcode;
    private DataColumn columnLocation_Number;
    private DataColumn columnIsCostReq;
    private DataColumn columnIsPhotoReq;
    private DataColumn columnIsDiagramReq;
    private DataColumn columnRush;
    private DataColumn columnDue_Date;
    private DataColumn columnSpecial_Instructions;
    private DataColumn columnSIC_Other;
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
    public DataColumn Location_NumberColumn => this.columnLocation_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsCostReqColumn => this.columnIsCostReq;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsPhotoReqColumn => this.columnIsPhotoReq;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsDiagramReqColumn => this.columnIsDiagramReq;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RushColumn => this.columnRush;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Due_DateColumn => this.columnDue_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Special_InstructionsColumn => this.columnSpecial_Instructions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIC_OtherColumn => this.columnSIC_Other;

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
    public dsRequest.LocationRow this[int index] => (dsRequest.LocationRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.LocationRowChangeEventHandler LocationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.LocationRowChangeEventHandler LocationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.LocationRowChangeEventHandler LocationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.LocationRowChangeEventHandler LocationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddLocationRow(dsRequest.LocationRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.LocationRow AddLocationRow(
      string Location_Address1,
      string Location_Address2,
      string Location_City,
      string Location_State,
      string Location_Zipcode,
      string Location_Number,
      bool IsCostReq,
      bool IsPhotoReq,
      bool IsDiagramReq,
      bool Rush,
      string Due_Date,
      string Special_Instructions,
      string SIC_Other,
      dsRequest.RequestRow parentRequestRowByRequest_Location)
    {
      dsRequest.LocationRow row = (dsRequest.LocationRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) Location_Address1,
        (object) Location_Address2,
        (object) Location_City,
        (object) Location_State,
        (object) Location_Zipcode,
        (object) Location_Number,
        (object) IsCostReq,
        (object) IsPhotoReq,
        (object) IsDiagramReq,
        (object) Rush,
        (object) Due_Date,
        (object) Special_Instructions,
        (object) SIC_Other,
        null,
        null
      };
      if (parentRequestRowByRequest_Location != null)
        objArray[14] = RuntimeHelpers.GetObjectValue(parentRequestRowByRequest_Location[23]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRequest.LocationDataTable locationDataTable = (dsRequest.LocationDataTable) base.Clone();
      locationDataTable.InitVars();
      return (DataTable) locationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsRequest.LocationDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocation_Address1 = this.Columns["Location_Address1"];
      this.columnLocation_Address2 = this.Columns["Location_Address2"];
      this.columnLocation_City = this.Columns["Location_City"];
      this.columnLocation_State = this.Columns["Location_State"];
      this.columnLocation_Zipcode = this.Columns["Location_Zipcode"];
      this.columnLocation_Number = this.Columns["Location_Number"];
      this.columnIsCostReq = this.Columns["IsCostReq"];
      this.columnIsPhotoReq = this.Columns["IsPhotoReq"];
      this.columnIsDiagramReq = this.Columns["IsDiagramReq"];
      this.columnRush = this.Columns["Rush"];
      this.columnDue_Date = this.Columns["Due_Date"];
      this.columnSpecial_Instructions = this.Columns["Special_Instructions"];
      this.columnSIC_Other = this.Columns["SIC_Other"];
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
      this.columnLocation_Number = new DataColumn("Location_Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Number);
      this.columnIsCostReq = new DataColumn("IsCostReq", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsCostReq);
      this.columnIsPhotoReq = new DataColumn("IsPhotoReq", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsPhotoReq);
      this.columnIsDiagramReq = new DataColumn("IsDiagramReq", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsDiagramReq);
      this.columnRush = new DataColumn("Rush", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRush);
      this.columnDue_Date = new DataColumn("Due_Date", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDue_Date);
      this.columnSpecial_Instructions = new DataColumn("Special_Instructions", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecial_Instructions);
      this.columnSIC_Other = new DataColumn("SIC_Other", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Other);
      this.columnLocation_Id = new DataColumn("Location_Id", typeof (int), (string) null, MappingType.Hidden);
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
      this.columnLocation_Zipcode.AllowDBNull = false;
      this.columnIsCostReq.AllowDBNull = false;
      this.columnIsPhotoReq.AllowDBNull = false;
      this.columnIsDiagramReq.AllowDBNull = false;
      this.columnRush.AllowDBNull = false;
      this.columnDue_Date.AllowDBNull = false;
      this.columnLocation_Id.AutoIncrement = true;
      this.columnLocation_Id.AllowDBNull = false;
      this.columnLocation_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.LocationRow NewLocationRow() => (dsRequest.LocationRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRequest.LocationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRequest.LocationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequest.LocationRowChangeEventHandler locationRowChangedEvent = this.LocationRowChangedEvent;
      if (locationRowChangedEvent == null)
        return;
      locationRowChangedEvent((object) this, new dsRequest.LocationRowChangeEvent((dsRequest.LocationRow) e.Row, e.Action));
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
      dsRequest.LocationRowChangeEventHandler rowChangingEvent = this.LocationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRequest.LocationRowChangeEvent((dsRequest.LocationRow) e.Row, e.Action));
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
      dsRequest.LocationRowChangeEventHandler locationRowDeletedEvent = this.LocationRowDeletedEvent;
      if (locationRowDeletedEvent == null)
        return;
      locationRowDeletedEvent((object) this, new dsRequest.LocationRowChangeEvent((dsRequest.LocationRow) e.Row, e.Action));
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
      dsRequest.LocationRowChangeEventHandler rowDeletingEvent = this.LocationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRequest.LocationRowChangeEvent((dsRequest.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveLocationRow(dsRequest.LocationRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRequest dsRequest = new dsRequest();
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
        FixedValue = dsRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (LocationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRequest.GetSchemaSerializable();
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
  public class SIC_CodesDataTable : DataTable, IEnumerable
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
    public dsRequest.SIC_CodesRow this[int index] => (dsRequest.SIC_CodesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddSIC_CodesRow(dsRequest.SIC_CodesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.SIC_CodesRow AddSIC_CodesRow(
      string SIC_Code,
      dsRequest.LocationRow parentLocationRowByLocation_SIC_Codes)
    {
      dsRequest.SIC_CodesRow row = (dsRequest.SIC_CodesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) SIC_Code,
        null
      };
      if (parentLocationRowByLocation_SIC_Codes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentLocationRowByLocation_SIC_Codes[13]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRequest.SIC_CodesDataTable sicCodesDataTable = (dsRequest.SIC_CodesDataTable) base.Clone();
      sicCodesDataTable.InitVars();
      return (DataTable) sicCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsRequest.SIC_CodesDataTable();

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
      this.columnLocation_Id = new DataColumn("Location_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnLocation_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.SIC_CodesRow NewSIC_CodesRow() => (dsRequest.SIC_CodesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRequest.SIC_CodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRequest.SIC_CodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SIC_CodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequest.SIC_CodesRowChangeEventHandler codesRowChangedEvent = this.SIC_CodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsRequest.SIC_CodesRowChangeEvent((dsRequest.SIC_CodesRow) e.Row, e.Action));
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
      dsRequest.SIC_CodesRowChangeEventHandler rowChangingEvent = this.SIC_CodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRequest.SIC_CodesRowChangeEvent((dsRequest.SIC_CodesRow) e.Row, e.Action));
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
      dsRequest.SIC_CodesRowChangeEventHandler codesRowDeletedEvent = this.SIC_CodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsRequest.SIC_CodesRowChangeEvent((dsRequest.SIC_CodesRow) e.Row, e.Action));
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
      dsRequest.SIC_CodesRowChangeEventHandler rowDeletingEvent = this.SIC_CodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRequest.SIC_CodesRowChangeEvent((dsRequest.SIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveSIC_CodesRow(dsRequest.SIC_CodesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRequest dsRequest = new dsRequest();
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
        FixedValue = dsRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SIC_CodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRequest.GetSchemaSerializable();
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
  public class ReportsDataTable : DataTable, IEnumerable
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
    public dsRequest.ReportsRow this[int index] => (dsRequest.ReportsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.ReportsRowChangeEventHandler ReportsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.ReportsRowChangeEventHandler ReportsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.ReportsRowChangeEventHandler ReportsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequest.ReportsRowChangeEventHandler ReportsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddReportsRow(dsRequest.ReportsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.ReportsRow AddReportsRow(
      string Item_Name,
      string Value,
      dsRequest.LocationRow parentLocationRowByLocation_Reports)
    {
      dsRequest.ReportsRow row = (dsRequest.ReportsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Item_Name,
        (object) Value,
        null
      };
      if (parentLocationRowByLocation_Reports != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentLocationRowByLocation_Reports[13]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRequest.ReportsDataTable reportsDataTable = (dsRequest.ReportsDataTable) base.Clone();
      reportsDataTable.InitVars();
      return (DataTable) reportsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsRequest.ReportsDataTable();

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
      this.columnLocation_Id = new DataColumn("Location_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnLocation_Id);
      this.columnItem_Name.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.ReportsRow NewReportsRow() => (dsRequest.ReportsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRequest.ReportsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRequest.ReportsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReportsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequest.ReportsRowChangeEventHandler reportsRowChangedEvent = this.ReportsRowChangedEvent;
      if (reportsRowChangedEvent == null)
        return;
      reportsRowChangedEvent((object) this, new dsRequest.ReportsRowChangeEvent((dsRequest.ReportsRow) e.Row, e.Action));
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
      dsRequest.ReportsRowChangeEventHandler rowChangingEvent = this.ReportsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRequest.ReportsRowChangeEvent((dsRequest.ReportsRow) e.Row, e.Action));
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
      dsRequest.ReportsRowChangeEventHandler reportsRowDeletedEvent = this.ReportsRowDeletedEvent;
      if (reportsRowDeletedEvent == null)
        return;
      reportsRowDeletedEvent((object) this, new dsRequest.ReportsRowChangeEvent((dsRequest.ReportsRow) e.Row, e.Action));
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
      dsRequest.ReportsRowChangeEventHandler rowDeletingEvent = this.ReportsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRequest.ReportsRowChangeEvent((dsRequest.ReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveReportsRow(dsRequest.ReportsRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRequest dsRequest = new dsRequest();
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
        FixedValue = dsRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReportsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRequest.GetSchemaSerializable();
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
    private dsRequest.RequestDataTable tableRequest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal RequestRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableRequest = (dsRequest.RequestDataTable) this.Table;
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
      get => Conversions.ToString(this[this.tableRequest.Requestor_NameColumn]);
      set => this[this.tableRequest.Requestor_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Name
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_NameColumn]);
      set => this[this.tableRequest.Insured_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Address_1
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_Address_1Column]);
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
      get => Conversions.ToString(this[this.tableRequest.Insured_CityColumn]);
      set => this[this.tableRequest.Insured_CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_State
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_StateColumn]);
      set => this[this.tableRequest.Insured_StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Zipcode
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_ZipcodeColumn]);
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
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_Contact_NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_Contact_Name' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_Contact_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Contact_Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_Contact_PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_Contact_Phone' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
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
      get => Conversions.ToString(this[this.tableRequest.Agent_ContactColumn]);
      set => this[this.tableRequest.Agent_ContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Agent_Contact_Phone
    {
      get => Conversions.ToString(this[this.tableRequest.Agent_Contact_PhoneColumn]);
      set => this[this.tableRequest.Agent_Contact_PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Retailer_Contact_Name
    {
      get => Conversions.ToString(this[this.tableRequest.Retailer_Contact_NameColumn]);
      set => this[this.tableRequest.Retailer_Contact_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Retailer_Contact_Phone
    {
      get => Conversions.ToString(this[this.tableRequest.Retailer_Contact_PhoneColumn]);
      set => this[this.tableRequest.Retailer_Contact_PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Control_Number
    {
      get => Conversions.ToString(this[this.tableRequest.Control_NumberColumn]);
      set => this[this.tableRequest.Control_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LineOfCoverage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.LineOfCoverageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineOfCoverage' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.LineOfCoverageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Unit_Cost
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Unit_CostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Unit_Cost' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Unit_CostColumn] = (object) value;
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
    public bool IsInsured_Address_2Null() => this.IsNull(this.tableRequest.Insured_Address_2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_Address_2Null()
    {
      this[this.tableRequest.Insured_Address_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_Contact_NameNull()
    {
      return this.IsNull(this.tableRequest.Insured_Contact_NameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_Contact_NameNull()
    {
      this[this.tableRequest.Insured_Contact_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_Contact_PhoneNull()
    {
      return this.IsNull(this.tableRequest.Insured_Contact_PhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_Contact_PhoneNull()
    {
      this[this.tableRequest.Insured_Contact_PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
    public bool IsLineOfCoverageNull() => this.IsNull(this.tableRequest.LineOfCoverageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLineOfCoverageNull()
    {
      this[this.tableRequest.LineOfCoverageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnit_CostNull() => this.IsNull(this.tableRequest.Unit_CostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnit_CostNull()
    {
      this[this.tableRequest.Unit_CostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.LocationRow[] GetLocationRows()
    {
      return this.Table.ChildRelations["Request_Location"] != null ? (dsRequest.LocationRow[]) this.GetChildRows(this.Table.ChildRelations["Request_Location"]) : new dsRequest.LocationRow[0];
    }
  }

  public class LocationRow : DataRow
  {
    private dsRequest.LocationDataTable tableLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal LocationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLocation = (dsRequest.LocationDataTable) this.Table;
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
      get => Conversions.ToString(this[this.tableLocation.Location_ZipcodeColumn]);
      set => this[this.tableLocation.Location_ZipcodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Number
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Location_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Location_Number' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Location_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCostReq
    {
      get => Conversions.ToBoolean(this[this.tableLocation.IsCostReqColumn]);
      set => this[this.tableLocation.IsCostReqColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPhotoReq
    {
      get => Conversions.ToBoolean(this[this.tableLocation.IsPhotoReqColumn]);
      set => this[this.tableLocation.IsPhotoReqColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDiagramReq
    {
      get => Conversions.ToBoolean(this[this.tableLocation.IsDiagramReqColumn]);
      set => this[this.tableLocation.IsDiagramReqColumn] = (object) value;
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
    public string SIC_Other
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.SIC_OtherColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SIC_Other' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.SIC_OtherColumn] = (object) value;
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
    public dsRequest.RequestRow RequestRow
    {
      get
      {
        return (dsRequest.RequestRow) this.GetParentRow(this.Table.ParentRelations["Request_Location"]);
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
    public bool IsLocation_NumberNull() => this.IsNull(this.tableLocation.Location_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocation_NumberNull()
    {
      this[this.tableLocation.Location_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
    public bool IsSIC_OtherNull() => this.IsNull(this.tableLocation.SIC_OtherColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSIC_OtherNull()
    {
      this[this.tableLocation.SIC_OtherColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
    public dsRequest.SIC_CodesRow[] GetSIC_CodesRows()
    {
      return this.Table.ChildRelations["Location_SIC_Codes"] != null ? (dsRequest.SIC_CodesRow[]) this.GetChildRows(this.Table.ChildRelations["Location_SIC_Codes"]) : new dsRequest.SIC_CodesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.ReportsRow[] GetReportsRows()
    {
      return this.Table.ChildRelations["Location_Reports"] != null ? (dsRequest.ReportsRow[]) this.GetChildRows(this.Table.ChildRelations["Location_Reports"]) : new dsRequest.ReportsRow[0];
    }
  }

  public class SIC_CodesRow : DataRow
  {
    private dsRequest.SIC_CodesDataTable tableSIC_Codes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SIC_CodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSIC_Codes = (dsRequest.SIC_CodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC_Code
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSIC_Codes.SIC_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SIC_Code' in table 'SIC_Codes' is DBNull.", (Exception) ex);
        }
      }
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
    public dsRequest.LocationRow LocationRow
    {
      get
      {
        return (dsRequest.LocationRow) this.GetParentRow(this.Table.ParentRelations["Location_SIC_Codes"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Location_SIC_Codes"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSIC_CodeNull() => this.IsNull(this.tableSIC_Codes.SIC_CodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSIC_CodeNull()
    {
      this[this.tableSIC_Codes.SIC_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
    private dsRequest.ReportsDataTable tableReports;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ReportsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReports = (dsRequest.ReportsDataTable) this.Table;
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
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReports.ValueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Value' in table 'Reports' is DBNull.", (Exception) ex);
        }
      }
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
    public dsRequest.LocationRow LocationRow
    {
      get
      {
        return (dsRequest.LocationRow) this.GetParentRow(this.Table.ParentRelations["Location_Reports"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Location_Reports"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsValueNull() => this.IsNull(this.tableReports.ValueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetValueNull()
    {
      this[this.tableReports.ValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
    private dsRequest.RequestRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RequestRowChangeEvent(dsRequest.RequestRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.RequestRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class LocationRowChangeEvent : EventArgs
  {
    private dsRequest.LocationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public LocationRowChangeEvent(dsRequest.LocationRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.LocationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class SIC_CodesRowChangeEvent : EventArgs
  {
    private dsRequest.SIC_CodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SIC_CodesRowChangeEvent(dsRequest.SIC_CodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.SIC_CodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ReportsRowChangeEvent : EventArgs
  {
    private dsRequest.ReportsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ReportsRowChangeEvent(dsRequest.ReportsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequest.ReportsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
