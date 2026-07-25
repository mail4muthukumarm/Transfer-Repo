// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsAdditionalInterests
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
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdditionalInterests")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdditionalInterests : DataSet
{
  private dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable tabletblQuoteAdditionalInterests;
  private dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable tabletblQuoteAdditionalInterestTypes;
  private dsAdditionalInterests.lstAdditionalInterestTypesDataTable tablelstAdditionalInterestTypes;
  private dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable tabletblQuoteAdditionalInterestsLocations;
  private dsAdditionalInterests.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsAdditionalInterests.tblNetRateLocationsDataTable tabletblNetRateLocations;
  private dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable tabletblQuoteAdditionalInterestsNetRateLocations;
  private dsAdditionalInterests.lstLinesDataTable tablelstLines;
  private dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable tabletblQuoteAdditionalInterestsNetRateVehicles;
  private dsAdditionalInterests.tblNetRateVehiclesDataTable tabletblNetRateVehicles;
  private dsAdditionalInterests.tblAdditionalInterestsDataTable tabletblAdditionalInterests;
  private dsAdditionalInterests.lstSalutationsDataTable tablelstSalutations;
  private dsAdditionalInterests.dtPreviousInterestDataTable tabledtPreviousInterest;
  private dsAdditionalInterests.dtLocIntDataTable tabledtLocInt;
  private DataRelation relationFK_lstLines_tblQuoteAdditionalInterests;
  private DataRelation relationlstAdditionalInterestTypestblQuoteAdditionalInterestTypes;
  private DataRelation relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes;
  private DataRelation relationtblUnderwritingLocationstblQuoteAdditionalInterestsLocations;
  private DataRelation relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations;
  private DataRelation relationtblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations;
  private DataRelation relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations;
  private DataRelation relationFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles;
  private DataRelation relationFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsAdditionalInterests()
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
  protected dsAdditionalInterests(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteAdditionalInterests)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable(dataSet.Tables[nameof (tblQuoteAdditionalInterests)]));
        if (dataSet.Tables[nameof (tblQuoteAdditionalInterestTypes)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable(dataSet.Tables[nameof (tblQuoteAdditionalInterestTypes)]));
        if (dataSet.Tables[nameof (lstAdditionalInterestTypes)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.lstAdditionalInterestTypesDataTable(dataSet.Tables[nameof (lstAdditionalInterestTypes)]));
        if (dataSet.Tables[nameof (tblQuoteAdditionalInterestsLocations)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable(dataSet.Tables[nameof (tblQuoteAdditionalInterestsLocations)]));
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (tblNetRateLocations)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblNetRateLocationsDataTable(dataSet.Tables[nameof (tblNetRateLocations)]));
        if (dataSet.Tables[nameof (tblQuoteAdditionalInterestsNetRateLocations)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable(dataSet.Tables[nameof (tblQuoteAdditionalInterestsNetRateLocations)]));
        if (dataSet.Tables[nameof (lstLines)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.lstLinesDataTable(dataSet.Tables[nameof (lstLines)]));
        if (dataSet.Tables[nameof (tblQuoteAdditionalInterestsNetRateVehicles)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable(dataSet.Tables[nameof (tblQuoteAdditionalInterestsNetRateVehicles)]));
        if (dataSet.Tables[nameof (tblNetRateVehicles)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblNetRateVehiclesDataTable(dataSet.Tables[nameof (tblNetRateVehicles)]));
        if (dataSet.Tables[nameof (tblAdditionalInterests)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.tblAdditionalInterestsDataTable(dataSet.Tables[nameof (tblAdditionalInterests)]));
        if (dataSet.Tables[nameof (lstSalutations)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.lstSalutationsDataTable(dataSet.Tables[nameof (lstSalutations)]));
        if (dataSet.Tables[nameof (dtPreviousInterest)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.dtPreviousInterestDataTable(dataSet.Tables[nameof (dtPreviousInterest)]));
        if (dataSet.Tables[nameof (dtLocInt)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterests.dtLocIntDataTable(dataSet.Tables[nameof (dtLocInt)]));
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
  public dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable tblQuoteAdditionalInterests
  {
    get => this.tabletblQuoteAdditionalInterests;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable tblQuoteAdditionalInterestTypes
  {
    get => this.tabletblQuoteAdditionalInterestTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.lstAdditionalInterestTypesDataTable lstAdditionalInterestTypes
  {
    get => this.tablelstAdditionalInterestTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable tblQuoteAdditionalInterestsLocations
  {
    get => this.tabletblQuoteAdditionalInterestsLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblNetRateLocationsDataTable tblNetRateLocations
  {
    get => this.tabletblNetRateLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable tblQuoteAdditionalInterestsNetRateLocations
  {
    get => this.tabletblQuoteAdditionalInterestsNetRateLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.lstLinesDataTable lstLines => this.tablelstLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable tblQuoteAdditionalInterestsNetRateVehicles
  {
    get => this.tabletblQuoteAdditionalInterestsNetRateVehicles;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblNetRateVehiclesDataTable tblNetRateVehicles
  {
    get => this.tabletblNetRateVehicles;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.tblAdditionalInterestsDataTable tblAdditionalInterests
  {
    get => this.tabletblAdditionalInterests;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.lstSalutationsDataTable lstSalutations => this.tablelstSalutations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.dtPreviousInterestDataTable dtPreviousInterest
  {
    get => this.tabledtPreviousInterest;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalInterests.dtLocIntDataTable dtLocInt => this.tabledtLocInt;

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
    dsAdditionalInterests additionalInterests = (dsAdditionalInterests) base.Clone();
    additionalInterests.InitVars();
    additionalInterests.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) additionalInterests;
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
      if (dataSet.Tables["tblQuoteAdditionalInterests"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable(dataSet.Tables["tblQuoteAdditionalInterests"]));
      if (dataSet.Tables["tblQuoteAdditionalInterestTypes"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable(dataSet.Tables["tblQuoteAdditionalInterestTypes"]));
      if (dataSet.Tables["lstAdditionalInterestTypes"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.lstAdditionalInterestTypesDataTable(dataSet.Tables["lstAdditionalInterestTypes"]));
      if (dataSet.Tables["tblQuoteAdditionalInterestsLocations"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable(dataSet.Tables["tblQuoteAdditionalInterestsLocations"]));
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["tblNetRateLocations"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblNetRateLocationsDataTable(dataSet.Tables["tblNetRateLocations"]));
      if (dataSet.Tables["tblQuoteAdditionalInterestsNetRateLocations"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable(dataSet.Tables["tblQuoteAdditionalInterestsNetRateLocations"]));
      if (dataSet.Tables["lstLines"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.lstLinesDataTable(dataSet.Tables["lstLines"]));
      if (dataSet.Tables["tblQuoteAdditionalInterestsNetRateVehicles"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable(dataSet.Tables["tblQuoteAdditionalInterestsNetRateVehicles"]));
      if (dataSet.Tables["tblNetRateVehicles"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblNetRateVehiclesDataTable(dataSet.Tables["tblNetRateVehicles"]));
      if (dataSet.Tables["tblAdditionalInterests"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.tblAdditionalInterestsDataTable(dataSet.Tables["tblAdditionalInterests"]));
      if (dataSet.Tables["lstSalutations"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.lstSalutationsDataTable(dataSet.Tables["lstSalutations"]));
      if (dataSet.Tables["dtPreviousInterest"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.dtPreviousInterestDataTable(dataSet.Tables["dtPreviousInterest"]));
      if (dataSet.Tables["dtLocInt"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterests.dtLocIntDataTable(dataSet.Tables["dtLocInt"]));
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
    this.tabletblQuoteAdditionalInterests = (dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable) base.Tables["tblQuoteAdditionalInterests"];
    if (initTable && this.tabletblQuoteAdditionalInterests != null)
      this.tabletblQuoteAdditionalInterests.InitVars();
    this.tabletblQuoteAdditionalInterestTypes = (dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable) base.Tables["tblQuoteAdditionalInterestTypes"];
    if (initTable && this.tabletblQuoteAdditionalInterestTypes != null)
      this.tabletblQuoteAdditionalInterestTypes.InitVars();
    this.tablelstAdditionalInterestTypes = (dsAdditionalInterests.lstAdditionalInterestTypesDataTable) base.Tables["lstAdditionalInterestTypes"];
    if (initTable && this.tablelstAdditionalInterestTypes != null)
      this.tablelstAdditionalInterestTypes.InitVars();
    this.tabletblQuoteAdditionalInterestsLocations = (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable) base.Tables["tblQuoteAdditionalInterestsLocations"];
    if (initTable && this.tabletblQuoteAdditionalInterestsLocations != null)
      this.tabletblQuoteAdditionalInterestsLocations.InitVars();
    this.tabletblUnderwritingLocations = (dsAdditionalInterests.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tabletblNetRateLocations = (dsAdditionalInterests.tblNetRateLocationsDataTable) base.Tables["tblNetRateLocations"];
    if (initTable && this.tabletblNetRateLocations != null)
      this.tabletblNetRateLocations.InitVars();
    this.tabletblQuoteAdditionalInterestsNetRateLocations = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable) base.Tables["tblQuoteAdditionalInterestsNetRateLocations"];
    if (initTable && this.tabletblQuoteAdditionalInterestsNetRateLocations != null)
      this.tabletblQuoteAdditionalInterestsNetRateLocations.InitVars();
    this.tablelstLines = (dsAdditionalInterests.lstLinesDataTable) base.Tables["lstLines"];
    if (initTable && this.tablelstLines != null)
      this.tablelstLines.InitVars();
    this.tabletblQuoteAdditionalInterestsNetRateVehicles = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable) base.Tables["tblQuoteAdditionalInterestsNetRateVehicles"];
    if (initTable && this.tabletblQuoteAdditionalInterestsNetRateVehicles != null)
      this.tabletblQuoteAdditionalInterestsNetRateVehicles.InitVars();
    this.tabletblNetRateVehicles = (dsAdditionalInterests.tblNetRateVehiclesDataTable) base.Tables["tblNetRateVehicles"];
    if (initTable && this.tabletblNetRateVehicles != null)
      this.tabletblNetRateVehicles.InitVars();
    this.tabletblAdditionalInterests = (dsAdditionalInterests.tblAdditionalInterestsDataTable) base.Tables["tblAdditionalInterests"];
    if (initTable && this.tabletblAdditionalInterests != null)
      this.tabletblAdditionalInterests.InitVars();
    this.tablelstSalutations = (dsAdditionalInterests.lstSalutationsDataTable) base.Tables["lstSalutations"];
    if (initTable && this.tablelstSalutations != null)
      this.tablelstSalutations.InitVars();
    this.tabledtPreviousInterest = (dsAdditionalInterests.dtPreviousInterestDataTable) base.Tables["dtPreviousInterest"];
    if (initTable && this.tabledtPreviousInterest != null)
      this.tabledtPreviousInterest.InitVars();
    this.tabledtLocInt = (dsAdditionalInterests.dtLocIntDataTable) base.Tables["dtLocInt"];
    if (initTable && this.tabledtLocInt != null)
      this.tabledtLocInt.InitVars();
    this.relationFK_lstLines_tblQuoteAdditionalInterests = this.Relations["FK_lstLines_tblQuoteAdditionalInterests"];
    this.relationlstAdditionalInterestTypestblQuoteAdditionalInterestTypes = this.Relations["lstAdditionalInterestTypestblQuoteAdditionalInterestTypes"];
    this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes = this.Relations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes"];
    this.relationtblUnderwritingLocationstblQuoteAdditionalInterestsLocations = this.Relations["tblUnderwritingLocationstblQuoteAdditionalInterestsLocations"];
    this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations = this.Relations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations"];
    this.relationtblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations = this.Relations["tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations"];
    this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations = this.Relations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations"];
    this.relationFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles = this.Relations["FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles"];
    this.relationFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles = this.Relations["FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdditionalInterests);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAdditionalInterests.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteAdditionalInterests = new dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAdditionalInterests);
    this.tabletblQuoteAdditionalInterestTypes = new dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAdditionalInterestTypes);
    this.tablelstAdditionalInterestTypes = new dsAdditionalInterests.lstAdditionalInterestTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstAdditionalInterestTypes);
    this.tabletblQuoteAdditionalInterestsLocations = new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAdditionalInterestsLocations);
    this.tabletblUnderwritingLocations = new dsAdditionalInterests.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tabletblNetRateLocations = new dsAdditionalInterests.tblNetRateLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblNetRateLocations);
    this.tabletblQuoteAdditionalInterestsNetRateLocations = new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAdditionalInterestsNetRateLocations);
    this.tablelstLines = new dsAdditionalInterests.lstLinesDataTable();
    base.Tables.Add((DataTable) this.tablelstLines);
    this.tabletblQuoteAdditionalInterestsNetRateVehicles = new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAdditionalInterestsNetRateVehicles);
    this.tabletblNetRateVehicles = new dsAdditionalInterests.tblNetRateVehiclesDataTable();
    base.Tables.Add((DataTable) this.tabletblNetRateVehicles);
    this.tabletblAdditionalInterests = new dsAdditionalInterests.tblAdditionalInterestsDataTable();
    base.Tables.Add((DataTable) this.tabletblAdditionalInterests);
    this.tablelstSalutations = new dsAdditionalInterests.lstSalutationsDataTable();
    base.Tables.Add((DataTable) this.tablelstSalutations);
    this.tabledtPreviousInterest = new dsAdditionalInterests.dtPreviousInterestDataTable();
    base.Tables.Add((DataTable) this.tabledtPreviousInterest);
    this.tabledtLocInt = new dsAdditionalInterests.dtLocIntDataTable();
    base.Tables.Add((DataTable) this.tabledtLocInt);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("FK_lstLines_tblQuoteAdditionalInterests", new DataColumn[1]
    {
      this.tablelstLines.LineIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.LineIDColumn
    });
    this.tabletblQuoteAdditionalInterests.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.None;
    foreignKeyConstraint1.UpdateRule = Rule.None;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstAdditionalInterestTypestblQuoteAdditionalInterestTypes", new DataColumn[1]
    {
      this.tablelstAdditionalInterestTypes.InterestTypeColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestTypeColumn
    });
    this.tabletblQuoteAdditionalInterestTypes.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestIDColumn
    });
    this.tabletblQuoteAdditionalInterestTypes.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.None;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("tblUnderwritingLocationstblQuoteAdditionalInterestsLocations", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsLocations.UnderwritingLocationIDColumn
    });
    this.tabletblQuoteAdditionalInterestsLocations.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsLocations.AdditionalInterestIDColumn
    });
    this.tabletblQuoteAdditionalInterestsLocations.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.None;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations", new DataColumn[2]
    {
      this.tabletblNetRateLocations.LocationIDColumn,
      this.tabletblNetRateLocations.BuildingNumberColumn
    }, new DataColumn[2]
    {
      this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateLocationIDColumn,
      this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateBuildingNumberColumn
    });
    this.tabletblQuoteAdditionalInterestsNetRateLocations.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.None;
    foreignKeyConstraint6.UpdateRule = Rule.None;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsNetRateLocations.AdditionalInterestIDColumn
    });
    this.tabletblQuoteAdditionalInterestsNetRateLocations.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint8 = new ForeignKeyConstraint("FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles", new DataColumn[1]
    {
      this.tabletblNetRateVehicles.VehicleIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsNetRateVehicles.VehicleIDColumn
    });
    this.tabletblQuoteAdditionalInterestsNetRateVehicles.Constraints.Add((Constraint) foreignKeyConstraint8);
    foreignKeyConstraint8.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint8.DeleteRule = Rule.None;
    foreignKeyConstraint8.UpdateRule = Rule.None;
    ForeignKeyConstraint foreignKeyConstraint9 = new ForeignKeyConstraint("FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsNetRateVehicles.AdditionalInterestIDColumn
    });
    this.tabletblQuoteAdditionalInterestsNetRateVehicles.Constraints.Add((Constraint) foreignKeyConstraint9);
    foreignKeyConstraint9.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint9.DeleteRule = Rule.Cascade;
    foreignKeyConstraint9.UpdateRule = Rule.None;
    this.relationFK_lstLines_tblQuoteAdditionalInterests = new DataRelation("FK_lstLines_tblQuoteAdditionalInterests", new DataColumn[1]
    {
      this.tablelstLines.LineIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.LineIDColumn
    }, false);
    this.Relations.Add(this.relationFK_lstLines_tblQuoteAdditionalInterests);
    this.relationlstAdditionalInterestTypestblQuoteAdditionalInterestTypes = new DataRelation("lstAdditionalInterestTypestblQuoteAdditionalInterestTypes", new DataColumn[1]
    {
      this.tablelstAdditionalInterestTypes.InterestTypeColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestTypeColumn
    }, false);
    this.Relations.Add(this.relationlstAdditionalInterestTypestblQuoteAdditionalInterestTypes);
    this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes = new DataRelation("tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes);
    this.relationtblUnderwritingLocationstblQuoteAdditionalInterestsLocations = new DataRelation("tblUnderwritingLocationstblQuoteAdditionalInterestsLocations", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsLocations.UnderwritingLocationIDColumn
    }, false);
    this.Relations.Add(this.relationtblUnderwritingLocationstblQuoteAdditionalInterestsLocations);
    this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations = new DataRelation("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsLocations.AdditionalInterestIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations);
    this.relationtblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations = new DataRelation("tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations", new DataColumn[2]
    {
      this.tabletblNetRateLocations.LocationIDColumn,
      this.tabletblNetRateLocations.BuildingNumberColumn
    }, new DataColumn[2]
    {
      this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateLocationIDColumn,
      this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateBuildingNumberColumn
    }, false);
    this.Relations.Add(this.relationtblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations);
    this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations = new DataRelation("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsNetRateLocations.AdditionalInterestIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations);
    this.relationFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles = new DataRelation("FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles", new DataColumn[1]
    {
      this.tabletblNetRateVehicles.VehicleIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsNetRateVehicles.VehicleIDColumn
    }, false);
    this.Relations.Add(this.relationFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles);
    this.relationFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles = new DataRelation("FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles", new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterests.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteAdditionalInterestsNetRateVehicles.AdditionalInterestIDColumn
    }, false);
    this.Relations.Add(this.relationFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteAdditionalInterests() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteAdditionalInterestTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstAdditionalInterestTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteAdditionalInterestsLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblNetRateLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteAdditionalInterestsNetRateLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteAdditionalInterestsNetRateVehicles() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblNetRateVehicles() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblAdditionalInterests() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstSalutations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtPreviousInterest() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtLocInt() => false;

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
    dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = additionalInterests.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public delegate void tblQuoteAdditionalInterestsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuoteAdditionalInterestTypesRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstAdditionalInterestTypesRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuoteAdditionalInterestsLocationsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblNetRateLocationsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblNetRateLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstLinesRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.lstLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblNetRateVehiclesRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblNetRateVehiclesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblAdditionalInterestsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.tblAdditionalInterestsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstSalutationsRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.lstSalutationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtPreviousInterestRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.dtPreviousInterestRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtLocIntRowChangeEventHandler(
    object sender,
    dsAdditionalInterests.dtLocIntRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteAdditionalInterestsDataTable : 
    TypedTableBase<dsAdditionalInterests.tblQuoteAdditionalInterestsRow>
  {
    private DataColumn columnID;
    private DataColumn columnAdditionalInterestGuid;
    private DataColumn columnQuoteID;
    private DataColumn columnInterestName;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnStateID;
    private DataColumn columnRegion;
    private DataColumn columnISOCountryCode;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone;
    private DataColumn columnFax;
    private DataColumn columnModificationCode;
    private DataColumn columnInterest;
    private DataColumn columnDescriptionText;
    private DataColumn columnIssuanceDate;
    private DataColumn columnFEIN;
    private DataColumn columnLineID;
    private DataColumn columnBillable;
    private DataColumn columnBillableAmount;
    private DataColumn columnAdditionalInterestTypeID;
    private DataColumn columnSalutation;
    private DataColumn columnFirstName;
    private DataColumn columnMiddleName;
    private DataColumn columnLastName;
    private DataColumn columnDateOfBirth;
    private DataColumn columnCopyInterest;
    private DataColumn columnMobile;
    private DataColumn columnEmail;
    private DataColumn columnOfacCleared;
    private DataColumn columnGenerateDoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsDataTable()
    {
      this.TableName = "tblQuoteAdditionalInterests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsDataTable(DataTable table)
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
    protected tblQuoteAdditionalInterestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestGuidColumn => this.columnAdditionalInterestGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestNameColumn => this.columnInterestName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestColumn => this.columnInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionTextColumn => this.columnDescriptionText;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IssuanceDateColumn => this.columnIssuanceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FEINColumn => this.columnFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineIDColumn => this.columnLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillableColumn => this.columnBillable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillableAmountColumn => this.columnBillableAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestTypeIDColumn => this.columnAdditionalInterestTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MiddleNameColumn => this.columnMiddleName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateOfBirthColumn => this.columnDateOfBirth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CopyInterestColumn => this.columnCopyInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MobileColumn => this.columnMobile;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacClearedColumn => this.columnOfacCleared;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GenerateDocColumn => this.columnGenerateDoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow this[int index]
    {
      get => (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteAdditionalInterestsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow AddtblQuoteAdditionalInterestsRow(
      Guid AdditionalInterestGuid,
      int QuoteID,
      string InterestName,
      string Address1,
      string Address2,
      string City,
      string County,
      string StateID,
      string _Region,
      string ISOCountryCode,
      string ZipCode,
      string ZipPlus,
      string Phone,
      string Fax,
      string ModificationCode,
      string Interest,
      string DescriptionText,
      DateTime IssuanceDate,
      string FEIN,
      dsAdditionalInterests.lstLinesRow parentlstLinesRowByFK_lstLines_tblQuoteAdditionalInterests,
      bool Billable,
      Decimal BillableAmount,
      int AdditionalInterestTypeID,
      string Salutation,
      string FirstName,
      string MiddleName,
      string LastName,
      DateTime DateOfBirth,
      bool CopyInterest,
      string Mobile,
      string Email,
      DateTime OfacCleared,
      bool GenerateDoc)
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow row = (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.NewRow();
      object[] objArray = new object[34]
      {
        null,
        (object) AdditionalInterestGuid,
        (object) QuoteID,
        (object) InterestName,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) StateID,
        (object) _Region,
        (object) ISOCountryCode,
        (object) ZipCode,
        (object) ZipPlus,
        (object) Phone,
        (object) Fax,
        (object) ModificationCode,
        (object) Interest,
        (object) DescriptionText,
        (object) IssuanceDate,
        (object) FEIN,
        null,
        (object) Billable,
        (object) BillableAmount,
        (object) AdditionalInterestTypeID,
        (object) Salutation,
        (object) FirstName,
        (object) MiddleName,
        (object) LastName,
        (object) DateOfBirth,
        (object) CopyInterest,
        (object) Mobile,
        (object) Email,
        (object) OfacCleared,
        (object) GenerateDoc
      };
      if (parentlstLinesRowByFK_lstLines_tblQuoteAdditionalInterests != null)
        objArray[20] = RuntimeHelpers.GetObjectValue(parentlstLinesRowByFK_lstLines_tblQuoteAdditionalInterests[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow FindByID(int ID)
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable interestsDataTable = (dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable) base.Clone();
      interestsDataTable.InitVars();
      return (DataTable) interestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnAdditionalInterestGuid = this.Columns["AdditionalInterestGuid"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnInterestName = this.Columns["InterestName"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnStateID = this.Columns["StateID"];
      this.columnRegion = this.Columns["Region"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone = this.Columns["Phone"];
      this.columnFax = this.Columns["Fax"];
      this.columnModificationCode = this.Columns["ModificationCode"];
      this.columnInterest = this.Columns["Interest"];
      this.columnDescriptionText = this.Columns["DescriptionText"];
      this.columnIssuanceDate = this.Columns["IssuanceDate"];
      this.columnFEIN = this.Columns["FEIN"];
      this.columnLineID = this.Columns["LineID"];
      this.columnBillable = this.Columns["Billable"];
      this.columnBillableAmount = this.Columns["BillableAmount"];
      this.columnAdditionalInterestTypeID = this.Columns["AdditionalInterestTypeID"];
      this.columnSalutation = this.Columns["Salutation"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnMiddleName = this.Columns["MiddleName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnDateOfBirth = this.Columns["DateOfBirth"];
      this.columnCopyInterest = this.Columns["CopyInterest"];
      this.columnMobile = this.Columns["Mobile"];
      this.columnEmail = this.Columns["Email"];
      this.columnOfacCleared = this.Columns["OfacCleared"];
      this.columnGenerateDoc = this.Columns["GenerateDoc"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnAdditionalInterestGuid = new DataColumn("AdditionalInterestGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestGuid);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnInterestName = new DataColumn("InterestName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterestName);
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
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.columnInterest = new DataColumn("Interest", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterest);
      this.columnDescriptionText = new DataColumn("DescriptionText", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescriptionText);
      this.columnIssuanceDate = new DataColumn("IssuanceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuanceDate);
      this.columnFEIN = new DataColumn("FEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEIN);
      this.columnLineID = new DataColumn("LineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineID);
      this.columnBillable = new DataColumn("Billable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillable);
      this.columnBillableAmount = new DataColumn("BillableAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillableAmount);
      this.columnAdditionalInterestTypeID = new DataColumn("AdditionalInterestTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestTypeID);
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnMiddleName = new DataColumn("MiddleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMiddleName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnDateOfBirth = new DataColumn("DateOfBirth", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateOfBirth);
      this.columnCopyInterest = new DataColumn("CopyInterest", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCopyInterest);
      this.columnMobile = new DataColumn("Mobile", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMobile);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnOfacCleared = new DataColumn("OfacCleared", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacCleared);
      this.columnGenerateDoc = new DataColumn("GenerateDoc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenerateDoc);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnAdditionalInterestGuid.AllowDBNull = false;
      this.columnQuoteID.AllowDBNull = false;
      this.columnISOCountryCode.AllowDBNull = false;
      this.columnISOCountryCode.DefaultValue = (object) "USA";
      this.columnModificationCode.AllowDBNull = false;
      this.columnModificationCode.DefaultValue = (object) "N";
      this.columnBillable.AllowDBNull = false;
      this.columnBillable.DefaultValue = (object) false;
      this.columnCopyInterest.DefaultValue = (object) false;
      this.columnGenerateDoc.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow NewtblQuoteAdditionalInterestsRow()
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblQuoteAdditionalInterestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblQuoteAdditionalInterestsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler interestsRowChangedEvent = this.tblQuoteAdditionalInterestsRowChangedEvent;
      if (interestsRowChangedEvent == null)
        return;
      interestsRowChangedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler rowChangingEvent = this.tblQuoteAdditionalInterestsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler interestsRowDeletedEvent = this.tblQuoteAdditionalInterestsRowDeletedEvent;
      if (interestsRowDeletedEvent == null)
        return;
      interestsRowDeletedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEventHandler rowDeletingEvent = this.tblQuoteAdditionalInterestsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteAdditionalInterestsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAdditionalInterestsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblQuoteAdditionalInterestTypesDataTable : 
    TypedTableBase<dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow>
  {
    private DataColumn columnAdditionalInterestID;
    private DataColumn columnAdditionalInterestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestTypesDataTable()
    {
      this.TableName = "tblQuoteAdditionalInterestTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestTypesDataTable(DataTable table)
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
    protected tblQuoteAdditionalInterestTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestIDColumn => this.columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestTypeColumn => this.columnAdditionalInterestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow this[int index]
    {
      get => (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler tblQuoteAdditionalInterestTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler tblQuoteAdditionalInterestTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler tblQuoteAdditionalInterestTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler tblQuoteAdditionalInterestTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteAdditionalInterestTypesRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow AddtblQuoteAdditionalInterestTypesRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes,
      dsAdditionalInterests.lstAdditionalInterestTypesRow parentlstAdditionalInterestTypesRowBylstAdditionalInterestTypestblQuoteAdditionalInterestTypes)
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow row = (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes[0]);
      if (parentlstAdditionalInterestTypesRowBylstAdditionalInterestTypestblQuoteAdditionalInterestTypes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstAdditionalInterestTypesRowBylstAdditionalInterestTypestblQuoteAdditionalInterestTypes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow FindByAdditionalInterestIDAdditionalInterestType(
      int AdditionalInterestID,
      string AdditionalInterestType)
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) this.Rows.Find(new object[2]
      {
        (object) AdditionalInterestID,
        (object) AdditionalInterestType
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable interestTypesDataTable = (dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable) base.Clone();
      interestTypesDataTable.InitVars();
      return (DataTable) interestTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnAdditionalInterestID = this.Columns["AdditionalInterestID"];
      this.columnAdditionalInterestType = this.Columns["AdditionalInterestType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnAdditionalInterestID = new DataColumn("AdditionalInterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestID);
      this.columnAdditionalInterestType = new DataColumn("AdditionalInterestType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey2", new DataColumn[2]
      {
        this.columnAdditionalInterestID,
        this.columnAdditionalInterestType
      }, true));
      this.columnAdditionalInterestID.AllowDBNull = false;
      this.columnAdditionalInterestType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow NewtblQuoteAdditionalInterestTypesRow()
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler typesRowChangedEvent = this.tblQuoteAdditionalInterestTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler rowChangingEvent = this.tblQuoteAdditionalInterestTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler typesRowDeletedEvent = this.tblQuoteAdditionalInterestTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEventHandler rowDeletingEvent = this.tblQuoteAdditionalInterestTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteAdditionalInterestTypesRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAdditionalInterestTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class lstAdditionalInterestTypesDataTable : 
    TypedTableBase<dsAdditionalInterests.lstAdditionalInterestTypesRow>
  {
    private DataColumn columnInterestType;
    private DataColumn columnAdditionalInterest;
    private DataColumn columnAddressRequired;
    private DataColumn columnLocationRequired;
    private DataColumn columnVehicleRequired;
    private DataColumn columnisDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdditionalInterestTypesDataTable()
    {
      this.TableName = "lstAdditionalInterestTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdditionalInterestTypesDataTable(DataTable table)
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
    protected lstAdditionalInterestTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestTypeColumn => this.columnInterestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestColumn => this.columnAdditionalInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddressRequiredColumn => this.columnAddressRequired;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationRequiredColumn => this.columnLocationRequired;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VehicleRequiredColumn => this.columnVehicleRequired;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IsDisabledColumn => this.columnisDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstAdditionalInterestTypesRow this[int index]
    {
      get => (dsAdditionalInterests.lstAdditionalInterestTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstAdditionalInterestTypesRow(
      dsAdditionalInterests.lstAdditionalInterestTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstAdditionalInterestTypesRow AddlstAdditionalInterestTypesRow(
      string InterestType,
      string AdditionalInterest,
      bool AddressRequired,
      bool LocationRequired,
      bool VehicleRequired,
      bool isDisabled)
    {
      dsAdditionalInterests.lstAdditionalInterestTypesRow row = (dsAdditionalInterests.lstAdditionalInterestTypesRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) InterestType,
        (object) AdditionalInterest,
        (object) AddressRequired,
        (object) LocationRequired,
        (object) VehicleRequired,
        (object) isDisabled
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstAdditionalInterestTypesRow FindByInterestType(
      string InterestType)
    {
      return (dsAdditionalInterests.lstAdditionalInterestTypesRow) this.Rows.Find(new object[1]
      {
        (object) InterestType
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.lstAdditionalInterestTypesDataTable interestTypesDataTable = (dsAdditionalInterests.lstAdditionalInterestTypesDataTable) base.Clone();
      interestTypesDataTable.InitVars();
      return (DataTable) interestTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.lstAdditionalInterestTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnInterestType = this.Columns["InterestType"];
      this.columnAdditionalInterest = this.Columns["AdditionalInterest"];
      this.columnAddressRequired = this.Columns["AddressRequired"];
      this.columnLocationRequired = this.Columns["LocationRequired"];
      this.columnVehicleRequired = this.Columns["VehicleRequired"];
      this.columnisDisabled = this.Columns["IsDisabled"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnInterestType = new DataColumn("InterestType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterestType);
      this.columnAdditionalInterest = new DataColumn("AdditionalInterest", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterest);
      this.columnAddressRequired = new DataColumn("AddressRequired", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressRequired);
      this.columnLocationRequired = new DataColumn("LocationRequired", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationRequired);
      this.columnVehicleRequired = new DataColumn("VehicleRequired", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleRequired);
      this.columnisDisabled = new DataColumn("IsDisabled", typeof (bool), (string) null, MappingType.Element);
      this.columnisDisabled.ExtendedProperties.Add((object) "Generator_ColumnPropNameInRow", (object) "isDisabled");
      this.columnisDisabled.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "isDisabledColumn");
      this.columnisDisabled.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnisDisabled");
      this.columnisDisabled.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "IsDisabled");
      this.Columns.Add(this.columnisDisabled);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey3", new DataColumn[1]
      {
        this.columnInterestType
      }, true));
      this.columnInterestType.AllowDBNull = false;
      this.columnInterestType.Unique = true;
      this.columnAdditionalInterest.AllowDBNull = false;
      this.columnAddressRequired.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstAdditionalInterestTypesRow NewlstAdditionalInterestTypesRow()
    {
      return (dsAdditionalInterests.lstAdditionalInterestTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.lstAdditionalInterestTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.lstAdditionalInterestTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler typesRowChangedEvent = this.lstAdditionalInterestTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler rowChangingEvent = this.lstAdditionalInterestTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler typesRowDeletedEvent = this.lstAdditionalInterestTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEventHandler rowDeletingEvent = this.lstAdditionalInterestTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.lstAdditionalInterestTypesRowChangeEvent((dsAdditionalInterests.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstAdditionalInterestTypesRow(
      dsAdditionalInterests.lstAdditionalInterestTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAdditionalInterestTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblQuoteAdditionalInterestsLocationsDataTable : 
    TypedTableBase<dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow>
  {
    private DataColumn columnAdditionalInterestID;
    private DataColumn columnUnderwritingLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsLocationsDataTable()
    {
      this.TableName = "tblQuoteAdditionalInterestsLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsLocationsDataTable(DataTable table)
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
    protected tblQuoteAdditionalInterestsLocationsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestIDColumn => this.columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwritingLocationIDColumn => this.columnUnderwritingLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow this[int index]
    {
      get => (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler tblQuoteAdditionalInterestsLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler tblQuoteAdditionalInterestsLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler tblQuoteAdditionalInterestsLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler tblQuoteAdditionalInterestsLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteAdditionalInterestsLocationsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow AddtblQuoteAdditionalInterestsLocationsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations,
      dsAdditionalInterests.tblUnderwritingLocationsRow parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblQuoteAdditionalInterestsLocations)
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow row = (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations[0]);
      if (parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblQuoteAdditionalInterestsLocations != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblQuoteAdditionalInterestsLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow FindByAdditionalInterestIDUnderwritingLocationID(
      int AdditionalInterestID,
      int UnderwritingLocationID)
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) this.Rows.Find(new object[2]
      {
        (object) AdditionalInterestID,
        (object) UnderwritingLocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable locationsDataTable = (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnAdditionalInterestID = this.Columns["AdditionalInterestID"];
      this.columnUnderwritingLocationID = this.Columns["UnderwritingLocationID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnAdditionalInterestID = new DataColumn("AdditionalInterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestID);
      this.columnUnderwritingLocationID = new DataColumn("UnderwritingLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwritingLocationID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey4", new DataColumn[2]
      {
        this.columnAdditionalInterestID,
        this.columnUnderwritingLocationID
      }, true));
      this.columnAdditionalInterestID.AllowDBNull = false;
      this.columnUnderwritingLocationID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow NewtblQuoteAdditionalInterestsLocationsRow()
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblQuoteAdditionalInterestsLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler rowChangingEvent = this.tblQuoteAdditionalInterestsLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblQuoteAdditionalInterestsLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEventHandler rowDeletingEvent = this.tblQuoteAdditionalInterestsLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteAdditionalInterestsLocationsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAdditionalInterestsLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
    TypedTableBase<dsAdditionalInterests.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnAddress1;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnBuildingNo;
    private DataColumn columnPhysicalBuildingNo;
    private DataColumn columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PhysicalBuildingNoColumn => this.columnPhysicalBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsAdditionalInterests.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUnderwritingLocationsRow(
      dsAdditionalInterests.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      string Address1,
      string City,
      string State,
      string BuildingNo,
      string PhysicalBuildingNo,
      int LocationNo)
    {
      dsAdditionalInterests.tblUnderwritingLocationsRow row = (dsAdditionalInterests.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) Address1,
        (object) City,
        (object) State,
        (object) BuildingNo,
        (object) PhysicalBuildingNo,
        (object) LocationNo
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsAdditionalInterests.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblUnderwritingLocationsDataTable locationsDataTable = (dsAdditionalInterests.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnPhysicalBuildingNo = this.Columns["PhysicalBuildingNo"];
      this.columnLocationNo = this.Columns["LocationNo"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnPhysicalBuildingNo = new DataColumn("PhysicalBuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysicalBuildingNo);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey5", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnAddress1.AllowDBNull = false;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnBuildingNo.AllowDBNull = false;
      this.columnPhysicalBuildingNo.AllowDBNull = false;
      this.columnLocationNo.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsAdditionalInterests.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblUnderwritingLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsAdditionalInterests.tblUnderwritingLocationsRowChangeEvent((dsAdditionalInterests.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblUnderwritingLocationsRowChangeEvent((dsAdditionalInterests.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsAdditionalInterests.tblUnderwritingLocationsRowChangeEvent((dsAdditionalInterests.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblUnderwritingLocationsRowChangeEvent((dsAdditionalInterests.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(
      dsAdditionalInterests.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblNetRateLocationsDataTable : 
    TypedTableBase<dsAdditionalInterests.tblNetRateLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnLocationNumber;
    private DataColumn columnBuildingNumber;
    private DataColumn columnAddress;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZipCode;
    private DataColumn columnStreetSecondaryLocation;
    private DataColumn columnBuildingIdentifier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNetRateLocationsDataTable()
    {
      this.TableName = "tblNetRateLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNetRateLocationsDataTable(DataTable table)
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
    protected tblNetRateLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNumberColumn => this.columnLocationNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BuildingNumberColumn => this.columnBuildingNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StreetSecondaryLocationColumn => this.columnStreetSecondaryLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BuildingIdentifierColumn => this.columnBuildingIdentifier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateLocationsRow this[int index]
    {
      get => (dsAdditionalInterests.tblNetRateLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler tblNetRateLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler tblNetRateLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler tblNetRateLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler tblNetRateLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblNetRateLocationsRow(dsAdditionalInterests.tblNetRateLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateLocationsRow AddtblNetRateLocationsRow(
      int LocationNumber,
      int BuildingNumber,
      string Address,
      string City,
      string State,
      string ZipCode,
      string StreetSecondaryLocation,
      string BuildingIdentifier)
    {
      dsAdditionalInterests.tblNetRateLocationsRow row = (dsAdditionalInterests.tblNetRateLocationsRow) this.NewRow();
      object[] objArray = new object[9]
      {
        null,
        (object) LocationNumber,
        (object) BuildingNumber,
        (object) Address,
        (object) City,
        (object) State,
        (object) ZipCode,
        (object) StreetSecondaryLocation,
        (object) BuildingIdentifier
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateLocationsRow FindByLocationIDBuildingNumber(
      int LocationID,
      int BuildingNumber)
    {
      return (dsAdditionalInterests.tblNetRateLocationsRow) this.Rows.Find(new object[2]
      {
        (object) LocationID,
        (object) BuildingNumber
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblNetRateLocationsDataTable locationsDataTable = (dsAdditionalInterests.tblNetRateLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblNetRateLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationNumber = this.Columns["LocationNumber"];
      this.columnBuildingNumber = this.Columns["BuildingNumber"];
      this.columnAddress = this.Columns["Address"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnStreetSecondaryLocation = this.Columns["StreetSecondaryLocation"];
      this.columnBuildingIdentifier = this.Columns["BuildingIdentifier"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationNumber = new DataColumn("LocationNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNumber);
      this.columnBuildingNumber = new DataColumn("BuildingNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNumber);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnStreetSecondaryLocation = new DataColumn("StreetSecondaryLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreetSecondaryLocation);
      this.columnBuildingIdentifier = new DataColumn("BuildingIdentifier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingIdentifier);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey7", new DataColumn[2]
      {
        this.columnLocationID,
        this.columnBuildingNumber
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnBuildingNumber.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateLocationsRow NewtblNetRateLocationsRow()
    {
      return (dsAdditionalInterests.tblNetRateLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblNetRateLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterests.tblNetRateLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblNetRateLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsAdditionalInterests.tblNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler rowChangingEvent = this.tblNetRateLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblNetRateLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsAdditionalInterests.tblNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateLocationsRowChangeEventHandler rowDeletingEvent = this.tblNetRateLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblNetRateLocationsRow(dsAdditionalInterests.tblNetRateLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNetRateLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblQuoteAdditionalInterestsNetRateLocationsDataTable : 
    TypedTableBase<dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow>
  {
    private DataColumn columnAdditionalInterestID;
    private DataColumn columnNetRateLocationID;
    private DataColumn columnNetRateBuildingNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsNetRateLocationsDataTable()
    {
      this.TableName = "tblQuoteAdditionalInterestsNetRateLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsNetRateLocationsDataTable(DataTable table)
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
    protected tblQuoteAdditionalInterestsNetRateLocationsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestIDColumn => this.columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NetRateLocationIDColumn => this.columnNetRateLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NetRateBuildingNumberColumn => this.columnNetRateBuildingNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow this[int index]
    {
      get
      {
        return (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) this.Rows[index];
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler tblQuoteAdditionalInterestsNetRateLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler tblQuoteAdditionalInterestsNetRateLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler tblQuoteAdditionalInterestsNetRateLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler tblQuoteAdditionalInterestsNetRateLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteAdditionalInterestsNetRateLocationsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow AddtblQuoteAdditionalInterestsNetRateLocationsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations,
      int NetRateLocationID,
      int NetRateBuildingNumber)
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow row = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) NetRateLocationID,
        (object) NetRateBuildingNumber
      };
      if (parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuoteAdditionalInterestsRowBytblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow FindByAdditionalInterestIDNetRateLocationIDNetRateBuildingNumber(
      int AdditionalInterestID,
      int NetRateLocationID,
      int NetRateBuildingNumber)
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) this.Rows.Find(new object[3]
      {
        (object) AdditionalInterestID,
        (object) NetRateLocationID,
        (object) NetRateBuildingNumber
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable locationsDataTable = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnAdditionalInterestID = this.Columns["AdditionalInterestID"];
      this.columnNetRateLocationID = this.Columns["NetRateLocationID"];
      this.columnNetRateBuildingNumber = this.Columns["NetRateBuildingNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnAdditionalInterestID = new DataColumn("AdditionalInterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestID);
      this.columnNetRateLocationID = new DataColumn("NetRateLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetRateLocationID);
      this.columnNetRateBuildingNumber = new DataColumn("NetRateBuildingNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetRateBuildingNumber);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalInterestsKey6", new DataColumn[3]
      {
        this.columnAdditionalInterestID,
        this.columnNetRateLocationID,
        this.columnNetRateBuildingNumber
      }, true));
      this.columnAdditionalInterestID.AllowDBNull = false;
      this.columnNetRateLocationID.AllowDBNull = false;
      this.columnNetRateBuildingNumber.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow NewtblQuoteAdditionalInterestsNetRateLocationsRow()
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblQuoteAdditionalInterestsNetRateLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler rowChangingEvent = this.tblQuoteAdditionalInterestsNetRateLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblQuoteAdditionalInterestsNetRateLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEventHandler rowDeletingEvent = this.tblQuoteAdditionalInterestsNetRateLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteAdditionalInterestsNetRateLocationsRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAdditionalInterestsNetRateLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class lstLinesDataTable : TypedTableBase<dsAdditionalInterests.lstLinesRow>
  {
    private DataColumn columnLineID;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesDataTable()
    {
      this.TableName = "lstLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesDataTable(DataTable table)
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
    protected lstLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineIDColumn => this.columnLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstLinesRow this[int index]
    {
      get => (dsAdditionalInterests.lstLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstLinesRowChangeEventHandler lstLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstLinesRowChangeEventHandler lstLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstLinesRowChangeEventHandler lstLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstLinesRowChangeEventHandler lstLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstLinesRow(dsAdditionalInterests.lstLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstLinesRow AddlstLinesRow(string LineName)
    {
      dsAdditionalInterests.lstLinesRow row = (dsAdditionalInterests.lstLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstLinesRow FindByLineID(int LineID)
    {
      return (dsAdditionalInterests.lstLinesRow) this.Rows.Find(new object[1]
      {
        (object) LineID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.lstLinesDataTable lstLinesDataTable = (dsAdditionalInterests.lstLinesDataTable) base.Clone();
      lstLinesDataTable.InitVars();
      return (DataTable) lstLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.lstLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLineID = this.Columns["LineID"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLineID = new DataColumn("LineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineID);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("lstLinesKey1", new DataColumn[1]
      {
        this.columnLineID
      }, true));
      this.columnLineID.AutoIncrement = true;
      this.columnLineID.AllowDBNull = false;
      this.columnLineID.ReadOnly = true;
      this.columnLineID.Unique = true;
      this.columnLineName.AllowDBNull = false;
      this.columnLineName.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstLinesRow NewlstLinesRow()
    {
      return (dsAdditionalInterests.lstLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.lstLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterests.lstLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstLinesRowChangeEventHandler linesRowChangedEvent = this.lstLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsAdditionalInterests.lstLinesRowChangeEvent((dsAdditionalInterests.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstLinesRowChangeEventHandler rowChangingEvent = this.lstLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.lstLinesRowChangeEvent((dsAdditionalInterests.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstLinesRowChangeEventHandler linesRowDeletedEvent = this.lstLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsAdditionalInterests.lstLinesRowChangeEvent((dsAdditionalInterests.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstLinesRowChangeEventHandler rowDeletingEvent = this.lstLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.lstLinesRowChangeEvent((dsAdditionalInterests.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstLinesRow(dsAdditionalInterests.lstLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblQuoteAdditionalInterestsNetRateVehiclesDataTable : 
    TypedTableBase<dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow>
  {
    private DataColumn columnAdditionalInterestID;
    private DataColumn columnVehicleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsNetRateVehiclesDataTable()
    {
      this.TableName = "tblQuoteAdditionalInterestsNetRateVehicles";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsNetRateVehiclesDataTable(DataTable table)
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
    protected tblQuoteAdditionalInterestsNetRateVehiclesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestIDColumn => this.columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VehicleIDColumn => this.columnVehicleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow this[int index]
    {
      get => (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler tblQuoteAdditionalInterestsNetRateVehiclesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler tblQuoteAdditionalInterestsNetRateVehiclesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler tblQuoteAdditionalInterestsNetRateVehiclesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler tblQuoteAdditionalInterestsNetRateVehiclesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteAdditionalInterestsNetRateVehiclesRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow AddtblQuoteAdditionalInterestsNetRateVehiclesRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow parenttblQuoteAdditionalInterestsRowByFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles,
      dsAdditionalInterests.tblNetRateVehiclesRow parenttblNetRateVehiclesRowByFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles)
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow row = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblQuoteAdditionalInterestsRowByFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuoteAdditionalInterestsRowByFK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles[0]);
      if (parenttblNetRateVehiclesRowByFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblNetRateVehiclesRowByFK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow FindByAdditionalInterestIDVehicleID(
      int AdditionalInterestID,
      int VehicleID)
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) this.Rows.Find(new object[2]
      {
        (object) AdditionalInterestID,
        (object) VehicleID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable vehiclesDataTable = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable) base.Clone();
      vehiclesDataTable.InitVars();
      return (DataTable) vehiclesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnAdditionalInterestID = this.Columns["AdditionalInterestID"];
      this.columnVehicleID = this.Columns["VehicleID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnAdditionalInterestID = new DataColumn("AdditionalInterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestID);
      this.columnVehicleID = new DataColumn("VehicleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnAdditionalInterestID,
        this.columnVehicleID
      }, true));
      this.columnAdditionalInterestID.AllowDBNull = false;
      this.columnVehicleID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow NewtblQuoteAdditionalInterestsNetRateVehiclesRow()
    {
      return (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateVehiclesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler vehiclesRowChangedEvent = this.tblQuoteAdditionalInterestsNetRateVehiclesRowChangedEvent;
      if (vehiclesRowChangedEvent == null)
        return;
      vehiclesRowChangedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateVehiclesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler rowChangingEvent = this.tblQuoteAdditionalInterestsNetRateVehiclesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateVehiclesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler vehiclesRowDeletedEvent = this.tblQuoteAdditionalInterestsNetRateVehiclesRowDeletedEvent;
      if (vehiclesRowDeletedEvent == null)
        return;
      vehiclesRowDeletedEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsNetRateVehiclesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEventHandler rowDeletingEvent = this.tblQuoteAdditionalInterestsNetRateVehiclesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteAdditionalInterestsNetRateVehiclesRow(
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAdditionalInterestsNetRateVehiclesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblNetRateVehiclesDataTable : 
    TypedTableBase<dsAdditionalInterests.tblNetRateVehiclesRow>
  {
    private DataColumn columnVehicleID;
    private DataColumn columnVehicleNumber;
    private DataColumn columnMake;
    private DataColumn columnModel;
    private DataColumn columnYear;
    private DataColumn columnVIN;
    private DataColumn columnLocationID;
    private DataColumn columnVehicleUnitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNetRateVehiclesDataTable()
    {
      this.TableName = "tblNetRateVehicles";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNetRateVehiclesDataTable(DataTable table)
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
    protected tblNetRateVehiclesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VehicleIDColumn => this.columnVehicleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VehicleNumberColumn => this.columnVehicleNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MakeColumn => this.columnMake;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ModelColumn => this.columnModel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn YearColumn => this.columnYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VINColumn => this.columnVIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VehicleUnitNumberColumn => this.columnVehicleUnitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateVehiclesRow this[int index]
    {
      get => (dsAdditionalInterests.tblNetRateVehiclesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler tblNetRateVehiclesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler tblNetRateVehiclesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler tblNetRateVehiclesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler tblNetRateVehiclesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblNetRateVehiclesRow(dsAdditionalInterests.tblNetRateVehiclesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateVehiclesRow AddtblNetRateVehiclesRow(
      int VehicleID,
      int VehicleNumber,
      string Make,
      string Model,
      string Year,
      string VIN,
      int LocationID,
      int VehicleUnitNumber)
    {
      dsAdditionalInterests.tblNetRateVehiclesRow row = (dsAdditionalInterests.tblNetRateVehiclesRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) VehicleID,
        (object) VehicleNumber,
        (object) Make,
        (object) Model,
        (object) Year,
        (object) VIN,
        (object) LocationID,
        (object) VehicleUnitNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateVehiclesRow FindByVehicleID(int VehicleID)
    {
      return (dsAdditionalInterests.tblNetRateVehiclesRow) this.Rows.Find(new object[1]
      {
        (object) VehicleID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblNetRateVehiclesDataTable vehiclesDataTable = (dsAdditionalInterests.tblNetRateVehiclesDataTable) base.Clone();
      vehiclesDataTable.InitVars();
      return (DataTable) vehiclesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblNetRateVehiclesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnVehicleID = this.Columns["VehicleID"];
      this.columnVehicleNumber = this.Columns["VehicleNumber"];
      this.columnMake = this.Columns["Make"];
      this.columnModel = this.Columns["Model"];
      this.columnYear = this.Columns["Year"];
      this.columnVIN = this.Columns["VIN"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnVehicleUnitNumber = this.Columns["VehicleUnitNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnVehicleID = new DataColumn("VehicleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleID);
      this.columnVehicleNumber = new DataColumn("VehicleNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleNumber);
      this.columnMake = new DataColumn("Make", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMake);
      this.columnModel = new DataColumn("Model", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModel);
      this.columnYear = new DataColumn("Year", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYear);
      this.columnVIN = new DataColumn("VIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVIN);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnVehicleUnitNumber = new DataColumn("VehicleUnitNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleUnitNumber);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnVehicleID
      }, true));
      this.columnVehicleID.AllowDBNull = false;
      this.columnVehicleID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateVehiclesRow NewtblNetRateVehiclesRow()
    {
      return (dsAdditionalInterests.tblNetRateVehiclesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblNetRateVehiclesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterests.tblNetRateVehiclesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateVehiclesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler vehiclesRowChangedEvent = this.tblNetRateVehiclesRowChangedEvent;
      if (vehiclesRowChangedEvent == null)
        return;
      vehiclesRowChangedEvent((object) this, new dsAdditionalInterests.tblNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateVehiclesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler rowChangingEvent = this.tblNetRateVehiclesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateVehiclesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler vehiclesRowDeletedEvent = this.tblNetRateVehiclesRowDeletedEvent;
      if (vehiclesRowDeletedEvent == null)
        return;
      vehiclesRowDeletedEvent((object) this, new dsAdditionalInterests.tblNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateVehiclesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblNetRateVehiclesRowChangeEventHandler rowDeletingEvent = this.tblNetRateVehiclesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblNetRateVehiclesRowChangeEvent((dsAdditionalInterests.tblNetRateVehiclesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblNetRateVehiclesRow(dsAdditionalInterests.tblNetRateVehiclesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNetRateVehiclesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class tblAdditionalInterestsDataTable : 
    TypedTableBase<dsAdditionalInterests.tblAdditionalInterestsRow>
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblAdditionalInterestsDataTable()
    {
      this.TableName = "tblAdditionalInterests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblAdditionalInterestsDataTable(DataTable table)
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
    protected tblAdditionalInterestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestIDColumn => this.columnInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestColumn => this.columnInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblAdditionalInterestsRow this[int index]
    {
      get => (dsAdditionalInterests.tblAdditionalInterestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblAdditionalInterestsRow(
      dsAdditionalInterests.tblAdditionalInterestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblAdditionalInterestsRow AddtblAdditionalInterestsRow(
      string Interest,
      string Address1,
      string Address2,
      string City,
      string County,
      string StateID,
      string _Region,
      string ISOCountryCode,
      string ZipCode,
      string ZipPlus)
    {
      dsAdditionalInterests.tblAdditionalInterestsRow row = (dsAdditionalInterests.tblAdditionalInterestsRow) this.NewRow();
      object[] objArray = new object[11]
      {
        null,
        (object) Interest,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) StateID,
        (object) _Region,
        (object) ISOCountryCode,
        (object) ZipCode,
        (object) ZipPlus
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblAdditionalInterestsRow FindByInterestID(int InterestID)
    {
      return (dsAdditionalInterests.tblAdditionalInterestsRow) this.Rows.Find(new object[1]
      {
        (object) InterestID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.tblAdditionalInterestsDataTable interestsDataTable = (dsAdditionalInterests.tblAdditionalInterestsDataTable) base.Clone();
      interestsDataTable.InitVars();
      return (DataTable) interestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.tblAdditionalInterestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
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
      this.columnInterest.AllowDBNull = false;
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
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblAdditionalInterestsRow NewtblAdditionalInterestsRow()
    {
      return (dsAdditionalInterests.tblAdditionalInterestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.tblAdditionalInterestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalInterests.tblAdditionalInterestsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalInterestsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler interestsRowChangedEvent = this.tblAdditionalInterestsRowChangedEvent;
      if (interestsRowChangedEvent == null)
        return;
      interestsRowChangedEvent((object) this, new dsAdditionalInterests.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalInterestsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler rowChangingEvent = this.tblAdditionalInterestsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalInterestsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler interestsRowDeletedEvent = this.tblAdditionalInterestsRowDeletedEvent;
      if (interestsRowDeletedEvent == null)
        return;
      interestsRowDeletedEvent((object) this, new dsAdditionalInterests.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalInterestsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.tblAdditionalInterestsRowChangeEventHandler rowDeletingEvent = this.tblAdditionalInterestsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterests.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblAdditionalInterestsRow(
      dsAdditionalInterests.tblAdditionalInterestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblAdditionalInterestsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class lstSalutationsDataTable : TypedTableBase<dsAdditionalInterests.lstSalutationsRow>
  {
    private DataColumn columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstSalutationsDataTable()
    {
      this.TableName = "lstSalutations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstSalutationsDataTable(DataTable table)
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
    protected lstSalutationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstSalutationsRow this[int index]
    {
      get => (dsAdditionalInterests.lstSalutationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstSalutationsRowChangeEventHandler lstSalutationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstSalutationsRowChangeEventHandler lstSalutationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstSalutationsRow(dsAdditionalInterests.lstSalutationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstSalutationsRow AddlstSalutationsRow(string Salutation)
    {
      dsAdditionalInterests.lstSalutationsRow row = (dsAdditionalInterests.lstSalutationsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) Salutation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstSalutationsRow FindBySalutation(string Salutation)
    {
      return (dsAdditionalInterests.lstSalutationsRow) this.Rows.Find(new object[1]
      {
        (object) Salutation
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.lstSalutationsDataTable salutationsDataTable = (dsAdditionalInterests.lstSalutationsDataTable) base.Clone();
      salutationsDataTable.InitVars();
      return (DataTable) salutationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.lstSalutationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars() => this.columnSalutation = this.Columns["Salutation"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnSalutation
      }, true));
      this.columnSalutation.AllowDBNull = false;
      this.columnSalutation.Unique = true;
      this.columnSalutation.MaxLength = 4;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstSalutationsRow NewlstSalutationsRow()
    {
      return (dsAdditionalInterests.lstSalutationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.lstSalutationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterests.lstSalutationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstSalutationsRowChangeEventHandler salutationsRowChangedEvent = this.lstSalutationsRowChangedEvent;
      if (salutationsRowChangedEvent == null)
        return;
      salutationsRowChangedEvent((object) this, new dsAdditionalInterests.lstSalutationsRowChangeEvent((dsAdditionalInterests.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstSalutationsRowChangeEventHandler rowChangingEvent = this.lstSalutationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.lstSalutationsRowChangeEvent((dsAdditionalInterests.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstSalutationsRowChangeEventHandler salutationsRowDeletedEvent = this.lstSalutationsRowDeletedEvent;
      if (salutationsRowDeletedEvent == null)
        return;
      salutationsRowDeletedEvent((object) this, new dsAdditionalInterests.lstSalutationsRowChangeEvent((dsAdditionalInterests.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.lstSalutationsRowChangeEventHandler rowDeletingEvent = this.lstSalutationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.lstSalutationsRowChangeEvent((dsAdditionalInterests.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstSalutationsRow(dsAdditionalInterests.lstSalutationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSalutationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class dtPreviousInterestDataTable : 
    TypedTableBase<dsAdditionalInterests.dtPreviousInterestRow>
  {
    private DataColumn columnID;
    private DataColumn columnPreviousAdditionalInterestGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtPreviousInterestDataTable()
    {
      this.TableName = "dtPreviousInterest";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtPreviousInterestDataTable(DataTable table)
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
    protected dtPreviousInterestDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PreviousAdditionalInterestGuidColumn
    {
      get => this.columnPreviousAdditionalInterestGuid;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtPreviousInterestRow this[int index]
    {
      get => (dsAdditionalInterests.dtPreviousInterestRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler dtPreviousInterestRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler dtPreviousInterestRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler dtPreviousInterestRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler dtPreviousInterestRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtPreviousInterestRow(dsAdditionalInterests.dtPreviousInterestRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtPreviousInterestRow AdddtPreviousInterestRow(
      int ID,
      Guid PreviousAdditionalInterestGuid)
    {
      dsAdditionalInterests.dtPreviousInterestRow row = (dsAdditionalInterests.dtPreviousInterestRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) PreviousAdditionalInterestGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtPreviousInterestRow FindByID(int ID)
    {
      return (dsAdditionalInterests.dtPreviousInterestRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.dtPreviousInterestDataTable interestDataTable = (dsAdditionalInterests.dtPreviousInterestDataTable) base.Clone();
      interestDataTable.InitVars();
      return (DataTable) interestDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.dtPreviousInterestDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPreviousAdditionalInterestGuid = this.Columns["PreviousAdditionalInterestGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPreviousAdditionalInterestGuid = new DataColumn("PreviousAdditionalInterestGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPreviousAdditionalInterestGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtPreviousInterestRow NewdtPreviousInterestRow()
    {
      return (dsAdditionalInterests.dtPreviousInterestRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.dtPreviousInterestRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterests.dtPreviousInterestRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPreviousInterestRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler interestRowChangedEvent = this.dtPreviousInterestRowChangedEvent;
      if (interestRowChangedEvent == null)
        return;
      interestRowChangedEvent((object) this, new dsAdditionalInterests.dtPreviousInterestRowChangeEvent((dsAdditionalInterests.dtPreviousInterestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPreviousInterestRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler rowChangingEvent = this.dtPreviousInterestRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.dtPreviousInterestRowChangeEvent((dsAdditionalInterests.dtPreviousInterestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPreviousInterestRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler interestRowDeletedEvent = this.dtPreviousInterestRowDeletedEvent;
      if (interestRowDeletedEvent == null)
        return;
      interestRowDeletedEvent((object) this, new dsAdditionalInterests.dtPreviousInterestRowChangeEvent((dsAdditionalInterests.dtPreviousInterestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPreviousInterestRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtPreviousInterestRowChangeEventHandler rowDeletingEvent = this.dtPreviousInterestRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.dtPreviousInterestRowChangeEvent((dsAdditionalInterests.dtPreviousInterestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtPreviousInterestRow(dsAdditionalInterests.dtPreviousInterestRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtPreviousInterestDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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
  public class dtLocIntDataTable : TypedTableBase<dsAdditionalInterests.dtLocIntRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtLocIntDataTable()
    {
      this.TableName = "dtLocInt";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtLocIntDataTable(DataTable table)
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
    protected dtLocIntDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestIDColumn => this.columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtLocIntRow this[int index]
    {
      get => (dsAdditionalInterests.dtLocIntRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtLocIntRowChangeEventHandler dtLocIntRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtLocIntRowChangeEventHandler dtLocIntRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtLocIntRowChangeEventHandler dtLocIntRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdditionalInterests.dtLocIntRowChangeEventHandler dtLocIntRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtLocIntRow(dsAdditionalInterests.dtLocIntRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtLocIntRow AdddtLocIntRow(
      int LocationID,
      int AdditionalInterestID)
    {
      dsAdditionalInterests.dtLocIntRow row = (dsAdditionalInterests.dtLocIntRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LocationID,
        (object) AdditionalInterestID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterests.dtLocIntDataTable dtLocIntDataTable = (dsAdditionalInterests.dtLocIntDataTable) base.Clone();
      dtLocIntDataTable.InitVars();
      return (DataTable) dtLocIntDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterests.dtLocIntDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnAdditionalInterestID = this.Columns["AdditionalInterestID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnAdditionalInterestID = new DataColumn("AdditionalInterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestID);
      this.columnLocationID.AllowDBNull = false;
      this.columnAdditionalInterestID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtLocIntRow NewdtLocIntRow()
    {
      return (dsAdditionalInterests.dtLocIntRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterests.dtLocIntRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterests.dtLocIntRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocIntRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtLocIntRowChangeEventHandler intRowChangedEvent = this.dtLocIntRowChangedEvent;
      if (intRowChangedEvent == null)
        return;
      intRowChangedEvent((object) this, new dsAdditionalInterests.dtLocIntRowChangeEvent((dsAdditionalInterests.dtLocIntRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocIntRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtLocIntRowChangeEventHandler rowChangingEvent = this.dtLocIntRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalInterests.dtLocIntRowChangeEvent((dsAdditionalInterests.dtLocIntRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocIntRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtLocIntRowChangeEventHandler intRowDeletedEvent = this.dtLocIntRowDeletedEvent;
      if (intRowDeletedEvent == null)
        return;
      intRowDeletedEvent((object) this, new dsAdditionalInterests.dtLocIntRowChangeEvent((dsAdditionalInterests.dtLocIntRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocIntRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalInterests.dtLocIntRowChangeEventHandler rowDeletingEvent = this.dtLocIntRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalInterests.dtLocIntRowChangeEvent((dsAdditionalInterests.dtLocIntRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtLocIntRow(dsAdditionalInterests.dtLocIntRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterests additionalInterests = new dsAdditionalInterests();
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
        FixedValue = additionalInterests.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtLocIntDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterests.GetSchemaSerializable();
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

  public class tblQuoteAdditionalInterestsRow : DataRow
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable tabletblQuoteAdditionalInterests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAdditionalInterests = (dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterests.IDColumn]);
      set => this[this.tabletblQuoteAdditionalInterests.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AdditionalInterestGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteAdditionalInterests.AdditionalInterestGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterests.AdditionalInterestGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterests.QuoteIDColumn]);
      set => this[this.tabletblQuoteAdditionalInterests.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InterestName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.InterestNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InterestName' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.InterestNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ISOCountryCode
    {
      get => Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.ISOCountryCodeColumn]);
      set => this[this.tabletblQuoteAdditionalInterests.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ModificationCode
    {
      get
      {
        return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.ModificationCodeColumn]);
      }
      set => this[this.tabletblQuoteAdditionalInterests.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Interest
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.InterestColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Interest' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.InterestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DescriptionText
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.DescriptionTextColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DescriptionText' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.DescriptionTextColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FEIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.FEINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FEIN' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.FEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LineID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterests.LineIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineID' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.LineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Billable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteAdditionalInterests.BillableColumn]);
      set => this[this.tabletblQuoteAdditionalInterests.BillableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal BillableAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteAdditionalInterests.BillableAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillableAmount' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.BillableAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AdditionalInterestTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterests.AdditionalInterestTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalInterestTypeID' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterests.AdditionalInterestTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Salutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.SalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Salutation' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string MiddleName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.MiddleNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MiddleName' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.MiddleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateOfBirth
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteAdditionalInterests.DateOfBirthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateOfBirth' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.DateOfBirthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CopyInterest
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblQuoteAdditionalInterests.CopyInterestColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CopyInterest' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.CopyInterestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Mobile
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.MobileColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Mobile' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.MobileColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime OfacCleared
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteAdditionalInterests.OfacClearedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfacCleared' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.OfacClearedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool GenerateDoc
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblQuoteAdditionalInterests.GenerateDocColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GenerateDoc' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.GenerateDocColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstLinesRow lstLinesRow
    {
      get
      {
        return (dsAdditionalInterests.lstLinesRow) this.GetParentRow(this.Table.ParentRelations["FK_lstLines_tblQuoteAdditionalInterests"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_lstLines_tblQuoteAdditionalInterests"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInterestNameNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.InterestNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInterestNameNull()
    {
      this[this.tabletblQuoteAdditionalInterests.InterestNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.Address1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblQuoteAdditionalInterests.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress2Null()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.Address2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblQuoteAdditionalInterests.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblQuoteAdditionalInterests.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblQuoteAdditionalInterests.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblQuoteAdditionalInterests.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblQuoteAdditionalInterests.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblQuoteAdditionalInterests.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblQuoteAdditionalInterests.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblQuoteAdditionalInterests.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblQuoteAdditionalInterests.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInterestNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.InterestColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInterestNull()
    {
      this[this.tabletblQuoteAdditionalInterests.InterestColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionTextNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.DescriptionTextColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionTextNull()
    {
      this[this.tabletblQuoteAdditionalInterests.DescriptionTextColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFEINNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.FEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFEINNull()
    {
      this[this.tabletblQuoteAdditionalInterests.FEINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineIDNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.LineIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineIDNull()
    {
      this[this.tabletblQuoteAdditionalInterests.LineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBillableAmountNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.BillableAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBillableAmountNull()
    {
      this[this.tabletblQuoteAdditionalInterests.BillableAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdditionalInterestTypeIDNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.AdditionalInterestTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAdditionalInterestTypeIDNull()
    {
      this[this.tabletblQuoteAdditionalInterests.AdditionalInterestTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSalutationNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.SalutationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSalutationNull()
    {
      this[this.tabletblQuoteAdditionalInterests.SalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.FirstNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabletblQuoteAdditionalInterests.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMiddleNameNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.MiddleNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMiddleNameNull()
    {
      this[this.tabletblQuoteAdditionalInterests.MiddleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.LastNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabletblQuoteAdditionalInterests.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateOfBirthNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.DateOfBirthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateOfBirthNull()
    {
      this[this.tabletblQuoteAdditionalInterests.DateOfBirthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCopyInterestNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.CopyInterestColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCopyInterestNull()
    {
      this[this.tabletblQuoteAdditionalInterests.CopyInterestColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMobileNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.MobileColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMobileNull()
    {
      this[this.tabletblQuoteAdditionalInterests.MobileColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblQuoteAdditionalInterests.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblQuoteAdditionalInterests.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfacClearedNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.OfacClearedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfacClearedNull()
    {
      this[this.tabletblQuoteAdditionalInterests.OfacClearedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGenerateDocNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.GenerateDocColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGenerateDocNull()
    {
      this[this.tabletblQuoteAdditionalInterests.GenerateDocColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow[] GettblQuoteAdditionalInterestsNetRateVehiclesRows()
    {
      return this.Table.ChildRelations["FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow[]) this.GetChildRows(this.Table.ChildRelations["FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow[] GettblQuoteAdditionalInterestsNetRateLocationsRows()
    {
      return this.Table.ChildRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow[] GettblQuoteAdditionalInterestsLocationsRows()
    {
      return this.Table.ChildRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[] GettblQuoteAdditionalInterestTypesRows()
    {
      return this.Table.ChildRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[0];
    }
  }

  public class tblQuoteAdditionalInterestTypesRow : DataRow
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable tabletblQuoteAdditionalInterestTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAdditionalInterestTypes = (dsAdditionalInterests.tblQuoteAdditionalInterestTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AdditionalInterestID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdditionalInterestType
    {
      get
      {
        return Conversions.ToString(this[this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestTypeColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestTypes.AdditionalInterestTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstAdditionalInterestTypesRow lstAdditionalInterestTypesRow
    {
      get
      {
        return (dsAdditionalInterests.lstAdditionalInterestTypesRow) this.GetParentRow(this.Table.ParentRelations["lstAdditionalInterestTypestblQuoteAdditionalInterestTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstAdditionalInterestTypestblQuoteAdditionalInterestTypes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow tblQuoteAdditionalInterestsRow
    {
      get
      {
        return (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes"]);
      }
    }
  }

  public class lstAdditionalInterestTypesRow : DataRow
  {
    private dsAdditionalInterests.lstAdditionalInterestTypesDataTable tablelstAdditionalInterestTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdditionalInterestTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAdditionalInterestTypes = (dsAdditionalInterests.lstAdditionalInterestTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InterestType
    {
      get => Conversions.ToString(this[this.tablelstAdditionalInterestTypes.InterestTypeColumn]);
      set => this[this.tablelstAdditionalInterestTypes.InterestTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdditionalInterest
    {
      get
      {
        return Conversions.ToString(this[this.tablelstAdditionalInterestTypes.AdditionalInterestColumn]);
      }
      set => this[this.tablelstAdditionalInterestTypes.AdditionalInterestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AddressRequired
    {
      get
      {
        return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.AddressRequiredColumn]);
      }
      set => this[this.tablelstAdditionalInterestTypes.AddressRequiredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool LocationRequired
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.LocationRequiredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationRequired' in table 'lstAdditionalInterestTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalInterestTypes.LocationRequiredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool VehicleRequired
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.VehicleRequiredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VehicleRequired' in table 'lstAdditionalInterestTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalInterestTypes.VehicleRequiredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.IsDisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsDisabled' in table 'lstAdditionalInterestTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalInterestTypes.IsDisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationRequiredNull()
    {
      return this.IsNull(this.tablelstAdditionalInterestTypes.LocationRequiredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationRequiredNull()
    {
      this[this.tablelstAdditionalInterestTypes.LocationRequiredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsVehicleRequiredNull()
    {
      return this.IsNull(this.tablelstAdditionalInterestTypes.VehicleRequiredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetVehicleRequiredNull()
    {
      this[this.tablelstAdditionalInterestTypes.VehicleRequiredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIsDisabledNull()
    {
      return this.IsNull(this.tablelstAdditionalInterestTypes.IsDisabledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIsDisabledNull()
    {
      this[this.tablelstAdditionalInterestTypes.IsDisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[] GettblQuoteAdditionalInterestTypesRows()
    {
      return this.Table.ChildRelations["lstAdditionalInterestTypestblQuoteAdditionalInterestTypes"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[]) this.GetChildRows(this.Table.ChildRelations["lstAdditionalInterestTypestblQuoteAdditionalInterestTypes"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[0];
    }
  }

  public class tblQuoteAdditionalInterestsLocationsRow : DataRow
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable tabletblQuoteAdditionalInterestsLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAdditionalInterestsLocations = (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AdditionalInterestID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsLocations.AdditionalInterestIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsLocations.AdditionalInterestIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int UnderwritingLocationID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsLocations.UnderwritingLocationIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsLocations.UnderwritingLocationIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblUnderwritingLocationsRow tblUnderwritingLocationsRow
    {
      get
      {
        return (dsAdditionalInterests.tblUnderwritingLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblUnderwritingLocationstblQuoteAdditionalInterestsLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUnderwritingLocationstblQuoteAdditionalInterestsLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow tblQuoteAdditionalInterestsRow
    {
      get
      {
        return (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations"]);
      }
    }
  }

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsAdditionalInterests.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsAdditionalInterests.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.Address1Column]);
      set => this[this.tabletblUnderwritingLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BuildingNo
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.BuildingNoColumn]);
      set => this[this.tabletblUnderwritingLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PhysicalBuildingNo
    {
      get
      {
        return Conversions.ToString(this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn]);
      }
      set => this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationNo
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationNoColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow[] GettblQuoteAdditionalInterestsLocationsRows()
    {
      return this.Table.ChildRelations["tblUnderwritingLocationstblQuoteAdditionalInterestsLocations"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblUnderwritingLocationstblQuoteAdditionalInterestsLocations"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow[0];
    }
  }

  public class tblNetRateLocationsRow : DataRow
  {
    private dsAdditionalInterests.tblNetRateLocationsDataTable tabletblNetRateLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNetRateLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNetRateLocations = (dsAdditionalInterests.tblNetRateLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateLocations.LocationIDColumn]);
      set => this[this.tabletblNetRateLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateLocations.LocationNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationNumber' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.LocationNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BuildingNumber
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateLocations.BuildingNumberColumn]);
      set => this[this.tabletblNetRateLocations.BuildingNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateLocations.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateLocations.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateLocations.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateLocations.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StreetSecondaryLocation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateLocations.StreetSecondaryLocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StreetSecondaryLocation' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.StreetSecondaryLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BuildingIdentifier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateLocations.BuildingIdentifierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BuildingIdentifier' in table 'tblNetRateLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateLocations.BuildingIdentifierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNumberNull()
    {
      return this.IsNull(this.tabletblNetRateLocations.LocationNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNumberNull()
    {
      this[this.tabletblNetRateLocations.LocationNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tabletblNetRateLocations.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tabletblNetRateLocations.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblNetRateLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblNetRateLocations.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblNetRateLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblNetRateLocations.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblNetRateLocations.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblNetRateLocations.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStreetSecondaryLocationNull()
    {
      return this.IsNull(this.tabletblNetRateLocations.StreetSecondaryLocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStreetSecondaryLocationNull()
    {
      this[this.tabletblNetRateLocations.StreetSecondaryLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBuildingIdentifierNull()
    {
      return this.IsNull(this.tabletblNetRateLocations.BuildingIdentifierColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBuildingIdentifierNull()
    {
      this[this.tabletblNetRateLocations.BuildingIdentifierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow[] GettblQuoteAdditionalInterestsNetRateLocationsRows()
    {
      return this.Table.ChildRelations["tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow[0];
    }
  }

  public class tblQuoteAdditionalInterestsNetRateLocationsRow : DataRow
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable tabletblQuoteAdditionalInterestsNetRateLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsNetRateLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAdditionalInterestsNetRateLocations = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AdditionalInterestID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsNetRateLocations.AdditionalInterestIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsNetRateLocations.AdditionalInterestIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NetRateLocationID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateLocationIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateLocationIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NetRateBuildingNumber
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateBuildingNumberColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsNetRateLocations.NetRateBuildingNumberColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateLocationsRow tblNetRateLocationsRowParent
    {
      get
      {
        return (dsAdditionalInterests.tblNetRateLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblNetRateLocationstblQuoteAdditionalInterestsNetRateLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow tblQuoteAdditionalInterestsRow
    {
      get
      {
        return (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations"]);
      }
    }
  }

  public class lstLinesRow : DataRow
  {
    private dsAdditionalInterests.lstLinesDataTable tablelstLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLines = (dsAdditionalInterests.lstLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LineID
    {
      get => Conversions.ToInteger(this[this.tablelstLines.LineIDColumn]);
      set => this[this.tablelstLines.LineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tablelstLines.LineNameColumn]);
      set => this[this.tablelstLines.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow[] GettblQuoteAdditionalInterestsRows()
    {
      return this.Table.ChildRelations["FK_lstLines_tblQuoteAdditionalInterests"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsRow[]) this.GetChildRows(this.Table.ChildRelations["FK_lstLines_tblQuoteAdditionalInterests"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsRow[0];
    }
  }

  public class tblQuoteAdditionalInterestsNetRateVehiclesRow : DataRow
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable tabletblQuoteAdditionalInterestsNetRateVehicles;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteAdditionalInterestsNetRateVehiclesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAdditionalInterestsNetRateVehicles = (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AdditionalInterestID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsNetRateVehicles.AdditionalInterestIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsNetRateVehicles.AdditionalInterestIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int VehicleID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterestsNetRateVehicles.VehicleIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteAdditionalInterestsNetRateVehicles.VehicleIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateVehiclesRow tblNetRateVehiclesRow
    {
      get
      {
        return (dsAdditionalInterests.tblNetRateVehiclesRow) this.GetParentRow(this.Table.ParentRelations["FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow tblQuoteAdditionalInterestsRow
    {
      get
      {
        return (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) this.GetParentRow(this.Table.ParentRelations["FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles"]);
      }
    }
  }

  public class tblNetRateVehiclesRow : DataRow
  {
    private dsAdditionalInterests.tblNetRateVehiclesDataTable tabletblNetRateVehicles;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNetRateVehiclesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNetRateVehicles = (dsAdditionalInterests.tblNetRateVehiclesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int VehicleID
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateVehicles.VehicleIDColumn]);
      set => this[this.tabletblNetRateVehicles.VehicleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int VehicleNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateVehicles.VehicleNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VehicleNumber' in table 'tblNetRateVehicles' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateVehicles.VehicleNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Make
    {
      get
      {
        return !this.IsMakeNull() ? Conversions.ToString(this[this.tabletblNetRateVehicles.MakeColumn]) : (string) null;
      }
      set => this[this.tabletblNetRateVehicles.MakeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Model
    {
      get
      {
        return !this.IsModelNull() ? Conversions.ToString(this[this.tabletblNetRateVehicles.ModelColumn]) : (string) null;
      }
      set => this[this.tabletblNetRateVehicles.ModelColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Year
    {
      get
      {
        return !this.IsYearNull() ? Conversions.ToString(this[this.tabletblNetRateVehicles.YearColumn]) : (string) null;
      }
      set => this[this.tabletblNetRateVehicles.YearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string VIN
    {
      get
      {
        return !this.IsVINNull() ? Conversions.ToString(this[this.tabletblNetRateVehicles.VINColumn]) : (string) null;
      }
      set => this[this.tabletblNetRateVehicles.VINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateVehicles.LocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationID' in table 'tblNetRateVehicles' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateVehicles.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int VehicleUnitNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateVehicles.VehicleUnitNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VehicleUnitNumber' in table 'tblNetRateVehicles' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateVehicles.VehicleUnitNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsVehicleNumberNull()
    {
      return this.IsNull(this.tabletblNetRateVehicles.VehicleNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetVehicleNumberNull()
    {
      this[this.tabletblNetRateVehicles.VehicleNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMakeNull() => this.IsNull(this.tabletblNetRateVehicles.MakeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMakeNull()
    {
      this[this.tabletblNetRateVehicles.MakeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsModelNull() => this.IsNull(this.tabletblNetRateVehicles.ModelColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetModelNull()
    {
      this[this.tabletblNetRateVehicles.ModelColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsYearNull() => this.IsNull(this.tabletblNetRateVehicles.YearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetYearNull()
    {
      this[this.tabletblNetRateVehicles.YearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsVINNull() => this.IsNull(this.tabletblNetRateVehicles.VINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetVINNull()
    {
      this[this.tabletblNetRateVehicles.VINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationIDNull() => this.IsNull(this.tabletblNetRateVehicles.LocationIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationIDNull()
    {
      this[this.tabletblNetRateVehicles.LocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsVehicleUnitNumberNull()
    {
      return this.IsNull(this.tabletblNetRateVehicles.VehicleUnitNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetVehicleUnitNumberNull()
    {
      this[this.tabletblNetRateVehicles.VehicleUnitNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow[] GettblQuoteAdditionalInterestsNetRateVehiclesRows()
    {
      return this.Table.ChildRelations["FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles"] != null ? (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow[]) this.GetChildRows(this.Table.ChildRelations["FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles"]) : new dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow[0];
    }
  }

  public class tblAdditionalInterestsRow : DataRow
  {
    private dsAdditionalInterests.tblAdditionalInterestsDataTable tabletblAdditionalInterests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblAdditionalInterestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblAdditionalInterests = (dsAdditionalInterests.tblAdditionalInterestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InterestID
    {
      get => Conversions.ToInteger(this[this.tabletblAdditionalInterests.InterestIDColumn]);
      set => this[this.tabletblAdditionalInterests.InterestIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Interest
    {
      get => Conversions.ToString(this[this.tabletblAdditionalInterests.InterestColumn]);
      set => this[this.tabletblAdditionalInterests.InterestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.ISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdditionalInterests.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblAdditionalInterests.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblAdditionalInterests.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblAdditionalInterests.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblAdditionalInterests.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblAdditionalInterests.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblAdditionalInterests.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblAdditionalInterests.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblAdditionalInterests.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblAdditionalInterests.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblAdditionalInterests.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblAdditionalInterests.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblAdditionalInterests.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblAdditionalInterests.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tabletblAdditionalInterests.ISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblAdditionalInterests.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblAdditionalInterests.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblAdditionalInterests.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblAdditionalInterests.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstSalutationsRow : DataRow
  {
    private dsAdditionalInterests.lstSalutationsDataTable tablelstSalutations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstSalutationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSalutations = (dsAdditionalInterests.lstSalutationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Salutation
    {
      get => Conversions.ToString(this[this.tablelstSalutations.SalutationColumn]);
      set => this[this.tablelstSalutations.SalutationColumn] = (object) value;
    }
  }

  public class dtPreviousInterestRow : DataRow
  {
    private dsAdditionalInterests.dtPreviousInterestDataTable tabledtPreviousInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtPreviousInterestRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtPreviousInterest = (dsAdditionalInterests.dtPreviousInterestDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabledtPreviousInterest.IDColumn]);
      set => this[this.tabledtPreviousInterest.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid PreviousAdditionalInterestGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabledtPreviousInterest.PreviousAdditionalInterestGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PreviousAdditionalInterestGuid' in table 'dtPreviousInterest' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtPreviousInterest.PreviousAdditionalInterestGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPreviousAdditionalInterestGuidNull()
    {
      return this.IsNull(this.tabledtPreviousInterest.PreviousAdditionalInterestGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPreviousAdditionalInterestGuidNull()
    {
      this[this.tabledtPreviousInterest.PreviousAdditionalInterestGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtLocIntRow : DataRow
  {
    private dsAdditionalInterests.dtLocIntDataTable tabledtLocInt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtLocIntRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtLocInt = (dsAdditionalInterests.dtLocIntDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabledtLocInt.LocationIDColumn]);
      set => this[this.tabledtLocInt.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AdditionalInterestID
    {
      get => Conversions.ToInteger(this[this.tabledtLocInt.AdditionalInterestIDColumn]);
      set => this[this.tabledtLocInt.AdditionalInterestIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteAdditionalInterestsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsRowChangeEvent(
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteAdditionalInterestTypesRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestTypesRowChangeEvent(
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstAdditionalInterestTypesRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.lstAdditionalInterestTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdditionalInterestTypesRowChangeEvent(
      dsAdditionalInterests.lstAdditionalInterestTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstAdditionalInterestTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteAdditionalInterestsLocationsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsLocationsRowChangeEvent(
      dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsAdditionalInterests.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblNetRateLocationsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblNetRateLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNetRateLocationsRowChangeEvent(
      dsAdditionalInterests.tblNetRateLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsNetRateLocationsRowChangeEvent(
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow Row
    {
      get => this.eventRow;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstLinesRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.lstLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesRowChangeEvent(dsAdditionalInterests.lstLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteAdditionalInterestsNetRateVehiclesRowChangeEvent(
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblNetRateVehiclesRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblNetRateVehiclesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNetRateVehiclesRowChangeEvent(
      dsAdditionalInterests.tblNetRateVehiclesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblNetRateVehiclesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblAdditionalInterestsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.tblAdditionalInterestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblAdditionalInterestsRowChangeEvent(
      dsAdditionalInterests.tblAdditionalInterestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.tblAdditionalInterestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstSalutationsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.lstSalutationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstSalutationsRowChangeEvent(
      dsAdditionalInterests.lstSalutationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.lstSalutationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtPreviousInterestRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.dtPreviousInterestRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtPreviousInterestRowChangeEvent(
      dsAdditionalInterests.dtPreviousInterestRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtPreviousInterestRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtLocIntRowChangeEvent : EventArgs
  {
    private dsAdditionalInterests.dtLocIntRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtLocIntRowChangeEvent(dsAdditionalInterests.dtLocIntRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdditionalInterests.dtLocIntRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
