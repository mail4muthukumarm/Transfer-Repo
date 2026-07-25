// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsMiscPremiums
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
[XmlRoot("dsMiscPremiums")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsMiscPremiums : DataSet
{
  private dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable tabletblQuoteOptionMiscPremiums;
  private dsMiscPremiums.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;
  private dsMiscPremiums.tblClientOfficesDataTable tabletblClientOffices;
  private dsMiscPremiums.lstStatesDataTable tablelstStates;
  private DataRelation relationtblFin_PolicyChargestblQuoteOptionMiscPremiums;
  private DataRelation relationtblClientOfficestblQuoteOptionMiscPremiums;
  private DataRelation relationlstStatestblQuoteOptionMiscPremiums;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsMiscPremiums()
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
  protected dsMiscPremiums(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteOptionMiscPremiums)] != null)
          base.Tables.Add((DataTable) new dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable(dataSet.Tables[nameof (tblQuoteOptionMiscPremiums)]));
        if (dataSet.Tables[nameof (tblFin_PolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsMiscPremiums.tblFin_PolicyChargesDataTable(dataSet.Tables[nameof (tblFin_PolicyCharges)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsMiscPremiums.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsMiscPremiums.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
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
  public dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable tblQuoteOptionMiscPremiums
  {
    get => this.tabletblQuoteOptionMiscPremiums;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsMiscPremiums.tblFin_PolicyChargesDataTable tblFin_PolicyCharges
  {
    get => this.tabletblFin_PolicyCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsMiscPremiums.tblClientOfficesDataTable tblClientOffices => this.tabletblClientOffices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsMiscPremiums.lstStatesDataTable lstStates => this.tablelstStates;

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
    dsMiscPremiums dsMiscPremiums = (dsMiscPremiums) base.Clone();
    dsMiscPremiums.InitVars();
    dsMiscPremiums.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsMiscPremiums;
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
      if (dataSet.Tables["tblQuoteOptionMiscPremiums"] != null)
        base.Tables.Add((DataTable) new dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable(dataSet.Tables["tblQuoteOptionMiscPremiums"]));
      if (dataSet.Tables["tblFin_PolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsMiscPremiums.tblFin_PolicyChargesDataTable(dataSet.Tables["tblFin_PolicyCharges"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsMiscPremiums.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsMiscPremiums.lstStatesDataTable(dataSet.Tables["lstStates"]));
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
    this.tabletblQuoteOptionMiscPremiums = (dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable) base.Tables["tblQuoteOptionMiscPremiums"];
    if (initTable && this.tabletblQuoteOptionMiscPremiums != null)
      this.tabletblQuoteOptionMiscPremiums.InitVars();
    this.tabletblFin_PolicyCharges = (dsMiscPremiums.tblFin_PolicyChargesDataTable) base.Tables["tblFin_PolicyCharges"];
    if (initTable && this.tabletblFin_PolicyCharges != null)
      this.tabletblFin_PolicyCharges.InitVars();
    this.tabletblClientOffices = (dsMiscPremiums.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tablelstStates = (dsMiscPremiums.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.relationtblFin_PolicyChargestblQuoteOptionMiscPremiums = this.Relations["tblFin_PolicyChargestblQuoteOptionMiscPremiums"];
    this.relationtblClientOfficestblQuoteOptionMiscPremiums = this.Relations["tblClientOfficestblQuoteOptionMiscPremiums"];
    this.relationlstStatestblQuoteOptionMiscPremiums = this.Relations["lstStatestblQuoteOptionMiscPremiums"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsMiscPremiums);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsMiscPremiums.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteOptionMiscPremiums = new dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionMiscPremiums);
    this.tabletblFin_PolicyCharges = new dsMiscPremiums.tblFin_PolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_PolicyCharges);
    this.tabletblClientOffices = new dsMiscPremiums.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tablelstStates = new dsMiscPremiums.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblFin_PolicyChargestblQuoteOptionMiscPremiums", new DataColumn[1]
    {
      this.tabletblFin_PolicyCharges.ChargeCodeColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionMiscPremiums.ChargeCodeColumn
    });
    this.tabletblQuoteOptionMiscPremiums.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblClientOfficestblQuoteOptionMiscPremiums", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionMiscPremiums.OfficeIDColumn
    });
    this.tabletblQuoteOptionMiscPremiums.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstStatestblQuoteOptionMiscPremiums", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionMiscPremiums.StateIDColumn
    });
    this.tabletblQuoteOptionMiscPremiums.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationtblFin_PolicyChargestblQuoteOptionMiscPremiums = new DataRelation("tblFin_PolicyChargestblQuoteOptionMiscPremiums", new DataColumn[1]
    {
      this.tabletblFin_PolicyCharges.ChargeCodeColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionMiscPremiums.ChargeCodeColumn
    }, false);
    this.Relations.Add(this.relationtblFin_PolicyChargestblQuoteOptionMiscPremiums);
    this.relationtblClientOfficestblQuoteOptionMiscPremiums = new DataRelation("tblClientOfficestblQuoteOptionMiscPremiums", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionMiscPremiums.OfficeIDColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblQuoteOptionMiscPremiums);
    this.relationlstStatestblQuoteOptionMiscPremiums = new DataRelation("lstStatestblQuoteOptionMiscPremiums", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionMiscPremiums.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatestblQuoteOptionMiscPremiums);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptionMiscPremiums() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFin_PolicyCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStates() => false;

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
    dsMiscPremiums dsMiscPremiums = new dsMiscPremiums();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsMiscPremiums.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsMiscPremiums.GetSchemaSerializable();
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
  public delegate void tblQuoteOptionMiscPremiumsRowChangeEventHandler(
    object sender,
    dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblFin_PolicyChargesRowChangeEventHandler(
    object sender,
    dsMiscPremiums.tblFin_PolicyChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsMiscPremiums.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsMiscPremiums.lstStatesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteOptionMiscPremiumsDataTable : 
    TypedTableBase<dsMiscPremiums.tblQuoteOptionMiscPremiumsRow>
  {
    private DataColumn columnMiscPremiumID;
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnOfficeID;
    private DataColumn columnPremium;
    private DataColumn columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionMiscPremiumsDataTable()
    {
      this.TableName = "tblQuoteOptionMiscPremiums";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionMiscPremiumsDataTable(DataTable table)
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
    protected tblQuoteOptionMiscPremiumsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MiscPremiumIDColumn => this.columnMiscPremiumID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow this[int index]
    {
      get => (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler tblQuoteOptionMiscPremiumsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler tblQuoteOptionMiscPremiumsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler tblQuoteOptionMiscPremiumsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler tblQuoteOptionMiscPremiumsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionMiscPremiumsRow(dsMiscPremiums.tblQuoteOptionMiscPremiumsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow AddtblQuoteOptionMiscPremiumsRow(
      Guid QuoteOptionGuid,
      dsMiscPremiums.tblFin_PolicyChargesRow parenttblFin_PolicyChargesRowBytblFin_PolicyChargestblQuoteOptionMiscPremiums,
      dsMiscPremiums.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblQuoteOptionMiscPremiums,
      Decimal Premium,
      dsMiscPremiums.lstStatesRow parentlstStatesRowBylstStatestblQuoteOptionMiscPremiums)
    {
      dsMiscPremiums.tblQuoteOptionMiscPremiumsRow row = (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) QuoteOptionGuid,
        null,
        null,
        (object) Premium,
        null
      };
      if (parenttblFin_PolicyChargesRowBytblFin_PolicyChargestblQuoteOptionMiscPremiums != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblFin_PolicyChargesRowBytblFin_PolicyChargestblQuoteOptionMiscPremiums[0]);
      if (parenttblClientOfficesRowBytblClientOfficestblQuoteOptionMiscPremiums != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblQuoteOptionMiscPremiums[0]);
      if (parentlstStatesRowBylstStatestblQuoteOptionMiscPremiums != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStatestblQuoteOptionMiscPremiums[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow FindByMiscPremiumID(int MiscPremiumID)
    {
      return (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) this.Rows.Find(new object[1]
      {
        (object) MiscPremiumID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable premiumsDataTable = (dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable) base.Clone();
      premiumsDataTable.InitVars();
      return (DataTable) premiumsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnMiscPremiumID = this.Columns["MiscPremiumID"];
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnPremium = this.Columns["Premium"];
      this.columnStateID = this.Columns["StateID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnMiscPremiumID = new DataColumn("MiscPremiumID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMiscPremiumID);
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsMiscPremiumsKey1", new DataColumn[1]
      {
        this.columnMiscPremiumID
      }, true));
      this.columnMiscPremiumID.AutoIncrement = true;
      this.columnMiscPremiumID.AllowDBNull = false;
      this.columnMiscPremiumID.ReadOnly = true;
      this.columnMiscPremiumID.Unique = true;
      this.columnQuoteOptionGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow NewtblQuoteOptionMiscPremiumsRow()
    {
      return (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsMiscPremiums.tblQuoteOptionMiscPremiumsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionMiscPremiumsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler premiumsRowChangedEvent = this.tblQuoteOptionMiscPremiumsRowChangedEvent;
      if (premiumsRowChangedEvent == null)
        return;
      premiumsRowChangedEvent((object) this, new dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEvent((dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionMiscPremiumsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionMiscPremiumsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEvent((dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionMiscPremiumsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler premiumsRowDeletedEvent = this.tblQuoteOptionMiscPremiumsRowDeletedEvent;
      if (premiumsRowDeletedEvent == null)
        return;
      premiumsRowDeletedEvent((object) this, new dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEvent((dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionMiscPremiumsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionMiscPremiumsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsMiscPremiums.tblQuoteOptionMiscPremiumsRowChangeEvent((dsMiscPremiums.tblQuoteOptionMiscPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionMiscPremiumsRow(dsMiscPremiums.tblQuoteOptionMiscPremiumsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsMiscPremiums dsMiscPremiums = new dsMiscPremiums();
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
        FixedValue = dsMiscPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionMiscPremiumsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsMiscPremiums.GetSchemaSerializable();
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
  public class tblFin_PolicyChargesDataTable : TypedTableBase<dsMiscPremiums.tblFin_PolicyChargesRow>
  {
    private DataColumn columnChargeCode;
    private DataColumn columnChargeName;
    private DataColumn columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesDataTable()
    {
      this.TableName = "tblFin_PolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesDataTable(DataTable table)
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
    protected tblFin_PolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblFin_PolicyChargesRow this[int index]
    {
      get => (dsMiscPremiums.tblFin_PolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFin_PolicyChargesRow(dsMiscPremiums.tblFin_PolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblFin_PolicyChargesRow AddtblFin_PolicyChargesRow(
      string ChargeName,
      string StateID)
    {
      dsMiscPremiums.tblFin_PolicyChargesRow row = (dsMiscPremiums.tblFin_PolicyChargesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) ChargeName,
        (object) StateID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblFin_PolicyChargesRow FindByChargeCode(int ChargeCode)
    {
      return (dsMiscPremiums.tblFin_PolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsMiscPremiums.tblFin_PolicyChargesDataTable chargesDataTable = (dsMiscPremiums.tblFin_PolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsMiscPremiums.tblFin_PolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnStateID = this.Columns["StateID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsMiscPremiumsKey2", new DataColumn[1]
      {
        this.columnChargeCode
      }, true));
      this.columnChargeCode.AutoIncrement = true;
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeCode.ReadOnly = true;
      this.columnChargeCode.Unique = true;
      this.columnChargeName.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblFin_PolicyChargesRow NewtblFin_PolicyChargesRow()
    {
      return (dsMiscPremiums.tblFin_PolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsMiscPremiums.tblFin_PolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsMiscPremiums.tblFin_PolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblFin_PolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsMiscPremiums.tblFin_PolicyChargesRowChangeEvent((dsMiscPremiums.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler rowChangingEvent = this.tblFin_PolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsMiscPremiums.tblFin_PolicyChargesRowChangeEvent((dsMiscPremiums.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblFin_PolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsMiscPremiums.tblFin_PolicyChargesRowChangeEvent((dsMiscPremiums.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblFin_PolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblFin_PolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsMiscPremiums.tblFin_PolicyChargesRowChangeEvent((dsMiscPremiums.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFin_PolicyChargesRow(dsMiscPremiums.tblFin_PolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsMiscPremiums dsMiscPremiums = new dsMiscPremiums();
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
        FixedValue = dsMiscPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_PolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsMiscPremiums.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsMiscPremiums.tblClientOfficesRow>
  {
    private DataColumn columnOfficeID;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblClientOfficesDataTable(DataTable table)
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
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblClientOfficesRow this[int index]
    {
      get => (dsMiscPremiums.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblClientOfficesRow(dsMiscPremiums.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblClientOfficesRow AddtblClientOfficesRow(string Location)
    {
      dsMiscPremiums.tblClientOfficesRow row = (dsMiscPremiums.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblClientOfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsMiscPremiums.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsMiscPremiums.tblClientOfficesDataTable officesDataTable = (dsMiscPremiums.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsMiscPremiums.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsMiscPremiumsKey3", new DataColumn[1]
      {
        this.columnOfficeID
      }, true));
      this.columnOfficeID.AutoIncrement = true;
      this.columnOfficeID.AllowDBNull = false;
      this.columnOfficeID.ReadOnly = true;
      this.columnOfficeID.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsMiscPremiums.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsMiscPremiums.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsMiscPremiums.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsMiscPremiums.tblClientOfficesRowChangeEvent((dsMiscPremiums.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsMiscPremiums.tblClientOfficesRowChangeEvent((dsMiscPremiums.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsMiscPremiums.tblClientOfficesRowChangeEvent((dsMiscPremiums.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsMiscPremiums.tblClientOfficesRowChangeEvent((dsMiscPremiums.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblClientOfficesRow(dsMiscPremiums.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsMiscPremiums dsMiscPremiums = new dsMiscPremiums();
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
        FixedValue = dsMiscPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsMiscPremiums.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsMiscPremiums.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.lstStatesRow this[int index]
    {
      get => (dsMiscPremiums.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMiscPremiums.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatesRow(dsMiscPremiums.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsMiscPremiums.lstStatesRow row = (dsMiscPremiums.lstStatesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.lstStatesRow FindByStateID(string StateID)
    {
      return (dsMiscPremiums.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsMiscPremiums.lstStatesDataTable lstStatesDataTable = (dsMiscPremiums.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsMiscPremiums.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsMiscPremiumsKey4", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnState.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.lstStatesRow NewlstStatesRow()
    {
      return (dsMiscPremiums.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsMiscPremiums.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsMiscPremiums.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsMiscPremiums.lstStatesRowChangeEvent((dsMiscPremiums.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsMiscPremiums.lstStatesRowChangeEvent((dsMiscPremiums.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsMiscPremiums.lstStatesRowChangeEvent((dsMiscPremiums.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsMiscPremiums.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsMiscPremiums.lstStatesRowChangeEvent((dsMiscPremiums.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatesRow(dsMiscPremiums.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsMiscPremiums dsMiscPremiums = new dsMiscPremiums();
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
        FixedValue = dsMiscPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsMiscPremiums.GetSchemaSerializable();
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

  public class tblQuoteOptionMiscPremiumsRow : DataRow
  {
    private dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable tabletblQuoteOptionMiscPremiums;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionMiscPremiumsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionMiscPremiums = (dsMiscPremiums.tblQuoteOptionMiscPremiumsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int MiscPremiumID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionMiscPremiums.MiscPremiumIDColumn]);
      set => this[this.tabletblQuoteOptionMiscPremiums.MiscPremiumIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptionMiscPremiums.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptionMiscPremiums.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionMiscPremiums.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'tblQuoteOptionMiscPremiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionMiscPremiums.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionMiscPremiums.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'tblQuoteOptionMiscPremiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionMiscPremiums.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionMiscPremiums.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'tblQuoteOptionMiscPremiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionMiscPremiums.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionMiscPremiums.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblQuoteOptionMiscPremiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionMiscPremiums.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblFin_PolicyChargesRow tblFin_PolicyChargesRow
    {
      get
      {
        return (dsMiscPremiums.tblFin_PolicyChargesRow) this.GetParentRow(this.Table.ParentRelations["tblFin_PolicyChargestblQuoteOptionMiscPremiums"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblFin_PolicyChargestblQuoteOptionMiscPremiums"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsMiscPremiums.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblQuoteOptionMiscPremiums"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblQuoteOptionMiscPremiums"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsMiscPremiums.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStatestblQuoteOptionMiscPremiums"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatestblQuoteOptionMiscPremiums"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeCodeNull()
    {
      return this.IsNull(this.tabletblQuoteOptionMiscPremiums.ChargeCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tabletblQuoteOptionMiscPremiums.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOfficeIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionMiscPremiums.OfficeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tabletblQuoteOptionMiscPremiums.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabletblQuoteOptionMiscPremiums.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabletblQuoteOptionMiscPremiums.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblQuoteOptionMiscPremiums.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblQuoteOptionMiscPremiums.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFin_PolicyChargesRow : DataRow
  {
    private dsMiscPremiums.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_PolicyCharges = (dsMiscPremiums.tblFin_PolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblFin_PolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.ChargeNameColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.StateIDColumn]);
      set => this[this.tabletblFin_PolicyCharges.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[] GettblQuoteOptionMiscPremiumsRows()
    {
      return this.Table.ChildRelations["tblFin_PolicyChargestblQuoteOptionMiscPremiums"] != null ? (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[]) this.GetChildRows(this.Table.ChildRelations["tblFin_PolicyChargestblQuoteOptionMiscPremiums"]) : new dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[0];
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsMiscPremiums.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsMiscPremiums.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblClientOffices.OfficeIDColumn]);
      set => this[this.tabletblClientOffices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.LocationColumn]);
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[] GettblQuoteOptionMiscPremiumsRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblQuoteOptionMiscPremiums"] != null ? (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblQuoteOptionMiscPremiums"]) : new dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[0];
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsMiscPremiums.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsMiscPremiums.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[] GettblQuoteOptionMiscPremiumsRows()
    {
      return this.Table.ChildRelations["lstStatestblQuoteOptionMiscPremiums"] != null ? (dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatestblQuoteOptionMiscPremiums"]) : new dsMiscPremiums.tblQuoteOptionMiscPremiumsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionMiscPremiumsRowChangeEvent : EventArgs
  {
    private dsMiscPremiums.tblQuoteOptionMiscPremiumsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionMiscPremiumsRowChangeEvent(
      dsMiscPremiums.tblQuoteOptionMiscPremiumsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblQuoteOptionMiscPremiumsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFin_PolicyChargesRowChangeEvent : EventArgs
  {
    private dsMiscPremiums.tblFin_PolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesRowChangeEvent(
      dsMiscPremiums.tblFin_PolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblFin_PolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsMiscPremiums.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsMiscPremiums.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsMiscPremiums.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesRowChangeEvent(dsMiscPremiums.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMiscPremiums.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
