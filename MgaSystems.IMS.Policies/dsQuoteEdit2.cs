// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsQuoteEdit2
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
[XmlRoot("dsQuoteEdit2")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsQuoteEdit2 : DataSet
{
  private dsQuoteEdit2.tblQuotesDataTable tabletblQuotes;
  private dsQuoteEdit2.lstSalutationsDataTable tablelstSalutations;
  private dsQuoteEdit2.tblEntityGroupsDataTable tabletblEntityGroups;
  private dsQuoteEdit2.lstBusinessTypesDataTable tablelstBusinessTypes;
  private dsQuoteEdit2.lstClaims_GenderDataTable tablelstClaims_Gender;
  private DataRelation relationlstBusinessTypestblQuotes;
  private DataRelation relationlstSalutationstblQuotes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsQuoteEdit2()
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
  protected dsQuoteEdit2(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuotes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit2.tblQuotesDataTable(dataSet.Tables[nameof (tblQuotes)]));
        if (dataSet.Tables[nameof (lstSalutations)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit2.lstSalutationsDataTable(dataSet.Tables[nameof (lstSalutations)]));
        if (dataSet.Tables[nameof (tblEntityGroups)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit2.tblEntityGroupsDataTable(dataSet.Tables[nameof (tblEntityGroups)]));
        if (dataSet.Tables[nameof (lstBusinessTypes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit2.lstBusinessTypesDataTable(dataSet.Tables[nameof (lstBusinessTypes)]));
        if (dataSet.Tables[nameof (lstClaims_Gender)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit2.lstClaims_GenderDataTable(dataSet.Tables[nameof (lstClaims_Gender)]));
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
  public dsQuoteEdit2.tblQuotesDataTable tblQuotes => this.tabletblQuotes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit2.lstSalutationsDataTable lstSalutations => this.tablelstSalutations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit2.tblEntityGroupsDataTable tblEntityGroups => this.tabletblEntityGroups;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit2.lstBusinessTypesDataTable lstBusinessTypes => this.tablelstBusinessTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit2.lstClaims_GenderDataTable lstClaims_Gender => this.tablelstClaims_Gender;

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
    dsQuoteEdit2 dsQuoteEdit2 = (dsQuoteEdit2) base.Clone();
    dsQuoteEdit2.InitVars();
    dsQuoteEdit2.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsQuoteEdit2;
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
      if (dataSet.Tables["tblQuotes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit2.tblQuotesDataTable(dataSet.Tables["tblQuotes"]));
      if (dataSet.Tables["lstSalutations"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit2.lstSalutationsDataTable(dataSet.Tables["lstSalutations"]));
      if (dataSet.Tables["tblEntityGroups"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit2.tblEntityGroupsDataTable(dataSet.Tables["tblEntityGroups"]));
      if (dataSet.Tables["lstBusinessTypes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit2.lstBusinessTypesDataTable(dataSet.Tables["lstBusinessTypes"]));
      if (dataSet.Tables["lstClaims_Gender"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit2.lstClaims_GenderDataTable(dataSet.Tables["lstClaims_Gender"]));
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
    this.tabletblQuotes = (dsQuoteEdit2.tblQuotesDataTable) base.Tables["tblQuotes"];
    if (initTable && this.tabletblQuotes != null)
      this.tabletblQuotes.InitVars();
    this.tablelstSalutations = (dsQuoteEdit2.lstSalutationsDataTable) base.Tables["lstSalutations"];
    if (initTable && this.tablelstSalutations != null)
      this.tablelstSalutations.InitVars();
    this.tabletblEntityGroups = (dsQuoteEdit2.tblEntityGroupsDataTable) base.Tables["tblEntityGroups"];
    if (initTable && this.tabletblEntityGroups != null)
      this.tabletblEntityGroups.InitVars();
    this.tablelstBusinessTypes = (dsQuoteEdit2.lstBusinessTypesDataTable) base.Tables["lstBusinessTypes"];
    if (initTable && this.tablelstBusinessTypes != null)
      this.tablelstBusinessTypes.InitVars();
    this.tablelstClaims_Gender = (dsQuoteEdit2.lstClaims_GenderDataTable) base.Tables["lstClaims_Gender"];
    if (initTable && this.tablelstClaims_Gender != null)
      this.tablelstClaims_Gender.InitVars();
    this.relationlstBusinessTypestblQuotes = this.Relations["lstBusinessTypestblQuotes"];
    this.relationlstSalutationstblQuotes = this.Relations["lstSalutationstblQuotes"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsQuoteEdit2);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsQuoteEdit2.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuotes = new dsQuoteEdit2.tblQuotesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuotes);
    this.tablelstSalutations = new dsQuoteEdit2.lstSalutationsDataTable();
    base.Tables.Add((DataTable) this.tablelstSalutations);
    this.tabletblEntityGroups = new dsQuoteEdit2.tblEntityGroupsDataTable();
    base.Tables.Add((DataTable) this.tabletblEntityGroups);
    this.tablelstBusinessTypes = new dsQuoteEdit2.lstBusinessTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstBusinessTypes);
    this.tablelstClaims_Gender = new dsQuoteEdit2.lstClaims_GenderDataTable();
    base.Tables.Add((DataTable) this.tablelstClaims_Gender);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstBusinessTypestblQuotes", new DataColumn[1]
    {
      this.tablelstBusinessTypes.BusinessTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.InsuredBusinessTypeIDColumn
    });
    this.tabletblQuotes.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstSalutationstblQuotes", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.InsuredSalutationColumn
    });
    this.tabletblQuotes.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationlstBusinessTypestblQuotes = new DataRelation("lstBusinessTypestblQuotes", new DataColumn[1]
    {
      this.tablelstBusinessTypes.BusinessTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.InsuredBusinessTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstBusinessTypestblQuotes);
    this.relationlstSalutationstblQuotes = new DataRelation("lstSalutationstblQuotes", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.InsuredSalutationColumn
    }, false);
    this.Relations.Add(this.relationlstSalutationstblQuotes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuotes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstSalutations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblEntityGroups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstBusinessTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstClaims_Gender() => false;

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
    dsQuoteEdit2 dsQuoteEdit2 = new dsQuoteEdit2();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsQuoteEdit2.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsQuoteEdit2.GetSchemaSerializable();
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
  public delegate void tblQuotesRowChangeEventHandler(
    object sender,
    dsQuoteEdit2.tblQuotesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstSalutationsRowChangeEventHandler(
    object sender,
    dsQuoteEdit2.lstSalutationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblEntityGroupsRowChangeEventHandler(
    object sender,
    dsQuoteEdit2.tblEntityGroupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstBusinessTypesRowChangeEventHandler(
    object sender,
    dsQuoteEdit2.lstBusinessTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstClaims_GenderRowChangeEventHandler(
    object sender,
    dsQuoteEdit2.lstClaims_GenderRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuotesDataTable : TypedTableBase<dsQuoteEdit2.tblQuotesRow>
  {
    private DataColumn columnQuoteGUID;
    private DataColumn columnInsuredDBA;
    private DataColumn columnInsuredFEIN;
    private DataColumn columnInsuredSSN;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnInsuredCorporationName;
    private DataColumn columnInsuredSalutation;
    private DataColumn columnInsuredFirstName;
    private DataColumn columnInsuredMiddleName;
    private DataColumn columnInsuredLastName;
    private DataColumn columnInsuredAddress1;
    private DataColumn columnInsuredAddress2;
    private DataColumn columnInsuredCity;
    private DataColumn columnInsuredCounty;
    private DataColumn columnInsuredZipCode;
    private DataColumn columnInsuredState;
    private DataColumn columnInsuredRegion;
    private DataColumn columnInsuredISOCountryCode;
    private DataColumn columnInsuredZipPlus;
    private DataColumn columnInsuredPhone;
    private DataColumn columnInsuredFax;
    private DataColumn columnInsuredAddress1_Billing;
    private DataColumn columnInsuredAddress2_Billing;
    private DataColumn columnInsuredCity_Billing;
    private DataColumn columnInsuredCounty_Billing;
    private DataColumn columnInsuredISOCountryCode_Billing;
    private DataColumn columnInsuredZipCode_Billing;
    private DataColumn columnInsuredState_Billing;
    private DataColumn columnInsuredZipPlus_Billing;
    private DataColumn columnInsuredPhone_Billing;
    private DataColumn columnInsuredFax_Billing;
    private DataColumn columnInsuredRegion_Billing;
    private DataColumn columnProducerName;
    private DataColumn columnProducerLocationName;
    private DataColumn columnProducerAddress1;
    private DataColumn columnProducerAddress2;
    private DataColumn columnProducerCity;
    private DataColumn columnProducerCounty;
    private DataColumn columnProducerState;
    private DataColumn columnProducerZipCode;
    private DataColumn columnProducerZipPlus;
    private DataColumn columnProducerPhone;
    private DataColumn columnProducerFax;
    private DataColumn columnProducerAddress1_Billing;
    private DataColumn columnProducerAddress2_Billing;
    private DataColumn columnProducerCity_Billing;
    private DataColumn columnProducerCounty_Billing;
    private DataColumn columnProducerState_Billing;
    private DataColumn columnProducerZipCode_Billing;
    private DataColumn columnProducerZipPlus_Billing;
    private DataColumn columnProducerPhone_Billing;
    private DataColumn columnProducerFax_Billing;
    private DataColumn columnCostCenterID;
    private DataColumn columnInsuredBusinessTypeID;
    private DataColumn columnInsuredMobileNumber;
    private DataColumn columnInsuredBillingEmail;
    private DataColumn columnInsuredBillingContact;
    private DataColumn columnProducerISOCountryCode;
    private DataColumn columnProducerISOCountryCode_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuotesDataTable()
    {
      this.TableName = "tblQuotes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuotesDataTable(DataTable table)
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
    protected tblQuotesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredDBAColumn => this.columnInsuredDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredFEINColumn => this.columnInsuredFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredSSNColumn => this.columnInsuredSSN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredCorporationNameColumn => this.columnInsuredCorporationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredSalutationColumn => this.columnInsuredSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredFirstNameColumn => this.columnInsuredFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredMiddleNameColumn => this.columnInsuredMiddleName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredLastNameColumn => this.columnInsuredLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredAddress1Column => this.columnInsuredAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredAddress2Column => this.columnInsuredAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredCityColumn => this.columnInsuredCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredCountyColumn => this.columnInsuredCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredZipCodeColumn => this.columnInsuredZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredStateColumn => this.columnInsuredState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredRegionColumn => this.columnInsuredRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredISOCountryCodeColumn => this.columnInsuredISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredZipPlusColumn => this.columnInsuredZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredPhoneColumn => this.columnInsuredPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredFaxColumn => this.columnInsuredFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredAddress1_BillingColumn => this.columnInsuredAddress1_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredAddress2_BillingColumn => this.columnInsuredAddress2_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredCity_BillingColumn => this.columnInsuredCity_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredCounty_BillingColumn => this.columnInsuredCounty_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredISOCountryCode_BillingColumn
    {
      get => this.columnInsuredISOCountryCode_Billing;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredZipCode_BillingColumn => this.columnInsuredZipCode_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredState_BillingColumn => this.columnInsuredState_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredZipPlus_BillingColumn => this.columnInsuredZipPlus_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredPhone_BillingColumn => this.columnInsuredPhone_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredFax_BillingColumn => this.columnInsuredFax_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredRegion_BillingColumn => this.columnInsuredRegion_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerNameColumn => this.columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationNameColumn => this.columnProducerLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerAddress1Column => this.columnProducerAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerAddress2Column => this.columnProducerAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerCityColumn => this.columnProducerCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerCountyColumn => this.columnProducerCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerStateColumn => this.columnProducerState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerZipCodeColumn => this.columnProducerZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerZipPlusColumn => this.columnProducerZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerPhoneColumn => this.columnProducerPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerFaxColumn => this.columnProducerFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerAddress1_BillingColumn => this.columnProducerAddress1_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerAddress2_BillingColumn => this.columnProducerAddress2_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerCity_BillingColumn => this.columnProducerCity_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerCounty_BillingColumn => this.columnProducerCounty_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerState_BillingColumn => this.columnProducerState_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerZipCode_BillingColumn => this.columnProducerZipCode_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerZipPlus_BillingColumn => this.columnProducerZipPlus_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerPhone_BillingColumn => this.columnProducerPhone_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerFax_BillingColumn => this.columnProducerFax_Billing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CostCenterIDColumn => this.columnCostCenterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredBusinessTypeIDColumn => this.columnInsuredBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredMobileNumberColumn => this.columnInsuredMobileNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredBillingEmailColumn => this.columnInsuredBillingEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredBillingContactColumn => this.columnInsuredBillingContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerISOCountryCodeColumn => this.columnProducerISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerISOCountryCode_BillingColumn
    {
      get => this.columnProducerISOCountryCode_Billing;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow this[int index]
    {
      get => (dsQuoteEdit2.tblQuotesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblQuotesRowChangeEventHandler tblQuotesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblQuotesRowChangeEventHandler tblQuotesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblQuotesRowChangeEventHandler tblQuotesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblQuotesRowChangeEventHandler tblQuotesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuotesRow(dsQuoteEdit2.tblQuotesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow AddtblQuotesRow(
      Guid QuoteGUID,
      string InsuredDBA,
      string InsuredFEIN,
      string InsuredSSN,
      string InsuredPolicyName,
      string InsuredCorporationName,
      dsQuoteEdit2.lstSalutationsRow parentlstSalutationsRowBylstSalutationstblQuotes,
      string InsuredFirstName,
      string InsuredMiddleName,
      string InsuredLastName,
      string InsuredAddress1,
      string InsuredAddress2,
      string InsuredCity,
      string InsuredCounty,
      string InsuredZipCode,
      string InsuredState,
      string InsuredRegion,
      string InsuredISOCountryCode,
      string InsuredZipPlus,
      string InsuredPhone,
      string InsuredFax,
      string InsuredAddress1_Billing,
      string InsuredAddress2_Billing,
      string InsuredCity_Billing,
      string InsuredCounty_Billing,
      string InsuredISOCountryCode_Billing,
      string InsuredZipCode_Billing,
      string InsuredState_Billing,
      string InsuredZipPlus_Billing,
      string InsuredPhone_Billing,
      string InsuredFax_Billing,
      string InsuredRegion_Billing,
      string ProducerName,
      string ProducerLocationName,
      string ProducerAddress1,
      string ProducerAddress2,
      string ProducerCity,
      string ProducerCounty,
      string ProducerState,
      string ProducerZipCode,
      string ProducerZipPlus,
      string ProducerPhone,
      string ProducerFax,
      string ProducerAddress1_Billing,
      string ProducerAddress2_Billing,
      string ProducerCity_Billing,
      string ProducerCounty_Billing,
      string ProducerState_Billing,
      string ProducerZipCode_Billing,
      string ProducerZipPlus_Billing,
      string ProducerPhone_Billing,
      string ProducerFax_Billing,
      int CostCenterID,
      dsQuoteEdit2.lstBusinessTypesRow parentlstBusinessTypesRowBylstBusinessTypestblQuotes,
      string InsuredMobileNumber,
      string InsuredBillingEmail,
      string InsuredBillingContact,
      string ProducerISOCountryCode,
      string ProducerISOCountryCode_Billing)
    {
      dsQuoteEdit2.tblQuotesRow row = (dsQuoteEdit2.tblQuotesRow) this.NewRow();
      object[] objArray = new object[59]
      {
        (object) QuoteGUID,
        (object) InsuredDBA,
        (object) InsuredFEIN,
        (object) InsuredSSN,
        (object) InsuredPolicyName,
        (object) InsuredCorporationName,
        null,
        (object) InsuredFirstName,
        (object) InsuredMiddleName,
        (object) InsuredLastName,
        (object) InsuredAddress1,
        (object) InsuredAddress2,
        (object) InsuredCity,
        (object) InsuredCounty,
        (object) InsuredZipCode,
        (object) InsuredState,
        (object) InsuredRegion,
        (object) InsuredISOCountryCode,
        (object) InsuredZipPlus,
        (object) InsuredPhone,
        (object) InsuredFax,
        (object) InsuredAddress1_Billing,
        (object) InsuredAddress2_Billing,
        (object) InsuredCity_Billing,
        (object) InsuredCounty_Billing,
        (object) InsuredISOCountryCode_Billing,
        (object) InsuredZipCode_Billing,
        (object) InsuredState_Billing,
        (object) InsuredZipPlus_Billing,
        (object) InsuredPhone_Billing,
        (object) InsuredFax_Billing,
        (object) InsuredRegion_Billing,
        (object) ProducerName,
        (object) ProducerLocationName,
        (object) ProducerAddress1,
        (object) ProducerAddress2,
        (object) ProducerCity,
        (object) ProducerCounty,
        (object) ProducerState,
        (object) ProducerZipCode,
        (object) ProducerZipPlus,
        (object) ProducerPhone,
        (object) ProducerFax,
        (object) ProducerAddress1_Billing,
        (object) ProducerAddress2_Billing,
        (object) ProducerCity_Billing,
        (object) ProducerCounty_Billing,
        (object) ProducerState_Billing,
        (object) ProducerZipCode_Billing,
        (object) ProducerZipPlus_Billing,
        (object) ProducerPhone_Billing,
        (object) ProducerFax_Billing,
        (object) CostCenterID,
        null,
        (object) InsuredMobileNumber,
        (object) InsuredBillingEmail,
        (object) InsuredBillingContact,
        (object) ProducerISOCountryCode,
        (object) ProducerISOCountryCode_Billing
      };
      if (parentlstSalutationsRowBylstSalutationstblQuotes != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parentlstSalutationsRowBylstSalutationstblQuotes[0]);
      if (parentlstBusinessTypesRowBylstBusinessTypestblQuotes != null)
        objArray[53] = RuntimeHelpers.GetObjectValue(parentlstBusinessTypesRowBylstBusinessTypestblQuotes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow FindByQuoteGUID(Guid QuoteGUID)
    {
      return (dsQuoteEdit2.tblQuotesRow) this.Rows.Find(new object[1]
      {
        (object) QuoteGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit2.tblQuotesDataTable tblQuotesDataTable = (dsQuoteEdit2.tblQuotesDataTable) base.Clone();
      tblQuotesDataTable.InitVars();
      return (DataTable) tblQuotesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit2.tblQuotesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnInsuredDBA = this.Columns["InsuredDBA"];
      this.columnInsuredFEIN = this.Columns["InsuredFEIN"];
      this.columnInsuredSSN = this.Columns["InsuredSSN"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnInsuredCorporationName = this.Columns["InsuredCorporationName"];
      this.columnInsuredSalutation = this.Columns["InsuredSalutation"];
      this.columnInsuredFirstName = this.Columns["InsuredFirstName"];
      this.columnInsuredMiddleName = this.Columns["InsuredMiddleName"];
      this.columnInsuredLastName = this.Columns["InsuredLastName"];
      this.columnInsuredAddress1 = this.Columns["InsuredAddress1"];
      this.columnInsuredAddress2 = this.Columns["InsuredAddress2"];
      this.columnInsuredCity = this.Columns["InsuredCity"];
      this.columnInsuredCounty = this.Columns["InsuredCounty"];
      this.columnInsuredZipCode = this.Columns["InsuredZipCode"];
      this.columnInsuredState = this.Columns["InsuredState"];
      this.columnInsuredRegion = this.Columns["InsuredRegion"];
      this.columnInsuredISOCountryCode = this.Columns["InsuredISOCountryCode"];
      this.columnInsuredZipPlus = this.Columns["InsuredZipPlus"];
      this.columnInsuredPhone = this.Columns["InsuredPhone"];
      this.columnInsuredFax = this.Columns["InsuredFax"];
      this.columnInsuredAddress1_Billing = this.Columns["InsuredAddress1_Billing"];
      this.columnInsuredAddress2_Billing = this.Columns["InsuredAddress2_Billing"];
      this.columnInsuredCity_Billing = this.Columns["InsuredCity_Billing"];
      this.columnInsuredCounty_Billing = this.Columns["InsuredCounty_Billing"];
      this.columnInsuredISOCountryCode_Billing = this.Columns["InsuredISOCountryCode_Billing"];
      this.columnInsuredZipCode_Billing = this.Columns["InsuredZipCode_Billing"];
      this.columnInsuredState_Billing = this.Columns["InsuredState_Billing"];
      this.columnInsuredZipPlus_Billing = this.Columns["InsuredZipPlus_Billing"];
      this.columnInsuredPhone_Billing = this.Columns["InsuredPhone_Billing"];
      this.columnInsuredFax_Billing = this.Columns["InsuredFax_Billing"];
      this.columnInsuredRegion_Billing = this.Columns["InsuredRegion_Billing"];
      this.columnProducerName = this.Columns["ProducerName"];
      this.columnProducerLocationName = this.Columns["ProducerLocationName"];
      this.columnProducerAddress1 = this.Columns["ProducerAddress1"];
      this.columnProducerAddress2 = this.Columns["ProducerAddress2"];
      this.columnProducerCity = this.Columns["ProducerCity"];
      this.columnProducerCounty = this.Columns["ProducerCounty"];
      this.columnProducerState = this.Columns["ProducerState"];
      this.columnProducerZipCode = this.Columns["ProducerZipCode"];
      this.columnProducerZipPlus = this.Columns["ProducerZipPlus"];
      this.columnProducerPhone = this.Columns["ProducerPhone"];
      this.columnProducerFax = this.Columns["ProducerFax"];
      this.columnProducerAddress1_Billing = this.Columns["ProducerAddress1_Billing"];
      this.columnProducerAddress2_Billing = this.Columns["ProducerAddress2_Billing"];
      this.columnProducerCity_Billing = this.Columns["ProducerCity_Billing"];
      this.columnProducerCounty_Billing = this.Columns["ProducerCounty_Billing"];
      this.columnProducerState_Billing = this.Columns["ProducerState_Billing"];
      this.columnProducerZipCode_Billing = this.Columns["ProducerZipCode_Billing"];
      this.columnProducerZipPlus_Billing = this.Columns["ProducerZipPlus_Billing"];
      this.columnProducerPhone_Billing = this.Columns["ProducerPhone_Billing"];
      this.columnProducerFax_Billing = this.Columns["ProducerFax_Billing"];
      this.columnCostCenterID = this.Columns["CostCenterID"];
      this.columnInsuredBusinessTypeID = this.Columns["InsuredBusinessTypeID"];
      this.columnInsuredMobileNumber = this.Columns["InsuredMobileNumber"];
      this.columnInsuredBillingEmail = this.Columns["InsuredBillingEmail"];
      this.columnInsuredBillingContact = this.Columns["InsuredBillingContact"];
      this.columnProducerISOCountryCode = this.Columns["ProducerISOCountryCode"];
      this.columnProducerISOCountryCode_Billing = this.Columns["ProducerISOCountryCode_Billing"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnInsuredDBA = new DataColumn("InsuredDBA", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredDBA);
      this.columnInsuredFEIN = new DataColumn("InsuredFEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredFEIN);
      this.columnInsuredSSN = new DataColumn("InsuredSSN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredSSN);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnInsuredCorporationName = new DataColumn("InsuredCorporationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredCorporationName);
      this.columnInsuredSalutation = new DataColumn("InsuredSalutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredSalutation);
      this.columnInsuredFirstName = new DataColumn("InsuredFirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredFirstName);
      this.columnInsuredMiddleName = new DataColumn("InsuredMiddleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredMiddleName);
      this.columnInsuredLastName = new DataColumn("InsuredLastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLastName);
      this.columnInsuredAddress1 = new DataColumn("InsuredAddress1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredAddress1);
      this.columnInsuredAddress2 = new DataColumn("InsuredAddress2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredAddress2);
      this.columnInsuredCity = new DataColumn("InsuredCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredCity);
      this.columnInsuredCounty = new DataColumn("InsuredCounty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredCounty);
      this.columnInsuredZipCode = new DataColumn("InsuredZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredZipCode);
      this.columnInsuredState = new DataColumn("InsuredState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredState);
      this.columnInsuredRegion = new DataColumn("InsuredRegion", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredRegion);
      this.columnInsuredISOCountryCode = new DataColumn("InsuredISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredISOCountryCode);
      this.columnInsuredZipPlus = new DataColumn("InsuredZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredZipPlus);
      this.columnInsuredPhone = new DataColumn("InsuredPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPhone);
      this.columnInsuredFax = new DataColumn("InsuredFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredFax);
      this.columnInsuredAddress1_Billing = new DataColumn("InsuredAddress1_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredAddress1_Billing);
      this.columnInsuredAddress2_Billing = new DataColumn("InsuredAddress2_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredAddress2_Billing);
      this.columnInsuredCity_Billing = new DataColumn("InsuredCity_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredCity_Billing);
      this.columnInsuredCounty_Billing = new DataColumn("InsuredCounty_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredCounty_Billing);
      this.columnInsuredISOCountryCode_Billing = new DataColumn("InsuredISOCountryCode_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredISOCountryCode_Billing);
      this.columnInsuredZipCode_Billing = new DataColumn("InsuredZipCode_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredZipCode_Billing);
      this.columnInsuredState_Billing = new DataColumn("InsuredState_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredState_Billing);
      this.columnInsuredZipPlus_Billing = new DataColumn("InsuredZipPlus_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredZipPlus_Billing);
      this.columnInsuredPhone_Billing = new DataColumn("InsuredPhone_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPhone_Billing);
      this.columnInsuredFax_Billing = new DataColumn("InsuredFax_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredFax_Billing);
      this.columnInsuredRegion_Billing = new DataColumn("InsuredRegion_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredRegion_Billing);
      this.columnProducerName = new DataColumn("ProducerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerName);
      this.columnProducerLocationName = new DataColumn("ProducerLocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationName);
      this.columnProducerAddress1 = new DataColumn("ProducerAddress1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerAddress1);
      this.columnProducerAddress2 = new DataColumn("ProducerAddress2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerAddress2);
      this.columnProducerCity = new DataColumn("ProducerCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCity);
      this.columnProducerCounty = new DataColumn("ProducerCounty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCounty);
      this.columnProducerState = new DataColumn("ProducerState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerState);
      this.columnProducerZipCode = new DataColumn("ProducerZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerZipCode);
      this.columnProducerZipPlus = new DataColumn("ProducerZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerZipPlus);
      this.columnProducerPhone = new DataColumn("ProducerPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPhone);
      this.columnProducerFax = new DataColumn("ProducerFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerFax);
      this.columnProducerAddress1_Billing = new DataColumn("ProducerAddress1_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerAddress1_Billing);
      this.columnProducerAddress2_Billing = new DataColumn("ProducerAddress2_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerAddress2_Billing);
      this.columnProducerCity_Billing = new DataColumn("ProducerCity_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCity_Billing);
      this.columnProducerCounty_Billing = new DataColumn("ProducerCounty_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCounty_Billing);
      this.columnProducerState_Billing = new DataColumn("ProducerState_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerState_Billing);
      this.columnProducerZipCode_Billing = new DataColumn("ProducerZipCode_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerZipCode_Billing);
      this.columnProducerZipPlus_Billing = new DataColumn("ProducerZipPlus_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerZipPlus_Billing);
      this.columnProducerPhone_Billing = new DataColumn("ProducerPhone_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPhone_Billing);
      this.columnProducerFax_Billing = new DataColumn("ProducerFax_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerFax_Billing);
      this.columnCostCenterID = new DataColumn("CostCenterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterID);
      this.columnInsuredBusinessTypeID = new DataColumn("InsuredBusinessTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredBusinessTypeID);
      this.columnInsuredMobileNumber = new DataColumn("InsuredMobileNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredMobileNumber);
      this.columnInsuredBillingEmail = new DataColumn("InsuredBillingEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredBillingEmail);
      this.columnInsuredBillingContact = new DataColumn("InsuredBillingContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredBillingContact);
      this.columnProducerISOCountryCode = new DataColumn("ProducerISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerISOCountryCode);
      this.columnProducerISOCountryCode_Billing = new DataColumn("ProducerISOCountryCode_Billing", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerISOCountryCode_Billing);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEdit2Key1", new DataColumn[1]
      {
        this.columnQuoteGUID
      }, true));
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnQuoteGUID.Unique = true;
      this.columnInsuredPolicyName.AllowDBNull = false;
      this.columnInsuredAddress1.AllowDBNull = false;
      this.columnInsuredCity.AllowDBNull = false;
      this.columnInsuredISOCountryCode.DefaultValue = (object) "USA";
      this.columnProducerName.AllowDBNull = false;
      this.columnProducerLocationName.AllowDBNull = false;
      this.columnProducerAddress1.AllowDBNull = false;
      this.columnProducerCity.AllowDBNull = false;
      this.columnProducerZipCode.AllowDBNull = false;
      this.columnInsuredBillingEmail.MaxLength = 50;
      this.columnInsuredBillingContact.MaxLength = 350;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow NewtblQuotesRow() => (dsQuoteEdit2.tblQuotesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit2.tblQuotesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit2.tblQuotesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblQuotesRowChangeEventHandler quotesRowChangedEvent = this.tblQuotesRowChangedEvent;
      if (quotesRowChangedEvent == null)
        return;
      quotesRowChangedEvent((object) this, new dsQuoteEdit2.tblQuotesRowChangeEvent((dsQuoteEdit2.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblQuotesRowChangeEventHandler rowChangingEvent = this.tblQuotesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit2.tblQuotesRowChangeEvent((dsQuoteEdit2.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblQuotesRowChangeEventHandler quotesRowDeletedEvent = this.tblQuotesRowDeletedEvent;
      if (quotesRowDeletedEvent == null)
        return;
      quotesRowDeletedEvent((object) this, new dsQuoteEdit2.tblQuotesRowChangeEvent((dsQuoteEdit2.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblQuotesRowChangeEventHandler rowDeletingEvent = this.tblQuotesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit2.tblQuotesRowChangeEvent((dsQuoteEdit2.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuotesRow(dsQuoteEdit2.tblQuotesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit2 dsQuoteEdit2 = new dsQuoteEdit2();
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
        FixedValue = dsQuoteEdit2.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuotesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit2.GetSchemaSerializable();
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
  public class lstSalutationsDataTable : TypedTableBase<dsQuoteEdit2.lstSalutationsRow>
  {
    private DataColumn columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSalutationsDataTable()
    {
      this.TableName = "lstSalutations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstSalutationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstSalutationsRow this[int index]
    {
      get => (dsQuoteEdit2.lstSalutationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstSalutationsRowChangeEventHandler lstSalutationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstSalutationsRowChangeEventHandler lstSalutationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstSalutationsRow(dsQuoteEdit2.lstSalutationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstSalutationsRow AddlstSalutationsRow(string Salutation)
    {
      dsQuoteEdit2.lstSalutationsRow row = (dsQuoteEdit2.lstSalutationsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) Salutation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstSalutationsRow FindBySalutation(string Salutation)
    {
      return (dsQuoteEdit2.lstSalutationsRow) this.Rows.Find(new object[1]
      {
        (object) Salutation
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit2.lstSalutationsDataTable salutationsDataTable = (dsQuoteEdit2.lstSalutationsDataTable) base.Clone();
      salutationsDataTable.InitVars();
      return (DataTable) salutationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit2.lstSalutationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.columnSalutation = this.Columns["Salutation"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEdit2Key2", new DataColumn[1]
      {
        this.columnSalutation
      }, true));
      this.columnSalutation.AllowDBNull = false;
      this.columnSalutation.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstSalutationsRow NewlstSalutationsRow()
    {
      return (dsQuoteEdit2.lstSalutationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit2.lstSalutationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit2.lstSalutationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstSalutationsRowChangeEventHandler salutationsRowChangedEvent = this.lstSalutationsRowChangedEvent;
      if (salutationsRowChangedEvent == null)
        return;
      salutationsRowChangedEvent((object) this, new dsQuoteEdit2.lstSalutationsRowChangeEvent((dsQuoteEdit2.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstSalutationsRowChangeEventHandler rowChangingEvent = this.lstSalutationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit2.lstSalutationsRowChangeEvent((dsQuoteEdit2.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstSalutationsRowChangeEventHandler salutationsRowDeletedEvent = this.lstSalutationsRowDeletedEvent;
      if (salutationsRowDeletedEvent == null)
        return;
      salutationsRowDeletedEvent((object) this, new dsQuoteEdit2.lstSalutationsRowChangeEvent((dsQuoteEdit2.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstSalutationsRowChangeEventHandler rowDeletingEvent = this.lstSalutationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit2.lstSalutationsRowChangeEvent((dsQuoteEdit2.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstSalutationsRow(dsQuoteEdit2.lstSalutationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit2 dsQuoteEdit2 = new dsQuoteEdit2();
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
        FixedValue = dsQuoteEdit2.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSalutationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit2.GetSchemaSerializable();
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
  public class tblEntityGroupsDataTable : TypedTableBase<dsQuoteEdit2.tblEntityGroupsRow>
  {
    private DataColumn columnGroupId;
    private DataColumn columnGroupName;
    private DataColumn columnIsDefault;
    private DataColumn columnSystemDefined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEntityGroupsDataTable()
    {
      this.TableName = "tblEntityGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEntityGroupsDataTable(DataTable table)
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
    protected tblEntityGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GroupIdColumn => this.columnGroupId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GroupNameColumn => this.columnGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsDefaultColumn => this.columnIsDefault;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SystemDefinedColumn => this.columnSystemDefined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblEntityGroupsRow this[int index]
    {
      get => (dsQuoteEdit2.tblEntityGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler tblEntityGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler tblEntityGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler tblEntityGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler tblEntityGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblEntityGroupsRow(dsQuoteEdit2.tblEntityGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblEntityGroupsRow AddtblEntityGroupsRow(
      string GroupName,
      bool IsDefault,
      bool SystemDefined)
    {
      dsQuoteEdit2.tblEntityGroupsRow row = (dsQuoteEdit2.tblEntityGroupsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) GroupName,
        (object) IsDefault,
        (object) SystemDefined
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblEntityGroupsRow FindByGroupId(int GroupId)
    {
      return (dsQuoteEdit2.tblEntityGroupsRow) this.Rows.Find(new object[1]
      {
        (object) GroupId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit2.tblEntityGroupsDataTable entityGroupsDataTable = (dsQuoteEdit2.tblEntityGroupsDataTable) base.Clone();
      entityGroupsDataTable.InitVars();
      return (DataTable) entityGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit2.tblEntityGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnGroupId = this.Columns["GroupId"];
      this.columnGroupName = this.Columns["GroupName"];
      this.columnIsDefault = this.Columns["IsDefault"];
      this.columnSystemDefined = this.Columns["SystemDefined"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnGroupId = new DataColumn("GroupId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupId);
      this.columnGroupName = new DataColumn("GroupName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupName);
      this.columnIsDefault = new DataColumn("IsDefault", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsDefault);
      this.columnSystemDefined = new DataColumn("SystemDefined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSystemDefined);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEdit2Key3", new DataColumn[1]
      {
        this.columnGroupId
      }, true));
      this.columnGroupId.AutoIncrement = true;
      this.columnGroupId.AllowDBNull = false;
      this.columnGroupId.ReadOnly = true;
      this.columnGroupId.Unique = true;
      this.columnGroupName.AllowDBNull = false;
      this.columnIsDefault.AllowDBNull = false;
      this.columnIsDefault.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblEntityGroupsRow NewtblEntityGroupsRow()
    {
      return (dsQuoteEdit2.tblEntityGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit2.tblEntityGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit2.tblEntityGroupsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler groupsRowChangedEvent = this.tblEntityGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsQuoteEdit2.tblEntityGroupsRowChangeEvent((dsQuoteEdit2.tblEntityGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler rowChangingEvent = this.tblEntityGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit2.tblEntityGroupsRowChangeEvent((dsQuoteEdit2.tblEntityGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler groupsRowDeletedEvent = this.tblEntityGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsQuoteEdit2.tblEntityGroupsRowChangeEvent((dsQuoteEdit2.tblEntityGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.tblEntityGroupsRowChangeEventHandler rowDeletingEvent = this.tblEntityGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit2.tblEntityGroupsRowChangeEvent((dsQuoteEdit2.tblEntityGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblEntityGroupsRow(dsQuoteEdit2.tblEntityGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit2 dsQuoteEdit2 = new dsQuoteEdit2();
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
        FixedValue = dsQuoteEdit2.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblEntityGroupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit2.GetSchemaSerializable();
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
  public class lstBusinessTypesDataTable : TypedTableBase<dsQuoteEdit2.lstBusinessTypesRow>
  {
    private DataColumn columnBusinessTypeID;
    private DataColumn columnBusinessType;
    private DataColumn columnIndividual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBusinessTypesDataTable()
    {
      this.TableName = "lstBusinessTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBusinessTypesDataTable(DataTable table)
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
    protected lstBusinessTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BusinessTypeIDColumn => this.columnBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BusinessTypeColumn => this.columnBusinessType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IndividualColumn => this.columnIndividual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstBusinessTypesRow this[int index]
    {
      get => (dsQuoteEdit2.lstBusinessTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstBusinessTypesRow(dsQuoteEdit2.lstBusinessTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstBusinessTypesRow AddlstBusinessTypesRow(
      int BusinessTypeID,
      string BusinessType,
      bool Individual)
    {
      dsQuoteEdit2.lstBusinessTypesRow row = (dsQuoteEdit2.lstBusinessTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) BusinessTypeID,
        (object) BusinessType,
        (object) Individual
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstBusinessTypesRow FindByBusinessTypeID(int BusinessTypeID)
    {
      return (dsQuoteEdit2.lstBusinessTypesRow) this.Rows.Find(new object[1]
      {
        (object) BusinessTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit2.lstBusinessTypesDataTable businessTypesDataTable = (dsQuoteEdit2.lstBusinessTypesDataTable) base.Clone();
      businessTypesDataTable.InitVars();
      return (DataTable) businessTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit2.lstBusinessTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnBusinessTypeID = this.Columns["BusinessTypeID"];
      this.columnBusinessType = this.Columns["BusinessType"];
      this.columnIndividual = this.Columns["Individual"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnBusinessTypeID = new DataColumn("BusinessTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessTypeID);
      this.columnBusinessType = new DataColumn("BusinessType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessType);
      this.columnIndividual = new DataColumn("Individual", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIndividual);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEdit2Key4", new DataColumn[1]
      {
        this.columnBusinessTypeID
      }, true));
      this.columnBusinessTypeID.AllowDBNull = false;
      this.columnBusinessTypeID.ReadOnly = true;
      this.columnBusinessTypeID.Unique = true;
      this.columnBusinessType.AllowDBNull = false;
      this.columnIndividual.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstBusinessTypesRow NewlstBusinessTypesRow()
    {
      return (dsQuoteEdit2.lstBusinessTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit2.lstBusinessTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit2.lstBusinessTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler typesRowChangedEvent = this.lstBusinessTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsQuoteEdit2.lstBusinessTypesRowChangeEvent((dsQuoteEdit2.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler rowChangingEvent = this.lstBusinessTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit2.lstBusinessTypesRowChangeEvent((dsQuoteEdit2.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler typesRowDeletedEvent = this.lstBusinessTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsQuoteEdit2.lstBusinessTypesRowChangeEvent((dsQuoteEdit2.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstBusinessTypesRowChangeEventHandler rowDeletingEvent = this.lstBusinessTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit2.lstBusinessTypesRowChangeEvent((dsQuoteEdit2.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstBusinessTypesRow(dsQuoteEdit2.lstBusinessTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit2 dsQuoteEdit2 = new dsQuoteEdit2();
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
        FixedValue = dsQuoteEdit2.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBusinessTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit2.GetSchemaSerializable();
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
  public class lstClaims_GenderDataTable : TypedTableBase<dsQuoteEdit2.lstClaims_GenderRow>
  {
    private DataColumn columnGenderId;
    private DataColumn columnGender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClaims_GenderDataTable()
    {
      this.TableName = "lstClaims_Gender";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClaims_GenderDataTable(DataTable table)
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
    protected lstClaims_GenderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GenderIdColumn => this.columnGenderId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GenderColumn => this.columnGender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstClaims_GenderRow this[int index]
    {
      get => (dsQuoteEdit2.lstClaims_GenderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstClaims_GenderRow(dsQuoteEdit2.lstClaims_GenderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstClaims_GenderRow AddlstClaims_GenderRow(int GenderId, string Gender)
    {
      dsQuoteEdit2.lstClaims_GenderRow row = (dsQuoteEdit2.lstClaims_GenderRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) GenderId,
        (object) Gender
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstClaims_GenderRow FindByGenderId(int GenderId)
    {
      return (dsQuoteEdit2.lstClaims_GenderRow) this.Rows.Find(new object[1]
      {
        (object) GenderId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit2.lstClaims_GenderDataTable claimsGenderDataTable = (dsQuoteEdit2.lstClaims_GenderDataTable) base.Clone();
      claimsGenderDataTable.InitVars();
      return (DataTable) claimsGenderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit2.lstClaims_GenderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnGenderId = this.Columns["GenderId"];
      this.columnGender = this.Columns["Gender"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnGenderId = new DataColumn("GenderId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenderId);
      this.columnGender = new DataColumn("Gender", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGender);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnGenderId
      }, true));
      this.columnGenderId.AllowDBNull = false;
      this.columnGenderId.Unique = true;
      this.columnGender.AllowDBNull = false;
      this.columnGender.MaxLength = 6;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstClaims_GenderRow NewlstClaims_GenderRow()
    {
      return (dsQuoteEdit2.lstClaims_GenderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit2.lstClaims_GenderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit2.lstClaims_GenderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler genderRowChangedEvent = this.lstClaims_GenderRowChangedEvent;
      if (genderRowChangedEvent == null)
        return;
      genderRowChangedEvent((object) this, new dsQuoteEdit2.lstClaims_GenderRowChangeEvent((dsQuoteEdit2.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler rowChangingEvent = this.lstClaims_GenderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit2.lstClaims_GenderRowChangeEvent((dsQuoteEdit2.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler genderRowDeletedEvent = this.lstClaims_GenderRowDeletedEvent;
      if (genderRowDeletedEvent == null)
        return;
      genderRowDeletedEvent((object) this, new dsQuoteEdit2.lstClaims_GenderRowChangeEvent((dsQuoteEdit2.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit2.lstClaims_GenderRowChangeEventHandler rowDeletingEvent = this.lstClaims_GenderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit2.lstClaims_GenderRowChangeEvent((dsQuoteEdit2.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstClaims_GenderRow(dsQuoteEdit2.lstClaims_GenderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit2 dsQuoteEdit2 = new dsQuoteEdit2();
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
        FixedValue = dsQuoteEdit2.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClaims_GenderDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit2.GetSchemaSerializable();
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

  public class tblQuotesRow : DataRow
  {
    private dsQuoteEdit2.tblQuotesDataTable tabletblQuotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuotesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuotes = (dsQuoteEdit2.tblQuotesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tabletblQuotes.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuotes.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredDBA
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredDBAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredDBA' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredDBAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredFEIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredFEINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredFEIN' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredFEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredSSN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredSSNColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredSSN' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredSSNColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredPolicyName
    {
      get => Conversions.ToString(this[this.tabletblQuotes.InsuredPolicyNameColumn]);
      set => this[this.tabletblQuotes.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredCorporationName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredCorporationNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredCorporationName' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredCorporationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredSalutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredSalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredSalutation' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredSalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredFirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredFirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredFirstName' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredFirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredMiddleName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredMiddleNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredMiddleName' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredMiddleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredLastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredLastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredLastName' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredLastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredAddress1
    {
      get => Conversions.ToString(this[this.tabletblQuotes.InsuredAddress1Column]);
      set => this[this.tabletblQuotes.InsuredAddress1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredAddress2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredAddress2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredAddress2' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredAddress2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredCity
    {
      get => Conversions.ToString(this[this.tabletblQuotes.InsuredCityColumn]);
      set => this[this.tabletblQuotes.InsuredCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredCounty
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredCountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredCounty' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredCountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredZipCode' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredState
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredStateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredState' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredRegion
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredRegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredRegion' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredRegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredISOCountryCode' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredZipPlus' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPhone' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredFax' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredAddress1_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredAddress1_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredAddress1_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredAddress1_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredAddress2_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredAddress2_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredAddress2_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredAddress2_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredCity_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredCity_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredCity_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredCity_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredCounty_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredCounty_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredCounty_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredCounty_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredISOCountryCode_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredISOCountryCode_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredISOCountryCode_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredISOCountryCode_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredZipCode_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredZipCode_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredZipCode_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredZipCode_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredState_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredState_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredState_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredState_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredZipPlus_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredZipPlus_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredZipPlus_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredZipPlus_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredPhone_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredPhone_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPhone_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredPhone_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredFax_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredFax_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredFax_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredFax_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredRegion_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredRegion_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredRegion_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredRegion_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerName
    {
      get => Conversions.ToString(this[this.tabletblQuotes.ProducerNameColumn]);
      set => this[this.tabletblQuotes.ProducerNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerLocationName
    {
      get => Conversions.ToString(this[this.tabletblQuotes.ProducerLocationNameColumn]);
      set => this[this.tabletblQuotes.ProducerLocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerAddress1
    {
      get => Conversions.ToString(this[this.tabletblQuotes.ProducerAddress1Column]);
      set => this[this.tabletblQuotes.ProducerAddress1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerAddress2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerAddress2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerAddress2' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerAddress2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerCity
    {
      get => Conversions.ToString(this[this.tabletblQuotes.ProducerCityColumn]);
      set => this[this.tabletblQuotes.ProducerCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerCounty
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerCountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCounty' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerCountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerState
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerStateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerState' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerZipCode
    {
      get => Conversions.ToString(this[this.tabletblQuotes.ProducerZipCodeColumn]);
      set => this[this.tabletblQuotes.ProducerZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerZipPlus' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerPhone' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerFax' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerAddress1_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerAddress1_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerAddress1_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerAddress1_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerAddress2_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerAddress2_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerAddress2_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerAddress2_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerCity_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerCity_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCity_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerCity_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerCounty_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerCounty_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCounty_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerCounty_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerState_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerState_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerState_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerState_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerZipCode_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerZipCode_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerZipCode_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerZipCode_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerZipPlus_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerZipPlus_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerZipPlus_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerZipPlus_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerPhone_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerPhone_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerPhone_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerPhone_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerFax_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerFax_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerFax_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerFax_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CostCenterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.CostCenterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CostCenterID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.CostCenterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InsuredBusinessTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.InsuredBusinessTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredBusinessTypeID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredBusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredMobileNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredMobileNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredMobileNumber' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredMobileNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredBillingEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredBillingEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredBillingEmail' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredBillingEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredBillingContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.InsuredBillingContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredBillingContact' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InsuredBillingContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerISOCountryCode' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerISOCountryCode_Billing
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ProducerISOCountryCode_BillingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerISOCountryCode_Billing' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerISOCountryCode_BillingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstBusinessTypesRow lstBusinessTypesRow
    {
      get
      {
        return (dsQuoteEdit2.lstBusinessTypesRow) this.GetParentRow(this.Table.ParentRelations["lstBusinessTypestblQuotes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstBusinessTypestblQuotes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstSalutationsRow lstSalutationsRow
    {
      get
      {
        return (dsQuoteEdit2.lstSalutationsRow) this.GetParentRow(this.Table.ParentRelations["lstSalutationstblQuotes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSalutationstblQuotes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredDBANull() => this.IsNull(this.tabletblQuotes.InsuredDBAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredDBANull()
    {
      this[this.tabletblQuotes.InsuredDBAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredFEINNull() => this.IsNull(this.tabletblQuotes.InsuredFEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredFEINNull()
    {
      this[this.tabletblQuotes.InsuredFEINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredSSNNull() => this.IsNull(this.tabletblQuotes.InsuredSSNColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredSSNNull()
    {
      this[this.tabletblQuotes.InsuredSSNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredCorporationNameNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredCorporationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredCorporationNameNull()
    {
      this[this.tabletblQuotes.InsuredCorporationNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredSalutationNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredSalutationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredSalutationNull()
    {
      this[this.tabletblQuotes.InsuredSalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredFirstNameNull() => this.IsNull(this.tabletblQuotes.InsuredFirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredFirstNameNull()
    {
      this[this.tabletblQuotes.InsuredFirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredMiddleNameNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredMiddleNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredMiddleNameNull()
    {
      this[this.tabletblQuotes.InsuredMiddleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredLastNameNull() => this.IsNull(this.tabletblQuotes.InsuredLastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredLastNameNull()
    {
      this[this.tabletblQuotes.InsuredLastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredAddress2Null() => this.IsNull(this.tabletblQuotes.InsuredAddress2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredAddress2Null()
    {
      this[this.tabletblQuotes.InsuredAddress2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredCountyNull() => this.IsNull(this.tabletblQuotes.InsuredCountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredCountyNull()
    {
      this[this.tabletblQuotes.InsuredCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredZipCodeNull() => this.IsNull(this.tabletblQuotes.InsuredZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredZipCodeNull()
    {
      this[this.tabletblQuotes.InsuredZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredStateNull() => this.IsNull(this.tabletblQuotes.InsuredStateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredStateNull()
    {
      this[this.tabletblQuotes.InsuredStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredRegionNull() => this.IsNull(this.tabletblQuotes.InsuredRegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredRegionNull()
    {
      this[this.tabletblQuotes.InsuredRegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredISOCountryCodeNull()
    {
      this[this.tabletblQuotes.InsuredISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredZipPlusNull() => this.IsNull(this.tabletblQuotes.InsuredZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredZipPlusNull()
    {
      this[this.tabletblQuotes.InsuredZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredPhoneNull() => this.IsNull(this.tabletblQuotes.InsuredPhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredPhoneNull()
    {
      this[this.tabletblQuotes.InsuredPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredFaxNull() => this.IsNull(this.tabletblQuotes.InsuredFaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredFaxNull()
    {
      this[this.tabletblQuotes.InsuredFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredAddress1_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredAddress1_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredAddress1_BillingNull()
    {
      this[this.tabletblQuotes.InsuredAddress1_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredAddress2_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredAddress2_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredAddress2_BillingNull()
    {
      this[this.tabletblQuotes.InsuredAddress2_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredCity_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredCity_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredCity_BillingNull()
    {
      this[this.tabletblQuotes.InsuredCity_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredCounty_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredCounty_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredCounty_BillingNull()
    {
      this[this.tabletblQuotes.InsuredCounty_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredISOCountryCode_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredISOCountryCode_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredISOCountryCode_BillingNull()
    {
      this[this.tabletblQuotes.InsuredISOCountryCode_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredZipCode_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredZipCode_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredZipCode_BillingNull()
    {
      this[this.tabletblQuotes.InsuredZipCode_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredState_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredState_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredState_BillingNull()
    {
      this[this.tabletblQuotes.InsuredState_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredZipPlus_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredZipPlus_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredZipPlus_BillingNull()
    {
      this[this.tabletblQuotes.InsuredZipPlus_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredPhone_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredPhone_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredPhone_BillingNull()
    {
      this[this.tabletblQuotes.InsuredPhone_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredFax_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredFax_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredFax_BillingNull()
    {
      this[this.tabletblQuotes.InsuredFax_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredRegion_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredRegion_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredRegion_BillingNull()
    {
      this[this.tabletblQuotes.InsuredRegion_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerAddress2Null() => this.IsNull(this.tabletblQuotes.ProducerAddress2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerAddress2Null()
    {
      this[this.tabletblQuotes.ProducerAddress2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerCountyNull() => this.IsNull(this.tabletblQuotes.ProducerCountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerCountyNull()
    {
      this[this.tabletblQuotes.ProducerCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerStateNull() => this.IsNull(this.tabletblQuotes.ProducerStateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerStateNull()
    {
      this[this.tabletblQuotes.ProducerStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerZipPlusNull() => this.IsNull(this.tabletblQuotes.ProducerZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerZipCodeNull() => this.IsNull(this.tabletblQuotes.ProducerZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerZipCodeNull()
    {
      this[this.tabletblQuotes.ProducerZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerZipPlusNull()
    {
      this[this.tabletblQuotes.ProducerZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerPhoneNull() => this.IsNull(this.tabletblQuotes.ProducerPhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerPhoneNull()
    {
      this[this.tabletblQuotes.ProducerPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerFaxNull() => this.IsNull(this.tabletblQuotes.ProducerFaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerFaxNull()
    {
      this[this.tabletblQuotes.ProducerFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerAddress1_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerAddress1_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerAddress1_BillingNull()
    {
      this[this.tabletblQuotes.ProducerAddress1_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerAddress2_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerAddress2_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerAddress2_BillingNull()
    {
      this[this.tabletblQuotes.ProducerAddress2_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerCity_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerCity_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerCity_BillingNull()
    {
      this[this.tabletblQuotes.ProducerCity_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerCounty_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerCounty_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerCounty_BillingNull()
    {
      this[this.tabletblQuotes.ProducerCounty_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerState_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerState_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerState_BillingNull()
    {
      this[this.tabletblQuotes.ProducerState_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerZipCode_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerZipCode_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerZipCode_BillingNull()
    {
      this[this.tabletblQuotes.ProducerZipCode_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerZipPlus_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerZipPlus_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerZipPlus_BillingNull()
    {
      this[this.tabletblQuotes.ProducerZipPlus_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerPhone_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerPhone_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerPhone_BillingNull()
    {
      this[this.tabletblQuotes.ProducerPhone_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerFax_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerFax_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerFax_BillingNull()
    {
      this[this.tabletblQuotes.ProducerFax_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCostCenterIDNull() => this.IsNull(this.tabletblQuotes.CostCenterIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCostCenterIDNull()
    {
      this[this.tabletblQuotes.CostCenterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredBusinessTypeIDNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredBusinessTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredBusinessTypeIDNull()
    {
      this[this.tabletblQuotes.InsuredBusinessTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredMobileNumberNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredMobileNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredMobileNumberNull()
    {
      this[this.tabletblQuotes.InsuredMobileNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredBillingEmailNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredBillingEmailColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredBillingEmailNull()
    {
      this[this.tabletblQuotes.InsuredBillingEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredBillingContactNull()
    {
      return this.IsNull(this.tabletblQuotes.InsuredBillingContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredBillingContactNull()
    {
      this[this.tabletblQuotes.InsuredBillingContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerISOCountryCodeNull()
    {
      this[this.tabletblQuotes.ProducerISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerISOCountryCode_BillingNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerISOCountryCode_BillingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerISOCountryCode_BillingNull()
    {
      this[this.tabletblQuotes.ProducerISOCountryCode_BillingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstSalutationsRow : DataRow
  {
    private dsQuoteEdit2.lstSalutationsDataTable tablelstSalutations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSalutationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSalutations = (dsQuoteEdit2.lstSalutationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Salutation
    {
      get => Conversions.ToString(this[this.tablelstSalutations.SalutationColumn]);
      set => this[this.tablelstSalutations.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow[] GettblQuotesRows()
    {
      return this.Table.ChildRelations["lstSalutationstblQuotes"] != null ? (dsQuoteEdit2.tblQuotesRow[]) this.GetChildRows(this.Table.ChildRelations["lstSalutationstblQuotes"]) : new dsQuoteEdit2.tblQuotesRow[0];
    }
  }

  public class tblEntityGroupsRow : DataRow
  {
    private dsQuoteEdit2.tblEntityGroupsDataTable tabletblEntityGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEntityGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblEntityGroups = (dsQuoteEdit2.tblEntityGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int GroupId
    {
      get => Conversions.ToInteger(this[this.tabletblEntityGroups.GroupIdColumn]);
      set => this[this.tabletblEntityGroups.GroupIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string GroupName
    {
      get => Conversions.ToString(this[this.tabletblEntityGroups.GroupNameColumn]);
      set => this[this.tabletblEntityGroups.GroupNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefault
    {
      get => Conversions.ToBoolean(this[this.tabletblEntityGroups.IsDefaultColumn]);
      set => this[this.tabletblEntityGroups.IsDefaultColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool SystemDefined
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblEntityGroups.SystemDefinedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SystemDefined' in table 'tblEntityGroups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityGroups.SystemDefinedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSystemDefinedNull() => this.IsNull(this.tabletblEntityGroups.SystemDefinedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSystemDefinedNull()
    {
      this[this.tabletblEntityGroups.SystemDefinedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstBusinessTypesRow : DataRow
  {
    private dsQuoteEdit2.lstBusinessTypesDataTable tablelstBusinessTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBusinessTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBusinessTypes = (dsQuoteEdit2.lstBusinessTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int BusinessTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstBusinessTypes.BusinessTypeIDColumn]);
      set => this[this.tablelstBusinessTypes.BusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BusinessType
    {
      get => Conversions.ToString(this[this.tablelstBusinessTypes.BusinessTypeColumn]);
      set => this[this.tablelstBusinessTypes.BusinessTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Individual
    {
      get => Conversions.ToBoolean(this[this.tablelstBusinessTypes.IndividualColumn]);
      set => this[this.tablelstBusinessTypes.IndividualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow[] GettblQuotesRows()
    {
      return this.Table.ChildRelations["lstBusinessTypestblQuotes"] != null ? (dsQuoteEdit2.tblQuotesRow[]) this.GetChildRows(this.Table.ChildRelations["lstBusinessTypestblQuotes"]) : new dsQuoteEdit2.tblQuotesRow[0];
    }
  }

  public class lstClaims_GenderRow : DataRow
  {
    private dsQuoteEdit2.lstClaims_GenderDataTable tablelstClaims_Gender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClaims_GenderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClaims_Gender = (dsQuoteEdit2.lstClaims_GenderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int GenderId
    {
      get => Conversions.ToInteger(this[this.tablelstClaims_Gender.GenderIdColumn]);
      set => this[this.tablelstClaims_Gender.GenderIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Gender
    {
      get => Conversions.ToString(this[this.tablelstClaims_Gender.GenderColumn]);
      set => this[this.tablelstClaims_Gender.GenderColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuotesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit2.tblQuotesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuotesRowChangeEvent(dsQuoteEdit2.tblQuotesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblQuotesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstSalutationsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit2.lstSalutationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSalutationsRowChangeEvent(dsQuoteEdit2.lstSalutationsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstSalutationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblEntityGroupsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit2.tblEntityGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEntityGroupsRowChangeEvent(dsQuoteEdit2.tblEntityGroupsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.tblEntityGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstBusinessTypesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit2.lstBusinessTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBusinessTypesRowChangeEvent(
      dsQuoteEdit2.lstBusinessTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstBusinessTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstClaims_GenderRowChangeEvent : EventArgs
  {
    private dsQuoteEdit2.lstClaims_GenderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClaims_GenderRowChangeEvent(
      dsQuoteEdit2.lstClaims_GenderRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsQuoteEdit2.lstClaims_GenderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
