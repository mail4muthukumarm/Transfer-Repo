// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsDriverInfo
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsDriverInfo")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsDriverInfo : DataSet
{
  private dsDriverInfo.lstDriverStatusDataTable tablelstDriverStatus;
  private dsDriverInfo.tblDriverInfoDataTable tabletblDriverInfo;
  private dsDriverInfo.lstStatesDataTable tablelstStates;
  private dsDriverInfo.lstDriverStatusInfoDataTable tablelstDriverStatusInfo;
  private dsDriverInfo.tblADRDataTable tabletblADR;
  private dsDriverInfo.dtDriverInfoDataTable tabledtDriverInfo;
  private dsDriverInfo.dtOrderingDataTable tabledtOrdering;
  private dsDriverInfo.tblUsersDataTable tabletblUsers;
  private dsDriverInfo.dtQueryDataTable tabledtQuery;
  private dsDriverInfo.lstDriverCDLDataTable tablelstDriverCDL;
  private dsDriverInfo.tblDriverProductStatesDataTable tabletblDriverProductStates;
  private dsDriverInfo.dtProductsDataTable tabledtProducts;
  private dsDriverInfo.dtOptionsDataTable tabledtOptions;
  private dsDriverInfo.tblDriverReqsDataTable tabletblDriverReqs;
  private dsDriverInfo.tblDriverLicenseValidationStatesDataTable tabletblDriverLicenseValidationStates;
  private dsDriverInfo.dtIIXDataTable tabledtIIX;
  private dsDriverInfo.lstIIXMVRTypesDataTable tablelstIIXMVRTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsDriverInfo()
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
  protected dsDriverInfo(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstDriverStatus)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.lstDriverStatusDataTable(dataSet.Tables[nameof (lstDriverStatus)]));
        if (dataSet.Tables[nameof (tblDriverInfo)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.tblDriverInfoDataTable(dataSet.Tables[nameof (tblDriverInfo)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (lstDriverStatusInfo)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.lstDriverStatusInfoDataTable(dataSet.Tables[nameof (lstDriverStatusInfo)]));
        if (dataSet.Tables[nameof (tblADR)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.tblADRDataTable(dataSet.Tables[nameof (tblADR)]));
        if (dataSet.Tables[nameof (dtDriverInfo)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.dtDriverInfoDataTable(dataSet.Tables[nameof (dtDriverInfo)]));
        if (dataSet.Tables[nameof (dtOrdering)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.dtOrderingDataTable(dataSet.Tables[nameof (dtOrdering)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (dtQuery)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.dtQueryDataTable(dataSet.Tables[nameof (dtQuery)]));
        if (dataSet.Tables[nameof (lstDriverCDL)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.lstDriverCDLDataTable(dataSet.Tables[nameof (lstDriverCDL)]));
        if (dataSet.Tables[nameof (tblDriverProductStates)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.tblDriverProductStatesDataTable(dataSet.Tables[nameof (tblDriverProductStates)]));
        if (dataSet.Tables[nameof (dtProducts)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.dtProductsDataTable(dataSet.Tables[nameof (dtProducts)]));
        if (dataSet.Tables[nameof (dtOptions)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.dtOptionsDataTable(dataSet.Tables[nameof (dtOptions)]));
        if (dataSet.Tables[nameof (tblDriverReqs)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.tblDriverReqsDataTable(dataSet.Tables[nameof (tblDriverReqs)]));
        if (dataSet.Tables[nameof (tblDriverLicenseValidationStates)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.tblDriverLicenseValidationStatesDataTable(dataSet.Tables[nameof (tblDriverLicenseValidationStates)]));
        if (dataSet.Tables[nameof (dtIIX)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.dtIIXDataTable(dataSet.Tables[nameof (dtIIX)]));
        if (dataSet.Tables[nameof (lstIIXMVRTypes)] != null)
          base.Tables.Add((DataTable) new dsDriverInfo.lstIIXMVRTypesDataTable(dataSet.Tables[nameof (lstIIXMVRTypes)]));
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
  public dsDriverInfo.lstDriverStatusDataTable lstDriverStatus => this.tablelstDriverStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.tblDriverInfoDataTable tblDriverInfo => this.tabletblDriverInfo;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.lstDriverStatusInfoDataTable lstDriverStatusInfo
  {
    get => this.tablelstDriverStatusInfo;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.tblADRDataTable tblADR => this.tabletblADR;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.dtDriverInfoDataTable dtDriverInfo => this.tabledtDriverInfo;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.dtOrderingDataTable dtOrdering => this.tabledtOrdering;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.dtQueryDataTable dtQuery => this.tabledtQuery;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.lstDriverCDLDataTable lstDriverCDL => this.tablelstDriverCDL;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.tblDriverProductStatesDataTable tblDriverProductStates
  {
    get => this.tabletblDriverProductStates;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.dtProductsDataTable dtProducts => this.tabledtProducts;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.dtOptionsDataTable dtOptions => this.tabledtOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.tblDriverReqsDataTable tblDriverReqs => this.tabletblDriverReqs;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.tblDriverLicenseValidationStatesDataTable tblDriverLicenseValidationStates
  {
    get => this.tabletblDriverLicenseValidationStates;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.dtIIXDataTable dtIIX => this.tabledtIIX;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDriverInfo.lstIIXMVRTypesDataTable lstIIXMVRTypes => this.tablelstIIXMVRTypes;

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
    dsDriverInfo dsDriverInfo = (dsDriverInfo) base.Clone();
    dsDriverInfo.InitVars();
    dsDriverInfo.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsDriverInfo;
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
      if (dataSet.Tables["lstDriverStatus"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.lstDriverStatusDataTable(dataSet.Tables["lstDriverStatus"]));
      if (dataSet.Tables["tblDriverInfo"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.tblDriverInfoDataTable(dataSet.Tables["tblDriverInfo"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["lstDriverStatusInfo"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.lstDriverStatusInfoDataTable(dataSet.Tables["lstDriverStatusInfo"]));
      if (dataSet.Tables["tblADR"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.tblADRDataTable(dataSet.Tables["tblADR"]));
      if (dataSet.Tables["dtDriverInfo"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.dtDriverInfoDataTable(dataSet.Tables["dtDriverInfo"]));
      if (dataSet.Tables["dtOrdering"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.dtOrderingDataTable(dataSet.Tables["dtOrdering"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["dtQuery"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.dtQueryDataTable(dataSet.Tables["dtQuery"]));
      if (dataSet.Tables["lstDriverCDL"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.lstDriverCDLDataTable(dataSet.Tables["lstDriverCDL"]));
      if (dataSet.Tables["tblDriverProductStates"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.tblDriverProductStatesDataTable(dataSet.Tables["tblDriverProductStates"]));
      if (dataSet.Tables["dtProducts"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.dtProductsDataTable(dataSet.Tables["dtProducts"]));
      if (dataSet.Tables["dtOptions"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.dtOptionsDataTable(dataSet.Tables["dtOptions"]));
      if (dataSet.Tables["tblDriverReqs"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.tblDriverReqsDataTable(dataSet.Tables["tblDriverReqs"]));
      if (dataSet.Tables["tblDriverLicenseValidationStates"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.tblDriverLicenseValidationStatesDataTable(dataSet.Tables["tblDriverLicenseValidationStates"]));
      if (dataSet.Tables["dtIIX"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.dtIIXDataTable(dataSet.Tables["dtIIX"]));
      if (dataSet.Tables["lstIIXMVRTypes"] != null)
        base.Tables.Add((DataTable) new dsDriverInfo.lstIIXMVRTypesDataTable(dataSet.Tables["lstIIXMVRTypes"]));
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
    this.tablelstDriverStatus = (dsDriverInfo.lstDriverStatusDataTable) base.Tables["lstDriverStatus"];
    if (initTable && this.tablelstDriverStatus != null)
      this.tablelstDriverStatus.InitVars();
    this.tabletblDriverInfo = (dsDriverInfo.tblDriverInfoDataTable) base.Tables["tblDriverInfo"];
    if (initTable && this.tabletblDriverInfo != null)
      this.tabletblDriverInfo.InitVars();
    this.tablelstStates = (dsDriverInfo.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tablelstDriverStatusInfo = (dsDriverInfo.lstDriverStatusInfoDataTable) base.Tables["lstDriverStatusInfo"];
    if (initTable && this.tablelstDriverStatusInfo != null)
      this.tablelstDriverStatusInfo.InitVars();
    this.tabletblADR = (dsDriverInfo.tblADRDataTable) base.Tables["tblADR"];
    if (initTable && this.tabletblADR != null)
      this.tabletblADR.InitVars();
    this.tabledtDriverInfo = (dsDriverInfo.dtDriverInfoDataTable) base.Tables["dtDriverInfo"];
    if (initTable && this.tabledtDriverInfo != null)
      this.tabledtDriverInfo.InitVars();
    this.tabledtOrdering = (dsDriverInfo.dtOrderingDataTable) base.Tables["dtOrdering"];
    if (initTable && this.tabledtOrdering != null)
      this.tabledtOrdering.InitVars();
    this.tabletblUsers = (dsDriverInfo.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabledtQuery = (dsDriverInfo.dtQueryDataTable) base.Tables["dtQuery"];
    if (initTable && this.tabledtQuery != null)
      this.tabledtQuery.InitVars();
    this.tablelstDriverCDL = (dsDriverInfo.lstDriverCDLDataTable) base.Tables["lstDriverCDL"];
    if (initTable && this.tablelstDriverCDL != null)
      this.tablelstDriverCDL.InitVars();
    this.tabletblDriverProductStates = (dsDriverInfo.tblDriverProductStatesDataTable) base.Tables["tblDriverProductStates"];
    if (initTable && this.tabletblDriverProductStates != null)
      this.tabletblDriverProductStates.InitVars();
    this.tabledtProducts = (dsDriverInfo.dtProductsDataTable) base.Tables["dtProducts"];
    if (initTable && this.tabledtProducts != null)
      this.tabledtProducts.InitVars();
    this.tabledtOptions = (dsDriverInfo.dtOptionsDataTable) base.Tables["dtOptions"];
    if (initTable && this.tabledtOptions != null)
      this.tabledtOptions.InitVars();
    this.tabletblDriverReqs = (dsDriverInfo.tblDriverReqsDataTable) base.Tables["tblDriverReqs"];
    if (initTable && this.tabletblDriverReqs != null)
      this.tabletblDriverReqs.InitVars();
    this.tabletblDriverLicenseValidationStates = (dsDriverInfo.tblDriverLicenseValidationStatesDataTable) base.Tables["tblDriverLicenseValidationStates"];
    if (initTable && this.tabletblDriverLicenseValidationStates != null)
      this.tabletblDriverLicenseValidationStates.InitVars();
    this.tabledtIIX = (dsDriverInfo.dtIIXDataTable) base.Tables["dtIIX"];
    if (initTable && this.tabledtIIX != null)
      this.tabledtIIX.InitVars();
    this.tablelstIIXMVRTypes = (dsDriverInfo.lstIIXMVRTypesDataTable) base.Tables["lstIIXMVRTypes"];
    if (!initTable || this.tablelstIIXMVRTypes == null)
      return;
    this.tablelstIIXMVRTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsDriverInfo);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsDriverInfo.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstDriverStatus = new dsDriverInfo.lstDriverStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstDriverStatus);
    this.tabletblDriverInfo = new dsDriverInfo.tblDriverInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblDriverInfo);
    this.tablelstStates = new dsDriverInfo.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tablelstDriverStatusInfo = new dsDriverInfo.lstDriverStatusInfoDataTable();
    base.Tables.Add((DataTable) this.tablelstDriverStatusInfo);
    this.tabletblADR = new dsDriverInfo.tblADRDataTable();
    base.Tables.Add((DataTable) this.tabletblADR);
    this.tabledtDriverInfo = new dsDriverInfo.dtDriverInfoDataTable();
    base.Tables.Add((DataTable) this.tabledtDriverInfo);
    this.tabledtOrdering = new dsDriverInfo.dtOrderingDataTable();
    base.Tables.Add((DataTable) this.tabledtOrdering);
    this.tabletblUsers = new dsDriverInfo.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabledtQuery = new dsDriverInfo.dtQueryDataTable();
    base.Tables.Add((DataTable) this.tabledtQuery);
    this.tablelstDriverCDL = new dsDriverInfo.lstDriverCDLDataTable();
    base.Tables.Add((DataTable) this.tablelstDriverCDL);
    this.tabletblDriverProductStates = new dsDriverInfo.tblDriverProductStatesDataTable();
    base.Tables.Add((DataTable) this.tabletblDriverProductStates);
    this.tabledtProducts = new dsDriverInfo.dtProductsDataTable();
    base.Tables.Add((DataTable) this.tabledtProducts);
    this.tabledtOptions = new dsDriverInfo.dtOptionsDataTable();
    base.Tables.Add((DataTable) this.tabledtOptions);
    this.tabletblDriverReqs = new dsDriverInfo.tblDriverReqsDataTable();
    base.Tables.Add((DataTable) this.tabletblDriverReqs);
    this.tabletblDriverLicenseValidationStates = new dsDriverInfo.tblDriverLicenseValidationStatesDataTable();
    base.Tables.Add((DataTable) this.tabletblDriverLicenseValidationStates);
    this.tabledtIIX = new dsDriverInfo.dtIIXDataTable();
    base.Tables.Add((DataTable) this.tabledtIIX);
    this.tablelstIIXMVRTypes = new dsDriverInfo.lstIIXMVRTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstIIXMVRTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstDriverStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblDriverInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstDriverStatusInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblADR() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtDriverInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtOrdering() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtQuery() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstDriverCDL() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblDriverProductStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtProducts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblDriverReqs() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblDriverLicenseValidationStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtIIX() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstIIXMVRTypes() => false;

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
    dsDriverInfo dsDriverInfo = new dsDriverInfo();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsDriverInfo.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public delegate void lstDriverStatusRowChangeEventHandler(
    object sender,
    dsDriverInfo.lstDriverStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblDriverInfoRowChangeEventHandler(
    object sender,
    dsDriverInfo.tblDriverInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsDriverInfo.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstDriverStatusInfoRowChangeEventHandler(
    object sender,
    dsDriverInfo.lstDriverStatusInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblADRRowChangeEventHandler(
    object sender,
    dsDriverInfo.tblADRRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtDriverInfoRowChangeEventHandler(
    object sender,
    dsDriverInfo.dtDriverInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtOrderingRowChangeEventHandler(
    object sender,
    dsDriverInfo.dtOrderingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsDriverInfo.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtQueryRowChangeEventHandler(
    object sender,
    dsDriverInfo.dtQueryRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstDriverCDLRowChangeEventHandler(
    object sender,
    dsDriverInfo.lstDriverCDLRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblDriverProductStatesRowChangeEventHandler(
    object sender,
    dsDriverInfo.tblDriverProductStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtProductsRowChangeEventHandler(
    object sender,
    dsDriverInfo.dtProductsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtOptionsRowChangeEventHandler(
    object sender,
    dsDriverInfo.dtOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblDriverReqsRowChangeEventHandler(
    object sender,
    dsDriverInfo.tblDriverReqsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblDriverLicenseValidationStatesRowChangeEventHandler(
    object sender,
    dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtIIXRowChangeEventHandler(object sender, dsDriverInfo.dtIIXRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstIIXMVRTypesRowChangeEventHandler(
    object sender,
    dsDriverInfo.lstIIXMVRTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstDriverStatusDataTable : TypedTableBase<dsDriverInfo.lstDriverStatusRow>
  {
    private DataColumn columnDriverStatusID;
    private DataColumn columnStatus;
    private DataColumn columnInactive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDriverStatusDataTable()
    {
      this.TableName = "lstDriverStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDriverStatusDataTable(DataTable table)
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
    protected lstDriverStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverStatusIDColumn => this.columnDriverStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InactiveColumn => this.columnInactive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusRow this[int index]
    {
      get => (dsDriverInfo.lstDriverStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusRowChangeEventHandler lstDriverStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusRowChangeEventHandler lstDriverStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusRowChangeEventHandler lstDriverStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusRowChangeEventHandler lstDriverStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstDriverStatusRow(dsDriverInfo.lstDriverStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusRow AddlstDriverStatusRow(string Status, bool Inactive)
    {
      dsDriverInfo.lstDriverStatusRow row = (dsDriverInfo.lstDriverStatusRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) Status,
        (object) Inactive
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusRow FindByDriverStatusID(int DriverStatusID)
    {
      return (dsDriverInfo.lstDriverStatusRow) this.Rows.Find(new object[1]
      {
        (object) DriverStatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.lstDriverStatusDataTable driverStatusDataTable = (dsDriverInfo.lstDriverStatusDataTable) base.Clone();
      driverStatusDataTable.InitVars();
      return (DataTable) driverStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.lstDriverStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverStatusID = this.Columns["DriverStatusID"];
      this.columnStatus = this.Columns["Status"];
      this.columnInactive = this.Columns["Inactive"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverStatusID = new DataColumn("DriverStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverStatusID);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnInactive = new DataColumn("Inactive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInactive);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverStatusID
      }, true));
      this.columnDriverStatusID.AutoIncrement = true;
      this.columnDriverStatusID.AutoIncrementSeed = -1L;
      this.columnDriverStatusID.AutoIncrementStep = -1L;
      this.columnDriverStatusID.AllowDBNull = false;
      this.columnDriverStatusID.ReadOnly = true;
      this.columnDriverStatusID.Unique = true;
      this.columnStatus.AllowDBNull = false;
      this.columnStatus.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusRow NewlstDriverStatusRow()
    {
      return (dsDriverInfo.lstDriverStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.lstDriverStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.lstDriverStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusRowChangeEventHandler statusRowChangedEvent = this.lstDriverStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsDriverInfo.lstDriverStatusRowChangeEvent((dsDriverInfo.lstDriverStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusRowChangeEventHandler rowChangingEvent = this.lstDriverStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.lstDriverStatusRowChangeEvent((dsDriverInfo.lstDriverStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusRowChangeEventHandler statusRowDeletedEvent = this.lstDriverStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsDriverInfo.lstDriverStatusRowChangeEvent((dsDriverInfo.lstDriverStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusRowChangeEventHandler rowDeletingEvent = this.lstDriverStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.lstDriverStatusRowChangeEvent((dsDriverInfo.lstDriverStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstDriverStatusRow(dsDriverInfo.lstDriverStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDriverStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class tblDriverInfoDataTable : TypedTableBase<dsDriverInfo.tblDriverInfoRow>
  {
    private DataColumn columnDriverID;
    private DataColumn columnControlNo;
    private DataColumn columnQuoteGuid;
    private DataColumn columnFirstName;
    private DataColumn columnLastName;
    private DataColumn columnDOB;
    private DataColumn columnLicenseNumber;
    private DataColumn columnStateID;
    private DataColumn columnStatusID;
    private DataColumn columnDateAdded;
    private DataColumn columnDriverDeleted;
    private DataColumn columnDriverAdded;
    private DataColumn columnNumberOfPoints;
    private DataColumn columnFurnishedCar;
    private DataColumn columnComments;
    private DataColumn columnFullPartTime;
    private DataColumn columnCopyOnRenewal;
    private DataColumn columnModifiedDate;
    private DataColumn columnLicenseExpDate;
    private DataColumn columnStreet1;
    private DataColumn columnStreet2;
    private DataColumn columnCity;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnDriverRatingFactor;
    private DataColumn columnLicenseClass;
    private DataColumn columnADR;
    private DataColumn columnNumAtFaultAcc;
    private DataColumn columnNumOtherAcc;
    private DataColumn columnSpeedingLessTenMPH;
    private DataColumn columnSpeedingMoreTenMPH;
    private DataColumn columnSecVltns;
    private DataColumn columnEquipVltns;
    private DataColumn columnOtherMovingVltns;
    private DataColumn columnTotalVtlns;
    private DataColumn columnMedicalExpiration;
    private DataColumn columnNoteRecipient;
    private DataColumn columnNoteSubject;
    private DataColumn columnNoteBody;
    private DataColumn columnDaysDue;
    private DataColumn columnPopUpNote;
    private DataColumn columnDateOfHire;
    private DataColumn columnDateOfOrigCDL;
    private DataColumn columnYearsLogTruckExperienceNum;
    private DataColumn columnMVRDate;
    private DataColumn columnCDLDriverID;
    private DataColumn columnDriverExcluded;
    private DataColumn columnGenerateDoc;
    private DataColumn columnDOC;
    private DataColumn columnJobTitle;
    private DataColumn columnLicenseNumberEncrypted;
    private DataColumn columnDOBEncrypted;
    private DataColumn columnBulkDelete;
    private DataColumn columnTruVision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverInfoDataTable()
    {
      this.TableName = "tblDriverInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverInfoDataTable(DataTable table)
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
    protected tblDriverInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverIDColumn => this.columnDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverDeletedColumn => this.columnDriverDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverAddedColumn => this.columnDriverAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumberOfPointsColumn => this.columnNumberOfPoints;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FurnishedCarColumn => this.columnFurnishedCar;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullPartTimeColumn => this.columnFullPartTime;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CopyOnRenewalColumn => this.columnCopyOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ModifiedDateColumn => this.columnModifiedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseExpDateColumn => this.columnLicenseExpDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Street1Column => this.columnStreet1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Street2Column => this.columnStreet2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverRatingFactorColumn => this.columnDriverRatingFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseClassColumn => this.columnLicenseClass;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ADRColumn => this.columnADR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumAtFaultAccColumn => this.columnNumAtFaultAcc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumOtherAccColumn => this.columnNumOtherAcc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SpeedingLessTenMPHColumn => this.columnSpeedingLessTenMPH;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SpeedingMoreTenMPHColumn => this.columnSpeedingMoreTenMPH;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SecVltnsColumn => this.columnSecVltns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EquipVltnsColumn => this.columnEquipVltns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OtherMovingVltnsColumn => this.columnOtherMovingVltns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TotalVtlnsColumn => this.columnTotalVtlns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MedicalExpirationColumn => this.columnMedicalExpiration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteRecipientColumn => this.columnNoteRecipient;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteSubjectColumn => this.columnNoteSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteBodyColumn => this.columnNoteBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DaysDueColumn => this.columnDaysDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PopUpNoteColumn => this.columnPopUpNote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateOfHireColumn => this.columnDateOfHire;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateOfOrigCDLColumn => this.columnDateOfOrigCDL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn YearsLogTruckExperienceNumColumn => this.columnYearsLogTruckExperienceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MVRDateColumn => this.columnMVRDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CDLDriverIDColumn => this.columnCDLDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverExcludedColumn => this.columnDriverExcluded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GenerateDocColumn => this.columnGenerateDoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DOCColumn => this.columnDOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn JobTitleColumn => this.columnJobTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberEncryptedColumn => this.columnLicenseNumberEncrypted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DOBEncryptedColumn => this.columnDOBEncrypted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BulkDeleteColumn => this.columnBulkDelete;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TruVisionColumn => this.columnTruVision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverInfoRow this[int index]
    {
      get => (dsDriverInfo.tblDriverInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverInfoRowChangeEventHandler tblDriverInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverInfoRowChangeEventHandler tblDriverInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverInfoRowChangeEventHandler tblDriverInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverInfoRowChangeEventHandler tblDriverInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblDriverInfoRow(dsDriverInfo.tblDriverInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverInfoRow AddtblDriverInfoRow(
      int ControlNo,
      Guid QuoteGuid,
      string FirstName,
      string LastName,
      DateTime DOB,
      string LicenseNumber,
      string StateID,
      int StatusID,
      DateTime DateAdded,
      DateTime DriverDeleted,
      DateTime DriverAdded,
      string NumberOfPoints,
      bool FurnishedCar,
      string Comments,
      byte FullPartTime,
      bool CopyOnRenewal,
      DateTime ModifiedDate,
      DateTime LicenseExpDate,
      string Street1,
      string Street2,
      string City,
      string ZipCode,
      string ZipPlus,
      Decimal DriverRatingFactor,
      string LicenseClass,
      bool ADR,
      string NumAtFaultAcc,
      string NumOtherAcc,
      string SpeedingLessTenMPH,
      string SpeedingMoreTenMPH,
      string SecVltns,
      string EquipVltns,
      string OtherMovingVltns,
      string TotalVtlns,
      DateTime MedicalExpiration,
      Guid NoteRecipient,
      string NoteSubject,
      string NoteBody,
      int DaysDue,
      bool PopUpNote,
      DateTime DateOfHire,
      DateTime DateOfOrigCDL,
      int YearsLogTruckExperienceNum,
      DateTime MVRDate,
      int CDLDriverID,
      DateTime DriverExcluded,
      bool GenerateDoc,
      bool DOC,
      string JobTitle,
      string LicenseNumberEncrypted,
      string DOBEncrypted,
      bool BulkDelete,
      bool TruVision)
    {
      dsDriverInfo.tblDriverInfoRow row = (dsDriverInfo.tblDriverInfoRow) this.NewRow();
      object[] objArray = new object[54]
      {
        null,
        (object) ControlNo,
        (object) QuoteGuid,
        (object) FirstName,
        (object) LastName,
        (object) DOB,
        (object) LicenseNumber,
        (object) StateID,
        (object) StatusID,
        (object) DateAdded,
        (object) DriverDeleted,
        (object) DriverAdded,
        (object) NumberOfPoints,
        (object) FurnishedCar,
        (object) Comments,
        (object) FullPartTime,
        (object) CopyOnRenewal,
        (object) ModifiedDate,
        (object) LicenseExpDate,
        (object) Street1,
        (object) Street2,
        (object) City,
        (object) ZipCode,
        (object) ZipPlus,
        (object) DriverRatingFactor,
        (object) LicenseClass,
        (object) ADR,
        (object) NumAtFaultAcc,
        (object) NumOtherAcc,
        (object) SpeedingLessTenMPH,
        (object) SpeedingMoreTenMPH,
        (object) SecVltns,
        (object) EquipVltns,
        (object) OtherMovingVltns,
        (object) TotalVtlns,
        (object) MedicalExpiration,
        (object) NoteRecipient,
        (object) NoteSubject,
        (object) NoteBody,
        (object) DaysDue,
        (object) PopUpNote,
        (object) DateOfHire,
        (object) DateOfOrigCDL,
        (object) YearsLogTruckExperienceNum,
        (object) MVRDate,
        (object) CDLDriverID,
        (object) DriverExcluded,
        (object) GenerateDoc,
        (object) DOC,
        (object) JobTitle,
        (object) LicenseNumberEncrypted,
        (object) DOBEncrypted,
        (object) BulkDelete,
        (object) TruVision
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverInfoRow FindByDriverID(long DriverID)
    {
      return (dsDriverInfo.tblDriverInfoRow) this.Rows.Find(new object[1]
      {
        (object) DriverID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.tblDriverInfoDataTable driverInfoDataTable = (dsDriverInfo.tblDriverInfoDataTable) base.Clone();
      driverInfoDataTable.InitVars();
      return (DataTable) driverInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.tblDriverInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverID = this.Columns["DriverID"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnDOB = this.Columns["DOB"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnStateID = this.Columns["StateID"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnDriverDeleted = this.Columns["DriverDeleted"];
      this.columnDriverAdded = this.Columns["DriverAdded"];
      this.columnNumberOfPoints = this.Columns["NumberOfPoints"];
      this.columnFurnishedCar = this.Columns["FurnishedCar"];
      this.columnComments = this.Columns["Comments"];
      this.columnFullPartTime = this.Columns["FullPartTime"];
      this.columnCopyOnRenewal = this.Columns["CopyOnRenewal"];
      this.columnModifiedDate = this.Columns["ModifiedDate"];
      this.columnLicenseExpDate = this.Columns["LicenseExpDate"];
      this.columnStreet1 = this.Columns["Street1"];
      this.columnStreet2 = this.Columns["Street2"];
      this.columnCity = this.Columns["City"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnDriverRatingFactor = this.Columns["DriverRatingFactor"];
      this.columnLicenseClass = this.Columns["LicenseClass"];
      this.columnADR = this.Columns["ADR"];
      this.columnNumAtFaultAcc = this.Columns["NumAtFaultAcc"];
      this.columnNumOtherAcc = this.Columns["NumOtherAcc"];
      this.columnSpeedingLessTenMPH = this.Columns["SpeedingLessTenMPH"];
      this.columnSpeedingMoreTenMPH = this.Columns["SpeedingMoreTenMPH"];
      this.columnSecVltns = this.Columns["SecVltns"];
      this.columnEquipVltns = this.Columns["EquipVltns"];
      this.columnOtherMovingVltns = this.Columns["OtherMovingVltns"];
      this.columnTotalVtlns = this.Columns["TotalVtlns"];
      this.columnMedicalExpiration = this.Columns["MedicalExpiration"];
      this.columnNoteRecipient = this.Columns["NoteRecipient"];
      this.columnNoteSubject = this.Columns["NoteSubject"];
      this.columnNoteBody = this.Columns["NoteBody"];
      this.columnDaysDue = this.Columns["DaysDue"];
      this.columnPopUpNote = this.Columns["PopUpNote"];
      this.columnDateOfHire = this.Columns["DateOfHire"];
      this.columnDateOfOrigCDL = this.Columns["DateOfOrigCDL"];
      this.columnYearsLogTruckExperienceNum = this.Columns["YearsLogTruckExperienceNum"];
      this.columnMVRDate = this.Columns["MVRDate"];
      this.columnCDLDriverID = this.Columns["CDLDriverID"];
      this.columnDriverExcluded = this.Columns["DriverExcluded"];
      this.columnGenerateDoc = this.Columns["GenerateDoc"];
      this.columnDOC = this.Columns["DOC"];
      this.columnJobTitle = this.Columns["JobTitle"];
      this.columnLicenseNumberEncrypted = this.Columns["LicenseNumberEncrypted"];
      this.columnDOBEncrypted = this.Columns["DOBEncrypted"];
      this.columnBulkDelete = this.Columns["BulkDelete"];
      this.columnTruVision = this.Columns["TruVision"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverID = new DataColumn("DriverID", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverID);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnDriverDeleted = new DataColumn("DriverDeleted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverDeleted);
      this.columnDriverAdded = new DataColumn("DriverAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverAdded);
      this.columnNumberOfPoints = new DataColumn("NumberOfPoints", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumberOfPoints);
      this.columnFurnishedCar = new DataColumn("FurnishedCar", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFurnishedCar);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnFullPartTime = new DataColumn("FullPartTime", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullPartTime);
      this.columnCopyOnRenewal = new DataColumn("CopyOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCopyOnRenewal);
      this.columnModifiedDate = new DataColumn("ModifiedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiedDate);
      this.columnLicenseExpDate = new DataColumn("LicenseExpDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseExpDate);
      this.columnStreet1 = new DataColumn("Street1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet1);
      this.columnStreet2 = new DataColumn("Street2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnDriverRatingFactor = new DataColumn("DriverRatingFactor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverRatingFactor);
      this.columnLicenseClass = new DataColumn("LicenseClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseClass);
      this.columnADR = new DataColumn("ADR", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADR);
      this.columnNumAtFaultAcc = new DataColumn("NumAtFaultAcc", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumAtFaultAcc);
      this.columnNumOtherAcc = new DataColumn("NumOtherAcc", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumOtherAcc);
      this.columnSpeedingLessTenMPH = new DataColumn("SpeedingLessTenMPH", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpeedingLessTenMPH);
      this.columnSpeedingMoreTenMPH = new DataColumn("SpeedingMoreTenMPH", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpeedingMoreTenMPH);
      this.columnSecVltns = new DataColumn("SecVltns", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSecVltns);
      this.columnEquipVltns = new DataColumn("EquipVltns", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEquipVltns);
      this.columnOtherMovingVltns = new DataColumn("OtherMovingVltns", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherMovingVltns);
      this.columnTotalVtlns = new DataColumn("TotalVtlns", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalVtlns);
      this.columnMedicalExpiration = new DataColumn("MedicalExpiration", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMedicalExpiration);
      this.columnNoteRecipient = new DataColumn("NoteRecipient", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteRecipient);
      this.columnNoteSubject = new DataColumn("NoteSubject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteSubject);
      this.columnNoteBody = new DataColumn("NoteBody", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteBody);
      this.columnDaysDue = new DataColumn("DaysDue", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDaysDue);
      this.columnPopUpNote = new DataColumn("PopUpNote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPopUpNote);
      this.columnDateOfHire = new DataColumn("DateOfHire", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateOfHire);
      this.columnDateOfOrigCDL = new DataColumn("DateOfOrigCDL", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateOfOrigCDL);
      this.columnYearsLogTruckExperienceNum = new DataColumn("YearsLogTruckExperienceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearsLogTruckExperienceNum);
      this.columnMVRDate = new DataColumn("MVRDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMVRDate);
      this.columnCDLDriverID = new DataColumn("CDLDriverID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCDLDriverID);
      this.columnDriverExcluded = new DataColumn("DriverExcluded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverExcluded);
      this.columnGenerateDoc = new DataColumn("GenerateDoc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenerateDoc);
      this.columnDOC = new DataColumn("DOC", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOC);
      this.columnJobTitle = new DataColumn("JobTitle", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJobTitle);
      this.columnLicenseNumberEncrypted = new DataColumn("LicenseNumberEncrypted", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumberEncrypted);
      this.columnDOBEncrypted = new DataColumn("DOBEncrypted", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOBEncrypted);
      this.columnBulkDelete = new DataColumn("BulkDelete", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBulkDelete);
      this.columnTruVision = new DataColumn("TruVision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTruVision);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverID
      }, true));
      this.columnDriverID.AutoIncrement = true;
      this.columnDriverID.AutoIncrementSeed = -1L;
      this.columnDriverID.AutoIncrementStep = -1L;
      this.columnDriverID.AllowDBNull = false;
      this.columnDriverID.Unique = true;
      this.columnControlNo.AllowDBNull = false;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnFirstName.MaxLength = 100;
      this.columnLastName.MaxLength = 100;
      this.columnLicenseNumber.MaxLength = 50;
      this.columnStateID.MaxLength = 2;
      this.columnNumberOfPoints.MaxLength = 100;
      this.columnFurnishedCar.AllowDBNull = false;
      this.columnComments.MaxLength = 500;
      this.columnCopyOnRenewal.DefaultValue = (object) true;
      this.columnStreet1.MaxLength = 250;
      this.columnStreet2.MaxLength = 250;
      this.columnCity.MaxLength = 100;
      this.columnZipCode.MaxLength = 5;
      this.columnZipPlus.MaxLength = 4;
      this.columnPopUpNote.DefaultValue = (object) false;
      this.columnBulkDelete.DefaultValue = (object) false;
      this.columnTruVision.AllowDBNull = false;
      this.columnTruVision.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverInfoRow NewtblDriverInfoRow()
    {
      return (dsDriverInfo.tblDriverInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.tblDriverInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.tblDriverInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverInfoRowChangeEventHandler infoRowChangedEvent = this.tblDriverInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsDriverInfo.tblDriverInfoRowChangeEvent((dsDriverInfo.tblDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverInfoRowChangeEventHandler rowChangingEvent = this.tblDriverInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.tblDriverInfoRowChangeEvent((dsDriverInfo.tblDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverInfoRowChangeEventHandler infoRowDeletedEvent = this.tblDriverInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsDriverInfo.tblDriverInfoRowChangeEvent((dsDriverInfo.tblDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverInfoRowChangeEventHandler rowDeletingEvent = this.tblDriverInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.tblDriverInfoRowChangeEvent((dsDriverInfo.tblDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblDriverInfoRow(dsDriverInfo.tblDriverInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDriverInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsDriverInfo.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstStatesRow this[int index]
    {
      get => (dsDriverInfo.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstStatesRow(dsDriverInfo.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsDriverInfo.lstStatesRow row = (dsDriverInfo.lstStatesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstStatesRow FindByStateID(string StateID)
    {
      return (dsDriverInfo.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.lstStatesDataTable lstStatesDataTable = (dsDriverInfo.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstStatesRow NewlstStatesRow() => (dsDriverInfo.lstStatesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsDriverInfo.lstStatesRowChangeEvent((dsDriverInfo.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.lstStatesRowChangeEvent((dsDriverInfo.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsDriverInfo.lstStatesRowChangeEvent((dsDriverInfo.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.lstStatesRowChangeEvent((dsDriverInfo.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstStatesRow(dsDriverInfo.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class lstDriverStatusInfoDataTable : TypedTableBase<dsDriverInfo.lstDriverStatusInfoRow>
  {
    private DataColumn columnID;
    private DataColumn columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDriverStatusInfoDataTable()
    {
      this.TableName = "lstDriverStatusInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDriverStatusInfoDataTable(DataTable table)
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
    protected lstDriverStatusInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusInfoRow this[int index]
    {
      get => (dsDriverInfo.lstDriverStatusInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler lstDriverStatusInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler lstDriverStatusInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler lstDriverStatusInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler lstDriverStatusInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstDriverStatusInfoRow(dsDriverInfo.lstDriverStatusInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusInfoRow AddlstDriverStatusInfoRow(byte ID, string Status)
    {
      dsDriverInfo.lstDriverStatusInfoRow row = (dsDriverInfo.lstDriverStatusInfoRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Status
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusInfoRow FindByID(byte ID)
    {
      return (dsDriverInfo.lstDriverStatusInfoRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.lstDriverStatusInfoDataTable statusInfoDataTable = (dsDriverInfo.lstDriverStatusInfoDataTable) base.Clone();
      statusInfoDataTable.InitVars();
      return (DataTable) statusInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.lstDriverStatusInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnStatus = this.Columns["Status"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnStatus.AllowDBNull = false;
      this.columnStatus.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusInfoRow NewlstDriverStatusInfoRow()
    {
      return (dsDriverInfo.lstDriverStatusInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.lstDriverStatusInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.lstDriverStatusInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler infoRowChangedEvent = this.lstDriverStatusInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsDriverInfo.lstDriverStatusInfoRowChangeEvent((dsDriverInfo.lstDriverStatusInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler rowChangingEvent = this.lstDriverStatusInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.lstDriverStatusInfoRowChangeEvent((dsDriverInfo.lstDriverStatusInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler infoRowDeletedEvent = this.lstDriverStatusInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsDriverInfo.lstDriverStatusInfoRowChangeEvent((dsDriverInfo.lstDriverStatusInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverStatusInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverStatusInfoRowChangeEventHandler rowDeletingEvent = this.lstDriverStatusInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.lstDriverStatusInfoRowChangeEvent((dsDriverInfo.lstDriverStatusInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstDriverStatusInfoRow(dsDriverInfo.lstDriverStatusInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDriverStatusInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class tblADRDataTable : TypedTableBase<dsDriverInfo.tblADRRow>
  {
    private DataColumn columnADR_ID;
    private DataColumn columnAccountID;
    private DataColumn columnPurpose;
    private DataColumn columnProductID;
    private DataColumn columnOrderDate;
    private DataColumn columnReference;
    private DataColumn columnControl;
    private DataColumn columnValid;
    private DataColumn columnReklamiErrorCode;
    private DataColumn columnErrorCode;
    private DataColumn columnErrorDescription;
    private DataColumn columnResultBlob;
    private DataColumn columnRouting;
    private DataColumn columnTrackingNumber;
    private DataColumn columnBillCode;
    private DataColumn columnHost;
    private DataColumn columnLicenseNumber;
    private DataColumn columnLine;
    private DataColumn columnFirstName;
    private DataColumn columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblADRDataTable()
    {
      this.TableName = "tblADR";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblADRDataTable(DataTable table)
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
    protected tblADRDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ADR_IDColumn => this.columnADR_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AccountIDColumn => this.columnAccountID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PurposeColumn => this.columnPurpose;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProductIDColumn => this.columnProductID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OrderDateColumn => this.columnOrderDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReferenceColumn => this.columnReference;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlColumn => this.columnControl;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ValidColumn => this.columnValid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReklamiErrorCodeColumn => this.columnReklamiErrorCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ErrorCodeColumn => this.columnErrorCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ErrorDescriptionColumn => this.columnErrorDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ResultBlobColumn => this.columnResultBlob;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoutingColumn => this.columnRouting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TrackingNumberColumn => this.columnTrackingNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillCodeColumn => this.columnBillCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HostColumn => this.columnHost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblADRRow this[int index] => (dsDriverInfo.tblADRRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblADRRowChangeEventHandler tblADRRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblADRRowChangeEventHandler tblADRRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblADRRowChangeEventHandler tblADRRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblADRRowChangeEventHandler tblADRRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblADRRow(dsDriverInfo.tblADRRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblADRRow AddtblADRRow(
      string AccountID,
      string Purpose,
      string ProductID,
      DateTime OrderDate,
      string Reference,
      string Control,
      string Valid,
      string ReklamiErrorCode,
      string ErrorCode,
      string ErrorDescription,
      string ResultBlob,
      string Routing,
      string TrackingNumber,
      string BillCode,
      string Host,
      string LicenseNumber,
      string Line,
      string FirstName,
      string LastName)
    {
      dsDriverInfo.tblADRRow row = (dsDriverInfo.tblADRRow) this.NewRow();
      object[] objArray = new object[20]
      {
        null,
        (object) AccountID,
        (object) Purpose,
        (object) ProductID,
        (object) OrderDate,
        (object) Reference,
        (object) Control,
        (object) Valid,
        (object) ReklamiErrorCode,
        (object) ErrorCode,
        (object) ErrorDescription,
        (object) ResultBlob,
        (object) Routing,
        (object) TrackingNumber,
        (object) BillCode,
        (object) Host,
        (object) LicenseNumber,
        (object) Line,
        (object) FirstName,
        (object) LastName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblADRRow FindByADR_ID(int ADR_ID)
    {
      return (dsDriverInfo.tblADRRow) this.Rows.Find(new object[1]
      {
        (object) ADR_ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.tblADRDataTable tblAdrDataTable = (dsDriverInfo.tblADRDataTable) base.Clone();
      tblAdrDataTable.InitVars();
      return (DataTable) tblAdrDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsDriverInfo.tblADRDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnADR_ID = this.Columns["ADR_ID"];
      this.columnAccountID = this.Columns["AccountID"];
      this.columnPurpose = this.Columns["Purpose"];
      this.columnProductID = this.Columns["ProductID"];
      this.columnOrderDate = this.Columns["OrderDate"];
      this.columnReference = this.Columns["Reference"];
      this.columnControl = this.Columns["Control"];
      this.columnValid = this.Columns["Valid"];
      this.columnReklamiErrorCode = this.Columns["ReklamiErrorCode"];
      this.columnErrorCode = this.Columns["ErrorCode"];
      this.columnErrorDescription = this.Columns["ErrorDescription"];
      this.columnResultBlob = this.Columns["ResultBlob"];
      this.columnRouting = this.Columns["Routing"];
      this.columnTrackingNumber = this.Columns["TrackingNumber"];
      this.columnBillCode = this.Columns["BillCode"];
      this.columnHost = this.Columns["Host"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnLine = this.Columns["Line"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnLastName = this.Columns["LastName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnADR_ID = new DataColumn("ADR_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADR_ID);
      this.columnAccountID = new DataColumn("AccountID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountID);
      this.columnPurpose = new DataColumn("Purpose", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurpose);
      this.columnProductID = new DataColumn("ProductID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProductID);
      this.columnOrderDate = new DataColumn("OrderDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOrderDate);
      this.columnReference = new DataColumn("Reference", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReference);
      this.columnControl = new DataColumn("Control", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControl);
      this.columnValid = new DataColumn("Valid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValid);
      this.columnReklamiErrorCode = new DataColumn("ReklamiErrorCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReklamiErrorCode);
      this.columnErrorCode = new DataColumn("ErrorCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnErrorCode);
      this.columnErrorDescription = new DataColumn("ErrorDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnErrorDescription);
      this.columnResultBlob = new DataColumn("ResultBlob", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResultBlob);
      this.columnRouting = new DataColumn("Routing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRouting);
      this.columnTrackingNumber = new DataColumn("TrackingNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTrackingNumber);
      this.columnBillCode = new DataColumn("BillCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillCode);
      this.columnHost = new DataColumn("Host", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHost);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnADR_ID
      }, true));
      this.columnADR_ID.AutoIncrement = true;
      this.columnADR_ID.AutoIncrementSeed = -1L;
      this.columnADR_ID.AutoIncrementStep = -1L;
      this.columnADR_ID.AllowDBNull = false;
      this.columnADR_ID.ReadOnly = true;
      this.columnADR_ID.Unique = true;
      this.columnAccountID.AllowDBNull = false;
      this.columnAccountID.MaxLength = 15;
      this.columnPurpose.MaxLength = 10;
      this.columnProductID.MaxLength = 10;
      this.columnReference.MaxLength = 50;
      this.columnControl.MaxLength = 50;
      this.columnValid.MaxLength = 150;
      this.columnReklamiErrorCode.MaxLength = 50;
      this.columnErrorCode.MaxLength = 50;
      this.columnErrorDescription.MaxLength = 150;
      this.columnResultBlob.MaxLength = 8000;
      this.columnRouting.MaxLength = 50;
      this.columnTrackingNumber.MaxLength = 50;
      this.columnBillCode.MaxLength = 50;
      this.columnHost.MaxLength = 50;
      this.columnLicenseNumber.MaxLength = 50;
      this.columnLine.MaxLength = 100;
      this.columnFirstName.MaxLength = 50;
      this.columnLastName.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblADRRow NewtblADRRow() => (dsDriverInfo.tblADRRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.tblADRRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.tblADRRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblADRRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblADRRowChangeEventHandler adrRowChangedEvent = this.tblADRRowChangedEvent;
      if (adrRowChangedEvent == null)
        return;
      adrRowChangedEvent((object) this, new dsDriverInfo.tblADRRowChangeEvent((dsDriverInfo.tblADRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblADRRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblADRRowChangeEventHandler rowChangingEvent = this.tblADRRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.tblADRRowChangeEvent((dsDriverInfo.tblADRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblADRRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblADRRowChangeEventHandler adrRowDeletedEvent = this.tblADRRowDeletedEvent;
      if (adrRowDeletedEvent == null)
        return;
      adrRowDeletedEvent((object) this, new dsDriverInfo.tblADRRowChangeEvent((dsDriverInfo.tblADRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblADRRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblADRRowChangeEventHandler rowDeletingEvent = this.tblADRRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.tblADRRowChangeEvent((dsDriverInfo.tblADRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblADRRow(dsDriverInfo.tblADRRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblADRDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class dtDriverInfoDataTable : TypedTableBase<dsDriverInfo.dtDriverInfoRow>
  {
    private DataColumn columnDriverID;
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnQuoteGuid;
    private DataColumn columnQuoteStatus;
    private DataColumn columnFirstName;
    private DataColumn columnLastName;
    private DataColumn columnDOB;
    private DataColumn columnLicenseNumber;
    private DataColumn columnStateID;
    private DataColumn columnStatusID;
    private DataColumn columnDateAdded;
    private DataColumn columnDriverDeleted;
    private DataColumn columnDriverAdded;
    private DataColumn columnNumberOfPoints;
    private DataColumn columnFullPartTime;
    private DataColumn columnLicenseExpDate;
    private DataColumn columnStreet1;
    private DataColumn columnCity;
    private DataColumn columnZipCode;
    private DataColumn columnCopy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtDriverInfoDataTable()
    {
      this.TableName = "dtDriverInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtDriverInfoDataTable(DataTable table)
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
    protected dtDriverInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverIDColumn => this.columnDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusColumn => this.columnQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverDeletedColumn => this.columnDriverDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverAddedColumn => this.columnDriverAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumberOfPointsColumn => this.columnNumberOfPoints;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullPartTimeColumn => this.columnFullPartTime;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseExpDateColumn => this.columnLicenseExpDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Street1Column => this.columnStreet1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CopyColumn => this.columnCopy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtDriverInfoRow this[int index]
    {
      get => (dsDriverInfo.dtDriverInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtDriverInfoRowChangeEventHandler dtDriverInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtDriverInfoRowChangeEventHandler dtDriverInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtDriverInfoRowChangeEventHandler dtDriverInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtDriverInfoRowChangeEventHandler dtDriverInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtDriverInfoRow(dsDriverInfo.dtDriverInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtDriverInfoRow AdddtDriverInfoRow(
      int ControlNo,
      string PolicyNumber,
      Guid QuoteGuid,
      string QuoteStatus,
      string FirstName,
      string LastName,
      DateTime DOB,
      string LicenseNumber,
      string StateID,
      int StatusID,
      DateTime DateAdded,
      DateTime DriverDeleted,
      DateTime DriverAdded,
      string NumberOfPoints,
      byte FullPartTime,
      DateTime LicenseExpDate,
      string Street1,
      string City,
      string ZipCode,
      bool Copy)
    {
      dsDriverInfo.dtDriverInfoRow row = (dsDriverInfo.dtDriverInfoRow) this.NewRow();
      object[] objArray = new object[21]
      {
        null,
        (object) ControlNo,
        (object) PolicyNumber,
        (object) QuoteGuid,
        (object) QuoteStatus,
        (object) FirstName,
        (object) LastName,
        (object) DOB,
        (object) LicenseNumber,
        (object) StateID,
        (object) StatusID,
        (object) DateAdded,
        (object) DriverDeleted,
        (object) DriverAdded,
        (object) NumberOfPoints,
        (object) FullPartTime,
        (object) LicenseExpDate,
        (object) Street1,
        (object) City,
        (object) ZipCode,
        (object) Copy
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtDriverInfoRow FindByDriverID(long DriverID)
    {
      return (dsDriverInfo.dtDriverInfoRow) this.Rows.Find(new object[1]
      {
        (object) DriverID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.dtDriverInfoDataTable driverInfoDataTable = (dsDriverInfo.dtDriverInfoDataTable) base.Clone();
      driverInfoDataTable.InitVars();
      return (DataTable) driverInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.dtDriverInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverID = this.Columns["DriverID"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnQuoteStatus = this.Columns["QuoteStatus"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnDOB = this.Columns["DOB"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnStateID = this.Columns["StateID"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnDriverDeleted = this.Columns["DriverDeleted"];
      this.columnDriverAdded = this.Columns["DriverAdded"];
      this.columnNumberOfPoints = this.Columns["NumberOfPoints"];
      this.columnFullPartTime = this.Columns["FullPartTime"];
      this.columnLicenseExpDate = this.Columns["LicenseExpDate"];
      this.columnStreet1 = this.Columns["Street1"];
      this.columnCity = this.Columns["City"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnCopy = this.Columns["Copy"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverID = new DataColumn("DriverID", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverID);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnQuoteStatus = new DataColumn("QuoteStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatus);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnDriverDeleted = new DataColumn("DriverDeleted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverDeleted);
      this.columnDriverAdded = new DataColumn("DriverAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverAdded);
      this.columnNumberOfPoints = new DataColumn("NumberOfPoints", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumberOfPoints);
      this.columnFullPartTime = new DataColumn("FullPartTime", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullPartTime);
      this.columnLicenseExpDate = new DataColumn("LicenseExpDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseExpDate);
      this.columnStreet1 = new DataColumn("Street1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnCopy = new DataColumn("Copy", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCopy);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverID
      }, true));
      this.columnDriverID.AutoIncrement = true;
      this.columnDriverID.AutoIncrementSeed = -1L;
      this.columnDriverID.AutoIncrementStep = -1L;
      this.columnDriverID.AllowDBNull = false;
      this.columnDriverID.ReadOnly = true;
      this.columnDriverID.Unique = true;
      this.columnControlNo.AllowDBNull = false;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnFirstName.MaxLength = 100;
      this.columnLastName.MaxLength = 100;
      this.columnLicenseNumber.MaxLength = 50;
      this.columnStateID.MaxLength = 2;
      this.columnNumberOfPoints.MaxLength = 100;
      this.columnStreet1.MaxLength = 250;
      this.columnCity.MaxLength = 100;
      this.columnZipCode.MaxLength = 5;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtDriverInfoRow NewdtDriverInfoRow()
    {
      return (dsDriverInfo.dtDriverInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.dtDriverInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.dtDriverInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtDriverInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtDriverInfoRowChangeEventHandler infoRowChangedEvent = this.dtDriverInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsDriverInfo.dtDriverInfoRowChangeEvent((dsDriverInfo.dtDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtDriverInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtDriverInfoRowChangeEventHandler rowChangingEvent = this.dtDriverInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.dtDriverInfoRowChangeEvent((dsDriverInfo.dtDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtDriverInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtDriverInfoRowChangeEventHandler infoRowDeletedEvent = this.dtDriverInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsDriverInfo.dtDriverInfoRowChangeEvent((dsDriverInfo.dtDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtDriverInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtDriverInfoRowChangeEventHandler rowDeletingEvent = this.dtDriverInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.dtDriverInfoRowChangeEvent((dsDriverInfo.dtDriverInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtDriverInfoRow(dsDriverInfo.dtDriverInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtDriverInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class dtOrderingDataTable : TypedTableBase<dsDriverInfo.dtOrderingRow>
  {
    private DataColumn columnDriverID;
    private DataColumn columnLicenseNumber;
    private DataColumn columnFirstName;
    private DataColumn columnMiddleName;
    private DataColumn columnLastName;
    private DataColumn columnDOB;
    private DataColumn columnStateID;
    private DataColumn columnSuffix;
    private DataColumn columnMisc;
    private DataColumn columnProductID;
    private DataColumn columnSubType;
    private DataColumn columnPurpose;
    private DataColumn columnVaultAge;
    private DataColumn columnHintMvrInsuranceOption;
    private DataColumn columnLicenseValidationLookup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtOrderingDataTable()
    {
      this.TableName = "dtOrdering";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtOrderingDataTable(DataTable table)
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
    protected dtOrderingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverIDColumn => this.columnDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

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
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SuffixColumn => this.columnSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MiscColumn => this.columnMisc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProductIDColumn => this.columnProductID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubTypeColumn => this.columnSubType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PurposeColumn => this.columnPurpose;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VaultAgeColumn => this.columnVaultAge;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HintMvrInsuranceOptionColumn => this.columnHintMvrInsuranceOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseValidationLookupColumn => this.columnLicenseValidationLookup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOrderingRow this[int index]
    {
      get => (dsDriverInfo.dtOrderingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOrderingRowChangeEventHandler dtOrderingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOrderingRowChangeEventHandler dtOrderingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOrderingRowChangeEventHandler dtOrderingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOrderingRowChangeEventHandler dtOrderingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtOrderingRow(dsDriverInfo.dtOrderingRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOrderingRow AdddtOrderingRow(
      int DriverID,
      string LicenseNumber,
      string FirstName,
      string MiddleName,
      string LastName,
      DateTime DOB,
      string StateID,
      string Suffix,
      string Misc,
      string ProductID,
      string SubType,
      string Purpose,
      string VaultAge,
      string HintMvrInsuranceOption,
      bool LicenseValidationLookup)
    {
      dsDriverInfo.dtOrderingRow row = (dsDriverInfo.dtOrderingRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) DriverID,
        (object) LicenseNumber,
        (object) FirstName,
        (object) MiddleName,
        (object) LastName,
        (object) DOB,
        (object) StateID,
        (object) Suffix,
        (object) Misc,
        (object) ProductID,
        (object) SubType,
        (object) Purpose,
        (object) VaultAge,
        (object) HintMvrInsuranceOption,
        (object) LicenseValidationLookup
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOrderingRow FindByDriverID(int DriverID)
    {
      return (dsDriverInfo.dtOrderingRow) this.Rows.Find(new object[1]
      {
        (object) DriverID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.dtOrderingDataTable orderingDataTable = (dsDriverInfo.dtOrderingDataTable) base.Clone();
      orderingDataTable.InitVars();
      return (DataTable) orderingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.dtOrderingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverID = this.Columns["DriverID"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnMiddleName = this.Columns["MiddleName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnDOB = this.Columns["DOB"];
      this.columnStateID = this.Columns["StateID"];
      this.columnSuffix = this.Columns["Suffix"];
      this.columnMisc = this.Columns["Misc"];
      this.columnProductID = this.Columns["ProductID"];
      this.columnSubType = this.Columns["SubType"];
      this.columnPurpose = this.Columns["Purpose"];
      this.columnVaultAge = this.Columns["VaultAge"];
      this.columnHintMvrInsuranceOption = this.Columns["HintMvrInsuranceOption"];
      this.columnLicenseValidationLookup = this.Columns["LicenseValidationLookup"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverID = new DataColumn("DriverID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverID);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnMiddleName = new DataColumn("MiddleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMiddleName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnSuffix = new DataColumn("Suffix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSuffix);
      this.columnMisc = new DataColumn("Misc", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMisc);
      this.columnProductID = new DataColumn("ProductID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProductID);
      this.columnSubType = new DataColumn("SubType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubType);
      this.columnPurpose = new DataColumn("Purpose", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurpose);
      this.columnVaultAge = new DataColumn("VaultAge", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVaultAge);
      this.columnHintMvrInsuranceOption = new DataColumn("HintMvrInsuranceOption", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHintMvrInsuranceOption);
      this.columnLicenseValidationLookup = new DataColumn("LicenseValidationLookup", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseValidationLookup);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverID
      }, true));
      this.columnDriverID.AutoIncrementSeed = -1L;
      this.columnDriverID.AutoIncrementStep = -1L;
      this.columnDriverID.AllowDBNull = false;
      this.columnDriverID.ReadOnly = true;
      this.columnDriverID.Unique = true;
      this.columnFirstName.MaxLength = 100;
      this.columnLastName.MaxLength = 100;
      this.columnStateID.MaxLength = 2;
      this.columnSuffix.Caption = "NumberOfPoints";
      this.columnSuffix.MaxLength = 100;
      this.columnMisc.Caption = "Comments";
      this.columnMisc.MaxLength = 500;
      this.columnLicenseValidationLookup.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOrderingRow NewdtOrderingRow()
    {
      return (dsDriverInfo.dtOrderingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.dtOrderingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.dtOrderingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOrderingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOrderingRowChangeEventHandler orderingRowChangedEvent = this.dtOrderingRowChangedEvent;
      if (orderingRowChangedEvent == null)
        return;
      orderingRowChangedEvent((object) this, new dsDriverInfo.dtOrderingRowChangeEvent((dsDriverInfo.dtOrderingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOrderingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOrderingRowChangeEventHandler rowChangingEvent = this.dtOrderingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.dtOrderingRowChangeEvent((dsDriverInfo.dtOrderingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOrderingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOrderingRowChangeEventHandler orderingRowDeletedEvent = this.dtOrderingRowDeletedEvent;
      if (orderingRowDeletedEvent == null)
        return;
      orderingRowDeletedEvent((object) this, new dsDriverInfo.dtOrderingRowChangeEvent((dsDriverInfo.dtOrderingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOrderingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOrderingRowChangeEventHandler rowDeletingEvent = this.dtOrderingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.dtOrderingRowChangeEvent((dsDriverInfo.dtOrderingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtOrderingRow(dsDriverInfo.dtOrderingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtOrderingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsDriverInfo.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersDataTable()
    {
      this.TableName = "tblUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersDataTable(DataTable table)
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
    protected tblUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblUsersRow this[int index] => (dsDriverInfo.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUsersRow(dsDriverInfo.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblUsersRow AddtblUsersRow(Guid UserGUID, string Name_LastFirst)
    {
      dsDriverInfo.tblUsersRow row = (dsDriverInfo.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) Name_LastFirst
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsDriverInfo.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.tblUsersDataTable tblUsersDataTable = (dsDriverInfo.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName_LastFirst = new DataColumn("Name_LastFirst", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName_LastFirst);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblUsersRow NewtblUsersRow() => (dsDriverInfo.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsDriverInfo.tblUsersRowChangeEvent((dsDriverInfo.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.tblUsersRowChangeEvent((dsDriverInfo.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsDriverInfo.tblUsersRowChangeEvent((dsDriverInfo.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.tblUsersRowChangeEvent((dsDriverInfo.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUsersRow(dsDriverInfo.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class dtQueryDataTable : TypedTableBase<dsDriverInfo.dtQueryRow>
  {
    private DataColumn columnDriverID;
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnQuoteGuid;
    private DataColumn columnQuoteStatus;
    private DataColumn columnFirstName;
    private DataColumn columnLastName;
    private DataColumn columnDOB;
    private DataColumn columnLicenseNumber;
    private DataColumn columnStateID;
    private DataColumn columnDriverStatus;
    private DataColumn columnDateAdded;
    private DataColumn columnDriverDeleted;
    private DataColumn columnDriverAdded;
    private DataColumn columnNumberOfPoints;
    private DataColumn columnFullPartTime;
    private DataColumn columnLicenseExpDate;
    private DataColumn columnStreet1;
    private DataColumn columnCity;
    private DataColumn columnZipCode;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtQueryDataTable()
    {
      this.TableName = "dtQuery";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtQueryDataTable(DataTable table)
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
    protected dtQueryDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverIDColumn => this.columnDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusColumn => this.columnQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverStatusColumn => this.columnDriverStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverDeletedColumn => this.columnDriverDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverAddedColumn => this.columnDriverAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumberOfPointsColumn => this.columnNumberOfPoints;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullPartTimeColumn => this.columnFullPartTime;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseExpDateColumn => this.columnLicenseExpDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Street1Column => this.columnStreet1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtQueryRow this[int index] => (dsDriverInfo.dtQueryRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtQueryRowChangeEventHandler dtQueryRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtQueryRowChangeEventHandler dtQueryRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtQueryRowChangeEventHandler dtQueryRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtQueryRowChangeEventHandler dtQueryRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtQueryRow(dsDriverInfo.dtQueryRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtQueryRow AdddtQueryRow(
      int ControlNo,
      string PolicyNumber,
      Guid QuoteGuid,
      string QuoteStatus,
      string FirstName,
      string LastName,
      DateTime DOB,
      string LicenseNumber,
      string StateID,
      string DriverStatus,
      DateTime DateAdded,
      DateTime DriverDeleted,
      DateTime DriverAdded,
      string NumberOfPoints,
      string FullPartTime,
      DateTime LicenseExpDate,
      string Street1,
      string City,
      string ZipCode,
      string InsuredPolicyName,
      DateTime ExpirationDate)
    {
      dsDriverInfo.dtQueryRow row = (dsDriverInfo.dtQueryRow) this.NewRow();
      object[] objArray = new object[22]
      {
        null,
        (object) ControlNo,
        (object) PolicyNumber,
        (object) QuoteGuid,
        (object) QuoteStatus,
        (object) FirstName,
        (object) LastName,
        (object) DOB,
        (object) LicenseNumber,
        (object) StateID,
        (object) DriverStatus,
        (object) DateAdded,
        (object) DriverDeleted,
        (object) DriverAdded,
        (object) NumberOfPoints,
        (object) FullPartTime,
        (object) LicenseExpDate,
        (object) Street1,
        (object) City,
        (object) ZipCode,
        (object) InsuredPolicyName,
        (object) ExpirationDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtQueryRow FindByDriverID(long DriverID)
    {
      return (dsDriverInfo.dtQueryRow) this.Rows.Find(new object[1]
      {
        (object) DriverID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.dtQueryDataTable dtQueryDataTable = (dsDriverInfo.dtQueryDataTable) base.Clone();
      dtQueryDataTable.InitVars();
      return (DataTable) dtQueryDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.dtQueryDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverID = this.Columns["DriverID"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnQuoteStatus = this.Columns["QuoteStatus"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnDOB = this.Columns["DOB"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnStateID = this.Columns["StateID"];
      this.columnDriverStatus = this.Columns["DriverStatus"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnDriverDeleted = this.Columns["DriverDeleted"];
      this.columnDriverAdded = this.Columns["DriverAdded"];
      this.columnNumberOfPoints = this.Columns["NumberOfPoints"];
      this.columnFullPartTime = this.Columns["FullPartTime"];
      this.columnLicenseExpDate = this.Columns["LicenseExpDate"];
      this.columnStreet1 = this.Columns["Street1"];
      this.columnCity = this.Columns["City"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverID = new DataColumn("DriverID", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverID);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnQuoteStatus = new DataColumn("QuoteStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatus);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnDriverStatus = new DataColumn("DriverStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverStatus);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnDriverDeleted = new DataColumn("DriverDeleted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverDeleted);
      this.columnDriverAdded = new DataColumn("DriverAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverAdded);
      this.columnNumberOfPoints = new DataColumn("NumberOfPoints", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumberOfPoints);
      this.columnFullPartTime = new DataColumn("FullPartTime", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullPartTime);
      this.columnLicenseExpDate = new DataColumn("LicenseExpDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseExpDate);
      this.columnStreet1 = new DataColumn("Street1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverID
      }, true));
      this.columnDriverID.AutoIncrement = true;
      this.columnDriverID.AutoIncrementSeed = -1L;
      this.columnDriverID.AutoIncrementStep = -1L;
      this.columnDriverID.AllowDBNull = false;
      this.columnDriverID.ReadOnly = true;
      this.columnDriverID.Unique = true;
      this.columnControlNo.AllowDBNull = false;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnFirstName.MaxLength = 100;
      this.columnLastName.MaxLength = 100;
      this.columnLicenseNumber.MaxLength = 50;
      this.columnStateID.MaxLength = 2;
      this.columnNumberOfPoints.MaxLength = 100;
      this.columnStreet1.MaxLength = 250;
      this.columnCity.MaxLength = 100;
      this.columnZipCode.MaxLength = 5;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtQueryRow NewdtQueryRow() => (dsDriverInfo.dtQueryRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.dtQueryRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.dtQueryRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtQueryRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtQueryRowChangeEventHandler queryRowChangedEvent = this.dtQueryRowChangedEvent;
      if (queryRowChangedEvent == null)
        return;
      queryRowChangedEvent((object) this, new dsDriverInfo.dtQueryRowChangeEvent((dsDriverInfo.dtQueryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtQueryRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtQueryRowChangeEventHandler rowChangingEvent = this.dtQueryRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.dtQueryRowChangeEvent((dsDriverInfo.dtQueryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtQueryRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtQueryRowChangeEventHandler queryRowDeletedEvent = this.dtQueryRowDeletedEvent;
      if (queryRowDeletedEvent == null)
        return;
      queryRowDeletedEvent((object) this, new dsDriverInfo.dtQueryRowChangeEvent((dsDriverInfo.dtQueryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtQueryRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtQueryRowChangeEventHandler rowDeletingEvent = this.dtQueryRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.dtQueryRowChangeEvent((dsDriverInfo.dtQueryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtQueryRow(dsDriverInfo.dtQueryRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtQueryDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class lstDriverCDLDataTable : TypedTableBase<dsDriverInfo.lstDriverCDLRow>
  {
    private DataColumn columnID;
    private DataColumn columnCDL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDriverCDLDataTable()
    {
      this.TableName = "lstDriverCDL";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDriverCDLDataTable(DataTable table)
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
    protected lstDriverCDLDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CDLColumn => this.columnCDL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverCDLRow this[int index]
    {
      get => (dsDriverInfo.lstDriverCDLRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverCDLRowChangeEventHandler lstDriverCDLRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverCDLRowChangeEventHandler lstDriverCDLRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverCDLRowChangeEventHandler lstDriverCDLRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstDriverCDLRowChangeEventHandler lstDriverCDLRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstDriverCDLRow(dsDriverInfo.lstDriverCDLRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverCDLRow AddlstDriverCDLRow(int ID, string CDL)
    {
      dsDriverInfo.lstDriverCDLRow row = (dsDriverInfo.lstDriverCDLRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) CDL
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverCDLRow FindByID(int ID)
    {
      return (dsDriverInfo.lstDriverCDLRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.lstDriverCDLDataTable driverCdlDataTable = (dsDriverInfo.lstDriverCDLDataTable) base.Clone();
      driverCdlDataTable.InitVars();
      return (DataTable) driverCdlDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.lstDriverCDLDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCDL = this.Columns["CDL"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCDL = new DataColumn("CDL", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCDL);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverCDLRow NewlstDriverCDLRow()
    {
      return (dsDriverInfo.lstDriverCDLRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.lstDriverCDLRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.lstDriverCDLRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverCDLRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverCDLRowChangeEventHandler cdlRowChangedEvent = this.lstDriverCDLRowChangedEvent;
      if (cdlRowChangedEvent == null)
        return;
      cdlRowChangedEvent((object) this, new dsDriverInfo.lstDriverCDLRowChangeEvent((dsDriverInfo.lstDriverCDLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverCDLRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverCDLRowChangeEventHandler rowChangingEvent = this.lstDriverCDLRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.lstDriverCDLRowChangeEvent((dsDriverInfo.lstDriverCDLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverCDLRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverCDLRowChangeEventHandler cdlRowDeletedEvent = this.lstDriverCDLRowDeletedEvent;
      if (cdlRowDeletedEvent == null)
        return;
      cdlRowDeletedEvent((object) this, new dsDriverInfo.lstDriverCDLRowChangeEvent((dsDriverInfo.lstDriverCDLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDriverCDLRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstDriverCDLRowChangeEventHandler rowDeletingEvent = this.lstDriverCDLRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.lstDriverCDLRowChangeEvent((dsDriverInfo.lstDriverCDLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstDriverCDLRow(dsDriverInfo.lstDriverCDLRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDriverCDLDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class tblDriverProductStatesDataTable : 
    TypedTableBase<dsDriverInfo.tblDriverProductStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnSubType;
    private DataColumn columnFullOption;
    private DataColumn columnCleanOption;
    private DataColumn columnActivityOption;
    private DataColumn columnVdetailOption;
    private DataColumn columnAlternateSubType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverProductStatesDataTable()
    {
      this.TableName = "tblDriverProductStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverProductStatesDataTable(DataTable table)
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
    protected tblDriverProductStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubTypeColumn => this.columnSubType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullOptionColumn => this.columnFullOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CleanOptionColumn => this.columnCleanOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ActivityOptionColumn => this.columnActivityOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VdetailOptionColumn => this.columnVdetailOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AlternateSubTypeColumn => this.columnAlternateSubType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverProductStatesRow this[int index]
    {
      get => (dsDriverInfo.tblDriverProductStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverProductStatesRowChangeEventHandler tblDriverProductStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverProductStatesRowChangeEventHandler tblDriverProductStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverProductStatesRowChangeEventHandler tblDriverProductStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverProductStatesRowChangeEventHandler tblDriverProductStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblDriverProductStatesRow(dsDriverInfo.tblDriverProductStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverProductStatesRow AddtblDriverProductStatesRow(
      string StateID,
      string SubType,
      bool FullOption,
      bool CleanOption,
      bool ActivityOption,
      bool VdetailOption,
      string AlternateSubType)
    {
      dsDriverInfo.tblDriverProductStatesRow row = (dsDriverInfo.tblDriverProductStatesRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) StateID,
        (object) SubType,
        (object) FullOption,
        (object) CleanOption,
        (object) ActivityOption,
        (object) VdetailOption,
        (object) AlternateSubType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverProductStatesRow FindByStateID(string StateID)
    {
      return (dsDriverInfo.tblDriverProductStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.tblDriverProductStatesDataTable productStatesDataTable = (dsDriverInfo.tblDriverProductStatesDataTable) base.Clone();
      productStatesDataTable.InitVars();
      return (DataTable) productStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.tblDriverProductStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnSubType = this.Columns["SubType"];
      this.columnFullOption = this.Columns["FullOption"];
      this.columnCleanOption = this.Columns["CleanOption"];
      this.columnActivityOption = this.Columns["ActivityOption"];
      this.columnVdetailOption = this.Columns["VdetailOption"];
      this.columnAlternateSubType = this.Columns["AlternateSubType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnSubType = new DataColumn("SubType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubType);
      this.columnFullOption = new DataColumn("FullOption", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullOption);
      this.columnCleanOption = new DataColumn("CleanOption", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCleanOption);
      this.columnActivityOption = new DataColumn("ActivityOption", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActivityOption);
      this.columnVdetailOption = new DataColumn("VdetailOption", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVdetailOption);
      this.columnAlternateSubType = new DataColumn("AlternateSubType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlternateSubType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnFullOption.DefaultValue = (object) false;
      this.columnCleanOption.DefaultValue = (object) false;
      this.columnActivityOption.DefaultValue = (object) false;
      this.columnVdetailOption.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverProductStatesRow NewtblDriverProductStatesRow()
    {
      return (dsDriverInfo.tblDriverProductStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.tblDriverProductStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.tblDriverProductStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverProductStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverProductStatesRowChangeEventHandler statesRowChangedEvent = this.tblDriverProductStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsDriverInfo.tblDriverProductStatesRowChangeEvent((dsDriverInfo.tblDriverProductStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverProductStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverProductStatesRowChangeEventHandler rowChangingEvent = this.tblDriverProductStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.tblDriverProductStatesRowChangeEvent((dsDriverInfo.tblDriverProductStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverProductStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverProductStatesRowChangeEventHandler statesRowDeletedEvent = this.tblDriverProductStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsDriverInfo.tblDriverProductStatesRowChangeEvent((dsDriverInfo.tblDriverProductStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverProductStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverProductStatesRowChangeEventHandler rowDeletingEvent = this.tblDriverProductStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.tblDriverProductStatesRowChangeEvent((dsDriverInfo.tblDriverProductStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblDriverProductStatesRow(dsDriverInfo.tblDriverProductStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDriverProductStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class dtProductsDataTable : TypedTableBase<dsDriverInfo.dtProductsRow>
  {
    private DataColumn columnProductID;
    private DataColumn columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtProductsDataTable()
    {
      this.TableName = "dtProducts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtProductsDataTable(DataTable table)
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
    protected dtProductsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProductIDColumn => this.columnProductID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtProductsRow this[int index]
    {
      get => (dsDriverInfo.dtProductsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtProductsRowChangeEventHandler dtProductsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtProductsRowChangeEventHandler dtProductsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtProductsRowChangeEventHandler dtProductsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtProductsRowChangeEventHandler dtProductsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtProductsRow(dsDriverInfo.dtProductsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtProductsRow AdddtProductsRow(string ProductID, int ID)
    {
      dsDriverInfo.dtProductsRow row = (dsDriverInfo.dtProductsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProductID,
        (object) ID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtProductsRow FindByProductID(string ProductID)
    {
      return (dsDriverInfo.dtProductsRow) this.Rows.Find(new object[1]
      {
        (object) ProductID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.dtProductsDataTable productsDataTable = (dsDriverInfo.dtProductsDataTable) base.Clone();
      productsDataTable.InitVars();
      return (DataTable) productsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.dtProductsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProductID = this.Columns["ProductID"];
      this.columnID = this.Columns["ID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProductID = new DataColumn("ProductID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProductID);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProductID
      }, true));
      this.columnProductID.AllowDBNull = false;
      this.columnProductID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtProductsRow NewdtProductsRow()
    {
      return (dsDriverInfo.dtProductsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.dtProductsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.dtProductsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProductsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtProductsRowChangeEventHandler productsRowChangedEvent = this.dtProductsRowChangedEvent;
      if (productsRowChangedEvent == null)
        return;
      productsRowChangedEvent((object) this, new dsDriverInfo.dtProductsRowChangeEvent((dsDriverInfo.dtProductsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProductsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtProductsRowChangeEventHandler rowChangingEvent = this.dtProductsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.dtProductsRowChangeEvent((dsDriverInfo.dtProductsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProductsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtProductsRowChangeEventHandler productsRowDeletedEvent = this.dtProductsRowDeletedEvent;
      if (productsRowDeletedEvent == null)
        return;
      productsRowDeletedEvent((object) this, new dsDriverInfo.dtProductsRowChangeEvent((dsDriverInfo.dtProductsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProductsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtProductsRowChangeEventHandler rowDeletingEvent = this.dtProductsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.dtProductsRowChangeEvent((dsDriverInfo.dtProductsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtProductsRow(dsDriverInfo.dtProductsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtProductsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class dtOptionsDataTable : TypedTableBase<dsDriverInfo.dtOptionsRow>
  {
    private DataColumn columnHintMvrInsuranceOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtOptionsDataTable()
    {
      this.TableName = "dtOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtOptionsDataTable(DataTable table)
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
    protected dtOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HintMvrInsuranceOptionColumn => this.columnHintMvrInsuranceOption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOptionsRow this[int index]
    {
      get => (dsDriverInfo.dtOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOptionsRowChangeEventHandler dtOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOptionsRowChangeEventHandler dtOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOptionsRowChangeEventHandler dtOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtOptionsRowChangeEventHandler dtOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtOptionsRow(dsDriverInfo.dtOptionsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOptionsRow AdddtOptionsRow(string HintMvrInsuranceOption)
    {
      dsDriverInfo.dtOptionsRow row = (dsDriverInfo.dtOptionsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) HintMvrInsuranceOption
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOptionsRow FindByHintMvrInsuranceOption(string HintMvrInsuranceOption)
    {
      return (dsDriverInfo.dtOptionsRow) this.Rows.Find(new object[1]
      {
        (object) HintMvrInsuranceOption
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.dtOptionsDataTable optionsDataTable = (dsDriverInfo.dtOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.dtOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnHintMvrInsuranceOption = this.Columns["HintMvrInsuranceOption"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnHintMvrInsuranceOption = new DataColumn("HintMvrInsuranceOption", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHintMvrInsuranceOption);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnHintMvrInsuranceOption
      }, true));
      this.columnHintMvrInsuranceOption.AllowDBNull = false;
      this.columnHintMvrInsuranceOption.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOptionsRow NewdtOptionsRow() => (dsDriverInfo.dtOptionsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.dtOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.dtOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOptionsRowChangeEventHandler optionsRowChangedEvent = this.dtOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsDriverInfo.dtOptionsRowChangeEvent((dsDriverInfo.dtOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOptionsRowChangeEventHandler rowChangingEvent = this.dtOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.dtOptionsRowChangeEvent((dsDriverInfo.dtOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOptionsRowChangeEventHandler optionsRowDeletedEvent = this.dtOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsDriverInfo.dtOptionsRowChangeEvent((dsDriverInfo.dtOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtOptionsRowChangeEventHandler rowDeletingEvent = this.dtOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.dtOptionsRowChangeEvent((dsDriverInfo.dtOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtOptionsRow(dsDriverInfo.dtOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class tblDriverReqsDataTable : TypedTableBase<dsDriverInfo.tblDriverReqsRow>
  {
    private DataColumn columnDriverID;
    private DataColumn columnValid;
    private DataColumn columnIsClear;
    private DataColumn columnDLStatus;
    private DataColumn columnDocumentValidationResult;
    private DataColumn columnMatchError;
    private DataColumn columnInvoicePath;
    private DataColumn columnCompanyClass;
    private DataColumn columnErrorDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverReqsDataTable()
    {
      this.TableName = "tblDriverReqs";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverReqsDataTable(DataTable table)
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
    protected tblDriverReqsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverIDColumn => this.columnDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ValidColumn => this.columnValid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IsClearColumn => this.columnIsClear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DLStatusColumn => this.columnDLStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DocumentValidationResultColumn => this.columnDocumentValidationResult;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MatchErrorColumn => this.columnMatchError;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InvoicePathColumn => this.columnInvoicePath;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyClassColumn => this.columnCompanyClass;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ErrorDescriptionColumn => this.columnErrorDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverReqsRow this[int index]
    {
      get => (dsDriverInfo.tblDriverReqsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverReqsRowChangeEventHandler tblDriverReqsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverReqsRowChangeEventHandler tblDriverReqsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverReqsRowChangeEventHandler tblDriverReqsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverReqsRowChangeEventHandler tblDriverReqsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblDriverReqsRow(dsDriverInfo.tblDriverReqsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverReqsRow AddtblDriverReqsRow(
      int DriverID,
      string Valid,
      string IsClear,
      string DLStatus,
      string DocumentValidationResult,
      string MatchError,
      string InvoicePath,
      string CompanyClass,
      string ErrorDescription)
    {
      dsDriverInfo.tblDriverReqsRow row = (dsDriverInfo.tblDriverReqsRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) DriverID,
        (object) Valid,
        (object) IsClear,
        (object) DLStatus,
        (object) DocumentValidationResult,
        (object) MatchError,
        (object) InvoicePath,
        (object) CompanyClass,
        (object) ErrorDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverReqsRow FindByDriverID(int DriverID)
    {
      return (dsDriverInfo.tblDriverReqsRow) this.Rows.Find(new object[1]
      {
        (object) DriverID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.tblDriverReqsDataTable driverReqsDataTable = (dsDriverInfo.tblDriverReqsDataTable) base.Clone();
      driverReqsDataTable.InitVars();
      return (DataTable) driverReqsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.tblDriverReqsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverID = this.Columns["DriverID"];
      this.columnValid = this.Columns["Valid"];
      this.columnIsClear = this.Columns["IsClear"];
      this.columnDLStatus = this.Columns["DLStatus"];
      this.columnDocumentValidationResult = this.Columns["DocumentValidationResult"];
      this.columnMatchError = this.Columns["MatchError"];
      this.columnInvoicePath = this.Columns["InvoicePath"];
      this.columnCompanyClass = this.Columns["CompanyClass"];
      this.columnErrorDescription = this.Columns["ErrorDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverID = new DataColumn("DriverID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverID);
      this.columnValid = new DataColumn("Valid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValid);
      this.columnIsClear = new DataColumn("IsClear", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsClear);
      this.columnDLStatus = new DataColumn("DLStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDLStatus);
      this.columnDocumentValidationResult = new DataColumn("DocumentValidationResult", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentValidationResult);
      this.columnMatchError = new DataColumn("MatchError", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMatchError);
      this.columnInvoicePath = new DataColumn("InvoicePath", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoicePath);
      this.columnCompanyClass = new DataColumn("CompanyClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyClass);
      this.columnErrorDescription = new DataColumn("ErrorDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnErrorDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverID
      }, true));
      this.columnDriverID.AllowDBNull = false;
      this.columnDriverID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverReqsRow NewtblDriverReqsRow()
    {
      return (dsDriverInfo.tblDriverReqsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.tblDriverReqsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.tblDriverReqsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverReqsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverReqsRowChangeEventHandler reqsRowChangedEvent = this.tblDriverReqsRowChangedEvent;
      if (reqsRowChangedEvent == null)
        return;
      reqsRowChangedEvent((object) this, new dsDriverInfo.tblDriverReqsRowChangeEvent((dsDriverInfo.tblDriverReqsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverReqsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverReqsRowChangeEventHandler rowChangingEvent = this.tblDriverReqsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.tblDriverReqsRowChangeEvent((dsDriverInfo.tblDriverReqsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverReqsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverReqsRowChangeEventHandler reqsRowDeletedEvent = this.tblDriverReqsRowDeletedEvent;
      if (reqsRowDeletedEvent == null)
        return;
      reqsRowDeletedEvent((object) this, new dsDriverInfo.tblDriverReqsRowChangeEvent((dsDriverInfo.tblDriverReqsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverReqsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverReqsRowChangeEventHandler rowDeletingEvent = this.tblDriverReqsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.tblDriverReqsRowChangeEvent((dsDriverInfo.tblDriverReqsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblDriverReqsRow(dsDriverInfo.tblDriverReqsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDriverReqsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class tblDriverLicenseValidationStatesDataTable : 
    TypedTableBase<dsDriverInfo.tblDriverLicenseValidationStatesRow>
  {
    private DataColumn columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverLicenseValidationStatesDataTable()
    {
      this.TableName = "tblDriverLicenseValidationStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverLicenseValidationStatesDataTable(DataTable table)
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
    protected tblDriverLicenseValidationStatesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverLicenseValidationStatesRow this[int index]
    {
      get => (dsDriverInfo.tblDriverLicenseValidationStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler tblDriverLicenseValidationStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler tblDriverLicenseValidationStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler tblDriverLicenseValidationStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler tblDriverLicenseValidationStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblDriverLicenseValidationStatesRow(
      dsDriverInfo.tblDriverLicenseValidationStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverLicenseValidationStatesRow AddtblDriverLicenseValidationStatesRow(
      string StateID)
    {
      dsDriverInfo.tblDriverLicenseValidationStatesRow row = (dsDriverInfo.tblDriverLicenseValidationStatesRow) this.NewRow();
      object[] objArray = new object[1]{ (object) StateID };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverLicenseValidationStatesRow FindByStateID(string StateID)
    {
      return (dsDriverInfo.tblDriverLicenseValidationStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.tblDriverLicenseValidationStatesDataTable validationStatesDataTable = (dsDriverInfo.tblDriverLicenseValidationStatesDataTable) base.Clone();
      validationStatesDataTable.InitVars();
      return (DataTable) validationStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.tblDriverLicenseValidationStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars() => this.columnStateID = this.Columns["StateID"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverLicenseValidationStatesRow NewtblDriverLicenseValidationStatesRow()
    {
      return (dsDriverInfo.tblDriverLicenseValidationStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.tblDriverLicenseValidationStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDriverInfo.tblDriverLicenseValidationStatesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverLicenseValidationStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler statesRowChangedEvent = this.tblDriverLicenseValidationStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEvent((dsDriverInfo.tblDriverLicenseValidationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverLicenseValidationStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler rowChangingEvent = this.tblDriverLicenseValidationStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEvent((dsDriverInfo.tblDriverLicenseValidationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverLicenseValidationStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler statesRowDeletedEvent = this.tblDriverLicenseValidationStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEvent((dsDriverInfo.tblDriverLicenseValidationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDriverLicenseValidationStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEventHandler rowDeletingEvent = this.tblDriverLicenseValidationStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.tblDriverLicenseValidationStatesRowChangeEvent((dsDriverInfo.tblDriverLicenseValidationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblDriverLicenseValidationStatesRow(
      dsDriverInfo.tblDriverLicenseValidationStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDriverLicenseValidationStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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
  public class dtIIXDataTable : TypedTableBase<dsDriverInfo.dtIIXRow>
  {
    private DataColumn columnDriverID;
    private DataColumn columnRequestType;
    private DataColumn columnLicenseNumber;
    private DataColumn columnFirstName;
    private DataColumn columnMiddleName;
    private DataColumn columnLastName;
    private DataColumn columnDOB;
    private DataColumn columnStateID;
    private DataColumn columnSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtIIXDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtIIXDataTable_ColumnChanging);
      this.TableName = "dtIIX";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtIIXDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtIIXDataTable_ColumnChanging);
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
    protected dtIIXDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtIIXDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverIDColumn => this.columnDriverID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RequestTypeColumn => this.columnRequestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

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
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SuffixColumn => this.columnSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtIIXRow this[int index] => (dsDriverInfo.dtIIXRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtIIXRowChangeEventHandler dtIIXRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtIIXRowChangeEventHandler dtIIXRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtIIXRowChangeEventHandler dtIIXRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.dtIIXRowChangeEventHandler dtIIXRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtIIXRow(dsDriverInfo.dtIIXRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtIIXRow AdddtIIXRow(
      int DriverID,
      string RequestType,
      string LicenseNumber,
      string FirstName,
      string MiddleName,
      string LastName,
      DateTime DOB,
      string StateID,
      string Suffix)
    {
      dsDriverInfo.dtIIXRow row = (dsDriverInfo.dtIIXRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) DriverID,
        (object) RequestType,
        (object) LicenseNumber,
        (object) FirstName,
        (object) MiddleName,
        (object) LastName,
        (object) DOB,
        (object) StateID,
        (object) Suffix
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtIIXRow FindByDriverID(int DriverID)
    {
      return (dsDriverInfo.dtIIXRow) this.Rows.Find(new object[1]
      {
        (object) DriverID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.dtIIXDataTable dtIixDataTable = (dsDriverInfo.dtIIXDataTable) base.Clone();
      dtIixDataTable.InitVars();
      return (DataTable) dtIixDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsDriverInfo.dtIIXDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDriverID = this.Columns["DriverID"];
      this.columnRequestType = this.Columns["RequestType"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnMiddleName = this.Columns["MiddleName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnDOB = this.Columns["DOB"];
      this.columnStateID = this.Columns["StateID"];
      this.columnSuffix = this.Columns["Suffix"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDriverID = new DataColumn("DriverID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriverID);
      this.columnRequestType = new DataColumn("RequestType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequestType);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnMiddleName = new DataColumn("MiddleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMiddleName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnSuffix = new DataColumn("Suffix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSuffix);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDriverID
      }, true));
      this.columnDriverID.AutoIncrementSeed = -1L;
      this.columnDriverID.AutoIncrementStep = -1L;
      this.columnDriverID.AllowDBNull = false;
      this.columnDriverID.ReadOnly = true;
      this.columnDriverID.Unique = true;
      this.columnFirstName.MaxLength = 100;
      this.columnLastName.MaxLength = 100;
      this.columnStateID.MaxLength = 2;
      this.columnSuffix.Caption = "NumberOfPoints";
      this.columnSuffix.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtIIXRow NewdtIIXRow() => (dsDriverInfo.dtIIXRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.dtIIXRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.dtIIXRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIIXRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtIIXRowChangeEventHandler iixRowChangedEvent = this.dtIIXRowChangedEvent;
      if (iixRowChangedEvent == null)
        return;
      iixRowChangedEvent((object) this, new dsDriverInfo.dtIIXRowChangeEvent((dsDriverInfo.dtIIXRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIIXRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtIIXRowChangeEventHandler rowChangingEvent = this.dtIIXRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.dtIIXRowChangeEvent((dsDriverInfo.dtIIXRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIIXRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtIIXRowChangeEventHandler iixRowDeletedEvent = this.dtIIXRowDeletedEvent;
      if (iixRowDeletedEvent == null)
        return;
      iixRowDeletedEvent((object) this, new dsDriverInfo.dtIIXRowChangeEvent((dsDriverInfo.dtIIXRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIIXRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.dtIIXRowChangeEventHandler rowDeletingEvent = this.dtIIXRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.dtIIXRowChangeEvent((dsDriverInfo.dtIIXRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtIIXRow(dsDriverInfo.dtIIXRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtIIXDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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

    private void dtIIXDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.LicenseNumberColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstIIXMVRTypesDataTable : TypedTableBase<dsDriverInfo.lstIIXMVRTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnStateID;
    private DataColumn columnType;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstIIXMVRTypesDataTable()
    {
      this.TableName = "lstIIXMVRTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstIIXMVRTypesDataTable(DataTable table)
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
    protected lstIIXMVRTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstIIXMVRTypesRow this[int index]
    {
      get => (dsDriverInfo.lstIIXMVRTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler lstIIXMVRTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler lstIIXMVRTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler lstIIXMVRTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler lstIIXMVRTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstIIXMVRTypesRow(dsDriverInfo.lstIIXMVRTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstIIXMVRTypesRow AddlstIIXMVRTypesRow(
      string StateID,
      string Type,
      string Description)
    {
      dsDriverInfo.lstIIXMVRTypesRow row = (dsDriverInfo.lstIIXMVRTypesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) StateID,
        (object) Type,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstIIXMVRTypesRow FindByID(int ID)
    {
      return (dsDriverInfo.lstIIXMVRTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsDriverInfo.lstIIXMVRTypesDataTable iixmvrTypesDataTable = (dsDriverInfo.lstIIXMVRTypesDataTable) base.Clone();
      iixmvrTypesDataTable.InitVars();
      return (DataTable) iixmvrTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDriverInfo.lstIIXMVRTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnType = this.Columns["Type"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnStateID.MaxLength = 2;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstIIXMVRTypesRow NewlstIIXMVRTypesRow()
    {
      return (dsDriverInfo.lstIIXMVRTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDriverInfo.lstIIXMVRTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsDriverInfo.lstIIXMVRTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIIXMVRTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler typesRowChangedEvent = this.lstIIXMVRTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsDriverInfo.lstIIXMVRTypesRowChangeEvent((dsDriverInfo.lstIIXMVRTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIIXMVRTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler rowChangingEvent = this.lstIIXMVRTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDriverInfo.lstIIXMVRTypesRowChangeEvent((dsDriverInfo.lstIIXMVRTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIIXMVRTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler typesRowDeletedEvent = this.lstIIXMVRTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsDriverInfo.lstIIXMVRTypesRowChangeEvent((dsDriverInfo.lstIIXMVRTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIIXMVRTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDriverInfo.lstIIXMVRTypesRowChangeEventHandler rowDeletingEvent = this.lstIIXMVRTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDriverInfo.lstIIXMVRTypesRowChangeEvent((dsDriverInfo.lstIIXMVRTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstIIXMVRTypesRow(dsDriverInfo.lstIIXMVRTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDriverInfo dsDriverInfo = new dsDriverInfo();
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
        FixedValue = dsDriverInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstIIXMVRTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDriverInfo.GetSchemaSerializable();
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

  public class lstDriverStatusRow : DataRow
  {
    private dsDriverInfo.lstDriverStatusDataTable tablelstDriverStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDriverStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDriverStatus = (dsDriverInfo.lstDriverStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DriverStatusID
    {
      get => Conversions.ToInteger(this[this.tablelstDriverStatus.DriverStatusIDColumn]);
      set => this[this.tablelstDriverStatus.DriverStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Status
    {
      get => Conversions.ToString(this[this.tablelstDriverStatus.StatusColumn]);
      set => this[this.tablelstDriverStatus.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Inactive
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstDriverStatus.InactiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inactive' in table 'lstDriverStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstDriverStatus.InactiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInactiveNull() => this.IsNull(this.tablelstDriverStatus.InactiveColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInactiveNull()
    {
      this[this.tablelstDriverStatus.InactiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDriverInfoRow : DataRow
  {
    private dsDriverInfo.tblDriverInfoDataTable tabletblDriverInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDriverInfo = (dsDriverInfo.tblDriverInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public long DriverID
    {
      get => Conversions.ToLong(this[this.tabletblDriverInfo.DriverIDColumn]);
      set => this[this.tabletblDriverInfo.DriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabletblDriverInfo.ControlNoColumn]);
      set => this[this.tabletblDriverInfo.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblDriverInfo.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDriverInfo.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDriverInfo.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverDeleted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DriverDeletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverDeleted' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DriverDeletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DriverAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverAdded' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DriverAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NumberOfPoints
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.NumberOfPointsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumberOfPoints' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.NumberOfPointsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FurnishedCar
    {
      get => Conversions.ToBoolean(this[this.tabletblDriverInfo.FurnishedCarColumn]);
      set => this[this.tabletblDriverInfo.FurnishedCarColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte FullPartTime
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblDriverInfo.FullPartTimeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullPartTime' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.FullPartTimeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CopyOnRenewal
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverInfo.CopyOnRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CopyOnRenewal' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.CopyOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ModifiedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.ModifiedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModifiedDate' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.ModifiedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LicenseExpDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.LicenseExpDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseExpDate' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.LicenseExpDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Street1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.Street1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street1' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.Street1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Street2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.Street2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street2' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.Street2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal DriverRatingFactor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblDriverInfo.DriverRatingFactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverRatingFactor' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DriverRatingFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseClass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.LicenseClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseClass' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.LicenseClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ADR
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverInfo.ADRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ADR' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.ADRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NumAtFaultAcc
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.NumAtFaultAccColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumAtFaultAcc' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.NumAtFaultAccColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NumOtherAcc
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.NumOtherAccColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumOtherAcc' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.NumOtherAccColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SpeedingLessTenMPH
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.SpeedingLessTenMPHColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpeedingLessTenMPH' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.SpeedingLessTenMPHColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SpeedingMoreTenMPH
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.SpeedingMoreTenMPHColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpeedingMoreTenMPH' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.SpeedingMoreTenMPHColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SecVltns
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.SecVltnsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SecVltns' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.SecVltnsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EquipVltns
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.EquipVltnsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EquipVltns' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.EquipVltnsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OtherMovingVltns
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.OtherMovingVltnsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherMovingVltns' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.OtherMovingVltnsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TotalVtlns
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.TotalVtlnsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalVtlns' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.TotalVtlnsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime MedicalExpiration
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.MedicalExpirationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MedicalExpiration' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.MedicalExpirationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid NoteRecipient
    {
      get
      {
        try
        {
          object obj = this[this.tabletblDriverInfo.NoteRecipientColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteRecipient' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.NoteRecipientColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NoteSubject
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.NoteSubjectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteSubject' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.NoteSubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NoteBody
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.NoteBodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteBody' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.NoteBodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DaysDue
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDriverInfo.DaysDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DaysDue' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DaysDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PopUpNote
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverInfo.PopUpNoteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PopUpNote' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.PopUpNoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateOfHire
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DateOfHireColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateOfHire' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DateOfHireColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateOfOrigCDL
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DateOfOrigCDLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateOfOrigCDL' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DateOfOrigCDLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int YearsLogTruckExperienceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDriverInfo.YearsLogTruckExperienceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearsLogTruckExperienceNum' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.YearsLogTruckExperienceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime MVRDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.MVRDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MVRDate' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.MVRDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CDLDriverID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDriverInfo.CDLDriverIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CDLDriverID' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.CDLDriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverExcluded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblDriverInfo.DriverExcludedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverExcluded' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DriverExcludedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool GenerateDoc
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverInfo.GenerateDocColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GenerateDoc' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.GenerateDocColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DOC
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverInfo.DOCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOC' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string JobTitle
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.JobTitleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'JobTitle' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.JobTitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumberEncrypted
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.LicenseNumberEncryptedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumberEncrypted' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.LicenseNumberEncryptedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DOBEncrypted
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverInfo.DOBEncryptedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOBEncrypted' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.DOBEncryptedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool BulkDelete
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverInfo.BulkDeleteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BulkDelete' in table 'tblDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverInfo.BulkDeleteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool TruVision
    {
      get => Conversions.ToBoolean(this[this.tabletblDriverInfo.TruVisionColumn]);
      set => this[this.tabletblDriverInfo.TruVisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabletblDriverInfo.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabletblDriverInfo.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabletblDriverInfo.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabletblDriverInfo.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabletblDriverInfo.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabletblDriverInfo.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberNull() => this.IsNull(this.tabletblDriverInfo.LicenseNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tabletblDriverInfo.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblDriverInfo.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblDriverInfo.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblDriverInfo.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblDriverInfo.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabletblDriverInfo.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabletblDriverInfo.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverDeletedNull() => this.IsNull(this.tabletblDriverInfo.DriverDeletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverDeletedNull()
    {
      this[this.tabletblDriverInfo.DriverDeletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverAddedNull() => this.IsNull(this.tabletblDriverInfo.DriverAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverAddedNull()
    {
      this[this.tabletblDriverInfo.DriverAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumberOfPointsNull() => this.IsNull(this.tabletblDriverInfo.NumberOfPointsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumberOfPointsNull()
    {
      this[this.tabletblDriverInfo.NumberOfPointsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tabletblDriverInfo.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblDriverInfo.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullPartTimeNull() => this.IsNull(this.tabletblDriverInfo.FullPartTimeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullPartTimeNull()
    {
      this[this.tabletblDriverInfo.FullPartTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCopyOnRenewalNull() => this.IsNull(this.tabletblDriverInfo.CopyOnRenewalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCopyOnRenewalNull()
    {
      this[this.tabletblDriverInfo.CopyOnRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsModifiedDateNull() => this.IsNull(this.tabletblDriverInfo.ModifiedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetModifiedDateNull()
    {
      this[this.tabletblDriverInfo.ModifiedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseExpDateNull() => this.IsNull(this.tabletblDriverInfo.LicenseExpDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseExpDateNull()
    {
      this[this.tabletblDriverInfo.LicenseExpDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStreet1Null() => this.IsNull(this.tabletblDriverInfo.Street1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStreet1Null()
    {
      this[this.tabletblDriverInfo.Street1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStreet2Null() => this.IsNull(this.tabletblDriverInfo.Street2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStreet2Null()
    {
      this[this.tabletblDriverInfo.Street2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblDriverInfo.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblDriverInfo.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblDriverInfo.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblDriverInfo.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblDriverInfo.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblDriverInfo.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverRatingFactorNull()
    {
      return this.IsNull(this.tabletblDriverInfo.DriverRatingFactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverRatingFactorNull()
    {
      this[this.tabletblDriverInfo.DriverRatingFactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseClassNull() => this.IsNull(this.tabletblDriverInfo.LicenseClassColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseClassNull()
    {
      this[this.tabletblDriverInfo.LicenseClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsADRNull() => this.IsNull(this.tabletblDriverInfo.ADRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetADRNull()
    {
      this[this.tabletblDriverInfo.ADRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumAtFaultAccNull() => this.IsNull(this.tabletblDriverInfo.NumAtFaultAccColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumAtFaultAccNull()
    {
      this[this.tabletblDriverInfo.NumAtFaultAccColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumOtherAccNull() => this.IsNull(this.tabletblDriverInfo.NumOtherAccColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumOtherAccNull()
    {
      this[this.tabletblDriverInfo.NumOtherAccColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSpeedingLessTenMPHNull()
    {
      return this.IsNull(this.tabletblDriverInfo.SpeedingLessTenMPHColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSpeedingLessTenMPHNull()
    {
      this[this.tabletblDriverInfo.SpeedingLessTenMPHColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSpeedingMoreTenMPHNull()
    {
      return this.IsNull(this.tabletblDriverInfo.SpeedingMoreTenMPHColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSpeedingMoreTenMPHNull()
    {
      this[this.tabletblDriverInfo.SpeedingMoreTenMPHColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSecVltnsNull() => this.IsNull(this.tabletblDriverInfo.SecVltnsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSecVltnsNull()
    {
      this[this.tabletblDriverInfo.SecVltnsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEquipVltnsNull() => this.IsNull(this.tabletblDriverInfo.EquipVltnsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEquipVltnsNull()
    {
      this[this.tabletblDriverInfo.EquipVltnsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOtherMovingVltnsNull()
    {
      return this.IsNull(this.tabletblDriverInfo.OtherMovingVltnsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOtherMovingVltnsNull()
    {
      this[this.tabletblDriverInfo.OtherMovingVltnsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotalVtlnsNull() => this.IsNull(this.tabletblDriverInfo.TotalVtlnsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotalVtlnsNull()
    {
      this[this.tabletblDriverInfo.TotalVtlnsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMedicalExpirationNull()
    {
      return this.IsNull(this.tabletblDriverInfo.MedicalExpirationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMedicalExpirationNull()
    {
      this[this.tabletblDriverInfo.MedicalExpirationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNoteRecipientNull() => this.IsNull(this.tabletblDriverInfo.NoteRecipientColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNoteRecipientNull()
    {
      this[this.tabletblDriverInfo.NoteRecipientColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNoteSubjectNull() => this.IsNull(this.tabletblDriverInfo.NoteSubjectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNoteSubjectNull()
    {
      this[this.tabletblDriverInfo.NoteSubjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNoteBodyNull() => this.IsNull(this.tabletblDriverInfo.NoteBodyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNoteBodyNull()
    {
      this[this.tabletblDriverInfo.NoteBodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDaysDueNull() => this.IsNull(this.tabletblDriverInfo.DaysDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDaysDueNull()
    {
      this[this.tabletblDriverInfo.DaysDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPopUpNoteNull() => this.IsNull(this.tabletblDriverInfo.PopUpNoteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPopUpNoteNull()
    {
      this[this.tabletblDriverInfo.PopUpNoteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateOfHireNull() => this.IsNull(this.tabletblDriverInfo.DateOfHireColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateOfHireNull()
    {
      this[this.tabletblDriverInfo.DateOfHireColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateOfOrigCDLNull() => this.IsNull(this.tabletblDriverInfo.DateOfOrigCDLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateOfOrigCDLNull()
    {
      this[this.tabletblDriverInfo.DateOfOrigCDLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsYearsLogTruckExperienceNumNull()
    {
      return this.IsNull(this.tabletblDriverInfo.YearsLogTruckExperienceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetYearsLogTruckExperienceNumNull()
    {
      this[this.tabletblDriverInfo.YearsLogTruckExperienceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMVRDateNull() => this.IsNull(this.tabletblDriverInfo.MVRDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMVRDateNull()
    {
      this[this.tabletblDriverInfo.MVRDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCDLDriverIDNull() => this.IsNull(this.tabletblDriverInfo.CDLDriverIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCDLDriverIDNull()
    {
      this[this.tabletblDriverInfo.CDLDriverIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverExcludedNull() => this.IsNull(this.tabletblDriverInfo.DriverExcludedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverExcludedNull()
    {
      this[this.tabletblDriverInfo.DriverExcludedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGenerateDocNull() => this.IsNull(this.tabletblDriverInfo.GenerateDocColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGenerateDocNull()
    {
      this[this.tabletblDriverInfo.GenerateDocColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOCNull() => this.IsNull(this.tabletblDriverInfo.DOCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOCNull()
    {
      this[this.tabletblDriverInfo.DOCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsJobTitleNull() => this.IsNull(this.tabletblDriverInfo.JobTitleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetJobTitleNull()
    {
      this[this.tabletblDriverInfo.JobTitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberEncryptedNull()
    {
      return this.IsNull(this.tabletblDriverInfo.LicenseNumberEncryptedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberEncryptedNull()
    {
      this[this.tabletblDriverInfo.LicenseNumberEncryptedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOBEncryptedNull() => this.IsNull(this.tabletblDriverInfo.DOBEncryptedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOBEncryptedNull()
    {
      this[this.tabletblDriverInfo.DOBEncryptedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBulkDeleteNull() => this.IsNull(this.tabletblDriverInfo.BulkDeleteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBulkDeleteNull()
    {
      this[this.tabletblDriverInfo.BulkDeleteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsDriverInfo.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsDriverInfo.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }
  }

  public class lstDriverStatusInfoRow : DataRow
  {
    private dsDriverInfo.lstDriverStatusInfoDataTable tablelstDriverStatusInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDriverStatusInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDriverStatusInfo = (dsDriverInfo.lstDriverStatusInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte ID
    {
      get => Conversions.ToByte(this[this.tablelstDriverStatusInfo.IDColumn]);
      set => this[this.tablelstDriverStatusInfo.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Status
    {
      get => Conversions.ToString(this[this.tablelstDriverStatusInfo.StatusColumn]);
      set => this[this.tablelstDriverStatusInfo.StatusColumn] = (object) value;
    }
  }

  public class tblADRRow : DataRow
  {
    private dsDriverInfo.tblADRDataTable tabletblADR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblADRRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblADR = (dsDriverInfo.tblADRDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ADR_ID
    {
      get => Conversions.ToInteger(this[this.tabletblADR.ADR_IDColumn]);
      set => this[this.tabletblADR.ADR_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AccountID
    {
      get => Conversions.ToString(this[this.tabletblADR.AccountIDColumn]);
      set => this[this.tabletblADR.AccountIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Purpose
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.PurposeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Purpose' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.PurposeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProductID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ProductIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProductID' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ProductIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime OrderDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblADR.OrderDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OrderDate' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.OrderDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Reference
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ReferenceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Reference' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ReferenceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Control
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ControlColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Control' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ControlColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Valid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ValidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Valid' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ValidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ReklamiErrorCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ReklamiErrorCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReklamiErrorCode' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ReklamiErrorCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ErrorCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ErrorCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ErrorCode' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ErrorCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ErrorDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ErrorDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ErrorDescription' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ErrorDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ResultBlob
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.ResultBlobColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ResultBlob' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.ResultBlobColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Routing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.RoutingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Routing' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.RoutingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TrackingNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.TrackingNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TrackingNumber' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.TrackingNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BillCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.BillCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillCode' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.BillCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Host
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.HostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Host' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.HostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.LineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Line' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblADR.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'tblADR' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblADR.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPurposeNull() => this.IsNull(this.tabletblADR.PurposeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPurposeNull()
    {
      this[this.tabletblADR.PurposeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProductIDNull() => this.IsNull(this.tabletblADR.ProductIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProductIDNull()
    {
      this[this.tabletblADR.ProductIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOrderDateNull() => this.IsNull(this.tabletblADR.OrderDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOrderDateNull()
    {
      this[this.tabletblADR.OrderDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReferenceNull() => this.IsNull(this.tabletblADR.ReferenceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReferenceNull()
    {
      this[this.tabletblADR.ReferenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsControlNull() => this.IsNull(this.tabletblADR.ControlColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetControlNull()
    {
      this[this.tabletblADR.ControlColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsValidNull() => this.IsNull(this.tabletblADR.ValidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetValidNull()
    {
      this[this.tabletblADR.ValidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReklamiErrorCodeNull() => this.IsNull(this.tabletblADR.ReklamiErrorCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReklamiErrorCodeNull()
    {
      this[this.tabletblADR.ReklamiErrorCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsErrorCodeNull() => this.IsNull(this.tabletblADR.ErrorCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetErrorCodeNull()
    {
      this[this.tabletblADR.ErrorCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsErrorDescriptionNull() => this.IsNull(this.tabletblADR.ErrorDescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetErrorDescriptionNull()
    {
      this[this.tabletblADR.ErrorDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsResultBlobNull() => this.IsNull(this.tabletblADR.ResultBlobColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetResultBlobNull()
    {
      this[this.tabletblADR.ResultBlobColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoutingNull() => this.IsNull(this.tabletblADR.RoutingColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoutingNull()
    {
      this[this.tabletblADR.RoutingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTrackingNumberNull() => this.IsNull(this.tabletblADR.TrackingNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTrackingNumberNull()
    {
      this[this.tabletblADR.TrackingNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBillCodeNull() => this.IsNull(this.tabletblADR.BillCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBillCodeNull()
    {
      this[this.tabletblADR.BillCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHostNull() => this.IsNull(this.tabletblADR.HostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHostNull()
    {
      this[this.tabletblADR.HostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberNull() => this.IsNull(this.tabletblADR.LicenseNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tabletblADR.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tabletblADR.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineNull()
    {
      this[this.tabletblADR.LineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabletblADR.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabletblADR.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabletblADR.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabletblADR.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtDriverInfoRow : DataRow
  {
    private dsDriverInfo.dtDriverInfoDataTable tabledtDriverInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtDriverInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtDriverInfo = (dsDriverInfo.dtDriverInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public long DriverID
    {
      get => Conversions.ToLong(this[this.tabledtDriverInfo.DriverIDColumn]);
      set => this[this.tabledtDriverInfo.DriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabledtDriverInfo.ControlNoColumn]);
      set => this[this.tabledtDriverInfo.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabledtDriverInfo.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledtDriverInfo.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string QuoteStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.QuoteStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatus' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.QuoteStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtDriverInfo.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtDriverInfo.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtDriverInfo.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverDeleted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtDriverInfo.DriverDeletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverDeleted' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.DriverDeletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtDriverInfo.DriverAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverAdded' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.DriverAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NumberOfPoints
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.NumberOfPointsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumberOfPoints' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.NumberOfPointsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte FullPartTime
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabledtDriverInfo.FullPartTimeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullPartTime' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.FullPartTimeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LicenseExpDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtDriverInfo.LicenseExpDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseExpDate' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.LicenseExpDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Street1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.Street1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street1' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.Street1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtDriverInfo.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Copy
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtDriverInfo.CopyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Copy' in table 'dtDriverInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtDriverInfo.CopyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabledtDriverInfo.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtDriverInfo.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsQuoteStatusNull() => this.IsNull(this.tabledtDriverInfo.QuoteStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetQuoteStatusNull()
    {
      this[this.tabledtDriverInfo.QuoteStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabledtDriverInfo.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabledtDriverInfo.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabledtDriverInfo.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabledtDriverInfo.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabledtDriverInfo.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabledtDriverInfo.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberNull() => this.IsNull(this.tabledtDriverInfo.LicenseNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tabledtDriverInfo.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabledtDriverInfo.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabledtDriverInfo.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabledtDriverInfo.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabledtDriverInfo.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabledtDriverInfo.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabledtDriverInfo.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverDeletedNull() => this.IsNull(this.tabledtDriverInfo.DriverDeletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverDeletedNull()
    {
      this[this.tabledtDriverInfo.DriverDeletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverAddedNull() => this.IsNull(this.tabledtDriverInfo.DriverAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverAddedNull()
    {
      this[this.tabledtDriverInfo.DriverAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumberOfPointsNull() => this.IsNull(this.tabledtDriverInfo.NumberOfPointsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumberOfPointsNull()
    {
      this[this.tabledtDriverInfo.NumberOfPointsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullPartTimeNull() => this.IsNull(this.tabledtDriverInfo.FullPartTimeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullPartTimeNull()
    {
      this[this.tabledtDriverInfo.FullPartTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseExpDateNull() => this.IsNull(this.tabledtDriverInfo.LicenseExpDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseExpDateNull()
    {
      this[this.tabledtDriverInfo.LicenseExpDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStreet1Null() => this.IsNull(this.tabledtDriverInfo.Street1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStreet1Null()
    {
      this[this.tabledtDriverInfo.Street1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtDriverInfo.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtDriverInfo.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabledtDriverInfo.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabledtDriverInfo.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCopyNull() => this.IsNull(this.tabledtDriverInfo.CopyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCopyNull()
    {
      this[this.tabledtDriverInfo.CopyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtOrderingRow : DataRow
  {
    private dsDriverInfo.dtOrderingDataTable tabledtOrdering;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtOrderingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtOrdering = (dsDriverInfo.dtOrderingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DriverID
    {
      get => Conversions.ToInteger(this[this.tabledtOrdering.DriverIDColumn]);
      set => this[this.tabledtOrdering.DriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string MiddleName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.MiddleNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MiddleName' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.MiddleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtOrdering.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Suffix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.SuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Suffix' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.SuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Misc
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.MiscColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Misc' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.MiscColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProductID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.ProductIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProductID' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.ProductIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SubType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.SubTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubType' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.SubTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Purpose
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.PurposeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Purpose' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.PurposeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string VaultAge
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.VaultAgeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VaultAge' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.VaultAgeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string HintMvrInsuranceOption
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtOrdering.HintMvrInsuranceOptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HintMvrInsuranceOption' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.HintMvrInsuranceOptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool LicenseValidationLookup
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtOrdering.LicenseValidationLookupColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseValidationLookup' in table 'dtOrdering' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtOrdering.LicenseValidationLookupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberNull() => this.IsNull(this.tabledtOrdering.LicenseNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tabledtOrdering.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabledtOrdering.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabledtOrdering.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMiddleNameNull() => this.IsNull(this.tabledtOrdering.MiddleNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMiddleNameNull()
    {
      this[this.tabledtOrdering.MiddleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabledtOrdering.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabledtOrdering.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabledtOrdering.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabledtOrdering.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabledtOrdering.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabledtOrdering.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSuffixNull() => this.IsNull(this.tabledtOrdering.SuffixColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSuffixNull()
    {
      this[this.tabledtOrdering.SuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMiscNull() => this.IsNull(this.tabledtOrdering.MiscColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMiscNull()
    {
      this[this.tabledtOrdering.MiscColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProductIDNull() => this.IsNull(this.tabledtOrdering.ProductIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProductIDNull()
    {
      this[this.tabledtOrdering.ProductIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubTypeNull() => this.IsNull(this.tabledtOrdering.SubTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubTypeNull()
    {
      this[this.tabledtOrdering.SubTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPurposeNull() => this.IsNull(this.tabledtOrdering.PurposeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPurposeNull()
    {
      this[this.tabledtOrdering.PurposeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsVaultAgeNull() => this.IsNull(this.tabledtOrdering.VaultAgeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetVaultAgeNull()
    {
      this[this.tabledtOrdering.VaultAgeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHintMvrInsuranceOptionNull()
    {
      return this.IsNull(this.tabledtOrdering.HintMvrInsuranceOptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHintMvrInsuranceOptionNull()
    {
      this[this.tabledtOrdering.HintMvrInsuranceOptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseValidationLookupNull()
    {
      return this.IsNull(this.tabledtOrdering.LicenseValidationLookupColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseValidationLookupNull()
    {
      this[this.tabledtOrdering.LicenseValidationLookupColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsDriverInfo.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsDriverInfo.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tabletblUsers.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUsers.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name_LastFirst
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUsers.Name_LastFirstColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name_LastFirst' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.Name_LastFirstColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsName_LastFirstNull() => this.IsNull(this.tabletblUsers.Name_LastFirstColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblUsers.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtQueryRow : DataRow
  {
    private dsDriverInfo.dtQueryDataTable tabledtQuery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtQueryRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtQuery = (dsDriverInfo.dtQueryDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public long DriverID
    {
      get => Conversions.ToLong(this[this.tabledtQuery.DriverIDColumn]);
      set => this[this.tabledtQuery.DriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabledtQuery.ControlNoColumn]);
      set => this[this.tabledtQuery.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabledtQuery.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledtQuery.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string QuoteStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.QuoteStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatus' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.QuoteStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtQuery.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DriverStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.DriverStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverStatus' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.DriverStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtQuery.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverDeleted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtQuery.DriverDeletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverDeleted' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.DriverDeletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DriverAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtQuery.DriverAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DriverAdded' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.DriverAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NumberOfPoints
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.NumberOfPointsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumberOfPoints' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.NumberOfPointsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FullPartTime
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.FullPartTimeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullPartTime' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.FullPartTimeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LicenseExpDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtQuery.LicenseExpDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseExpDate' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.LicenseExpDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Street1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.Street1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street1' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.Street1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtQuery.InsuredPolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPolicyName' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtQuery.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'dtQuery' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtQuery.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabledtQuery.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtQuery.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsQuoteStatusNull() => this.IsNull(this.tabledtQuery.QuoteStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetQuoteStatusNull()
    {
      this[this.tabledtQuery.QuoteStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabledtQuery.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabledtQuery.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabledtQuery.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabledtQuery.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabledtQuery.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabledtQuery.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberNull() => this.IsNull(this.tabledtQuery.LicenseNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tabledtQuery.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabledtQuery.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabledtQuery.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverStatusNull() => this.IsNull(this.tabledtQuery.DriverStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverStatusNull()
    {
      this[this.tabledtQuery.DriverStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabledtQuery.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabledtQuery.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverDeletedNull() => this.IsNull(this.tabledtQuery.DriverDeletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverDeletedNull()
    {
      this[this.tabledtQuery.DriverDeletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverAddedNull() => this.IsNull(this.tabledtQuery.DriverAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverAddedNull()
    {
      this[this.tabledtQuery.DriverAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumberOfPointsNull() => this.IsNull(this.tabledtQuery.NumberOfPointsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumberOfPointsNull()
    {
      this[this.tabledtQuery.NumberOfPointsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullPartTimeNull() => this.IsNull(this.tabledtQuery.FullPartTimeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullPartTimeNull()
    {
      this[this.tabledtQuery.FullPartTimeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseExpDateNull() => this.IsNull(this.tabledtQuery.LicenseExpDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseExpDateNull()
    {
      this[this.tabledtQuery.LicenseExpDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStreet1Null() => this.IsNull(this.tabledtQuery.Street1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStreet1Null()
    {
      this[this.tabledtQuery.Street1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtQuery.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtQuery.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabledtQuery.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabledtQuery.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInsuredPolicyNameNull() => this.IsNull(this.tabledtQuery.InsuredPolicyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tabledtQuery.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tabledtQuery.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tabledtQuery.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstDriverCDLRow : DataRow
  {
    private dsDriverInfo.lstDriverCDLDataTable tablelstDriverCDL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDriverCDLRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDriverCDL = (dsDriverInfo.lstDriverCDLDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstDriverCDL.IDColumn]);
      set => this[this.tablelstDriverCDL.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CDL
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstDriverCDL.CDLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CDL' in table 'lstDriverCDL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstDriverCDL.CDLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCDLNull() => this.IsNull(this.tablelstDriverCDL.CDLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCDLNull()
    {
      this[this.tablelstDriverCDL.CDLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDriverProductStatesRow : DataRow
  {
    private dsDriverInfo.tblDriverProductStatesDataTable tabletblDriverProductStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverProductStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDriverProductStates = (dsDriverInfo.tblDriverProductStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblDriverProductStates.StateIDColumn]);
      set => this[this.tabletblDriverProductStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SubType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverProductStates.SubTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubType' in table 'tblDriverProductStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverProductStates.SubTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FullOption
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverProductStates.FullOptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullOption' in table 'tblDriverProductStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverProductStates.FullOptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CleanOption
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverProductStates.CleanOptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CleanOption' in table 'tblDriverProductStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverProductStates.CleanOptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ActivityOption
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverProductStates.ActivityOptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ActivityOption' in table 'tblDriverProductStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverProductStates.ActivityOptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool VdetailOption
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDriverProductStates.VdetailOptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VdetailOption' in table 'tblDriverProductStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverProductStates.VdetailOptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AlternateSubType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverProductStates.AlternateSubTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AlternateSubType' in table 'tblDriverProductStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverProductStates.AlternateSubTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubTypeNull() => this.IsNull(this.tabletblDriverProductStates.SubTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubTypeNull()
    {
      this[this.tabletblDriverProductStates.SubTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullOptionNull()
    {
      return this.IsNull(this.tabletblDriverProductStates.FullOptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullOptionNull()
    {
      this[this.tabletblDriverProductStates.FullOptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCleanOptionNull()
    {
      return this.IsNull(this.tabletblDriverProductStates.CleanOptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCleanOptionNull()
    {
      this[this.tabletblDriverProductStates.CleanOptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsActivityOptionNull()
    {
      return this.IsNull(this.tabletblDriverProductStates.ActivityOptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetActivityOptionNull()
    {
      this[this.tabletblDriverProductStates.ActivityOptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsVdetailOptionNull()
    {
      return this.IsNull(this.tabletblDriverProductStates.VdetailOptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetVdetailOptionNull()
    {
      this[this.tabletblDriverProductStates.VdetailOptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAlternateSubTypeNull()
    {
      return this.IsNull(this.tabletblDriverProductStates.AlternateSubTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAlternateSubTypeNull()
    {
      this[this.tabletblDriverProductStates.AlternateSubTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtProductsRow : DataRow
  {
    private dsDriverInfo.dtProductsDataTable tabledtProducts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtProductsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtProducts = (dsDriverInfo.dtProductsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProductID
    {
      get => Conversions.ToString(this[this.tabledtProducts.ProductIDColumn]);
      set => this[this.tabledtProducts.ProductIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtProducts.IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ID' in table 'dtProducts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducts.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIDNull() => this.IsNull(this.tabledtProducts.IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIDNull()
    {
      this[this.tabledtProducts.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtOptionsRow : DataRow
  {
    private dsDriverInfo.dtOptionsDataTable tabledtOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtOptions = (dsDriverInfo.dtOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string HintMvrInsuranceOption
    {
      get => Conversions.ToString(this[this.tabledtOptions.HintMvrInsuranceOptionColumn]);
      set => this[this.tabledtOptions.HintMvrInsuranceOptionColumn] = (object) value;
    }
  }

  public class tblDriverReqsRow : DataRow
  {
    private dsDriverInfo.tblDriverReqsDataTable tabletblDriverReqs;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverReqsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDriverReqs = (dsDriverInfo.tblDriverReqsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DriverID
    {
      get => Conversions.ToInteger(this[this.tabletblDriverReqs.DriverIDColumn]);
      set => this[this.tabletblDriverReqs.DriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Valid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.ValidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Valid' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.ValidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string IsClear
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.IsClearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsClear' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.IsClearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DLStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.DLStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DLStatus' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.DLStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DocumentValidationResult
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.DocumentValidationResultColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentValidationResult' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.DocumentValidationResultColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string MatchError
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.MatchErrorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MatchError' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.MatchErrorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InvoicePath
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.InvoicePathColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoicePath' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.InvoicePathColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyClass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.CompanyClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyClass' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.CompanyClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ErrorDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDriverReqs.ErrorDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ErrorDescription' in table 'tblDriverReqs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDriverReqs.ErrorDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsValidNull() => this.IsNull(this.tabletblDriverReqs.ValidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetValidNull()
    {
      this[this.tabletblDriverReqs.ValidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIsClearNull() => this.IsNull(this.tabletblDriverReqs.IsClearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIsClearNull()
    {
      this[this.tabletblDriverReqs.IsClearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDLStatusNull() => this.IsNull(this.tabletblDriverReqs.DLStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDLStatusNull()
    {
      this[this.tabletblDriverReqs.DLStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDocumentValidationResultNull()
    {
      return this.IsNull(this.tabletblDriverReqs.DocumentValidationResultColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDocumentValidationResultNull()
    {
      this[this.tabletblDriverReqs.DocumentValidationResultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMatchErrorNull() => this.IsNull(this.tabletblDriverReqs.MatchErrorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMatchErrorNull()
    {
      this[this.tabletblDriverReqs.MatchErrorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInvoicePathNull() => this.IsNull(this.tabletblDriverReqs.InvoicePathColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInvoicePathNull()
    {
      this[this.tabletblDriverReqs.InvoicePathColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyClassNull() => this.IsNull(this.tabletblDriverReqs.CompanyClassColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyClassNull()
    {
      this[this.tabletblDriverReqs.CompanyClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsErrorDescriptionNull()
    {
      return this.IsNull(this.tabletblDriverReqs.ErrorDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetErrorDescriptionNull()
    {
      this[this.tabletblDriverReqs.ErrorDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDriverLicenseValidationStatesRow : DataRow
  {
    private dsDriverInfo.tblDriverLicenseValidationStatesDataTable tabletblDriverLicenseValidationStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDriverLicenseValidationStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDriverLicenseValidationStates = (dsDriverInfo.tblDriverLicenseValidationStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblDriverLicenseValidationStates.StateIDColumn]);
      set => this[this.tabletblDriverLicenseValidationStates.StateIDColumn] = (object) value;
    }
  }

  public class dtIIXRow : DataRow
  {
    private dsDriverInfo.dtIIXDataTable tabledtIIX;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtIIXRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtIIX = (dsDriverInfo.dtIIXDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DriverID
    {
      get => Conversions.ToInteger(this[this.tabledtIIX.DriverIDColumn]);
      set => this[this.tabledtIIX.DriverIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RequestType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.RequestTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequestType' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.RequestTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string MiddleName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.MiddleNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MiddleName' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.MiddleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtIIX.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Suffix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtIIX.SuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Suffix' in table 'dtIIX' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtIIX.SuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRequestTypeNull() => this.IsNull(this.tabledtIIX.RequestTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRequestTypeNull()
    {
      this[this.tabledtIIX.RequestTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLicenseNumberNull() => this.IsNull(this.tabledtIIX.LicenseNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tabledtIIX.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabledtIIX.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabledtIIX.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMiddleNameNull() => this.IsNull(this.tabledtIIX.MiddleNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMiddleNameNull()
    {
      this[this.tabledtIIX.MiddleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabledtIIX.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabledtIIX.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabledtIIX.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabledtIIX.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabledtIIX.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabledtIIX.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSuffixNull() => this.IsNull(this.tabledtIIX.SuffixColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSuffixNull()
    {
      this[this.tabledtIIX.SuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstIIXMVRTypesRow : DataRow
  {
    private dsDriverInfo.lstIIXMVRTypesDataTable tablelstIIXMVRTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstIIXMVRTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstIIXMVRTypes = (dsDriverInfo.lstIIXMVRTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstIIXMVRTypes.IDColumn]);
      set => this[this.tablelstIIXMVRTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstIIXMVRTypes.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'lstIIXMVRTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstIIXMVRTypes.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Type
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstIIXMVRTypes.TypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Type' in table 'lstIIXMVRTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstIIXMVRTypes.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstIIXMVRTypes.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstIIXMVRTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstIIXMVRTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tablelstIIXMVRTypes.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tablelstIIXMVRTypes.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTypeNull() => this.IsNull(this.tablelstIIXMVRTypes.TypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTypeNull()
    {
      this[this.tablelstIIXMVRTypes.TypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstIIXMVRTypes.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstIIXMVRTypes.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstDriverStatusRowChangeEvent : EventArgs
  {
    private dsDriverInfo.lstDriverStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDriverStatusRowChangeEvent(dsDriverInfo.lstDriverStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblDriverInfoRowChangeEvent : EventArgs
  {
    private dsDriverInfo.tblDriverInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverInfoRowChangeEvent(dsDriverInfo.tblDriverInfoRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsDriverInfo.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesRowChangeEvent(dsDriverInfo.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstDriverStatusInfoRowChangeEvent : EventArgs
  {
    private dsDriverInfo.lstDriverStatusInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDriverStatusInfoRowChangeEvent(
      dsDriverInfo.lstDriverStatusInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverStatusInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblADRRowChangeEvent : EventArgs
  {
    private dsDriverInfo.tblADRRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblADRRowChangeEvent(dsDriverInfo.tblADRRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblADRRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtDriverInfoRowChangeEvent : EventArgs
  {
    private dsDriverInfo.dtDriverInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtDriverInfoRowChangeEvent(dsDriverInfo.dtDriverInfoRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtDriverInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtOrderingRowChangeEvent : EventArgs
  {
    private dsDriverInfo.dtOrderingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtOrderingRowChangeEvent(dsDriverInfo.dtOrderingRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOrderingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsDriverInfo.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersRowChangeEvent(dsDriverInfo.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtQueryRowChangeEvent : EventArgs
  {
    private dsDriverInfo.dtQueryRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtQueryRowChangeEvent(dsDriverInfo.dtQueryRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtQueryRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstDriverCDLRowChangeEvent : EventArgs
  {
    private dsDriverInfo.lstDriverCDLRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDriverCDLRowChangeEvent(dsDriverInfo.lstDriverCDLRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstDriverCDLRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblDriverProductStatesRowChangeEvent : EventArgs
  {
    private dsDriverInfo.tblDriverProductStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverProductStatesRowChangeEvent(
      dsDriverInfo.tblDriverProductStatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverProductStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtProductsRowChangeEvent : EventArgs
  {
    private dsDriverInfo.dtProductsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtProductsRowChangeEvent(dsDriverInfo.dtProductsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtProductsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtOptionsRowChangeEvent : EventArgs
  {
    private dsDriverInfo.dtOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtOptionsRowChangeEvent(dsDriverInfo.dtOptionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblDriverReqsRowChangeEvent : EventArgs
  {
    private dsDriverInfo.tblDriverReqsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverReqsRowChangeEvent(dsDriverInfo.tblDriverReqsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverReqsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblDriverLicenseValidationStatesRowChangeEvent : EventArgs
  {
    private dsDriverInfo.tblDriverLicenseValidationStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDriverLicenseValidationStatesRowChangeEvent(
      dsDriverInfo.tblDriverLicenseValidationStatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.tblDriverLicenseValidationStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtIIXRowChangeEvent : EventArgs
  {
    private dsDriverInfo.dtIIXRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtIIXRowChangeEvent(dsDriverInfo.dtIIXRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.dtIIXRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstIIXMVRTypesRowChangeEvent : EventArgs
  {
    private dsDriverInfo.lstIIXMVRTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstIIXMVRTypesRowChangeEvent(dsDriverInfo.lstIIXMVRTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsDriverInfo.lstIIXMVRTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
