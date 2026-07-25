// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.dsPolicyInquiry
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
namespace MGASystems.IMS.Policies.PolicyDetail;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyInquiry")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyInquiry : DataSet
{
  private dsPolicyInquiry.spFin_QuoteInvoicesDataTable tablespFin_QuoteInvoices;
  private dsPolicyInquiry.spFin_InvoiceTransactionsDataTable tablespFin_InvoiceTransactions;
  private dsPolicyInquiry.spFin_PolicyARBreakdownDataTable tablespFin_PolicyARBreakdown;
  private dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable tablespFin_PolicyARBreakdown_2;
  private dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable tablespFin_PolicyARBreakdown_3;
  private dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable tablespFin_PolicyARBreakdown_4;
  private dsPolicyInquiry.SummariesDataTable tableSummaries;
  private dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable tablespFin_PolicyAPBreakdown;
  private DataRelation relationspFin_QuoteInvoicesspFin_InvoiceTransactions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPolicyInquiry()
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
  protected dsPolicyInquiry(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (spFin_QuoteInvoices)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_QuoteInvoicesDataTable(dataSet.Tables[nameof (spFin_QuoteInvoices)]));
        if (dataSet.Tables[nameof (spFin_InvoiceTransactions)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable(dataSet.Tables[nameof (spFin_InvoiceTransactions)]));
        if (dataSet.Tables[nameof (spFin_PolicyARBreakdown)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdownDataTable(dataSet.Tables[nameof (spFin_PolicyARBreakdown)]));
        if (dataSet.Tables[nameof (spFin_PolicyARBreakdown_2)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable(dataSet.Tables[nameof (spFin_PolicyARBreakdown_2)]));
        if (dataSet.Tables[nameof (spFin_PolicyARBreakdown_3)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable(dataSet.Tables[nameof (spFin_PolicyARBreakdown_3)]));
        if (dataSet.Tables[nameof (spFin_PolicyARBreakdown_4)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable(dataSet.Tables[nameof (spFin_PolicyARBreakdown_4)]));
        if (dataSet.Tables[nameof (Summaries)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.SummariesDataTable(dataSet.Tables[nameof (Summaries)]));
        if (dataSet.Tables[nameof (spFin_PolicyAPBreakdown)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable(dataSet.Tables[nameof (spFin_PolicyAPBreakdown)]));
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
  public dsPolicyInquiry.spFin_QuoteInvoicesDataTable spFin_QuoteInvoices
  {
    get => this.tablespFin_QuoteInvoices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_InvoiceTransactionsDataTable spFin_InvoiceTransactions
  {
    get => this.tablespFin_InvoiceTransactions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_PolicyARBreakdownDataTable spFin_PolicyARBreakdown
  {
    get => this.tablespFin_PolicyARBreakdown;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable spFin_PolicyARBreakdown_2
  {
    get => this.tablespFin_PolicyARBreakdown_2;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable spFin_PolicyARBreakdown_3
  {
    get => this.tablespFin_PolicyARBreakdown_3;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable spFin_PolicyARBreakdown_4
  {
    get => this.tablespFin_PolicyARBreakdown_4;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.SummariesDataTable Summaries => this.tableSummaries;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable spFin_PolicyAPBreakdown
  {
    get => this.tablespFin_PolicyAPBreakdown;
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
    dsPolicyInquiry dsPolicyInquiry = (dsPolicyInquiry) base.Clone();
    dsPolicyInquiry.InitVars();
    dsPolicyInquiry.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyInquiry;
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
      if (dataSet.Tables["spFin_QuoteInvoices"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_QuoteInvoicesDataTable(dataSet.Tables["spFin_QuoteInvoices"]));
      if (dataSet.Tables["spFin_InvoiceTransactions"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable(dataSet.Tables["spFin_InvoiceTransactions"]));
      if (dataSet.Tables["spFin_PolicyARBreakdown"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdownDataTable(dataSet.Tables["spFin_PolicyARBreakdown"]));
      if (dataSet.Tables["spFin_PolicyARBreakdown_2"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable(dataSet.Tables["spFin_PolicyARBreakdown_2"]));
      if (dataSet.Tables["spFin_PolicyARBreakdown_3"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable(dataSet.Tables["spFin_PolicyARBreakdown_3"]));
      if (dataSet.Tables["spFin_PolicyARBreakdown_4"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable(dataSet.Tables["spFin_PolicyARBreakdown_4"]));
      if (dataSet.Tables["Summaries"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.SummariesDataTable(dataSet.Tables["Summaries"]));
      if (dataSet.Tables["spFin_PolicyAPBreakdown"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable(dataSet.Tables["spFin_PolicyAPBreakdown"]));
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
    this.tablespFin_QuoteInvoices = (dsPolicyInquiry.spFin_QuoteInvoicesDataTable) base.Tables["spFin_QuoteInvoices"];
    if (initTable && this.tablespFin_QuoteInvoices != null)
      this.tablespFin_QuoteInvoices.InitVars();
    this.tablespFin_InvoiceTransactions = (dsPolicyInquiry.spFin_InvoiceTransactionsDataTable) base.Tables["spFin_InvoiceTransactions"];
    if (initTable && this.tablespFin_InvoiceTransactions != null)
      this.tablespFin_InvoiceTransactions.InitVars();
    this.tablespFin_PolicyARBreakdown = (dsPolicyInquiry.spFin_PolicyARBreakdownDataTable) base.Tables["spFin_PolicyARBreakdown"];
    if (initTable && this.tablespFin_PolicyARBreakdown != null)
      this.tablespFin_PolicyARBreakdown.InitVars();
    this.tablespFin_PolicyARBreakdown_2 = (dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable) base.Tables["spFin_PolicyARBreakdown_2"];
    if (initTable && this.tablespFin_PolicyARBreakdown_2 != null)
      this.tablespFin_PolicyARBreakdown_2.InitVars();
    this.tablespFin_PolicyARBreakdown_3 = (dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable) base.Tables["spFin_PolicyARBreakdown_3"];
    if (initTable && this.tablespFin_PolicyARBreakdown_3 != null)
      this.tablespFin_PolicyARBreakdown_3.InitVars();
    this.tablespFin_PolicyARBreakdown_4 = (dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable) base.Tables["spFin_PolicyARBreakdown_4"];
    if (initTable && this.tablespFin_PolicyARBreakdown_4 != null)
      this.tablespFin_PolicyARBreakdown_4.InitVars();
    this.tableSummaries = (dsPolicyInquiry.SummariesDataTable) base.Tables["Summaries"];
    if (initTable && this.tableSummaries != null)
      this.tableSummaries.InitVars();
    this.tablespFin_PolicyAPBreakdown = (dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable) base.Tables["spFin_PolicyAPBreakdown"];
    if (initTable && this.tablespFin_PolicyAPBreakdown != null)
      this.tablespFin_PolicyAPBreakdown.InitVars();
    this.relationspFin_QuoteInvoicesspFin_InvoiceTransactions = this.Relations["spFin_QuoteInvoicesspFin_InvoiceTransactions"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyInquiry);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyInquiry.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablespFin_QuoteInvoices = new dsPolicyInquiry.spFin_QuoteInvoicesDataTable();
    base.Tables.Add((DataTable) this.tablespFin_QuoteInvoices);
    this.tablespFin_InvoiceTransactions = new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable();
    base.Tables.Add((DataTable) this.tablespFin_InvoiceTransactions);
    this.tablespFin_PolicyARBreakdown = new dsPolicyInquiry.spFin_PolicyARBreakdownDataTable();
    base.Tables.Add((DataTable) this.tablespFin_PolicyARBreakdown);
    this.tablespFin_PolicyARBreakdown_2 = new dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable();
    base.Tables.Add((DataTable) this.tablespFin_PolicyARBreakdown_2);
    this.tablespFin_PolicyARBreakdown_3 = new dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable();
    base.Tables.Add((DataTable) this.tablespFin_PolicyARBreakdown_3);
    this.tablespFin_PolicyARBreakdown_4 = new dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable();
    base.Tables.Add((DataTable) this.tablespFin_PolicyARBreakdown_4);
    this.tableSummaries = new dsPolicyInquiry.SummariesDataTable();
    base.Tables.Add((DataTable) this.tableSummaries);
    this.tablespFin_PolicyAPBreakdown = new dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable();
    base.Tables.Add((DataTable) this.tablespFin_PolicyAPBreakdown);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("spFin_QuoteInvoicesspFin_InvoiceTransactions", new DataColumn[1]
    {
      this.tablespFin_QuoteInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tablespFin_InvoiceTransactions.InvoiceNumColumn
    });
    this.tablespFin_InvoiceTransactions.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationspFin_QuoteInvoicesspFin_InvoiceTransactions = new DataRelation("spFin_QuoteInvoicesspFin_InvoiceTransactions", new DataColumn[1]
    {
      this.tablespFin_QuoteInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tablespFin_InvoiceTransactions.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationspFin_QuoteInvoicesspFin_InvoiceTransactions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_QuoteInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_InvoiceTransactions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_PolicyARBreakdown() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_PolicyARBreakdown_2() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_PolicyARBreakdown_3() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_PolicyARBreakdown_4() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeSummaries() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializespFin_PolicyAPBreakdown() => false;

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
    dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPolicyInquiry.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public delegate void spFin_QuoteInvoicesRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void spFin_InvoiceTransactionsRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void spFin_PolicyARBreakdownRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void spFin_PolicyARBreakdown_2RowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void spFin_PolicyARBreakdown_3RowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void spFin_PolicyARBreakdown_4RowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void SummariesRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.SummariesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void spFin_PolicyAPBreakdownRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class spFin_QuoteInvoicesDataTable : TypedTableBase<dsPolicyInquiry.spFin_QuoteInvoicesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDueDate;
    private DataColumn columnGrossPremium;
    private DataColumn columnFees;
    private DataColumn columnNetBilled;
    private DataColumn columnAmtPTD;
    private DataColumn columnSurplus;
    private DataColumn columnTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_QuoteInvoicesDataTable()
    {
      this.TableName = "spFin_QuoteInvoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_QuoteInvoicesDataTable(DataTable table)
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
    protected spFin_QuoteInvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GrossPremiumColumn => this.columnGrossPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeesColumn => this.columnFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NetBilledColumn => this.columnNetBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmtPTDColumn => this.columnAmtPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SurplusColumn => this.columnSurplus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransactionColumn => this.columnTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow this[int index]
    {
      get => (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_QuoteInvoicesRow(dsPolicyInquiry.spFin_QuoteInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow AddspFin_QuoteInvoicesRow(
      int InvoiceNum,
      int OfficeInvoiceNum,
      DateTime InvoiceDate,
      DateTime DueDate,
      Decimal GrossPremium,
      Decimal Fees,
      Decimal NetBilled,
      Decimal AmtPTD,
      Decimal Surplus,
      string Transaction)
    {
      dsPolicyInquiry.spFin_QuoteInvoicesRow row = (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) InvoiceNum,
        (object) OfficeInvoiceNum,
        (object) InvoiceDate,
        (object) DueDate,
        (object) GrossPremium,
        (object) Fees,
        (object) NetBilled,
        (object) AmtPTD,
        (object) Surplus,
        (object) Transaction
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow FindByInvoiceNum(int InvoiceNum)
    {
      return (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.Rows.Find(new object[1]
      {
        (object) InvoiceNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_QuoteInvoicesDataTable invoicesDataTable = (dsPolicyInquiry.spFin_QuoteInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_QuoteInvoicesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnGrossPremium = this.Columns["GrossPremium"];
      this.columnFees = this.Columns["Fees"];
      this.columnNetBilled = this.Columns["NetBilled"];
      this.columnAmtPTD = this.Columns["AmtPTD"];
      this.columnSurplus = this.Columns["Surplus"];
      this.columnTransaction = this.Columns["Transaction"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnGrossPremium = new DataColumn("GrossPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossPremium);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnNetBilled = new DataColumn("NetBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetBilled);
      this.columnAmtPTD = new DataColumn("AmtPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTD);
      this.columnSurplus = new DataColumn("Surplus", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurplus);
      this.columnTransaction = new DataColumn("Transaction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransaction);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyInquiryKey1", new DataColumn[1]
      {
        this.columnInvoiceNum
      }, true));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnInvoiceNum.Unique = true;
      this.columnAmtPTD.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow NewspFin_QuoteInvoicesRow()
    {
      return (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_QuoteInvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_QuoteInvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_QuoteInvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler invoicesRowChangedEvent = this.spFin_QuoteInvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_QuoteInvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler rowChangingEvent = this.spFin_QuoteInvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_QuoteInvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.spFin_QuoteInvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_QuoteInvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler rowDeletingEvent = this.spFin_QuoteInvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_QuoteInvoicesRow(dsPolicyInquiry.spFin_QuoteInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_QuoteInvoicesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class spFin_InvoiceTransactionsDataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_InvoiceTransactionsRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnTransactNum;
    private DataColumn columnTransdescription;
    private DataColumn columnpostDate;
    private DataColumn columnuser;
    private DataColumn columnvoided;
    private DataColumn columnarapplied;
    private DataColumn columnapapplied;
    private DataColumn columnexchapplied;
    private DataColumn columnunacctapplied;
    private DataColumn columnincomeapplied;
    private DataColumn columncashapplied;
    private DataColumn columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_InvoiceTransactionsDataTable()
    {
      this.TableName = "spFin_InvoiceTransactions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_InvoiceTransactionsDataTable(DataTable table)
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
    protected spFin_InvoiceTransactionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransactNumColumn => this.columnTransactNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransdescriptionColumn => this.columnTransdescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn postDateColumn => this.columnpostDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn userColumn => this.columnuser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn voidedColumn => this.columnvoided;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn arappliedColumn => this.columnarapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn apappliedColumn => this.columnapapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn exchappliedColumn => this.columnexchapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn unacctappliedColumn => this.columnunacctapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn incomeappliedColumn => this.columnincomeapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn cashappliedColumn => this.columncashapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Check_NumberColumn => this.columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow this[int index]
    {
      get => (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_InvoiceTransactionsRow(dsPolicyInquiry.spFin_InvoiceTransactionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow AddspFin_InvoiceTransactionsRow(
      dsPolicyInquiry.spFin_QuoteInvoicesRow parentspFin_QuoteInvoicesRowByspFin_QuoteInvoicesspFin_InvoiceTransactions,
      string Transdescription,
      DateTime postDate,
      string user,
      bool voided,
      Decimal arapplied,
      Decimal apapplied,
      Decimal exchapplied,
      Decimal unacctapplied,
      Decimal incomeapplied,
      Decimal cashapplied,
      string Check_Number)
    {
      dsPolicyInquiry.spFin_InvoiceTransactionsRow row = (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.NewRow();
      object[] objArray = new object[13]
      {
        null,
        null,
        (object) Transdescription,
        (object) postDate,
        (object) user,
        (object) voided,
        (object) arapplied,
        (object) apapplied,
        (object) exchapplied,
        (object) unacctapplied,
        (object) incomeapplied,
        (object) cashapplied,
        (object) Check_Number
      };
      if (parentspFin_QuoteInvoicesRowByspFin_QuoteInvoicesspFin_InvoiceTransactions != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentspFin_QuoteInvoicesRowByspFin_QuoteInvoicesspFin_InvoiceTransactions[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow FindByInvoiceNumTransactNum(
      int InvoiceNum,
      int TransactNum)
    {
      return (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.Rows.Find(new object[2]
      {
        (object) InvoiceNum,
        (object) TransactNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_InvoiceTransactionsDataTable transactionsDataTable = (dsPolicyInquiry.spFin_InvoiceTransactionsDataTable) base.Clone();
      transactionsDataTable.InitVars();
      return (DataTable) transactionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnTransdescription = this.Columns["Transdescription"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnuser = this.Columns["user"];
      this.columnvoided = this.Columns["voided"];
      this.columnarapplied = this.Columns["arapplied"];
      this.columnapapplied = this.Columns["apapplied"];
      this.columnexchapplied = this.Columns["exchapplied"];
      this.columnunacctapplied = this.Columns["unacctapplied"];
      this.columnincomeapplied = this.Columns["incomeapplied"];
      this.columncashapplied = this.Columns["cashapplied"];
      this.columnCheck_Number = this.Columns["Check Number"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnTransdescription = new DataColumn("Transdescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransdescription);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnuser = new DataColumn("user", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnuser);
      this.columnvoided = new DataColumn("voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnvoided);
      this.columnarapplied = new DataColumn("arapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarapplied);
      this.columnapapplied = new DataColumn("apapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnapapplied);
      this.columnexchapplied = new DataColumn("exchapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexchapplied);
      this.columnunacctapplied = new DataColumn("unacctapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnunacctapplied);
      this.columnincomeapplied = new DataColumn("incomeapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnincomeapplied);
      this.columncashapplied = new DataColumn("cashapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columncashapplied);
      this.columnCheck_Number = new DataColumn("Check Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheck_Number);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyInquiryKey2", new DataColumn[2]
      {
        this.columnInvoiceNum,
        this.columnTransactNum
      }, true));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnTransactNum.AutoIncrement = true;
      this.columnTransactNum.AllowDBNull = false;
      this.columnTransactNum.ReadOnly = true;
      this.columnTransdescription.AllowDBNull = false;
      this.columnpostDate.AllowDBNull = false;
      this.columnuser.AllowDBNull = false;
      this.columnvoided.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow NewspFin_InvoiceTransactionsRow()
    {
      return (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_InvoiceTransactionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_InvoiceTransactionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_InvoiceTransactionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler transactionsRowChangedEvent = this.spFin_InvoiceTransactionsRowChangedEvent;
      if (transactionsRowChangedEvent == null)
        return;
      transactionsRowChangedEvent((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_InvoiceTransactionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler rowChangingEvent = this.spFin_InvoiceTransactionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_InvoiceTransactionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler transactionsRowDeletedEvent = this.spFin_InvoiceTransactionsRowDeletedEvent;
      if (transactionsRowDeletedEvent == null)
        return;
      transactionsRowDeletedEvent((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_InvoiceTransactionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler rowDeletingEvent = this.spFin_InvoiceTransactionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_InvoiceTransactionsRow(dsPolicyInquiry.spFin_InvoiceTransactionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_InvoiceTransactionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class spFin_PolicyARBreakdownDataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_PolicyARBreakdownRow>
  {
    private DataColumn columnInvoiceNumber;
    private DataColumn columnInvoiceNum;
    private DataColumn columnPremium;
    private DataColumn columnAIEndorsement;
    private DataColumn columnSurchargeFees;
    private DataColumn columnOtherFees;
    private DataColumn columnCommissionNetOut;
    private DataColumn columnDollarsReceived;
    private DataColumn columnWriteOffs;
    private DataColumn columnBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdownDataTable()
    {
      this.TableName = "spFin_PolicyARBreakdown";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdownDataTable(DataTable table)
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
    protected spFin_PolicyARBreakdownDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumberColumn => this.columnInvoiceNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AIEndorsementColumn => this.columnAIEndorsement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SurchargeFeesColumn => this.columnSurchargeFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherFeesColumn => this.columnOtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionNetOutColumn => this.columnCommissionNetOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DollarsReceivedColumn => this.columnDollarsReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WriteOffsColumn => this.columnWriteOffs;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BalanceColumn => this.columnBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdownRow this[int index]
    {
      get => (dsPolicyInquiry.spFin_PolicyARBreakdownRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler spFin_PolicyARBreakdownRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler spFin_PolicyARBreakdownRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler spFin_PolicyARBreakdownRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler spFin_PolicyARBreakdownRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_PolicyARBreakdownRow(dsPolicyInquiry.spFin_PolicyARBreakdownRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdownRow AddspFin_PolicyARBreakdownRow(
      int InvoiceNumber,
      int InvoiceNum,
      Decimal Premium,
      Decimal AIEndorsement,
      Decimal SurchargeFees,
      Decimal OtherFees,
      Decimal CommissionNetOut,
      Decimal DollarsReceived,
      Decimal WriteOffs,
      Decimal Balance)
    {
      dsPolicyInquiry.spFin_PolicyARBreakdownRow row = (dsPolicyInquiry.spFin_PolicyARBreakdownRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) InvoiceNumber,
        (object) InvoiceNum,
        (object) Premium,
        (object) AIEndorsement,
        (object) SurchargeFees,
        (object) OtherFees,
        (object) CommissionNetOut,
        (object) DollarsReceived,
        (object) WriteOffs,
        (object) Balance
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_PolicyARBreakdownDataTable breakdownDataTable = (dsPolicyInquiry.spFin_PolicyARBreakdownDataTable) base.Clone();
      breakdownDataTable.InitVars();
      return (DataTable) breakdownDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdownDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNumber = this.Columns["InvoiceNumber"];
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnPremium = this.Columns["Premium"];
      this.columnAIEndorsement = this.Columns["AIEndorsement"];
      this.columnSurchargeFees = this.Columns["SurchargeFees"];
      this.columnOtherFees = this.Columns["OtherFees"];
      this.columnCommissionNetOut = this.Columns["CommissionNetOut"];
      this.columnDollarsReceived = this.Columns["DollarsReceived"];
      this.columnWriteOffs = this.Columns["WriteOffs"];
      this.columnBalance = this.Columns["Balance"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNumber = new DataColumn("InvoiceNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNumber);
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnAIEndorsement = new DataColumn("AIEndorsement", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAIEndorsement);
      this.columnSurchargeFees = new DataColumn("SurchargeFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurchargeFees);
      this.columnOtherFees = new DataColumn("OtherFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherFees);
      this.columnCommissionNetOut = new DataColumn("CommissionNetOut", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionNetOut);
      this.columnDollarsReceived = new DataColumn("DollarsReceived", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarsReceived);
      this.columnWriteOffs = new DataColumn("WriteOffs", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWriteOffs);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
      this.columnBalance.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdownRow NewspFin_PolicyARBreakdownRow()
    {
      return (dsPolicyInquiry.spFin_PolicyARBreakdownRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_PolicyARBreakdownRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_PolicyARBreakdownRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdownRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler breakdownRowChangedEvent = this.spFin_PolicyARBreakdownRowChangedEvent;
      if (breakdownRowChangedEvent == null)
        return;
      breakdownRowChangedEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdownRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler rowChangingEvent = this.spFin_PolicyARBreakdownRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdownRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler breakdownRowDeletedEvent = this.spFin_PolicyARBreakdownRowDeletedEvent;
      if (breakdownRowDeletedEvent == null)
        return;
      breakdownRowDeletedEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdownRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEventHandler rowDeletingEvent = this.spFin_PolicyARBreakdownRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_PolicyARBreakdownRow(dsPolicyInquiry.spFin_PolicyARBreakdownRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_PolicyARBreakdownDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class spFin_PolicyARBreakdown_2DataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_PolicyARBreakdown_2Row>
  {
    private DataColumn columnDollarsReceived_Premium;
    private DataColumn columnDollarsReceived_AIEndorsement;
    private DataColumn columnDollarsReceived_SurchargeFees;
    private DataColumn columnDollarsReceived_OtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdown_2DataTable()
    {
      this.TableName = "spFin_PolicyARBreakdown_2";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdown_2DataTable(DataTable table)
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
    protected spFin_PolicyARBreakdown_2DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DollarsReceived_PremiumColumn => this.columnDollarsReceived_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DollarsReceived_AIEndorsementColumn
    {
      get => this.columnDollarsReceived_AIEndorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DollarsReceived_SurchargeFeesColumn
    {
      get => this.columnDollarsReceived_SurchargeFees;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DollarsReceived_OtherFeesColumn => this.columnDollarsReceived_OtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_2Row this[int index]
    {
      get => (dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler spFin_PolicyARBreakdown_2RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler spFin_PolicyARBreakdown_2RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler spFin_PolicyARBreakdown_2RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler spFin_PolicyARBreakdown_2RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_PolicyARBreakdown_2Row(dsPolicyInquiry.spFin_PolicyARBreakdown_2Row row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_2Row AddspFin_PolicyARBreakdown_2Row(
      Decimal DollarsReceived_Premium,
      Decimal DollarsReceived_AIEndorsement,
      Decimal DollarsReceived_SurchargeFees,
      Decimal DollarsReceived_OtherFees)
    {
      dsPolicyInquiry.spFin_PolicyARBreakdown_2Row row = (dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) DollarsReceived_Premium,
        (object) DollarsReceived_AIEndorsement,
        (object) DollarsReceived_SurchargeFees,
        (object) DollarsReceived_OtherFees
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable breakdown2DataTable = (dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable) base.Clone();
      breakdown2DataTable.InitVars();
      return (DataTable) breakdown2DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnDollarsReceived_Premium = this.Columns["DollarsReceived_Premium"];
      this.columnDollarsReceived_AIEndorsement = this.Columns["DollarsReceived_AIEndorsement"];
      this.columnDollarsReceived_SurchargeFees = this.Columns["DollarsReceived_SurchargeFees"];
      this.columnDollarsReceived_OtherFees = this.Columns["DollarsReceived_OtherFees"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnDollarsReceived_Premium = new DataColumn("DollarsReceived_Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarsReceived_Premium);
      this.columnDollarsReceived_AIEndorsement = new DataColumn("DollarsReceived_AIEndorsement", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarsReceived_AIEndorsement);
      this.columnDollarsReceived_SurchargeFees = new DataColumn("DollarsReceived_SurchargeFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarsReceived_SurchargeFees);
      this.columnDollarsReceived_OtherFees = new DataColumn("DollarsReceived_OtherFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarsReceived_OtherFees);
      this.columnDollarsReceived_AIEndorsement.Caption = "DollarsReceived_Premium";
      this.columnDollarsReceived_SurchargeFees.Caption = "DollarsReceived_Premium";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_2Row NewspFin_PolicyARBreakdown_2Row()
    {
      return (dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_PolicyARBreakdown_2Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_PolicyARBreakdown_2Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_2RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler changeEventHandler = this.spFin_PolicyARBreakdown_2RowChangedEvent;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_2RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler rowChangingEvent = this.spFin_PolicyARBreakdown_2RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_2RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler changeEventHandler = this.spFin_PolicyARBreakdown_2RowDeletedEvent;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_2RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEventHandler rowDeletingEvent = this.spFin_PolicyARBreakdown_2RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_2RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_PolicyARBreakdown_2Row(dsPolicyInquiry.spFin_PolicyARBreakdown_2Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_PolicyARBreakdown_2DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class spFin_PolicyARBreakdown_3DataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_PolicyARBreakdown_3Row>
  {
    private DataColumn columnWriteOffs_Premium;
    private DataColumn columnWriteOffs_AIEndorsement;
    private DataColumn columnWriteOffs_SurchargeFees;
    private DataColumn columnWriteOffs_OtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdown_3DataTable()
    {
      this.TableName = "spFin_PolicyARBreakdown_3";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdown_3DataTable(DataTable table)
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
    protected spFin_PolicyARBreakdown_3DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WriteOffs_PremiumColumn => this.columnWriteOffs_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WriteOffs_AIEndorsementColumn => this.columnWriteOffs_AIEndorsement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WriteOffs_SurchargeFeesColumn => this.columnWriteOffs_SurchargeFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WriteOffs_OtherFeesColumn => this.columnWriteOffs_OtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_3Row this[int index]
    {
      get => (dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler spFin_PolicyARBreakdown_3RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler spFin_PolicyARBreakdown_3RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler spFin_PolicyARBreakdown_3RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler spFin_PolicyARBreakdown_3RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_PolicyARBreakdown_3Row(dsPolicyInquiry.spFin_PolicyARBreakdown_3Row row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_3Row AddspFin_PolicyARBreakdown_3Row(
      Decimal WriteOffs_Premium,
      Decimal WriteOffs_AIEndorsement,
      Decimal WriteOffs_SurchargeFees,
      Decimal WriteOffs_OtherFees)
    {
      dsPolicyInquiry.spFin_PolicyARBreakdown_3Row row = (dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) WriteOffs_Premium,
        (object) WriteOffs_AIEndorsement,
        (object) WriteOffs_SurchargeFees,
        (object) WriteOffs_OtherFees
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable breakdown3DataTable = (dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable) base.Clone();
      breakdown3DataTable.InitVars();
      return (DataTable) breakdown3DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnWriteOffs_Premium = this.Columns["WriteOffs_Premium"];
      this.columnWriteOffs_AIEndorsement = this.Columns["WriteOffs_AIEndorsement"];
      this.columnWriteOffs_SurchargeFees = this.Columns["WriteOffs_SurchargeFees"];
      this.columnWriteOffs_OtherFees = this.Columns["WriteOffs_OtherFees"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnWriteOffs_Premium = new DataColumn("WriteOffs_Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWriteOffs_Premium);
      this.columnWriteOffs_AIEndorsement = new DataColumn("WriteOffs_AIEndorsement", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWriteOffs_AIEndorsement);
      this.columnWriteOffs_SurchargeFees = new DataColumn("WriteOffs_SurchargeFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWriteOffs_SurchargeFees);
      this.columnWriteOffs_OtherFees = new DataColumn("WriteOffs_OtherFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWriteOffs_OtherFees);
      this.columnWriteOffs_Premium.Caption = "DollarsReceived_Premium";
      this.columnWriteOffs_AIEndorsement.Caption = "DollarsReceived_Premium";
      this.columnWriteOffs_SurchargeFees.Caption = "DollarsReceived_Premium";
      this.columnWriteOffs_OtherFees.Caption = "DollarsReceived_OtherFees";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_3Row NewspFin_PolicyARBreakdown_3Row()
    {
      return (dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_PolicyARBreakdown_3Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_PolicyARBreakdown_3Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_3RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler changeEventHandler = this.spFin_PolicyARBreakdown_3RowChangedEvent;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_3RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler rowChangingEvent = this.spFin_PolicyARBreakdown_3RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_3RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler changeEventHandler = this.spFin_PolicyARBreakdown_3RowDeletedEvent;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_3RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEventHandler rowDeletingEvent = this.spFin_PolicyARBreakdown_3RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_3RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_PolicyARBreakdown_3Row(dsPolicyInquiry.spFin_PolicyARBreakdown_3Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_PolicyARBreakdown_3DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class spFin_PolicyARBreakdown_4DataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_PolicyARBreakdown_4Row>
  {
    private DataColumn columnCommissionNetOut_Premium;
    private DataColumn columnCommissionNetOut_AIEndorsement;
    private DataColumn columnCommissionNetOut_SurchargeFees;
    private DataColumn columnCommissionNetOut_OtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdown_4DataTable()
    {
      this.TableName = "spFin_PolicyARBreakdown_4";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdown_4DataTable(DataTable table)
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
    protected spFin_PolicyARBreakdown_4DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionNetOut_PremiumColumn => this.columnCommissionNetOut_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionNetOut_AIEndorsementColumn
    {
      get => this.columnCommissionNetOut_AIEndorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionNetOut_SurchargeFeesColumn
    {
      get => this.columnCommissionNetOut_SurchargeFees;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionNetOut_OtherFeesColumn => this.columnCommissionNetOut_OtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_4Row this[int index]
    {
      get => (dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler spFin_PolicyARBreakdown_4RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler spFin_PolicyARBreakdown_4RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler spFin_PolicyARBreakdown_4RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler spFin_PolicyARBreakdown_4RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_PolicyARBreakdown_4Row(dsPolicyInquiry.spFin_PolicyARBreakdown_4Row row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_4Row AddspFin_PolicyARBreakdown_4Row(
      Decimal CommissionNetOut_Premium,
      Decimal CommissionNetOut_AIEndorsement,
      Decimal CommissionNetOut_SurchargeFees,
      Decimal CommissionNetOut_OtherFees)
    {
      dsPolicyInquiry.spFin_PolicyARBreakdown_4Row row = (dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CommissionNetOut_Premium,
        (object) CommissionNetOut_AIEndorsement,
        (object) CommissionNetOut_SurchargeFees,
        (object) CommissionNetOut_OtherFees
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable breakdown4DataTable = (dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable) base.Clone();
      breakdown4DataTable.InitVars();
      return (DataTable) breakdown4DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCommissionNetOut_Premium = this.Columns["CommissionNetOut_Premium"];
      this.columnCommissionNetOut_AIEndorsement = this.Columns["CommissionNetOut_AIEndorsement"];
      this.columnCommissionNetOut_SurchargeFees = this.Columns["CommissionNetOut_SurchargeFees"];
      this.columnCommissionNetOut_OtherFees = this.Columns["CommissionNetOut_OtherFees"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCommissionNetOut_Premium = new DataColumn("CommissionNetOut_Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionNetOut_Premium);
      this.columnCommissionNetOut_AIEndorsement = new DataColumn("CommissionNetOut_AIEndorsement", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionNetOut_AIEndorsement);
      this.columnCommissionNetOut_SurchargeFees = new DataColumn("CommissionNetOut_SurchargeFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionNetOut_SurchargeFees);
      this.columnCommissionNetOut_OtherFees = new DataColumn("CommissionNetOut_OtherFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionNetOut_OtherFees);
      this.columnCommissionNetOut_Premium.Caption = "DollarsReceived_Premium";
      this.columnCommissionNetOut_AIEndorsement.Caption = "DollarsReceived_Premium";
      this.columnCommissionNetOut_SurchargeFees.Caption = "DollarsReceived_Premium";
      this.columnCommissionNetOut_OtherFees.Caption = "DollarsReceived_OtherFees";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_4Row NewspFin_PolicyARBreakdown_4Row()
    {
      return (dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_PolicyARBreakdown_4Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_PolicyARBreakdown_4Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_4RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler changeEventHandler = this.spFin_PolicyARBreakdown_4RowChangedEvent;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_4RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler rowChangingEvent = this.spFin_PolicyARBreakdown_4RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_4RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler changeEventHandler = this.spFin_PolicyARBreakdown_4RowDeletedEvent;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyARBreakdown_4RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEventHandler rowDeletingEvent = this.spFin_PolicyARBreakdown_4RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_PolicyARBreakdown_4RowChangeEvent((dsPolicyInquiry.spFin_PolicyARBreakdown_4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_PolicyARBreakdown_4Row(dsPolicyInquiry.spFin_PolicyARBreakdown_4Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_PolicyARBreakdown_4DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class SummariesDataTable : TypedTableBase<dsPolicyInquiry.SummariesRow>
  {
    private DataColumn columnDescription;
    private DataColumn columnPremium;
    private DataColumn columnAIEndorsement;
    private DataColumn columnSurchargeFees;
    private DataColumn columnOtherFees;
    private DataColumn columnCommissionNetOut;
    private DataColumn columnDollarsReceived;
    private DataColumn columnWriteOffs;
    private DataColumn columnBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public SummariesDataTable()
    {
      this.TableName = "Summaries";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SummariesDataTable(DataTable table)
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
    protected SummariesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AIEndorsementColumn => this.columnAIEndorsement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SurchargeFeesColumn => this.columnSurchargeFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherFeesColumn => this.columnOtherFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionNetOutColumn => this.columnCommissionNetOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DollarsReceivedColumn => this.columnDollarsReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WriteOffsColumn => this.columnWriteOffs;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BalanceColumn => this.columnBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.SummariesRow this[int index]
    {
      get => (dsPolicyInquiry.SummariesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.SummariesRowChangeEventHandler SummariesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.SummariesRowChangeEventHandler SummariesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.SummariesRowChangeEventHandler SummariesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.SummariesRowChangeEventHandler SummariesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddSummariesRow(dsPolicyInquiry.SummariesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.SummariesRow AddSummariesRow(
      string Description,
      Decimal Premium,
      Decimal AIEndorsement,
      Decimal SurchargeFees,
      Decimal OtherFees,
      Decimal CommissionNetOut,
      Decimal DollarsReceived,
      Decimal WriteOffs,
      Decimal Balance)
    {
      dsPolicyInquiry.SummariesRow row = (dsPolicyInquiry.SummariesRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) Description,
        (object) Premium,
        (object) AIEndorsement,
        (object) SurchargeFees,
        (object) OtherFees,
        (object) CommissionNetOut,
        (object) DollarsReceived,
        (object) WriteOffs,
        (object) Balance
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.SummariesDataTable summariesDataTable = (dsPolicyInquiry.SummariesDataTable) base.Clone();
      summariesDataTable.InitVars();
      return (DataTable) summariesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.SummariesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnDescription = this.Columns["Description"];
      this.columnPremium = this.Columns["Premium"];
      this.columnAIEndorsement = this.Columns["AIEndorsement"];
      this.columnSurchargeFees = this.Columns["SurchargeFees"];
      this.columnOtherFees = this.Columns["OtherFees"];
      this.columnCommissionNetOut = this.Columns["CommissionNetOut"];
      this.columnDollarsReceived = this.Columns["DollarsReceived"];
      this.columnWriteOffs = this.Columns["WriteOffs"];
      this.columnBalance = this.Columns["Balance"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnAIEndorsement = new DataColumn("AIEndorsement", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAIEndorsement);
      this.columnSurchargeFees = new DataColumn("SurchargeFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurchargeFees);
      this.columnOtherFees = new DataColumn("OtherFees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherFees);
      this.columnCommissionNetOut = new DataColumn("CommissionNetOut", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionNetOut);
      this.columnDollarsReceived = new DataColumn("DollarsReceived", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarsReceived);
      this.columnWriteOffs = new DataColumn("WriteOffs", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWriteOffs);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
      this.columnBalance.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.SummariesRow NewSummariesRow()
    {
      return (dsPolicyInquiry.SummariesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.SummariesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.SummariesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummariesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.SummariesRowChangeEventHandler summariesRowChangedEvent = this.SummariesRowChangedEvent;
      if (summariesRowChangedEvent == null)
        return;
      summariesRowChangedEvent((object) this, new dsPolicyInquiry.SummariesRowChangeEvent((dsPolicyInquiry.SummariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummariesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.SummariesRowChangeEventHandler rowChangingEvent = this.SummariesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.SummariesRowChangeEvent((dsPolicyInquiry.SummariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummariesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.SummariesRowChangeEventHandler summariesRowDeletedEvent = this.SummariesRowDeletedEvent;
      if (summariesRowDeletedEvent == null)
        return;
      summariesRowDeletedEvent((object) this, new dsPolicyInquiry.SummariesRowChangeEvent((dsPolicyInquiry.SummariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummariesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.SummariesRowChangeEventHandler rowDeletingEvent = this.SummariesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.SummariesRowChangeEvent((dsPolicyInquiry.SummariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveSummariesRow(dsPolicyInquiry.SummariesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SummariesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
  public class spFin_PolicyAPBreakdownDataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_PolicyAPBreakdownRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnRemitter;
    private DataColumn columnInvoice_Number;
    private DataColumn columnProducerLocationGuid;
    private DataColumn columnCompanyPayable_Premium;
    private DataColumn columnCompanyPayable_Fees;
    private DataColumn columnProducerPayable;
    private DataColumn columnMGAPayable_Commission;
    private DataColumn columnMGAPayable_Fees;
    private DataColumn columnExchangePayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyAPBreakdownDataTable()
    {
      this.TableName = "spFin_PolicyAPBreakdown";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyAPBreakdownDataTable(DataTable table)
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
    protected spFin_PolicyAPBreakdownDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RemitterColumn => this.columnRemitter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Invoice_NumberColumn => this.columnInvoice_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGuidColumn => this.columnProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyPayable_PremiumColumn => this.columnCompanyPayable_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyPayable_FeesColumn => this.columnCompanyPayable_Fees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerPayableColumn => this.columnProducerPayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MGAPayable_CommissionColumn => this.columnMGAPayable_Commission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MGAPayable_FeesColumn => this.columnMGAPayable_Fees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExchangePayableColumn => this.columnExchangePayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyAPBreakdownRow this[int index]
    {
      get => (dsPolicyInquiry.spFin_PolicyAPBreakdownRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler spFin_PolicyAPBreakdownRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler spFin_PolicyAPBreakdownRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler spFin_PolicyAPBreakdownRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler spFin_PolicyAPBreakdownRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddspFin_PolicyAPBreakdownRow(dsPolicyInquiry.spFin_PolicyAPBreakdownRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyAPBreakdownRow AddspFin_PolicyAPBreakdownRow(
      int InvoiceNum,
      string Remitter,
      int Invoice_Number,
      Guid ProducerLocationGuid,
      Decimal CompanyPayable_Premium,
      Decimal CompanyPayable_Fees,
      Decimal ProducerPayable,
      Decimal MGAPayable_Commission,
      Decimal MGAPayable_Fees,
      Decimal ExchangePayable)
    {
      dsPolicyInquiry.spFin_PolicyAPBreakdownRow row = (dsPolicyInquiry.spFin_PolicyAPBreakdownRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) InvoiceNum,
        (object) Remitter,
        (object) Invoice_Number,
        (object) ProducerLocationGuid,
        (object) CompanyPayable_Premium,
        (object) CompanyPayable_Fees,
        (object) ProducerPayable,
        (object) MGAPayable_Commission,
        (object) MGAPayable_Fees,
        (object) ExchangePayable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable breakdownDataTable = (dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable) base.Clone();
      breakdownDataTable.InitVars();
      return (DataTable) breakdownDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnInvoice_Number = this.Columns["Invoice Number"];
      this.columnProducerLocationGuid = this.Columns["ProducerLocationGuid"];
      this.columnCompanyPayable_Premium = this.Columns["CompanyPayable_Premium"];
      this.columnCompanyPayable_Fees = this.Columns["CompanyPayable_Fees"];
      this.columnProducerPayable = this.Columns["ProducerPayable"];
      this.columnMGAPayable_Commission = this.Columns["MGAPayable_Commission"];
      this.columnMGAPayable_Fees = this.Columns["MGAPayable_Fees"];
      this.columnExchangePayable = this.Columns["ExchangePayable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnInvoice_Number = new DataColumn("Invoice Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoice_Number);
      this.columnProducerLocationGuid = new DataColumn("ProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGuid);
      this.columnCompanyPayable_Premium = new DataColumn("CompanyPayable_Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyPayable_Premium);
      this.columnCompanyPayable_Fees = new DataColumn("CompanyPayable_Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyPayable_Fees);
      this.columnProducerPayable = new DataColumn("ProducerPayable", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPayable);
      this.columnMGAPayable_Commission = new DataColumn("MGAPayable_Commission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMGAPayable_Commission);
      this.columnMGAPayable_Fees = new DataColumn("MGAPayable_Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMGAPayable_Fees);
      this.columnExchangePayable = new DataColumn("ExchangePayable", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchangePayable);
      this.columnRemitter.MaxLength = 1;
      this.columnMGAPayable_Commission.Caption = "ATMPayable_Commission";
      this.columnMGAPayable_Fees.Caption = "ATMPayable_Fees";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyAPBreakdownRow NewspFin_PolicyAPBreakdownRow()
    {
      return (dsPolicyInquiry.spFin_PolicyAPBreakdownRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_PolicyAPBreakdownRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_PolicyAPBreakdownRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyAPBreakdownRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler breakdownRowChangedEvent = this.spFin_PolicyAPBreakdownRowChangedEvent;
      if (breakdownRowChangedEvent == null)
        return;
      breakdownRowChangedEvent((object) this, new dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyAPBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyAPBreakdownRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler rowChangingEvent = this.spFin_PolicyAPBreakdownRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyAPBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyAPBreakdownRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler breakdownRowDeletedEvent = this.spFin_PolicyAPBreakdownRowDeletedEvent;
      if (breakdownRowDeletedEvent == null)
        return;
      breakdownRowDeletedEvent((object) this, new dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyAPBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_PolicyAPBreakdownRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEventHandler rowDeletingEvent = this.spFin_PolicyAPBreakdownRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.spFin_PolicyAPBreakdownRowChangeEvent((dsPolicyInquiry.spFin_PolicyAPBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovespFin_PolicyAPBreakdownRow(dsPolicyInquiry.spFin_PolicyAPBreakdownRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
        FixedValue = dsPolicyInquiry.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_PolicyAPBreakdownDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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

  public class spFin_QuoteInvoicesRow : DataRow
  {
    private dsPolicyInquiry.spFin_QuoteInvoicesDataTable tablespFin_QuoteInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_QuoteInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_QuoteInvoices = (dsPolicyInquiry.spFin_QuoteInvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tablespFin_QuoteInvoices.InvoiceNumColumn]);
      set => this[this.tablespFin_QuoteInvoices.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeInvoiceNum' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablespFin_QuoteInvoices.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablespFin_QuoteInvoices.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal GrossPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_QuoteInvoices.GrossPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossPremium' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.GrossPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Fees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_QuoteInvoices.FeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fees' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal NetBilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_QuoteInvoices.NetBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetBilled' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.NetBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal AmtPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_QuoteInvoices.AmtPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtPTD' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.AmtPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Surplus
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_QuoteInvoices.SurplusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Surplus' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.SurplusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Transaction
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_QuoteInvoices.TransactionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Transaction' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.TransactionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfficeInvoiceNumNull()
    {
      this[this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceDateNull() => this.IsNull(this.tablespFin_QuoteInvoices.InvoiceDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tablespFin_QuoteInvoices.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tablespFin_QuoteInvoices.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tablespFin_QuoteInvoices.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGrossPremiumNull()
    {
      return this.IsNull(this.tablespFin_QuoteInvoices.GrossPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGrossPremiumNull()
    {
      this[this.tablespFin_QuoteInvoices.GrossPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFeesNull() => this.IsNull(this.tablespFin_QuoteInvoices.FeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFeesNull()
    {
      this[this.tablespFin_QuoteInvoices.FeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNetBilledNull() => this.IsNull(this.tablespFin_QuoteInvoices.NetBilledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNetBilledNull()
    {
      this[this.tablespFin_QuoteInvoices.NetBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAmtPTDNull() => this.IsNull(this.tablespFin_QuoteInvoices.AmtPTDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAmtPTDNull()
    {
      this[this.tablespFin_QuoteInvoices.AmtPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSurplusNull() => this.IsNull(this.tablespFin_QuoteInvoices.SurplusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSurplusNull()
    {
      this[this.tablespFin_QuoteInvoices.SurplusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTransactionNull() => this.IsNull(this.tablespFin_QuoteInvoices.TransactionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTransactionNull()
    {
      this[this.tablespFin_QuoteInvoices.TransactionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow[] GetspFin_InvoiceTransactionsRows()
    {
      return this.Table.ChildRelations["spFin_QuoteInvoicesspFin_InvoiceTransactions"] != null ? (dsPolicyInquiry.spFin_InvoiceTransactionsRow[]) this.GetChildRows(this.Table.ChildRelations["spFin_QuoteInvoicesspFin_InvoiceTransactions"]) : new dsPolicyInquiry.spFin_InvoiceTransactionsRow[0];
    }
  }

  public class spFin_InvoiceTransactionsRow : DataRow
  {
    private dsPolicyInquiry.spFin_InvoiceTransactionsDataTable tablespFin_InvoiceTransactions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_InvoiceTransactionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_InvoiceTransactions = (dsPolicyInquiry.spFin_InvoiceTransactionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tablespFin_InvoiceTransactions.InvoiceNumColumn]);
      set => this[this.tablespFin_InvoiceTransactions.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TransactNum
    {
      get => Conversions.ToInteger(this[this.tablespFin_InvoiceTransactions.TransactNumColumn]);
      set => this[this.tablespFin_InvoiceTransactions.TransactNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Transdescription
    {
      get => Conversions.ToString(this[this.tablespFin_InvoiceTransactions.TransdescriptionColumn]);
      set => this[this.tablespFin_InvoiceTransactions.TransdescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime postDate
    {
      get => Conversions.ToDate(this[this.tablespFin_InvoiceTransactions.postDateColumn]);
      set => this[this.tablespFin_InvoiceTransactions.postDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string user
    {
      get => Conversions.ToString(this[this.tablespFin_InvoiceTransactions.userColumn]);
      set => this[this.tablespFin_InvoiceTransactions.userColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool voided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablespFin_InvoiceTransactions.voidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'voided' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.voidedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal arapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_InvoiceTransactions.arappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'arapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.arappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal apapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_InvoiceTransactions.apappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'apapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.apappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal exchapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_InvoiceTransactions.exchappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'exchapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.exchappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal unacctapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_InvoiceTransactions.unacctappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'unacctapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.unacctappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal incomeapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_InvoiceTransactions.incomeappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'incomeapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.incomeappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal cashapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_InvoiceTransactions.cashappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'cashapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.cashappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Check_Number
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_InvoiceTransactions.Check_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Check Number' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.Check_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow spFin_QuoteInvoicesRow
    {
      get
      {
        return (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.GetParentRow(this.Table.ParentRelations["spFin_QuoteInvoicesspFin_InvoiceTransactions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["spFin_QuoteInvoicesspFin_InvoiceTransactions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsvoidedNull() => this.IsNull(this.tablespFin_InvoiceTransactions.voidedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetvoidedNull()
    {
      this[this.tablespFin_InvoiceTransactions.voidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsarappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.arappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetarappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.arappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsapappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.apappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetapappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.apappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsexchappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.exchappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetexchappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.exchappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsunacctappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.unacctappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetunacctappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.unacctappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsincomeappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.incomeappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetincomeappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.incomeappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IscashappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.cashappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetcashappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.cashappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCheck_NumberNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.Check_NumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCheck_NumberNull()
    {
      this[this.tablespFin_InvoiceTransactions.Check_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class spFin_PolicyARBreakdownRow : DataRow
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdownDataTable tablespFin_PolicyARBreakdown;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdownRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_PolicyARBreakdown = (dsPolicyInquiry.spFin_PolicyARBreakdownDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_PolicyARBreakdown.InvoiceNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceNumber' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.InvoiceNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_PolicyARBreakdown.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal AIEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.AIEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AIEndorsement' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.AIEndorsementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal SurchargeFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.SurchargeFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SurchargeFees' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.SurchargeFeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal OtherFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.OtherFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherFees' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.OtherFeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CommissionNetOut
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.CommissionNetOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionNetOut' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.CommissionNetOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DollarsReceived
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.DollarsReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarsReceived' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.DollarsReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal WriteOffs
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.WriteOffsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WriteOffs' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.WriteOffsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Balance' in table 'spFin_PolicyARBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown.BalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceNumberNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown.InvoiceNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceNumberNull()
    {
      this[this.tablespFin_PolicyARBreakdown.InvoiceNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceNumNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown.InvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tablespFin_PolicyARBreakdown.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tablespFin_PolicyARBreakdown.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tablespFin_PolicyARBreakdown.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAIEndorsementNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown.AIEndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAIEndorsementNull()
    {
      this[this.tablespFin_PolicyARBreakdown.AIEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSurchargeFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown.SurchargeFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSurchargeFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown.SurchargeFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOtherFeesNull() => this.IsNull(this.tablespFin_PolicyARBreakdown.OtherFeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOtherFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown.OtherFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionNetOutNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown.CommissionNetOutColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionNetOutNull()
    {
      this[this.tablespFin_PolicyARBreakdown.CommissionNetOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDollarsReceivedNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown.DollarsReceivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDollarsReceivedNull()
    {
      this[this.tablespFin_PolicyARBreakdown.DollarsReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWriteOffsNull() => this.IsNull(this.tablespFin_PolicyARBreakdown.WriteOffsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWriteOffsNull()
    {
      this[this.tablespFin_PolicyARBreakdown.WriteOffsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBalanceNull() => this.IsNull(this.tablespFin_PolicyARBreakdown.BalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBalanceNull()
    {
      this[this.tablespFin_PolicyARBreakdown.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class spFin_PolicyARBreakdown_2Row : DataRow
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable tablespFin_PolicyARBreakdown_2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdown_2Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_PolicyARBreakdown_2 = (dsPolicyInquiry.spFin_PolicyARBreakdown_2DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DollarsReceived_Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarsReceived_Premium' in table 'spFin_PolicyARBreakdown_2' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_PremiumColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DollarsReceived_AIEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_AIEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarsReceived_AIEndorsement' in table 'spFin_PolicyARBreakdown_2' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_AIEndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DollarsReceived_SurchargeFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_SurchargeFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarsReceived_SurchargeFees' in table 'spFin_PolicyARBreakdown_2' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_SurchargeFeesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DollarsReceived_OtherFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_OtherFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarsReceived_OtherFees' in table 'spFin_PolicyARBreakdown_2' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_OtherFeesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDollarsReceived_PremiumNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_2.DollarsReceived_PremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDollarsReceived_PremiumNull()
    {
      this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDollarsReceived_AIEndorsementNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_2.DollarsReceived_AIEndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDollarsReceived_AIEndorsementNull()
    {
      this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_AIEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDollarsReceived_SurchargeFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_2.DollarsReceived_SurchargeFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDollarsReceived_SurchargeFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_SurchargeFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDollarsReceived_OtherFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_2.DollarsReceived_OtherFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDollarsReceived_OtherFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown_2.DollarsReceived_OtherFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class spFin_PolicyARBreakdown_3Row : DataRow
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable tablespFin_PolicyARBreakdown_3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdown_3Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_PolicyARBreakdown_3 = (dsPolicyInquiry.spFin_PolicyARBreakdown_3DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal WriteOffs_Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WriteOffs_Premium' in table 'spFin_PolicyARBreakdown_3' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal WriteOffs_AIEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_AIEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WriteOffs_AIEndorsement' in table 'spFin_PolicyARBreakdown_3' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_AIEndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal WriteOffs_SurchargeFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_SurchargeFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WriteOffs_SurchargeFees' in table 'spFin_PolicyARBreakdown_3' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_SurchargeFeesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal WriteOffs_OtherFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_OtherFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WriteOffs_OtherFees' in table 'spFin_PolicyARBreakdown_3' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_OtherFeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWriteOffs_PremiumNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_3.WriteOffs_PremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWriteOffs_PremiumNull()
    {
      this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWriteOffs_AIEndorsementNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_3.WriteOffs_AIEndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWriteOffs_AIEndorsementNull()
    {
      this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_AIEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWriteOffs_SurchargeFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_3.WriteOffs_SurchargeFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWriteOffs_SurchargeFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_SurchargeFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWriteOffs_OtherFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_3.WriteOffs_OtherFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWriteOffs_OtherFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown_3.WriteOffs_OtherFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class spFin_PolicyARBreakdown_4Row : DataRow
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable tablespFin_PolicyARBreakdown_4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyARBreakdown_4Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_PolicyARBreakdown_4 = (dsPolicyInquiry.spFin_PolicyARBreakdown_4DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CommissionNetOut_Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionNetOut_Premium' in table 'spFin_PolicyARBreakdown_4' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_PremiumColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CommissionNetOut_AIEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_AIEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionNetOut_AIEndorsement' in table 'spFin_PolicyARBreakdown_4' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_AIEndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CommissionNetOut_SurchargeFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_SurchargeFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionNetOut_SurchargeFees' in table 'spFin_PolicyARBreakdown_4' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_SurchargeFeesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CommissionNetOut_OtherFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_OtherFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionNetOut_OtherFees' in table 'spFin_PolicyARBreakdown_4' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_OtherFeesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionNetOut_PremiumNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_PremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionNetOut_PremiumNull()
    {
      this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionNetOut_AIEndorsementNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_AIEndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionNetOut_AIEndorsementNull()
    {
      this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_AIEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionNetOut_SurchargeFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_SurchargeFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionNetOut_SurchargeFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_SurchargeFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionNetOut_OtherFeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_OtherFeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionNetOut_OtherFeesNull()
    {
      this[this.tablespFin_PolicyARBreakdown_4.CommissionNetOut_OtherFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class SummariesRow : DataRow
  {
    private dsPolicyInquiry.SummariesDataTable tableSummaries;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SummariesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSummaries = (dsPolicyInquiry.SummariesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSummaries.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal AIEndorsement
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.AIEndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AIEndorsement' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.AIEndorsementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal SurchargeFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.SurchargeFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SurchargeFees' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.SurchargeFeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal OtherFees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.OtherFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherFees' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.OtherFeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CommissionNetOut
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.CommissionNetOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionNetOut' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.CommissionNetOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DollarsReceived
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.DollarsReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarsReceived' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.DollarsReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal WriteOffs
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.WriteOffsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WriteOffs' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.WriteOffsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummaries.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Balance' in table 'Summaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummaries.BalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tableSummaries.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tableSummaries.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tableSummaries.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tableSummaries.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAIEndorsementNull() => this.IsNull(this.tableSummaries.AIEndorsementColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAIEndorsementNull()
    {
      this[this.tableSummaries.AIEndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSurchargeFeesNull() => this.IsNull(this.tableSummaries.SurchargeFeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSurchargeFeesNull()
    {
      this[this.tableSummaries.SurchargeFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOtherFeesNull() => this.IsNull(this.tableSummaries.OtherFeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOtherFeesNull()
    {
      this[this.tableSummaries.OtherFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionNetOutNull() => this.IsNull(this.tableSummaries.CommissionNetOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionNetOutNull()
    {
      this[this.tableSummaries.CommissionNetOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDollarsReceivedNull() => this.IsNull(this.tableSummaries.DollarsReceivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDollarsReceivedNull()
    {
      this[this.tableSummaries.DollarsReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWriteOffsNull() => this.IsNull(this.tableSummaries.WriteOffsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWriteOffsNull()
    {
      this[this.tableSummaries.WriteOffsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBalanceNull() => this.IsNull(this.tableSummaries.BalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBalanceNull()
    {
      this[this.tableSummaries.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class spFin_PolicyAPBreakdownRow : DataRow
  {
    private dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable tablespFin_PolicyAPBreakdown;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal spFin_PolicyAPBreakdownRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_PolicyAPBreakdown = (dsPolicyInquiry.spFin_PolicyAPBreakdownDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_PolicyAPBreakdown.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_PolicyAPBreakdown.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Remitter' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.RemitterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Invoice_Number
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_PolicyAPBreakdown.Invoice_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Invoice Number' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.Invoice_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablespFin_PolicyAPBreakdown.ProducerLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGuid' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.ProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CompanyPayable_Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyAPBreakdown.CompanyPayable_PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyPayable_Premium' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.CompanyPayable_PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CompanyPayable_Fees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyAPBreakdown.CompanyPayable_FeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyPayable_Fees' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.CompanyPayable_FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ProducerPayable
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyAPBreakdown.ProducerPayableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerPayable' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.ProducerPayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal MGAPayable_Commission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyAPBreakdown.MGAPayable_CommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MGAPayable_Commission' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.MGAPayable_CommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal MGAPayable_Fees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyAPBreakdown.MGAPayable_FeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MGAPayable_Fees' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.MGAPayable_FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ExchangePayable
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_PolicyAPBreakdown.ExchangePayableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchangePayable' in table 'spFin_PolicyAPBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_PolicyAPBreakdown.ExchangePayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceNumNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.InvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRemitterNull() => this.IsNull(this.tablespFin_PolicyAPBreakdown.RemitterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRemitterNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoice_NumberNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.Invoice_NumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoice_NumberNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.Invoice_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerLocationGuidNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.ProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerLocationGuidNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.ProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyPayable_PremiumNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.CompanyPayable_PremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyPayable_PremiumNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.CompanyPayable_PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyPayable_FeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.CompanyPayable_FeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyPayable_FeesNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.CompanyPayable_FeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerPayableNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.ProducerPayableColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerPayableNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.ProducerPayableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMGAPayable_CommissionNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.MGAPayable_CommissionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMGAPayable_CommissionNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.MGAPayable_CommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMGAPayable_FeesNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.MGAPayable_FeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMGAPayable_FeesNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.MGAPayable_FeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExchangePayableNull()
    {
      return this.IsNull(this.tablespFin_PolicyAPBreakdown.ExchangePayableColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExchangePayableNull()
    {
      this[this.tablespFin_PolicyAPBreakdown.ExchangePayableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_QuoteInvoicesRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_QuoteInvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_QuoteInvoicesRowChangeEvent(
      dsPolicyInquiry.spFin_QuoteInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_InvoiceTransactionsRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_InvoiceTransactionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_InvoiceTransactionsRowChangeEvent(
      dsPolicyInquiry.spFin_InvoiceTransactionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_PolicyARBreakdownRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdownRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdownRowChangeEvent(
      dsPolicyInquiry.spFin_PolicyARBreakdownRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdownRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_PolicyARBreakdown_2RowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdown_2Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdown_2RowChangeEvent(
      dsPolicyInquiry.spFin_PolicyARBreakdown_2Row row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_2Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_PolicyARBreakdown_3RowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdown_3Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdown_3RowChangeEvent(
      dsPolicyInquiry.spFin_PolicyARBreakdown_3Row row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_3Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_PolicyARBreakdown_4RowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_PolicyARBreakdown_4Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyARBreakdown_4RowChangeEvent(
      dsPolicyInquiry.spFin_PolicyARBreakdown_4Row row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyARBreakdown_4Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class SummariesRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.SummariesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public SummariesRowChangeEvent(dsPolicyInquiry.SummariesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.SummariesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class spFin_PolicyAPBreakdownRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_PolicyAPBreakdownRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public spFin_PolicyAPBreakdownRowChangeEvent(
      dsPolicyInquiry.spFin_PolicyAPBreakdownRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyInquiry.spFin_PolicyAPBreakdownRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
