// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.dsAdminInspReq
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
namespace MGASystems.IMS.Forms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdminInspReq")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdminInspReq : DataSet
{
  private dsAdminInspReq.tblAdminInspectionRequestsDataTable tabletblAdminInspectionRequests;
  private dsAdminInspReq.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;
  private dsAdminInspReq.lstAdminInspectionStatusDataTable tablelstAdminInspectionStatus;
  private dsAdminInspReq.dtFilterDateDataTable tabledtFilterDate;
  private dsAdminInspReq.dtLoggingDataTable tabledtLogging;
  private dsAdminInspReq.dtReportDataTable tabledtReport;
  private dsAdminInspReq.dtReportGenericDataTable tabledtReportGeneric;
  private dsAdminInspReq.dtColumnsDataTable tabledtColumns;
  private dsAdminInspReq.lstInspectionsAdminRecStatusDataTable tablelstInspectionsAdminRecStatus;
  private dsAdminInspReq.lstAdminInspectionTypesDataTable tablelstAdminInspectionTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsAdminInspReq()
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
  protected dsAdminInspReq(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblAdminInspectionRequests)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.tblAdminInspectionRequestsDataTable(dataSet.Tables[nameof (tblAdminInspectionRequests)]));
        if (dataSet.Tables[nameof (tblFin_ExpensePayees)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.tblFin_ExpensePayeesDataTable(dataSet.Tables[nameof (tblFin_ExpensePayees)]));
        if (dataSet.Tables[nameof (lstAdminInspectionStatus)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.lstAdminInspectionStatusDataTable(dataSet.Tables[nameof (lstAdminInspectionStatus)]));
        if (dataSet.Tables[nameof (dtFilterDate)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.dtFilterDateDataTable(dataSet.Tables[nameof (dtFilterDate)]));
        if (dataSet.Tables[nameof (dtLogging)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.dtLoggingDataTable(dataSet.Tables[nameof (dtLogging)]));
        if (dataSet.Tables[nameof (dtReport)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.dtReportDataTable(dataSet.Tables[nameof (dtReport)]));
        if (dataSet.Tables[nameof (dtReportGeneric)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.dtReportGenericDataTable(dataSet.Tables[nameof (dtReportGeneric)]));
        if (dataSet.Tables[nameof (dtColumns)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.dtColumnsDataTable(dataSet.Tables[nameof (dtColumns)]));
        if (dataSet.Tables[nameof (lstInspectionsAdminRecStatus)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.lstInspectionsAdminRecStatusDataTable(dataSet.Tables[nameof (lstInspectionsAdminRecStatus)]));
        if (dataSet.Tables[nameof (lstAdminInspectionTypes)] != null)
          base.Tables.Add((DataTable) new dsAdminInspReq.lstAdminInspectionTypesDataTable(dataSet.Tables[nameof (lstAdminInspectionTypes)]));
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
  public dsAdminInspReq.tblAdminInspectionRequestsDataTable tblAdminInspectionRequests
  {
    get => this.tabletblAdminInspectionRequests;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.tblFin_ExpensePayeesDataTable tblFin_ExpensePayees
  {
    get => this.tabletblFin_ExpensePayees;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.lstAdminInspectionStatusDataTable lstAdminInspectionStatus
  {
    get => this.tablelstAdminInspectionStatus;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.dtFilterDateDataTable dtFilterDate => this.tabledtFilterDate;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.dtLoggingDataTable dtLogging => this.tabledtLogging;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.dtReportDataTable dtReport => this.tabledtReport;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.dtReportGenericDataTable dtReportGeneric => this.tabledtReportGeneric;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.dtColumnsDataTable dtColumns => this.tabledtColumns;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.lstInspectionsAdminRecStatusDataTable lstInspectionsAdminRecStatus
  {
    get => this.tablelstInspectionsAdminRecStatus;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminInspReq.lstAdminInspectionTypesDataTable lstAdminInspectionTypes
  {
    get => this.tablelstAdminInspectionTypes;
  }

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
    dsAdminInspReq dsAdminInspReq = (dsAdminInspReq) base.Clone();
    dsAdminInspReq.InitVars();
    dsAdminInspReq.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsAdminInspReq;
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
      if (dataSet.Tables["tblAdminInspectionRequests"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.tblAdminInspectionRequestsDataTable(dataSet.Tables["tblAdminInspectionRequests"]));
      if (dataSet.Tables["tblFin_ExpensePayees"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.tblFin_ExpensePayeesDataTable(dataSet.Tables["tblFin_ExpensePayees"]));
      if (dataSet.Tables["lstAdminInspectionStatus"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.lstAdminInspectionStatusDataTable(dataSet.Tables["lstAdminInspectionStatus"]));
      if (dataSet.Tables["dtFilterDate"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.dtFilterDateDataTable(dataSet.Tables["dtFilterDate"]));
      if (dataSet.Tables["dtLogging"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.dtLoggingDataTable(dataSet.Tables["dtLogging"]));
      if (dataSet.Tables["dtReport"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.dtReportDataTable(dataSet.Tables["dtReport"]));
      if (dataSet.Tables["dtReportGeneric"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.dtReportGenericDataTable(dataSet.Tables["dtReportGeneric"]));
      if (dataSet.Tables["dtColumns"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.dtColumnsDataTable(dataSet.Tables["dtColumns"]));
      if (dataSet.Tables["lstInspectionsAdminRecStatus"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.lstInspectionsAdminRecStatusDataTable(dataSet.Tables["lstInspectionsAdminRecStatus"]));
      if (dataSet.Tables["lstAdminInspectionTypes"] != null)
        base.Tables.Add((DataTable) new dsAdminInspReq.lstAdminInspectionTypesDataTable(dataSet.Tables["lstAdminInspectionTypes"]));
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
    this.tabletblAdminInspectionRequests = (dsAdminInspReq.tblAdminInspectionRequestsDataTable) base.Tables["tblAdminInspectionRequests"];
    if (initTable && this.tabletblAdminInspectionRequests != null)
      this.tabletblAdminInspectionRequests.InitVars();
    this.tabletblFin_ExpensePayees = (dsAdminInspReq.tblFin_ExpensePayeesDataTable) base.Tables["tblFin_ExpensePayees"];
    if (initTable && this.tabletblFin_ExpensePayees != null)
      this.tabletblFin_ExpensePayees.InitVars();
    this.tablelstAdminInspectionStatus = (dsAdminInspReq.lstAdminInspectionStatusDataTable) base.Tables["lstAdminInspectionStatus"];
    if (initTable && this.tablelstAdminInspectionStatus != null)
      this.tablelstAdminInspectionStatus.InitVars();
    this.tabledtFilterDate = (dsAdminInspReq.dtFilterDateDataTable) base.Tables["dtFilterDate"];
    if (initTable && this.tabledtFilterDate != null)
      this.tabledtFilterDate.InitVars();
    this.tabledtLogging = (dsAdminInspReq.dtLoggingDataTable) base.Tables["dtLogging"];
    if (initTable && this.tabledtLogging != null)
      this.tabledtLogging.InitVars();
    this.tabledtReport = (dsAdminInspReq.dtReportDataTable) base.Tables["dtReport"];
    if (initTable && this.tabledtReport != null)
      this.tabledtReport.InitVars();
    this.tabledtReportGeneric = (dsAdminInspReq.dtReportGenericDataTable) base.Tables["dtReportGeneric"];
    if (initTable && this.tabledtReportGeneric != null)
      this.tabledtReportGeneric.InitVars();
    this.tabledtColumns = (dsAdminInspReq.dtColumnsDataTable) base.Tables["dtColumns"];
    if (initTable && this.tabledtColumns != null)
      this.tabledtColumns.InitVars();
    this.tablelstInspectionsAdminRecStatus = (dsAdminInspReq.lstInspectionsAdminRecStatusDataTable) base.Tables["lstInspectionsAdminRecStatus"];
    if (initTable && this.tablelstInspectionsAdminRecStatus != null)
      this.tablelstInspectionsAdminRecStatus.InitVars();
    this.tablelstAdminInspectionTypes = (dsAdminInspReq.lstAdminInspectionTypesDataTable) base.Tables["lstAdminInspectionTypes"];
    if (!initTable || this.tablelstAdminInspectionTypes == null)
      return;
    this.tablelstAdminInspectionTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdminInspReq);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsAdminInspReq.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblAdminInspectionRequests = new dsAdminInspReq.tblAdminInspectionRequestsDataTable();
    base.Tables.Add((DataTable) this.tabletblAdminInspectionRequests);
    this.tabletblFin_ExpensePayees = new dsAdminInspReq.tblFin_ExpensePayeesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_ExpensePayees);
    this.tablelstAdminInspectionStatus = new dsAdminInspReq.lstAdminInspectionStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstAdminInspectionStatus);
    this.tabledtFilterDate = new dsAdminInspReq.dtFilterDateDataTable();
    base.Tables.Add((DataTable) this.tabledtFilterDate);
    this.tabledtLogging = new dsAdminInspReq.dtLoggingDataTable();
    base.Tables.Add((DataTable) this.tabledtLogging);
    this.tabledtReport = new dsAdminInspReq.dtReportDataTable();
    base.Tables.Add((DataTable) this.tabledtReport);
    this.tabledtReportGeneric = new dsAdminInspReq.dtReportGenericDataTable();
    base.Tables.Add((DataTable) this.tabledtReportGeneric);
    this.tabledtColumns = new dsAdminInspReq.dtColumnsDataTable();
    base.Tables.Add((DataTable) this.tabledtColumns);
    this.tablelstInspectionsAdminRecStatus = new dsAdminInspReq.lstInspectionsAdminRecStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstInspectionsAdminRecStatus);
    this.tablelstAdminInspectionTypes = new dsAdminInspReq.lstAdminInspectionTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstAdminInspectionTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblAdminInspectionRequests() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblFin_ExpensePayees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstAdminInspectionStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtFilterDate() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtLogging() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtReport() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtReportGeneric() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtColumns() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstInspectionsAdminRecStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstAdminInspectionTypes() => false;

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
    dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsAdminInspReq.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public delegate void tblAdminInspectionRequestsRowChangeEventHandler(
    object sender,
    dsAdminInspReq.tblAdminInspectionRequestsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblFin_ExpensePayeesRowChangeEventHandler(
    object sender,
    dsAdminInspReq.tblFin_ExpensePayeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstAdminInspectionStatusRowChangeEventHandler(
    object sender,
    dsAdminInspReq.lstAdminInspectionStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtFilterDateRowChangeEventHandler(
    object sender,
    dsAdminInspReq.dtFilterDateRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtLoggingRowChangeEventHandler(
    object sender,
    dsAdminInspReq.dtLoggingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtReportRowChangeEventHandler(
    object sender,
    dsAdminInspReq.dtReportRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtReportGenericRowChangeEventHandler(
    object sender,
    dsAdminInspReq.dtReportGenericRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtColumnsRowChangeEventHandler(
    object sender,
    dsAdminInspReq.dtColumnsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstInspectionsAdminRecStatusRowChangeEventHandler(
    object sender,
    dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstAdminInspectionTypesRowChangeEventHandler(
    object sender,
    dsAdminInspReq.lstAdminInspectionTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblAdminInspectionRequestsDataTable : 
    TypedTableBase<dsAdminInspReq.tblAdminInspectionRequestsRow>
  {
    private DataColumn columnID;
    private DataColumn columnFollowUp;
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnLOB;
    private DataColumn columnLocationID;
    private DataColumn columnLocationNumber;
    private DataColumn columnLocationAddress;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnInspectionCompanyID;
    private DataColumn columnInspectionContact;
    private DataColumn columnInspectionContactPhone;
    private DataColumn columnUnderwriter;
    private DataColumn columnEffectiveDate;
    private DataColumn columnOrderDate;
    private DataColumn columnDropDeadDate;
    private DataColumn columnFollowupDate;
    private DataColumn columnReceivedDate;
    private DataColumn columnReceived;
    private DataColumn columnRevisedContactInfo;
    private DataColumn columnInspectionStatus;
    private DataColumn columnOrderedBy;
    private DataColumn columnInspType;
    private DataColumn columnOnEndorsement;
    private DataColumn columnPolicyType;
    private DataColumn columnInsuredID;
    private DataColumn columnPolicyStatus;
    private DataColumn columnClosed;
    private DataColumn columnClosedDate;
    private DataColumn columnCriticalOutstanding;
    private DataColumn columnCriticalWaived;
    private DataColumn columnCriticalComplete;
    private DataColumn columnCriticalTotal;
    private DataColumn columnNonCriticalOutstanding;
    private DataColumn columnNonCriticalWaived;
    private DataColumn columnNonCriticalComplete;
    private DataColumn columnNonCriticalTotal;
    private DataColumn columnRecStatusID;
    private DataColumn columnRecSent;
    private DataColumn columnRecsFollowUp;
    private DataColumn columnRecsCompleted;
    private DataColumn columnRoof;
    private DataColumn columnNotes;
    private DataColumn columnRecsReceived;
    private DataColumn columnCPR;
    private DataColumn columnMap;
    private DataColumn columnSprinklerTest;
    private DataColumn columnThermo;
    private DataColumn columnFirePump;
    private DataColumn columnFocusAccount;
    private DataColumn columnCriticalAccount;
    private DataColumn columnLastAssessmentDate;
    private DataColumn columnInspectionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblAdminInspectionRequestsDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblAdminInspectionRequestsDataTable_ColumnChanging);
      this.tblAdminInspectionRequestsRowChanging += new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler(this.tblAdminInspectionRequestsDataTable_tblAdminInspectionRequestsRowChanging);
      this.TableName = "tblAdminInspectionRequests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblAdminInspectionRequestsDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblAdminInspectionRequestsDataTable_ColumnChanging);
      this.tblAdminInspectionRequestsRowChanging += new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler(this.tblAdminInspectionRequestsDataTable_tblAdminInspectionRequestsRowChanging);
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
    protected tblAdminInspectionRequestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblAdminInspectionRequestsDataTable_ColumnChanging);
      this.tblAdminInspectionRequestsRowChanging += new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler(this.tblAdminInspectionRequestsDataTable_tblAdminInspectionRequestsRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FollowUpColumn => this.columnFollowUp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNumberColumn => this.columnLocationNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationAddressColumn => this.columnLocationAddress;

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
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionCompanyIDColumn => this.columnInspectionCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactColumn => this.columnInspectionContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactPhoneColumn => this.columnInspectionContactPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OrderDateColumn => this.columnOrderDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DropDeadDateColumn => this.columnDropDeadDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FollowupDateColumn => this.columnFollowupDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReceivedDateColumn => this.columnReceivedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReceivedColumn => this.columnReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RevisedContactInfoColumn => this.columnRevisedContactInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionStatusColumn => this.columnInspectionStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OrderedByColumn => this.columnOrderedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspTypeColumn => this.columnInspType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OnEndorsementColumn => this.columnOnEndorsement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredIDColumn => this.columnInsuredID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyStatusColumn => this.columnPolicyStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClosedColumn => this.columnClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClosedDateColumn => this.columnClosedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalOutstandingColumn => this.columnCriticalOutstanding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalWaivedColumn => this.columnCriticalWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalCompleteColumn => this.columnCriticalComplete;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalTotalColumn => this.columnCriticalTotal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalOutstandingColumn => this.columnNonCriticalOutstanding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalWaivedColumn => this.columnNonCriticalWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalCompleteColumn => this.columnNonCriticalComplete;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalTotalColumn => this.columnNonCriticalTotal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecStatusIDColumn => this.columnRecStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecSentColumn => this.columnRecSent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecsFollowUpColumn => this.columnRecsFollowUp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecsCompletedColumn => this.columnRecsCompleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoofColumn => this.columnRoof;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecsReceivedColumn => this.columnRecsReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CPRColumn => this.columnCPR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MapColumn => this.columnMap;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SprinklerTestColumn => this.columnSprinklerTest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ThermoColumn => this.columnThermo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirePumpColumn => this.columnFirePump;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FocusAccountColumn => this.columnFocusAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalAccountColumn => this.columnCriticalAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastAssessmentDateColumn => this.columnLastAssessmentDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionTypeIDColumn => this.columnInspectionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblAdminInspectionRequestsRow this[int index]
    {
      get => (dsAdminInspReq.tblAdminInspectionRequestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler tblAdminInspectionRequestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler tblAdminInspectionRequestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler tblAdminInspectionRequestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler tblAdminInspectionRequestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblAdminInspectionRequestsRow(dsAdminInspReq.tblAdminInspectionRequestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblAdminInspectionRequestsRow AddtblAdminInspectionRequestsRow(
      Decimal ID,
      bool FollowUp,
      string ControlNo,
      string PolicyNumber,
      string Insured,
      string LOB,
      int LocationID,
      string LocationNumber,
      string LocationAddress,
      string Address1,
      string Address2,
      string City,
      string State,
      string Zip,
      int InspectionCompanyID,
      string InspectionContact,
      string InspectionContactPhone,
      string Underwriter,
      DateTime EffectiveDate,
      DateTime OrderDate,
      DateTime DropDeadDate,
      DateTime FollowupDate,
      DateTime ReceivedDate,
      bool Received,
      bool RevisedContactInfo,
      int InspectionStatus,
      string OrderedBy,
      string InspType,
      bool OnEndorsement,
      string PolicyType,
      int InsuredID,
      string PolicyStatus,
      bool Closed,
      DateTime ClosedDate,
      string CriticalOutstanding,
      string CriticalWaived,
      string CriticalComplete,
      string CriticalTotal,
      string NonCriticalOutstanding,
      string NonCriticalWaived,
      string NonCriticalComplete,
      string NonCriticalTotal,
      int RecStatusID,
      DateTime RecSent,
      DateTime RecsFollowUp,
      DateTime RecsCompleted,
      bool Roof,
      string Notes,
      bool RecsReceived,
      DateTime CPR,
      DateTime Map,
      DateTime SprinklerTest,
      DateTime Thermo,
      DateTime FirePump,
      bool FocusAccount,
      bool CriticalAccount,
      DateTime LastAssessmentDate,
      int InspectionTypeID)
    {
      dsAdminInspReq.tblAdminInspectionRequestsRow row = (dsAdminInspReq.tblAdminInspectionRequestsRow) this.NewRow();
      object[] objArray = new object[58]
      {
        (object) ID,
        (object) FollowUp,
        (object) ControlNo,
        (object) PolicyNumber,
        (object) Insured,
        (object) LOB,
        (object) LocationID,
        (object) LocationNumber,
        (object) LocationAddress,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) InspectionCompanyID,
        (object) InspectionContact,
        (object) InspectionContactPhone,
        (object) Underwriter,
        (object) EffectiveDate,
        (object) OrderDate,
        (object) DropDeadDate,
        (object) FollowupDate,
        (object) ReceivedDate,
        (object) Received,
        (object) RevisedContactInfo,
        (object) InspectionStatus,
        (object) OrderedBy,
        (object) InspType,
        (object) OnEndorsement,
        (object) PolicyType,
        (object) InsuredID,
        (object) PolicyStatus,
        (object) Closed,
        (object) ClosedDate,
        (object) CriticalOutstanding,
        (object) CriticalWaived,
        (object) CriticalComplete,
        (object) CriticalTotal,
        (object) NonCriticalOutstanding,
        (object) NonCriticalWaived,
        (object) NonCriticalComplete,
        (object) NonCriticalTotal,
        (object) RecStatusID,
        (object) RecSent,
        (object) RecsFollowUp,
        (object) RecsCompleted,
        (object) Roof,
        (object) Notes,
        (object) RecsReceived,
        (object) CPR,
        (object) Map,
        (object) SprinklerTest,
        (object) Thermo,
        (object) FirePump,
        (object) FocusAccount,
        (object) CriticalAccount,
        (object) LastAssessmentDate,
        (object) InspectionTypeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblAdminInspectionRequestsRow FindByID(Decimal ID)
    {
      return (dsAdminInspReq.tblAdminInspectionRequestsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.tblAdminInspectionRequestsDataTable requestsDataTable = (dsAdminInspReq.tblAdminInspectionRequestsDataTable) base.Clone();
      requestsDataTable.InitVars();
      return (DataTable) requestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.tblAdminInspectionRequestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnFollowUp = this.Columns["FollowUp"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnLOB = this.Columns["LOB"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationNumber = this.Columns["LocationNumber"];
      this.columnLocationAddress = this.Columns["LocationAddress"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnInspectionCompanyID = this.Columns["InspectionCompanyID"];
      this.columnInspectionContact = this.Columns["InspectionContact"];
      this.columnInspectionContactPhone = this.Columns["InspectionContactPhone"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnOrderDate = this.Columns["OrderDate"];
      this.columnDropDeadDate = this.Columns["DropDeadDate"];
      this.columnFollowupDate = this.Columns["FollowupDate"];
      this.columnReceivedDate = this.Columns["ReceivedDate"];
      this.columnReceived = this.Columns["Received"];
      this.columnRevisedContactInfo = this.Columns["RevisedContactInfo"];
      this.columnInspectionStatus = this.Columns["InspectionStatus"];
      this.columnOrderedBy = this.Columns["OrderedBy"];
      this.columnInspType = this.Columns["InspType"];
      this.columnOnEndorsement = this.Columns["OnEndorsement"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnInsuredID = this.Columns["InsuredID"];
      this.columnPolicyStatus = this.Columns["PolicyStatus"];
      this.columnClosed = this.Columns["Closed"];
      this.columnClosedDate = this.Columns["ClosedDate"];
      this.columnCriticalOutstanding = this.Columns["CriticalOutstanding"];
      this.columnCriticalWaived = this.Columns["CriticalWaived"];
      this.columnCriticalComplete = this.Columns["CriticalComplete"];
      this.columnCriticalTotal = this.Columns["CriticalTotal"];
      this.columnNonCriticalOutstanding = this.Columns["NonCriticalOutstanding"];
      this.columnNonCriticalWaived = this.Columns["NonCriticalWaived"];
      this.columnNonCriticalComplete = this.Columns["NonCriticalComplete"];
      this.columnNonCriticalTotal = this.Columns["NonCriticalTotal"];
      this.columnRecStatusID = this.Columns["RecStatusID"];
      this.columnRecSent = this.Columns["RecSent"];
      this.columnRecsFollowUp = this.Columns["RecsFollowUp"];
      this.columnRecsCompleted = this.Columns["RecsCompleted"];
      this.columnRoof = this.Columns["Roof"];
      this.columnNotes = this.Columns["Notes"];
      this.columnRecsReceived = this.Columns["RecsReceived"];
      this.columnCPR = this.Columns["CPR"];
      this.columnMap = this.Columns["Map"];
      this.columnSprinklerTest = this.Columns["SprinklerTest"];
      this.columnThermo = this.Columns["Thermo"];
      this.columnFirePump = this.Columns["FirePump"];
      this.columnFocusAccount = this.Columns["FocusAccount"];
      this.columnCriticalAccount = this.Columns["CriticalAccount"];
      this.columnLastAssessmentDate = this.Columns["LastAssessmentDate"];
      this.columnInspectionTypeID = this.Columns["InspectionTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnFollowUp = new DataColumn("FollowUp", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFollowUp);
      this.columnControlNo = new DataColumn("ControlNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationNumber = new DataColumn("LocationNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNumber);
      this.columnLocationAddress = new DataColumn("LocationAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationAddress);
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
      this.columnInspectionCompanyID = new DataColumn("InspectionCompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionCompanyID);
      this.columnInspectionContact = new DataColumn("InspectionContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContact);
      this.columnInspectionContactPhone = new DataColumn("InspectionContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContactPhone);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnOrderDate = new DataColumn("OrderDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOrderDate);
      this.columnDropDeadDate = new DataColumn("DropDeadDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDropDeadDate);
      this.columnFollowupDate = new DataColumn("FollowupDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFollowupDate);
      this.columnReceivedDate = new DataColumn("ReceivedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceivedDate);
      this.columnReceived = new DataColumn("Received", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceived);
      this.columnRevisedContactInfo = new DataColumn("RevisedContactInfo", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRevisedContactInfo);
      this.columnInspectionStatus = new DataColumn("InspectionStatus", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionStatus);
      this.columnOrderedBy = new DataColumn("OrderedBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOrderedBy);
      this.columnInspType = new DataColumn("InspType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspType);
      this.columnOnEndorsement = new DataColumn("OnEndorsement", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnEndorsement);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnInsuredID = new DataColumn("InsuredID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredID);
      this.columnPolicyStatus = new DataColumn("PolicyStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyStatus);
      this.columnClosed = new DataColumn("Closed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosed);
      this.columnClosedDate = new DataColumn("ClosedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosedDate);
      this.columnCriticalOutstanding = new DataColumn("CriticalOutstanding", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalOutstanding);
      this.columnCriticalWaived = new DataColumn("CriticalWaived", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalWaived);
      this.columnCriticalComplete = new DataColumn("CriticalComplete", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalComplete);
      this.columnCriticalTotal = new DataColumn("CriticalTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalTotal);
      this.columnNonCriticalOutstanding = new DataColumn("NonCriticalOutstanding", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalOutstanding);
      this.columnNonCriticalWaived = new DataColumn("NonCriticalWaived", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalWaived);
      this.columnNonCriticalComplete = new DataColumn("NonCriticalComplete", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalComplete);
      this.columnNonCriticalTotal = new DataColumn("NonCriticalTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalTotal);
      this.columnRecStatusID = new DataColumn("RecStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecStatusID);
      this.columnRecSent = new DataColumn("RecSent", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecSent);
      this.columnRecsFollowUp = new DataColumn("RecsFollowUp", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecsFollowUp);
      this.columnRecsCompleted = new DataColumn("RecsCompleted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecsCompleted);
      this.columnRoof = new DataColumn("Roof", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoof);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnRecsReceived = new DataColumn("RecsReceived", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecsReceived);
      this.columnCPR = new DataColumn("CPR", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCPR);
      this.columnMap = new DataColumn("Map", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMap);
      this.columnSprinklerTest = new DataColumn("SprinklerTest", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSprinklerTest);
      this.columnThermo = new DataColumn("Thermo", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnThermo);
      this.columnFirePump = new DataColumn("FirePump", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirePump);
      this.columnFocusAccount = new DataColumn("FocusAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFocusAccount);
      this.columnCriticalAccount = new DataColumn("CriticalAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalAccount);
      this.columnLastAssessmentDate = new DataColumn("LastAssessmentDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastAssessmentDate);
      this.columnInspectionTypeID = new DataColumn("InspectionTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnFollowUp.DefaultValue = (object) false;
      this.columnControlNo.AllowDBNull = false;
      this.columnPolicyNumber.AllowDBNull = false;
      this.columnPolicyNumber.MaxLength = 50;
      this.columnInsured.AllowDBNull = false;
      this.columnInsured.MaxLength = 800;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationAddress.AllowDBNull = false;
      this.columnLocationAddress.MaxLength = 800;
      this.columnInspectionCompanyID.AllowDBNull = false;
      this.columnReceived.DefaultValue = (object) false;
      this.columnRevisedContactInfo.DefaultValue = (object) false;
      this.columnOnEndorsement.DefaultValue = (object) false;
      this.columnClosed.DefaultValue = (object) false;
      this.columnRoof.DefaultValue = (object) false;
      this.columnRecsReceived.DefaultValue = (object) false;
      this.columnFocusAccount.DefaultValue = (object) false;
      this.columnCriticalAccount.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblAdminInspectionRequestsRow NewtblAdminInspectionRequestsRow()
    {
      return (dsAdminInspReq.tblAdminInspectionRequestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.tblAdminInspectionRequestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.tblAdminInspectionRequestsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminInspectionRequestsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler requestsRowChangedEvent = this.tblAdminInspectionRequestsRowChangedEvent;
      if (requestsRowChangedEvent == null)
        return;
      requestsRowChangedEvent((object) this, new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEvent((dsAdminInspReq.tblAdminInspectionRequestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminInspectionRequestsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler rowChangingEvent = this.tblAdminInspectionRequestsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEvent((dsAdminInspReq.tblAdminInspectionRequestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminInspectionRequestsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler requestsRowDeletedEvent = this.tblAdminInspectionRequestsRowDeletedEvent;
      if (requestsRowDeletedEvent == null)
        return;
      requestsRowDeletedEvent((object) this, new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEvent((dsAdminInspReq.tblAdminInspectionRequestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminInspectionRequestsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblAdminInspectionRequestsRowChangeEventHandler rowDeletingEvent = this.tblAdminInspectionRequestsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.tblAdminInspectionRequestsRowChangeEvent((dsAdminInspReq.tblAdminInspectionRequestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblAdminInspectionRequestsRow(dsAdminInspReq.tblAdminInspectionRequestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblAdminInspectionRequestsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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

    private void tblAdminInspectionRequestsDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.InspectionContactPhoneColumn.ColumnName, false);
    }

    private void tblAdminInspectionRequestsDataTable_tblAdminInspectionRequestsRowChanging(
      object sender,
      dsAdminInspReq.tblAdminInspectionRequestsRowChangeEvent e)
    {
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblFin_ExpensePayeesDataTable : TypedTableBase<dsAdminInspReq.tblFin_ExpensePayeesRow>
  {
    private DataColumn columnPayeeID;
    private DataColumn columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_ExpensePayeesDataTable()
    {
      this.TableName = "tblFin_ExpensePayees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblFin_ExpensePayeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeIDColumn => this.columnPayeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblFin_ExpensePayeesRow this[int index]
    {
      get => (dsAdminInspReq.tblFin_ExpensePayeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblFin_ExpensePayeesRow(dsAdminInspReq.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblFin_ExpensePayeesRow AddtblFin_ExpensePayeesRow(string PayeeName)
    {
      dsAdminInspReq.tblFin_ExpensePayeesRow row = (dsAdminInspReq.tblFin_ExpensePayeesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) PayeeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblFin_ExpensePayeesRow FindByPayeeID(int PayeeID)
    {
      return (dsAdminInspReq.tblFin_ExpensePayeesRow) this.Rows.Find(new object[1]
      {
        (object) PayeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.tblFin_ExpensePayeesDataTable expensePayeesDataTable = (dsAdminInspReq.tblFin_ExpensePayeesDataTable) base.Clone();
      expensePayeesDataTable.InitVars();
      return (DataTable) expensePayeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.tblFin_ExpensePayeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPayeeID = this.Columns["PayeeID"];
      this.columnPayeeName = this.Columns["PayeeName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPayeeID = new DataColumn("PayeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeID);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPayeeID
      }, true));
      this.columnPayeeID.AutoIncrement = true;
      this.columnPayeeID.AutoIncrementSeed = -1L;
      this.columnPayeeID.AutoIncrementStep = -1L;
      this.columnPayeeID.AllowDBNull = false;
      this.columnPayeeID.ReadOnly = true;
      this.columnPayeeID.Unique = true;
      this.columnPayeeName.AllowDBNull = false;
      this.columnPayeeName.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblFin_ExpensePayeesRow NewtblFin_ExpensePayeesRow()
    {
      return (dsAdminInspReq.tblFin_ExpensePayeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.tblFin_ExpensePayeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.tblFin_ExpensePayeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler payeesRowChangedEvent = this.tblFin_ExpensePayeesRowChangedEvent;
      if (payeesRowChangedEvent == null)
        return;
      payeesRowChangedEvent((object) this, new dsAdminInspReq.tblFin_ExpensePayeesRowChangeEvent((dsAdminInspReq.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler rowChangingEvent = this.tblFin_ExpensePayeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.tblFin_ExpensePayeesRowChangeEvent((dsAdminInspReq.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler payeesRowDeletedEvent = this.tblFin_ExpensePayeesRowDeletedEvent;
      if (payeesRowDeletedEvent == null)
        return;
      payeesRowDeletedEvent((object) this, new dsAdminInspReq.tblFin_ExpensePayeesRowChangeEvent((dsAdminInspReq.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.tblFin_ExpensePayeesRowChangeEventHandler rowDeletingEvent = this.tblFin_ExpensePayeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.tblFin_ExpensePayeesRowChangeEvent((dsAdminInspReq.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblFin_ExpensePayeesRow(dsAdminInspReq.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_ExpensePayeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class lstAdminInspectionStatusDataTable : 
    TypedTableBase<dsAdminInspReq.lstAdminInspectionStatusRow>
  {
    private DataColumn columnID;
    private DataColumn columnInspectionStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdminInspectionStatusDataTable()
    {
      this.TableName = "lstAdminInspectionStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdminInspectionStatusDataTable(DataTable table)
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
    protected lstAdminInspectionStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionStatusColumn => this.columnInspectionStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionStatusRow this[int index]
    {
      get => (dsAdminInspReq.lstAdminInspectionStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler lstAdminInspectionStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler lstAdminInspectionStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler lstAdminInspectionStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler lstAdminInspectionStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstAdminInspectionStatusRow(dsAdminInspReq.lstAdminInspectionStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionStatusRow AddlstAdminInspectionStatusRow(
      string InspectionStatus)
    {
      dsAdminInspReq.lstAdminInspectionStatusRow row = (dsAdminInspReq.lstAdminInspectionStatusRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) InspectionStatus
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionStatusRow FindByID(int ID)
    {
      return (dsAdminInspReq.lstAdminInspectionStatusRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.lstAdminInspectionStatusDataTable inspectionStatusDataTable = (dsAdminInspReq.lstAdminInspectionStatusDataTable) base.Clone();
      inspectionStatusDataTable.InitVars();
      return (DataTable) inspectionStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.lstAdminInspectionStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnInspectionStatus = this.Columns["InspectionStatus"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnInspectionStatus = new DataColumn("InspectionStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionStatus);
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
      this.columnInspectionStatus.AllowDBNull = false;
      this.columnInspectionStatus.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionStatusRow NewlstAdminInspectionStatusRow()
    {
      return (dsAdminInspReq.lstAdminInspectionStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.lstAdminInspectionStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.lstAdminInspectionStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler statusRowChangedEvent = this.lstAdminInspectionStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsAdminInspReq.lstAdminInspectionStatusRowChangeEvent((dsAdminInspReq.lstAdminInspectionStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler rowChangingEvent = this.lstAdminInspectionStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.lstAdminInspectionStatusRowChangeEvent((dsAdminInspReq.lstAdminInspectionStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler statusRowDeletedEvent = this.lstAdminInspectionStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsAdminInspReq.lstAdminInspectionStatusRowChangeEvent((dsAdminInspReq.lstAdminInspectionStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionStatusRowChangeEventHandler rowDeletingEvent = this.lstAdminInspectionStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.lstAdminInspectionStatusRowChangeEvent((dsAdminInspReq.lstAdminInspectionStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstAdminInspectionStatusRow(dsAdminInspReq.lstAdminInspectionStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAdminInspectionStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class dtFilterDateDataTable : TypedTableBase<dsAdminInspReq.dtFilterDateRow>
  {
    private DataColumn columnDateID;
    private DataColumn columnDateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtFilterDateDataTable()
    {
      this.TableName = "dtFilterDate";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtFilterDateDataTable(DataTable table)
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
    protected dtFilterDateDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateIDColumn => this.columnDateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateNameColumn => this.columnDateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtFilterDateRow this[int index]
    {
      get => (dsAdminInspReq.dtFilterDateRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtFilterDateRowChangeEventHandler dtFilterDateRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtFilterDateRowChangeEventHandler dtFilterDateRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtFilterDateRowChangeEventHandler dtFilterDateRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtFilterDateRowChangeEventHandler dtFilterDateRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtFilterDateRow(dsAdminInspReq.dtFilterDateRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtFilterDateRow AdddtFilterDateRow(int DateID, string DateName)
    {
      dsAdminInspReq.dtFilterDateRow row = (dsAdminInspReq.dtFilterDateRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) DateID,
        (object) DateName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtFilterDateRow FindByDateID(int DateID)
    {
      return (dsAdminInspReq.dtFilterDateRow) this.Rows.Find(new object[1]
      {
        (object) DateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.dtFilterDateDataTable filterDateDataTable = (dsAdminInspReq.dtFilterDateDataTable) base.Clone();
      filterDateDataTable.InitVars();
      return (DataTable) filterDateDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.dtFilterDateDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDateID = this.Columns["DateID"];
      this.columnDateName = this.Columns["DateName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDateID = new DataColumn("DateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateID);
      this.columnDateName = new DataColumn("DateName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDateID
      }, true));
      this.columnDateID.AllowDBNull = false;
      this.columnDateID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtFilterDateRow NewdtFilterDateRow()
    {
      return (dsAdminInspReq.dtFilterDateRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.dtFilterDateRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.dtFilterDateRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtFilterDateRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtFilterDateRowChangeEventHandler dateRowChangedEvent = this.dtFilterDateRowChangedEvent;
      if (dateRowChangedEvent == null)
        return;
      dateRowChangedEvent((object) this, new dsAdminInspReq.dtFilterDateRowChangeEvent((dsAdminInspReq.dtFilterDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtFilterDateRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtFilterDateRowChangeEventHandler rowChangingEvent = this.dtFilterDateRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.dtFilterDateRowChangeEvent((dsAdminInspReq.dtFilterDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtFilterDateRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtFilterDateRowChangeEventHandler dateRowDeletedEvent = this.dtFilterDateRowDeletedEvent;
      if (dateRowDeletedEvent == null)
        return;
      dateRowDeletedEvent((object) this, new dsAdminInspReq.dtFilterDateRowChangeEvent((dsAdminInspReq.dtFilterDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtFilterDateRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtFilterDateRowChangeEventHandler rowDeletingEvent = this.dtFilterDateRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.dtFilterDateRowChangeEvent((dsAdminInspReq.dtFilterDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtFilterDateRow(dsAdminInspReq.dtFilterDateRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtFilterDateDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class dtLoggingDataTable : TypedTableBase<dsAdminInspReq.dtLoggingRow>
  {
    private DataColumn columnUserName;
    private DataColumn columnAction;
    private DataColumn columnActionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtLoggingDataTable()
    {
      this.TableName = "dtLogging";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtLoggingDataTable(DataTable table)
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
    protected dtLoggingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ActionColumn => this.columnAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ActionDateColumn => this.columnActionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtLoggingRow this[int index]
    {
      get => (dsAdminInspReq.dtLoggingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtLoggingRowChangeEventHandler dtLoggingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtLoggingRowChangeEventHandler dtLoggingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtLoggingRowChangeEventHandler dtLoggingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtLoggingRowChangeEventHandler dtLoggingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtLoggingRow(dsAdminInspReq.dtLoggingRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtLoggingRow AdddtLoggingRow(
      string UserName,
      string Action,
      DateTime ActionDate)
    {
      dsAdminInspReq.dtLoggingRow row = (dsAdminInspReq.dtLoggingRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) UserName,
        (object) Action,
        (object) ActionDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.dtLoggingDataTable loggingDataTable = (dsAdminInspReq.dtLoggingDataTable) base.Clone();
      loggingDataTable.InitVars();
      return (DataTable) loggingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.dtLoggingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserName = this.Columns["UserName"];
      this.columnAction = this.Columns["Action"];
      this.columnActionDate = this.Columns["ActionDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnAction = new DataColumn("Action", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAction);
      this.columnActionDate = new DataColumn("ActionDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActionDate);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtLoggingRow NewdtLoggingRow()
    {
      return (dsAdminInspReq.dtLoggingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.dtLoggingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.dtLoggingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLoggingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtLoggingRowChangeEventHandler loggingRowChangedEvent = this.dtLoggingRowChangedEvent;
      if (loggingRowChangedEvent == null)
        return;
      loggingRowChangedEvent((object) this, new dsAdminInspReq.dtLoggingRowChangeEvent((dsAdminInspReq.dtLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLoggingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtLoggingRowChangeEventHandler rowChangingEvent = this.dtLoggingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.dtLoggingRowChangeEvent((dsAdminInspReq.dtLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLoggingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtLoggingRowChangeEventHandler loggingRowDeletedEvent = this.dtLoggingRowDeletedEvent;
      if (loggingRowDeletedEvent == null)
        return;
      loggingRowDeletedEvent((object) this, new dsAdminInspReq.dtLoggingRowChangeEvent((dsAdminInspReq.dtLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLoggingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtLoggingRowChangeEventHandler rowDeletingEvent = this.dtLoggingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.dtLoggingRowChangeEvent((dsAdminInspReq.dtLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtLoggingRow(dsAdminInspReq.dtLoggingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtLoggingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class dtReportDataTable : TypedTableBase<dsAdminInspReq.dtReportRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnInsured;
    private DataColumn columnInspectionCompany;
    private DataColumn columnInspectionContact;
    private DataColumn columnInspectionContactPhone;
    private DataColumn columnAddress1;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtReportDataTable()
    {
      this.TableName = "dtReport";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtReportDataTable(DataTable table)
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
    protected dtReportDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionCompanyColumn => this.columnInspectionCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactColumn => this.columnInspectionContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactPhoneColumn => this.columnInspectionContactPhone;

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
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportRow this[int index]
    {
      get => (dsAdminInspReq.dtReportRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportRowChangeEventHandler dtReportRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportRowChangeEventHandler dtReportRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportRowChangeEventHandler dtReportRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportRowChangeEventHandler dtReportRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtReportRow(dsAdminInspReq.dtReportRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportRow AdddtReportRow(
      int ControlNo,
      string Insured,
      string InspectionCompany,
      string InspectionContact,
      string InspectionContactPhone,
      string Address1,
      string City,
      string State,
      string Zip)
    {
      dsAdminInspReq.dtReportRow row = (dsAdminInspReq.dtReportRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) ControlNo,
        (object) Insured,
        (object) InspectionCompany,
        (object) InspectionContact,
        (object) InspectionContactPhone,
        (object) Address1,
        (object) City,
        (object) State,
        (object) Zip
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.dtReportDataTable dtReportDataTable = (dsAdminInspReq.dtReportDataTable) base.Clone();
      dtReportDataTable.InitVars();
      return (DataTable) dtReportDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.dtReportDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnInsured = this.Columns["Insured"];
      this.columnInspectionCompany = this.Columns["InspectionCompany"];
      this.columnInspectionContact = this.Columns["InspectionContact"];
      this.columnInspectionContactPhone = this.Columns["InspectionContactPhone"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnInspectionCompany = new DataColumn("InspectionCompany", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionCompany);
      this.columnInspectionContact = new DataColumn("InspectionContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContact);
      this.columnInspectionContactPhone = new DataColumn("InspectionContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContactPhone);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnControlNo.AllowDBNull = false;
      this.columnInsured.AllowDBNull = false;
      this.columnInsured.MaxLength = 800;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportRow NewdtReportRow()
    {
      return (dsAdminInspReq.dtReportRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.dtReportRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.dtReportRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportRowChangeEventHandler reportRowChangedEvent = this.dtReportRowChangedEvent;
      if (reportRowChangedEvent == null)
        return;
      reportRowChangedEvent((object) this, new dsAdminInspReq.dtReportRowChangeEvent((dsAdminInspReq.dtReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportRowChangeEventHandler rowChangingEvent = this.dtReportRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.dtReportRowChangeEvent((dsAdminInspReq.dtReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportRowChangeEventHandler reportRowDeletedEvent = this.dtReportRowDeletedEvent;
      if (reportRowDeletedEvent == null)
        return;
      reportRowDeletedEvent((object) this, new dsAdminInspReq.dtReportRowChangeEvent((dsAdminInspReq.dtReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportRowChangeEventHandler rowDeletingEvent = this.dtReportRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.dtReportRowChangeEvent((dsAdminInspReq.dtReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtReportRow(dsAdminInspReq.dtReportRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtReportDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class dtReportGenericDataTable : TypedTableBase<dsAdminInspReq.dtReportGenericRow>
  {
    private DataColumn columnID;
    private DataColumn columnRevisedContactInfo;
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnLOB;
    private DataColumn columnLocationNumber;
    private DataColumn columnLocationAddress;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnInspectionCompany;
    private DataColumn columnInspectionContact;
    private DataColumn columnInspectionContactPhone;
    private DataColumn columnUnderwriter;
    private DataColumn columnEffectiveDate;
    private DataColumn columnOrderDate;
    private DataColumn columnDropDeadDate;
    private DataColumn columnReceivedDate;
    private DataColumn columnInspectionStatus;
    private DataColumn columnReceived;
    private DataColumn columnOrderedBy;
    private DataColumn columnInspectionType;
    private DataColumn columnLocationID;
    private DataColumn columnFollowupDate;
    private DataColumn columnOnEndorsement;
    private DataColumn columnPolicyType;
    private DataColumn columnInsuredID;
    private DataColumn columnPolicyStatus;
    private DataColumn columnClosed;
    private DataColumn columnClosedDate;
    private DataColumn columnCriticalOutstanding;
    private DataColumn columnCriticalWaived;
    private DataColumn columnCriticalComplete;
    private DataColumn columnCriticalTotal;
    private DataColumn columnNonCriticalOutstanding;
    private DataColumn columnNonCriticalWaived;
    private DataColumn columnNonCriticalComplete;
    private DataColumn columnNonCriticalTotal;
    private DataColumn columnRecStatus;
    private DataColumn columnRecSent;
    private DataColumn columnRecsFollowUp;
    private DataColumn columnRecsCompleted;
    private DataColumn columnCPR;
    private DataColumn columnMap;
    private DataColumn columnSprinklerTest;
    private DataColumn columnThermo;
    private DataColumn columnFirePump;
    private DataColumn columnFocusAccount;
    private DataColumn columnCriticalAccount;
    private DataColumn columnLastAssessmentDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtReportGenericDataTable()
    {
      this.TableName = "dtReportGeneric";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtReportGenericDataTable(DataTable table)
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
    protected dtReportGenericDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RevisedContactInfoColumn => this.columnRevisedContactInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNumberColumn => this.columnLocationNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationAddressColumn => this.columnLocationAddress;

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
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionCompanyColumn => this.columnInspectionCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactColumn => this.columnInspectionContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactPhoneColumn => this.columnInspectionContactPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OrderDateColumn => this.columnOrderDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DropDeadDateColumn => this.columnDropDeadDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReceivedDateColumn => this.columnReceivedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionStatusColumn => this.columnInspectionStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReceivedColumn => this.columnReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OrderedByColumn => this.columnOrderedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionTypeColumn => this.columnInspectionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FollowupDateColumn => this.columnFollowupDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OnEndorsementColumn => this.columnOnEndorsement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredIDColumn => this.columnInsuredID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyStatusColumn => this.columnPolicyStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClosedColumn => this.columnClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClosedDateColumn => this.columnClosedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalOutstandingColumn => this.columnCriticalOutstanding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalWaivedColumn => this.columnCriticalWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalCompleteColumn => this.columnCriticalComplete;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalTotalColumn => this.columnCriticalTotal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalOutstandingColumn => this.columnNonCriticalOutstanding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalWaivedColumn => this.columnNonCriticalWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalCompleteColumn => this.columnNonCriticalComplete;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonCriticalTotalColumn => this.columnNonCriticalTotal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecStatusColumn => this.columnRecStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecSentColumn => this.columnRecSent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecsFollowUpColumn => this.columnRecsFollowUp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecsCompletedColumn => this.columnRecsCompleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CPRColumn => this.columnCPR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MapColumn => this.columnMap;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SprinklerTestColumn => this.columnSprinklerTest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ThermoColumn => this.columnThermo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirePumpColumn => this.columnFirePump;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FocusAccountColumn => this.columnFocusAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CriticalAccountColumn => this.columnCriticalAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastAssessmentDateColumn => this.columnLastAssessmentDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportGenericRow this[int index]
    {
      get => (dsAdminInspReq.dtReportGenericRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportGenericRowChangeEventHandler dtReportGenericRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportGenericRowChangeEventHandler dtReportGenericRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportGenericRowChangeEventHandler dtReportGenericRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtReportGenericRowChangeEventHandler dtReportGenericRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtReportGenericRow(dsAdminInspReq.dtReportGenericRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportGenericRow AdddtReportGenericRow(
      Decimal ID,
      bool RevisedContactInfo,
      int ControlNo,
      string PolicyNumber,
      string Insured,
      string LOB,
      string LocationNumber,
      string LocationAddress,
      string Address1,
      string Address2,
      string City,
      string State,
      string Zip,
      string InspectionCompany,
      string InspectionContact,
      string InspectionContactPhone,
      string Underwriter,
      DateTime EffectiveDate,
      DateTime OrderDate,
      DateTime DropDeadDate,
      string ReceivedDate,
      string InspectionStatus,
      string Received,
      string OrderedBy,
      string InspectionType,
      int LocationID,
      DateTime FollowupDate,
      bool OnEndorsement,
      string PolicyType,
      int InsuredID,
      string PolicyStatus,
      bool Closed,
      DateTime ClosedDate,
      string CriticalOutstanding,
      string CriticalWaived,
      string CriticalComplete,
      string CriticalTotal,
      string NonCriticalOutstanding,
      string NonCriticalWaived,
      string NonCriticalComplete,
      string NonCriticalTotal,
      string RecStatus,
      DateTime RecSent,
      DateTime RecsFollowUp,
      DateTime RecsCompleted,
      DateTime CPR,
      DateTime Map,
      DateTime SprinklerTest,
      DateTime Thermo,
      DateTime FirePump,
      bool FocusAccount,
      bool CriticalAccount,
      DateTime LastAssessmentDate)
    {
      dsAdminInspReq.dtReportGenericRow row = (dsAdminInspReq.dtReportGenericRow) this.NewRow();
      object[] objArray = new object[53]
      {
        (object) ID,
        (object) RevisedContactInfo,
        (object) ControlNo,
        (object) PolicyNumber,
        (object) Insured,
        (object) LOB,
        (object) LocationNumber,
        (object) LocationAddress,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) InspectionCompany,
        (object) InspectionContact,
        (object) InspectionContactPhone,
        (object) Underwriter,
        (object) EffectiveDate,
        (object) OrderDate,
        (object) DropDeadDate,
        (object) ReceivedDate,
        (object) InspectionStatus,
        (object) Received,
        (object) OrderedBy,
        (object) InspectionType,
        (object) LocationID,
        (object) FollowupDate,
        (object) OnEndorsement,
        (object) PolicyType,
        (object) InsuredID,
        (object) PolicyStatus,
        (object) Closed,
        (object) ClosedDate,
        (object) CriticalOutstanding,
        (object) CriticalWaived,
        (object) CriticalComplete,
        (object) CriticalTotal,
        (object) NonCriticalOutstanding,
        (object) NonCriticalWaived,
        (object) NonCriticalComplete,
        (object) NonCriticalTotal,
        (object) RecStatus,
        (object) RecSent,
        (object) RecsFollowUp,
        (object) RecsCompleted,
        (object) CPR,
        (object) Map,
        (object) SprinklerTest,
        (object) Thermo,
        (object) FirePump,
        (object) FocusAccount,
        (object) CriticalAccount,
        (object) LastAssessmentDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.dtReportGenericDataTable genericDataTable = (dsAdminInspReq.dtReportGenericDataTable) base.Clone();
      genericDataTable.InitVars();
      return (DataTable) genericDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.dtReportGenericDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnRevisedContactInfo = this.Columns["RevisedContactInfo"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnLOB = this.Columns["LOB"];
      this.columnLocationNumber = this.Columns["LocationNumber"];
      this.columnLocationAddress = this.Columns["LocationAddress"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnInspectionCompany = this.Columns["InspectionCompany"];
      this.columnInspectionContact = this.Columns["InspectionContact"];
      this.columnInspectionContactPhone = this.Columns["InspectionContactPhone"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnOrderDate = this.Columns["OrderDate"];
      this.columnDropDeadDate = this.Columns["DropDeadDate"];
      this.columnReceivedDate = this.Columns["ReceivedDate"];
      this.columnInspectionStatus = this.Columns["InspectionStatus"];
      this.columnReceived = this.Columns["Received"];
      this.columnOrderedBy = this.Columns["OrderedBy"];
      this.columnInspectionType = this.Columns["InspectionType"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnFollowupDate = this.Columns["FollowupDate"];
      this.columnOnEndorsement = this.Columns["OnEndorsement"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnInsuredID = this.Columns["InsuredID"];
      this.columnPolicyStatus = this.Columns["PolicyStatus"];
      this.columnClosed = this.Columns["Closed"];
      this.columnClosedDate = this.Columns["ClosedDate"];
      this.columnCriticalOutstanding = this.Columns["CriticalOutstanding"];
      this.columnCriticalWaived = this.Columns["CriticalWaived"];
      this.columnCriticalComplete = this.Columns["CriticalComplete"];
      this.columnCriticalTotal = this.Columns["CriticalTotal"];
      this.columnNonCriticalOutstanding = this.Columns["NonCriticalOutstanding"];
      this.columnNonCriticalWaived = this.Columns["NonCriticalWaived"];
      this.columnNonCriticalComplete = this.Columns["NonCriticalComplete"];
      this.columnNonCriticalTotal = this.Columns["NonCriticalTotal"];
      this.columnRecStatus = this.Columns["RecStatus"];
      this.columnRecSent = this.Columns["RecSent"];
      this.columnRecsFollowUp = this.Columns["RecsFollowUp"];
      this.columnRecsCompleted = this.Columns["RecsCompleted"];
      this.columnCPR = this.Columns["CPR"];
      this.columnMap = this.Columns["Map"];
      this.columnSprinklerTest = this.Columns["SprinklerTest"];
      this.columnThermo = this.Columns["Thermo"];
      this.columnFirePump = this.Columns["FirePump"];
      this.columnFocusAccount = this.Columns["FocusAccount"];
      this.columnCriticalAccount = this.Columns["CriticalAccount"];
      this.columnLastAssessmentDate = this.Columns["LastAssessmentDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnRevisedContactInfo = new DataColumn("RevisedContactInfo", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRevisedContactInfo);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnLocationNumber = new DataColumn("LocationNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNumber);
      this.columnLocationAddress = new DataColumn("LocationAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationAddress);
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
      this.columnInspectionCompany = new DataColumn("InspectionCompany", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionCompany);
      this.columnInspectionContact = new DataColumn("InspectionContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContact);
      this.columnInspectionContactPhone = new DataColumn("InspectionContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContactPhone);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnOrderDate = new DataColumn("OrderDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOrderDate);
      this.columnDropDeadDate = new DataColumn("DropDeadDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDropDeadDate);
      this.columnReceivedDate = new DataColumn("ReceivedDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceivedDate);
      this.columnInspectionStatus = new DataColumn("InspectionStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionStatus);
      this.columnReceived = new DataColumn("Received", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceived);
      this.columnOrderedBy = new DataColumn("OrderedBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOrderedBy);
      this.columnInspectionType = new DataColumn("InspectionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionType);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnFollowupDate = new DataColumn("FollowupDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFollowupDate);
      this.columnOnEndorsement = new DataColumn("OnEndorsement", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnEndorsement);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnInsuredID = new DataColumn("InsuredID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredID);
      this.columnPolicyStatus = new DataColumn("PolicyStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyStatus);
      this.columnClosed = new DataColumn("Closed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosed);
      this.columnClosedDate = new DataColumn("ClosedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosedDate);
      this.columnCriticalOutstanding = new DataColumn("CriticalOutstanding", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalOutstanding);
      this.columnCriticalWaived = new DataColumn("CriticalWaived", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalWaived);
      this.columnCriticalComplete = new DataColumn("CriticalComplete", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalComplete);
      this.columnCriticalTotal = new DataColumn("CriticalTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalTotal);
      this.columnNonCriticalOutstanding = new DataColumn("NonCriticalOutstanding", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalOutstanding);
      this.columnNonCriticalWaived = new DataColumn("NonCriticalWaived", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalWaived);
      this.columnNonCriticalComplete = new DataColumn("NonCriticalComplete", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalComplete);
      this.columnNonCriticalTotal = new DataColumn("NonCriticalTotal", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonCriticalTotal);
      this.columnRecStatus = new DataColumn("RecStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecStatus);
      this.columnRecSent = new DataColumn("RecSent", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecSent);
      this.columnRecsFollowUp = new DataColumn("RecsFollowUp", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecsFollowUp);
      this.columnRecsCompleted = new DataColumn("RecsCompleted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecsCompleted);
      this.columnCPR = new DataColumn("CPR", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCPR);
      this.columnMap = new DataColumn("Map", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMap);
      this.columnSprinklerTest = new DataColumn("SprinklerTest", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSprinklerTest);
      this.columnThermo = new DataColumn("Thermo", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnThermo);
      this.columnFirePump = new DataColumn("FirePump", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirePump);
      this.columnFocusAccount = new DataColumn("FocusAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFocusAccount);
      this.columnCriticalAccount = new DataColumn("CriticalAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCriticalAccount);
      this.columnLastAssessmentDate = new DataColumn("LastAssessmentDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastAssessmentDate);
      this.columnControlNo.AllowDBNull = false;
      this.columnPolicyNumber.AllowDBNull = false;
      this.columnPolicyNumber.MaxLength = 50;
      this.columnInsured.AllowDBNull = false;
      this.columnInsured.MaxLength = 800;
      this.columnLocationAddress.AllowDBNull = false;
      this.columnLocationAddress.MaxLength = 800;
      this.columnInspectionCompany.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportGenericRow NewdtReportGenericRow()
    {
      return (dsAdminInspReq.dtReportGenericRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.dtReportGenericRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.dtReportGenericRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportGenericRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportGenericRowChangeEventHandler genericRowChangedEvent = this.dtReportGenericRowChangedEvent;
      if (genericRowChangedEvent == null)
        return;
      genericRowChangedEvent((object) this, new dsAdminInspReq.dtReportGenericRowChangeEvent((dsAdminInspReq.dtReportGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportGenericRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportGenericRowChangeEventHandler rowChangingEvent = this.dtReportGenericRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.dtReportGenericRowChangeEvent((dsAdminInspReq.dtReportGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportGenericRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportGenericRowChangeEventHandler genericRowDeletedEvent = this.dtReportGenericRowDeletedEvent;
      if (genericRowDeletedEvent == null)
        return;
      genericRowDeletedEvent((object) this, new dsAdminInspReq.dtReportGenericRowChangeEvent((dsAdminInspReq.dtReportGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportGenericRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtReportGenericRowChangeEventHandler rowDeletingEvent = this.dtReportGenericRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.dtReportGenericRowChangeEvent((dsAdminInspReq.dtReportGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtReportGenericRow(dsAdminInspReq.dtReportGenericRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtReportGenericDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class dtColumnsDataTable : TypedTableBase<dsAdminInspReq.dtColumnsRow>
  {
    private DataColumn columnColumnName;
    private DataColumn columnSelectColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtColumnsDataTable()
    {
      this.TableName = "dtColumns";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtColumnsDataTable(DataTable table)
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
    protected dtColumnsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ColumnNameColumn => this.columnColumnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SelectColumnColumn => this.columnSelectColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtColumnsRow this[int index]
    {
      get => (dsAdminInspReq.dtColumnsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtColumnsRowChangeEventHandler dtColumnsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtColumnsRowChangeEventHandler dtColumnsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtColumnsRowChangeEventHandler dtColumnsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.dtColumnsRowChangeEventHandler dtColumnsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtColumnsRow(dsAdminInspReq.dtColumnsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtColumnsRow AdddtColumnsRow(string ColumnName, bool SelectColumn)
    {
      dsAdminInspReq.dtColumnsRow row = (dsAdminInspReq.dtColumnsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ColumnName,
        (object) SelectColumn
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtColumnsRow FindByColumnName(string ColumnName)
    {
      return (dsAdminInspReq.dtColumnsRow) this.Rows.Find(new object[1]
      {
        (object) ColumnName
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.dtColumnsDataTable columnsDataTable = (dsAdminInspReq.dtColumnsDataTable) base.Clone();
      columnsDataTable.InitVars();
      return (DataTable) columnsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.dtColumnsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnColumnName = this.Columns["ColumnName"];
      this.columnSelectColumn = this.Columns["SelectColumn"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnColumnName = new DataColumn("ColumnName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnColumnName);
      this.columnSelectColumn = new DataColumn("SelectColumn", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelectColumn);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnColumnName
      }, true));
      this.columnColumnName.AllowDBNull = false;
      this.columnColumnName.Unique = true;
      this.columnSelectColumn.DefaultValue = (object) true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtColumnsRow NewdtColumnsRow()
    {
      return (dsAdminInspReq.dtColumnsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.dtColumnsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.dtColumnsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtColumnsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtColumnsRowChangeEventHandler columnsRowChangedEvent = this.dtColumnsRowChangedEvent;
      if (columnsRowChangedEvent == null)
        return;
      columnsRowChangedEvent((object) this, new dsAdminInspReq.dtColumnsRowChangeEvent((dsAdminInspReq.dtColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtColumnsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtColumnsRowChangeEventHandler rowChangingEvent = this.dtColumnsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.dtColumnsRowChangeEvent((dsAdminInspReq.dtColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtColumnsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtColumnsRowChangeEventHandler columnsRowDeletedEvent = this.dtColumnsRowDeletedEvent;
      if (columnsRowDeletedEvent == null)
        return;
      columnsRowDeletedEvent((object) this, new dsAdminInspReq.dtColumnsRowChangeEvent((dsAdminInspReq.dtColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtColumnsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.dtColumnsRowChangeEventHandler rowDeletingEvent = this.dtColumnsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.dtColumnsRowChangeEvent((dsAdminInspReq.dtColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtColumnsRow(dsAdminInspReq.dtColumnsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtColumnsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class lstInspectionsAdminRecStatusDataTable : 
    TypedTableBase<dsAdminInspReq.lstInspectionsAdminRecStatusRow>
  {
    private DataColumn columnID;
    private DataColumn columnRecStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstInspectionsAdminRecStatusDataTable()
    {
      this.TableName = "lstInspectionsAdminRecStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstInspectionsAdminRecStatusDataTable(DataTable table)
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
    protected lstInspectionsAdminRecStatusDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecStatusColumn => this.columnRecStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstInspectionsAdminRecStatusRow this[int index]
    {
      get => (dsAdminInspReq.lstInspectionsAdminRecStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler lstInspectionsAdminRecStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler lstInspectionsAdminRecStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler lstInspectionsAdminRecStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler lstInspectionsAdminRecStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstInspectionsAdminRecStatusRow(
      dsAdminInspReq.lstInspectionsAdminRecStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstInspectionsAdminRecStatusRow AddlstInspectionsAdminRecStatusRow(
      string RecStatus)
    {
      dsAdminInspReq.lstInspectionsAdminRecStatusRow row = (dsAdminInspReq.lstInspectionsAdminRecStatusRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) RecStatus
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstInspectionsAdminRecStatusRow FindByID(int ID)
    {
      return (dsAdminInspReq.lstInspectionsAdminRecStatusRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.lstInspectionsAdminRecStatusDataTable recStatusDataTable = (dsAdminInspReq.lstInspectionsAdminRecStatusDataTable) base.Clone();
      recStatusDataTable.InitVars();
      return (DataTable) recStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.lstInspectionsAdminRecStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnRecStatus = this.Columns["RecStatus"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnRecStatus = new DataColumn("RecStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecStatus);
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
      this.columnRecStatus.AllowDBNull = false;
      this.columnRecStatus.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstInspectionsAdminRecStatusRow NewlstInspectionsAdminRecStatusRow()
    {
      return (dsAdminInspReq.lstInspectionsAdminRecStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.lstInspectionsAdminRecStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.lstInspectionsAdminRecStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInspectionsAdminRecStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler statusRowChangedEvent = this.lstInspectionsAdminRecStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEvent((dsAdminInspReq.lstInspectionsAdminRecStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInspectionsAdminRecStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler rowChangingEvent = this.lstInspectionsAdminRecStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEvent((dsAdminInspReq.lstInspectionsAdminRecStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInspectionsAdminRecStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler statusRowDeletedEvent = this.lstInspectionsAdminRecStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEvent((dsAdminInspReq.lstInspectionsAdminRecStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInspectionsAdminRecStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEventHandler rowDeletingEvent = this.lstInspectionsAdminRecStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.lstInspectionsAdminRecStatusRowChangeEvent((dsAdminInspReq.lstInspectionsAdminRecStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstInspectionsAdminRecStatusRow(
      dsAdminInspReq.lstInspectionsAdminRecStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstInspectionsAdminRecStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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
  public class lstAdminInspectionTypesDataTable : 
    TypedTableBase<dsAdminInspReq.lstAdminInspectionTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnInspectionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdminInspectionTypesDataTable()
    {
      this.TableName = "lstAdminInspectionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdminInspectionTypesDataTable(DataTable table)
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
    protected lstAdminInspectionTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionTypeColumn => this.columnInspectionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionTypesRow this[int index]
    {
      get => (dsAdminInspReq.lstAdminInspectionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler lstAdminInspectionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler lstAdminInspectionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler lstAdminInspectionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler lstAdminInspectionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstAdminInspectionTypesRow(dsAdminInspReq.lstAdminInspectionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionTypesRow AddlstAdminInspectionTypesRow(
      string InspectionType)
    {
      dsAdminInspReq.lstAdminInspectionTypesRow row = (dsAdminInspReq.lstAdminInspectionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) InspectionType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionTypesRow FindByID(int ID)
    {
      return (dsAdminInspReq.lstAdminInspectionTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminInspReq.lstAdminInspectionTypesDataTable inspectionTypesDataTable = (dsAdminInspReq.lstAdminInspectionTypesDataTable) base.Clone();
      inspectionTypesDataTable.InitVars();
      return (DataTable) inspectionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminInspReq.lstAdminInspectionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnInspectionType = this.Columns["InspectionType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnInspectionType = new DataColumn("InspectionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionType);
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
      this.columnInspectionType.AllowDBNull = false;
      this.columnInspectionType.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionTypesRow NewlstAdminInspectionTypesRow()
    {
      return (dsAdminInspReq.lstAdminInspectionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminInspReq.lstAdminInspectionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminInspReq.lstAdminInspectionTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler typesRowChangedEvent = this.lstAdminInspectionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAdminInspReq.lstAdminInspectionTypesRowChangeEvent((dsAdminInspReq.lstAdminInspectionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler rowChangingEvent = this.lstAdminInspectionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminInspReq.lstAdminInspectionTypesRowChangeEvent((dsAdminInspReq.lstAdminInspectionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler typesRowDeletedEvent = this.lstAdminInspectionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAdminInspReq.lstAdminInspectionTypesRowChangeEvent((dsAdminInspReq.lstAdminInspectionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdminInspectionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminInspReq.lstAdminInspectionTypesRowChangeEventHandler rowDeletingEvent = this.lstAdminInspectionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminInspReq.lstAdminInspectionTypesRowChangeEvent((dsAdminInspReq.lstAdminInspectionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstAdminInspectionTypesRow(dsAdminInspReq.lstAdminInspectionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminInspReq dsAdminInspReq = new dsAdminInspReq();
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
        FixedValue = dsAdminInspReq.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAdminInspectionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminInspReq.GetSchemaSerializable();
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

  public class tblAdminInspectionRequestsRow : DataRow
  {
    private dsAdminInspReq.tblAdminInspectionRequestsDataTable tabletblAdminInspectionRequests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblAdminInspectionRequestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblAdminInspectionRequests = (dsAdminInspReq.tblAdminInspectionRequestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tabletblAdminInspectionRequests.IDColumn]);
      set => this[this.tabletblAdminInspectionRequests.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FollowUp
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.FollowUpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FollowUp' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.FollowUpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ControlNo
    {
      get => Conversions.ToString(this[this.tabletblAdminInspectionRequests.ControlNoColumn]);
      set => this[this.tabletblAdminInspectionRequests.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get => Conversions.ToString(this[this.tabletblAdminInspectionRequests.PolicyNumberColumn]);
      set => this[this.tabletblAdminInspectionRequests.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Insured
    {
      get => Conversions.ToString(this[this.tabletblAdminInspectionRequests.InsuredColumn]);
      set => this[this.tabletblAdminInspectionRequests.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblAdminInspectionRequests.LocationIDColumn]);
      set => this[this.tabletblAdminInspectionRequests.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.LocationNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationNumber' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.LocationNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationAddress
    {
      get => Conversions.ToString(this[this.tabletblAdminInspectionRequests.LocationAddressColumn]);
      set => this[this.tabletblAdminInspectionRequests.LocationAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InspectionCompanyID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblAdminInspectionRequests.InspectionCompanyIDColumn]);
      }
      set => this[this.tabletblAdminInspectionRequests.InspectionCompanyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.InspectionContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContact' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.InspectionContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.InspectionContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContactPhone' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblAdminInspectionRequests.InspectionContactPhoneColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime OrderDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.OrderDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OrderDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.OrderDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DropDeadDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.DropDeadDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DropDeadDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.DropDeadDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime FollowupDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.FollowupDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FollowupDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.FollowupDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ReceivedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.ReceivedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReceivedDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.ReceivedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Received
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.ReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Received' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.ReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RevisedContactInfo
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.RevisedContactInfoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RevisedContactInfo' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RevisedContactInfoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InspectionStatus
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminInspectionRequests.InspectionStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionStatus' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.InspectionStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OrderedBy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.OrderedByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OrderedBy' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.OrderedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.InspTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspType' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.InspTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool OnEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.OnEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OnEndorsement' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.OnEndorsementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.PolicyTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyType' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InsuredID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminInspectionRequests.InsuredIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredID' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.InsuredIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.PolicyStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyStatus' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.PolicyStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Closed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.ClosedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Closed' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.ClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ClosedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.ClosedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClosedDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.ClosedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalOutstanding
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.CriticalOutstandingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalOutstanding' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CriticalOutstandingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalWaived
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.CriticalWaivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalWaived' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CriticalWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalComplete
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.CriticalCompleteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalComplete' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CriticalCompleteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.CriticalTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalTotal' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CriticalTotalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalOutstanding
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.NonCriticalOutstandingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalOutstanding' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblAdminInspectionRequests.NonCriticalOutstandingColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalWaived
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.NonCriticalWaivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalWaived' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.NonCriticalWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalComplete
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.NonCriticalCompleteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalComplete' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.NonCriticalCompleteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.NonCriticalTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalTotal' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.NonCriticalTotalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RecStatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminInspectionRequests.RecStatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecStatusID' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RecStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RecSent
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.RecSentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecSent' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RecSentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RecsFollowUp
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.RecsFollowUpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecsFollowUp' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RecsFollowUpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RecsCompleted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.RecsCompletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecsCompleted' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RecsCompletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Roof
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.RoofColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Roof' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RoofColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminInspectionRequests.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RecsReceived
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.RecsReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecsReceived' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.RecsReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime CPR
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.CPRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CPR' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CPRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Map
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.MapColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Map' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.MapColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime SprinklerTest
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.SprinklerTestColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SprinklerTest' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.SprinklerTestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Thermo
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.ThermoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Thermo' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.ThermoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime FirePump
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.FirePumpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirePump' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.FirePumpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FocusAccount
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.FocusAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FocusAccount' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.FocusAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CriticalAccount
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminInspectionRequests.CriticalAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalAccount' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.CriticalAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LastAssessmentDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminInspectionRequests.LastAssessmentDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastAssessmentDate' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.LastAssessmentDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InspectionTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminInspectionRequests.InspectionTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionTypeID' in table 'tblAdminInspectionRequests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminInspectionRequests.InspectionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFollowUpNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.FollowUpColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFollowUpNull()
    {
      this[this.tabletblAdminInspectionRequests.FollowUpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tabletblAdminInspectionRequests.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tabletblAdminInspectionRequests.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNumberNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.LocationNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNumberNull()
    {
      this[this.tabletblAdminInspectionRequests.LocationNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.Address1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblAdminInspectionRequests.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress2Null()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.Address2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblAdminInspectionRequests.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblAdminInspectionRequests.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblAdminInspectionRequests.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblAdminInspectionRequests.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblAdminInspectionRequests.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabletblAdminInspectionRequests.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabletblAdminInspectionRequests.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.InspectionContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactNull()
    {
      this[this.tabletblAdminInspectionRequests.InspectionContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactPhoneNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.InspectionContactPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactPhoneNull()
    {
      this[this.tabletblAdminInspectionRequests.InspectionContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUnderwriterNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.UnderwriterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tabletblAdminInspectionRequests.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblAdminInspectionRequests.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOrderDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.OrderDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOrderDateNull()
    {
      this[this.tabletblAdminInspectionRequests.OrderDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDropDeadDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.DropDeadDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDropDeadDateNull()
    {
      this[this.tabletblAdminInspectionRequests.DropDeadDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFollowupDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.FollowupDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFollowupDateNull()
    {
      this[this.tabletblAdminInspectionRequests.FollowupDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReceivedDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.ReceivedDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReceivedDateNull()
    {
      this[this.tabletblAdminInspectionRequests.ReceivedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReceivedNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.ReceivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReceivedNull()
    {
      this[this.tabletblAdminInspectionRequests.ReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRevisedContactInfoNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.RevisedContactInfoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRevisedContactInfoNull()
    {
      this[this.tabletblAdminInspectionRequests.RevisedContactInfoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionStatusNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.InspectionStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionStatusNull()
    {
      this[this.tabletblAdminInspectionRequests.InspectionStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOrderedByNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.OrderedByColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOrderedByNull()
    {
      this[this.tabletblAdminInspectionRequests.OrderedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspTypeNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.InspTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspTypeNull()
    {
      this[this.tabletblAdminInspectionRequests.InspTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOnEndorsementNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.OnEndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOnEndorsementNull()
    {
      this[this.tabletblAdminInspectionRequests.OnEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyTypeNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.PolicyTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyTypeNull()
    {
      this[this.tabletblAdminInspectionRequests.PolicyTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInsuredIDNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.InsuredIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInsuredIDNull()
    {
      this[this.tabletblAdminInspectionRequests.InsuredIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyStatusNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.PolicyStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyStatusNull()
    {
      this[this.tabletblAdminInspectionRequests.PolicyStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClosedNull() => this.IsNull(this.tabletblAdminInspectionRequests.ClosedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClosedNull()
    {
      this[this.tabletblAdminInspectionRequests.ClosedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClosedDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.ClosedDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClosedDateNull()
    {
      this[this.tabletblAdminInspectionRequests.ClosedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalOutstandingNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.CriticalOutstandingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalOutstandingNull()
    {
      this[this.tabletblAdminInspectionRequests.CriticalOutstandingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalWaivedNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.CriticalWaivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalWaivedNull()
    {
      this[this.tabletblAdminInspectionRequests.CriticalWaivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalCompleteNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.CriticalCompleteColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalCompleteNull()
    {
      this[this.tabletblAdminInspectionRequests.CriticalCompleteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalTotalNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.CriticalTotalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalTotalNull()
    {
      this[this.tabletblAdminInspectionRequests.CriticalTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalOutstandingNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.NonCriticalOutstandingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalOutstandingNull()
    {
      this[this.tabletblAdminInspectionRequests.NonCriticalOutstandingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalWaivedNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.NonCriticalWaivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalWaivedNull()
    {
      this[this.tabletblAdminInspectionRequests.NonCriticalWaivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalCompleteNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.NonCriticalCompleteColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalCompleteNull()
    {
      this[this.tabletblAdminInspectionRequests.NonCriticalCompleteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalTotalNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.NonCriticalTotalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalTotalNull()
    {
      this[this.tabletblAdminInspectionRequests.NonCriticalTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecStatusIDNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.RecStatusIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecStatusIDNull()
    {
      this[this.tabletblAdminInspectionRequests.RecStatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecSentNull() => this.IsNull(this.tabletblAdminInspectionRequests.RecSentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecSentNull()
    {
      this[this.tabletblAdminInspectionRequests.RecSentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecsFollowUpNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.RecsFollowUpColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecsFollowUpNull()
    {
      this[this.tabletblAdminInspectionRequests.RecsFollowUpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecsCompletedNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.RecsCompletedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecsCompletedNull()
    {
      this[this.tabletblAdminInspectionRequests.RecsCompletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoofNull() => this.IsNull(this.tabletblAdminInspectionRequests.RoofColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoofNull()
    {
      this[this.tabletblAdminInspectionRequests.RoofColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tabletblAdminInspectionRequests.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tabletblAdminInspectionRequests.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecsReceivedNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.RecsReceivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecsReceivedNull()
    {
      this[this.tabletblAdminInspectionRequests.RecsReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCPRNull() => this.IsNull(this.tabletblAdminInspectionRequests.CPRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCPRNull()
    {
      this[this.tabletblAdminInspectionRequests.CPRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMapNull() => this.IsNull(this.tabletblAdminInspectionRequests.MapColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMapNull()
    {
      this[this.tabletblAdminInspectionRequests.MapColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSprinklerTestNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.SprinklerTestColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSprinklerTestNull()
    {
      this[this.tabletblAdminInspectionRequests.SprinklerTestColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsThermoNull() => this.IsNull(this.tabletblAdminInspectionRequests.ThermoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetThermoNull()
    {
      this[this.tabletblAdminInspectionRequests.ThermoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirePumpNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.FirePumpColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirePumpNull()
    {
      this[this.tabletblAdminInspectionRequests.FirePumpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFocusAccountNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.FocusAccountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFocusAccountNull()
    {
      this[this.tabletblAdminInspectionRequests.FocusAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalAccountNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.CriticalAccountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalAccountNull()
    {
      this[this.tabletblAdminInspectionRequests.CriticalAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastAssessmentDateNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.LastAssessmentDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastAssessmentDateNull()
    {
      this[this.tabletblAdminInspectionRequests.LastAssessmentDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionTypeIDNull()
    {
      return this.IsNull(this.tabletblAdminInspectionRequests.InspectionTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionTypeIDNull()
    {
      this[this.tabletblAdminInspectionRequests.InspectionTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFin_ExpensePayeesRow : DataRow
  {
    private dsAdminInspReq.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFin_ExpensePayeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_ExpensePayees = (dsAdminInspReq.tblFin_ExpensePayeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PayeeID
    {
      get => Conversions.ToInteger(this[this.tabletblFin_ExpensePayees.PayeeIDColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayeeName
    {
      get => Conversions.ToString(this[this.tabletblFin_ExpensePayees.PayeeNameColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeNameColumn] = (object) value;
    }
  }

  public class lstAdminInspectionStatusRow : DataRow
  {
    private dsAdminInspReq.lstAdminInspectionStatusDataTable tablelstAdminInspectionStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdminInspectionStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAdminInspectionStatus = (dsAdminInspReq.lstAdminInspectionStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstAdminInspectionStatus.IDColumn]);
      set => this[this.tablelstAdminInspectionStatus.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionStatus
    {
      get => Conversions.ToString(this[this.tablelstAdminInspectionStatus.InspectionStatusColumn]);
      set => this[this.tablelstAdminInspectionStatus.InspectionStatusColumn] = (object) value;
    }
  }

  public class dtFilterDateRow : DataRow
  {
    private dsAdminInspReq.dtFilterDateDataTable tabledtFilterDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtFilterDateRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtFilterDate = (dsAdminInspReq.dtFilterDateDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DateID
    {
      get => Conversions.ToInteger(this[this.tabledtFilterDate.DateIDColumn]);
      set => this[this.tabledtFilterDate.DateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DateName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtFilterDate.DateNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateName' in table 'dtFilterDate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtFilterDate.DateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateNameNull() => this.IsNull(this.tabledtFilterDate.DateNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateNameNull()
    {
      this[this.tabledtFilterDate.DateNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtLoggingRow : DataRow
  {
    private dsAdminInspReq.dtLoggingDataTable tabledtLogging;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtLoggingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtLogging = (dsAdminInspReq.dtLoggingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLogging.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'dtLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLogging.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Action
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLogging.ActionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Action' in table 'dtLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLogging.ActionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ActionDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtLogging.ActionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ActionDate' in table 'dtLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLogging.ActionDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tabledtLogging.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tabledtLogging.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsActionNull() => this.IsNull(this.tabledtLogging.ActionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetActionNull()
    {
      this[this.tabledtLogging.ActionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsActionDateNull() => this.IsNull(this.tabledtLogging.ActionDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetActionDateNull()
    {
      this[this.tabledtLogging.ActionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtReportRow : DataRow
  {
    private dsAdminInspReq.dtReportDataTable tabledtReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtReportRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtReport = (dsAdminInspReq.dtReportDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabledtReport.ControlNoColumn]);
      set => this[this.tabledtReport.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Insured
    {
      get => Conversions.ToString(this[this.tabledtReport.InsuredColumn]);
      set => this[this.tabledtReport.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionCompany
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.InspectionCompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionCompany' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.InspectionCompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.InspectionContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContact' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.InspectionContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.InspectionContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContactPhone' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.InspectionContactPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReport.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'dtReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReport.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionCompanyNull()
    {
      return this.IsNull(this.tabledtReport.InspectionCompanyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionCompanyNull()
    {
      this[this.tabledtReport.InspectionCompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactNull()
    {
      return this.IsNull(this.tabledtReport.InspectionContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactNull()
    {
      this[this.tabledtReport.InspectionContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactPhoneNull()
    {
      return this.IsNull(this.tabledtReport.InspectionContactPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactPhoneNull()
    {
      this[this.tabledtReport.InspectionContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabledtReport.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabledtReport.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtReport.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtReport.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtReport.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabledtReport.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabledtReport.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabledtReport.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtReportGenericRow : DataRow
  {
    private dsAdminInspReq.dtReportGenericDataTable tabledtReportGeneric;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtReportGenericRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtReportGeneric = (dsAdminInspReq.dtReportGenericDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ID
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtReportGeneric.IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ID' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RevisedContactInfo
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtReportGeneric.RevisedContactInfoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RevisedContactInfo' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.RevisedContactInfoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabledtReportGeneric.ControlNoColumn]);
      set => this[this.tabledtReportGeneric.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get => Conversions.ToString(this[this.tabledtReportGeneric.PolicyNumberColumn]);
      set => this[this.tabledtReportGeneric.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Insured
    {
      get => Conversions.ToString(this[this.tabledtReportGeneric.InsuredColumn]);
      set => this[this.tabledtReportGeneric.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.LocationNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationNumber' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.LocationNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationAddress
    {
      get => Conversions.ToString(this[this.tabledtReportGeneric.LocationAddressColumn]);
      set => this[this.tabledtReportGeneric.LocationAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionCompany
    {
      get => Conversions.ToString(this[this.tabledtReportGeneric.InspectionCompanyColumn]);
      set => this[this.tabledtReportGeneric.InspectionCompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.InspectionContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContact' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.InspectionContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.InspectionContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContactPhone' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.InspectionContactPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime OrderDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.OrderDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OrderDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.OrderDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DropDeadDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.DropDeadDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DropDeadDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.DropDeadDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ReceivedDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.ReceivedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReceivedDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.ReceivedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.InspectionStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionStatus' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.InspectionStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Received
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.ReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Received' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.ReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OrderedBy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.OrderedByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OrderedBy' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.OrderedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.InspectionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionType' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.InspectionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtReportGeneric.LocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationID' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime FollowupDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.FollowupDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FollowupDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.FollowupDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool OnEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtReportGeneric.OnEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OnEndorsement' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.OnEndorsementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.PolicyTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyType' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InsuredID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtReportGeneric.InsuredIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredID' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.InsuredIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.PolicyStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyStatus' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.PolicyStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Closed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtReportGeneric.ClosedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Closed' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.ClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ClosedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.ClosedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClosedDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.ClosedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalOutstanding
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.CriticalOutstandingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalOutstanding' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CriticalOutstandingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalWaived
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.CriticalWaivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalWaived' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CriticalWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalComplete
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.CriticalCompleteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalComplete' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CriticalCompleteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CriticalTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.CriticalTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalTotal' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CriticalTotalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalOutstanding
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.NonCriticalOutstandingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalOutstanding' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.NonCriticalOutstandingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalWaived
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.NonCriticalWaivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalWaived' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.NonCriticalWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalComplete
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.NonCriticalCompleteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalComplete' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.NonCriticalCompleteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NonCriticalTotal
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.NonCriticalTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonCriticalTotal' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.NonCriticalTotalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RecStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReportGeneric.RecStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecStatus' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.RecStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RecSent
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.RecSentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecSent' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.RecSentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RecsFollowUp
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.RecsFollowUpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecsFollowUp' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.RecsFollowUpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RecsCompleted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.RecsCompletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecsCompleted' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.RecsCompletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime CPR
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.CPRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CPR' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CPRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Map
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.MapColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Map' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.MapColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime SprinklerTest
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.SprinklerTestColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SprinklerTest' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.SprinklerTestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Thermo
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.ThermoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Thermo' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.ThermoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime FirePump
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.FirePumpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirePump' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.FirePumpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FocusAccount
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtReportGeneric.FocusAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FocusAccount' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.FocusAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CriticalAccount
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtReportGeneric.CriticalAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CriticalAccount' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.CriticalAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LastAssessmentDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtReportGeneric.LastAssessmentDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastAssessmentDate' in table 'dtReportGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReportGeneric.LastAssessmentDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIDNull() => this.IsNull(this.tabledtReportGeneric.IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIDNull()
    {
      this[this.tabledtReportGeneric.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRevisedContactInfoNull()
    {
      return this.IsNull(this.tabledtReportGeneric.RevisedContactInfoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRevisedContactInfoNull()
    {
      this[this.tabledtReportGeneric.RevisedContactInfoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tabledtReportGeneric.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tabledtReportGeneric.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNumberNull()
    {
      return this.IsNull(this.tabledtReportGeneric.LocationNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNumberNull()
    {
      this[this.tabledtReportGeneric.LocationNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabledtReportGeneric.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabledtReportGeneric.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabledtReportGeneric.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabledtReportGeneric.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtReportGeneric.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtReportGeneric.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtReportGeneric.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabledtReportGeneric.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabledtReportGeneric.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabledtReportGeneric.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactNull()
    {
      return this.IsNull(this.tabledtReportGeneric.InspectionContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactNull()
    {
      this[this.tabledtReportGeneric.InspectionContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactPhoneNull()
    {
      return this.IsNull(this.tabledtReportGeneric.InspectionContactPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactPhoneNull()
    {
      this[this.tabledtReportGeneric.InspectionContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUnderwriterNull() => this.IsNull(this.tabledtReportGeneric.UnderwriterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tabledtReportGeneric.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tabledtReportGeneric.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabledtReportGeneric.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOrderDateNull() => this.IsNull(this.tabledtReportGeneric.OrderDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOrderDateNull()
    {
      this[this.tabledtReportGeneric.OrderDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDropDeadDateNull() => this.IsNull(this.tabledtReportGeneric.DropDeadDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDropDeadDateNull()
    {
      this[this.tabledtReportGeneric.DropDeadDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReceivedDateNull() => this.IsNull(this.tabledtReportGeneric.ReceivedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReceivedDateNull()
    {
      this[this.tabledtReportGeneric.ReceivedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionStatusNull()
    {
      return this.IsNull(this.tabledtReportGeneric.InspectionStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionStatusNull()
    {
      this[this.tabledtReportGeneric.InspectionStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReceivedNull() => this.IsNull(this.tabledtReportGeneric.ReceivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReceivedNull()
    {
      this[this.tabledtReportGeneric.ReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOrderedByNull() => this.IsNull(this.tabledtReportGeneric.OrderedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOrderedByNull()
    {
      this[this.tabledtReportGeneric.OrderedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionTypeNull()
    {
      return this.IsNull(this.tabledtReportGeneric.InspectionTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionTypeNull()
    {
      this[this.tabledtReportGeneric.InspectionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationIDNull() => this.IsNull(this.tabledtReportGeneric.LocationIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationIDNull()
    {
      this[this.tabledtReportGeneric.LocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFollowupDateNull() => this.IsNull(this.tabledtReportGeneric.FollowupDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFollowupDateNull()
    {
      this[this.tabledtReportGeneric.FollowupDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOnEndorsementNull() => this.IsNull(this.tabledtReportGeneric.OnEndorsementColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOnEndorsementNull()
    {
      this[this.tabledtReportGeneric.OnEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyTypeNull() => this.IsNull(this.tabledtReportGeneric.PolicyTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyTypeNull()
    {
      this[this.tabledtReportGeneric.PolicyTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInsuredIDNull() => this.IsNull(this.tabledtReportGeneric.InsuredIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInsuredIDNull()
    {
      this[this.tabledtReportGeneric.InsuredIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyStatusNull() => this.IsNull(this.tabledtReportGeneric.PolicyStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyStatusNull()
    {
      this[this.tabledtReportGeneric.PolicyStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClosedNull() => this.IsNull(this.tabledtReportGeneric.ClosedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClosedNull()
    {
      this[this.tabledtReportGeneric.ClosedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClosedDateNull() => this.IsNull(this.tabledtReportGeneric.ClosedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClosedDateNull()
    {
      this[this.tabledtReportGeneric.ClosedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalOutstandingNull()
    {
      return this.IsNull(this.tabledtReportGeneric.CriticalOutstandingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalOutstandingNull()
    {
      this[this.tabledtReportGeneric.CriticalOutstandingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalWaivedNull()
    {
      return this.IsNull(this.tabledtReportGeneric.CriticalWaivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalWaivedNull()
    {
      this[this.tabledtReportGeneric.CriticalWaivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalCompleteNull()
    {
      return this.IsNull(this.tabledtReportGeneric.CriticalCompleteColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalCompleteNull()
    {
      this[this.tabledtReportGeneric.CriticalCompleteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalTotalNull() => this.IsNull(this.tabledtReportGeneric.CriticalTotalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalTotalNull()
    {
      this[this.tabledtReportGeneric.CriticalTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalOutstandingNull()
    {
      return this.IsNull(this.tabledtReportGeneric.NonCriticalOutstandingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalOutstandingNull()
    {
      this[this.tabledtReportGeneric.NonCriticalOutstandingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalWaivedNull()
    {
      return this.IsNull(this.tabledtReportGeneric.NonCriticalWaivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalWaivedNull()
    {
      this[this.tabledtReportGeneric.NonCriticalWaivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalCompleteNull()
    {
      return this.IsNull(this.tabledtReportGeneric.NonCriticalCompleteColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalCompleteNull()
    {
      this[this.tabledtReportGeneric.NonCriticalCompleteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonCriticalTotalNull()
    {
      return this.IsNull(this.tabledtReportGeneric.NonCriticalTotalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonCriticalTotalNull()
    {
      this[this.tabledtReportGeneric.NonCriticalTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecStatusNull() => this.IsNull(this.tabledtReportGeneric.RecStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecStatusNull()
    {
      this[this.tabledtReportGeneric.RecStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecSentNull() => this.IsNull(this.tabledtReportGeneric.RecSentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecSentNull()
    {
      this[this.tabledtReportGeneric.RecSentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecsFollowUpNull() => this.IsNull(this.tabledtReportGeneric.RecsFollowUpColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecsFollowUpNull()
    {
      this[this.tabledtReportGeneric.RecsFollowUpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecsCompletedNull() => this.IsNull(this.tabledtReportGeneric.RecsCompletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecsCompletedNull()
    {
      this[this.tabledtReportGeneric.RecsCompletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCPRNull() => this.IsNull(this.tabledtReportGeneric.CPRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCPRNull()
    {
      this[this.tabledtReportGeneric.CPRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMapNull() => this.IsNull(this.tabledtReportGeneric.MapColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMapNull()
    {
      this[this.tabledtReportGeneric.MapColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSprinklerTestNull() => this.IsNull(this.tabledtReportGeneric.SprinklerTestColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSprinklerTestNull()
    {
      this[this.tabledtReportGeneric.SprinklerTestColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsThermoNull() => this.IsNull(this.tabledtReportGeneric.ThermoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetThermoNull()
    {
      this[this.tabledtReportGeneric.ThermoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirePumpNull() => this.IsNull(this.tabledtReportGeneric.FirePumpColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirePumpNull()
    {
      this[this.tabledtReportGeneric.FirePumpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFocusAccountNull() => this.IsNull(this.tabledtReportGeneric.FocusAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFocusAccountNull()
    {
      this[this.tabledtReportGeneric.FocusAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCriticalAccountNull()
    {
      return this.IsNull(this.tabledtReportGeneric.CriticalAccountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCriticalAccountNull()
    {
      this[this.tabledtReportGeneric.CriticalAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastAssessmentDateNull()
    {
      return this.IsNull(this.tabledtReportGeneric.LastAssessmentDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastAssessmentDateNull()
    {
      this[this.tabledtReportGeneric.LastAssessmentDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtColumnsRow : DataRow
  {
    private dsAdminInspReq.dtColumnsDataTable tabledtColumns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtColumnsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtColumns = (dsAdminInspReq.dtColumnsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ColumnName
    {
      get => Conversions.ToString(this[this.tabledtColumns.ColumnNameColumn]);
      set => this[this.tabledtColumns.ColumnNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SelectColumn
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtColumns.SelectColumnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SelectColumn' in table 'dtColumns' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtColumns.SelectColumnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSelectColumnNull() => this.IsNull(this.tabledtColumns.SelectColumnColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSelectColumnNull()
    {
      this[this.tabledtColumns.SelectColumnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstInspectionsAdminRecStatusRow : DataRow
  {
    private dsAdminInspReq.lstInspectionsAdminRecStatusDataTable tablelstInspectionsAdminRecStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstInspectionsAdminRecStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstInspectionsAdminRecStatus = (dsAdminInspReq.lstInspectionsAdminRecStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstInspectionsAdminRecStatus.IDColumn]);
      set => this[this.tablelstInspectionsAdminRecStatus.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RecStatus
    {
      get => Conversions.ToString(this[this.tablelstInspectionsAdminRecStatus.RecStatusColumn]);
      set => this[this.tablelstInspectionsAdminRecStatus.RecStatusColumn] = (object) value;
    }
  }

  public class lstAdminInspectionTypesRow : DataRow
  {
    private dsAdminInspReq.lstAdminInspectionTypesDataTable tablelstAdminInspectionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdminInspectionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAdminInspectionTypes = (dsAdminInspReq.lstAdminInspectionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstAdminInspectionTypes.IDColumn]);
      set => this[this.tablelstAdminInspectionTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionType
    {
      get => Conversions.ToString(this[this.tablelstAdminInspectionTypes.InspectionTypeColumn]);
      set => this[this.tablelstAdminInspectionTypes.InspectionTypeColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblAdminInspectionRequestsRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.tblAdminInspectionRequestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblAdminInspectionRequestsRowChangeEvent(
      dsAdminInspReq.tblAdminInspectionRequestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblAdminInspectionRequestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblFin_ExpensePayeesRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.tblFin_ExpensePayeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_ExpensePayeesRowChangeEvent(
      dsAdminInspReq.tblFin_ExpensePayeesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.tblFin_ExpensePayeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstAdminInspectionStatusRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.lstAdminInspectionStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdminInspectionStatusRowChangeEvent(
      dsAdminInspReq.lstAdminInspectionStatusRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtFilterDateRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.dtFilterDateRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtFilterDateRowChangeEvent(dsAdminInspReq.dtFilterDateRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtFilterDateRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtLoggingRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.dtLoggingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtLoggingRowChangeEvent(dsAdminInspReq.dtLoggingRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtLoggingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtReportRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.dtReportRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtReportRowChangeEvent(dsAdminInspReq.dtReportRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtReportGenericRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.dtReportGenericRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtReportGenericRowChangeEvent(
      dsAdminInspReq.dtReportGenericRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtReportGenericRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtColumnsRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.dtColumnsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtColumnsRowChangeEvent(dsAdminInspReq.dtColumnsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.dtColumnsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstInspectionsAdminRecStatusRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.lstInspectionsAdminRecStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstInspectionsAdminRecStatusRowChangeEvent(
      dsAdminInspReq.lstInspectionsAdminRecStatusRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstInspectionsAdminRecStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstAdminInspectionTypesRowChangeEvent : EventArgs
  {
    private dsAdminInspReq.lstAdminInspectionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdminInspectionTypesRowChangeEvent(
      dsAdminInspReq.lstAdminInspectionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminInspReq.lstAdminInspectionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
