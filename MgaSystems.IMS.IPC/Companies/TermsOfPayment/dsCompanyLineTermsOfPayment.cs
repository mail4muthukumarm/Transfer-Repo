// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.TermsOfPayment.dsCompanyLineTermsOfPayment
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.TermsOfPayment;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyLineTermsOfPayment")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLineTermsOfPayment : DataSet
{
  private dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable tabletblCompanyLineTermsOfPayment;
  private dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable tablelstPaymentMethods;
  private DataRelation relationlstPaymentMethodstblCompanyLineTermsOfPayment;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyLineTermsOfPayment()
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
  protected dsCompanyLineTermsOfPayment(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLineTermsOfPayment)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable(dataSet.Tables[nameof (tblCompanyLineTermsOfPayment)]));
        if (dataSet.Tables[nameof (lstPaymentMethods)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable(dataSet.Tables[nameof (lstPaymentMethods)]));
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
  public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable tblCompanyLineTermsOfPayment
  {
    get => this.tabletblCompanyLineTermsOfPayment;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable lstPaymentMethods
  {
    get => this.tablelstPaymentMethods;
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
    dsCompanyLineTermsOfPayment lineTermsOfPayment = (dsCompanyLineTermsOfPayment) base.Clone();
    lineTermsOfPayment.InitVars();
    lineTermsOfPayment.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) lineTermsOfPayment;
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
      if (dataSet.Tables["tblCompanyLineTermsOfPayment"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable(dataSet.Tables["tblCompanyLineTermsOfPayment"]));
      if (dataSet.Tables["lstPaymentMethods"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable(dataSet.Tables["lstPaymentMethods"]));
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
    this.tabletblCompanyLineTermsOfPayment = (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable) base.Tables["tblCompanyLineTermsOfPayment"];
    if (initTable && this.tabletblCompanyLineTermsOfPayment != null)
      this.tabletblCompanyLineTermsOfPayment.InitVars();
    this.tablelstPaymentMethods = (dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable) base.Tables["lstPaymentMethods"];
    if (initTable && this.tablelstPaymentMethods != null)
      this.tablelstPaymentMethods.InitVars();
    this.relationlstPaymentMethodstblCompanyLineTermsOfPayment = this.Relations["lstPaymentMethodstblCompanyLineTermsOfPayment"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLineTermsOfPayment);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyLineTermsOfPayment.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLineTermsOfPayment = new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineTermsOfPayment);
    this.tablelstPaymentMethods = new dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable();
    base.Tables.Add((DataTable) this.tablelstPaymentMethods);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstPaymentMethodstblCompanyLineTermsOfPayment", new DataColumn[1]
    {
      this.tablelstPaymentMethods.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineTermsOfPayment.PaymentMethodIDColumn
    });
    this.tabletblCompanyLineTermsOfPayment.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstPaymentMethodstblCompanyLineTermsOfPayment = new DataRelation("lstPaymentMethodstblCompanyLineTermsOfPayment", new DataColumn[1]
    {
      this.tablelstPaymentMethods.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineTermsOfPayment.PaymentMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstPaymentMethodstblCompanyLineTermsOfPayment);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLineTermsOfPayment() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstPaymentMethods() => false;

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
    dsCompanyLineTermsOfPayment lineTermsOfPayment = new dsCompanyLineTermsOfPayment();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = lineTermsOfPayment.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = lineTermsOfPayment.GetSchemaSerializable();
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
  public delegate void tblCompanyLineTermsOfPaymentRowChangeEventHandler(
    object sender,
    dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstPaymentMethodsRowChangeEventHandler(
    object sender,
    dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineTermsOfPaymentDataTable : 
    TypedTableBase<dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow>
  {
    private DataColumn columnPaymentTermsID;
    private DataColumn columnCompanyLineID;
    private DataColumn columnEffective;
    private DataColumn columnTermsOfPayment;
    private DataColumn columnPaymentMethodID;
    private DataColumn columnPaymentMeasuredFrom;
    private DataColumn columnPaymentDayOfMonth;
    private DataColumn columnProducerPaymentMeasuredFrom;
    private DataColumn columnProducerPaymentDayOfMonth;
    private DataColumn columnDefaultProducerTermsOfPayment;
    private DataColumn columnProducerPaymentMeasuredFrom_Endorsement;
    private DataColumn columnProducerPaymentDayOfMonth_Endorsement;
    private DataColumn columnDefaultProducerTermsOfPayment_Endorsement;
    private DataColumn columnCreditsTakenImmediatly;
    private DataColumn columnAcctCurrent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineTermsOfPaymentDataTable()
    {
      this.TableName = "tblCompanyLineTermsOfPayment";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineTermsOfPaymentDataTable(DataTable table)
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
    protected tblCompanyLineTermsOfPaymentDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PaymentTermsIDColumn => this.columnPaymentTermsID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TermsOfPaymentColumn => this.columnTermsOfPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PaymentMethodIDColumn => this.columnPaymentMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PaymentMeasuredFromColumn => this.columnPaymentMeasuredFrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PaymentDayOfMonthColumn => this.columnPaymentDayOfMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerPaymentMeasuredFromColumn => this.columnProducerPaymentMeasuredFrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerPaymentDayOfMonthColumn => this.columnProducerPaymentDayOfMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultProducerTermsOfPaymentColumn
    {
      get => this.columnDefaultProducerTermsOfPayment;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerPaymentMeasuredFrom_EndorsementColumn
    {
      get => this.columnProducerPaymentMeasuredFrom_Endorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerPaymentDayOfMonth_EndorsementColumn
    {
      get => this.columnProducerPaymentDayOfMonth_Endorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultProducerTermsOfPayment_EndorsementColumn
    {
      get => this.columnDefaultProducerTermsOfPayment_Endorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreditsTakenImmediatlyColumn => this.columnCreditsTakenImmediatly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AcctCurrentColumn => this.columnAcctCurrent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow this[int index]
    {
      get => (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLineTermsOfPaymentRow(
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow AddtblCompanyLineTermsOfPaymentRow(
      int CompanyLineID,
      DateTime Effective,
      short TermsOfPayment,
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRow parentlstPaymentMethodsRowBylstPaymentMethodstblCompanyLineTermsOfPayment,
      string PaymentMeasuredFrom,
      int PaymentDayOfMonth,
      string ProducerPaymentMeasuredFrom,
      int ProducerPaymentDayOfMonth,
      short DefaultProducerTermsOfPayment,
      string ProducerPaymentMeasuredFrom_Endorsement,
      int ProducerPaymentDayOfMonth_Endorsement,
      short DefaultProducerTermsOfPayment_Endorsement,
      bool CreditsTakenImmediatly,
      bool AcctCurrent)
    {
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow row = (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) this.NewRow();
      object[] objArray = new object[15]
      {
        null,
        (object) CompanyLineID,
        (object) Effective,
        (object) TermsOfPayment,
        null,
        (object) PaymentMeasuredFrom,
        (object) PaymentDayOfMonth,
        (object) ProducerPaymentMeasuredFrom,
        (object) ProducerPaymentDayOfMonth,
        (object) DefaultProducerTermsOfPayment,
        (object) ProducerPaymentMeasuredFrom_Endorsement,
        (object) ProducerPaymentDayOfMonth_Endorsement,
        (object) DefaultProducerTermsOfPayment_Endorsement,
        (object) CreditsTakenImmediatly,
        (object) AcctCurrent
      };
      if (parentlstPaymentMethodsRowBylstPaymentMethodstblCompanyLineTermsOfPayment != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parentlstPaymentMethodsRowBylstPaymentMethodstblCompanyLineTermsOfPayment[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow FindByPaymentTermsID(
      int PaymentTermsID)
    {
      return (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) this.Rows.Find(new object[1]
      {
        (object) PaymentTermsID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable paymentDataTable = (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable) base.Clone();
      paymentDataTable.InitVars();
      return (DataTable) paymentDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPaymentTermsID = this.Columns["PaymentTermsID"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnEffective = this.Columns["Effective"];
      this.columnTermsOfPayment = this.Columns["TermsOfPayment"];
      this.columnPaymentMethodID = this.Columns["PaymentMethodID"];
      this.columnPaymentMeasuredFrom = this.Columns["PaymentMeasuredFrom"];
      this.columnPaymentDayOfMonth = this.Columns["PaymentDayOfMonth"];
      this.columnProducerPaymentMeasuredFrom = this.Columns["ProducerPaymentMeasuredFrom"];
      this.columnProducerPaymentDayOfMonth = this.Columns["ProducerPaymentDayOfMonth"];
      this.columnDefaultProducerTermsOfPayment = this.Columns["DefaultProducerTermsOfPayment"];
      this.columnProducerPaymentMeasuredFrom_Endorsement = this.Columns["ProducerPaymentMeasuredFrom_Endorsement"];
      this.columnProducerPaymentDayOfMonth_Endorsement = this.Columns["ProducerPaymentDayOfMonth_Endorsement"];
      this.columnDefaultProducerTermsOfPayment_Endorsement = this.Columns["DefaultProducerTermsOfPayment_Endorsement"];
      this.columnCreditsTakenImmediatly = this.Columns["CreditsTakenImmediatly"];
      this.columnAcctCurrent = this.Columns["AcctCurrent"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPaymentTermsID = new DataColumn("PaymentTermsID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentTermsID);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnTermsOfPayment = new DataColumn("TermsOfPayment", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTermsOfPayment);
      this.columnPaymentMethodID = new DataColumn("PaymentMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentMethodID);
      this.columnPaymentMeasuredFrom = new DataColumn("PaymentMeasuredFrom", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentMeasuredFrom);
      this.columnPaymentDayOfMonth = new DataColumn("PaymentDayOfMonth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentDayOfMonth);
      this.columnProducerPaymentMeasuredFrom = new DataColumn("ProducerPaymentMeasuredFrom", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentMeasuredFrom);
      this.columnProducerPaymentDayOfMonth = new DataColumn("ProducerPaymentDayOfMonth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentDayOfMonth);
      this.columnDefaultProducerTermsOfPayment = new DataColumn("DefaultProducerTermsOfPayment", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultProducerTermsOfPayment);
      this.columnProducerPaymentMeasuredFrom_Endorsement = new DataColumn("ProducerPaymentMeasuredFrom_Endorsement", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentMeasuredFrom_Endorsement);
      this.columnProducerPaymentDayOfMonth_Endorsement = new DataColumn("ProducerPaymentDayOfMonth_Endorsement", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentDayOfMonth_Endorsement);
      this.columnDefaultProducerTermsOfPayment_Endorsement = new DataColumn("DefaultProducerTermsOfPayment_Endorsement", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultProducerTermsOfPayment_Endorsement);
      this.columnCreditsTakenImmediatly = new DataColumn("CreditsTakenImmediatly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreditsTakenImmediatly);
      this.columnAcctCurrent = new DataColumn("AcctCurrent", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAcctCurrent);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPaymentTermsID
      }, true));
      this.columnPaymentTermsID.AutoIncrement = true;
      this.columnPaymentTermsID.AllowDBNull = false;
      this.columnPaymentTermsID.ReadOnly = true;
      this.columnPaymentTermsID.Unique = true;
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnEffective.AllowDBNull = false;
      this.columnPaymentMeasuredFrom.AllowDBNull = false;
      this.columnPaymentMeasuredFrom.DefaultValue = (object) "M";
      this.columnProducerPaymentMeasuredFrom.AllowDBNull = false;
      this.columnProducerPaymentMeasuredFrom.DefaultValue = (object) "M";
      this.columnProducerPaymentMeasuredFrom_Endorsement.AllowDBNull = false;
      this.columnProducerPaymentMeasuredFrom_Endorsement.DefaultValue = (object) "M";
      this.columnCreditsTakenImmediatly.AllowDBNull = false;
      this.columnCreditsTakenImmediatly.DefaultValue = (object) false;
      this.columnAcctCurrent.AllowDBNull = false;
      this.columnAcctCurrent.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow NewtblCompanyLineTermsOfPaymentRow()
    {
      return (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineTermsOfPaymentRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler paymentRowChangedEvent = this.tblCompanyLineTermsOfPaymentRowChangedEvent;
      if (paymentRowChangedEvent == null)
        return;
      paymentRowChangedEvent((object) this, new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineTermsOfPaymentRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler rowChangingEvent = this.tblCompanyLineTermsOfPaymentRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineTermsOfPaymentRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler paymentRowDeletedEvent = this.tblCompanyLineTermsOfPaymentRowDeletedEvent;
      if (paymentRowDeletedEvent == null)
        return;
      paymentRowDeletedEvent((object) this, new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineTermsOfPaymentRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineTermsOfPaymentRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLineTermsOfPaymentRow(
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineTermsOfPayment lineTermsOfPayment = new dsCompanyLineTermsOfPayment();
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
        FixedValue = lineTermsOfPayment.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineTermsOfPaymentDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = lineTermsOfPayment.GetSchemaSerializable();
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
  public class lstPaymentMethodsDataTable : 
    TypedTableBase<dsCompanyLineTermsOfPayment.lstPaymentMethodsRow>
  {
    private DataColumn columnID;
    private DataColumn columnPaymentMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstPaymentMethodsDataTable()
    {
      this.TableName = "lstPaymentMethods";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstPaymentMethodsDataTable(DataTable table)
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
    protected lstPaymentMethodsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PaymentMethodColumn => this.columnPaymentMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.lstPaymentMethodsRow this[int index]
    {
      get => (dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstPaymentMethodsRow(
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.lstPaymentMethodsRow AddlstPaymentMethodsRow(
      int ID,
      string PaymentMethod)
    {
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRow row = (dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) PaymentMethod
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.lstPaymentMethodsRow FindByID(int ID)
    {
      return (dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable methodsDataTable = (dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable) base.Clone();
      methodsDataTable.InitVars();
      return (DataTable) methodsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPaymentMethod = this.Columns["PaymentMethod"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPaymentMethod = new DataColumn("PaymentMethod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentMethod);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnPaymentMethod.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.lstPaymentMethodsRow NewlstPaymentMethodsRow()
    {
      return (dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineTermsOfPayment.lstPaymentMethodsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineTermsOfPayment.lstPaymentMethodsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler methodsRowChangedEvent = this.lstPaymentMethodsRowChangedEvent;
      if (methodsRowChangedEvent == null)
        return;
      methodsRowChangedEvent((object) this, new dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEvent((dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler rowChangingEvent = this.lstPaymentMethodsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEvent((dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler methodsRowDeletedEvent = this.lstPaymentMethodsRowDeletedEvent;
      if (methodsRowDeletedEvent == null)
        return;
      methodsRowDeletedEvent((object) this, new dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEvent((dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEventHandler rowDeletingEvent = this.lstPaymentMethodsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineTermsOfPayment.lstPaymentMethodsRowChangeEvent((dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstPaymentMethodsRow(
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineTermsOfPayment lineTermsOfPayment = new dsCompanyLineTermsOfPayment();
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
        FixedValue = lineTermsOfPayment.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPaymentMethodsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = lineTermsOfPayment.GetSchemaSerializable();
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

  public class tblCompanyLineTermsOfPaymentRow : DataRow
  {
    private dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable tabletblCompanyLineTermsOfPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineTermsOfPaymentRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineTermsOfPayment = (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PaymentTermsID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineTermsOfPayment.PaymentTermsIDColumn]);
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.PaymentTermsIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineTermsOfPayment.CompanyLineIDColumn]);
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Effective
    {
      get => Conversions.ToDate(this[this.tabletblCompanyLineTermsOfPayment.EffectiveColumn]);
      set => this[this.tabletblCompanyLineTermsOfPayment.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short TermsOfPayment
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblCompanyLineTermsOfPayment.TermsOfPaymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TermsOfPayment' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.TermsOfPaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PaymentMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineTermsOfPayment.PaymentMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PaymentMethodID' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.PaymentMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PaymentMeasuredFrom
    {
      get
      {
        return Conversions.ToString(this[this.tabletblCompanyLineTermsOfPayment.PaymentMeasuredFromColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.PaymentMeasuredFromColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PaymentDayOfMonth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineTermsOfPayment.PaymentDayOfMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PaymentDayOfMonth' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.PaymentDayOfMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerPaymentMeasuredFrom
    {
      get
      {
        return Conversions.ToString(this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFromColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFromColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ProducerPaymentDayOfMonth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerPaymentDayOfMonth' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short DefaultProducerTermsOfPayment
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultProducerTermsOfPayment' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerPaymentMeasuredFrom_Endorsement
    {
      get
      {
        return Conversions.ToString(this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFrom_EndorsementColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFrom_EndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ProducerPaymentDayOfMonth_Endorsement
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerPaymentDayOfMonth_Endorsement' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short DefaultProducerTermsOfPayment_Endorsement
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultProducerTermsOfPayment_Endorsement' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool CreditsTakenImmediatly
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineTermsOfPayment.CreditsTakenImmediatlyColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.CreditsTakenImmediatlyColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool AcctCurrent
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyLineTermsOfPayment.AcctCurrentColumn]);
      set => this[this.tabletblCompanyLineTermsOfPayment.AcctCurrentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.lstPaymentMethodsRow lstPaymentMethodsRow
    {
      get
      {
        return (dsCompanyLineTermsOfPayment.lstPaymentMethodsRow) this.GetParentRow(this.Table.ParentRelations["lstPaymentMethodstblCompanyLineTermsOfPayment"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstPaymentMethodstblCompanyLineTermsOfPayment"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTermsOfPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.TermsOfPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTermsOfPaymentNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.TermsOfPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPaymentMethodIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.PaymentMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPaymentMethodIDNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.PaymentMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPaymentDayOfMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.PaymentDayOfMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPaymentDayOfMonthNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.PaymentDayOfMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerPaymentDayOfMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerPaymentDayOfMonthNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDefaultProducerTermsOfPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDefaultProducerTermsOfPaymentNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerPaymentDayOfMonth_EndorsementNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerPaymentDayOfMonth_EndorsementNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDefaultProducerTermsOfPayment_EndorsementNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDefaultProducerTermsOfPayment_EndorsementNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstPaymentMethodsRow : DataRow
  {
    private dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable tablelstPaymentMethods;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstPaymentMethodsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPaymentMethods = (dsCompanyLineTermsOfPayment.lstPaymentMethodsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPaymentMethods.IDColumn]);
      set => this[this.tablelstPaymentMethods.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PaymentMethod
    {
      get => Conversions.ToString(this[this.tablelstPaymentMethods.PaymentMethodColumn]);
      set => this[this.tablelstPaymentMethods.PaymentMethodColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow[] GettblCompanyLineTermsOfPaymentRows()
    {
      return this.Table.ChildRelations["lstPaymentMethodstblCompanyLineTermsOfPayment"] != null ? (dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow[]) this.GetChildRows(this.Table.ChildRelations["lstPaymentMethodstblCompanyLineTermsOfPayment"]) : new dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLineTermsOfPaymentRowChangeEvent : EventArgs
  {
    private dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineTermsOfPaymentRowChangeEvent(
      dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.tblCompanyLineTermsOfPaymentRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstPaymentMethodsRowChangeEvent : EventArgs
  {
    private dsCompanyLineTermsOfPayment.lstPaymentMethodsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstPaymentMethodsRowChangeEvent(
      dsCompanyLineTermsOfPayment.lstPaymentMethodsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineTermsOfPayment.lstPaymentMethodsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
