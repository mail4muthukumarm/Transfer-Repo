// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Crime.dsCrime
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
namespace MGASystems.IMS.Policies.Rating.Crime;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCrime")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCrime : DataSet
{
  private dsCrime.tblQuoteOptionCrimeDataTable tabletblQuoteOptionCrime;
  private dsCrime.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsCrime.tblQuoteOptionCrime_SublimitsDataTable tabletblQuoteOptionCrime_Sublimits;
  private dsCrime.lstSubLimitsDataTable tablelstSubLimits;
  private DataRelation relationtblQuoteOptionstblQuoteOptionCrime;
  private DataRelation relationtblQuoteOptionCrimetblQuoteOptionCrime_Sublimits;
  private DataRelation relationlstSubLimitstblQuoteOptionCrime_Sublimits;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCrime()
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
  protected dsCrime(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteOptionCrime)] != null)
          base.Tables.Add((DataTable) new dsCrime.tblQuoteOptionCrimeDataTable(dataSet.Tables[nameof (tblQuoteOptionCrime)]));
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsCrime.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (tblQuoteOptionCrime_Sublimits)] != null)
          base.Tables.Add((DataTable) new dsCrime.tblQuoteOptionCrime_SublimitsDataTable(dataSet.Tables[nameof (tblQuoteOptionCrime_Sublimits)]));
        if (dataSet.Tables[nameof (lstSubLimits)] != null)
          base.Tables.Add((DataTable) new dsCrime.lstSubLimitsDataTable(dataSet.Tables[nameof (lstSubLimits)]));
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
  public dsCrime.tblQuoteOptionCrimeDataTable tblQuoteOptionCrime => this.tabletblQuoteOptionCrime;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCrime.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCrime.tblQuoteOptionCrime_SublimitsDataTable tblQuoteOptionCrime_Sublimits
  {
    get => this.tabletblQuoteOptionCrime_Sublimits;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCrime.lstSubLimitsDataTable lstSubLimits => this.tablelstSubLimits;

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
    dsCrime dsCrime = (dsCrime) base.Clone();
    dsCrime.InitVars();
    dsCrime.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCrime;
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
      if (dataSet.Tables["tblQuoteOptionCrime"] != null)
        base.Tables.Add((DataTable) new dsCrime.tblQuoteOptionCrimeDataTable(dataSet.Tables["tblQuoteOptionCrime"]));
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsCrime.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["tblQuoteOptionCrime_Sublimits"] != null)
        base.Tables.Add((DataTable) new dsCrime.tblQuoteOptionCrime_SublimitsDataTable(dataSet.Tables["tblQuoteOptionCrime_Sublimits"]));
      if (dataSet.Tables["lstSubLimits"] != null)
        base.Tables.Add((DataTable) new dsCrime.lstSubLimitsDataTable(dataSet.Tables["lstSubLimits"]));
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
    this.tabletblQuoteOptionCrime = (dsCrime.tblQuoteOptionCrimeDataTable) base.Tables["tblQuoteOptionCrime"];
    if (initTable && this.tabletblQuoteOptionCrime != null)
      this.tabletblQuoteOptionCrime.InitVars();
    this.tabletblQuoteOptions = (dsCrime.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tabletblQuoteOptionCrime_Sublimits = (dsCrime.tblQuoteOptionCrime_SublimitsDataTable) base.Tables["tblQuoteOptionCrime_Sublimits"];
    if (initTable && this.tabletblQuoteOptionCrime_Sublimits != null)
      this.tabletblQuoteOptionCrime_Sublimits.InitVars();
    this.tablelstSubLimits = (dsCrime.lstSubLimitsDataTable) base.Tables["lstSubLimits"];
    if (initTable && this.tablelstSubLimits != null)
      this.tablelstSubLimits.InitVars();
    this.relationtblQuoteOptionstblQuoteOptionCrime = this.Relations["tblQuoteOptionstblQuoteOptionCrime"];
    this.relationtblQuoteOptionCrimetblQuoteOptionCrime_Sublimits = this.Relations["tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits"];
    this.relationlstSubLimitstblQuoteOptionCrime_Sublimits = this.Relations["lstSubLimitstblQuoteOptionCrime_Sublimits"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCrime);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCrime.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteOptionCrime = new dsCrime.tblQuoteOptionCrimeDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionCrime);
    this.tabletblQuoteOptions = new dsCrime.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tabletblQuoteOptionCrime_Sublimits = new dsCrime.tblQuoteOptionCrime_SublimitsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionCrime_Sublimits);
    this.tablelstSubLimits = new dsCrime.lstSubLimitsDataTable();
    base.Tables.Add((DataTable) this.tablelstSubLimits);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblQuoteOptionstblQuoteOptionCrime", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime.QuoteOptionIDColumn
    });
    this.tabletblQuoteOptionCrime.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits", new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime_Sublimits.CrimeOptionIDColumn
    });
    this.tabletblQuoteOptionCrime_Sublimits.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstSubLimitstblQuoteOptionCrime_Sublimits", new DataColumn[1]
    {
      this.tablelstSubLimits.SubLimitIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime_Sublimits.SubLimitIDColumn
    });
    this.tabletblQuoteOptionCrime_Sublimits.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationtblQuoteOptionstblQuoteOptionCrime = new DataRelation("tblQuoteOptionstblQuoteOptionCrime", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime.QuoteOptionIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionstblQuoteOptionCrime);
    this.relationtblQuoteOptionCrimetblQuoteOptionCrime_Sublimits = new DataRelation("tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits", new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime_Sublimits.CrimeOptionIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionCrimetblQuoteOptionCrime_Sublimits);
    this.relationlstSubLimitstblQuoteOptionCrime_Sublimits = new DataRelation("lstSubLimitstblQuoteOptionCrime_Sublimits", new DataColumn[1]
    {
      this.tablelstSubLimits.SubLimitIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCrime_Sublimits.SubLimitIDColumn
    }, false);
    this.Relations.Add(this.relationlstSubLimitstblQuoteOptionCrime_Sublimits);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptionCrime() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptionCrime_Sublimits() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstSubLimits() => false;

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
    dsCrime dsCrime = new dsCrime();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCrime.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCrime.GetSchemaSerializable();
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
  public delegate void tblQuoteOptionCrimeRowChangeEventHandler(
    object sender,
    dsCrime.tblQuoteOptionCrimeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsCrime.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionCrime_SublimitsRowChangeEventHandler(
    object sender,
    dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstSubLimitsRowChangeEventHandler(
    object sender,
    dsCrime.lstSubLimitsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteOptionCrimeDataTable : TypedTableBase<dsCrime.tblQuoteOptionCrimeRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnTerrorismDeclined;
    private DataColumn columnEmployeeTheftLimit;
    private DataColumn columnEmployeeTheftDed;
    private DataColumn columnEmployeeTheftPrem;
    private DataColumn columnForgeryLimit;
    private DataColumn columnForgeryDed;
    private DataColumn columnForgeryPrem;
    private DataColumn columnMoneyInsideLimit;
    private DataColumn columnMoneyInsideDed;
    private DataColumn columnMoneyInsidePrem;
    private DataColumn columnSafeInsideLimit;
    private DataColumn columnSafeInsideDed;
    private DataColumn columnSafeInsidePrem;
    private DataColumn columnTheftOutsideLimit;
    private DataColumn columnTheftOutsideDed;
    private DataColumn columnTheftOutsidePrem;
    private DataColumn columnComputerFraudLimit;
    private DataColumn columnComputerFraudDed;
    private DataColumn columnComputerFraudPrem;
    private DataColumn columnFundTransferLimit;
    private DataColumn columnFundTransferDed;
    private DataColumn columnFundTransferPrem;
    private DataColumn columnCounterfeitLimit;
    private DataColumn columnCounterfeitDed;
    private DataColumn columnCounterfeitPrem;
    private DataColumn columnTotalPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnAdditionalComments;
    private DataColumn columnRate;
    private DataColumn columnEffectiveDate;
    private DataColumn columnFactor;
    private DataColumn columnUserOverrideFactor;
    private DataColumn columnEndorsementCalcType;
    private DataColumn columnPriorRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionCrimeDataTable()
    {
      this.TableName = "tblQuoteOptionCrime";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionCrimeDataTable(DataTable table)
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
    protected tblQuoteOptionCrimeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismDeclinedColumn => this.columnTerrorismDeclined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmployeeTheftLimitColumn => this.columnEmployeeTheftLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmployeeTheftDedColumn => this.columnEmployeeTheftDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmployeeTheftPremColumn => this.columnEmployeeTheftPrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ForgeryLimitColumn => this.columnForgeryLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ForgeryDedColumn => this.columnForgeryDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ForgeryPremColumn => this.columnForgeryPrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MoneyInsideLimitColumn => this.columnMoneyInsideLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MoneyInsideDedColumn => this.columnMoneyInsideDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MoneyInsidePremColumn => this.columnMoneyInsidePrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SafeInsideLimitColumn => this.columnSafeInsideLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SafeInsideDedColumn => this.columnSafeInsideDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SafeInsidePremColumn => this.columnSafeInsidePrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TheftOutsideLimitColumn => this.columnTheftOutsideLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TheftOutsideDedColumn => this.columnTheftOutsideDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TheftOutsidePremColumn => this.columnTheftOutsidePrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ComputerFraudLimitColumn => this.columnComputerFraudLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ComputerFraudDedColumn => this.columnComputerFraudDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ComputerFraudPremColumn => this.columnComputerFraudPrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FundTransferLimitColumn => this.columnFundTransferLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FundTransferDedColumn => this.columnFundTransferDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FundTransferPremColumn => this.columnFundTransferPrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CounterfeitLimitColumn => this.columnCounterfeitLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CounterfeitDedColumn => this.columnCounterfeitDed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CounterfeitPremColumn => this.columnCounterfeitPrem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TotalPremiumColumn => this.columnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrPremiumColumn => this.columnTerrPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RateColumn => this.columnRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserOverrideFactorColumn => this.columnUserOverrideFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PriorRateColumn => this.columnPriorRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow this[int index]
    {
      get => (dsCrime.tblQuoteOptionCrimeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrimeRowChangeEventHandler tblQuoteOptionCrimeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrimeRowChangeEventHandler tblQuoteOptionCrimeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrimeRowChangeEventHandler tblQuoteOptionCrimeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrimeRowChangeEventHandler tblQuoteOptionCrimeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionCrimeRow(dsCrime.tblQuoteOptionCrimeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow AddtblQuoteOptionCrimeRow(
      dsCrime.tblQuoteOptionsRow parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionCrime,
      bool TerrorismDeclined,
      Decimal EmployeeTheftLimit,
      Decimal EmployeeTheftDed,
      Decimal EmployeeTheftPrem,
      Decimal ForgeryLimit,
      Decimal ForgeryDed,
      Decimal ForgeryPrem,
      Decimal MoneyInsideLimit,
      Decimal MoneyInsideDed,
      Decimal MoneyInsidePrem,
      Decimal SafeInsideLimit,
      Decimal SafeInsideDed,
      Decimal SafeInsidePrem,
      Decimal TheftOutsideLimit,
      Decimal TheftOutsideDed,
      Decimal TheftOutsidePrem,
      Decimal ComputerFraudLimit,
      Decimal ComputerFraudDed,
      Decimal ComputerFraudPrem,
      Decimal FundTransferLimit,
      Decimal FundTransferDed,
      Decimal FundTransferPrem,
      Decimal CounterfeitLimit,
      Decimal CounterfeitDed,
      Decimal CounterfeitPrem,
      Decimal TotalPremium,
      Decimal TerrPremium,
      string AdditionalComments,
      Decimal Rate,
      DateTime EffectiveDate,
      Decimal Factor,
      Decimal UserOverrideFactor,
      string EndorsementCalcType,
      Decimal PriorRate)
    {
      dsCrime.tblQuoteOptionCrimeRow row = (dsCrime.tblQuoteOptionCrimeRow) this.NewRow();
      object[] objArray = new object[36]
      {
        null,
        null,
        (object) TerrorismDeclined,
        (object) EmployeeTheftLimit,
        (object) EmployeeTheftDed,
        (object) EmployeeTheftPrem,
        (object) ForgeryLimit,
        (object) ForgeryDed,
        (object) ForgeryPrem,
        (object) MoneyInsideLimit,
        (object) MoneyInsideDed,
        (object) MoneyInsidePrem,
        (object) SafeInsideLimit,
        (object) SafeInsideDed,
        (object) SafeInsidePrem,
        (object) TheftOutsideLimit,
        (object) TheftOutsideDed,
        (object) TheftOutsidePrem,
        (object) ComputerFraudLimit,
        (object) ComputerFraudDed,
        (object) ComputerFraudPrem,
        (object) FundTransferLimit,
        (object) FundTransferDed,
        (object) FundTransferPrem,
        (object) CounterfeitLimit,
        (object) CounterfeitDed,
        (object) CounterfeitPrem,
        (object) TotalPremium,
        (object) TerrPremium,
        (object) AdditionalComments,
        (object) Rate,
        (object) EffectiveDate,
        (object) Factor,
        (object) UserOverrideFactor,
        (object) EndorsementCalcType,
        (object) PriorRate
      };
      if (parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionCrime != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionCrime[4]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow FindByID(int ID)
    {
      return (dsCrime.tblQuoteOptionCrimeRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCrime.tblQuoteOptionCrimeDataTable optionCrimeDataTable = (dsCrime.tblQuoteOptionCrimeDataTable) base.Clone();
      optionCrimeDataTable.InitVars();
      return (DataTable) optionCrimeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCrime.tblQuoteOptionCrimeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnTerrorismDeclined = this.Columns["TerrorismDeclined"];
      this.columnEmployeeTheftLimit = this.Columns["EmployeeTheftLimit"];
      this.columnEmployeeTheftDed = this.Columns["EmployeeTheftDed"];
      this.columnEmployeeTheftPrem = this.Columns["EmployeeTheftPrem"];
      this.columnForgeryLimit = this.Columns["ForgeryLimit"];
      this.columnForgeryDed = this.Columns["ForgeryDed"];
      this.columnForgeryPrem = this.Columns["ForgeryPrem"];
      this.columnMoneyInsideLimit = this.Columns["MoneyInsideLimit"];
      this.columnMoneyInsideDed = this.Columns["MoneyInsideDed"];
      this.columnMoneyInsidePrem = this.Columns["MoneyInsidePrem"];
      this.columnSafeInsideLimit = this.Columns["SafeInsideLimit"];
      this.columnSafeInsideDed = this.Columns["SafeInsideDed"];
      this.columnSafeInsidePrem = this.Columns["SafeInsidePrem"];
      this.columnTheftOutsideLimit = this.Columns["TheftOutsideLimit"];
      this.columnTheftOutsideDed = this.Columns["TheftOutsideDed"];
      this.columnTheftOutsidePrem = this.Columns["TheftOutsidePrem"];
      this.columnComputerFraudLimit = this.Columns["ComputerFraudLimit"];
      this.columnComputerFraudDed = this.Columns["ComputerFraudDed"];
      this.columnComputerFraudPrem = this.Columns["ComputerFraudPrem"];
      this.columnFundTransferLimit = this.Columns["FundTransferLimit"];
      this.columnFundTransferDed = this.Columns["FundTransferDed"];
      this.columnFundTransferPrem = this.Columns["FundTransferPrem"];
      this.columnCounterfeitLimit = this.Columns["CounterfeitLimit"];
      this.columnCounterfeitDed = this.Columns["CounterfeitDed"];
      this.columnCounterfeitPrem = this.Columns["CounterfeitPrem"];
      this.columnTotalPremium = this.Columns["TotalPremium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
      this.columnRate = this.Columns["Rate"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnFactor = this.Columns["Factor"];
      this.columnUserOverrideFactor = this.Columns["UserOverrideFactor"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
      this.columnPriorRate = this.Columns["PriorRate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnTerrorismDeclined = new DataColumn("TerrorismDeclined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismDeclined);
      this.columnEmployeeTheftLimit = new DataColumn("EmployeeTheftLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmployeeTheftLimit);
      this.columnEmployeeTheftDed = new DataColumn("EmployeeTheftDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmployeeTheftDed);
      this.columnEmployeeTheftPrem = new DataColumn("EmployeeTheftPrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmployeeTheftPrem);
      this.columnForgeryLimit = new DataColumn("ForgeryLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnForgeryLimit);
      this.columnForgeryDed = new DataColumn("ForgeryDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnForgeryDed);
      this.columnForgeryPrem = new DataColumn("ForgeryPrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnForgeryPrem);
      this.columnMoneyInsideLimit = new DataColumn("MoneyInsideLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMoneyInsideLimit);
      this.columnMoneyInsideDed = new DataColumn("MoneyInsideDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMoneyInsideDed);
      this.columnMoneyInsidePrem = new DataColumn("MoneyInsidePrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMoneyInsidePrem);
      this.columnSafeInsideLimit = new DataColumn("SafeInsideLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSafeInsideLimit);
      this.columnSafeInsideDed = new DataColumn("SafeInsideDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSafeInsideDed);
      this.columnSafeInsidePrem = new DataColumn("SafeInsidePrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSafeInsidePrem);
      this.columnTheftOutsideLimit = new DataColumn("TheftOutsideLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTheftOutsideLimit);
      this.columnTheftOutsideDed = new DataColumn("TheftOutsideDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTheftOutsideDed);
      this.columnTheftOutsidePrem = new DataColumn("TheftOutsidePrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTheftOutsidePrem);
      this.columnComputerFraudLimit = new DataColumn("ComputerFraudLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComputerFraudLimit);
      this.columnComputerFraudDed = new DataColumn("ComputerFraudDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComputerFraudDed);
      this.columnComputerFraudPrem = new DataColumn("ComputerFraudPrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComputerFraudPrem);
      this.columnFundTransferLimit = new DataColumn("FundTransferLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFundTransferLimit);
      this.columnFundTransferDed = new DataColumn("FundTransferDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFundTransferDed);
      this.columnFundTransferPrem = new DataColumn("FundTransferPrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFundTransferPrem);
      this.columnCounterfeitLimit = new DataColumn("CounterfeitLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounterfeitLimit);
      this.columnCounterfeitDed = new DataColumn("CounterfeitDed", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounterfeitDed);
      this.columnCounterfeitPrem = new DataColumn("CounterfeitPrem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounterfeitPrem);
      this.columnTotalPremium = new DataColumn("TotalPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.columnRate = new DataColumn("Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.columnUserOverrideFactor = new DataColumn("UserOverrideFactor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserOverrideFactor);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.columnPriorRate = new DataColumn("PriorRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPriorRate);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnTerrorismDeclined.AllowDBNull = false;
      this.columnTerrorismDeclined.DefaultValue = (object) false;
      this.columnEmployeeTheftLimit.AllowDBNull = false;
      this.columnEmployeeTheftLimit.DefaultValue = (object) 0M;
      this.columnEmployeeTheftDed.AllowDBNull = false;
      this.columnEmployeeTheftDed.DefaultValue = (object) 0M;
      this.columnEmployeeTheftPrem.AllowDBNull = false;
      this.columnEmployeeTheftPrem.DefaultValue = (object) 0M;
      this.columnForgeryLimit.AllowDBNull = false;
      this.columnForgeryLimit.DefaultValue = (object) 0M;
      this.columnForgeryDed.AllowDBNull = false;
      this.columnForgeryDed.DefaultValue = (object) 0M;
      this.columnForgeryPrem.AllowDBNull = false;
      this.columnForgeryPrem.DefaultValue = (object) 0M;
      this.columnMoneyInsideLimit.AllowDBNull = false;
      this.columnMoneyInsideLimit.DefaultValue = (object) 0M;
      this.columnMoneyInsideDed.AllowDBNull = false;
      this.columnMoneyInsideDed.DefaultValue = (object) 0M;
      this.columnMoneyInsidePrem.AllowDBNull = false;
      this.columnMoneyInsidePrem.DefaultValue = (object) 0M;
      this.columnSafeInsideLimit.AllowDBNull = false;
      this.columnSafeInsideLimit.DefaultValue = (object) 0M;
      this.columnSafeInsideDed.AllowDBNull = false;
      this.columnSafeInsideDed.DefaultValue = (object) 0M;
      this.columnSafeInsidePrem.AllowDBNull = false;
      this.columnSafeInsidePrem.DefaultValue = (object) 0M;
      this.columnTheftOutsideLimit.AllowDBNull = false;
      this.columnTheftOutsideLimit.DefaultValue = (object) 0M;
      this.columnTheftOutsideDed.AllowDBNull = false;
      this.columnTheftOutsideDed.DefaultValue = (object) 0M;
      this.columnTheftOutsidePrem.AllowDBNull = false;
      this.columnTheftOutsidePrem.DefaultValue = (object) 0M;
      this.columnComputerFraudLimit.AllowDBNull = false;
      this.columnComputerFraudLimit.DefaultValue = (object) 0M;
      this.columnComputerFraudDed.AllowDBNull = false;
      this.columnComputerFraudDed.DefaultValue = (object) 0M;
      this.columnComputerFraudPrem.AllowDBNull = false;
      this.columnComputerFraudPrem.DefaultValue = (object) 0M;
      this.columnFundTransferLimit.AllowDBNull = false;
      this.columnFundTransferLimit.DefaultValue = (object) 0M;
      this.columnFundTransferDed.AllowDBNull = false;
      this.columnFundTransferDed.DefaultValue = (object) 0M;
      this.columnFundTransferPrem.AllowDBNull = false;
      this.columnFundTransferPrem.DefaultValue = (object) 0M;
      this.columnCounterfeitLimit.AllowDBNull = false;
      this.columnCounterfeitLimit.DefaultValue = (object) 0M;
      this.columnCounterfeitDed.AllowDBNull = false;
      this.columnCounterfeitDed.DefaultValue = (object) 0M;
      this.columnCounterfeitPrem.AllowDBNull = false;
      this.columnCounterfeitPrem.DefaultValue = (object) 0M;
      this.columnTotalPremium.AllowDBNull = false;
      this.columnTotalPremium.DefaultValue = (object) 0M;
      this.columnTerrPremium.AllowDBNull = false;
      this.columnTerrPremium.DefaultValue = (object) 0M;
      this.columnRate.AllowDBNull = false;
      this.columnRate.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow NewtblQuoteOptionCrimeRow()
    {
      return (dsCrime.tblQuoteOptionCrimeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCrime.tblQuoteOptionCrimeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCrime.tblQuoteOptionCrimeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrimeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrimeRowChangeEventHandler crimeRowChangedEvent = this.tblQuoteOptionCrimeRowChangedEvent;
      if (crimeRowChangedEvent == null)
        return;
      crimeRowChangedEvent((object) this, new dsCrime.tblQuoteOptionCrimeRowChangeEvent((dsCrime.tblQuoteOptionCrimeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrimeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrimeRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionCrimeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCrime.tblQuoteOptionCrimeRowChangeEvent((dsCrime.tblQuoteOptionCrimeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrimeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrimeRowChangeEventHandler crimeRowDeletedEvent = this.tblQuoteOptionCrimeRowDeletedEvent;
      if (crimeRowDeletedEvent == null)
        return;
      crimeRowDeletedEvent((object) this, new dsCrime.tblQuoteOptionCrimeRowChangeEvent((dsCrime.tblQuoteOptionCrimeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrimeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrimeRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionCrimeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCrime.tblQuoteOptionCrimeRowChangeEvent((dsCrime.tblQuoteOptionCrimeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionCrimeRow(dsCrime.tblQuoteOptionCrimeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCrime dsCrime = new dsCrime();
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
        FixedValue = dsCrime.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionCrimeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCrime.GetSchemaSerializable();
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
  public class tblQuoteOptionsDataTable : TypedTableBase<dsCrime.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteGUID;
    private DataColumn columnLineGUID;
    private DataColumn columnDateCreated;
    private DataColumn columnAdditionalComments;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnQuoteOptionGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsDataTable()
    {
      this.TableName = "tblQuoteOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsDataTable(DataTable table)
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
    protected tblQuoteOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateCreatedColumn => this.columnDateCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionGUIDColumn => this.columnQuoteOptionGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionsRow this[int index]
    {
      get => (dsCrime.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionsRow(dsCrime.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteGUID,
      Guid LineGUID,
      DateTime DateCreated,
      string AdditionalComments,
      Guid QuoteOptionGUID)
    {
      dsCrime.tblQuoteOptionsRow row = (dsCrime.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) QuoteGUID,
        (object) LineGUID,
        (object) DateCreated,
        (object) AdditionalComments,
        null,
        (object) QuoteOptionGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionsRow FindByQuoteOptionID(int QuoteOptionID)
    {
      return (dsCrime.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCrime.tblQuoteOptionsDataTable optionsDataTable = (dsCrime.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCrime.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnQuoteOptionGUID = this.Columns["QuoteOptionGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnQuoteOptionGUID = new DataColumn("QuoteOptionGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCrimeKey1", new DataColumn[1]
      {
        this.columnQuoteOptionID
      }, true));
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
      this.columnDateCreated.AllowDBNull = false;
      this.columnQuoteOptionID.AutoIncrement = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnQuoteOptionID.ReadOnly = true;
      this.columnQuoteOptionID.Unique = true;
      this.columnQuoteOptionGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsCrime.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCrime.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCrime.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsCrime.tblQuoteOptionsRowChangeEvent((dsCrime.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCrime.tblQuoteOptionsRowChangeEvent((dsCrime.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsCrime.tblQuoteOptionsRowChangeEvent((dsCrime.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCrime.tblQuoteOptionsRowChangeEvent((dsCrime.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsCrime.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCrime dsCrime = new dsCrime();
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
        FixedValue = dsCrime.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCrime.GetSchemaSerializable();
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
  public class tblQuoteOptionCrime_SublimitsDataTable : 
    TypedTableBase<dsCrime.tblQuoteOptionCrime_SublimitsRow>
  {
    private DataColumn columnOptionSubLimitID;
    private DataColumn columnCrimeOptionID;
    private DataColumn columnSubLimitID;
    private DataColumn columnOriginalOptionSubLimitID;
    private DataColumn columnLimit;
    private DataColumn columnDeductible;
    private DataColumn columnDeductiblePercentage;
    private DataColumn columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionCrime_SublimitsDataTable()
    {
      this.TableName = "tblQuoteOptionCrime_Sublimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionCrime_SublimitsDataTable(DataTable table)
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
    protected tblQuoteOptionCrime_SublimitsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OptionSubLimitIDColumn => this.columnOptionSubLimitID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CrimeOptionIDColumn => this.columnCrimeOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubLimitIDColumn => this.columnSubLimitID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OriginalOptionSubLimitIDColumn => this.columnOriginalOptionSubLimitID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductiblePercentageColumn => this.columnDeductiblePercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow this[int index]
    {
      get => (dsCrime.tblQuoteOptionCrime_SublimitsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler tblQuoteOptionCrime_SublimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler tblQuoteOptionCrime_SublimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler tblQuoteOptionCrime_SublimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler tblQuoteOptionCrime_SublimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionCrime_SublimitsRow(dsCrime.tblQuoteOptionCrime_SublimitsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow AddtblQuoteOptionCrime_SublimitsRow(
      dsCrime.tblQuoteOptionCrimeRow parenttblQuoteOptionCrimeRowBytblQuoteOptionCrimetblQuoteOptionCrime_Sublimits,
      dsCrime.lstSubLimitsRow parentlstSubLimitsRowBylstSubLimitstblQuoteOptionCrime_Sublimits,
      int OriginalOptionSubLimitID,
      int Limit,
      int Deductible,
      Decimal DeductiblePercentage,
      string ModificationCode)
    {
      dsCrime.tblQuoteOptionCrime_SublimitsRow row = (dsCrime.tblQuoteOptionCrime_SublimitsRow) this.NewRow();
      object[] objArray = new object[8]
      {
        null,
        null,
        null,
        (object) OriginalOptionSubLimitID,
        (object) Limit,
        (object) Deductible,
        (object) DeductiblePercentage,
        (object) ModificationCode
      };
      if (parenttblQuoteOptionCrimeRowBytblQuoteOptionCrimetblQuoteOptionCrime_Sublimits != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionCrimeRowBytblQuoteOptionCrimetblQuoteOptionCrime_Sublimits[0]);
      if (parentlstSubLimitsRowBylstSubLimitstblQuoteOptionCrime_Sublimits != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstSubLimitsRowBylstSubLimitstblQuoteOptionCrime_Sublimits[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow FindByOptionSubLimitID(int OptionSubLimitID)
    {
      return (dsCrime.tblQuoteOptionCrime_SublimitsRow) this.Rows.Find(new object[1]
      {
        (object) OptionSubLimitID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCrime.tblQuoteOptionCrime_SublimitsDataTable sublimitsDataTable = (dsCrime.tblQuoteOptionCrime_SublimitsDataTable) base.Clone();
      sublimitsDataTable.InitVars();
      return (DataTable) sublimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCrime.tblQuoteOptionCrime_SublimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnOptionSubLimitID = this.Columns["OptionSubLimitID"];
      this.columnCrimeOptionID = this.Columns["CrimeOptionID"];
      this.columnSubLimitID = this.Columns["SubLimitID"];
      this.columnOriginalOptionSubLimitID = this.Columns["OriginalOptionSubLimitID"];
      this.columnLimit = this.Columns["Limit"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnDeductiblePercentage = this.Columns["DeductiblePercentage"];
      this.columnModificationCode = this.Columns["ModificationCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnOptionSubLimitID = new DataColumn("OptionSubLimitID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionSubLimitID);
      this.columnCrimeOptionID = new DataColumn("CrimeOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCrimeOptionID);
      this.columnSubLimitID = new DataColumn("SubLimitID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimitID);
      this.columnOriginalOptionSubLimitID = new DataColumn("OriginalOptionSubLimitID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalOptionSubLimitID);
      this.columnLimit = new DataColumn("Limit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnDeductible = new DataColumn("Deductible", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnDeductiblePercentage = new DataColumn("DeductiblePercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductiblePercentage);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCrimeKey2", new DataColumn[1]
      {
        this.columnOptionSubLimitID
      }, true));
      this.columnOptionSubLimitID.AutoIncrement = true;
      this.columnOptionSubLimitID.AllowDBNull = false;
      this.columnOptionSubLimitID.ReadOnly = true;
      this.columnOptionSubLimitID.Unique = true;
      this.columnCrimeOptionID.AllowDBNull = false;
      this.columnSubLimitID.AllowDBNull = false;
      this.columnLimit.AllowDBNull = false;
      this.columnModificationCode.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow NewtblQuoteOptionCrime_SublimitsRow()
    {
      return (dsCrime.tblQuoteOptionCrime_SublimitsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCrime.tblQuoteOptionCrime_SublimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCrime.tblQuoteOptionCrime_SublimitsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrime_SublimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler sublimitsRowChangedEvent = this.tblQuoteOptionCrime_SublimitsRowChangedEvent;
      if (sublimitsRowChangedEvent == null)
        return;
      sublimitsRowChangedEvent((object) this, new dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEvent((dsCrime.tblQuoteOptionCrime_SublimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrime_SublimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionCrime_SublimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEvent((dsCrime.tblQuoteOptionCrime_SublimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrime_SublimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler sublimitsRowDeletedEvent = this.tblQuoteOptionCrime_SublimitsRowDeletedEvent;
      if (sublimitsRowDeletedEvent == null)
        return;
      sublimitsRowDeletedEvent((object) this, new dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEvent((dsCrime.tblQuoteOptionCrime_SublimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionCrime_SublimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionCrime_SublimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCrime.tblQuoteOptionCrime_SublimitsRowChangeEvent((dsCrime.tblQuoteOptionCrime_SublimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionCrime_SublimitsRow(dsCrime.tblQuoteOptionCrime_SublimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCrime dsCrime = new dsCrime();
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
        FixedValue = dsCrime.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionCrime_SublimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCrime.GetSchemaSerializable();
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
  public class lstSubLimitsDataTable : TypedTableBase<dsCrime.lstSubLimitsRow>
  {
    private DataColumn columnSubLimitID;
    private DataColumn columnSubLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstSubLimitsDataTable()
    {
      this.TableName = "lstSubLimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstSubLimitsDataTable(DataTable table)
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
    protected lstSubLimitsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubLimitIDColumn => this.columnSubLimitID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubLimitColumn => this.columnSubLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.lstSubLimitsRow this[int index] => (dsCrime.lstSubLimitsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.lstSubLimitsRowChangeEventHandler lstSubLimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.lstSubLimitsRowChangeEventHandler lstSubLimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.lstSubLimitsRowChangeEventHandler lstSubLimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCrime.lstSubLimitsRowChangeEventHandler lstSubLimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstSubLimitsRow(dsCrime.lstSubLimitsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.lstSubLimitsRow AddlstSubLimitsRow(int SubLimitID, string SubLimit)
    {
      dsCrime.lstSubLimitsRow row = (dsCrime.lstSubLimitsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) SubLimitID,
        (object) SubLimit
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.lstSubLimitsRow FindBySubLimitID(int SubLimitID)
    {
      return (dsCrime.lstSubLimitsRow) this.Rows.Find(new object[1]
      {
        (object) SubLimitID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCrime.lstSubLimitsDataTable subLimitsDataTable = (dsCrime.lstSubLimitsDataTable) base.Clone();
      subLimitsDataTable.InitVars();
      return (DataTable) subLimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCrime.lstSubLimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSubLimitID = this.Columns["SubLimitID"];
      this.columnSubLimit = this.Columns["SubLimit"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSubLimitID = new DataColumn("SubLimitID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimitID);
      this.columnSubLimit = new DataColumn("SubLimit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimit);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCrimeKey3", new DataColumn[1]
      {
        this.columnSubLimitID
      }, true));
      this.columnSubLimitID.AllowDBNull = false;
      this.columnSubLimitID.ReadOnly = true;
      this.columnSubLimitID.Unique = true;
      this.columnSubLimit.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.lstSubLimitsRow NewlstSubLimitsRow() => (dsCrime.lstSubLimitsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCrime.lstSubLimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCrime.lstSubLimitsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.lstSubLimitsRowChangeEventHandler limitsRowChangedEvent = this.lstSubLimitsRowChangedEvent;
      if (limitsRowChangedEvent == null)
        return;
      limitsRowChangedEvent((object) this, new dsCrime.lstSubLimitsRowChangeEvent((dsCrime.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.lstSubLimitsRowChangeEventHandler rowChangingEvent = this.lstSubLimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCrime.lstSubLimitsRowChangeEvent((dsCrime.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.lstSubLimitsRowChangeEventHandler limitsRowDeletedEvent = this.lstSubLimitsRowDeletedEvent;
      if (limitsRowDeletedEvent == null)
        return;
      limitsRowDeletedEvent((object) this, new dsCrime.lstSubLimitsRowChangeEvent((dsCrime.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCrime.lstSubLimitsRowChangeEventHandler rowDeletingEvent = this.lstSubLimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCrime.lstSubLimitsRowChangeEvent((dsCrime.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstSubLimitsRow(dsCrime.lstSubLimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCrime dsCrime = new dsCrime();
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
        FixedValue = dsCrime.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSubLimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCrime.GetSchemaSerializable();
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

  public class tblQuoteOptionCrimeRow : DataRow
  {
    private dsCrime.tblQuoteOptionCrimeDataTable tabletblQuoteOptionCrime;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionCrimeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionCrime = (dsCrime.tblQuoteOptionCrimeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCrime.IDColumn]);
      set => this[this.tabletblQuoteOptionCrime.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCrime.QuoteOptionIDColumn]);
      set => this[this.tabletblQuoteOptionCrime.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TerrorismDeclined
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCrime.TerrorismDeclinedColumn]);
      set => this[this.tabletblQuoteOptionCrime.TerrorismDeclinedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal EmployeeTheftLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.EmployeeTheftLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.EmployeeTheftLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal EmployeeTheftDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.EmployeeTheftDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.EmployeeTheftDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal EmployeeTheftPrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.EmployeeTheftPremColumn]);
      set => this[this.tabletblQuoteOptionCrime.EmployeeTheftPremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ForgeryLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.ForgeryLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.ForgeryLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ForgeryDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.ForgeryDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.ForgeryDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ForgeryPrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.ForgeryPremColumn]);
      set => this[this.tabletblQuoteOptionCrime.ForgeryPremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal MoneyInsideLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.MoneyInsideLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.MoneyInsideLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal MoneyInsideDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.MoneyInsideDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.MoneyInsideDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal MoneyInsidePrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.MoneyInsidePremColumn]);
      set => this[this.tabletblQuoteOptionCrime.MoneyInsidePremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal SafeInsideLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.SafeInsideLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.SafeInsideLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal SafeInsideDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.SafeInsideDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.SafeInsideDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal SafeInsidePrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.SafeInsidePremColumn]);
      set => this[this.tabletblQuoteOptionCrime.SafeInsidePremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TheftOutsideLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.TheftOutsideLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.TheftOutsideLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TheftOutsideDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.TheftOutsideDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.TheftOutsideDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TheftOutsidePrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.TheftOutsidePremColumn]);
      set => this[this.tabletblQuoteOptionCrime.TheftOutsidePremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ComputerFraudLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.ComputerFraudLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.ComputerFraudLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ComputerFraudDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.ComputerFraudDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.ComputerFraudDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ComputerFraudPrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.ComputerFraudPremColumn]);
      set => this[this.tabletblQuoteOptionCrime.ComputerFraudPremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal FundTransferLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.FundTransferLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.FundTransferLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal FundTransferDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.FundTransferDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.FundTransferDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal FundTransferPrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.FundTransferPremColumn]);
      set => this[this.tabletblQuoteOptionCrime.FundTransferPremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal CounterfeitLimit
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.CounterfeitLimitColumn]);
      set => this[this.tabletblQuoteOptionCrime.CounterfeitLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal CounterfeitDed
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.CounterfeitDedColumn]);
      set => this[this.tabletblQuoteOptionCrime.CounterfeitDedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal CounterfeitPrem
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.CounterfeitPremColumn]);
      set => this[this.tabletblQuoteOptionCrime.CounterfeitPremColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TotalPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.TotalPremiumColumn]);
      set => this[this.tabletblQuoteOptionCrime.TotalPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TerrPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.TerrPremiumColumn]);
      set => this[this.tabletblQuoteOptionCrime.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionCrime.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblQuoteOptionCrime' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Rate
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.RateColumn]);
      set => this[this.tabletblQuoteOptionCrime.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteOptionCrime.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblQuoteOptionCrime' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblQuoteOptionCrime' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UserOverrideFactor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.UserOverrideFactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserOverrideFactor' in table 'tblQuoteOptionCrime' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime.UserOverrideFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionCrime.EndorsementCalcTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementCalcType' in table 'tblQuoteOptionCrime' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime.EndorsementCalcTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PriorRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime.PriorRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PriorRate' in table 'tblQuoteOptionCrime' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime.PriorRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionsRow tblQuoteOptionsRow
    {
      get
      {
        return (dsCrime.tblQuoteOptionsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionCrime"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionCrime"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblQuoteOptionCrime.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblQuoteOptionCrime.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblQuoteOptionCrime.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblQuoteOptionCrime.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserOverrideFactorNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime.UserOverrideFactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserOverrideFactorNull()
    {
      this[this.tabletblQuoteOptionCrime.UserOverrideFactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEndorsementCalcTypeNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime.EndorsementCalcTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEndorsementCalcTypeNull()
    {
      this[this.tabletblQuoteOptionCrime.EndorsementCalcTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPriorRateNull() => this.IsNull(this.tabletblQuoteOptionCrime.PriorRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPriorRateNull()
    {
      this[this.tabletblQuoteOptionCrime.PriorRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow[] GettblQuoteOptionCrime_SublimitsRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits"] != null ? (dsCrime.tblQuoteOptionCrime_SublimitsRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits"]) : new dsCrime.tblQuoteOptionCrime_SublimitsRow[0];
    }
  }

  public class tblQuoteOptionsRow : DataRow
  {
    private dsCrime.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsCrime.tblQuoteOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateCreated
    {
      get => Conversions.ToDate(this[this.tabletblQuoteOptions.DateCreatedColumn]);
      set => this[this.tabletblQuoteOptions.DateCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptions.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblQuoteOptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptions.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptions.QuoteOptionIDColumn]);
      set => this[this.tabletblQuoteOptions.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteOptionGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptions.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblQuoteOptions.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow[] GettblQuoteOptionCrimeRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionCrime"] != null ? (dsCrime.tblQuoteOptionCrimeRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionCrime"]) : new dsCrime.tblQuoteOptionCrimeRow[0];
    }
  }

  public class tblQuoteOptionCrime_SublimitsRow : DataRow
  {
    private dsCrime.tblQuoteOptionCrime_SublimitsDataTable tabletblQuoteOptionCrime_Sublimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionCrime_SublimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionCrime_Sublimits = (dsCrime.tblQuoteOptionCrime_SublimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OptionSubLimitID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteOptionCrime_Sublimits.OptionSubLimitIDColumn]);
      }
      set => this[this.tabletblQuoteOptionCrime_Sublimits.OptionSubLimitIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CrimeOptionID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteOptionCrime_Sublimits.CrimeOptionIDColumn]);
      }
      set => this[this.tabletblQuoteOptionCrime_Sublimits.CrimeOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SubLimitID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCrime_Sublimits.SubLimitIDColumn]);
      set => this[this.tabletblQuoteOptionCrime_Sublimits.SubLimitIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OriginalOptionSubLimitID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionCrime_Sublimits.OriginalOptionSubLimitIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalOptionSubLimitID' in table 'tblQuoteOptionCrime_Sublimits' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteOptionCrime_Sublimits.OriginalOptionSubLimitIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Limit
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCrime_Sublimits.LimitColumn]);
      set => this[this.tabletblQuoteOptionCrime_Sublimits.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Deductible
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionCrime_Sublimits.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblQuoteOptionCrime_Sublimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCrime_Sublimits.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeductiblePercentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCrime_Sublimits.DeductiblePercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeductiblePercentage' in table 'tblQuoteOptionCrime_Sublimits' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteOptionCrime_Sublimits.DeductiblePercentageColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ModificationCode
    {
      get
      {
        return Conversions.ToString(this[this.tabletblQuoteOptionCrime_Sublimits.ModificationCodeColumn]);
      }
      set => this[this.tabletblQuoteOptionCrime_Sublimits.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow tblQuoteOptionCrimeRow
    {
      get
      {
        return (dsCrime.tblQuoteOptionCrimeRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.lstSubLimitsRow lstSubLimitsRow
    {
      get
      {
        return (dsCrime.lstSubLimitsRow) this.GetParentRow(this.Table.ParentRelations["lstSubLimitstblQuoteOptionCrime_Sublimits"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSubLimitstblQuoteOptionCrime_Sublimits"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOriginalOptionSubLimitIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime_Sublimits.OriginalOptionSubLimitIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOriginalOptionSubLimitIDNull()
    {
      this[this.tabletblQuoteOptionCrime_Sublimits.OriginalOptionSubLimitIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeductibleNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime_Sublimits.DeductibleColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblQuoteOptionCrime_Sublimits.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeductiblePercentageNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCrime_Sublimits.DeductiblePercentageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeductiblePercentageNull()
    {
      this[this.tabletblQuoteOptionCrime_Sublimits.DeductiblePercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstSubLimitsRow : DataRow
  {
    private dsCrime.lstSubLimitsDataTable tablelstSubLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstSubLimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSubLimits = (dsCrime.lstSubLimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SubLimitID
    {
      get => Conversions.ToInteger(this[this.tablelstSubLimits.SubLimitIDColumn]);
      set => this[this.tablelstSubLimits.SubLimitIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SubLimit
    {
      get => Conversions.ToString(this[this.tablelstSubLimits.SubLimitColumn]);
      set => this[this.tablelstSubLimits.SubLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow[] GettblQuoteOptionCrime_SublimitsRows()
    {
      return this.Table.ChildRelations["lstSubLimitstblQuoteOptionCrime_Sublimits"] != null ? (dsCrime.tblQuoteOptionCrime_SublimitsRow[]) this.GetChildRows(this.Table.ChildRelations["lstSubLimitstblQuoteOptionCrime_Sublimits"]) : new dsCrime.tblQuoteOptionCrime_SublimitsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionCrimeRowChangeEvent : EventArgs
  {
    private dsCrime.tblQuoteOptionCrimeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionCrimeRowChangeEvent(
      dsCrime.tblQuoteOptionCrimeRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrimeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsCrime.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(dsCrime.tblQuoteOptionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionCrime_SublimitsRowChangeEvent : EventArgs
  {
    private dsCrime.tblQuoteOptionCrime_SublimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionCrime_SublimitsRowChangeEvent(
      dsCrime.tblQuoteOptionCrime_SublimitsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.tblQuoteOptionCrime_SublimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstSubLimitsRowChangeEvent : EventArgs
  {
    private dsCrime.lstSubLimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstSubLimitsRowChangeEvent(dsCrime.lstSubLimitsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCrime.lstSubLimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
