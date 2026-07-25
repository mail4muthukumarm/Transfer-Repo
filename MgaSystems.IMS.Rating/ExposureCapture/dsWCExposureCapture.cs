// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.dsWCExposureCapture
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating.ExposureCapture;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsWCExposureCapture")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsWCExposureCapture : DataSet
{
  private dsWCExposureCapture.tblGenericWCExposuresDataTable tabletblGenericWCExposures;
  private dsWCExposureCapture.lstClassCodesDataTable tablelstClassCodes;
  private dsWCExposureCapture.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsWCExposureCapture.lstStatesDataTable tablelstStates;
  private dsWCExposureCapture.lstWCLimitsDataTable tablelstWCLimits;
  private dsWCExposureCapture.tblWCPolicyInfoDataTable tabletblWCPolicyInfo;
  private dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable tableNetRate_Quote_Insur_Quote_Locat;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsWCExposureCapture()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsWCExposureCapture(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblGenericWCExposures)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.tblGenericWCExposuresDataTable(dataSet.Tables[nameof (tblGenericWCExposures)]));
        if (dataSet.Tables[nameof (lstClassCodes)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.lstClassCodesDataTable(dataSet.Tables[nameof (lstClassCodes)]));
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (lstWCLimits)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.lstWCLimitsDataTable(dataSet.Tables[nameof (lstWCLimits)]));
        if (dataSet.Tables[nameof (tblWCPolicyInfo)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.tblWCPolicyInfoDataTable(dataSet.Tables[nameof (tblWCPolicyInfo)]));
        if (dataSet.Tables[nameof (NetRate_Quote_Insur_Quote_Locat)] != null)
          base.Tables.Add((DataTable) new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable(dataSet.Tables[nameof (NetRate_Quote_Insur_Quote_Locat)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.tblGenericWCExposuresDataTable tblGenericWCExposures
  {
    get => this.tabletblGenericWCExposures;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.lstClassCodesDataTable lstClassCodes => this.tablelstClassCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.lstWCLimitsDataTable lstWCLimits => this.tablelstWCLimits;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.tblWCPolicyInfoDataTable tblWCPolicyInfo => this.tabletblWCPolicyInfo;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable NetRate_Quote_Insur_Quote_Locat
  {
    get => this.tableNetRate_Quote_Insur_Quote_Locat;
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
    dsWCExposureCapture wcExposureCapture = (dsWCExposureCapture) base.Clone();
    wcExposureCapture.InitVars();
    wcExposureCapture.InitExpressions();
    wcExposureCapture.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) wcExposureCapture;
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
      if (dataSet.Tables["tblGenericWCExposures"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.tblGenericWCExposuresDataTable(dataSet.Tables["tblGenericWCExposures"]));
      if (dataSet.Tables["lstClassCodes"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.lstClassCodesDataTable(dataSet.Tables["lstClassCodes"]));
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["lstWCLimits"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.lstWCLimitsDataTable(dataSet.Tables["lstWCLimits"]));
      if (dataSet.Tables["tblWCPolicyInfo"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.tblWCPolicyInfoDataTable(dataSet.Tables["tblWCPolicyInfo"]));
      if (dataSet.Tables["NetRate_Quote_Insur_Quote_Locat"] != null)
        base.Tables.Add((DataTable) new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable(dataSet.Tables["NetRate_Quote_Insur_Quote_Locat"]));
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
    this.tabletblGenericWCExposures = (dsWCExposureCapture.tblGenericWCExposuresDataTable) base.Tables["tblGenericWCExposures"];
    if (initTable && this.tabletblGenericWCExposures != null)
      this.tabletblGenericWCExposures.InitVars();
    this.tablelstClassCodes = (dsWCExposureCapture.lstClassCodesDataTable) base.Tables["lstClassCodes"];
    if (initTable && this.tablelstClassCodes != null)
      this.tablelstClassCodes.InitVars();
    this.tabletblUnderwritingLocations = (dsWCExposureCapture.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tablelstStates = (dsWCExposureCapture.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tablelstWCLimits = (dsWCExposureCapture.lstWCLimitsDataTable) base.Tables["lstWCLimits"];
    if (initTable && this.tablelstWCLimits != null)
      this.tablelstWCLimits.InitVars();
    this.tabletblWCPolicyInfo = (dsWCExposureCapture.tblWCPolicyInfoDataTable) base.Tables["tblWCPolicyInfo"];
    if (initTable && this.tabletblWCPolicyInfo != null)
      this.tabletblWCPolicyInfo.InitVars();
    this.tableNetRate_Quote_Insur_Quote_Locat = (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable) base.Tables["NetRate_Quote_Insur_Quote_Locat"];
    if (!initTable || this.tableNetRate_Quote_Insur_Quote_Locat == null)
      return;
    this.tableNetRate_Quote_Insur_Quote_Locat.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsWCExposureCapture);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsWCExposureCapture.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblGenericWCExposures = new dsWCExposureCapture.tblGenericWCExposuresDataTable();
    base.Tables.Add((DataTable) this.tabletblGenericWCExposures);
    this.tablelstClassCodes = new dsWCExposureCapture.lstClassCodesDataTable(false);
    base.Tables.Add((DataTable) this.tablelstClassCodes);
    this.tabletblUnderwritingLocations = new dsWCExposureCapture.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tablelstStates = new dsWCExposureCapture.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tablelstWCLimits = new dsWCExposureCapture.lstWCLimitsDataTable();
    base.Tables.Add((DataTable) this.tablelstWCLimits);
    this.tabletblWCPolicyInfo = new dsWCExposureCapture.tblWCPolicyInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblWCPolicyInfo);
    this.tableNetRate_Quote_Insur_Quote_Locat = new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable();
    base.Tables.Add((DataTable) this.tableNetRate_Quote_Insur_Quote_Locat);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblGenericWCExposures() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstClassCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstWCLimits() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblWCPolicyInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeNetRate_Quote_Insur_Quote_Locat() => false;

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
    dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = wcExposureCapture.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitExpressions()
  {
    this.lstClassCodes.ClassCodeKeyColumn.Expression = "ClassCodeID + ClassCode";
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblGenericWCExposuresRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.tblGenericWCExposuresRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstClassCodesRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.lstClassCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstWCLimitsRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.lstWCLimitsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblWCPolicyInfoRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.tblWCPolicyInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler(
    object sender,
    dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblGenericWCExposuresDataTable : 
    TypedTableBase<dsWCExposureCapture.tblGenericWCExposuresRow>
  {
    private DataColumn columnWorkCompID;
    private DataColumn columnQuoteID;
    private DataColumn columnDescription;
    private DataColumn columnRate;
    private DataColumn columnRenumeration;
    private DataColumn columnStateID;
    private DataColumn columnLocationID;
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCode;
    private DataColumn columnEffectiveRateOfClass;
    private DataColumn columnNoOfEmployees;
    private DataColumn columnExpectedIndemnityClaims;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblGenericWCExposuresDataTable()
    {
      this.TableName = "tblGenericWCExposures";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblGenericWCExposuresDataTable(DataTable table)
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
    protected tblGenericWCExposuresDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WorkCompIDColumn => this.columnWorkCompID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RateColumn => this.columnRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RenumerationColumn => this.columnRenumeration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveRateOfClassColumn => this.columnEffectiveRateOfClass;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoOfEmployeesColumn => this.columnNoOfEmployees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpectedIndemnityClaimsColumn => this.columnExpectedIndemnityClaims;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblGenericWCExposuresRow this[int index]
    {
      get => (dsWCExposureCapture.tblGenericWCExposuresRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler tblGenericWCExposuresRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler tblGenericWCExposuresRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler tblGenericWCExposuresRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler tblGenericWCExposuresRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblGenericWCExposuresRow(dsWCExposureCapture.tblGenericWCExposuresRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblGenericWCExposuresRow AddtblGenericWCExposuresRow(
      int QuoteID,
      string Description,
      Decimal Rate,
      Decimal Renumeration,
      string StateID,
      int LocationID,
      int ClassCodeID,
      string ClassCode,
      Decimal EffectiveRateOfClass,
      int NoOfEmployees,
      int ExpectedIndemnityClaims)
    {
      dsWCExposureCapture.tblGenericWCExposuresRow row = (dsWCExposureCapture.tblGenericWCExposuresRow) this.NewRow();
      object[] objArray = new object[12]
      {
        null,
        (object) QuoteID,
        (object) Description,
        (object) Rate,
        (object) Renumeration,
        (object) StateID,
        (object) LocationID,
        (object) ClassCodeID,
        (object) ClassCode,
        (object) EffectiveRateOfClass,
        (object) NoOfEmployees,
        (object) ExpectedIndemnityClaims
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblGenericWCExposuresRow FindByWorkCompID(int WorkCompID)
    {
      return (dsWCExposureCapture.tblGenericWCExposuresRow) this.Rows.Find(new object[1]
      {
        (object) WorkCompID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.tblGenericWCExposuresDataTable exposuresDataTable = (dsWCExposureCapture.tblGenericWCExposuresDataTable) base.Clone();
      exposuresDataTable.InitVars();
      return (DataTable) exposuresDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.tblGenericWCExposuresDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnWorkCompID = this.Columns["WorkCompID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnDescription = this.Columns["Description"];
      this.columnRate = this.Columns["Rate"];
      this.columnRenumeration = this.Columns["Renumeration"];
      this.columnStateID = this.Columns["StateID"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnEffectiveRateOfClass = this.Columns["EffectiveRateOfClass"];
      this.columnNoOfEmployees = this.Columns["NoOfEmployees"];
      this.columnExpectedIndemnityClaims = this.Columns["ExpectedIndemnityClaims"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnWorkCompID = new DataColumn("WorkCompID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWorkCompID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnRate = new DataColumn("Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
      this.columnRenumeration = new DataColumn("Renumeration", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenumeration);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnEffectiveRateOfClass = new DataColumn("EffectiveRateOfClass", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveRateOfClass);
      this.columnNoOfEmployees = new DataColumn("NoOfEmployees", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoOfEmployees);
      this.columnExpectedIndemnityClaims = new DataColumn("ExpectedIndemnityClaims", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpectedIndemnityClaims);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnWorkCompID
      }, true));
      this.columnWorkCompID.AutoIncrement = true;
      this.columnWorkCompID.AutoIncrementSeed = -1L;
      this.columnWorkCompID.AutoIncrementStep = -1L;
      this.columnWorkCompID.AllowDBNull = false;
      this.columnWorkCompID.ReadOnly = true;
      this.columnWorkCompID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnDescription.AutoIncrementSeed = -1L;
      this.columnDescription.AutoIncrementStep = -1L;
      this.columnRate.AutoIncrementSeed = -1L;
      this.columnRate.AutoIncrementStep = -1L;
      this.columnRenumeration.AutoIncrementSeed = -1L;
      this.columnRenumeration.AutoIncrementStep = -1L;
      this.columnStateID.AutoIncrementSeed = -1L;
      this.columnStateID.AutoIncrementStep = -1L;
      this.columnClassCode.MaxLength = 5;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblGenericWCExposuresRow NewtblGenericWCExposuresRow()
    {
      return (dsWCExposureCapture.tblGenericWCExposuresRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.tblGenericWCExposuresRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsWCExposureCapture.tblGenericWCExposuresRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericWCExposuresRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler exposuresRowChangedEvent = this.tblGenericWCExposuresRowChangedEvent;
      if (exposuresRowChangedEvent == null)
        return;
      exposuresRowChangedEvent((object) this, new dsWCExposureCapture.tblGenericWCExposuresRowChangeEvent((dsWCExposureCapture.tblGenericWCExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericWCExposuresRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler rowChangingEvent = this.tblGenericWCExposuresRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.tblGenericWCExposuresRowChangeEvent((dsWCExposureCapture.tblGenericWCExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericWCExposuresRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler exposuresRowDeletedEvent = this.tblGenericWCExposuresRowDeletedEvent;
      if (exposuresRowDeletedEvent == null)
        return;
      exposuresRowDeletedEvent((object) this, new dsWCExposureCapture.tblGenericWCExposuresRowChangeEvent((dsWCExposureCapture.tblGenericWCExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericWCExposuresRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblGenericWCExposuresRowChangeEventHandler rowDeletingEvent = this.tblGenericWCExposuresRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.tblGenericWCExposuresRowChangeEvent((dsWCExposureCapture.tblGenericWCExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblGenericWCExposuresRow(dsWCExposureCapture.tblGenericWCExposuresRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGenericWCExposuresDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  public class lstClassCodesDataTable : TypedTableBase<dsWCExposureCapture.lstClassCodesRow>
  {
    private DataColumn columnClassCode;
    private DataColumn columnClassCodeDescription;
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCodeKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClassCodesDataTable()
      : this(false)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClassCodesDataTable(bool initExpressions)
    {
      this.TableName = "lstClassCodes";
      this.BeginInit();
      this.InitClass();
      if (initExpressions)
        this.InitExpressions();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClassCodesDataTable(DataTable table)
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
    protected lstClassCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeKeyColumn => this.columnClassCodeKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstClassCodesRow this[int index]
    {
      get => (dsWCExposureCapture.lstClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstClassCodesRowChangeEventHandler lstClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstClassCodesRowChangeEventHandler lstClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstClassCodesRow(dsWCExposureCapture.lstClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstClassCodesRow AddlstClassCodesRow(
      string ClassCode,
      string ClassCodeDescription,
      long ClassCodeID,
      string ClassCodeKey)
    {
      dsWCExposureCapture.lstClassCodesRow row = (dsWCExposureCapture.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ClassCode,
        (object) ClassCodeDescription,
        (object) ClassCodeID,
        (object) ClassCodeKey
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstClassCodesRow AddlstClassCodesRow(
      string ClassCode,
      string ClassCodeDescription,
      long ClassCodeID)
    {
      dsWCExposureCapture.lstClassCodesRow row = (dsWCExposureCapture.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ClassCode,
        (object) ClassCodeDescription,
        (object) ClassCodeID,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.lstClassCodesDataTable classCodesDataTable = (dsWCExposureCapture.lstClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.lstClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCodeKey = this.Columns["ClassCodeKey"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCodeKey = new DataColumn("ClassCodeKey", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeKey);
      this.columnClassCode.AllowDBNull = false;
      this.columnClassCode.MaxLength = 5;
      this.columnClassCodeDescription.AllowDBNull = false;
      this.columnClassCodeDescription.MaxLength = 200;
      this.columnClassCodeKey.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstClassCodesRow NewlstClassCodesRow()
    {
      return (dsWCExposureCapture.lstClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.lstClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsWCExposureCapture.lstClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitExpressions()
    {
      this.ClassCodeKeyColumn.Expression = "ClassCodeID + ClassCode";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstClassCodesRowChangeEventHandler codesRowChangedEvent = this.lstClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsWCExposureCapture.lstClassCodesRowChangeEvent((dsWCExposureCapture.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstClassCodesRowChangeEventHandler rowChangingEvent = this.lstClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.lstClassCodesRowChangeEvent((dsWCExposureCapture.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstClassCodesRowChangeEventHandler codesRowDeletedEvent = this.lstClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsWCExposureCapture.lstClassCodesRowChangeEvent((dsWCExposureCapture.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstClassCodesRowChangeEventHandler rowDeletingEvent = this.lstClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.lstClassCodesRowChangeEvent((dsWCExposureCapture.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstClassCodesRow(dsWCExposureCapture.lstClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsWCExposureCapture.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnLocationNo;
    private DataColumn columnBuildingNo;
    private DataColumn columnPhysicalBuildingNo;
    private DataColumn columnAddress;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnModificationCode;
    private DataColumn columnNetRateLoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUnderwritingLocationsDataTable(DataTable table)
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
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhysicalBuildingNoColumn => this.columnPhysicalBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

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
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NetRateLocColumn => this.columnNetRateLoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsWCExposureCapture.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUnderwritingLocationsRow(
      dsWCExposureCapture.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      int LocationNo,
      string BuildingNo,
      string PhysicalBuildingNo,
      string Address,
      string City,
      string State,
      string Zip,
      string ModificationCode,
      bool NetRateLoc)
    {
      dsWCExposureCapture.tblUnderwritingLocationsRow row = (dsWCExposureCapture.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[10]
      {
        null,
        (object) LocationNo,
        (object) BuildingNo,
        (object) PhysicalBuildingNo,
        (object) Address,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ModificationCode,
        (object) NetRateLoc
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsWCExposureCapture.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.tblUnderwritingLocationsDataTable locationsDataTable = (dsWCExposureCapture.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnPhysicalBuildingNo = this.Columns["PhysicalBuildingNo"];
      this.columnAddress = this.Columns["Address"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnModificationCode = this.Columns["ModificationCode"];
      this.columnNetRateLoc = this.Columns["NetRateLoc"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnPhysicalBuildingNo = new DataColumn("PhysicalBuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysicalBuildingNo);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.columnNetRateLoc = new DataColumn("NetRateLoc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetRateLoc);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnLocationNo.AllowDBNull = false;
      this.columnPhysicalBuildingNo.AllowDBNull = false;
      this.columnAddress.ReadOnly = true;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnZip.AllowDBNull = false;
      this.columnNetRateLoc.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsWCExposureCapture.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsWCExposureCapture.tblUnderwritingLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsWCExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsWCExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsWCExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsWCExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsWCExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsWCExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(
      dsWCExposureCapture.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsWCExposureCapture.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatesDataTable(DataTable table)
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
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstStatesRow this[int index]
    {
      get => (dsWCExposureCapture.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatesRow(dsWCExposureCapture.lstStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsWCExposureCapture.lstStatesRow row = (dsWCExposureCapture.lstStatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) StateID,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstStatesRow FindByStateID(string StateID)
    {
      return (dsWCExposureCapture.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.lstStatesDataTable lstStatesDataTable = (dsWCExposureCapture.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnStateID.MaxLength = 2;
      this.columnState.AllowDBNull = false;
      this.columnState.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstStatesRow NewlstStatesRow()
    {
      return (dsWCExposureCapture.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsWCExposureCapture.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsWCExposureCapture.lstStatesRowChangeEvent((dsWCExposureCapture.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.lstStatesRowChangeEvent((dsWCExposureCapture.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsWCExposureCapture.lstStatesRowChangeEvent((dsWCExposureCapture.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.lstStatesRowChangeEvent((dsWCExposureCapture.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatesRow(dsWCExposureCapture.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  public class lstWCLimitsDataTable : TypedTableBase<dsWCExposureCapture.lstWCLimitsRow>
  {
    private DataColumn columnWCLimitsID;
    private DataColumn columnWCLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstWCLimitsDataTable()
    {
      this.TableName = "lstWCLimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstWCLimitsDataTable(DataTable table)
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
    protected lstWCLimitsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WCLimitsIDColumn => this.columnWCLimitsID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WCLimitsColumn => this.columnWCLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstWCLimitsRow this[int index]
    {
      get => (dsWCExposureCapture.lstWCLimitsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstWCLimitsRowChangeEventHandler lstWCLimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstWCLimitsRowChangeEventHandler lstWCLimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstWCLimitsRowChangeEventHandler lstWCLimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.lstWCLimitsRowChangeEventHandler lstWCLimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstWCLimitsRow(dsWCExposureCapture.lstWCLimitsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstWCLimitsRow AddlstWCLimitsRow(string WCLimits)
    {
      dsWCExposureCapture.lstWCLimitsRow row = (dsWCExposureCapture.lstWCLimitsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) WCLimits
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstWCLimitsRow FindByWCLimitsID(int WCLimitsID)
    {
      return (dsWCExposureCapture.lstWCLimitsRow) this.Rows.Find(new object[1]
      {
        (object) WCLimitsID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.lstWCLimitsDataTable wcLimitsDataTable = (dsWCExposureCapture.lstWCLimitsDataTable) base.Clone();
      wcLimitsDataTable.InitVars();
      return (DataTable) wcLimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.lstWCLimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnWCLimitsID = this.Columns["WCLimitsID"];
      this.columnWCLimits = this.Columns["WCLimits"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnWCLimitsID = new DataColumn("WCLimitsID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWCLimitsID);
      this.columnWCLimits = new DataColumn("WCLimits", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWCLimits);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnWCLimitsID
      }, true));
      this.columnWCLimitsID.AutoIncrement = true;
      this.columnWCLimitsID.AutoIncrementSeed = -1L;
      this.columnWCLimitsID.AutoIncrementStep = -1L;
      this.columnWCLimitsID.AllowDBNull = false;
      this.columnWCLimitsID.ReadOnly = true;
      this.columnWCLimitsID.Unique = true;
      this.columnWCLimits.AllowDBNull = false;
      this.columnWCLimits.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstWCLimitsRow NewlstWCLimitsRow()
    {
      return (dsWCExposureCapture.lstWCLimitsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.lstWCLimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsWCExposureCapture.lstWCLimitsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWCLimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstWCLimitsRowChangeEventHandler limitsRowChangedEvent = this.lstWCLimitsRowChangedEvent;
      if (limitsRowChangedEvent == null)
        return;
      limitsRowChangedEvent((object) this, new dsWCExposureCapture.lstWCLimitsRowChangeEvent((dsWCExposureCapture.lstWCLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWCLimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstWCLimitsRowChangeEventHandler rowChangingEvent = this.lstWCLimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.lstWCLimitsRowChangeEvent((dsWCExposureCapture.lstWCLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWCLimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstWCLimitsRowChangeEventHandler limitsRowDeletedEvent = this.lstWCLimitsRowDeletedEvent;
      if (limitsRowDeletedEvent == null)
        return;
      limitsRowDeletedEvent((object) this, new dsWCExposureCapture.lstWCLimitsRowChangeEvent((dsWCExposureCapture.lstWCLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWCLimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.lstWCLimitsRowChangeEventHandler rowDeletingEvent = this.lstWCLimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.lstWCLimitsRowChangeEvent((dsWCExposureCapture.lstWCLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstWCLimitsRow(dsWCExposureCapture.lstWCLimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstWCLimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  public class tblWCPolicyInfoDataTable : TypedTableBase<dsWCExposureCapture.tblWCPolicyInfoRow>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnWCLimit;
    private DataColumn columnDeductible;
    private DataColumn columnExperienceMod;
    private DataColumn columnScheduleRating;
    private DataColumn columnScheduledMod;
    private DataColumn columnIncurredLoss;
    private DataColumn columnNoOfMedical;
    private DataColumn columnNoOfIndemnity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblWCPolicyInfoDataTable()
    {
      this.TableName = "tblWCPolicyInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblWCPolicyInfoDataTable(DataTable table)
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
    protected tblWCPolicyInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WCLimitColumn => this.columnWCLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExperienceModColumn => this.columnExperienceMod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ScheduleRatingColumn => this.columnScheduleRating;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ScheduledModColumn => this.columnScheduledMod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IncurredLossColumn => this.columnIncurredLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoOfMedicalColumn => this.columnNoOfMedical;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoOfIndemnityColumn => this.columnNoOfIndemnity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblWCPolicyInfoRow this[int index]
    {
      get => (dsWCExposureCapture.tblWCPolicyInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler tblWCPolicyInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler tblWCPolicyInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler tblWCPolicyInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler tblWCPolicyInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblWCPolicyInfoRow(dsWCExposureCapture.tblWCPolicyInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblWCPolicyInfoRow AddtblWCPolicyInfoRow(
      int QuoteID,
      string WCLimit,
      string Deductible,
      string ExperienceMod,
      string ScheduleRating,
      string ScheduledMod,
      string IncurredLoss,
      string NoOfMedical,
      string NoOfIndemnity)
    {
      dsWCExposureCapture.tblWCPolicyInfoRow row = (dsWCExposureCapture.tblWCPolicyInfoRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) QuoteID,
        (object) WCLimit,
        (object) Deductible,
        (object) ExperienceMod,
        (object) ScheduleRating,
        (object) ScheduledMod,
        (object) IncurredLoss,
        (object) NoOfMedical,
        (object) NoOfIndemnity
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblWCPolicyInfoRow FindByQuoteID(int QuoteID)
    {
      return (dsWCExposureCapture.tblWCPolicyInfoRow) this.Rows.Find(new object[1]
      {
        (object) QuoteID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.tblWCPolicyInfoDataTable policyInfoDataTable = (dsWCExposureCapture.tblWCPolicyInfoDataTable) base.Clone();
      policyInfoDataTable.InitVars();
      return (DataTable) policyInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.tblWCPolicyInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnWCLimit = this.Columns["WCLimit"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnExperienceMod = this.Columns["ExperienceMod"];
      this.columnScheduleRating = this.Columns["ScheduleRating"];
      this.columnScheduledMod = this.Columns["ScheduledMod"];
      this.columnIncurredLoss = this.Columns["IncurredLoss"];
      this.columnNoOfMedical = this.Columns["NoOfMedical"];
      this.columnNoOfIndemnity = this.Columns["NoOfIndemnity"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnWCLimit = new DataColumn("WCLimit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWCLimit);
      this.columnDeductible = new DataColumn("Deductible", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnExperienceMod = new DataColumn("ExperienceMod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExperienceMod);
      this.columnScheduleRating = new DataColumn("ScheduleRating", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnScheduleRating);
      this.columnScheduledMod = new DataColumn("ScheduledMod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnScheduledMod);
      this.columnIncurredLoss = new DataColumn("IncurredLoss", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncurredLoss);
      this.columnNoOfMedical = new DataColumn("NoOfMedical", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoOfMedical);
      this.columnNoOfIndemnity = new DataColumn("NoOfIndemnity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoOfIndemnity);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnQuoteID.Unique = true;
      this.columnDeductible.MaxLength = 50;
      this.columnExperienceMod.MaxLength = 50;
      this.columnScheduleRating.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblWCPolicyInfoRow NewtblWCPolicyInfoRow()
    {
      return (dsWCExposureCapture.tblWCPolicyInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.tblWCPolicyInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsWCExposureCapture.tblWCPolicyInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWCPolicyInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler infoRowChangedEvent = this.tblWCPolicyInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsWCExposureCapture.tblWCPolicyInfoRowChangeEvent((dsWCExposureCapture.tblWCPolicyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWCPolicyInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler rowChangingEvent = this.tblWCPolicyInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.tblWCPolicyInfoRowChangeEvent((dsWCExposureCapture.tblWCPolicyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWCPolicyInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler infoRowDeletedEvent = this.tblWCPolicyInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsWCExposureCapture.tblWCPolicyInfoRowChangeEvent((dsWCExposureCapture.tblWCPolicyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWCPolicyInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.tblWCPolicyInfoRowChangeEventHandler rowDeletingEvent = this.tblWCPolicyInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.tblWCPolicyInfoRowChangeEvent((dsWCExposureCapture.tblWCPolicyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblWCPolicyInfoRow(dsWCExposureCapture.tblWCPolicyInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblWCPolicyInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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
  public class NetRate_Quote_Insur_Quote_LocatDataTable : 
    TypedTableBase<dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnQuoteID;
    private DataColumn columnUnitNumber;
    private DataColumn columnState;
    private DataColumn columnAddress;
    private DataColumn columnZipCode;
    private DataColumn columnCity;
    private DataColumn columnP_O_Box;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public NetRate_Quote_Insur_Quote_LocatDataTable()
    {
      this.TableName = "NetRate_Quote_Insur_Quote_Locat";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal NetRate_Quote_Insur_Quote_LocatDataTable(DataTable table)
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
    protected NetRate_Quote_Insur_Quote_LocatDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnitNumberColumn => this.columnUnitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn P_O_BoxColumn => this.columnP_O_Box;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow this[int index]
    {
      get => (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler NetRate_Quote_Insur_Quote_LocatRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler NetRate_Quote_Insur_Quote_LocatRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler NetRate_Quote_Insur_Quote_LocatRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler NetRate_Quote_Insur_Quote_LocatRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddNetRate_Quote_Insur_Quote_LocatRow(
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow AddNetRate_Quote_Insur_Quote_LocatRow(
      int QuoteID,
      int UnitNumber,
      string State,
      string Address,
      string ZipCode,
      string City,
      string P_O_Box)
    {
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow row = (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) this.NewRow();
      object[] objArray = new object[8]
      {
        null,
        (object) QuoteID,
        (object) UnitNumber,
        (object) State,
        (object) Address,
        (object) ZipCode,
        (object) City,
        (object) P_O_Box
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow FindByLocationID(int LocationID)
    {
      return (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable quoteLocatDataTable = (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable) base.Clone();
      quoteLocatDataTable.InitVars();
      return (DataTable) quoteLocatDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnUnitNumber = this.Columns["UnitNumber"];
      this.columnState = this.Columns["State"];
      this.columnAddress = this.Columns["Address"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnCity = this.Columns["City"];
      this.columnP_O_Box = this.Columns["P_O_Box"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnUnitNumber = new DataColumn("UnitNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnitNumber);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnP_O_Box = new DataColumn("P_O_Box", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnP_O_Box);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AutoIncrementSeed = -1L;
      this.columnLocationID.AutoIncrementStep = -1L;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnState.MaxLength = 100;
      this.columnAddress.MaxLength = 700;
      this.columnZipCode.MaxLength = 20;
      this.columnCity.MaxLength = 100;
      this.columnP_O_Box.MaxLength = 500;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow NewNetRate_Quote_Insur_Quote_LocatRow()
    {
      return (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRate_Quote_Insur_Quote_LocatRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler locatRowChangedEvent = this.NetRate_Quote_Insur_Quote_LocatRowChangedEvent;
      if (locatRowChangedEvent == null)
        return;
      locatRowChangedEvent((object) this, new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEvent((dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRate_Quote_Insur_Quote_LocatRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler rowChangingEvent = this.NetRate_Quote_Insur_Quote_LocatRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEvent((dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRate_Quote_Insur_Quote_LocatRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler locatRowDeletedEvent = this.NetRate_Quote_Insur_Quote_LocatRowDeletedEvent;
      if (locatRowDeletedEvent == null)
        return;
      locatRowDeletedEvent((object) this, new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEvent((dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRate_Quote_Insur_Quote_LocatRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEventHandler rowDeletingEvent = this.NetRate_Quote_Insur_Quote_LocatRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRowChangeEvent((dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveNetRate_Quote_Insur_Quote_LocatRow(
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWCExposureCapture wcExposureCapture = new dsWCExposureCapture();
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
        FixedValue = wcExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (NetRate_Quote_Insur_Quote_LocatDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = wcExposureCapture.GetSchemaSerializable();
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

  public class tblGenericWCExposuresRow : DataRow
  {
    private dsWCExposureCapture.tblGenericWCExposuresDataTable tabletblGenericWCExposures;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblGenericWCExposuresRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGenericWCExposures = (dsWCExposureCapture.tblGenericWCExposuresDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int WorkCompID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericWCExposures.WorkCompIDColumn]);
      set => this[this.tabletblGenericWCExposures.WorkCompIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericWCExposures.QuoteIDColumn]);
      set => this[this.tabletblGenericWCExposures.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericWCExposures.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Rate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGenericWCExposures.RateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Rate' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Renumeration
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGenericWCExposures.RenumerationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Renumeration' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.RenumerationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericWCExposures.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericWCExposures.LocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationID' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ClassCodeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericWCExposures.ClassCodeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeID' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClassCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericWCExposures.ClassCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCode' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal EffectiveRateOfClass
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGenericWCExposures.EffectiveRateOfClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveRateOfClass' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.EffectiveRateOfClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NoOfEmployees
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericWCExposures.NoOfEmployeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoOfEmployees' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.NoOfEmployeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ExpectedIndemnityClaims
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericWCExposures.ExpectedIndemnityClaimsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpectedIndemnityClaims' in table 'tblGenericWCExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericWCExposures.ExpectedIndemnityClaimsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblGenericWCExposures.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblGenericWCExposures.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRateNull() => this.IsNull(this.tabletblGenericWCExposures.RateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRateNull()
    {
      this[this.tabletblGenericWCExposures.RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRenumerationNull()
    {
      return this.IsNull(this.tabletblGenericWCExposures.RenumerationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRenumerationNull()
    {
      this[this.tabletblGenericWCExposures.RenumerationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblGenericWCExposures.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblGenericWCExposures.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationIDNull() => this.IsNull(this.tabletblGenericWCExposures.LocationIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationIDNull()
    {
      this[this.tabletblGenericWCExposures.LocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClassCodeIDNull()
    {
      return this.IsNull(this.tabletblGenericWCExposures.ClassCodeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClassCodeIDNull()
    {
      this[this.tabletblGenericWCExposures.ClassCodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClassCodeNull() => this.IsNull(this.tabletblGenericWCExposures.ClassCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClassCodeNull()
    {
      this[this.tabletblGenericWCExposures.ClassCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveRateOfClassNull()
    {
      return this.IsNull(this.tabletblGenericWCExposures.EffectiveRateOfClassColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveRateOfClassNull()
    {
      this[this.tabletblGenericWCExposures.EffectiveRateOfClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNoOfEmployeesNull()
    {
      return this.IsNull(this.tabletblGenericWCExposures.NoOfEmployeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNoOfEmployeesNull()
    {
      this[this.tabletblGenericWCExposures.NoOfEmployeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpectedIndemnityClaimsNull()
    {
      return this.IsNull(this.tabletblGenericWCExposures.ExpectedIndemnityClaimsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpectedIndemnityClaimsNull()
    {
      this[this.tabletblGenericWCExposures.ExpectedIndemnityClaimsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstClassCodesRow : DataRow
  {
    private dsWCExposureCapture.lstClassCodesDataTable tablelstClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClassCodes = (dsWCExposureCapture.lstClassCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClassCode
    {
      get => Conversions.ToString(this[this.tablelstClassCodes.ClassCodeColumn]);
      set => this[this.tablelstClassCodes.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClassCodeDescription
    {
      get => Conversions.ToString(this[this.tablelstClassCodes.ClassCodeDescriptionColumn]);
      set => this[this.tablelstClassCodes.ClassCodeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public long ClassCodeID
    {
      get
      {
        try
        {
          return Conversions.ToLong(this[this.tablelstClassCodes.ClassCodeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeID' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClassCodeKey
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClassCodes.ClassCodeKeyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeKey' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.ClassCodeKeyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClassCodeIDNull() => this.IsNull(this.tablelstClassCodes.ClassCodeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClassCodeIDNull()
    {
      this[this.tablelstClassCodes.ClassCodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClassCodeKeyNull() => this.IsNull(this.tablelstClassCodes.ClassCodeKeyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClassCodeKeyNull()
    {
      this[this.tablelstClassCodes.ClassCodeKeyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsWCExposureCapture.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsWCExposureCapture.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationNo
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationNoColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BuildingNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.BuildingNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BuildingNo' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PhysicalBuildingNo
    {
      get
      {
        return Conversions.ToString(this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn]);
      }
      set => this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipColumn]);
      set => this[this.tabletblUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ModificationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ModificationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModificationCode' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool NetRateLoc
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.NetRateLocColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetRateLoc' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.NetRateLocColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBuildingNoNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.BuildingNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBuildingNoNull()
    {
      this[this.tabletblUnderwritingLocations.BuildingNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tabletblUnderwritingLocations.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tabletblUnderwritingLocations.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsModificationCodeNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ModificationCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetModificationCodeNull()
    {
      this[this.tabletblUnderwritingLocations.ModificationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNetRateLocNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.NetRateLocColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNetRateLocNull()
    {
      this[this.tabletblUnderwritingLocations.NetRateLocColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsWCExposureCapture.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsWCExposureCapture.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }
  }

  public class lstWCLimitsRow : DataRow
  {
    private dsWCExposureCapture.lstWCLimitsDataTable tablelstWCLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstWCLimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstWCLimits = (dsWCExposureCapture.lstWCLimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int WCLimitsID
    {
      get => Conversions.ToInteger(this[this.tablelstWCLimits.WCLimitsIDColumn]);
      set => this[this.tablelstWCLimits.WCLimitsIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string WCLimits
    {
      get => Conversions.ToString(this[this.tablelstWCLimits.WCLimitsColumn]);
      set => this[this.tablelstWCLimits.WCLimitsColumn] = (object) value;
    }
  }

  public class tblWCPolicyInfoRow : DataRow
  {
    private dsWCExposureCapture.tblWCPolicyInfoDataTable tabletblWCPolicyInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblWCPolicyInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblWCPolicyInfo = (dsWCExposureCapture.tblWCPolicyInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblWCPolicyInfo.QuoteIDColumn]);
      set => this[this.tabletblWCPolicyInfo.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string WCLimit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.WCLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WCLimit' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.WCLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Deductible
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ExperienceMod
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.ExperienceModColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExperienceMod' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.ExperienceModColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ScheduleRating
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.ScheduleRatingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ScheduleRating' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.ScheduleRatingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ScheduledMod
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.ScheduledModColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ScheduledMod' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.ScheduledModColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string IncurredLoss
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.IncurredLossColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncurredLoss' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.IncurredLossColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NoOfMedical
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.NoOfMedicalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoOfMedical' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.NoOfMedicalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NoOfIndemnity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblWCPolicyInfo.NoOfIndemnityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoOfIndemnity' in table 'tblWCPolicyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWCPolicyInfo.NoOfIndemnityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWCLimitNull() => this.IsNull(this.tabletblWCPolicyInfo.WCLimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWCLimitNull()
    {
      this[this.tabletblWCPolicyInfo.WCLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeductibleNull() => this.IsNull(this.tabletblWCPolicyInfo.DeductibleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblWCPolicyInfo.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExperienceModNull() => this.IsNull(this.tabletblWCPolicyInfo.ExperienceModColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExperienceModNull()
    {
      this[this.tabletblWCPolicyInfo.ExperienceModColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsScheduleRatingNull()
    {
      return this.IsNull(this.tabletblWCPolicyInfo.ScheduleRatingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetScheduleRatingNull()
    {
      this[this.tabletblWCPolicyInfo.ScheduleRatingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsScheduledModNull() => this.IsNull(this.tabletblWCPolicyInfo.ScheduledModColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetScheduledModNull()
    {
      this[this.tabletblWCPolicyInfo.ScheduledModColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIncurredLossNull() => this.IsNull(this.tabletblWCPolicyInfo.IncurredLossColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIncurredLossNull()
    {
      this[this.tabletblWCPolicyInfo.IncurredLossColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNoOfMedicalNull() => this.IsNull(this.tabletblWCPolicyInfo.NoOfMedicalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNoOfMedicalNull()
    {
      this[this.tabletblWCPolicyInfo.NoOfMedicalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNoOfIndemnityNull() => this.IsNull(this.tabletblWCPolicyInfo.NoOfIndemnityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNoOfIndemnityNull()
    {
      this[this.tabletblWCPolicyInfo.NoOfIndemnityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class NetRate_Quote_Insur_Quote_LocatRow : DataRow
  {
    private dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable tableNetRate_Quote_Insur_Quote_Locat;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal NetRate_Quote_Insur_Quote_LocatRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableNetRate_Quote_Insur_Quote_Locat = (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationID
    {
      get
      {
        return Conversions.ToInteger(this[this.tableNetRate_Quote_Insur_Quote_Locat.LocationIDColumn]);
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tableNetRate_Quote_Insur_Quote_Locat.QuoteIDColumn]);
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int UnitNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableNetRate_Quote_Insur_Quote_Locat.UnitNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnitNumber' in table 'NetRate_Quote_Insur_Quote_Locat' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.UnitNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRate_Quote_Insur_Quote_Locat.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'NetRate_Quote_Insur_Quote_Locat' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRate_Quote_Insur_Quote_Locat.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'NetRate_Quote_Insur_Quote_Locat' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRate_Quote_Insur_Quote_Locat.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'NetRate_Quote_Insur_Quote_Locat' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRate_Quote_Insur_Quote_Locat.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'NetRate_Quote_Insur_Quote_Locat' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string P_O_Box
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRate_Quote_Insur_Quote_Locat.P_O_BoxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'P_O_Box' in table 'NetRate_Quote_Insur_Quote_Locat' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRate_Quote_Insur_Quote_Locat.P_O_BoxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnitNumberNull()
    {
      return this.IsNull(this.tableNetRate_Quote_Insur_Quote_Locat.UnitNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnitNumberNull()
    {
      this[this.tableNetRate_Quote_Insur_Quote_Locat.UnitNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableNetRate_Quote_Insur_Quote_Locat.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tableNetRate_Quote_Insur_Quote_Locat.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddressNull()
    {
      return this.IsNull(this.tableNetRate_Quote_Insur_Quote_Locat.AddressColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tableNetRate_Quote_Insur_Quote_Locat.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipCodeNull()
    {
      return this.IsNull(this.tableNetRate_Quote_Insur_Quote_Locat.ZipCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tableNetRate_Quote_Insur_Quote_Locat.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableNetRate_Quote_Insur_Quote_Locat.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableNetRate_Quote_Insur_Quote_Locat.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsP_O_BoxNull()
    {
      return this.IsNull(this.tableNetRate_Quote_Insur_Quote_Locat.P_O_BoxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetP_O_BoxNull()
    {
      this[this.tableNetRate_Quote_Insur_Quote_Locat.P_O_BoxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblGenericWCExposuresRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.tblGenericWCExposuresRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblGenericWCExposuresRowChangeEvent(
      dsWCExposureCapture.tblGenericWCExposuresRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblGenericWCExposuresRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstClassCodesRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.lstClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClassCodesRowChangeEvent(
      dsWCExposureCapture.lstClassCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsWCExposureCapture.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatesRowChangeEvent(dsWCExposureCapture.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstWCLimitsRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.lstWCLimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstWCLimitsRowChangeEvent(dsWCExposureCapture.lstWCLimitsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.lstWCLimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblWCPolicyInfoRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.tblWCPolicyInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblWCPolicyInfoRowChangeEvent(
      dsWCExposureCapture.tblWCPolicyInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.tblWCPolicyInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class NetRate_Quote_Insur_Quote_LocatRowChangeEvent : EventArgs
  {
    private dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public NetRate_Quote_Insur_Quote_LocatRowChangeEvent(
      dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
