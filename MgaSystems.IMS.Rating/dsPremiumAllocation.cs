// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsPremiumAllocation
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
[XmlRoot("dsPremiumAllocation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPremiumAllocation : DataSet
{
  private dsPremiumAllocation.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsPremiumAllocation.lstStatesDataTable tablelstStates;
  private dsPremiumAllocation.tblClientOfficesDataTable tabletblClientOffices;
  private dsPremiumAllocation.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsPremiumAllocation.tblQuoteOptionGenericDataTable tabletblQuoteOptionGeneric;
  private dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable tabletblPremiumAllocationCompanies;
  private dsPremiumAllocation.tblPremiumAllocationStatesDataTable tabletblPremiumAllocationStates;
  private DataRelation relationtblQuoteOptionstblQuoteOptionGeneric;
  private DataRelation relationtblCompanyLocationstblPremiumAllocationCompanies;
  private DataRelation relationtblClientOfficestblPremiumAllocationStates;
  private DataRelation relationlstStatestblPremiumAllocationStates;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPremiumAllocation()
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
  protected dsPremiumAllocation(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (tblQuoteOptionGeneric)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.tblQuoteOptionGenericDataTable(dataSet.Tables[nameof (tblQuoteOptionGeneric)]));
        if (dataSet.Tables[nameof (tblPremiumAllocationCompanies)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable(dataSet.Tables[nameof (tblPremiumAllocationCompanies)]));
        if (dataSet.Tables[nameof (tblPremiumAllocationStates)] != null)
          base.Tables.Add((DataTable) new dsPremiumAllocation.tblPremiumAllocationStatesDataTable(dataSet.Tables[nameof (tblPremiumAllocationStates)]));
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
  public dsPremiumAllocation.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumAllocation.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumAllocation.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumAllocation.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumAllocation.tblQuoteOptionGenericDataTable tblQuoteOptionGeneric
  {
    get => this.tabletblQuoteOptionGeneric;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable tblPremiumAllocationCompanies
  {
    get => this.tabletblPremiumAllocationCompanies;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumAllocation.tblPremiumAllocationStatesDataTable tblPremiumAllocationStates
  {
    get => this.tabletblPremiumAllocationStates;
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
    dsPremiumAllocation premiumAllocation = (dsPremiumAllocation) base.Clone();
    premiumAllocation.InitVars();
    premiumAllocation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) premiumAllocation;
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
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["tblQuoteOptionGeneric"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.tblQuoteOptionGenericDataTable(dataSet.Tables["tblQuoteOptionGeneric"]));
      if (dataSet.Tables["tblPremiumAllocationCompanies"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable(dataSet.Tables["tblPremiumAllocationCompanies"]));
      if (dataSet.Tables["tblPremiumAllocationStates"] != null)
        base.Tables.Add((DataTable) new dsPremiumAllocation.tblPremiumAllocationStatesDataTable(dataSet.Tables["tblPremiumAllocationStates"]));
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
    this.tabletblCompanyLocations = (dsPremiumAllocation.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tablelstStates = (dsPremiumAllocation.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tabletblClientOffices = (dsPremiumAllocation.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblQuoteOptions = (dsPremiumAllocation.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tabletblQuoteOptionGeneric = (dsPremiumAllocation.tblQuoteOptionGenericDataTable) base.Tables["tblQuoteOptionGeneric"];
    if (initTable && this.tabletblQuoteOptionGeneric != null)
      this.tabletblQuoteOptionGeneric.InitVars();
    this.tabletblPremiumAllocationCompanies = (dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable) base.Tables["tblPremiumAllocationCompanies"];
    if (initTable && this.tabletblPremiumAllocationCompanies != null)
      this.tabletblPremiumAllocationCompanies.InitVars();
    this.tabletblPremiumAllocationStates = (dsPremiumAllocation.tblPremiumAllocationStatesDataTable) base.Tables["tblPremiumAllocationStates"];
    if (initTable && this.tabletblPremiumAllocationStates != null)
      this.tabletblPremiumAllocationStates.InitVars();
    this.relationtblQuoteOptionstblQuoteOptionGeneric = this.Relations["tblQuoteOptionstblQuoteOptionGeneric"];
    this.relationtblCompanyLocationstblPremiumAllocationCompanies = this.Relations["tblCompanyLocationstblPremiumAllocationCompanies"];
    this.relationtblClientOfficestblPremiumAllocationStates = this.Relations["tblClientOfficestblPremiumAllocationStates"];
    this.relationlstStatestblPremiumAllocationStates = this.Relations["lstStatestblPremiumAllocationStates"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPremiumAllocation);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPremiumAllocation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLocations = new dsPremiumAllocation.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tablelstStates = new dsPremiumAllocation.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tabletblClientOffices = new dsPremiumAllocation.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblQuoteOptions = new dsPremiumAllocation.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tabletblQuoteOptionGeneric = new dsPremiumAllocation.tblQuoteOptionGenericDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionGeneric);
    this.tabletblPremiumAllocationCompanies = new dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblPremiumAllocationCompanies);
    this.tabletblPremiumAllocationStates = new dsPremiumAllocation.tblPremiumAllocationStatesDataTable();
    base.Tables.Add((DataTable) this.tabletblPremiumAllocationStates);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblQuoteOptionstblQuoteOptionGeneric", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionGeneric.QuoteOptionGuidColumn
    });
    this.tabletblQuoteOptionGeneric.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblCompanyLocationstblPremiumAllocationCompanies", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPremiumAllocationCompanies.CompanyLocationGUIDColumn
    });
    this.tabletblPremiumAllocationCompanies.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblClientOfficestblPremiumAllocationStates", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPremiumAllocationStates.QuotingLocationIDColumn
    });
    this.tabletblPremiumAllocationStates.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstStatestblPremiumAllocationStates", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPremiumAllocationStates.StateIDColumn
    });
    this.tabletblPremiumAllocationStates.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    this.relationtblQuoteOptionstblQuoteOptionGeneric = new DataRelation("tblQuoteOptionstblQuoteOptionGeneric", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionGeneric.QuoteOptionGuidColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionstblQuoteOptionGeneric);
    this.relationtblCompanyLocationstblPremiumAllocationCompanies = new DataRelation("tblCompanyLocationstblPremiumAllocationCompanies", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPremiumAllocationCompanies.CompanyLocationGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLocationstblPremiumAllocationCompanies);
    this.relationtblClientOfficestblPremiumAllocationStates = new DataRelation("tblClientOfficestblPremiumAllocationStates", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPremiumAllocationStates.QuotingLocationIDColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblPremiumAllocationStates);
    this.relationlstStatestblPremiumAllocationStates = new DataRelation("lstStatestblPremiumAllocationStates", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPremiumAllocationStates.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatestblPremiumAllocationStates);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptionGeneric() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblPremiumAllocationCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblPremiumAllocationStates() => false;

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
    dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = premiumAllocation.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionGenericRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.tblQuoteOptionGenericRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblPremiumAllocationCompaniesRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblPremiumAllocationStatesRowChangeEventHandler(
    object sender,
    dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLocationsDataTable : 
    TypedTableBase<dsPremiumAllocation.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLocationsDataTable(DataTable table)
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
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblCompanyLocationsRow this[int index]
    {
      get => (dsPremiumAllocation.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLocationsRow(dsPremiumAllocation.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      Guid CompanyLocationGUID,
      string LocationName)
    {
      dsPremiumAllocation.tblCompanyLocationsRow row = (dsPremiumAllocation.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLocationGUID,
        (object) LocationName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblCompanyLocationsRow FindByCompanyLocationGUID(
      Guid CompanyLocationGUID)
    {
      return (dsPremiumAllocation.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.tblCompanyLocationsDataTable locationsDataTable = (dsPremiumAllocation.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnLocationName = this.Columns["LocationName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey1", new DataColumn[1]
      {
        this.columnCompanyLocationGUID
      }, true));
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.Unique = true;
      this.columnLocationName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsPremiumAllocation.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPremiumAllocation.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsPremiumAllocation.tblCompanyLocationsRowChangeEvent((dsPremiumAllocation.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.tblCompanyLocationsRowChangeEvent((dsPremiumAllocation.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsPremiumAllocation.tblCompanyLocationsRowChangeEvent((dsPremiumAllocation.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.tblCompanyLocationsRowChangeEvent((dsPremiumAllocation.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsPremiumAllocation.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsPremiumAllocation.lstStatesRow>
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
    public dsPremiumAllocation.lstStatesRow this[int index]
    {
      get => (dsPremiumAllocation.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatesRow(dsPremiumAllocation.lstStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsPremiumAllocation.lstStatesRow row = (dsPremiumAllocation.lstStatesRow) this.NewRow();
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
    public dsPremiumAllocation.lstStatesRow FindByStateID(string StateID)
    {
      return (dsPremiumAllocation.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.lstStatesDataTable lstStatesDataTable = (dsPremiumAllocation.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.lstStatesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey3", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnState.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.lstStatesRow NewlstStatesRow()
    {
      return (dsPremiumAllocation.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPremiumAllocation.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsPremiumAllocation.lstStatesRowChangeEvent((dsPremiumAllocation.lstStatesRow) e.Row, e.Action));
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
      dsPremiumAllocation.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.lstStatesRowChangeEvent((dsPremiumAllocation.lstStatesRow) e.Row, e.Action));
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
      dsPremiumAllocation.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsPremiumAllocation.lstStatesRowChangeEvent((dsPremiumAllocation.lstStatesRow) e.Row, e.Action));
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
      dsPremiumAllocation.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.lstStatesRowChangeEvent((dsPremiumAllocation.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatesRow(dsPremiumAllocation.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsPremiumAllocation.tblClientOfficesRow>
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
    public dsPremiumAllocation.tblClientOfficesRow this[int index]
    {
      get => (dsPremiumAllocation.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblClientOfficesRow(dsPremiumAllocation.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblClientOfficesRow AddtblClientOfficesRow(
      int OfficeID,
      string Location)
    {
      dsPremiumAllocation.tblClientOfficesRow row = (dsPremiumAllocation.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) OfficeID,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblClientOfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsPremiumAllocation.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.tblClientOfficesDataTable officesDataTable = (dsPremiumAllocation.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.tblClientOfficesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey4", new DataColumn[1]
      {
        this.columnOfficeID
      }, true));
      this.columnOfficeID.AllowDBNull = false;
      this.columnOfficeID.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsPremiumAllocation.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPremiumAllocation.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsPremiumAllocation.tblClientOfficesRowChangeEvent((dsPremiumAllocation.tblClientOfficesRow) e.Row, e.Action));
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
      dsPremiumAllocation.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.tblClientOfficesRowChangeEvent((dsPremiumAllocation.tblClientOfficesRow) e.Row, e.Action));
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
      dsPremiumAllocation.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsPremiumAllocation.tblClientOfficesRowChangeEvent((dsPremiumAllocation.tblClientOfficesRow) e.Row, e.Action));
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
      dsPremiumAllocation.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.tblClientOfficesRowChangeEvent((dsPremiumAllocation.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblClientOfficesRow(dsPremiumAllocation.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public class tblQuoteOptionsDataTable : TypedTableBase<dsPremiumAllocation.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteOptionGUID;
    private DataColumn columnQuoteGUID;
    private DataColumn columnLineGUID;
    private DataColumn columnCompanyLocationID;

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
    public DataColumn QuoteOptionGUIDColumn => this.columnQuoteOptionGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionsRow this[int index]
    {
      get => (dsPremiumAllocation.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionsRow(dsPremiumAllocation.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteOptionGUID,
      Guid QuoteGUID,
      Guid LineGUID,
      int CompanyLocationID)
    {
      dsPremiumAllocation.tblQuoteOptionsRow row = (dsPremiumAllocation.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) QuoteOptionGUID,
        (object) QuoteGUID,
        (object) LineGUID,
        (object) CompanyLocationID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionsRow FindByQuoteOptionGUID(Guid QuoteOptionGUID)
    {
      return (dsPremiumAllocation.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.tblQuoteOptionsDataTable optionsDataTable = (dsPremiumAllocation.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionGUID = this.Columns["QuoteOptionGUID"];
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionGUID = new DataColumn("QuoteOptionGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGUID);
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey5", new DataColumn[1]
      {
        this.columnQuoteOptionGUID
      }, true));
      this.columnQuoteOptionGUID.AllowDBNull = false;
      this.columnQuoteOptionGUID.Unique = true;
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsPremiumAllocation.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPremiumAllocation.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPremiumAllocation.tblQuoteOptionsRowChangeEvent((dsPremiumAllocation.tblQuoteOptionsRow) e.Row, e.Action));
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
      dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.tblQuoteOptionsRowChangeEvent((dsPremiumAllocation.tblQuoteOptionsRow) e.Row, e.Action));
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
      dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPremiumAllocation.tblQuoteOptionsRowChangeEvent((dsPremiumAllocation.tblQuoteOptionsRow) e.Row, e.Action));
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
      dsPremiumAllocation.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.tblQuoteOptionsRowChangeEvent((dsPremiumAllocation.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsPremiumAllocation.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public class tblQuoteOptionGenericDataTable : 
    TypedTableBase<dsPremiumAllocation.tblQuoteOptionGenericRow>
  {
    private DataColumn columnGenericID;
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnOfficeID;
    private DataColumn columnPremium;
    private DataColumn columnEffectiveDate;
    private DataColumn columnTerrorismPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionGenericDataTable()
    {
      this.TableName = "tblQuoteOptionGeneric";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionGenericDataTable(DataTable table)
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
    protected tblQuoteOptionGenericDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GenericIDColumn => this.columnGenericID;

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
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismPremiumColumn => this.columnTerrorismPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionGenericRow this[int index]
    {
      get => (dsPremiumAllocation.tblQuoteOptionGenericRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler tblQuoteOptionGenericRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler tblQuoteOptionGenericRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler tblQuoteOptionGenericRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler tblQuoteOptionGenericRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionGenericRow(dsPremiumAllocation.tblQuoteOptionGenericRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionGenericRow AddtblQuoteOptionGenericRow(
      dsPremiumAllocation.tblQuoteOptionsRow parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionGeneric,
      int ChargeCode,
      int OfficeID,
      Decimal Premium,
      DateTime EffectiveDate,
      int TerrorismPremium)
    {
      dsPremiumAllocation.tblQuoteOptionGenericRow row = (dsPremiumAllocation.tblQuoteOptionGenericRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        null,
        (object) ChargeCode,
        (object) OfficeID,
        (object) Premium,
        (object) EffectiveDate,
        (object) TerrorismPremium
      };
      if (parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionGeneric != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionGeneric[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionGenericRow FindByGenericID(int GenericID)
    {
      return (dsPremiumAllocation.tblQuoteOptionGenericRow) this.Rows.Find(new object[1]
      {
        (object) GenericID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.tblQuoteOptionGenericDataTable genericDataTable = (dsPremiumAllocation.tblQuoteOptionGenericDataTable) base.Clone();
      genericDataTable.InitVars();
      return (DataTable) genericDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.tblQuoteOptionGenericDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGenericID = this.Columns["GenericID"];
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnPremium = this.Columns["Premium"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnTerrorismPremium = this.Columns["TerrorismPremium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGenericID = new DataColumn("GenericID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenericID);
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnTerrorismPremium = new DataColumn("TerrorismPremium", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey6", new DataColumn[1]
      {
        this.columnGenericID
      }, true));
      this.columnGenericID.AutoIncrement = true;
      this.columnGenericID.AllowDBNull = false;
      this.columnGenericID.ReadOnly = true;
      this.columnGenericID.Unique = true;
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnTerrorismPremium.AllowDBNull = false;
      this.columnTerrorismPremium.DefaultValue = (object) 0;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionGenericRow NewtblQuoteOptionGenericRow()
    {
      return (dsPremiumAllocation.tblQuoteOptionGenericRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.tblQuoteOptionGenericRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPremiumAllocation.tblQuoteOptionGenericRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGenericRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler genericRowChangedEvent = this.tblQuoteOptionGenericRowChangedEvent;
      if (genericRowChangedEvent == null)
        return;
      genericRowChangedEvent((object) this, new dsPremiumAllocation.tblQuoteOptionGenericRowChangeEvent((dsPremiumAllocation.tblQuoteOptionGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGenericRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionGenericRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.tblQuoteOptionGenericRowChangeEvent((dsPremiumAllocation.tblQuoteOptionGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGenericRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler genericRowDeletedEvent = this.tblQuoteOptionGenericRowDeletedEvent;
      if (genericRowDeletedEvent == null)
        return;
      genericRowDeletedEvent((object) this, new dsPremiumAllocation.tblQuoteOptionGenericRowChangeEvent((dsPremiumAllocation.tblQuoteOptionGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGenericRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblQuoteOptionGenericRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionGenericRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.tblQuoteOptionGenericRowChangeEvent((dsPremiumAllocation.tblQuoteOptionGenericRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionGenericRow(dsPremiumAllocation.tblQuoteOptionGenericRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionGenericDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public class tblPremiumAllocationCompaniesDataTable : 
    TypedTableBase<dsPremiumAllocation.tblPremiumAllocationCompaniesRow>
  {
    private DataColumn columnPremiumID;
    private DataColumn columnQuoteGuid;
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnPremium;
    private DataColumn columnTerrorismPremium;
    private DataColumn columnRate;
    private DataColumn columnTerrorismRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPremiumAllocationCompaniesDataTable()
    {
      this.TableName = "tblPremiumAllocationCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPremiumAllocationCompaniesDataTable(DataTable table)
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
    protected tblPremiumAllocationCompaniesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumIDColumn => this.columnPremiumID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismPremiumColumn => this.columnTerrorismPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RateColumn => this.columnRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismRateColumn => this.columnTerrorismRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationCompaniesRow this[int index]
    {
      get => (dsPremiumAllocation.tblPremiumAllocationCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler tblPremiumAllocationCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler tblPremiumAllocationCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler tblPremiumAllocationCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler tblPremiumAllocationCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblPremiumAllocationCompaniesRow(
      dsPremiumAllocation.tblPremiumAllocationCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationCompaniesRow AddtblPremiumAllocationCompaniesRow(
      Guid QuoteGuid,
      dsPremiumAllocation.tblCompanyLocationsRow parenttblCompanyLocationsRowBytblCompanyLocationstblPremiumAllocationCompanies,
      long Premium,
      long TerrorismPremium,
      Decimal Rate,
      Decimal TerrorismRate)
    {
      dsPremiumAllocation.tblPremiumAllocationCompaniesRow row = (dsPremiumAllocation.tblPremiumAllocationCompaniesRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) QuoteGuid,
        null,
        (object) Premium,
        (object) TerrorismPremium,
        (object) Rate,
        (object) TerrorismRate
      };
      if (parenttblCompanyLocationsRowBytblCompanyLocationstblPremiumAllocationCompanies != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblCompanyLocationsRowBytblCompanyLocationstblPremiumAllocationCompanies[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationCompaniesRow FindByPremiumID(int PremiumID)
    {
      return (dsPremiumAllocation.tblPremiumAllocationCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) PremiumID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable companiesDataTable = (dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPremiumID = this.Columns["PremiumID"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnPremium = this.Columns["Premium"];
      this.columnTerrorismPremium = this.Columns["TerrorismPremium"];
      this.columnRate = this.Columns["Rate"];
      this.columnTerrorismRate = this.Columns["TerrorismRate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPremiumID = new DataColumn("PremiumID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremiumID);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnPremium = new DataColumn("Premium", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnTerrorismPremium = new DataColumn("TerrorismPremium", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismPremium);
      this.columnRate = new DataColumn("Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
      this.columnTerrorismRate = new DataColumn("TerrorismRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismRate);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey2", new DataColumn[1]
      {
        this.columnPremiumID
      }, true));
      this.columnPremiumID.AutoIncrement = true;
      this.columnPremiumID.AllowDBNull = false;
      this.columnPremiumID.ReadOnly = true;
      this.columnPremiumID.Unique = true;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnTerrorismPremium.AllowDBNull = false;
      this.columnRate.AllowDBNull = false;
      this.columnTerrorismRate.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationCompaniesRow NewtblPremiumAllocationCompaniesRow()
    {
      return (dsPremiumAllocation.tblPremiumAllocationCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.tblPremiumAllocationCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPremiumAllocation.tblPremiumAllocationCompaniesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler companiesRowChangedEvent = this.tblPremiumAllocationCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler rowChangingEvent = this.tblPremiumAllocationCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.tblPremiumAllocationCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEventHandler rowDeletingEvent = this.tblPremiumAllocationCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationCompaniesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblPremiumAllocationCompaniesRow(
      dsPremiumAllocation.tblPremiumAllocationCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPremiumAllocationCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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
  public class tblPremiumAllocationStatesDataTable : 
    TypedTableBase<dsPremiumAllocation.tblPremiumAllocationStatesRow>
  {
    private DataColumn columnAllocationID;
    private DataColumn columnQuoteGuid;
    private DataColumn columnStateID;
    private DataColumn columnTIV;
    private DataColumn columnQuotingLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPremiumAllocationStatesDataTable()
    {
      this.TableName = "tblPremiumAllocationStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPremiumAllocationStatesDataTable(DataTable table)
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
    protected tblPremiumAllocationStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AllocationIDColumn => this.columnAllocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TIVColumn => this.columnTIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuotingLocationIDColumn => this.columnQuotingLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationStatesRow this[int index]
    {
      get => (dsPremiumAllocation.tblPremiumAllocationStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler tblPremiumAllocationStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler tblPremiumAllocationStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler tblPremiumAllocationStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler tblPremiumAllocationStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblPremiumAllocationStatesRow(
      dsPremiumAllocation.tblPremiumAllocationStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationStatesRow AddtblPremiumAllocationStatesRow(
      Guid QuoteGuid,
      dsPremiumAllocation.lstStatesRow parentlstStatesRowBylstStatestblPremiumAllocationStates,
      long TIV,
      dsPremiumAllocation.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblPremiumAllocationStates)
    {
      dsPremiumAllocation.tblPremiumAllocationStatesRow row = (dsPremiumAllocation.tblPremiumAllocationStatesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) QuoteGuid,
        null,
        (object) TIV,
        null
      };
      if (parentlstStatesRowBylstStatestblPremiumAllocationStates != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStatestblPremiumAllocationStates[0]);
      if (parenttblClientOfficesRowBytblClientOfficestblPremiumAllocationStates != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblPremiumAllocationStates[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationStatesRow FindByAllocationID(int AllocationID)
    {
      return (dsPremiumAllocation.tblPremiumAllocationStatesRow) this.Rows.Find(new object[1]
      {
        (object) AllocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumAllocation.tblPremiumAllocationStatesDataTable allocationStatesDataTable = (dsPremiumAllocation.tblPremiumAllocationStatesDataTable) base.Clone();
      allocationStatesDataTable.InitVars();
      return (DataTable) allocationStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumAllocation.tblPremiumAllocationStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnAllocationID = this.Columns["AllocationID"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnStateID = this.Columns["StateID"];
      this.columnTIV = this.Columns["TIV"];
      this.columnQuotingLocationID = this.Columns["QuotingLocationID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnAllocationID = new DataColumn("AllocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllocationID);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnTIV = new DataColumn("TIV", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTIV);
      this.columnQuotingLocationID = new DataColumn("QuotingLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuotingLocationID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumAllocationKey7", new DataColumn[1]
      {
        this.columnAllocationID
      }, true));
      this.columnAllocationID.AutoIncrement = true;
      this.columnAllocationID.AllowDBNull = false;
      this.columnAllocationID.ReadOnly = true;
      this.columnAllocationID.Unique = true;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
      this.columnTIV.AllowDBNull = false;
      this.columnQuotingLocationID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationStatesRow NewtblPremiumAllocationStatesRow()
    {
      return (dsPremiumAllocation.tblPremiumAllocationStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumAllocation.tblPremiumAllocationStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPremiumAllocation.tblPremiumAllocationStatesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler statesRowChangedEvent = this.tblPremiumAllocationStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler rowChangingEvent = this.tblPremiumAllocationStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler statesRowDeletedEvent = this.tblPremiumAllocationStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPremiumAllocationStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEventHandler rowDeletingEvent = this.tblPremiumAllocationStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumAllocation.tblPremiumAllocationStatesRowChangeEvent((dsPremiumAllocation.tblPremiumAllocationStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblPremiumAllocationStatesRow(
      dsPremiumAllocation.tblPremiumAllocationStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumAllocation premiumAllocation = new dsPremiumAllocation();
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
        FixedValue = premiumAllocation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPremiumAllocationStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = premiumAllocation.GetSchemaSerializable();
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

  public class tblCompanyLocationsRow : DataRow
  {
    private dsPremiumAllocation.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsPremiumAllocation.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLocations.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLocations.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationName
    {
      get => Conversions.ToString(this[this.tabletblCompanyLocations.LocationNameColumn]);
      set => this[this.tabletblCompanyLocations.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationCompaniesRow[] GettblPremiumAllocationCompaniesRows()
    {
      return this.Table.ChildRelations["tblCompanyLocationstblPremiumAllocationCompanies"] != null ? (dsPremiumAllocation.tblPremiumAllocationCompaniesRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLocationstblPremiumAllocationCompanies"]) : new dsPremiumAllocation.tblPremiumAllocationCompaniesRow[0];
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsPremiumAllocation.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsPremiumAllocation.lstStatesDataTable) this.Table;
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
    public dsPremiumAllocation.tblPremiumAllocationStatesRow[] GettblPremiumAllocationStatesRows()
    {
      return this.Table.ChildRelations["lstStatestblPremiumAllocationStates"] != null ? (dsPremiumAllocation.tblPremiumAllocationStatesRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatestblPremiumAllocationStates"]) : new dsPremiumAllocation.tblPremiumAllocationStatesRow[0];
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsPremiumAllocation.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsPremiumAllocation.tblClientOfficesDataTable) this.Table;
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
    public dsPremiumAllocation.tblPremiumAllocationStatesRow[] GettblPremiumAllocationStatesRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblPremiumAllocationStates"] != null ? (dsPremiumAllocation.tblPremiumAllocationStatesRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblPremiumAllocationStates"]) : new dsPremiumAllocation.tblPremiumAllocationStatesRow[0];
    }
  }

  public class tblQuoteOptionsRow : DataRow
  {
    private dsPremiumAllocation.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsPremiumAllocation.tblQuoteOptionsDataTable) this.Table;
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
    public int CompanyLocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptions.CompanyLocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationID' in table 'tblQuoteOptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptions.CompanyLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLocationIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptions.CompanyLocationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLocationIDNull()
    {
      this[this.tabletblQuoteOptions.CompanyLocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionGenericRow[] GettblQuoteOptionGenericRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionGeneric"] != null ? (dsPremiumAllocation.tblQuoteOptionGenericRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionGeneric"]) : new dsPremiumAllocation.tblQuoteOptionGenericRow[0];
    }
  }

  public class tblQuoteOptionGenericRow : DataRow
  {
    private dsPremiumAllocation.tblQuoteOptionGenericDataTable tabletblQuoteOptionGeneric;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionGenericRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionGeneric = (dsPremiumAllocation.tblQuoteOptionGenericDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GenericID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGeneric.GenericIDColumn]);
      set => this[this.tabletblQuoteOptionGeneric.GenericIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptionGeneric.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptionGeneric.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGeneric.ChargeCodeColumn]);
      set => this[this.tabletblQuoteOptionGeneric.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGeneric.OfficeIDColumn]);
      set => this[this.tabletblQuoteOptionGeneric.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionGeneric.PremiumColumn]);
      set => this[this.tabletblQuoteOptionGeneric.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteOptionGeneric.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblQuoteOptionGeneric' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGeneric.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int TerrorismPremium
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGeneric.TerrorismPremiumColumn]);
      set => this[this.tabletblQuoteOptionGeneric.TerrorismPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionsRow tblQuoteOptionsRow
    {
      get
      {
        return (dsPremiumAllocation.tblQuoteOptionsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionGeneric"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionGeneric"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabletblQuoteOptionGeneric.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblQuoteOptionGeneric.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPremiumAllocationCompaniesRow : DataRow
  {
    private dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable tabletblPremiumAllocationCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPremiumAllocationCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPremiumAllocationCompanies = (dsPremiumAllocation.tblPremiumAllocationCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PremiumID
    {
      get => Conversions.ToInteger(this[this.tabletblPremiumAllocationCompanies.PremiumIDColumn]);
      set => this[this.tabletblPremiumAllocationCompanies.PremiumIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblPremiumAllocationCompanies.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblPremiumAllocationCompanies.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblPremiumAllocationCompanies.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set
      {
        this[this.tabletblPremiumAllocationCompanies.CompanyLocationGUIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public long Premium
    {
      get => Conversions.ToLong(this[this.tabletblPremiumAllocationCompanies.PremiumColumn]);
      set => this[this.tabletblPremiumAllocationCompanies.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public long TerrorismPremium
    {
      get
      {
        return Conversions.ToLong(this[this.tabletblPremiumAllocationCompanies.TerrorismPremiumColumn]);
      }
      set => this[this.tabletblPremiumAllocationCompanies.TerrorismPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Rate
    {
      get => Conversions.ToDecimal(this[this.tabletblPremiumAllocationCompanies.RateColumn]);
      set => this[this.tabletblPremiumAllocationCompanies.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TerrorismRate
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblPremiumAllocationCompanies.TerrorismRateColumn]);
      }
      set => this[this.tabletblPremiumAllocationCompanies.TerrorismRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblCompanyLocationsRow tblCompanyLocationsRow
    {
      get
      {
        return (dsPremiumAllocation.tblCompanyLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLocationstblPremiumAllocationCompanies"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLocationstblPremiumAllocationCompanies"]);
      }
    }
  }

  public class tblPremiumAllocationStatesRow : DataRow
  {
    private dsPremiumAllocation.tblPremiumAllocationStatesDataTable tabletblPremiumAllocationStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPremiumAllocationStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPremiumAllocationStates = (dsPremiumAllocation.tblPremiumAllocationStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int AllocationID
    {
      get => Conversions.ToInteger(this[this.tabletblPremiumAllocationStates.AllocationIDColumn]);
      set => this[this.tabletblPremiumAllocationStates.AllocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblPremiumAllocationStates.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblPremiumAllocationStates.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblPremiumAllocationStates.StateIDColumn]);
      set => this[this.tabletblPremiumAllocationStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public long TIV
    {
      get => Conversions.ToLong(this[this.tabletblPremiumAllocationStates.TIVColumn]);
      set => this[this.tabletblPremiumAllocationStates.TIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuotingLocationID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblPremiumAllocationStates.QuotingLocationIDColumn]);
      }
      set => this[this.tabletblPremiumAllocationStates.QuotingLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsPremiumAllocation.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblPremiumAllocationStates"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblPremiumAllocationStates"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsPremiumAllocation.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStatestblPremiumAllocationStates"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatestblPremiumAllocationStates"]);
      }
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsPremiumAllocation.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesRowChangeEvent(dsPremiumAllocation.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsPremiumAllocation.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(
      dsPremiumAllocation.tblQuoteOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionGenericRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.tblQuoteOptionGenericRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionGenericRowChangeEvent(
      dsPremiumAllocation.tblQuoteOptionGenericRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblQuoteOptionGenericRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblPremiumAllocationCompaniesRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.tblPremiumAllocationCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPremiumAllocationCompaniesRowChangeEvent(
      dsPremiumAllocation.tblPremiumAllocationCompaniesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblPremiumAllocationStatesRowChangeEvent : EventArgs
  {
    private dsPremiumAllocation.tblPremiumAllocationStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPremiumAllocationStatesRowChangeEvent(
      dsPremiumAllocation.tblPremiumAllocationStatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumAllocation.tblPremiumAllocationStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
