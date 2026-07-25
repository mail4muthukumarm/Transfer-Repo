// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.EquipmentBreakdown.dsEquipmentBreakdown
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
namespace MGASystems.IMS.Policies.Rating.EquipmentBreakdown;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsEquipmentBreakdown")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsEquipmentBreakdown : DataSet
{
  private dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable tabletblQuoteOptionEquipmentBreakdown;
  private dsEquipmentBreakdown.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private DataRelation relationtblQuoteOptionstblQuoteOptionEquipmentBreakdown;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsEquipmentBreakdown()
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
  protected dsEquipmentBreakdown(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteOptionEquipmentBreakdown)] != null)
          base.Tables.Add((DataTable) new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable(dataSet.Tables[nameof (tblQuoteOptionEquipmentBreakdown)]));
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsEquipmentBreakdown.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
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
  public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable tblQuoteOptionEquipmentBreakdown
  {
    get => this.tabletblQuoteOptionEquipmentBreakdown;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsEquipmentBreakdown.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

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
    dsEquipmentBreakdown equipmentBreakdown = (dsEquipmentBreakdown) base.Clone();
    equipmentBreakdown.InitVars();
    equipmentBreakdown.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) equipmentBreakdown;
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
      if (dataSet.Tables["tblQuoteOptionEquipmentBreakdown"] != null)
        base.Tables.Add((DataTable) new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable(dataSet.Tables["tblQuoteOptionEquipmentBreakdown"]));
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsEquipmentBreakdown.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
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
    this.tabletblQuoteOptionEquipmentBreakdown = (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable) base.Tables["tblQuoteOptionEquipmentBreakdown"];
    if (initTable && this.tabletblQuoteOptionEquipmentBreakdown != null)
      this.tabletblQuoteOptionEquipmentBreakdown.InitVars();
    this.tabletblQuoteOptions = (dsEquipmentBreakdown.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.relationtblQuoteOptionstblQuoteOptionEquipmentBreakdown = this.Relations["tblQuoteOptionstblQuoteOptionEquipmentBreakdown"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsEquipmentBreakdown);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsEquipmentBreakdown.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteOptionEquipmentBreakdown = new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionEquipmentBreakdown);
    this.tabletblQuoteOptions = new dsEquipmentBreakdown.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblQuoteOptionstblQuoteOptionEquipmentBreakdown", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionEquipmentBreakdown.QuoteOptionIDColumn
    });
    this.tabletblQuoteOptionEquipmentBreakdown.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblQuoteOptionstblQuoteOptionEquipmentBreakdown = new DataRelation("tblQuoteOptionstblQuoteOptionEquipmentBreakdown", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionEquipmentBreakdown.QuoteOptionIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionstblQuoteOptionEquipmentBreakdown);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptionEquipmentBreakdown() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

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
    dsEquipmentBreakdown equipmentBreakdown = new dsEquipmentBreakdown();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = equipmentBreakdown.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = equipmentBreakdown.GetSchemaSerializable();
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
  public delegate void tblQuoteOptionEquipmentBreakdownRowChangeEventHandler(
    object sender,
    dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsEquipmentBreakdown.tblQuoteOptionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteOptionEquipmentBreakdownDataTable : 
    TypedTableBase<dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow>
  {
    private DataColumn columnID;
    private DataColumn columnPriorID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnTerrorismDeclined;
    private DataColumn columnPolicyLimitDescriptionID;
    private DataColumn columnPolicyFormID;
    private DataColumn columnTIV;
    private DataColumn columnNoofLocations;
    private DataColumn columnCoverage;
    private DataColumn columnPolicyLimitPerAccident;
    private DataColumn columnBusinessInterruption;
    private DataColumn columnExtraExpense;
    private DataColumn columnOffPremService;
    private DataColumn columnExpeditingExp;
    private DataColumn columnAmmoniaCont;
    private DataColumn columnWaterDamage;
    private DataColumn columnAOPDA;
    private DataColumn columnDeductiblePerID;
    private DataColumn columnOtherDeduct;
    private DataColumn columnPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnAdditionalComments;
    private DataColumn columnRate;
    private DataColumn columnPriorRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionEquipmentBreakdownDataTable()
    {
      this.TableName = "tblQuoteOptionEquipmentBreakdown";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionEquipmentBreakdownDataTable(DataTable table)
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
    protected tblQuoteOptionEquipmentBreakdownDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PriorIDColumn => this.columnPriorID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismDeclinedColumn => this.columnTerrorismDeclined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyLimitDescriptionIDColumn => this.columnPolicyLimitDescriptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TIVColumn => this.columnTIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoofLocationsColumn => this.columnNoofLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageColumn => this.columnCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyLimitPerAccidentColumn => this.columnPolicyLimitPerAccident;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BusinessInterruptionColumn => this.columnBusinessInterruption;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExtraExpenseColumn => this.columnExtraExpense;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OffPremServiceColumn => this.columnOffPremService;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpeditingExpColumn => this.columnExpeditingExp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmmoniaContColumn => this.columnAmmoniaCont;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WaterDamageColumn => this.columnWaterDamage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AOPDAColumn => this.columnAOPDA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductiblePerIDColumn => this.columnDeductiblePerID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OtherDeductColumn => this.columnOtherDeduct;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

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
    public DataColumn PriorRateColumn => this.columnPriorRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow this[int index]
    {
      get => (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler tblQuoteOptionEquipmentBreakdownRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler tblQuoteOptionEquipmentBreakdownRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler tblQuoteOptionEquipmentBreakdownRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler tblQuoteOptionEquipmentBreakdownRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionEquipmentBreakdownRow(
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow AddtblQuoteOptionEquipmentBreakdownRow(
      int PriorID,
      dsEquipmentBreakdown.tblQuoteOptionsRow parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionEquipmentBreakdown,
      bool TerrorismDeclined,
      byte PolicyLimitDescriptionID,
      byte PolicyFormID,
      Decimal TIV,
      byte NoofLocations,
      string Coverage,
      Decimal PolicyLimitPerAccident,
      string BusinessInterruption,
      string ExtraExpense,
      string OffPremService,
      Decimal ExpeditingExp,
      Decimal AmmoniaCont,
      Decimal WaterDamage,
      int AOPDA,
      string DeductiblePerID,
      string OtherDeduct,
      Decimal Premium,
      Decimal TerrPremium,
      string AdditionalComments,
      Decimal Rate,
      Decimal PriorRate)
    {
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow row = (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) this.NewRow();
      object[] objArray = new object[24]
      {
        null,
        (object) PriorID,
        null,
        (object) TerrorismDeclined,
        (object) PolicyLimitDescriptionID,
        (object) PolicyFormID,
        (object) TIV,
        (object) NoofLocations,
        (object) Coverage,
        (object) PolicyLimitPerAccident,
        (object) BusinessInterruption,
        (object) ExtraExpense,
        (object) OffPremService,
        (object) ExpeditingExp,
        (object) AmmoniaCont,
        (object) WaterDamage,
        (object) AOPDA,
        (object) DeductiblePerID,
        (object) OtherDeduct,
        (object) Premium,
        (object) TerrPremium,
        (object) AdditionalComments,
        (object) Rate,
        (object) PriorRate
      };
      if (parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionEquipmentBreakdown != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionEquipmentBreakdown[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow FindByID(int ID)
    {
      return (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable breakdownDataTable = (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable) base.Clone();
      breakdownDataTable.InitVars();
      return (DataTable) breakdownDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPriorID = this.Columns["PriorID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnTerrorismDeclined = this.Columns["TerrorismDeclined"];
      this.columnPolicyLimitDescriptionID = this.Columns["PolicyLimitDescriptionID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnTIV = this.Columns["TIV"];
      this.columnNoofLocations = this.Columns["NoofLocations"];
      this.columnCoverage = this.Columns["Coverage"];
      this.columnPolicyLimitPerAccident = this.Columns["PolicyLimitPerAccident"];
      this.columnBusinessInterruption = this.Columns["BusinessInterruption"];
      this.columnExtraExpense = this.Columns["ExtraExpense"];
      this.columnOffPremService = this.Columns["OffPremService"];
      this.columnExpeditingExp = this.Columns["ExpeditingExp"];
      this.columnAmmoniaCont = this.Columns["AmmoniaCont"];
      this.columnWaterDamage = this.Columns["WaterDamage"];
      this.columnAOPDA = this.Columns["AOPDA"];
      this.columnDeductiblePerID = this.Columns["DeductiblePerID"];
      this.columnOtherDeduct = this.Columns["OtherDeduct"];
      this.columnPremium = this.Columns["Premium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
      this.columnRate = this.Columns["Rate"];
      this.columnPriorRate = this.Columns["PriorRate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPriorID = new DataColumn("PriorID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPriorID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnTerrorismDeclined = new DataColumn("TerrorismDeclined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismDeclined);
      this.columnPolicyLimitDescriptionID = new DataColumn("PolicyLimitDescriptionID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyLimitDescriptionID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnTIV = new DataColumn("TIV", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTIV);
      this.columnNoofLocations = new DataColumn("NoofLocations", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoofLocations);
      this.columnCoverage = new DataColumn("Coverage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverage);
      this.columnPolicyLimitPerAccident = new DataColumn("PolicyLimitPerAccident", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyLimitPerAccident);
      this.columnBusinessInterruption = new DataColumn("BusinessInterruption", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessInterruption);
      this.columnExtraExpense = new DataColumn("ExtraExpense", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExtraExpense);
      this.columnOffPremService = new DataColumn("OffPremService", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOffPremService);
      this.columnExpeditingExp = new DataColumn("ExpeditingExp", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpeditingExp);
      this.columnAmmoniaCont = new DataColumn("AmmoniaCont", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmmoniaCont);
      this.columnWaterDamage = new DataColumn("WaterDamage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaterDamage);
      this.columnAOPDA = new DataColumn("AOPDA", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAOPDA);
      this.columnDeductiblePerID = new DataColumn("DeductiblePerID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductiblePerID);
      this.columnOtherDeduct = new DataColumn("OtherDeduct", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherDeduct);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.columnRate = new DataColumn("Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
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
      this.columnPolicyFormID.AllowDBNull = false;
      this.columnCoverage.AllowDBNull = false;
      this.columnPolicyLimitPerAccident.AllowDBNull = false;
      this.columnExpeditingExp.AllowDBNull = false;
      this.columnAmmoniaCont.AllowDBNull = false;
      this.columnWaterDamage.AllowDBNull = false;
      this.columnAOPDA.AllowDBNull = false;
      this.columnDeductiblePerID.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnTerrPremium.AllowDBNull = false;
      this.columnRate.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow NewtblQuoteOptionEquipmentBreakdownRow()
    {
      return (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionEquipmentBreakdownRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler breakdownRowChangedEvent = this.tblQuoteOptionEquipmentBreakdownRowChangedEvent;
      if (breakdownRowChangedEvent == null)
        return;
      breakdownRowChangedEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionEquipmentBreakdownRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionEquipmentBreakdownRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionEquipmentBreakdownRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler breakdownRowDeletedEvent = this.tblQuoteOptionEquipmentBreakdownRowDeletedEvent;
      if (breakdownRowDeletedEvent == null)
        return;
      breakdownRowDeletedEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionEquipmentBreakdownRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionEquipmentBreakdownRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionEquipmentBreakdownRow(
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsEquipmentBreakdown equipmentBreakdown = new dsEquipmentBreakdown();
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
        FixedValue = equipmentBreakdown.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionEquipmentBreakdownDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = equipmentBreakdown.GetSchemaSerializable();
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
  public class tblQuoteOptionsDataTable : TypedTableBase<dsEquipmentBreakdown.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnQuoteOptionGUID;
    private DataColumn columnQuoteGUID;
    private DataColumn columnLineGUID;
    private DataColumn columnDateCreated;
    private DataColumn columnAdditionalComments;

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
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionGUIDColumn => this.columnQuoteOptionGUID;

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
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionsRow this[int index]
    {
      get => (dsEquipmentBreakdown.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionsRow(dsEquipmentBreakdown.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteOptionGUID,
      Guid QuoteGUID,
      Guid LineGUID,
      DateTime DateCreated,
      string AdditionalComments)
    {
      dsEquipmentBreakdown.tblQuoteOptionsRow row = (dsEquipmentBreakdown.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) QuoteOptionGUID,
        (object) QuoteGUID,
        (object) LineGUID,
        (object) DateCreated,
        (object) AdditionalComments
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionsRow FindByQuoteOptionID(int QuoteOptionID)
    {
      return (dsEquipmentBreakdown.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsEquipmentBreakdown.tblQuoteOptionsDataTable optionsDataTable = (dsEquipmentBreakdown.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsEquipmentBreakdown.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnQuoteOptionGUID = this.Columns["QuoteOptionGUID"];
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnQuoteOptionGUID = new DataColumn("QuoteOptionGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGUID);
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsEquipmentBreakdownKey1", new DataColumn[1]
      {
        this.columnQuoteOptionID
      }, true));
      this.columnQuoteOptionID.AutoIncrement = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnQuoteOptionID.ReadOnly = true;
      this.columnQuoteOptionID.Unique = true;
      this.columnQuoteOptionGUID.AllowDBNull = false;
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
      this.columnDateCreated.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsEquipmentBreakdown.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsEquipmentBreakdown.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsEquipmentBreakdown.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionsRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionsRow) e.Row, e.Action));
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
      dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionsRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionsRow) e.Row, e.Action));
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
      dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionsRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionsRow) e.Row, e.Action));
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
      dsEquipmentBreakdown.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsEquipmentBreakdown.tblQuoteOptionsRowChangeEvent((dsEquipmentBreakdown.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsEquipmentBreakdown.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsEquipmentBreakdown equipmentBreakdown = new dsEquipmentBreakdown();
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
        FixedValue = equipmentBreakdown.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = equipmentBreakdown.GetSchemaSerializable();
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

  public class tblQuoteOptionEquipmentBreakdownRow : DataRow
  {
    private dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable tabletblQuoteOptionEquipmentBreakdown;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionEquipmentBreakdownRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionEquipmentBreakdown = (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionEquipmentBreakdown.IDColumn]);
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PriorID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionEquipmentBreakdown.PriorIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PriorID' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.PriorIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteOptionEquipmentBreakdown.QuoteOptionIDColumn]);
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TerrorismDeclined
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblQuoteOptionEquipmentBreakdown.TerrorismDeclinedColumn]);
      }
      set
      {
        this[this.tabletblQuoteOptionEquipmentBreakdown.TerrorismDeclinedColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte PolicyLimitDescriptionID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyLimitDescriptionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyLimitDescriptionID' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyLimitDescriptionIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte PolicyFormID
    {
      get
      {
        return Conversions.ToByte(this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyFormIDColumn]);
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TIV
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.TIVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TIV' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.TIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte NoofLocations
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblQuoteOptionEquipmentBreakdown.NoofLocationsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoofLocations' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.NoofLocationsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Coverage
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.CoverageColumn]);
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.CoverageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PolicyLimitPerAccident
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyLimitPerAccidentColumn]);
      }
      set
      {
        this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyLimitPerAccidentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BusinessInterruption
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.BusinessInterruptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusinessInterruption' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteOptionEquipmentBreakdown.BusinessInterruptionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ExtraExpense
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.ExtraExpenseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExtraExpense' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.ExtraExpenseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string OffPremService
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.OffPremServiceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OffPremService' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.OffPremServiceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ExpeditingExp
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.ExpeditingExpColumn]);
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.ExpeditingExpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmmoniaCont
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.AmmoniaContColumn]);
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.AmmoniaContColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal WaterDamage
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.WaterDamageColumn]);
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.WaterDamageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int AOPDA
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionEquipmentBreakdown.AOPDAColumn]);
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.AOPDAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DeductiblePerID
    {
      get
      {
        return Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.DeductiblePerIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteOptionEquipmentBreakdown.DeductiblePerIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string OtherDeduct
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.OtherDeductColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherDeduct' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.OtherDeductColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.PremiumColumn]);
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TerrPremium
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.TerrPremiumColumn]);
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionEquipmentBreakdown.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteOptionEquipmentBreakdown.AdditionalCommentsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Rate
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.RateColumn]);
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PriorRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionEquipmentBreakdown.PriorRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PriorRate' in table 'tblQuoteOptionEquipmentBreakdown' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionEquipmentBreakdown.PriorRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionsRow tblQuoteOptionsRow
    {
      get
      {
        return (dsEquipmentBreakdown.tblQuoteOptionsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionEquipmentBreakdown"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionEquipmentBreakdown"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPriorIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.PriorIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPriorIDNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.PriorIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyLimitDescriptionIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.PolicyLimitDescriptionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyLimitDescriptionIDNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.PolicyLimitDescriptionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTIVNull() => this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.TIVColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTIVNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.TIVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNoofLocationsNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.NoofLocationsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNoofLocationsNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.NoofLocationsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBusinessInterruptionNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.BusinessInterruptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBusinessInterruptionNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.BusinessInterruptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExtraExpenseNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.ExtraExpenseColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExtraExpenseNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.ExtraExpenseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOffPremServiceNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.OffPremServiceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOffPremServiceNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.OffPremServiceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOtherDeductNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.OtherDeductColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOtherDeductNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.OtherDeductColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPriorRateNull()
    {
      return this.IsNull(this.tabletblQuoteOptionEquipmentBreakdown.PriorRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPriorRateNull()
    {
      this[this.tabletblQuoteOptionEquipmentBreakdown.PriorRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuoteOptionsRow : DataRow
  {
    private dsEquipmentBreakdown.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsEquipmentBreakdown.tblQuoteOptionsDataTable) this.Table;
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
    public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow[] GettblQuoteOptionEquipmentBreakdownRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionEquipmentBreakdown"] != null ? (dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionEquipmentBreakdown"]) : new dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionEquipmentBreakdownRowChangeEvent : EventArgs
  {
    private dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionEquipmentBreakdownRowChangeEvent(
      dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionEquipmentBreakdownRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsEquipmentBreakdown.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(
      dsEquipmentBreakdown.tblQuoteOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEquipmentBreakdown.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
