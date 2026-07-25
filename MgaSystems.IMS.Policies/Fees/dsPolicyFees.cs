// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Fees.dsPolicyFees
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
namespace MGASystems.IMS.Policies.Fees;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyFees")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyFees : DataSet
{
  private dsPolicyFees.tblCompanyLinesDataTable tabletblCompanyLines;
  private dsPolicyFees.tblQuoteOptionChargesDataTable tabletblQuoteOptionCharges;
  private dsPolicyFees.lstFeeTypesDataTable tablelstFeeTypes;
  private dsPolicyFees.PolicyChargeCodesDataTable tablePolicyChargeCodes;
  private dsPolicyFees.tblClientOfficesDataTable tabletblClientOffices;
  private dsPolicyFees.tblCompanyPolicyChargesDataTable tabletblCompanyPolicyCharges;
  private dsPolicyFees.tblUsersDataTable tabletblUsers;
  private DataRelation relationlstFeeTypestblQuoteOptionCharges;
  private DataRelation relationtblClientOfficestblQuoteOptionCharges;
  private DataRelation relationlstFeeTypestblCompanyPolicyCharges;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPolicyFees()
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
  protected dsPolicyFees(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLines)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.tblCompanyLinesDataTable(dataSet.Tables[nameof (tblCompanyLines)]));
        if (dataSet.Tables[nameof (tblQuoteOptionCharges)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.tblQuoteOptionChargesDataTable(dataSet.Tables[nameof (tblQuoteOptionCharges)]));
        if (dataSet.Tables[nameof (lstFeeTypes)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.lstFeeTypesDataTable(dataSet.Tables[nameof (lstFeeTypes)]));
        if (dataSet.Tables[nameof (PolicyChargeCodes)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.PolicyChargeCodesDataTable(dataSet.Tables[nameof (PolicyChargeCodes)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblCompanyPolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.tblCompanyPolicyChargesDataTable(dataSet.Tables[nameof (tblCompanyPolicyCharges)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsPolicyFees.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
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
  public dsPolicyFees.tblCompanyLinesDataTable tblCompanyLines => this.tabletblCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFees.tblQuoteOptionChargesDataTable tblQuoteOptionCharges
  {
    get => this.tabletblQuoteOptionCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFees.lstFeeTypesDataTable lstFeeTypes => this.tablelstFeeTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFees.PolicyChargeCodesDataTable PolicyChargeCodes => this.tablePolicyChargeCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFees.tblClientOfficesDataTable tblClientOffices => this.tabletblClientOffices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFees.tblCompanyPolicyChargesDataTable tblCompanyPolicyCharges
  {
    get => this.tabletblCompanyPolicyCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFees.tblUsersDataTable tblUsers => this.tabletblUsers;

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
    dsPolicyFees dsPolicyFees = (dsPolicyFees) base.Clone();
    dsPolicyFees.InitVars();
    dsPolicyFees.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyFees;
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
      if (dataSet.Tables["tblCompanyLines"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.tblCompanyLinesDataTable(dataSet.Tables["tblCompanyLines"]));
      if (dataSet.Tables["tblQuoteOptionCharges"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.tblQuoteOptionChargesDataTable(dataSet.Tables["tblQuoteOptionCharges"]));
      if (dataSet.Tables["lstFeeTypes"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.lstFeeTypesDataTable(dataSet.Tables["lstFeeTypes"]));
      if (dataSet.Tables["PolicyChargeCodes"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.PolicyChargeCodesDataTable(dataSet.Tables["PolicyChargeCodes"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblCompanyPolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.tblCompanyPolicyChargesDataTable(dataSet.Tables["tblCompanyPolicyCharges"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsPolicyFees.tblUsersDataTable(dataSet.Tables["tblUsers"]));
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
    this.tabletblCompanyLines = (dsPolicyFees.tblCompanyLinesDataTable) base.Tables["tblCompanyLines"];
    if (initTable && this.tabletblCompanyLines != null)
      this.tabletblCompanyLines.InitVars();
    this.tabletblQuoteOptionCharges = (dsPolicyFees.tblQuoteOptionChargesDataTable) base.Tables["tblQuoteOptionCharges"];
    if (initTable && this.tabletblQuoteOptionCharges != null)
      this.tabletblQuoteOptionCharges.InitVars();
    this.tablelstFeeTypes = (dsPolicyFees.lstFeeTypesDataTable) base.Tables["lstFeeTypes"];
    if (initTable && this.tablelstFeeTypes != null)
      this.tablelstFeeTypes.InitVars();
    this.tablePolicyChargeCodes = (dsPolicyFees.PolicyChargeCodesDataTable) base.Tables["PolicyChargeCodes"];
    if (initTable && this.tablePolicyChargeCodes != null)
      this.tablePolicyChargeCodes.InitVars();
    this.tabletblClientOffices = (dsPolicyFees.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblCompanyPolicyCharges = (dsPolicyFees.tblCompanyPolicyChargesDataTable) base.Tables["tblCompanyPolicyCharges"];
    if (initTable && this.tabletblCompanyPolicyCharges != null)
      this.tabletblCompanyPolicyCharges.InitVars();
    this.tabletblUsers = (dsPolicyFees.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.relationlstFeeTypestblQuoteOptionCharges = this.Relations["lstFeeTypestblQuoteOptionCharges"];
    this.relationtblClientOfficestblQuoteOptionCharges = this.Relations["tblClientOfficestblQuoteOptionCharges"];
    this.relationlstFeeTypestblCompanyPolicyCharges = this.Relations["lstFeeTypestblCompanyPolicyCharges"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyFees);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyFees.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLines = new dsPolicyFees.tblCompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLines);
    this.tabletblQuoteOptionCharges = new dsPolicyFees.tblQuoteOptionChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionCharges);
    this.tablelstFeeTypes = new dsPolicyFees.lstFeeTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstFeeTypes);
    this.tablePolicyChargeCodes = new dsPolicyFees.PolicyChargeCodesDataTable();
    base.Tables.Add((DataTable) this.tablePolicyChargeCodes);
    this.tabletblClientOffices = new dsPolicyFees.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblCompanyPolicyCharges = new dsPolicyFees.tblCompanyPolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyPolicyCharges);
    this.tabletblUsers = new dsPolicyFees.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstFeeTypestblQuoteOptionCharges", new DataColumn[1]
    {
      this.tablelstFeeTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCharges.FeeTypeIDColumn
    });
    this.tabletblQuoteOptionCharges.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblClientOfficestblQuoteOptionCharges", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCharges.OfficeIDColumn
    });
    this.tabletblQuoteOptionCharges.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstFeeTypestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstFeeTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.FeeTypeIDColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationlstFeeTypestblQuoteOptionCharges = new DataRelation("lstFeeTypestblQuoteOptionCharges", new DataColumn[1]
    {
      this.tablelstFeeTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCharges.FeeTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstFeeTypestblQuoteOptionCharges);
    this.relationtblClientOfficestblQuoteOptionCharges = new DataRelation("tblClientOfficestblQuoteOptionCharges", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionCharges.OfficeIDColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblQuoteOptionCharges);
    this.relationlstFeeTypestblCompanyPolicyCharges = new DataRelation("lstFeeTypestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstFeeTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.FeeTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstFeeTypestblCompanyPolicyCharges);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteOptionCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstFeeTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializePolicyChargeCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyPolicyCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

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
    dsPolicyFees dsPolicyFees = new dsPolicyFees();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPolicyFees.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public delegate void tblCompanyLinesRowChangeEventHandler(
    object sender,
    dsPolicyFees.tblCompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblQuoteOptionChargesRowChangeEventHandler(
    object sender,
    dsPolicyFees.tblQuoteOptionChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstFeeTypesRowChangeEventHandler(
    object sender,
    dsPolicyFees.lstFeeTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void PolicyChargeCodesRowChangeEventHandler(
    object sender,
    dsPolicyFees.PolicyChargeCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsPolicyFees.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyPolicyChargesRowChangeEventHandler(
    object sender,
    dsPolicyFees.tblCompanyPolicyChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsPolicyFees.tblUsersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLinesDataTable : TypedTableBase<dsPolicyFees.tblCompanyLinesRow>
  {
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLinesDataTable()
    {
      this.TableName = "tblCompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLinesDataTable(DataTable table)
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
    protected tblCompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyLinesRow this[int index]
    {
      get => (dsPolicyFees.tblCompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLinesRow(dsPolicyFees.tblCompanyLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyLinesRow AddtblCompanyLinesRow(
      Guid CompanyLineGUID,
      string Company)
    {
      dsPolicyFees.tblCompanyLinesRow row = (dsPolicyFees.tblCompanyLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLineGUID,
        (object) Company
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyLinesRow FindByCompanyLineGUID(Guid CompanyLineGUID)
    {
      return (dsPolicyFees.tblCompanyLinesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLineGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.tblCompanyLinesDataTable companyLinesDataTable = (dsPolicyFees.tblCompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.tblCompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnCompany = this.Columns["Company"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFeesKey3", new DataColumn[1]
      {
        this.columnCompanyLineGUID
      }, true));
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnCompanyLineGUID.Unique = true;
      this.columnCompany.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyLinesRow NewtblCompanyLinesRow()
    {
      return (dsPolicyFees.tblCompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.tblCompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.tblCompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyLinesRowChangeEventHandler linesRowChangedEvent = this.tblCompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsPolicyFees.tblCompanyLinesRowChangeEvent((dsPolicyFees.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyLinesRowChangeEventHandler rowChangingEvent = this.tblCompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.tblCompanyLinesRowChangeEvent((dsPolicyFees.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.tblCompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsPolicyFees.tblCompanyLinesRowChangeEvent((dsPolicyFees.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyLinesRowChangeEventHandler rowDeletingEvent = this.tblCompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.tblCompanyLinesRowChangeEvent((dsPolicyFees.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLinesRow(dsPolicyFees.tblCompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public class tblQuoteOptionChargesDataTable : TypedTableBase<dsPolicyFees.tblQuoteOptionChargesRow>
  {
    private DataColumn columnOptionFeeID;
    private DataColumn columnCompanyFeeID;
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnOfficeID;
    private DataColumn columnFeeTypeID;
    private DataColumn columnPayable;
    private DataColumn columnFlatRate;
    private DataColumn columnPercentageRate;
    private DataColumn columnPercentageMinimum;
    private DataColumn columnSplittable;
    private DataColumn columnAutoApplied;
    private DataColumn columnChargeName;
    private DataColumn columnFeeType;
    private DataColumn columnPercentOfChargeCode;
    private DataColumn columnTaxable;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnConvertedToManualUserGuid;
    private DataColumn columnFullyEarned;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnAmount;
    private DataColumn columnPayee;
    private DataColumn columnPayeeOverride;
    private DataColumn columnForceSavedBy;
    private DataColumn columnTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionChargesDataTable()
    {
      this.TableName = "tblQuoteOptionCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionChargesDataTable(DataTable table)
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
    protected tblQuoteOptionChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyFeeIDColumn => this.columnCompanyFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeeTypeIDColumn => this.columnFeeTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayableColumn => this.columnPayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FlatRateColumn => this.columnFlatRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageRateColumn => this.columnPercentageRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageMinimumColumn => this.columnPercentageMinimum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SplittableColumn => this.columnSplittable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoAppliedColumn => this.columnAutoApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeeTypeColumn => this.columnFeeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentOfChargeCodeColumn => this.columnPercentOfChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxableColumn => this.columnTaxable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ConvertedToManualUserGuidColumn => this.columnConvertedToManualUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FullyEarnedColumn => this.columnFullyEarned;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeColumn => this.columnPayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeOverrideColumn => this.columnPayeeOverride;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ForceSavedByColumn => this.columnForceSavedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxColumn => this.columnTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow this[int index]
    {
      get => (dsPolicyFees.tblQuoteOptionChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteOptionChargesRow(dsPolicyFees.tblQuoteOptionChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow AddtblQuoteOptionChargesRow(
      int OptionFeeID,
      int CompanyFeeID,
      Guid QuoteOptionGuid,
      int ChargeCode,
      Guid CompanyLineGuid,
      dsPolicyFees.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblQuoteOptionCharges,
      dsPolicyFees.lstFeeTypesRow parentlstFeeTypesRowBylstFeeTypestblQuoteOptionCharges,
      bool Payable,
      Decimal FlatRate,
      Decimal PercentageRate,
      Decimal PercentageMinimum,
      bool Splittable,
      bool AutoApplied,
      string ChargeName,
      string FeeType,
      int PercentOfChargeCode,
      bool Taxable,
      Guid WaivedByUserGuid,
      Guid ConvertedToManualUserGuid,
      bool FullyEarned,
      string AppliesToPaymentID,
      Decimal Amount,
      string Payee,
      Guid PayeeOverride,
      Guid ForceSavedBy,
      bool Tax)
    {
      dsPolicyFees.tblQuoteOptionChargesRow row = (dsPolicyFees.tblQuoteOptionChargesRow) this.NewRow();
      object[] objArray = new object[26]
      {
        (object) OptionFeeID,
        (object) CompanyFeeID,
        (object) QuoteOptionGuid,
        (object) ChargeCode,
        (object) CompanyLineGuid,
        null,
        null,
        (object) Payable,
        (object) FlatRate,
        (object) PercentageRate,
        (object) PercentageMinimum,
        (object) Splittable,
        (object) AutoApplied,
        (object) ChargeName,
        (object) FeeType,
        (object) PercentOfChargeCode,
        (object) Taxable,
        (object) WaivedByUserGuid,
        (object) ConvertedToManualUserGuid,
        (object) FullyEarned,
        (object) AppliesToPaymentID,
        (object) Amount,
        (object) Payee,
        (object) PayeeOverride,
        (object) ForceSavedBy,
        (object) Tax
      };
      if (parenttblClientOfficesRowBytblClientOfficestblQuoteOptionCharges != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblQuoteOptionCharges[0]);
      if (parentlstFeeTypesRowBylstFeeTypestblQuoteOptionCharges != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parentlstFeeTypesRowBylstFeeTypestblQuoteOptionCharges[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow FindByOptionFeeID(int OptionFeeID)
    {
      return (dsPolicyFees.tblQuoteOptionChargesRow) this.Rows.Find(new object[1]
      {
        (object) OptionFeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.tblQuoteOptionChargesDataTable chargesDataTable = (dsPolicyFees.tblQuoteOptionChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.tblQuoteOptionChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
      this.columnCompanyFeeID = this.Columns["CompanyFeeID"];
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnFeeTypeID = this.Columns["FeeTypeID"];
      this.columnPayable = this.Columns["Payable"];
      this.columnFlatRate = this.Columns["FlatRate"];
      this.columnPercentageRate = this.Columns["PercentageRate"];
      this.columnPercentageMinimum = this.Columns["PercentageMinimum"];
      this.columnSplittable = this.Columns["Splittable"];
      this.columnAutoApplied = this.Columns["AutoApplied"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnFeeType = this.Columns["FeeType"];
      this.columnPercentOfChargeCode = this.Columns["PercentOfChargeCode"];
      this.columnTaxable = this.Columns["Taxable"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnConvertedToManualUserGuid = this.Columns["ConvertedToManualUserGuid"];
      this.columnFullyEarned = this.Columns["FullyEarned"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnAmount = this.Columns["Amount"];
      this.columnPayee = this.Columns["Payee"];
      this.columnPayeeOverride = this.Columns["PayeeOverride"];
      this.columnForceSavedBy = this.Columns["ForceSavedBy"];
      this.columnTax = this.Columns["Tax"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnCompanyFeeID = new DataColumn("CompanyFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyFeeID);
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnFeeTypeID = new DataColumn("FeeTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeTypeID);
      this.columnPayable = new DataColumn("Payable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayable);
      this.columnFlatRate = new DataColumn("FlatRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatRate);
      this.columnPercentageRate = new DataColumn("PercentageRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageRate);
      this.columnPercentageMinimum = new DataColumn("PercentageMinimum", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageMinimum);
      this.columnSplittable = new DataColumn("Splittable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSplittable);
      this.columnAutoApplied = new DataColumn("AutoApplied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoApplied);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnFeeType = new DataColumn("FeeType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeType);
      this.columnPercentOfChargeCode = new DataColumn("PercentOfChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentOfChargeCode);
      this.columnTaxable = new DataColumn("Taxable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxable);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnConvertedToManualUserGuid = new DataColumn("ConvertedToManualUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConvertedToManualUserGuid);
      this.columnFullyEarned = new DataColumn("FullyEarned", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullyEarned);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnPayeeOverride = new DataColumn("PayeeOverride", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeOverride);
      this.columnForceSavedBy = new DataColumn("ForceSavedBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnForceSavedBy);
      this.columnTax = new DataColumn("Tax", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTax);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFeesKey1", new DataColumn[1]
      {
        this.columnOptionFeeID
      }, true));
      this.columnOptionFeeID.AllowDBNull = false;
      this.columnOptionFeeID.Unique = true;
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnFeeTypeID.AllowDBNull = false;
      this.columnPayable.AllowDBNull = false;
      this.columnSplittable.AllowDBNull = false;
      this.columnAutoApplied.AllowDBNull = false;
      this.columnChargeName.AllowDBNull = false;
      this.columnFeeType.AllowDBNull = false;
      this.columnTaxable.AllowDBNull = false;
      this.columnTaxable.DefaultValue = (object) false;
      this.columnFullyEarned.AllowDBNull = false;
      this.columnFullyEarned.DefaultValue = (object) false;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnTax.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow NewtblQuoteOptionChargesRow()
    {
      return (dsPolicyFees.tblQuoteOptionChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.tblQuoteOptionChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.tblQuoteOptionChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler chargesRowChangedEvent = this.tblQuoteOptionChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsPolicyFees.tblQuoteOptionChargesRowChangeEvent((dsPolicyFees.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.tblQuoteOptionChargesRowChangeEvent((dsPolicyFees.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblQuoteOptionChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsPolicyFees.tblQuoteOptionChargesRowChangeEvent((dsPolicyFees.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblQuoteOptionChargesRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.tblQuoteOptionChargesRowChangeEvent((dsPolicyFees.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteOptionChargesRow(dsPolicyFees.tblQuoteOptionChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public class lstFeeTypesDataTable : TypedTableBase<dsPolicyFees.lstFeeTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnFeeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFeeTypesDataTable()
    {
      this.TableName = "lstFeeTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFeeTypesDataTable(DataTable table)
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
    protected lstFeeTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeeTypeColumn => this.columnFeeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow this[int index]
    {
      get => (dsPolicyFees.lstFeeTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstFeeTypesRow(dsPolicyFees.lstFeeTypesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow AddlstFeeTypesRow(int ID, string FeeType)
    {
      dsPolicyFees.lstFeeTypesRow row = (dsPolicyFees.lstFeeTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) FeeType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow FindByID(int ID)
    {
      return (dsPolicyFees.lstFeeTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.lstFeeTypesDataTable feeTypesDataTable = (dsPolicyFees.lstFeeTypesDataTable) base.Clone();
      feeTypesDataTable.InitVars();
      return (DataTable) feeTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.lstFeeTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnFeeType = this.Columns["FeeType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnFeeType = new DataColumn("FeeType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFeesKey4", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnFeeType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow NewlstFeeTypesRow()
    {
      return (dsPolicyFees.lstFeeTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.lstFeeTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.lstFeeTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.lstFeeTypesRowChangeEventHandler typesRowChangedEvent = this.lstFeeTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPolicyFees.lstFeeTypesRowChangeEvent((dsPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.lstFeeTypesRowChangeEventHandler rowChangingEvent = this.lstFeeTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.lstFeeTypesRowChangeEvent((dsPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.lstFeeTypesRowChangeEventHandler typesRowDeletedEvent = this.lstFeeTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPolicyFees.lstFeeTypesRowChangeEvent((dsPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.lstFeeTypesRowChangeEventHandler rowDeletingEvent = this.lstFeeTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.lstFeeTypesRowChangeEvent((dsPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstFeeTypesRow(dsPolicyFees.lstFeeTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFeeTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public class PolicyChargeCodesDataTable : TypedTableBase<dsPolicyFees.PolicyChargeCodesRow>
  {
    private DataColumn columnChargeCode;
    private DataColumn columnChargeName;
    private DataColumn columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PolicyChargeCodesDataTable()
    {
      this.TableName = "PolicyChargeCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PolicyChargeCodesDataTable(DataTable table)
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
    protected PolicyChargeCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.PolicyChargeCodesRow this[int index]
    {
      get => (dsPolicyFees.PolicyChargeCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.PolicyChargeCodesRowChangeEventHandler PolicyChargeCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.PolicyChargeCodesRowChangeEventHandler PolicyChargeCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.PolicyChargeCodesRowChangeEventHandler PolicyChargeCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.PolicyChargeCodesRowChangeEventHandler PolicyChargeCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddPolicyChargeCodesRow(dsPolicyFees.PolicyChargeCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.PolicyChargeCodesRow AddPolicyChargeCodesRow(
      int ChargeCode,
      string ChargeName,
      int OfficeID)
    {
      dsPolicyFees.PolicyChargeCodesRow row = (dsPolicyFees.PolicyChargeCodesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ChargeCode,
        (object) ChargeName,
        (object) OfficeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.PolicyChargeCodesRow FindByChargeCodeOfficeID(int ChargeCode, int OfficeID)
    {
      return (dsPolicyFees.PolicyChargeCodesRow) this.Rows.Find(new object[2]
      {
        (object) ChargeCode,
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.PolicyChargeCodesDataTable chargeCodesDataTable = (dsPolicyFees.PolicyChargeCodesDataTable) base.Clone();
      chargeCodesDataTable.InitVars();
      return (DataTable) chargeCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.PolicyChargeCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnOfficeID = this.Columns["OfficeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFeesKey5", new DataColumn[2]
      {
        this.columnChargeCode,
        this.columnOfficeID
      }, true));
      this.columnChargeCode.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.PolicyChargeCodesRow NewPolicyChargeCodesRow()
    {
      return (dsPolicyFees.PolicyChargeCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.PolicyChargeCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.PolicyChargeCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyChargeCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.PolicyChargeCodesRowChangeEventHandler codesRowChangedEvent = this.PolicyChargeCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsPolicyFees.PolicyChargeCodesRowChangeEvent((dsPolicyFees.PolicyChargeCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyChargeCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.PolicyChargeCodesRowChangeEventHandler rowChangingEvent = this.PolicyChargeCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.PolicyChargeCodesRowChangeEvent((dsPolicyFees.PolicyChargeCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyChargeCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.PolicyChargeCodesRowChangeEventHandler codesRowDeletedEvent = this.PolicyChargeCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsPolicyFees.PolicyChargeCodesRowChangeEvent((dsPolicyFees.PolicyChargeCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyChargeCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.PolicyChargeCodesRowChangeEventHandler rowDeletingEvent = this.PolicyChargeCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.PolicyChargeCodesRowChangeEvent((dsPolicyFees.PolicyChargeCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovePolicyChargeCodesRow(dsPolicyFees.PolicyChargeCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyChargeCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsPolicyFees.tblClientOfficesRow>
  {
    private DataColumn columnOfficeID;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblClientOfficesRow this[int index]
    {
      get => (dsPolicyFees.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblClientOfficesRow(dsPolicyFees.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblClientOfficesRow AddtblClientOfficesRow(string Location)
    {
      dsPolicyFees.tblClientOfficesRow row = (dsPolicyFees.tblClientOfficesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblClientOfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsPolicyFees.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.tblClientOfficesDataTable officesDataTable = (dsPolicyFees.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFeesKey6", new DataColumn[1]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsPolicyFees.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsPolicyFees.tblClientOfficesRowChangeEvent((dsPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.tblClientOfficesRowChangeEvent((dsPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsPolicyFees.tblClientOfficesRowChangeEvent((dsPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.tblClientOfficesRowChangeEvent((dsPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblClientOfficesRow(dsPolicyFees.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public class tblCompanyPolicyChargesDataTable : 
    TypedTableBase<dsPolicyFees.tblCompanyPolicyChargesRow>
  {
    private DataColumn columnID;
    private DataColumn columnChargeCode;
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnFlatRate;
    private DataColumn columnPercentageRate;
    private DataColumn columnChargeName;
    private DataColumn columnFeeTypeID;
    private DataColumn columnPayable;
    private DataColumn columnSplittable;
    private DataColumn columnTaxable;
    private DataColumn columnFullyEarned;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnCompanyFeeID;
    private DataColumn columnDescription;
    private DataColumn columnEffectiveDate;
    private DataColumn columnPayableEntityGuid;
    private DataColumn columnPayee;
    private DataColumn columnExistedOnPriorTransaction;
    private DataColumn columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyPolicyChargesDataTable()
    {
      this.TableName = "tblCompanyPolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyPolicyChargesDataTable(DataTable table)
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
    protected tblCompanyPolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FlatRateColumn => this.columnFlatRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageRateColumn => this.columnPercentageRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeeTypeIDColumn => this.columnFeeTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayableColumn => this.columnPayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SplittableColumn => this.columnSplittable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxableColumn => this.columnTaxable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FullyEarnedColumn => this.columnFullyEarned;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyFeeIDColumn => this.columnCompanyFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayableEntityGuidColumn => this.columnPayableEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeColumn => this.columnPayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExistedOnPriorTransactionColumn => this.columnExistedOnPriorTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyPolicyChargesRow this[int index]
    {
      get => (dsPolicyFees.tblCompanyPolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyPolicyChargesRow(dsPolicyFees.tblCompanyPolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyPolicyChargesRow AddtblCompanyPolicyChargesRow(
      int ChargeCode,
      Guid CompanyLineGUID,
      Decimal FlatRate,
      Decimal PercentageRate,
      string ChargeName,
      dsPolicyFees.lstFeeTypesRow parentlstFeeTypesRowBylstFeeTypestblCompanyPolicyCharges,
      bool Payable,
      bool Splittable,
      bool Taxable,
      bool FullyEarned,
      string AppliesToPaymentID,
      int CompanyFeeID,
      string Description,
      DateTime EffectiveDate,
      Guid PayableEntityGuid,
      string Payee,
      bool ExistedOnPriorTransaction,
      bool Disabled)
    {
      dsPolicyFees.tblCompanyPolicyChargesRow row = (dsPolicyFees.tblCompanyPolicyChargesRow) this.NewRow();
      object[] objArray = new object[19]
      {
        null,
        (object) ChargeCode,
        (object) CompanyLineGUID,
        (object) FlatRate,
        (object) PercentageRate,
        (object) ChargeName,
        null,
        (object) Payable,
        (object) Splittable,
        (object) Taxable,
        (object) FullyEarned,
        (object) AppliesToPaymentID,
        (object) CompanyFeeID,
        (object) Description,
        (object) EffectiveDate,
        (object) PayableEntityGuid,
        (object) Payee,
        (object) ExistedOnPriorTransaction,
        (object) Disabled
      };
      if (parentlstFeeTypesRowBylstFeeTypestblCompanyPolicyCharges != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parentlstFeeTypesRowBylstFeeTypestblCompanyPolicyCharges[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyPolicyChargesRow FindByID(int ID)
    {
      return (dsPolicyFees.tblCompanyPolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.tblCompanyPolicyChargesDataTable chargesDataTable = (dsPolicyFees.tblCompanyPolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.tblCompanyPolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnFlatRate = this.Columns["FlatRate"];
      this.columnPercentageRate = this.Columns["PercentageRate"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnFeeTypeID = this.Columns["FeeTypeID"];
      this.columnPayable = this.Columns["Payable"];
      this.columnSplittable = this.Columns["Splittable"];
      this.columnTaxable = this.Columns["Taxable"];
      this.columnFullyEarned = this.Columns["FullyEarned"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnCompanyFeeID = this.Columns["CompanyFeeID"];
      this.columnDescription = this.Columns["Description"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnPayableEntityGuid = this.Columns["PayableEntityGuid"];
      this.columnPayee = this.Columns["Payee"];
      this.columnExistedOnPriorTransaction = this.Columns["ExistedOnPriorTransaction"];
      this.columnDisabled = this.Columns["Disabled"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnFlatRate = new DataColumn("FlatRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatRate);
      this.columnPercentageRate = new DataColumn("PercentageRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageRate);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnFeeTypeID = new DataColumn("FeeTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeTypeID);
      this.columnPayable = new DataColumn("Payable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayable);
      this.columnSplittable = new DataColumn("Splittable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSplittable);
      this.columnTaxable = new DataColumn("Taxable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxable);
      this.columnFullyEarned = new DataColumn("FullyEarned", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullyEarned);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnCompanyFeeID = new DataColumn("CompanyFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyFeeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnPayableEntityGuid = new DataColumn("PayableEntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayableEntityGuid);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnExistedOnPriorTransaction = new DataColumn("ExistedOnPriorTransaction", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExistedOnPriorTransaction);
      this.columnDisabled = new DataColumn("Disabled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.Constraints.Add((Constraint) new UniqueConstraint("tblCompanyPolicyChargesKey1", new DataColumn[2]
      {
        this.columnCompanyLineGUID,
        this.columnCompanyFeeID
      }, false));
      this.Constraints.Add((Constraint) new UniqueConstraint("tblCompanyPolicyChargesKey2", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnChargeCode.AllowDBNull = false;
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnChargeName.ReadOnly = true;
      this.columnFeeTypeID.AllowDBNull = false;
      this.columnPayable.AllowDBNull = false;
      this.columnSplittable.AllowDBNull = false;
      this.columnTaxable.AllowDBNull = false;
      this.columnFullyEarned.AllowDBNull = false;
      this.columnFullyEarned.DefaultValue = (object) false;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnCompanyFeeID.AllowDBNull = false;
      this.columnExistedOnPriorTransaction.AllowDBNull = false;
      this.columnDisabled.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyPolicyChargesRow NewtblCompanyPolicyChargesRow()
    {
      return (dsPolicyFees.tblCompanyPolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.tblCompanyPolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.tblCompanyPolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblCompanyPolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler rowChangingEvent = this.tblCompanyPolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblCompanyPolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblCompanyPolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyPolicyChargesRow(dsPolicyFees.tblCompanyPolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyPolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsPolicyFees.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersDataTable()
    {
      this.TableName = "tblUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblUsersRow this[int index] => (dsPolicyFees.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyFees.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUsersRow(dsPolicyFees.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblUsersRow AddtblUsersRow(Guid UserGUID, string Name_LastFirst)
    {
      dsPolicyFees.tblUsersRow row = (dsPolicyFees.tblUsersRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsPolicyFees.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFees.tblUsersDataTable tblUsersDataTable = (dsPolicyFees.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFees.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
      this.columnName_LastFirst.ReadOnly = true;
      this.columnName_LastFirst.MaxLength = 102;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblUsersRow NewtblUsersRow() => (dsPolicyFees.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFees.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFees.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsPolicyFees.tblUsersRowChangeEvent((dsPolicyFees.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFees.tblUsersRowChangeEvent((dsPolicyFees.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsPolicyFees.tblUsersRowChangeEvent((dsPolicyFees.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFees.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFees.tblUsersRowChangeEvent((dsPolicyFees.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUsersRow(dsPolicyFees.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFees dsPolicyFees = new dsPolicyFees();
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
        FixedValue = dsPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFees.GetSchemaSerializable();
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

  public class tblCompanyLinesRow : DataRow
  {
    private dsPolicyFees.tblCompanyLinesDataTable tabletblCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLines = (dsPolicyFees.tblCompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLines.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLines.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Company
    {
      get => Conversions.ToString(this[this.tabletblCompanyLines.CompanyColumn]);
      set => this[this.tabletblCompanyLines.CompanyColumn] = (object) value;
    }
  }

  public class tblQuoteOptionChargesRow : DataRow
  {
    private dsPolicyFees.tblQuoteOptionChargesDataTable tabletblQuoteOptionCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionCharges = (dsPolicyFees.tblQuoteOptionChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OptionFeeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.OptionFeeIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyFeeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.CompanyFeeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyFeeID' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.CompanyFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptionCharges.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptionCharges.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.ChargeCodeColumn]);
      set => this[this.tabletblQuoteOptionCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.CompanyLineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineGuid' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int FeeTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.FeeTypeIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.FeeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Payable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.PayableColumn]);
      set => this[this.tabletblQuoteOptionCharges.PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal FlatRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.FlatRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatRate' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.FlatRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PercentageRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.PercentageRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentageRate' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PercentageRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PercentageMinimum
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.PercentageMinimumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentageMinimum' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PercentageMinimumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Splittable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.SplittableColumn]);
      set => this[this.tabletblQuoteOptionCharges.SplittableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoApplied
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.AutoAppliedColumn]);
      set => this[this.tabletblQuoteOptionCharges.AutoAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptionCharges.ChargeNameColumn]);
      set => this[this.tabletblQuoteOptionCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FeeType
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptionCharges.FeeTypeColumn]);
      set => this[this.tabletblQuoteOptionCharges.FeeTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PercentOfChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentOfChargeCode' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Taxable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.TaxableColumn]);
      set => this[this.tabletblQuoteOptionCharges.TaxableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ConvertedToManualUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConvertedToManualUserGuid' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool FullyEarned
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.FullyEarnedColumn]);
      set => this[this.tabletblQuoteOptionCharges.FullyEarnedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptionCharges.AppliesToPaymentIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionCharges.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Payee' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PayeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid PayeeOverride
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.PayeeOverrideColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeOverride' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PayeeOverrideColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ForceSavedBy
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.ForceSavedByColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ForceSavedBy' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.ForceSavedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Tax
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.TaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Tax' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.TaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow lstFeeTypesRow
    {
      get
      {
        return (dsPolicyFees.lstFeeTypesRow) this.GetParentRow(this.Table.ParentRelations["lstFeeTypestblQuoteOptionCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstFeeTypestblQuoteOptionCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsPolicyFees.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblQuoteOptionCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblQuoteOptionCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyFeeIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.CompanyFeeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyFeeIDNull()
    {
      this[this.tabletblQuoteOptionCharges.CompanyFeeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyLineGuidNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.CompanyLineGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyLineGuidNull()
    {
      this[this.tabletblQuoteOptionCharges.CompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfficeIDNull() => this.IsNull(this.tabletblQuoteOptionCharges.OfficeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tabletblQuoteOptionCharges.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFlatRateNull() => this.IsNull(this.tabletblQuoteOptionCharges.FlatRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFlatRateNull()
    {
      this[this.tabletblQuoteOptionCharges.FlatRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageRateNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PercentageRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageRateNull()
    {
      this[this.tabletblQuoteOptionCharges.PercentageRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageMinimumNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PercentageMinimumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageMinimumNull()
    {
      this[this.tabletblQuoteOptionCharges.PercentageMinimumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentOfChargeCodeNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentOfChargeCodeNull()
    {
      this[this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsConvertedToManualUserGuidNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetConvertedToManualUserGuidNull()
    {
      this[this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tabletblQuoteOptionCharges.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tabletblQuoteOptionCharges.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeNull() => this.IsNull(this.tabletblQuoteOptionCharges.PayeeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeNull()
    {
      this[this.tabletblQuoteOptionCharges.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeOverrideNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PayeeOverrideColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeOverrideNull()
    {
      this[this.tabletblQuoteOptionCharges.PayeeOverrideColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsForceSavedByNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.ForceSavedByColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetForceSavedByNull()
    {
      this[this.tabletblQuoteOptionCharges.ForceSavedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTaxNull() => this.IsNull(this.tabletblQuoteOptionCharges.TaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTaxNull()
    {
      this[this.tabletblQuoteOptionCharges.TaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstFeeTypesRow : DataRow
  {
    private dsPolicyFees.lstFeeTypesDataTable tablelstFeeTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFeeTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFeeTypes = (dsPolicyFees.lstFeeTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstFeeTypes.IDColumn]);
      set => this[this.tablelstFeeTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FeeType
    {
      get => Conversions.ToString(this[this.tablelstFeeTypes.FeeTypeColumn]);
      set => this[this.tablelstFeeTypes.FeeTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["lstFeeTypestblCompanyPolicyCharges"] != null ? (dsPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstFeeTypestblCompanyPolicyCharges"]) : new dsPolicyFees.tblCompanyPolicyChargesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow[] GettblQuoteOptionChargesRows()
    {
      return this.Table.ChildRelations["lstFeeTypestblQuoteOptionCharges"] != null ? (dsPolicyFees.tblQuoteOptionChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstFeeTypestblQuoteOptionCharges"]) : new dsPolicyFees.tblQuoteOptionChargesRow[0];
    }
  }

  public class PolicyChargeCodesRow : DataRow
  {
    private dsPolicyFees.PolicyChargeCodesDataTable tablePolicyChargeCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PolicyChargeCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyChargeCodes = (dsPolicyFees.PolicyChargeCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tablePolicyChargeCodes.ChargeCodeColumn]);
      set => this[this.tablePolicyChargeCodes.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyChargeCodes.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'PolicyChargeCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyChargeCodes.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tablePolicyChargeCodes.OfficeIDColumn]);
      set => this[this.tablePolicyChargeCodes.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsChargeNameNull() => this.IsNull(this.tablePolicyChargeCodes.ChargeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tablePolicyChargeCodes.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsPolicyFees.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsPolicyFees.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblClientOffices.OfficeIDColumn]);
      set => this[this.tabletblClientOffices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.LocationColumn]);
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow[] GettblQuoteOptionChargesRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblQuoteOptionCharges"] != null ? (dsPolicyFees.tblQuoteOptionChargesRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblQuoteOptionCharges"]) : new dsPolicyFees.tblQuoteOptionChargesRow[0];
    }
  }

  public class tblCompanyPolicyChargesRow : DataRow
  {
    private dsPolicyFees.tblCompanyPolicyChargesDataTable tabletblCompanyPolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyPolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyPolicyCharges = (dsPolicyFees.tblCompanyPolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.IDColumn]);
      set => this[this.tabletblCompanyPolicyCharges.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblCompanyPolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyPolicyCharges.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyPolicyCharges.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal FlatRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.FlatRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatRate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.FlatRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PercentageRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.PercentageRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentageRate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PercentageRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int FeeTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.FeeTypeIDColumn]);
      set => this[this.tabletblCompanyPolicyCharges.FeeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Payable
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.PayableColumn]);
      set => this[this.tabletblCompanyPolicyCharges.PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Splittable
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.SplittableColumn]);
      set => this[this.tabletblCompanyPolicyCharges.SplittableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Taxable
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.TaxableColumn]);
      set => this[this.tabletblCompanyPolicyCharges.TaxableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool FullyEarned
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.FullyEarnedColumn]);
      set => this[this.tabletblCompanyPolicyCharges.FullyEarnedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tabletblCompanyPolicyCharges.AppliesToPaymentIDColumn]);
      set => this[this.tabletblCompanyPolicyCharges.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyFeeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.CompanyFeeIDColumn]);
      set => this[this.tabletblCompanyPolicyCharges.CompanyFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyPolicyCharges.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid PayableEntityGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayableEntityGuid' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Payee' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PayeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool ExistedOnPriorTransaction
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExistedOnPriorTransactionColumn]);
      }
      set
      {
        this[this.tabletblCompanyPolicyCharges.ExistedOnPriorTransactionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Disabled
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.DisabledColumn]);
      set => this[this.tabletblCompanyPolicyCharges.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow lstFeeTypesRow
    {
      get
      {
        return (dsPolicyFees.lstFeeTypesRow) this.GetParentRow(this.Table.ParentRelations["lstFeeTypestblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstFeeTypestblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFlatRateNull() => this.IsNull(this.tabletblCompanyPolicyCharges.FlatRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFlatRateNull()
    {
      this[this.tabletblCompanyPolicyCharges.FlatRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageRateNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PercentageRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageRateNull()
    {
      this[this.tabletblCompanyPolicyCharges.PercentageRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsChargeNameNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ChargeNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tabletblCompanyPolicyCharges.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblCompanyPolicyCharges.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblCompanyPolicyCharges.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayableEntityGuidNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayableEntityGuidNull()
    {
      this[this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeNull() => this.IsNull(this.tabletblCompanyPolicyCharges.PayeeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeNull()
    {
      this[this.tabletblCompanyPolicyCharges.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsPolicyFees.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsPolicyFees.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsName_LastFirstNull() => this.IsNull(this.tabletblUsers.Name_LastFirstColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblUsers.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLinesRowChangeEvent : EventArgs
  {
    private dsPolicyFees.tblCompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLinesRowChangeEvent(dsPolicyFees.tblCompanyLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteOptionChargesRowChangeEvent : EventArgs
  {
    private dsPolicyFees.tblQuoteOptionChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionChargesRowChangeEvent(
      dsPolicyFees.tblQuoteOptionChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblQuoteOptionChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstFeeTypesRowChangeEvent : EventArgs
  {
    private dsPolicyFees.lstFeeTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFeeTypesRowChangeEvent(dsPolicyFees.lstFeeTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.lstFeeTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class PolicyChargeCodesRowChangeEvent : EventArgs
  {
    private dsPolicyFees.PolicyChargeCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PolicyChargeCodesRowChangeEvent(
      dsPolicyFees.PolicyChargeCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.PolicyChargeCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsPolicyFees.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsPolicyFees.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyPolicyChargesRowChangeEvent : EventArgs
  {
    private dsPolicyFees.tblCompanyPolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyPolicyChargesRowChangeEvent(
      dsPolicyFees.tblCompanyPolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblCompanyPolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsPolicyFees.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersRowChangeEvent(dsPolicyFees.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyFees.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
