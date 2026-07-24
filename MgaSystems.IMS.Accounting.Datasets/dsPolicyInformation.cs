// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPolicyInformation
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

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
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyInformation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyInformation : DataSet
{
  private dsPolicyInformation.PolicyHeaderDataTable tablePolicyHeader;
  private dsPolicyInformation.PolicyStatusChangesDataTable tablePolicyStatusChanges;
  private dsPolicyInformation.PolicyInvoicesDataTable tablePolicyInvoices;
  private dsPolicyInformation.InvoiceActivityDataTable tableInvoiceActivity;
  private dsPolicyInformation.InvoiceDetailDataTable tableInvoiceDetail;
  private dsPolicyInformation.InvoicePremiumLinesDataTable tableInvoicePremiumLines;
  private dsPolicyInformation.InvoiceFeeLinesDataTable tableInvoiceFeeLines;
  private dsPolicyInformation.CancellationInformationDataTable tableCancellationInformation;
  private dsPolicyInformation.PolicyInquiryCommentsDataTable tablePolicyInquiryComments;
  private dsPolicyInformation.ReinstatementInformationDataTable tableReinstatementInformation;
  private dsPolicyInformation.PolicyActivityDataTable tablePolicyActivity;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsPolicyInformation()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsPolicyInformation(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (PolicyHeader)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.PolicyHeaderDataTable(dataSet.Tables[nameof (PolicyHeader)]));
        if (dataSet.Tables[nameof (PolicyStatusChanges)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.PolicyStatusChangesDataTable(dataSet.Tables[nameof (PolicyStatusChanges)]));
        if (dataSet.Tables[nameof (PolicyInvoices)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.PolicyInvoicesDataTable(dataSet.Tables[nameof (PolicyInvoices)]));
        if (dataSet.Tables[nameof (InvoiceActivity)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.InvoiceActivityDataTable(dataSet.Tables[nameof (InvoiceActivity)]));
        if (dataSet.Tables[nameof (InvoiceDetail)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.InvoiceDetailDataTable(dataSet.Tables[nameof (InvoiceDetail)]));
        if (dataSet.Tables[nameof (InvoicePremiumLines)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.InvoicePremiumLinesDataTable(dataSet.Tables[nameof (InvoicePremiumLines)]));
        if (dataSet.Tables[nameof (InvoiceFeeLines)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.InvoiceFeeLinesDataTable(dataSet.Tables[nameof (InvoiceFeeLines)]));
        if (dataSet.Tables[nameof (CancellationInformation)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.CancellationInformationDataTable(dataSet.Tables[nameof (CancellationInformation)]));
        if (dataSet.Tables[nameof (PolicyInquiryComments)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.PolicyInquiryCommentsDataTable(dataSet.Tables[nameof (PolicyInquiryComments)]));
        if (dataSet.Tables[nameof (ReinstatementInformation)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.ReinstatementInformationDataTable(dataSet.Tables[nameof (ReinstatementInformation)]));
        if (dataSet.Tables[nameof (PolicyActivity)] != null)
          base.Tables.Add((DataTable) new dsPolicyInformation.PolicyActivityDataTable(dataSet.Tables[nameof (PolicyActivity)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.PolicyHeaderDataTable PolicyHeader => this.tablePolicyHeader;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.PolicyStatusChangesDataTable PolicyStatusChanges
  {
    get => this.tablePolicyStatusChanges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.PolicyInvoicesDataTable PolicyInvoices => this.tablePolicyInvoices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.InvoiceActivityDataTable InvoiceActivity => this.tableInvoiceActivity;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.InvoiceDetailDataTable InvoiceDetail => this.tableInvoiceDetail;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.InvoicePremiumLinesDataTable InvoicePremiumLines
  {
    get => this.tableInvoicePremiumLines;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.InvoiceFeeLinesDataTable InvoiceFeeLines => this.tableInvoiceFeeLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.CancellationInformationDataTable CancellationInformation
  {
    get => this.tableCancellationInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.PolicyInquiryCommentsDataTable PolicyInquiryComments
  {
    get => this.tablePolicyInquiryComments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.ReinstatementInformationDataTable ReinstatementInformation
  {
    get => this.tableReinstatementInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInformation.PolicyActivityDataTable PolicyActivity => this.tablePolicyActivity;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsPolicyInformation policyInformation = (dsPolicyInformation) base.Clone();
    policyInformation.InitVars();
    policyInformation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) policyInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["PolicyHeader"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.PolicyHeaderDataTable(dataSet.Tables["PolicyHeader"]));
      if (dataSet.Tables["PolicyStatusChanges"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.PolicyStatusChangesDataTable(dataSet.Tables["PolicyStatusChanges"]));
      if (dataSet.Tables["PolicyInvoices"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.PolicyInvoicesDataTable(dataSet.Tables["PolicyInvoices"]));
      if (dataSet.Tables["InvoiceActivity"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.InvoiceActivityDataTable(dataSet.Tables["InvoiceActivity"]));
      if (dataSet.Tables["InvoiceDetail"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.InvoiceDetailDataTable(dataSet.Tables["InvoiceDetail"]));
      if (dataSet.Tables["InvoicePremiumLines"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.InvoicePremiumLinesDataTable(dataSet.Tables["InvoicePremiumLines"]));
      if (dataSet.Tables["InvoiceFeeLines"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.InvoiceFeeLinesDataTable(dataSet.Tables["InvoiceFeeLines"]));
      if (dataSet.Tables["CancellationInformation"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.CancellationInformationDataTable(dataSet.Tables["CancellationInformation"]));
      if (dataSet.Tables["PolicyInquiryComments"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.PolicyInquiryCommentsDataTable(dataSet.Tables["PolicyInquiryComments"]));
      if (dataSet.Tables["ReinstatementInformation"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.ReinstatementInformationDataTable(dataSet.Tables["ReinstatementInformation"]));
      if (dataSet.Tables["PolicyActivity"] != null)
        base.Tables.Add((DataTable) new dsPolicyInformation.PolicyActivityDataTable(dataSet.Tables["PolicyActivity"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tablePolicyHeader = (dsPolicyInformation.PolicyHeaderDataTable) base.Tables["PolicyHeader"];
    if (initTable && this.tablePolicyHeader != null)
      this.tablePolicyHeader.InitVars();
    this.tablePolicyStatusChanges = (dsPolicyInformation.PolicyStatusChangesDataTable) base.Tables["PolicyStatusChanges"];
    if (initTable && this.tablePolicyStatusChanges != null)
      this.tablePolicyStatusChanges.InitVars();
    this.tablePolicyInvoices = (dsPolicyInformation.PolicyInvoicesDataTable) base.Tables["PolicyInvoices"];
    if (initTable && this.tablePolicyInvoices != null)
      this.tablePolicyInvoices.InitVars();
    this.tableInvoiceActivity = (dsPolicyInformation.InvoiceActivityDataTable) base.Tables["InvoiceActivity"];
    if (initTable && this.tableInvoiceActivity != null)
      this.tableInvoiceActivity.InitVars();
    this.tableInvoiceDetail = (dsPolicyInformation.InvoiceDetailDataTable) base.Tables["InvoiceDetail"];
    if (initTable && this.tableInvoiceDetail != null)
      this.tableInvoiceDetail.InitVars();
    this.tableInvoicePremiumLines = (dsPolicyInformation.InvoicePremiumLinesDataTable) base.Tables["InvoicePremiumLines"];
    if (initTable && this.tableInvoicePremiumLines != null)
      this.tableInvoicePremiumLines.InitVars();
    this.tableInvoiceFeeLines = (dsPolicyInformation.InvoiceFeeLinesDataTable) base.Tables["InvoiceFeeLines"];
    if (initTable && this.tableInvoiceFeeLines != null)
      this.tableInvoiceFeeLines.InitVars();
    this.tableCancellationInformation = (dsPolicyInformation.CancellationInformationDataTable) base.Tables["CancellationInformation"];
    if (initTable && this.tableCancellationInformation != null)
      this.tableCancellationInformation.InitVars();
    this.tablePolicyInquiryComments = (dsPolicyInformation.PolicyInquiryCommentsDataTable) base.Tables["PolicyInquiryComments"];
    if (initTable && this.tablePolicyInquiryComments != null)
      this.tablePolicyInquiryComments.InitVars();
    this.tableReinstatementInformation = (dsPolicyInformation.ReinstatementInformationDataTable) base.Tables["ReinstatementInformation"];
    if (initTable && this.tableReinstatementInformation != null)
      this.tableReinstatementInformation.InitVars();
    this.tablePolicyActivity = (dsPolicyInformation.PolicyActivityDataTable) base.Tables["PolicyActivity"];
    if (!initTable || this.tablePolicyActivity == null)
      return;
    this.tablePolicyActivity.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyInformation);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPolicyInformation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePolicyHeader = new dsPolicyInformation.PolicyHeaderDataTable();
    base.Tables.Add((DataTable) this.tablePolicyHeader);
    this.tablePolicyStatusChanges = new dsPolicyInformation.PolicyStatusChangesDataTable();
    base.Tables.Add((DataTable) this.tablePolicyStatusChanges);
    this.tablePolicyInvoices = new dsPolicyInformation.PolicyInvoicesDataTable();
    base.Tables.Add((DataTable) this.tablePolicyInvoices);
    this.tableInvoiceActivity = new dsPolicyInformation.InvoiceActivityDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceActivity);
    this.tableInvoiceDetail = new dsPolicyInformation.InvoiceDetailDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceDetail);
    this.tableInvoicePremiumLines = new dsPolicyInformation.InvoicePremiumLinesDataTable();
    base.Tables.Add((DataTable) this.tableInvoicePremiumLines);
    this.tableInvoiceFeeLines = new dsPolicyInformation.InvoiceFeeLinesDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceFeeLines);
    this.tableCancellationInformation = new dsPolicyInformation.CancellationInformationDataTable();
    base.Tables.Add((DataTable) this.tableCancellationInformation);
    this.tablePolicyInquiryComments = new dsPolicyInformation.PolicyInquiryCommentsDataTable();
    base.Tables.Add((DataTable) this.tablePolicyInquiryComments);
    this.tableReinstatementInformation = new dsPolicyInformation.ReinstatementInformationDataTable();
    base.Tables.Add((DataTable) this.tableReinstatementInformation);
    this.tablePolicyActivity = new dsPolicyInformation.PolicyActivityDataTable();
    base.Tables.Add((DataTable) this.tablePolicyActivity);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePolicyHeader() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePolicyStatusChanges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePolicyInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeInvoiceActivity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeInvoiceDetail() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeInvoicePremiumLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeInvoiceFeeLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeCancellationInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePolicyInquiryComments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeReinstatementInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePolicyActivity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsPolicyInformation policyInformation = new dsPolicyInformation();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = policyInformation.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PolicyHeaderRowChangeEventHandler(
    object sender,
    dsPolicyInformation.PolicyHeaderRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PolicyStatusChangesRowChangeEventHandler(
    object sender,
    dsPolicyInformation.PolicyStatusChangesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PolicyInvoicesRowChangeEventHandler(
    object sender,
    dsPolicyInformation.PolicyInvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void InvoiceActivityRowChangeEventHandler(
    object sender,
    dsPolicyInformation.InvoiceActivityRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void InvoiceDetailRowChangeEventHandler(
    object sender,
    dsPolicyInformation.InvoiceDetailRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void InvoicePremiumLinesRowChangeEventHandler(
    object sender,
    dsPolicyInformation.InvoicePremiumLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void InvoiceFeeLinesRowChangeEventHandler(
    object sender,
    dsPolicyInformation.InvoiceFeeLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void CancellationInformationRowChangeEventHandler(
    object sender,
    dsPolicyInformation.CancellationInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PolicyInquiryCommentsRowChangeEventHandler(
    object sender,
    dsPolicyInformation.PolicyInquiryCommentsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void ReinstatementInformationRowChangeEventHandler(
    object sender,
    dsPolicyInformation.ReinstatementInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PolicyActivityRowChangeEventHandler(
    object sender,
    dsPolicyInformation.PolicyActivityRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PolicyHeaderDataTable : TypedTableBase<dsPolicyInformation.PolicyHeaderRow>
  {
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnProducer;
    private DataColumn columnCompany;
    private DataColumn columnUnderwriter;
    private DataColumn columnControlNumber;
    private DataColumn columnIsNocDisabled;
    private DataColumn columnCostCenter;
    private DataColumn columnBillingType;
    private DataColumn columnFinanceCompanyGuid;
    private DataColumn columnFinanceCompanyName;
    private DataColumn columnFinanceCompanyAccountNumber;
    private DataColumn columnCurrencyCode;
    private DataColumn columnOfficeLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyHeaderDataTable()
    {
      this.TableName = "PolicyHeader";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyHeaderDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PolicyHeaderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ControlNumberColumn => this.columnControlNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IsNocDisabledColumn => this.columnIsNocDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CostCenterColumn => this.columnCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FinanceCompanyGuidColumn => this.columnFinanceCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FinanceCompanyNameColumn => this.columnFinanceCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FinanceCompanyAccountNumberColumn => this.columnFinanceCompanyAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CurrencyCodeColumn => this.columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OfficeLocationColumn => this.columnOfficeLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyHeaderRow this[int index]
    {
      get => (dsPolicyInformation.PolicyHeaderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyHeaderRowChangeEventHandler PolicyHeaderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyHeaderRowChangeEventHandler PolicyHeaderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyHeaderRowChangeEventHandler PolicyHeaderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyHeaderRowChangeEventHandler PolicyHeaderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPolicyHeaderRow(dsPolicyInformation.PolicyHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyHeaderRow AddPolicyHeaderRow(
      string PolicyNumber,
      string Insured,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      string Producer,
      string Company,
      string Underwriter,
      int ControlNumber,
      bool IsNocDisabled,
      string CostCenter,
      string BillingType,
      Guid FinanceCompanyGuid,
      string FinanceCompanyName,
      string FinanceCompanyAccountNumber,
      string CurrencyCode,
      string OfficeLocation)
    {
      dsPolicyInformation.PolicyHeaderRow row = (dsPolicyInformation.PolicyHeaderRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) PolicyNumber,
        (object) Insured,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) Producer,
        (object) Company,
        (object) Underwriter,
        (object) ControlNumber,
        (object) IsNocDisabled,
        (object) CostCenter,
        (object) BillingType,
        (object) FinanceCompanyGuid,
        (object) FinanceCompanyName,
        (object) FinanceCompanyAccountNumber,
        (object) CurrencyCode,
        (object) OfficeLocation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.PolicyHeaderDataTable policyHeaderDataTable = (dsPolicyInformation.PolicyHeaderDataTable) base.Clone();
      policyHeaderDataTable.InitVars();
      return (DataTable) policyHeaderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.PolicyHeaderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnProducer = this.Columns["Producer"];
      this.columnCompany = this.Columns["Company"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnControlNumber = this.Columns["ControlNumber"];
      this.columnIsNocDisabled = this.Columns["IsNocDisabled"];
      this.columnCostCenter = this.Columns["CostCenter"];
      this.columnBillingType = this.Columns["BillingType"];
      this.columnFinanceCompanyGuid = this.Columns["FinanceCompanyGuid"];
      this.columnFinanceCompanyName = this.Columns["FinanceCompanyName"];
      this.columnFinanceCompanyAccountNumber = this.Columns["FinanceCompanyAccountNumber"];
      this.columnCurrencyCode = this.Columns["CurrencyCode"];
      this.columnOfficeLocation = this.Columns["OfficeLocation"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnControlNumber = new DataColumn("ControlNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNumber);
      this.columnIsNocDisabled = new DataColumn("IsNocDisabled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsNocDisabled);
      this.columnCostCenter = new DataColumn("CostCenter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenter);
      this.columnBillingType = new DataColumn("BillingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingType);
      this.columnFinanceCompanyGuid = new DataColumn("FinanceCompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFinanceCompanyGuid);
      this.columnFinanceCompanyName = new DataColumn("FinanceCompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFinanceCompanyName);
      this.columnFinanceCompanyAccountNumber = new DataColumn("FinanceCompanyAccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFinanceCompanyAccountNumber);
      this.columnCurrencyCode = new DataColumn("CurrencyCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode);
      this.columnOfficeLocation = new DataColumn("OfficeLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeLocation);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyHeaderRow NewPolicyHeaderRow()
    {
      return (dsPolicyInformation.PolicyHeaderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.PolicyHeaderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.PolicyHeaderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyHeaderRowChangeEventHandler headerRowChangedEvent = this.PolicyHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsPolicyInformation.PolicyHeaderRowChangeEvent((dsPolicyInformation.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyHeaderRowChangeEventHandler rowChangingEvent = this.PolicyHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.PolicyHeaderRowChangeEvent((dsPolicyInformation.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyHeaderRowChangeEventHandler headerRowDeletedEvent = this.PolicyHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsPolicyInformation.PolicyHeaderRowChangeEvent((dsPolicyInformation.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyHeaderRowChangeEventHandler rowDeletingEvent = this.PolicyHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.PolicyHeaderRowChangeEvent((dsPolicyInformation.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePolicyHeaderRow(dsPolicyInformation.PolicyHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyHeaderDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class PolicyStatusChangesDataTable : 
    TypedTableBase<dsPolicyInformation.PolicyStatusChangesRow>
  {
    private DataColumn columnStatus;
    private DataColumn columnReason;
    private DataColumn columnDateChanged;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyStatusChangesDataTable()
    {
      this.TableName = "PolicyStatusChanges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyStatusChangesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PolicyStatusChangesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateChangedColumn => this.columnDateChanged;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyStatusChangesRow this[int index]
    {
      get => (dsPolicyInformation.PolicyStatusChangesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler PolicyStatusChangesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler PolicyStatusChangesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler PolicyStatusChangesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler PolicyStatusChangesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPolicyStatusChangesRow(dsPolicyInformation.PolicyStatusChangesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyStatusChangesRow AddPolicyStatusChangesRow(
      string Status,
      string Reason,
      DateTime DateChanged)
    {
      dsPolicyInformation.PolicyStatusChangesRow row = (dsPolicyInformation.PolicyStatusChangesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Status,
        (object) Reason,
        (object) DateChanged
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.PolicyStatusChangesDataTable changesDataTable = (dsPolicyInformation.PolicyStatusChangesDataTable) base.Clone();
      changesDataTable.InitVars();
      return (DataTable) changesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.PolicyStatusChangesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnStatus = this.Columns["Status"];
      this.columnReason = this.Columns["Reason"];
      this.columnDateChanged = this.Columns["DateChanged"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.columnDateChanged = new DataColumn("DateChanged", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateChanged);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyStatusChangesRow NewPolicyStatusChangesRow()
    {
      return (dsPolicyInformation.PolicyStatusChangesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.PolicyStatusChangesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.PolicyStatusChangesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyStatusChangesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler changesRowChangedEvent = this.PolicyStatusChangesRowChangedEvent;
      if (changesRowChangedEvent == null)
        return;
      changesRowChangedEvent((object) this, new dsPolicyInformation.PolicyStatusChangesRowChangeEvent((dsPolicyInformation.PolicyStatusChangesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyStatusChangesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler rowChangingEvent = this.PolicyStatusChangesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.PolicyStatusChangesRowChangeEvent((dsPolicyInformation.PolicyStatusChangesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyStatusChangesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler changesRowDeletedEvent = this.PolicyStatusChangesRowDeletedEvent;
      if (changesRowDeletedEvent == null)
        return;
      changesRowDeletedEvent((object) this, new dsPolicyInformation.PolicyStatusChangesRowChangeEvent((dsPolicyInformation.PolicyStatusChangesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyStatusChangesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyStatusChangesRowChangeEventHandler rowDeletingEvent = this.PolicyStatusChangesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.PolicyStatusChangesRowChangeEvent((dsPolicyInformation.PolicyStatusChangesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePolicyStatusChangesRow(dsPolicyInformation.PolicyStatusChangesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyStatusChangesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class PolicyInvoicesDataTable : TypedTableBase<dsPolicyInformation.PolicyInvoicesRow>
  {
    private DataColumn columninvoiceNum;
    private DataColumn columnofficeInvoiceNum;
    private DataColumn columnquoteId;
    private DataColumn columnGrossBilled;
    private DataColumn columnCommission;
    private DataColumn columnPremium;
    private DataColumn columnFees;
    private DataColumn columnAPBalance;
    private DataColumn columnARBalance;
    private DataColumn columnDueDate;
    private DataColumn columnunderNotice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyInvoicesDataTable()
    {
      this.TableName = "PolicyInvoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyInvoicesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PolicyInvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn invoiceNumColumn => this.columninvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn officeInvoiceNumColumn => this.columnofficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn quoteIdColumn => this.columnquoteId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GrossBilledColumn => this.columnGrossBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CommissionColumn => this.columnCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FeesColumn => this.columnFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn APBalanceColumn => this.columnAPBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ARBalanceColumn => this.columnARBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn underNoticeColumn => this.columnunderNotice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInvoicesRow this[int index]
    {
      get => (dsPolicyInformation.PolicyInvoicesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPolicyInvoicesRow(dsPolicyInformation.PolicyInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInvoicesRow AddPolicyInvoicesRow(
      int invoiceNum,
      int officeInvoiceNum,
      int quoteId,
      Decimal GrossBilled,
      Decimal Commission,
      Decimal Premium,
      Decimal Fees,
      Decimal APBalance,
      Decimal ARBalance,
      DateTime DueDate,
      bool underNotice)
    {
      dsPolicyInformation.PolicyInvoicesRow row = (dsPolicyInformation.PolicyInvoicesRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) invoiceNum,
        (object) officeInvoiceNum,
        (object) quoteId,
        (object) GrossBilled,
        (object) Commission,
        (object) Premium,
        (object) Fees,
        (object) APBalance,
        (object) ARBalance,
        (object) DueDate,
        (object) underNotice
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.PolicyInvoicesDataTable invoicesDataTable = (dsPolicyInformation.PolicyInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.PolicyInvoicesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columninvoiceNum = this.Columns["invoiceNum"];
      this.columnofficeInvoiceNum = this.Columns["officeInvoiceNum"];
      this.columnquoteId = this.Columns["quoteId"];
      this.columnGrossBilled = this.Columns["GrossBilled"];
      this.columnCommission = this.Columns["Commission"];
      this.columnPremium = this.Columns["Premium"];
      this.columnFees = this.Columns["Fees"];
      this.columnAPBalance = this.Columns["APBalance"];
      this.columnARBalance = this.Columns["ARBalance"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnunderNotice = this.Columns["underNotice"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columninvoiceNum = new DataColumn("invoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoiceNum);
      this.columnofficeInvoiceNum = new DataColumn("officeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeInvoiceNum);
      this.columnquoteId = new DataColumn("quoteId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquoteId);
      this.columnGrossBilled = new DataColumn("GrossBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossBilled);
      this.columnCommission = new DataColumn("Commission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommission);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnAPBalance = new DataColumn("APBalance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPBalance);
      this.columnARBalance = new DataColumn("ARBalance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARBalance);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnunderNotice = new DataColumn("underNotice", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnunderNotice);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInvoicesRow NewPolicyInvoicesRow()
    {
      return (dsPolicyInformation.PolicyInvoicesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.PolicyInvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.PolicyInvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInvoicesRowChangeEventHandler invoicesRowChangedEvent = this.PolicyInvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsPolicyInformation.PolicyInvoicesRowChangeEvent((dsPolicyInformation.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInvoicesRowChangeEventHandler rowChangingEvent = this.PolicyInvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.PolicyInvoicesRowChangeEvent((dsPolicyInformation.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.PolicyInvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsPolicyInformation.PolicyInvoicesRowChangeEvent((dsPolicyInformation.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInvoicesRowChangeEventHandler rowDeletingEvent = this.PolicyInvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.PolicyInvoicesRowChangeEvent((dsPolicyInformation.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePolicyInvoicesRow(dsPolicyInformation.PolicyInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyInvoicesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class InvoiceActivityDataTable : TypedTableBase<dsPolicyInformation.InvoiceActivityRow>
  {
    private DataColumn columntransactNum;
    private DataColumn columntransDescription;
    private DataColumn columnpostDate;
    private DataColumn columnReceived;
    private DataColumn columnUser;
    private DataColumn columnvoided;
    private DataColumn columnARApplied;
    private DataColumn columnAPApplied;
    private DataColumn columnExchApplied;
    private DataColumn columnUnacctApplied;
    private DataColumn columnIncomeApplied;
    private DataColumn columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceActivityDataTable()
    {
      this.TableName = "InvoiceActivity";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceActivityDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected InvoiceActivityDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn transactNumColumn => this.columntransactNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn transDescriptionColumn => this.columntransDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn postDateColumn => this.columnpostDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ReceivedColumn => this.columnReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UserColumn => this.columnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn voidedColumn => this.columnvoided;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ARAppliedColumn => this.columnARApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn APAppliedColumn => this.columnAPApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExchAppliedColumn => this.columnExchApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UnacctAppliedColumn => this.columnUnacctApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IncomeAppliedColumn => this.columnIncomeApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Check_NumberColumn => this.columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceActivityRow this[int index]
    {
      get => (dsPolicyInformation.InvoiceActivityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceActivityRowChangeEventHandler InvoiceActivityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceActivityRowChangeEventHandler InvoiceActivityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceActivityRowChangeEventHandler InvoiceActivityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceActivityRowChangeEventHandler InvoiceActivityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddInvoiceActivityRow(dsPolicyInformation.InvoiceActivityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceActivityRow AddInvoiceActivityRow(
      int transactNum,
      string transDescription,
      DateTime postDate,
      DateTime Received,
      string User,
      bool voided,
      Decimal ARApplied,
      Decimal APApplied,
      Decimal ExchApplied,
      Decimal UnacctApplied,
      Decimal IncomeApplied,
      string Check_Number)
    {
      dsPolicyInformation.InvoiceActivityRow row = (dsPolicyInformation.InvoiceActivityRow) this.NewRow();
      object[] objArray = new object[12]
      {
        (object) transactNum,
        (object) transDescription,
        (object) postDate,
        (object) Received,
        (object) User,
        (object) voided,
        (object) ARApplied,
        (object) APApplied,
        (object) ExchApplied,
        (object) UnacctApplied,
        (object) IncomeApplied,
        (object) Check_Number
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.InvoiceActivityDataTable activityDataTable = (dsPolicyInformation.InvoiceActivityDataTable) base.Clone();
      activityDataTable.InitVars();
      return (DataTable) activityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.InvoiceActivityDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columntransDescription = this.Columns["transDescription"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnReceived = this.Columns["Received"];
      this.columnUser = this.Columns["User"];
      this.columnvoided = this.Columns["voided"];
      this.columnARApplied = this.Columns["ARApplied"];
      this.columnAPApplied = this.Columns["APApplied"];
      this.columnExchApplied = this.Columns["ExchApplied"];
      this.columnUnacctApplied = this.Columns["UnacctApplied"];
      this.columnIncomeApplied = this.Columns["IncomeApplied"];
      this.columnCheck_Number = this.Columns["Check Number"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columntransDescription = new DataColumn("transDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransDescription);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnReceived = new DataColumn("Received", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceived);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.columnvoided = new DataColumn("voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnvoided);
      this.columnARApplied = new DataColumn("ARApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARApplied);
      this.columnAPApplied = new DataColumn("APApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPApplied);
      this.columnExchApplied = new DataColumn("ExchApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchApplied);
      this.columnUnacctApplied = new DataColumn("UnacctApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnacctApplied);
      this.columnIncomeApplied = new DataColumn("IncomeApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncomeApplied);
      this.columnCheck_Number = new DataColumn("Check Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheck_Number);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceActivityRow NewInvoiceActivityRow()
    {
      return (dsPolicyInformation.InvoiceActivityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.InvoiceActivityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.InvoiceActivityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceActivityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceActivityRowChangeEventHandler activityRowChangedEvent = this.InvoiceActivityRowChangedEvent;
      if (activityRowChangedEvent == null)
        return;
      activityRowChangedEvent((object) this, new dsPolicyInformation.InvoiceActivityRowChangeEvent((dsPolicyInformation.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceActivityRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceActivityRowChangeEventHandler rowChangingEvent = this.InvoiceActivityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.InvoiceActivityRowChangeEvent((dsPolicyInformation.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceActivityRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceActivityRowChangeEventHandler activityRowDeletedEvent = this.InvoiceActivityRowDeletedEvent;
      if (activityRowDeletedEvent == null)
        return;
      activityRowDeletedEvent((object) this, new dsPolicyInformation.InvoiceActivityRowChangeEvent((dsPolicyInformation.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceActivityRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceActivityRowChangeEventHandler rowDeletingEvent = this.InvoiceActivityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.InvoiceActivityRowChangeEvent((dsPolicyInformation.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveInvoiceActivityRow(dsPolicyInformation.InvoiceActivityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceActivityDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class InvoiceDetailDataTable : TypedTableBase<dsPolicyInformation.InvoiceDetailRow>
  {
    private DataColumn columnDueDate;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnEndorsementNumber;
    private DataColumn columnBrokerCommission;
    private DataColumn columnGrossCommission;
    private DataColumn columnDateBilled;
    private DataColumn columnDueCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceDetailDataTable()
    {
      this.TableName = "InvoiceDetail";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceDetailDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected InvoiceDetailDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EndorsementNumberColumn => this.columnEndorsementNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn BrokerCommissionColumn => this.columnBrokerCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GrossCommissionColumn => this.columnGrossCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateBilledColumn => this.columnDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DueCompanyColumn => this.columnDueCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceDetailRow this[int index]
    {
      get => (dsPolicyInformation.InvoiceDetailRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceDetailRowChangeEventHandler InvoiceDetailRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceDetailRowChangeEventHandler InvoiceDetailRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceDetailRowChangeEventHandler InvoiceDetailRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceDetailRowChangeEventHandler InvoiceDetailRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddInvoiceDetailRow(dsPolicyInformation.InvoiceDetailRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceDetailRow AddInvoiceDetailRow(
      DateTime DueDate,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      string EndorsementNumber,
      Decimal BrokerCommission,
      Decimal GrossCommission,
      DateTime DateBilled,
      DateTime DueCompany)
    {
      dsPolicyInformation.InvoiceDetailRow row = (dsPolicyInformation.InvoiceDetailRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) DueDate,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) EndorsementNumber,
        (object) BrokerCommission,
        (object) GrossCommission,
        (object) DateBilled,
        (object) DueCompany
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.InvoiceDetailDataTable invoiceDetailDataTable = (dsPolicyInformation.InvoiceDetailDataTable) base.Clone();
      invoiceDetailDataTable.InitVars();
      return (DataTable) invoiceDetailDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.InvoiceDetailDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnDueDate = this.Columns["DueDate"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnEndorsementNumber = this.Columns["EndorsementNumber"];
      this.columnBrokerCommission = this.Columns["BrokerCommission"];
      this.columnGrossCommission = this.Columns["GrossCommission"];
      this.columnDateBilled = this.Columns["DateBilled"];
      this.columnDueCompany = this.Columns["DueCompany"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnEndorsementNumber = new DataColumn("EndorsementNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementNumber);
      this.columnBrokerCommission = new DataColumn("BrokerCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBrokerCommission);
      this.columnGrossCommission = new DataColumn("GrossCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossCommission);
      this.columnDateBilled = new DataColumn("DateBilled", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateBilled);
      this.columnDueCompany = new DataColumn("DueCompany", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueCompany);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceDetailRow NewInvoiceDetailRow()
    {
      return (dsPolicyInformation.InvoiceDetailRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.InvoiceDetailRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.InvoiceDetailRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceDetailRowChangeEventHandler detailRowChangedEvent = this.InvoiceDetailRowChangedEvent;
      if (detailRowChangedEvent == null)
        return;
      detailRowChangedEvent((object) this, new dsPolicyInformation.InvoiceDetailRowChangeEvent((dsPolicyInformation.InvoiceDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceDetailRowChangeEventHandler rowChangingEvent = this.InvoiceDetailRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.InvoiceDetailRowChangeEvent((dsPolicyInformation.InvoiceDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceDetailRowChangeEventHandler detailRowDeletedEvent = this.InvoiceDetailRowDeletedEvent;
      if (detailRowDeletedEvent == null)
        return;
      detailRowDeletedEvent((object) this, new dsPolicyInformation.InvoiceDetailRowChangeEvent((dsPolicyInformation.InvoiceDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceDetailRowChangeEventHandler rowDeletingEvent = this.InvoiceDetailRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.InvoiceDetailRowChangeEvent((dsPolicyInformation.InvoiceDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveInvoiceDetailRow(dsPolicyInformation.InvoiceDetailRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceDetailDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class InvoicePremiumLinesDataTable : 
    TypedTableBase<dsPolicyInformation.InvoicePremiumLinesRow>
  {
    private DataColumn columnpremiumName;
    private DataColumn columnamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoicePremiumLinesDataTable()
    {
      this.TableName = "InvoicePremiumLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoicePremiumLinesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected InvoicePremiumLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn premiumNameColumn => this.columnpremiumName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn amountColumn => this.columnamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoicePremiumLinesRow this[int index]
    {
      get => (dsPolicyInformation.InvoicePremiumLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler InvoicePremiumLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler InvoicePremiumLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler InvoicePremiumLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler InvoicePremiumLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddInvoicePremiumLinesRow(dsPolicyInformation.InvoicePremiumLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoicePremiumLinesRow AddInvoicePremiumLinesRow(
      string premiumName,
      Decimal amount)
    {
      dsPolicyInformation.InvoicePremiumLinesRow row = (dsPolicyInformation.InvoicePremiumLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) premiumName,
        (object) amount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.InvoicePremiumLinesDataTable premiumLinesDataTable = (dsPolicyInformation.InvoicePremiumLinesDataTable) base.Clone();
      premiumLinesDataTable.InitVars();
      return (DataTable) premiumLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.InvoicePremiumLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnpremiumName = this.Columns["premiumName"];
      this.columnamount = this.Columns["amount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnpremiumName = new DataColumn("premiumName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpremiumName);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoicePremiumLinesRow NewInvoicePremiumLinesRow()
    {
      return (dsPolicyInformation.InvoicePremiumLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.InvoicePremiumLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.InvoicePremiumLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePremiumLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler linesRowChangedEvent = this.InvoicePremiumLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsPolicyInformation.InvoicePremiumLinesRowChangeEvent((dsPolicyInformation.InvoicePremiumLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePremiumLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler rowChangingEvent = this.InvoicePremiumLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.InvoicePremiumLinesRowChangeEvent((dsPolicyInformation.InvoicePremiumLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePremiumLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler linesRowDeletedEvent = this.InvoicePremiumLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsPolicyInformation.InvoicePremiumLinesRowChangeEvent((dsPolicyInformation.InvoicePremiumLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePremiumLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoicePremiumLinesRowChangeEventHandler rowDeletingEvent = this.InvoicePremiumLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.InvoicePremiumLinesRowChangeEvent((dsPolicyInformation.InvoicePremiumLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveInvoicePremiumLinesRow(dsPolicyInformation.InvoicePremiumLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoicePremiumLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class InvoiceFeeLinesDataTable : TypedTableBase<dsPolicyInformation.InvoiceFeeLinesRow>
  {
    private DataColumn columnFeeName;
    private DataColumn columnamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceFeeLinesDataTable()
    {
      this.TableName = "InvoiceFeeLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceFeeLinesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected InvoiceFeeLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FeeNameColumn => this.columnFeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn amountColumn => this.columnamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceFeeLinesRow this[int index]
    {
      get => (dsPolicyInformation.InvoiceFeeLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler InvoiceFeeLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler InvoiceFeeLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler InvoiceFeeLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler InvoiceFeeLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddInvoiceFeeLinesRow(dsPolicyInformation.InvoiceFeeLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceFeeLinesRow AddInvoiceFeeLinesRow(
      string FeeName,
      Decimal amount)
    {
      dsPolicyInformation.InvoiceFeeLinesRow row = (dsPolicyInformation.InvoiceFeeLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FeeName,
        (object) amount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.InvoiceFeeLinesDataTable feeLinesDataTable = (dsPolicyInformation.InvoiceFeeLinesDataTable) base.Clone();
      feeLinesDataTable.InitVars();
      return (DataTable) feeLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.InvoiceFeeLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnFeeName = this.Columns["FeeName"];
      this.columnamount = this.Columns["amount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnFeeName = new DataColumn("FeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeName);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceFeeLinesRow NewInvoiceFeeLinesRow()
    {
      return (dsPolicyInformation.InvoiceFeeLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.InvoiceFeeLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.InvoiceFeeLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceFeeLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler linesRowChangedEvent = this.InvoiceFeeLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsPolicyInformation.InvoiceFeeLinesRowChangeEvent((dsPolicyInformation.InvoiceFeeLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceFeeLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler rowChangingEvent = this.InvoiceFeeLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.InvoiceFeeLinesRowChangeEvent((dsPolicyInformation.InvoiceFeeLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceFeeLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler linesRowDeletedEvent = this.InvoiceFeeLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsPolicyInformation.InvoiceFeeLinesRowChangeEvent((dsPolicyInformation.InvoiceFeeLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceFeeLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.InvoiceFeeLinesRowChangeEventHandler rowDeletingEvent = this.InvoiceFeeLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.InvoiceFeeLinesRowChangeEvent((dsPolicyInformation.InvoiceFeeLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveInvoiceFeeLinesRow(dsPolicyInformation.InvoiceFeeLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceFeeLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class CancellationInformationDataTable : 
    TypedTableBase<dsPolicyInformation.CancellationInformationRow>
  {
    private DataColumn columnIssuanceDate;
    private DataColumn columnMessage;
    private DataColumn columnPastDueAmt;
    private DataColumn columnCancellationDate;
    private DataColumn columnCancellationMessage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CancellationInformationDataTable()
    {
      this.TableName = "CancellationInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CancellationInformationDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected CancellationInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IssuanceDateColumn => this.columnIssuanceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn MessageColumn => this.columnMessage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PastDueAmtColumn => this.columnPastDueAmt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CancellationDateColumn => this.columnCancellationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CancellationMessageColumn => this.columnCancellationMessage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.CancellationInformationRow this[int index]
    {
      get => (dsPolicyInformation.CancellationInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.CancellationInformationRowChangeEventHandler CancellationInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.CancellationInformationRowChangeEventHandler CancellationInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.CancellationInformationRowChangeEventHandler CancellationInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.CancellationInformationRowChangeEventHandler CancellationInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddCancellationInformationRow(dsPolicyInformation.CancellationInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.CancellationInformationRow AddCancellationInformationRow(
      DateTime IssuanceDate,
      string Message,
      Decimal PastDueAmt,
      DateTime CancellationDate,
      string CancellationMessage)
    {
      dsPolicyInformation.CancellationInformationRow row = (dsPolicyInformation.CancellationInformationRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) IssuanceDate,
        (object) Message,
        (object) PastDueAmt,
        (object) CancellationDate,
        (object) CancellationMessage
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.CancellationInformationDataTable informationDataTable = (dsPolicyInformation.CancellationInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.CancellationInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnIssuanceDate = this.Columns["IssuanceDate"];
      this.columnMessage = this.Columns["Message"];
      this.columnPastDueAmt = this.Columns["PastDueAmt"];
      this.columnCancellationDate = this.Columns["CancellationDate"];
      this.columnCancellationMessage = this.Columns["CancellationMessage"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnIssuanceDate = new DataColumn("IssuanceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuanceDate);
      this.columnMessage = new DataColumn("Message", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMessage);
      this.columnPastDueAmt = new DataColumn("PastDueAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPastDueAmt);
      this.columnCancellationDate = new DataColumn("CancellationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCancellationDate);
      this.columnCancellationMessage = new DataColumn("CancellationMessage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCancellationMessage);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.CancellationInformationRow NewCancellationInformationRow()
    {
      return (dsPolicyInformation.CancellationInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.CancellationInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.CancellationInformationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.CancellationInformationRowChangeEventHandler informationRowChangedEvent = this.CancellationInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsPolicyInformation.CancellationInformationRowChangeEvent((dsPolicyInformation.CancellationInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationInformationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.CancellationInformationRowChangeEventHandler rowChangingEvent = this.CancellationInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.CancellationInformationRowChangeEvent((dsPolicyInformation.CancellationInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationInformationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.CancellationInformationRowChangeEventHandler informationRowDeletedEvent = this.CancellationInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsPolicyInformation.CancellationInformationRowChangeEvent((dsPolicyInformation.CancellationInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationInformationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.CancellationInformationRowChangeEventHandler rowDeletingEvent = this.CancellationInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.CancellationInformationRowChangeEvent((dsPolicyInformation.CancellationInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveCancellationInformationRow(dsPolicyInformation.CancellationInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CancellationInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class PolicyInquiryCommentsDataTable : 
    TypedTableBase<dsPolicyInformation.PolicyInquiryCommentsRow>
  {
    private DataColumn columnCommentId;
    private DataColumn columnCommentDate;
    private DataColumn columnUserName;
    private DataColumn columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyInquiryCommentsDataTable()
    {
      this.TableName = "PolicyInquiryComments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyInquiryCommentsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PolicyInquiryCommentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CommentIdColumn => this.columnCommentId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CommentDateColumn => this.columnCommentDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CommentColumn => this.columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInquiryCommentsRow this[int index]
    {
      get => (dsPolicyInformation.PolicyInquiryCommentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler PolicyInquiryCommentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler PolicyInquiryCommentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler PolicyInquiryCommentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler PolicyInquiryCommentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPolicyInquiryCommentsRow(dsPolicyInformation.PolicyInquiryCommentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInquiryCommentsRow AddPolicyInquiryCommentsRow(
      int CommentId,
      DateTime CommentDate,
      string UserName,
      string Comment)
    {
      dsPolicyInformation.PolicyInquiryCommentsRow row = (dsPolicyInformation.PolicyInquiryCommentsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CommentId,
        (object) CommentDate,
        (object) UserName,
        (object) Comment
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.PolicyInquiryCommentsDataTable commentsDataTable = (dsPolicyInformation.PolicyInquiryCommentsDataTable) base.Clone();
      commentsDataTable.InitVars();
      return (DataTable) commentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.PolicyInquiryCommentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCommentId = this.Columns["CommentId"];
      this.columnCommentDate = this.Columns["CommentDate"];
      this.columnUserName = this.Columns["UserName"];
      this.columnComment = this.Columns["Comment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCommentId = new DataColumn("CommentId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommentId);
      this.columnCommentDate = new DataColumn("CommentDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommentDate);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnComment = new DataColumn("Comment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComment);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInquiryCommentsRow NewPolicyInquiryCommentsRow()
    {
      return (dsPolicyInformation.PolicyInquiryCommentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.PolicyInquiryCommentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.PolicyInquiryCommentsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInquiryCommentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler commentsRowChangedEvent = this.PolicyInquiryCommentsRowChangedEvent;
      if (commentsRowChangedEvent == null)
        return;
      commentsRowChangedEvent((object) this, new dsPolicyInformation.PolicyInquiryCommentsRowChangeEvent((dsPolicyInformation.PolicyInquiryCommentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInquiryCommentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler rowChangingEvent = this.PolicyInquiryCommentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.PolicyInquiryCommentsRowChangeEvent((dsPolicyInformation.PolicyInquiryCommentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInquiryCommentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler commentsRowDeletedEvent = this.PolicyInquiryCommentsRowDeletedEvent;
      if (commentsRowDeletedEvent == null)
        return;
      commentsRowDeletedEvent((object) this, new dsPolicyInformation.PolicyInquiryCommentsRowChangeEvent((dsPolicyInformation.PolicyInquiryCommentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyInquiryCommentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyInquiryCommentsRowChangeEventHandler rowDeletingEvent = this.PolicyInquiryCommentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.PolicyInquiryCommentsRowChangeEvent((dsPolicyInformation.PolicyInquiryCommentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePolicyInquiryCommentsRow(dsPolicyInformation.PolicyInquiryCommentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyInquiryCommentsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class ReinstatementInformationDataTable : 
    TypedTableBase<dsPolicyInformation.ReinstatementInformationRow>
  {
    private DataColumn columnIssuedMessage;
    private DataColumn columnEffectiveMessage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ReinstatementInformationDataTable()
    {
      this.TableName = "ReinstatementInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ReinstatementInformationDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected ReinstatementInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IssuedMessageColumn => this.columnIssuedMessage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EffectiveMessageColumn => this.columnEffectiveMessage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.ReinstatementInformationRow this[int index]
    {
      get => (dsPolicyInformation.ReinstatementInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.ReinstatementInformationRowChangeEventHandler ReinstatementInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.ReinstatementInformationRowChangeEventHandler ReinstatementInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.ReinstatementInformationRowChangeEventHandler ReinstatementInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.ReinstatementInformationRowChangeEventHandler ReinstatementInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddReinstatementInformationRow(
      dsPolicyInformation.ReinstatementInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.ReinstatementInformationRow AddReinstatementInformationRow(
      string IssuedMessage,
      string EffectiveMessage)
    {
      dsPolicyInformation.ReinstatementInformationRow row = (dsPolicyInformation.ReinstatementInformationRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) IssuedMessage,
        (object) EffectiveMessage
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.ReinstatementInformationDataTable informationDataTable = (dsPolicyInformation.ReinstatementInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.ReinstatementInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnIssuedMessage = this.Columns["IssuedMessage"];
      this.columnEffectiveMessage = this.Columns["EffectiveMessage"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnIssuedMessage = new DataColumn("IssuedMessage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuedMessage);
      this.columnEffectiveMessage = new DataColumn("EffectiveMessage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveMessage);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.ReinstatementInformationRow NewReinstatementInformationRow()
    {
      return (dsPolicyInformation.ReinstatementInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.ReinstatementInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPolicyInformation.ReinstatementInformationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinstatementInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.ReinstatementInformationRowChangeEventHandler informationRowChangedEvent = this.ReinstatementInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsPolicyInformation.ReinstatementInformationRowChangeEvent((dsPolicyInformation.ReinstatementInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinstatementInformationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.ReinstatementInformationRowChangeEventHandler rowChangingEvent = this.ReinstatementInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.ReinstatementInformationRowChangeEvent((dsPolicyInformation.ReinstatementInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinstatementInformationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.ReinstatementInformationRowChangeEventHandler informationRowDeletedEvent = this.ReinstatementInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsPolicyInformation.ReinstatementInformationRowChangeEvent((dsPolicyInformation.ReinstatementInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinstatementInformationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.ReinstatementInformationRowChangeEventHandler rowDeletingEvent = this.ReinstatementInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.ReinstatementInformationRowChangeEvent((dsPolicyInformation.ReinstatementInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveReinstatementInformationRow(
      dsPolicyInformation.ReinstatementInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReinstatementInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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
  public class PolicyActivityDataTable : TypedTableBase<dsPolicyInformation.PolicyActivityRow>
  {
    private DataColumn columntransactNum;
    private DataColumn columntransDescription;
    private DataColumn columnpostDate;
    private DataColumn columnReceived;
    private DataColumn columnUser;
    private DataColumn columnvoided;
    private DataColumn columnARApplied;
    private DataColumn columnAPApplied;
    private DataColumn columnExchApplied;
    private DataColumn columnUnacctApplied;
    private DataColumn columnIncomeApplied;
    private DataColumn columnCheck_Number;
    private DataColumn _columnInvoice__;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyActivityDataTable()
    {
      this.TableName = "PolicyActivity";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyActivityDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PolicyActivityDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn transactNumColumn => this.columntransactNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn transDescriptionColumn => this.columntransDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn postDateColumn => this.columnpostDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ReceivedColumn => this.columnReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UserColumn => this.columnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn voidedColumn => this.columnvoided;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ARAppliedColumn => this.columnARApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn APAppliedColumn => this.columnAPApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExchAppliedColumn => this.columnExchApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UnacctAppliedColumn => this.columnUnacctApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IncomeAppliedColumn => this.columnIncomeApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Check_NumberColumn => this.columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn _Invoice__Column => this._columnInvoice__;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyActivityRow this[int index]
    {
      get => (dsPolicyInformation.PolicyActivityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyActivityRowChangeEventHandler PolicyActivityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyActivityRowChangeEventHandler PolicyActivityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyActivityRowChangeEventHandler PolicyActivityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsPolicyInformation.PolicyActivityRowChangeEventHandler PolicyActivityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPolicyActivityRow(dsPolicyInformation.PolicyActivityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyActivityRow AddPolicyActivityRow(
      int transactNum,
      string transDescription,
      DateTime postDate,
      DateTime Received,
      string User,
      bool voided,
      Decimal ARApplied,
      Decimal APApplied,
      Decimal ExchApplied,
      Decimal UnacctApplied,
      Decimal IncomeApplied,
      string Check_Number,
      string _Invoice__)
    {
      dsPolicyInformation.PolicyActivityRow row = (dsPolicyInformation.PolicyActivityRow) this.NewRow();
      object[] objArray = new object[13]
      {
        (object) transactNum,
        (object) transDescription,
        (object) postDate,
        (object) Received,
        (object) User,
        (object) voided,
        (object) ARApplied,
        (object) APApplied,
        (object) ExchApplied,
        (object) UnacctApplied,
        (object) IncomeApplied,
        (object) Check_Number,
        (object) _Invoice__
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInformation.PolicyActivityDataTable activityDataTable = (dsPolicyInformation.PolicyActivityDataTable) base.Clone();
      activityDataTable.InitVars();
      return (DataTable) activityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInformation.PolicyActivityDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columntransDescription = this.Columns["transDescription"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnReceived = this.Columns["Received"];
      this.columnUser = this.Columns["User"];
      this.columnvoided = this.Columns["voided"];
      this.columnARApplied = this.Columns["ARApplied"];
      this.columnAPApplied = this.Columns["APApplied"];
      this.columnExchApplied = this.Columns["ExchApplied"];
      this.columnUnacctApplied = this.Columns["UnacctApplied"];
      this.columnIncomeApplied = this.Columns["IncomeApplied"];
      this.columnCheck_Number = this.Columns["Check Number"];
      this._columnInvoice__ = this.Columns["Invoice #"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columntransDescription = new DataColumn("transDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransDescription);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnReceived = new DataColumn("Received", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceived);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.columnvoided = new DataColumn("voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnvoided);
      this.columnARApplied = new DataColumn("ARApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARApplied);
      this.columnAPApplied = new DataColumn("APApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPApplied);
      this.columnExchApplied = new DataColumn("ExchApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchApplied);
      this.columnUnacctApplied = new DataColumn("UnacctApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnacctApplied);
      this.columnIncomeApplied = new DataColumn("IncomeApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncomeApplied);
      this.columnCheck_Number = new DataColumn("Check Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheck_Number);
      this._columnInvoice__ = new DataColumn("Invoice #", typeof (string), (string) null, MappingType.Element);
      this._columnInvoice__.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnInvoice__");
      this._columnInvoice__.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Invoice #");
      this.Columns.Add(this._columnInvoice__);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyActivityRow NewPolicyActivityRow()
    {
      return (dsPolicyInformation.PolicyActivityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInformation.PolicyActivityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInformation.PolicyActivityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyActivityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyActivityRowChangeEventHandler activityRowChangedEvent = this.PolicyActivityRowChangedEvent;
      if (activityRowChangedEvent == null)
        return;
      activityRowChangedEvent((object) this, new dsPolicyInformation.PolicyActivityRowChangeEvent((dsPolicyInformation.PolicyActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyActivityRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyActivityRowChangeEventHandler rowChangingEvent = this.PolicyActivityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInformation.PolicyActivityRowChangeEvent((dsPolicyInformation.PolicyActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyActivityRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyActivityRowChangeEventHandler activityRowDeletedEvent = this.PolicyActivityRowDeletedEvent;
      if (activityRowDeletedEvent == null)
        return;
      activityRowDeletedEvent((object) this, new dsPolicyInformation.PolicyActivityRowChangeEvent((dsPolicyInformation.PolicyActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyActivityRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInformation.PolicyActivityRowChangeEventHandler rowDeletingEvent = this.PolicyActivityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInformation.PolicyActivityRowChangeEvent((dsPolicyInformation.PolicyActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePolicyActivityRow(dsPolicyInformation.PolicyActivityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInformation policyInformation = new dsPolicyInformation();
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
        FixedValue = policyInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyActivityDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyInformation.GetSchemaSerializable();
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

  public class PolicyHeaderRow : DataRow
  {
    private dsPolicyInformation.PolicyHeaderDataTable tablePolicyHeader;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyHeader = (dsPolicyInformation.PolicyHeaderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.InsuredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyHeader.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyHeader.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Producer' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.CompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ControlNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyHeader.ControlNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNumber' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.ControlNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsNocDisabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyHeader.IsNocDisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsNocDisabled' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.IsNocDisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CostCenter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.CostCenterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CostCenter' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.CostCenterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string BillingType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.BillingTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingType' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid FinanceCompanyGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablePolicyHeader.FinanceCompanyGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FinanceCompanyGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.FinanceCompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FinanceCompanyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.FinanceCompanyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FinanceCompanyName' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.FinanceCompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FinanceCompanyAccountNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.FinanceCompanyAccountNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FinanceCompanyAccountNumber' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.FinanceCompanyAccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CurrencyCode
    {
      get
      {
        return !this.IsCurrencyCodeNull() ? Conversions.ToString(this[this.tablePolicyHeader.CurrencyCodeColumn]) : string.Empty;
      }
      set => this[this.tablePolicyHeader.CurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string OfficeLocation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHeader.OfficeLocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeLocation' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.OfficeLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tablePolicyHeader.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablePolicyHeader.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tablePolicyHeader.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredNull()
    {
      this[this.tablePolicyHeader.InsuredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tablePolicyHeader.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tablePolicyHeader.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tablePolicyHeader.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tablePolicyHeader.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tablePolicyHeader.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tablePolicyHeader.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tablePolicyHeader.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tablePolicyHeader.CompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUnderwriterNull() => this.IsNull(this.tablePolicyHeader.UnderwriterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tablePolicyHeader.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsControlNumberNull() => this.IsNull(this.tablePolicyHeader.ControlNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetControlNumberNull()
    {
      this[this.tablePolicyHeader.ControlNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIsNocDisabledNull() => this.IsNull(this.tablePolicyHeader.IsNocDisabledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIsNocDisabledNull()
    {
      this[this.tablePolicyHeader.IsNocDisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCostCenterNull() => this.IsNull(this.tablePolicyHeader.CostCenterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCostCenterNull()
    {
      this[this.tablePolicyHeader.CostCenterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsBillingTypeNull() => this.IsNull(this.tablePolicyHeader.BillingTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetBillingTypeNull()
    {
      this[this.tablePolicyHeader.BillingTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFinanceCompanyGuidNull()
    {
      return this.IsNull(this.tablePolicyHeader.FinanceCompanyGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFinanceCompanyGuidNull()
    {
      this[this.tablePolicyHeader.FinanceCompanyGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFinanceCompanyNameNull()
    {
      return this.IsNull(this.tablePolicyHeader.FinanceCompanyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFinanceCompanyNameNull()
    {
      this[this.tablePolicyHeader.FinanceCompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFinanceCompanyAccountNumberNull()
    {
      return this.IsNull(this.tablePolicyHeader.FinanceCompanyAccountNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFinanceCompanyAccountNumberNull()
    {
      this[this.tablePolicyHeader.FinanceCompanyAccountNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCurrencyCodeNull() => this.IsNull(this.tablePolicyHeader.CurrencyCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCurrencyCodeNull()
    {
      this[this.tablePolicyHeader.CurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOfficeLocationNull() => this.IsNull(this.tablePolicyHeader.OfficeLocationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOfficeLocationNull()
    {
      this[this.tablePolicyHeader.OfficeLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PolicyStatusChangesRow : DataRow
  {
    private dsPolicyInformation.PolicyStatusChangesDataTable tablePolicyStatusChanges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyStatusChangesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyStatusChanges = (dsPolicyInformation.PolicyStatusChangesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyStatusChanges.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Status' in table 'PolicyStatusChanges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyStatusChanges.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Reason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyStatusChanges.ReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Reason' in table 'PolicyStatusChanges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyStatusChanges.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DateChanged
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyStatusChanges.DateChangedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateChanged' in table 'PolicyStatusChanges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyStatusChanges.DateChangedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablePolicyStatusChanges.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablePolicyStatusChanges.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsReasonNull() => this.IsNull(this.tablePolicyStatusChanges.ReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetReasonNull()
    {
      this[this.tablePolicyStatusChanges.ReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateChangedNull() => this.IsNull(this.tablePolicyStatusChanges.DateChangedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateChangedNull()
    {
      this[this.tablePolicyStatusChanges.DateChangedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PolicyInvoicesRow : DataRow
  {
    private dsPolicyInformation.PolicyInvoicesDataTable tablePolicyInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyInvoices = (dsPolicyInformation.PolicyInvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int invoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyInvoices.invoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoiceNum' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.invoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int officeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyInvoices.officeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'officeInvoiceNum' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.officeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int quoteId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyInvoices.quoteIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'quoteId' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.quoteIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal GrossBilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyInvoices.GrossBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossBilled' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.GrossBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Commission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyInvoices.CommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Commission' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.CommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyInvoices.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Fees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyInvoices.FeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fees' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal APBalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyInvoices.APBalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'APBalance' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.APBalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ARBalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyInvoices.ARBalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARBalance' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.ARBalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyInvoices.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool underNotice
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyInvoices.underNoticeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'underNotice' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.underNoticeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsinvoiceNumNull() => this.IsNull(this.tablePolicyInvoices.invoiceNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetinvoiceNumNull()
    {
      this[this.tablePolicyInvoices.invoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsofficeInvoiceNumNull()
    {
      return this.IsNull(this.tablePolicyInvoices.officeInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetofficeInvoiceNumNull()
    {
      this[this.tablePolicyInvoices.officeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsquoteIdNull() => this.IsNull(this.tablePolicyInvoices.quoteIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetquoteIdNull()
    {
      this[this.tablePolicyInvoices.quoteIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGrossBilledNull() => this.IsNull(this.tablePolicyInvoices.GrossBilledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGrossBilledNull()
    {
      this[this.tablePolicyInvoices.GrossBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCommissionNull() => this.IsNull(this.tablePolicyInvoices.CommissionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCommissionNull()
    {
      this[this.tablePolicyInvoices.CommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tablePolicyInvoices.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tablePolicyInvoices.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFeesNull() => this.IsNull(this.tablePolicyInvoices.FeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFeesNull()
    {
      this[this.tablePolicyInvoices.FeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAPBalanceNull() => this.IsNull(this.tablePolicyInvoices.APBalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAPBalanceNull()
    {
      this[this.tablePolicyInvoices.APBalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsARBalanceNull() => this.IsNull(this.tablePolicyInvoices.ARBalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetARBalanceNull()
    {
      this[this.tablePolicyInvoices.ARBalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tablePolicyInvoices.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tablePolicyInvoices.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsunderNoticeNull() => this.IsNull(this.tablePolicyInvoices.underNoticeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetunderNoticeNull()
    {
      this[this.tablePolicyInvoices.underNoticeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvoiceActivityRow : DataRow
  {
    private dsPolicyInformation.InvoiceActivityDataTable tableInvoiceActivity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceActivityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceActivity = (dsPolicyInformation.InvoiceActivityDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceActivity.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactNum' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.transactNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string transDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceActivity.transDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transDescription' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.transDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime postDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceActivity.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'postDate' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.postDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime Received
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceActivity.ReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Received' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.ReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string User
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceActivity.UserColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'User' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.UserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool voided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableInvoiceActivity.voidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'voided' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.voidedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ARApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceActivity.ARAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARApplied' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.ARAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal APApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceActivity.APAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'APApplied' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.APAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ExchApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceActivity.ExchAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchApplied' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.ExchAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal UnacctApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceActivity.UnacctAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnacctApplied' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.UnacctAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal IncomeApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceActivity.IncomeAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncomeApplied' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.IncomeAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Check_Number
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceActivity.Check_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Check Number' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Check_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IstransactNumNull() => this.IsNull(this.tableInvoiceActivity.transactNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SettransactNumNull()
    {
      this[this.tableInvoiceActivity.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IstransDescriptionNull()
    {
      return this.IsNull(this.tableInvoiceActivity.transDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SettransDescriptionNull()
    {
      this[this.tableInvoiceActivity.transDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IspostDateNull() => this.IsNull(this.tableInvoiceActivity.postDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetpostDateNull()
    {
      this[this.tableInvoiceActivity.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsReceivedNull() => this.IsNull(this.tableInvoiceActivity.ReceivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetReceivedNull()
    {
      this[this.tableInvoiceActivity.ReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUserNull() => this.IsNull(this.tableInvoiceActivity.UserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUserNull()
    {
      this[this.tableInvoiceActivity.UserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsvoidedNull() => this.IsNull(this.tableInvoiceActivity.voidedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetvoidedNull()
    {
      this[this.tableInvoiceActivity.voidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsARAppliedNull() => this.IsNull(this.tableInvoiceActivity.ARAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetARAppliedNull()
    {
      this[this.tableInvoiceActivity.ARAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAPAppliedNull() => this.IsNull(this.tableInvoiceActivity.APAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAPAppliedNull()
    {
      this[this.tableInvoiceActivity.APAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExchAppliedNull() => this.IsNull(this.tableInvoiceActivity.ExchAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExchAppliedNull()
    {
      this[this.tableInvoiceActivity.ExchAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUnacctAppliedNull() => this.IsNull(this.tableInvoiceActivity.UnacctAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUnacctAppliedNull()
    {
      this[this.tableInvoiceActivity.UnacctAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIncomeAppliedNull() => this.IsNull(this.tableInvoiceActivity.IncomeAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIncomeAppliedNull()
    {
      this[this.tableInvoiceActivity.IncomeAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCheck_NumberNull() => this.IsNull(this.tableInvoiceActivity.Check_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCheck_NumberNull()
    {
      this[this.tableInvoiceActivity.Check_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvoiceDetailRow : DataRow
  {
    private dsPolicyInformation.InvoiceDetailDataTable tableInvoiceDetail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceDetailRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceDetail = (dsPolicyInformation.InvoiceDetailDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceDetail.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceDetail.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceDetail.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EndorsementNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceDetail.EndorsementNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementNumber' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.EndorsementNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal BrokerCommission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetail.BrokerCommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BrokerCommission' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.BrokerCommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal GrossCommission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetail.GrossCommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossCommission' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.GrossCommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DateBilled
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceDetail.DateBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateBilled' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.DateBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DueCompany
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceDetail.DueCompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueCompany' in table 'InvoiceDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetail.DueCompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tableInvoiceDetail.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tableInvoiceDetail.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableInvoiceDetail.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableInvoiceDetail.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tableInvoiceDetail.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableInvoiceDetail.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEndorsementNumberNull()
    {
      return this.IsNull(this.tableInvoiceDetail.EndorsementNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEndorsementNumberNull()
    {
      this[this.tableInvoiceDetail.EndorsementNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsBrokerCommissionNull()
    {
      return this.IsNull(this.tableInvoiceDetail.BrokerCommissionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetBrokerCommissionNull()
    {
      this[this.tableInvoiceDetail.BrokerCommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGrossCommissionNull()
    {
      return this.IsNull(this.tableInvoiceDetail.GrossCommissionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGrossCommissionNull()
    {
      this[this.tableInvoiceDetail.GrossCommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateBilledNull() => this.IsNull(this.tableInvoiceDetail.DateBilledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateBilledNull()
    {
      this[this.tableInvoiceDetail.DateBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDueCompanyNull() => this.IsNull(this.tableInvoiceDetail.DueCompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDueCompanyNull()
    {
      this[this.tableInvoiceDetail.DueCompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvoicePremiumLinesRow : DataRow
  {
    private dsPolicyInformation.InvoicePremiumLinesDataTable tableInvoicePremiumLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoicePremiumLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoicePremiumLines = (dsPolicyInformation.InvoicePremiumLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string premiumName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoicePremiumLines.premiumNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'premiumName' in table 'InvoicePremiumLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePremiumLines.premiumNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoicePremiumLines.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'amount' in table 'InvoicePremiumLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePremiumLines.amountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IspremiumNameNull() => this.IsNull(this.tableInvoicePremiumLines.premiumNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetpremiumNameNull()
    {
      this[this.tableInvoicePremiumLines.premiumNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsamountNull() => this.IsNull(this.tableInvoicePremiumLines.amountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetamountNull()
    {
      this[this.tableInvoicePremiumLines.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvoiceFeeLinesRow : DataRow
  {
    private dsPolicyInformation.InvoiceFeeLinesDataTable tableInvoiceFeeLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceFeeLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceFeeLines = (dsPolicyInformation.InvoiceFeeLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FeeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceFeeLines.FeeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FeeName' in table 'InvoiceFeeLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceFeeLines.FeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceFeeLines.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'amount' in table 'InvoiceFeeLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceFeeLines.amountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFeeNameNull() => this.IsNull(this.tableInvoiceFeeLines.FeeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFeeNameNull()
    {
      this[this.tableInvoiceFeeLines.FeeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsamountNull() => this.IsNull(this.tableInvoiceFeeLines.amountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetamountNull()
    {
      this[this.tableInvoiceFeeLines.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class CancellationInformationRow : DataRow
  {
    private dsPolicyInformation.CancellationInformationDataTable tableCancellationInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CancellationInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCancellationInformation = (dsPolicyInformation.CancellationInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime IssuanceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCancellationInformation.IssuanceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IssuanceDate' in table 'CancellationInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationInformation.IssuanceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Message
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationInformation.MessageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Message' in table 'CancellationInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationInformation.MessageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal PastDueAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCancellationInformation.PastDueAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PastDueAmt' in table 'CancellationInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationInformation.PastDueAmtColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime CancellationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCancellationInformation.CancellationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CancellationDate' in table 'CancellationInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationInformation.CancellationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CancellationMessage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationInformation.CancellationMessageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CancellationMessage' in table 'CancellationInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationInformation.CancellationMessageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIssuanceDateNull()
    {
      return this.IsNull(this.tableCancellationInformation.IssuanceDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIssuanceDateNull()
    {
      this[this.tableCancellationInformation.IssuanceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsMessageNull() => this.IsNull(this.tableCancellationInformation.MessageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetMessageNull()
    {
      this[this.tableCancellationInformation.MessageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPastDueAmtNull()
    {
      return this.IsNull(this.tableCancellationInformation.PastDueAmtColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPastDueAmtNull()
    {
      this[this.tableCancellationInformation.PastDueAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCancellationDateNull()
    {
      return this.IsNull(this.tableCancellationInformation.CancellationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCancellationDateNull()
    {
      this[this.tableCancellationInformation.CancellationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCancellationMessageNull()
    {
      return this.IsNull(this.tableCancellationInformation.CancellationMessageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCancellationMessageNull()
    {
      this[this.tableCancellationInformation.CancellationMessageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PolicyInquiryCommentsRow : DataRow
  {
    private dsPolicyInformation.PolicyInquiryCommentsDataTable tablePolicyInquiryComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyInquiryCommentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyInquiryComments = (dsPolicyInformation.PolicyInquiryCommentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CommentId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyInquiryComments.CommentIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommentId' in table 'PolicyInquiryComments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInquiryComments.CommentIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime CommentDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyInquiryComments.CommentDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommentDate' in table 'PolicyInquiryComments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInquiryComments.CommentDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyInquiryComments.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'PolicyInquiryComments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInquiryComments.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Comment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyInquiryComments.CommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comment' in table 'PolicyInquiryComments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInquiryComments.CommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCommentIdNull() => this.IsNull(this.tablePolicyInquiryComments.CommentIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCommentIdNull()
    {
      this[this.tablePolicyInquiryComments.CommentIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCommentDateNull()
    {
      return this.IsNull(this.tablePolicyInquiryComments.CommentDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCommentDateNull()
    {
      this[this.tablePolicyInquiryComments.CommentDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tablePolicyInquiryComments.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tablePolicyInquiryComments.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCommentNull() => this.IsNull(this.tablePolicyInquiryComments.CommentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCommentNull()
    {
      this[this.tablePolicyInquiryComments.CommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class ReinstatementInformationRow : DataRow
  {
    private dsPolicyInformation.ReinstatementInformationDataTable tableReinstatementInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ReinstatementInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReinstatementInformation = (dsPolicyInformation.ReinstatementInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string IssuedMessage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReinstatementInformation.IssuedMessageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IssuedMessage' in table 'ReinstatementInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinstatementInformation.IssuedMessageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EffectiveMessage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReinstatementInformation.EffectiveMessageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveMessage' in table 'ReinstatementInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinstatementInformation.EffectiveMessageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIssuedMessageNull()
    {
      return this.IsNull(this.tableReinstatementInformation.IssuedMessageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIssuedMessageNull()
    {
      this[this.tableReinstatementInformation.IssuedMessageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEffectiveMessageNull()
    {
      return this.IsNull(this.tableReinstatementInformation.EffectiveMessageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEffectiveMessageNull()
    {
      this[this.tableReinstatementInformation.EffectiveMessageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PolicyActivityRow : DataRow
  {
    private dsPolicyInformation.PolicyActivityDataTable tablePolicyActivity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyActivityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyActivity = (dsPolicyInformation.PolicyActivityDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyActivity.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactNum' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.transactNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string transDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyActivity.transDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transDescription' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.transDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime postDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyActivity.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'postDate' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.postDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime Received
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyActivity.ReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Received' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.ReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string User
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyActivity.UserColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'User' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.UserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool voided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyActivity.voidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'voided' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.voidedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ARApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyActivity.ARAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARApplied' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.ARAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal APApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyActivity.APAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'APApplied' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.APAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ExchApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyActivity.ExchAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchApplied' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.ExchAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal UnacctApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyActivity.UnacctAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnacctApplied' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.UnacctAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal IncomeApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyActivity.IncomeAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncomeApplied' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.IncomeAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Check_Number
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyActivity.Check_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Check Number' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity.Check_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string _Invoice__
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyActivity._Invoice__Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Invoice #' in table 'PolicyActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyActivity._Invoice__Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IstransactNumNull() => this.IsNull(this.tablePolicyActivity.transactNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SettransactNumNull()
    {
      this[this.tablePolicyActivity.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IstransDescriptionNull()
    {
      return this.IsNull(this.tablePolicyActivity.transDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SettransDescriptionNull()
    {
      this[this.tablePolicyActivity.transDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IspostDateNull() => this.IsNull(this.tablePolicyActivity.postDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetpostDateNull()
    {
      this[this.tablePolicyActivity.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsReceivedNull() => this.IsNull(this.tablePolicyActivity.ReceivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetReceivedNull()
    {
      this[this.tablePolicyActivity.ReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUserNull() => this.IsNull(this.tablePolicyActivity.UserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUserNull()
    {
      this[this.tablePolicyActivity.UserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsvoidedNull() => this.IsNull(this.tablePolicyActivity.voidedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetvoidedNull()
    {
      this[this.tablePolicyActivity.voidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsARAppliedNull() => this.IsNull(this.tablePolicyActivity.ARAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetARAppliedNull()
    {
      this[this.tablePolicyActivity.ARAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAPAppliedNull() => this.IsNull(this.tablePolicyActivity.APAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAPAppliedNull()
    {
      this[this.tablePolicyActivity.APAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExchAppliedNull() => this.IsNull(this.tablePolicyActivity.ExchAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExchAppliedNull()
    {
      this[this.tablePolicyActivity.ExchAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUnacctAppliedNull() => this.IsNull(this.tablePolicyActivity.UnacctAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUnacctAppliedNull()
    {
      this[this.tablePolicyActivity.UnacctAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIncomeAppliedNull() => this.IsNull(this.tablePolicyActivity.IncomeAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIncomeAppliedNull()
    {
      this[this.tablePolicyActivity.IncomeAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCheck_NumberNull() => this.IsNull(this.tablePolicyActivity.Check_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCheck_NumberNull()
    {
      this[this.tablePolicyActivity.Check_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Is_Invoice__Null() => this.IsNull(this.tablePolicyActivity._Invoice__Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Set_Invoice__Null()
    {
      this[this.tablePolicyActivity._Invoice__Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PolicyHeaderRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.PolicyHeaderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyHeaderRowChangeEvent(dsPolicyInformation.PolicyHeaderRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyHeaderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PolicyStatusChangesRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.PolicyStatusChangesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyStatusChangesRowChangeEvent(
      dsPolicyInformation.PolicyStatusChangesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyStatusChangesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PolicyInvoicesRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.PolicyInvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyInvoicesRowChangeEvent(
      dsPolicyInformation.PolicyInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class InvoiceActivityRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.InvoiceActivityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceActivityRowChangeEvent(
      dsPolicyInformation.InvoiceActivityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceActivityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class InvoiceDetailRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.InvoiceDetailRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceDetailRowChangeEvent(
      dsPolicyInformation.InvoiceDetailRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceDetailRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class InvoicePremiumLinesRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.InvoicePremiumLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoicePremiumLinesRowChangeEvent(
      dsPolicyInformation.InvoicePremiumLinesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoicePremiumLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class InvoiceFeeLinesRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.InvoiceFeeLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceFeeLinesRowChangeEvent(
      dsPolicyInformation.InvoiceFeeLinesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.InvoiceFeeLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class CancellationInformationRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.CancellationInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CancellationInformationRowChangeEvent(
      dsPolicyInformation.CancellationInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.CancellationInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PolicyInquiryCommentsRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.PolicyInquiryCommentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyInquiryCommentsRowChangeEvent(
      dsPolicyInformation.PolicyInquiryCommentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyInquiryCommentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class ReinstatementInformationRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.ReinstatementInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ReinstatementInformationRowChangeEvent(
      dsPolicyInformation.ReinstatementInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.ReinstatementInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PolicyActivityRowChangeEvent : EventArgs
  {
    private dsPolicyInformation.PolicyActivityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyActivityRowChangeEvent(
      dsPolicyInformation.PolicyActivityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsPolicyInformation.PolicyActivityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
