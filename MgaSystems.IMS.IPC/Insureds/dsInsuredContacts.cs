// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Insureds.dsInsuredContacts
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Insureds;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInsuredContacts")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInsuredContacts : DataSet
{
  private dsInsuredContacts.tblInsuredContactsDataTable tabletblInsuredContacts;
  private dsInsuredContacts.tblInsuredSpecialContactsDataTable tabletblInsuredSpecialContacts;
  private dsInsuredContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsInsuredContacts.lstStatusDataTable tablelstStatus;
  private dsInsuredContacts.lstInsuredSpecialContactTypesDataTable tablelstInsuredSpecialContactTypes;
  private dsInsuredContacts.lstSalutationsDataTable tablelstSalutations;
  private DataRelation relationlstSalutationstblInsuredContacts;
  private DataRelation relationlstDeliveryMethodtblInsuredContacts;
  private DataRelation relationlstStatustblInsuredContacts;
  private DataRelation relationtblInsuredContactstblInsuredSpecialContacts;
  private DataRelation relationlstInsuredSpecialContactTypestblInsuredSpecialContacts;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsInsuredContacts()
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
  protected dsInsuredContacts(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblInsuredContacts)] != null)
          base.Tables.Add((DataTable) new dsInsuredContacts.tblInsuredContactsDataTable(dataSet.Tables[nameof (tblInsuredContacts)]));
        if (dataSet.Tables[nameof (tblInsuredSpecialContacts)] != null)
          base.Tables.Add((DataTable) new dsInsuredContacts.tblInsuredSpecialContactsDataTable(dataSet.Tables[nameof (tblInsuredSpecialContacts)]));
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsInsuredContacts.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsInsuredContacts.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (lstInsuredSpecialContactTypes)] != null)
          base.Tables.Add((DataTable) new dsInsuredContacts.lstInsuredSpecialContactTypesDataTable(dataSet.Tables[nameof (lstInsuredSpecialContactTypes)]));
        if (dataSet.Tables[nameof (lstSalutations)] != null)
          base.Tables.Add((DataTable) new dsInsuredContacts.lstSalutationsDataTable(dataSet.Tables[nameof (lstSalutations)]));
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
  public dsInsuredContacts.tblInsuredContactsDataTable tblInsuredContacts
  {
    get => this.tabletblInsuredContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredContacts.tblInsuredSpecialContactsDataTable tblInsuredSpecialContacts
  {
    get => this.tabletblInsuredSpecialContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredContacts.lstDeliveryMethodDataTable lstDeliveryMethod
  {
    get => this.tablelstDeliveryMethod;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredContacts.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredContacts.lstInsuredSpecialContactTypesDataTable lstInsuredSpecialContactTypes
  {
    get => this.tablelstInsuredSpecialContactTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredContacts.lstSalutationsDataTable lstSalutations => this.tablelstSalutations;

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
    dsInsuredContacts dsInsuredContacts = (dsInsuredContacts) base.Clone();
    dsInsuredContacts.InitVars();
    dsInsuredContacts.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsInsuredContacts;
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
      if (dataSet.Tables["tblInsuredContacts"] != null)
        base.Tables.Add((DataTable) new dsInsuredContacts.tblInsuredContactsDataTable(dataSet.Tables["tblInsuredContacts"]));
      if (dataSet.Tables["tblInsuredSpecialContacts"] != null)
        base.Tables.Add((DataTable) new dsInsuredContacts.tblInsuredSpecialContactsDataTable(dataSet.Tables["tblInsuredSpecialContacts"]));
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsInsuredContacts.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsInsuredContacts.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["lstInsuredSpecialContactTypes"] != null)
        base.Tables.Add((DataTable) new dsInsuredContacts.lstInsuredSpecialContactTypesDataTable(dataSet.Tables["lstInsuredSpecialContactTypes"]));
      if (dataSet.Tables["lstSalutations"] != null)
        base.Tables.Add((DataTable) new dsInsuredContacts.lstSalutationsDataTable(dataSet.Tables["lstSalutations"]));
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
    this.tabletblInsuredContacts = (dsInsuredContacts.tblInsuredContactsDataTable) base.Tables["tblInsuredContacts"];
    if (initTable && this.tabletblInsuredContacts != null)
      this.tabletblInsuredContacts.InitVars();
    this.tabletblInsuredSpecialContacts = (dsInsuredContacts.tblInsuredSpecialContactsDataTable) base.Tables["tblInsuredSpecialContacts"];
    if (initTable && this.tabletblInsuredSpecialContacts != null)
      this.tabletblInsuredSpecialContacts.InitVars();
    this.tablelstDeliveryMethod = (dsInsuredContacts.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tablelstStatus = (dsInsuredContacts.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tablelstInsuredSpecialContactTypes = (dsInsuredContacts.lstInsuredSpecialContactTypesDataTable) base.Tables["lstInsuredSpecialContactTypes"];
    if (initTable && this.tablelstInsuredSpecialContactTypes != null)
      this.tablelstInsuredSpecialContactTypes.InitVars();
    this.tablelstSalutations = (dsInsuredContacts.lstSalutationsDataTable) base.Tables["lstSalutations"];
    if (initTable && this.tablelstSalutations != null)
      this.tablelstSalutations.InitVars();
    this.relationlstSalutationstblInsuredContacts = this.Relations["lstSalutationstblInsuredContacts"];
    this.relationlstDeliveryMethodtblInsuredContacts = this.Relations["lstDeliveryMethodtblInsuredContacts"];
    this.relationlstStatustblInsuredContacts = this.Relations["lstStatustblInsuredContacts"];
    this.relationtblInsuredContactstblInsuredSpecialContacts = this.Relations["tblInsuredContactstblInsuredSpecialContacts"];
    this.relationlstInsuredSpecialContactTypestblInsuredSpecialContacts = this.Relations["lstInsuredSpecialContactTypestblInsuredSpecialContacts"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInsuredContacts);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsInsuredContacts.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblInsuredContacts = new dsInsuredContacts.tblInsuredContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredContacts);
    this.tabletblInsuredSpecialContacts = new dsInsuredContacts.tblInsuredSpecialContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredSpecialContacts);
    this.tablelstDeliveryMethod = new dsInsuredContacts.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tablelstStatus = new dsInsuredContacts.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tablelstInsuredSpecialContactTypes = new dsInsuredContacts.lstInsuredSpecialContactTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstInsuredSpecialContactTypes);
    this.tablelstSalutations = new dsInsuredContacts.lstSalutationsDataTable();
    base.Tables.Add((DataTable) this.tablelstSalutations);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstSalutationstblInsuredContacts", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.SalutationColumn
    });
    this.tabletblInsuredContacts.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstDeliveryMethodtblInsuredContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.DeliveryMethodIDColumn
    });
    this.tabletblInsuredContacts.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstStatustblInsuredContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.StatusIDColumn
    });
    this.tabletblInsuredContacts.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("tblInsuredContactstblInsuredSpecialContacts", new DataColumn[1]
    {
      this.tabletblInsuredContacts.InsuredContactGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredSpecialContacts.InsuredContactGuidColumn
    });
    this.tabletblInsuredSpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstInsuredSpecialContactTypestblInsuredSpecialContacts", new DataColumn[1]
    {
      this.tablelstInsuredSpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredSpecialContacts.SpecialContactTypeIDColumn
    });
    this.tabletblInsuredSpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    this.relationlstSalutationstblInsuredContacts = new DataRelation("lstSalutationstblInsuredContacts", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.SalutationColumn
    }, false);
    this.Relations.Add(this.relationlstSalutationstblInsuredContacts);
    this.relationlstDeliveryMethodtblInsuredContacts = new DataRelation("lstDeliveryMethodtblInsuredContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblInsuredContacts);
    this.relationlstStatustblInsuredContacts = new DataRelation("lstStatustblInsuredContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblInsuredContacts);
    this.relationtblInsuredContactstblInsuredSpecialContacts = new DataRelation("tblInsuredContactstblInsuredSpecialContacts", new DataColumn[1]
    {
      this.tabletblInsuredContacts.InsuredContactGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredSpecialContacts.InsuredContactGuidColumn
    }, false);
    this.Relations.Add(this.relationtblInsuredContactstblInsuredSpecialContacts);
    this.relationlstInsuredSpecialContactTypestblInsuredSpecialContacts = new DataRelation("lstInsuredSpecialContactTypestblInsuredSpecialContacts", new DataColumn[1]
    {
      this.tablelstInsuredSpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredSpecialContacts.SpecialContactTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstInsuredSpecialContactTypestblInsuredSpecialContacts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInsuredContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInsuredSpecialContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstInsuredSpecialContactTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstSalutations() => false;

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
    dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsInsuredContacts.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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
  public delegate void tblInsuredContactsRowChangeEventHandler(
    object sender,
    dsInsuredContacts.tblInsuredContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblInsuredSpecialContactsRowChangeEventHandler(
    object sender,
    dsInsuredContacts.tblInsuredSpecialContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsInsuredContacts.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsInsuredContacts.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstInsuredSpecialContactTypesRowChangeEventHandler(
    object sender,
    dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstSalutationsRowChangeEventHandler(
    object sender,
    dsInsuredContacts.lstSalutationsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblInsuredContactsDataTable : TypedTableBase<dsInsuredContacts.tblInsuredContactsRow>
  {
    private DataColumn columnInsuredContactID;
    private DataColumn columnInsuredContactGuid;
    private DataColumn columnInsuredLocationGuid;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnSalutation;
    private DataColumn columnFName;
    private DataColumn columnLName;
    private DataColumn columnTitle;
    private DataColumn columnPhone;
    private DataColumn columnExtension;
    private DataColumn columnCell;
    private DataColumn columnEmail;
    private DataColumn columnStatusID;
    private DataColumn columnRmNumber;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnState;
    private DataColumn columnISOCountryCode;
    private DataColumn columnRegion;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnFax;
    private DataColumn columnName;
    private DataColumn columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredContactsDataTable()
    {
      this.TableName = "tblInsuredContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredContactsDataTable(DataTable table)
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
    protected tblInsuredContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredContactIDColumn => this.columnInsuredContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredContactGuidColumn => this.columnInsuredContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredLocationGuidColumn => this.columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FNameColumn => this.columnFName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LNameColumn => this.columnLName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExtensionColumn => this.columnExtension;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CellColumn => this.columnCell;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RmNumberColumn => this.columnRmNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptOutColumn => this.columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow this[int index]
    {
      get => (dsInsuredContacts.tblInsuredContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInsuredContactsRow(dsInsuredContacts.tblInsuredContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow AddtblInsuredContactsRow(
      Guid InsuredContactGuid,
      Guid InsuredLocationGuid,
      dsInsuredContacts.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblInsuredContacts,
      dsInsuredContacts.lstSalutationsRow parentlstSalutationsRowBylstSalutationstblInsuredContacts,
      string FName,
      string LName,
      string Title,
      string Phone,
      string Extension,
      string Cell,
      string Email,
      dsInsuredContacts.lstStatusRow parentlstStatusRowBylstStatustblInsuredContacts,
      string RmNumber,
      string Address1,
      string Address2,
      string City,
      string County,
      string State,
      string ISOCountryCode,
      string _Region,
      string ZipCode,
      string ZipPlus,
      string Fax,
      string Name,
      bool OptOut)
    {
      dsInsuredContacts.tblInsuredContactsRow row = (dsInsuredContacts.tblInsuredContactsRow) this.NewRow();
      object[] objArray = new object[26]
      {
        null,
        (object) InsuredContactGuid,
        (object) InsuredLocationGuid,
        null,
        null,
        (object) FName,
        (object) LName,
        (object) Title,
        (object) Phone,
        (object) Extension,
        (object) Cell,
        (object) Email,
        null,
        (object) RmNumber,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) State,
        (object) ISOCountryCode,
        (object) _Region,
        (object) ZipCode,
        (object) ZipPlus,
        (object) Fax,
        (object) Name,
        (object) OptOut
      };
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblInsuredContacts != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblInsuredContacts[0]);
      if (parentlstSalutationsRowBylstSalutationstblInsuredContacts != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parentlstSalutationsRowBylstSalutationstblInsuredContacts[0]);
      if (parentlstStatusRowBylstStatustblInsuredContacts != null)
        objArray[12] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblInsuredContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow FindByInsuredContactGuid(Guid InsuredContactGuid)
    {
      return (dsInsuredContacts.tblInsuredContactsRow) this.Rows.Find(new object[1]
      {
        (object) InsuredContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredContacts.tblInsuredContactsDataTable contactsDataTable = (dsInsuredContacts.tblInsuredContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredContacts.tblInsuredContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredContactID = this.Columns["InsuredContactID"];
      this.columnInsuredContactGuid = this.Columns["InsuredContactGuid"];
      this.columnInsuredLocationGuid = this.Columns["InsuredLocationGuid"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnSalutation = this.Columns["Salutation"];
      this.columnFName = this.Columns["FName"];
      this.columnLName = this.Columns["LName"];
      this.columnTitle = this.Columns["Title"];
      this.columnPhone = this.Columns["Phone"];
      this.columnExtension = this.Columns["Extension"];
      this.columnCell = this.Columns["Cell"];
      this.columnEmail = this.Columns["Email"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnRmNumber = this.Columns["RmNumber"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnState = this.Columns["State"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnRegion = this.Columns["Region"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnFax = this.Columns["Fax"];
      this.columnName = this.Columns["Name"];
      this.columnOptOut = this.Columns["OptOut"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredContactID = new DataColumn("InsuredContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredContactID);
      this.columnInsuredContactGuid = new DataColumn("InsuredContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredContactGuid);
      this.columnInsuredLocationGuid = new DataColumn("InsuredLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLocationGuid);
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.columnFName = new DataColumn("FName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFName);
      this.columnLName = new DataColumn("LName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLName);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnExtension = new DataColumn("Extension", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExtension);
      this.columnCell = new DataColumn("Cell", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCell);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnRmNumber = new DataColumn("RmNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRmNumber);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnOptOut = new DataColumn("OptOut", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptOut);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredContactsKey4", new DataColumn[1]
      {
        this.columnInsuredContactGuid
      }, true));
      this.columnInsuredContactID.AutoIncrement = true;
      this.columnInsuredContactID.AllowDBNull = false;
      this.columnInsuredContactID.ReadOnly = true;
      this.columnInsuredContactGuid.AllowDBNull = false;
      this.columnInsuredContactGuid.Unique = true;
      this.columnInsuredLocationGuid.AllowDBNull = false;
      this.columnISOCountryCode.DefaultValue = (object) "USA";
      this.columnOptOut.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow NewtblInsuredContactsRow()
    {
      return (dsInsuredContacts.tblInsuredContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredContacts.tblInsuredContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredContacts.tblInsuredContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredContactsRowChangeEventHandler contactsRowChangedEvent = this.tblInsuredContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsInsuredContacts.tblInsuredContactsRowChangeEvent((dsInsuredContacts.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredContactsRowChangeEventHandler rowChangingEvent = this.tblInsuredContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredContacts.tblInsuredContactsRowChangeEvent((dsInsuredContacts.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblInsuredContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsInsuredContacts.tblInsuredContactsRowChangeEvent((dsInsuredContacts.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredContactsRowChangeEventHandler rowDeletingEvent = this.tblInsuredContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredContacts.tblInsuredContactsRowChangeEvent((dsInsuredContacts.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInsuredContactsRow(dsInsuredContacts.tblInsuredContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
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
        FixedValue = dsInsuredContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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
  public class tblInsuredSpecialContactsDataTable : 
    TypedTableBase<dsInsuredContacts.tblInsuredSpecialContactsRow>
  {
    private DataColumn columnInsuredContactGuid;
    private DataColumn columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredSpecialContactsDataTable()
    {
      this.TableName = "tblInsuredSpecialContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredSpecialContactsDataTable(DataTable table)
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
    protected tblInsuredSpecialContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredContactGuidColumn => this.columnInsuredContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow this[int index]
    {
      get => (dsInsuredContacts.tblInsuredSpecialContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler tblInsuredSpecialContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler tblInsuredSpecialContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler tblInsuredSpecialContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler tblInsuredSpecialContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInsuredSpecialContactsRow(dsInsuredContacts.tblInsuredSpecialContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow AddtblInsuredSpecialContactsRow(
      dsInsuredContacts.tblInsuredContactsRow parenttblInsuredContactsRowBytblInsuredContactstblInsuredSpecialContacts,
      dsInsuredContacts.lstInsuredSpecialContactTypesRow parentlstInsuredSpecialContactTypesRowBylstInsuredSpecialContactTypestblInsuredSpecialContacts)
    {
      dsInsuredContacts.tblInsuredSpecialContactsRow row = (dsInsuredContacts.tblInsuredSpecialContactsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblInsuredContactsRowBytblInsuredContactstblInsuredSpecialContacts != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblInsuredContactsRowBytblInsuredContactstblInsuredSpecialContacts[1]);
      if (parentlstInsuredSpecialContactTypesRowBylstInsuredSpecialContactTypestblInsuredSpecialContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstInsuredSpecialContactTypesRowBylstInsuredSpecialContactTypestblInsuredSpecialContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow FindByInsuredContactGuidSpecialContactTypeID(
      Guid InsuredContactGuid,
      int SpecialContactTypeID)
    {
      return (dsInsuredContacts.tblInsuredSpecialContactsRow) this.Rows.Find(new object[2]
      {
        (object) InsuredContactGuid,
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredContacts.tblInsuredSpecialContactsDataTable contactsDataTable = (dsInsuredContacts.tblInsuredSpecialContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredContacts.tblInsuredSpecialContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredContactGuid = this.Columns["InsuredContactGuid"];
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredContactGuid = new DataColumn("InsuredContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredContactGuid);
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredContactsKey5", new DataColumn[2]
      {
        this.columnInsuredContactGuid,
        this.columnSpecialContactTypeID
      }, true));
      this.columnInsuredContactGuid.AllowDBNull = false;
      this.columnSpecialContactTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow NewtblInsuredSpecialContactsRow()
    {
      return (dsInsuredContacts.tblInsuredSpecialContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredContacts.tblInsuredSpecialContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredContacts.tblInsuredSpecialContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredSpecialContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler contactsRowChangedEvent = this.tblInsuredSpecialContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsInsuredContacts.tblInsuredSpecialContactsRowChangeEvent((dsInsuredContacts.tblInsuredSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredSpecialContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler rowChangingEvent = this.tblInsuredSpecialContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredContacts.tblInsuredSpecialContactsRowChangeEvent((dsInsuredContacts.tblInsuredSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredSpecialContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblInsuredSpecialContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsInsuredContacts.tblInsuredSpecialContactsRowChangeEvent((dsInsuredContacts.tblInsuredSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredSpecialContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.tblInsuredSpecialContactsRowChangeEventHandler rowDeletingEvent = this.tblInsuredSpecialContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredContacts.tblInsuredSpecialContactsRowChangeEvent((dsInsuredContacts.tblInsuredSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInsuredSpecialContactsRow(
      dsInsuredContacts.tblInsuredSpecialContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
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
        FixedValue = dsInsuredContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredSpecialContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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
  public class lstDeliveryMethodDataTable : TypedTableBase<dsInsuredContacts.lstDeliveryMethodRow>
  {
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeliveryMethodDataTable()
    {
      this.TableName = "lstDeliveryMethod";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeliveryMethodDataTable(DataTable table)
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
    protected lstDeliveryMethodDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstDeliveryMethodRow this[int index]
    {
      get => (dsInsuredContacts.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDeliveryMethodRow(dsInsuredContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsInsuredContacts.lstDeliveryMethodRow row = (dsInsuredContacts.lstDeliveryMethodRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsInsuredContacts.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredContacts.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsInsuredContacts.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredContacts.lstDeliveryMethodDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredContactsKey7", new DataColumn[1]
      {
        this.columnDeliveryMethodID
      }, true));
      this.columnDeliveryMethodID.AutoIncrement = true;
      this.columnDeliveryMethodID.AllowDBNull = false;
      this.columnDeliveryMethodID.ReadOnly = true;
      this.columnDeliveryMethodID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsInsuredContacts.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredContacts.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredContacts.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsInsuredContacts.lstDeliveryMethodRowChangeEvent((dsInsuredContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredContacts.lstDeliveryMethodRowChangeEvent((dsInsuredContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsInsuredContacts.lstDeliveryMethodRowChangeEvent((dsInsuredContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredContacts.lstDeliveryMethodRowChangeEvent((dsInsuredContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsInsuredContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
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
        FixedValue = dsInsuredContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsInsuredContacts.lstStatusRow>
  {
    private DataColumn columnStatusID;
    private DataColumn columnStatus;
    private DataColumn columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusDataTable()
    {
      this.TableName = "lstStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusDataTable(DataTable table)
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
    protected lstStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisableColumn => this.columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstStatusRow this[int index]
    {
      get => (dsInsuredContacts.lstStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatusRow(dsInsuredContacts.lstStatusRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstStatusRow AddlstStatusRow(
      int StatusID,
      string Status,
      bool Disable)
    {
      dsInsuredContacts.lstStatusRow row = (dsInsuredContacts.lstStatusRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StatusID,
        (object) Status,
        (object) Disable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsInsuredContacts.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredContacts.lstStatusDataTable lstStatusDataTable = (dsInsuredContacts.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredContacts.lstStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatus = this.Columns["Status"];
      this.columnDisable = this.Columns["Disable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDisable = new DataColumn("Disable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisable);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredContactsKey8", new DataColumn[1]
      {
        this.columnStatusID
      }, true));
      this.columnStatusID.AllowDBNull = false;
      this.columnStatusID.Unique = true;
      this.columnDisable.AllowDBNull = false;
      this.columnDisable.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstStatusRow NewlstStatusRow()
    {
      return (dsInsuredContacts.lstStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredContacts.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredContacts.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsInsuredContacts.lstStatusRowChangeEvent((dsInsuredContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredContacts.lstStatusRowChangeEvent((dsInsuredContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsInsuredContacts.lstStatusRowChangeEvent((dsInsuredContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredContacts.lstStatusRowChangeEvent((dsInsuredContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatusRow(dsInsuredContacts.lstStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
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
        FixedValue = dsInsuredContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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
  public class lstInsuredSpecialContactTypesDataTable : 
    TypedTableBase<dsInsuredContacts.lstInsuredSpecialContactTypesRow>
  {
    private DataColumn columnSpecialContactTypeID;
    private DataColumn columnSpecialContactType;
    private DataColumn columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstInsuredSpecialContactTypesDataTable()
    {
      this.TableName = "lstInsuredSpecialContactTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstInsuredSpecialContactTypesDataTable(DataTable table)
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
    protected lstInsuredSpecialContactTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecialContactTypeColumn => this.columnSpecialContactType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstInsuredSpecialContactTypesRow this[int index]
    {
      get => (dsInsuredContacts.lstInsuredSpecialContactTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler lstInsuredSpecialContactTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler lstInsuredSpecialContactTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler lstInsuredSpecialContactTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler lstInsuredSpecialContactTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstInsuredSpecialContactTypesRow(
      dsInsuredContacts.lstInsuredSpecialContactTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstInsuredSpecialContactTypesRow AddlstInsuredSpecialContactTypesRow(
      string SpecialContactType,
      bool Hidden)
    {
      dsInsuredContacts.lstInsuredSpecialContactTypesRow row = (dsInsuredContacts.lstInsuredSpecialContactTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) SpecialContactType,
        (object) Hidden
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstInsuredSpecialContactTypesRow FindBySpecialContactTypeID(
      int SpecialContactTypeID)
    {
      return (dsInsuredContacts.lstInsuredSpecialContactTypesRow) this.Rows.Find(new object[1]
      {
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredContacts.lstInsuredSpecialContactTypesDataTable contactTypesDataTable = (dsInsuredContacts.lstInsuredSpecialContactTypesDataTable) base.Clone();
      contactTypesDataTable.InitVars();
      return (DataTable) contactTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredContacts.lstInsuredSpecialContactTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
      this.columnSpecialContactType = this.Columns["SpecialContactType"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.columnSpecialContactType = new DataColumn("SpecialContactType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactType);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredContactsKey6", new DataColumn[1]
      {
        this.columnSpecialContactTypeID
      }, true));
      this.columnSpecialContactTypeID.AutoIncrement = true;
      this.columnSpecialContactTypeID.AllowDBNull = false;
      this.columnSpecialContactTypeID.ReadOnly = true;
      this.columnSpecialContactTypeID.Unique = true;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstInsuredSpecialContactTypesRow NewlstInsuredSpecialContactTypesRow()
    {
      return (dsInsuredContacts.lstInsuredSpecialContactTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredContacts.lstInsuredSpecialContactTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInsuredContacts.lstInsuredSpecialContactTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredSpecialContactTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler typesRowChangedEvent = this.lstInsuredSpecialContactTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEvent((dsInsuredContacts.lstInsuredSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredSpecialContactTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler rowChangingEvent = this.lstInsuredSpecialContactTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEvent((dsInsuredContacts.lstInsuredSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredSpecialContactTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler typesRowDeletedEvent = this.lstInsuredSpecialContactTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEvent((dsInsuredContacts.lstInsuredSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredSpecialContactTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEventHandler rowDeletingEvent = this.lstInsuredSpecialContactTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredContacts.lstInsuredSpecialContactTypesRowChangeEvent((dsInsuredContacts.lstInsuredSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstInsuredSpecialContactTypesRow(
      dsInsuredContacts.lstInsuredSpecialContactTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
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
        FixedValue = dsInsuredContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstInsuredSpecialContactTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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
  public class lstSalutationsDataTable : TypedTableBase<dsInsuredContacts.lstSalutationsRow>
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
    public dsInsuredContacts.lstSalutationsRow this[int index]
    {
      get => (dsInsuredContacts.lstSalutationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsuredContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstSalutationsRow(dsInsuredContacts.lstSalutationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstSalutationsRow AddlstSalutationsRow(string Salutation)
    {
      dsInsuredContacts.lstSalutationsRow row = (dsInsuredContacts.lstSalutationsRow) this.NewRow();
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
    public dsInsuredContacts.lstSalutationsRow FindBySalutation(string Salutation)
    {
      return (dsInsuredContacts.lstSalutationsRow) this.Rows.Find(new object[1]
      {
        (object) Salutation
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredContacts.lstSalutationsDataTable salutationsDataTable = (dsInsuredContacts.lstSalutationsDataTable) base.Clone();
      salutationsDataTable.InitVars();
      return (DataTable) salutationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredContacts.lstSalutationsDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnSalutation
      }, true));
      this.columnSalutation.AllowDBNull = false;
      this.columnSalutation.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstSalutationsRow NewlstSalutationsRow()
    {
      return (dsInsuredContacts.lstSalutationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredContacts.lstSalutationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredContacts.lstSalutationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredContacts.lstSalutationsRowChangeEventHandler salutationsRowChangedEvent = this.lstSalutationsRowChangedEvent;
      if (salutationsRowChangedEvent == null)
        return;
      salutationsRowChangedEvent((object) this, new dsInsuredContacts.lstSalutationsRowChangeEvent((dsInsuredContacts.lstSalutationsRow) e.Row, e.Action));
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
      dsInsuredContacts.lstSalutationsRowChangeEventHandler rowChangingEvent = this.lstSalutationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredContacts.lstSalutationsRowChangeEvent((dsInsuredContacts.lstSalutationsRow) e.Row, e.Action));
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
      dsInsuredContacts.lstSalutationsRowChangeEventHandler salutationsRowDeletedEvent = this.lstSalutationsRowDeletedEvent;
      if (salutationsRowDeletedEvent == null)
        return;
      salutationsRowDeletedEvent((object) this, new dsInsuredContacts.lstSalutationsRowChangeEvent((dsInsuredContacts.lstSalutationsRow) e.Row, e.Action));
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
      dsInsuredContacts.lstSalutationsRowChangeEventHandler rowDeletingEvent = this.lstSalutationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredContacts.lstSalutationsRowChangeEvent((dsInsuredContacts.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstSalutationsRow(dsInsuredContacts.lstSalutationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredContacts dsInsuredContacts = new dsInsuredContacts();
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
        FixedValue = dsInsuredContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSalutationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredContacts.GetSchemaSerializable();
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

  public class tblInsuredContactsRow : DataRow
  {
    private dsInsuredContacts.tblInsuredContactsDataTable tabletblInsuredContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredContacts = (dsInsuredContacts.tblInsuredContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InsuredContactID
    {
      get => Conversions.ToInteger(this[this.tabletblInsuredContacts.InsuredContactIDColumn]);
      set => this[this.tabletblInsuredContacts.InsuredContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredContactGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredContacts.InsuredContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredContacts.InsuredContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredLocationGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredContacts.InsuredLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredContacts.InsuredLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredContacts.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Salutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.SalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Salutation' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.FNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FName' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.FNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.LNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LName' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.LNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Title
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.TitleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Title' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Extension
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.ExtensionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Extension' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.ExtensionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Cell
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.CellColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Cell' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.CellColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredContacts.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RmNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.RmNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RmNumber' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.RmNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.ISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool OptOut
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblInsuredContacts.OptOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptOut' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.OptOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstSalutationsRow lstSalutationsRow
    {
      get
      {
        return (dsInsuredContacts.lstSalutationsRow) this.GetParentRow(this.Table.ParentRelations["lstSalutationstblInsuredContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSalutationstblInsuredContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsInsuredContacts.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblInsuredContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblInsuredContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsInsuredContacts.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblInsuredContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblInsuredContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblInsuredContacts.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblInsuredContacts.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSalutationNull() => this.IsNull(this.tabletblInsuredContacts.SalutationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSalutationNull()
    {
      this[this.tabletblInsuredContacts.SalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFNameNull() => this.IsNull(this.tabletblInsuredContacts.FNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFNameNull()
    {
      this[this.tabletblInsuredContacts.FNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLNameNull() => this.IsNull(this.tabletblInsuredContacts.LNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLNameNull()
    {
      this[this.tabletblInsuredContacts.LNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTitleNull() => this.IsNull(this.tabletblInsuredContacts.TitleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTitleNull()
    {
      this[this.tabletblInsuredContacts.TitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblInsuredContacts.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblInsuredContacts.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExtensionNull() => this.IsNull(this.tabletblInsuredContacts.ExtensionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExtensionNull()
    {
      this[this.tabletblInsuredContacts.ExtensionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCellNull() => this.IsNull(this.tabletblInsuredContacts.CellColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCellNull()
    {
      this[this.tabletblInsuredContacts.CellColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblInsuredContacts.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblInsuredContacts.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblInsuredContacts.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblInsuredContacts.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRmNumberNull() => this.IsNull(this.tabletblInsuredContacts.RmNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRmNumberNull()
    {
      this[this.tabletblInsuredContacts.RmNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblInsuredContacts.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblInsuredContacts.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblInsuredContacts.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblInsuredContacts.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblInsuredContacts.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblInsuredContacts.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblInsuredContacts.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblInsuredContacts.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblInsuredContacts.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblInsuredContacts.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblInsuredContacts.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tabletblInsuredContacts.ISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblInsuredContacts.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblInsuredContacts.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblInsuredContacts.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblInsuredContacts.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblInsuredContacts.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblInsuredContacts.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblInsuredContacts.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblInsuredContacts.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblInsuredContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblInsuredContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOptOutNull() => this.IsNull(this.tabletblInsuredContacts.OptOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOptOutNull()
    {
      this[this.tabletblInsuredContacts.OptOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow[] GettblInsuredSpecialContactsRows()
    {
      return this.Table.ChildRelations["tblInsuredContactstblInsuredSpecialContacts"] != null ? (dsInsuredContacts.tblInsuredSpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblInsuredContactstblInsuredSpecialContacts"]) : new dsInsuredContacts.tblInsuredSpecialContactsRow[0];
    }
  }

  public class tblInsuredSpecialContactsRow : DataRow
  {
    private dsInsuredContacts.tblInsuredSpecialContactsDataTable tabletblInsuredSpecialContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredSpecialContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredSpecialContacts = (dsInsuredContacts.tblInsuredSpecialContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredContactGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredSpecialContacts.InsuredContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredSpecialContacts.InsuredContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblInsuredSpecialContacts.SpecialContactTypeIDColumn]);
      }
      set => this[this.tabletblInsuredSpecialContacts.SpecialContactTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow tblInsuredContactsRow
    {
      get
      {
        return (dsInsuredContacts.tblInsuredContactsRow) this.GetParentRow(this.Table.ParentRelations["tblInsuredContactstblInsuredSpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInsuredContactstblInsuredSpecialContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstInsuredSpecialContactTypesRow lstInsuredSpecialContactTypesRow
    {
      get
      {
        return (dsInsuredContacts.lstInsuredSpecialContactTypesRow) this.GetParentRow(this.Table.ParentRelations["lstInsuredSpecialContactTypestblInsuredSpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstInsuredSpecialContactTypestblInsuredSpecialContacts"]);
      }
    }
  }

  public class lstDeliveryMethodRow : DataRow
  {
    private dsInsuredContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsInsuredContacts.lstDeliveryMethodDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DeliveryMethodID
    {
      get => Conversions.ToInteger(this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn]);
      set => this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstDeliveryMethod.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstDeliveryMethod' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstDeliveryMethod.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstDeliveryMethod.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstDeliveryMethod.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow[] GettblInsuredContactsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblInsuredContacts"] != null ? (dsInsuredContacts.tblInsuredContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblInsuredContacts"]) : new dsInsuredContacts.tblInsuredContactsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsInsuredContacts.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsInsuredContacts.lstStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tablelstStatus.StatusIDColumn]);
      set => this[this.tablelstStatus.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstStatus.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Status' in table 'lstStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStatus.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Disable
    {
      get => Conversions.ToBoolean(this[this.tablelstStatus.DisableColumn]);
      set => this[this.tablelstStatus.DisableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow[] GettblInsuredContactsRows()
    {
      return this.Table.ChildRelations["lstStatustblInsuredContacts"] != null ? (dsInsuredContacts.tblInsuredContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblInsuredContacts"]) : new dsInsuredContacts.tblInsuredContactsRow[0];
    }
  }

  public class lstInsuredSpecialContactTypesRow : DataRow
  {
    private dsInsuredContacts.lstInsuredSpecialContactTypesDataTable tablelstInsuredSpecialContactTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstInsuredSpecialContactTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstInsuredSpecialContactTypes = (dsInsuredContacts.lstInsuredSpecialContactTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstInsuredSpecialContactTypes.SpecialContactTypeIDColumn]);
      }
      set
      {
        this[this.tablelstInsuredSpecialContactTypes.SpecialContactTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SpecialContactType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstInsuredSpecialContactTypes.SpecialContactTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpecialContactType' in table 'lstInsuredSpecialContactTypes' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablelstInsuredSpecialContactTypes.SpecialContactTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tablelstInsuredSpecialContactTypes.HiddenColumn]);
      set => this[this.tablelstInsuredSpecialContactTypes.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSpecialContactTypeNull()
    {
      return this.IsNull(this.tablelstInsuredSpecialContactTypes.SpecialContactTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSpecialContactTypeNull()
    {
      this[this.tablelstInsuredSpecialContactTypes.SpecialContactTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow[] GettblInsuredSpecialContactsRows()
    {
      return this.Table.ChildRelations["lstInsuredSpecialContactTypestblInsuredSpecialContacts"] != null ? (dsInsuredContacts.tblInsuredSpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstInsuredSpecialContactTypestblInsuredSpecialContacts"]) : new dsInsuredContacts.tblInsuredSpecialContactsRow[0];
    }
  }

  public class lstSalutationsRow : DataRow
  {
    private dsInsuredContacts.lstSalutationsDataTable tablelstSalutations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSalutationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSalutations = (dsInsuredContacts.lstSalutationsDataTable) this.Table;
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
    public dsInsuredContacts.tblInsuredContactsRow[] GettblInsuredContactsRows()
    {
      return this.Table.ChildRelations["lstSalutationstblInsuredContacts"] != null ? (dsInsuredContacts.tblInsuredContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstSalutationstblInsuredContacts"]) : new dsInsuredContacts.tblInsuredContactsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInsuredContactsRowChangeEvent : EventArgs
  {
    private dsInsuredContacts.tblInsuredContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredContactsRowChangeEvent(
      dsInsuredContacts.tblInsuredContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInsuredSpecialContactsRowChangeEvent : EventArgs
  {
    private dsInsuredContacts.tblInsuredSpecialContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredSpecialContactsRowChangeEvent(
      dsInsuredContacts.tblInsuredSpecialContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.tblInsuredSpecialContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsInsuredContacts.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(
      dsInsuredContacts.lstDeliveryMethodRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsInsuredContacts.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusRowChangeEvent(dsInsuredContacts.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstInsuredSpecialContactTypesRowChangeEvent : EventArgs
  {
    private dsInsuredContacts.lstInsuredSpecialContactTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstInsuredSpecialContactTypesRowChangeEvent(
      dsInsuredContacts.lstInsuredSpecialContactTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstInsuredSpecialContactTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstSalutationsRowChangeEvent : EventArgs
  {
    private dsInsuredContacts.lstSalutationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSalutationsRowChangeEvent(
      dsInsuredContacts.lstSalutationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsuredContacts.lstSalutationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
