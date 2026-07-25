// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries.dsIntermediaryContacts
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsIntermediaryContacts")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsIntermediaryContacts : DataSet
{
  private dsIntermediaryContacts.tblIntermediaryContactsDataTable tabletblIntermediaryContacts;
  private dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable tabletblIntermediarySpecialContacts;
  private dsIntermediaryContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsIntermediaryContacts.lstStatusDataTable tablelstStatus;
  private dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable tablelstIntermediarySpecialContactTypes;
  private dsIntermediaryContacts.tblIntermediariesDataTable tabletblIntermediaries;
  private DataRelation relationtblIntermediariestblIntermediaryContacts;
  private DataRelation relationlstStatustblIntermediaryContacts;
  private DataRelation relationlstDeliveryMethodtblIntermediaryContacts;
  private DataRelation relationlstCompanySpecialContactTypestblIntermediarySpecialContacts;
  private DataRelation relationtblIntermediaryContactstblIntermediarySpecialContacts;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsIntermediaryContacts()
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
  protected dsIntermediaryContacts(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblIntermediaryContacts)] != null)
          base.Tables.Add((DataTable) new dsIntermediaryContacts.tblIntermediaryContactsDataTable(dataSet.Tables[nameof (tblIntermediaryContacts)]));
        if (dataSet.Tables[nameof (tblIntermediarySpecialContacts)] != null)
          base.Tables.Add((DataTable) new dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable(dataSet.Tables[nameof (tblIntermediarySpecialContacts)]));
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsIntermediaryContacts.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsIntermediaryContacts.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (lstIntermediarySpecialContactTypes)] != null)
          base.Tables.Add((DataTable) new dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable(dataSet.Tables[nameof (lstIntermediarySpecialContactTypes)]));
        if (dataSet.Tables[nameof (tblIntermediaries)] != null)
          base.Tables.Add((DataTable) new dsIntermediaryContacts.tblIntermediariesDataTable(dataSet.Tables[nameof (tblIntermediaries)]));
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
  public dsIntermediaryContacts.tblIntermediaryContactsDataTable tblIntermediaryContacts
  {
    get => this.tabletblIntermediaryContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable tblIntermediarySpecialContacts
  {
    get => this.tabletblIntermediarySpecialContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIntermediaryContacts.lstDeliveryMethodDataTable lstDeliveryMethod
  {
    get => this.tablelstDeliveryMethod;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIntermediaryContacts.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable lstIntermediarySpecialContactTypes
  {
    get => this.tablelstIntermediarySpecialContactTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIntermediaryContacts.tblIntermediariesDataTable tblIntermediaries
  {
    get => this.tabletblIntermediaries;
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
    dsIntermediaryContacts intermediaryContacts = (dsIntermediaryContacts) base.Clone();
    intermediaryContacts.InitVars();
    intermediaryContacts.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) intermediaryContacts;
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
      if (dataSet.Tables["tblIntermediaryContacts"] != null)
        base.Tables.Add((DataTable) new dsIntermediaryContacts.tblIntermediaryContactsDataTable(dataSet.Tables["tblIntermediaryContacts"]));
      if (dataSet.Tables["tblIntermediarySpecialContacts"] != null)
        base.Tables.Add((DataTable) new dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable(dataSet.Tables["tblIntermediarySpecialContacts"]));
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsIntermediaryContacts.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsIntermediaryContacts.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["lstIntermediarySpecialContactTypes"] != null)
        base.Tables.Add((DataTable) new dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable(dataSet.Tables["lstIntermediarySpecialContactTypes"]));
      if (dataSet.Tables["tblIntermediaries"] != null)
        base.Tables.Add((DataTable) new dsIntermediaryContacts.tblIntermediariesDataTable(dataSet.Tables["tblIntermediaries"]));
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
    this.tabletblIntermediaryContacts = (dsIntermediaryContacts.tblIntermediaryContactsDataTable) base.Tables["tblIntermediaryContacts"];
    if (initTable && this.tabletblIntermediaryContacts != null)
      this.tabletblIntermediaryContacts.InitVars();
    this.tabletblIntermediarySpecialContacts = (dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable) base.Tables["tblIntermediarySpecialContacts"];
    if (initTable && this.tabletblIntermediarySpecialContacts != null)
      this.tabletblIntermediarySpecialContacts.InitVars();
    this.tablelstDeliveryMethod = (dsIntermediaryContacts.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tablelstStatus = (dsIntermediaryContacts.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tablelstIntermediarySpecialContactTypes = (dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable) base.Tables["lstIntermediarySpecialContactTypes"];
    if (initTable && this.tablelstIntermediarySpecialContactTypes != null)
      this.tablelstIntermediarySpecialContactTypes.InitVars();
    this.tabletblIntermediaries = (dsIntermediaryContacts.tblIntermediariesDataTable) base.Tables["tblIntermediaries"];
    if (initTable && this.tabletblIntermediaries != null)
      this.tabletblIntermediaries.InitVars();
    this.relationtblIntermediariestblIntermediaryContacts = this.Relations["tblIntermediariestblIntermediaryContacts"];
    this.relationlstStatustblIntermediaryContacts = this.Relations["lstStatustblIntermediaryContacts"];
    this.relationlstDeliveryMethodtblIntermediaryContacts = this.Relations["lstDeliveryMethodtblIntermediaryContacts"];
    this.relationlstCompanySpecialContactTypestblIntermediarySpecialContacts = this.Relations["lstCompanySpecialContactTypestblIntermediarySpecialContacts"];
    this.relationtblIntermediaryContactstblIntermediarySpecialContacts = this.Relations["tblIntermediaryContactstblIntermediarySpecialContacts"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsIntermediaryContacts);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsIntermediaryContacts.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblIntermediaryContacts = new dsIntermediaryContacts.tblIntermediaryContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediaryContacts);
    this.tabletblIntermediarySpecialContacts = new dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediarySpecialContacts);
    this.tablelstDeliveryMethod = new dsIntermediaryContacts.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tablelstStatus = new dsIntermediaryContacts.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tablelstIntermediarySpecialContactTypes = new dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstIntermediarySpecialContactTypes);
    this.tabletblIntermediaries = new dsIntermediaryContacts.tblIntermediariesDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediaries);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblIntermediariestblIntermediaryContacts", new DataColumn[1]
    {
      this.tabletblIntermediaries.IntermediaryIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.IntermediaryIDColumn
    });
    this.tabletblIntermediaryContacts.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstStatustblIntermediaryContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.StatusIDColumn
    });
    this.tabletblIntermediaryContacts.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstDeliveryMethodtblIntermediaryContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.DeliveryMethodIDColumn
    });
    this.tabletblIntermediaryContacts.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstCompanySpecialContactTypestblIntermediarySpecialContacts", new DataColumn[1]
    {
      this.tablelstIntermediarySpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediarySpecialContacts.SpecialContactTypeIDColumn
    });
    this.tabletblIntermediarySpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("tblIntermediaryContactstblIntermediarySpecialContacts", new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediarySpecialContacts.IntermediaryContactGuidColumn
    });
    this.tabletblIntermediarySpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    this.relationtblIntermediariestblIntermediaryContacts = new DataRelation("tblIntermediariestblIntermediaryContacts", new DataColumn[1]
    {
      this.tabletblIntermediaries.IntermediaryIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.IntermediaryIDColumn
    }, false);
    this.Relations.Add(this.relationtblIntermediariestblIntermediaryContacts);
    this.relationlstStatustblIntermediaryContacts = new DataRelation("lstStatustblIntermediaryContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblIntermediaryContacts);
    this.relationlstDeliveryMethodtblIntermediaryContacts = new DataRelation("lstDeliveryMethodtblIntermediaryContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblIntermediaryContacts);
    this.relationlstCompanySpecialContactTypestblIntermediarySpecialContacts = new DataRelation("lstCompanySpecialContactTypestblIntermediarySpecialContacts", new DataColumn[1]
    {
      this.tablelstIntermediarySpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediarySpecialContacts.SpecialContactTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstCompanySpecialContactTypestblIntermediarySpecialContacts);
    this.relationtblIntermediaryContactstblIntermediarySpecialContacts = new DataRelation("tblIntermediaryContactstblIntermediarySpecialContacts", new DataColumn[1]
    {
      this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblIntermediarySpecialContacts.IntermediaryContactGuidColumn
    }, false);
    this.Relations.Add(this.relationtblIntermediaryContactstblIntermediarySpecialContacts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblIntermediaryContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblIntermediarySpecialContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstIntermediarySpecialContactTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblIntermediaries() => false;

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
    dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = intermediaryContacts.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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
  public delegate void tblIntermediaryContactsRowChangeEventHandler(
    object sender,
    dsIntermediaryContacts.tblIntermediaryContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblIntermediarySpecialContactsRowChangeEventHandler(
    object sender,
    dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsIntermediaryContacts.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsIntermediaryContacts.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstIntermediarySpecialContactTypesRowChangeEventHandler(
    object sender,
    dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblIntermediariesRowChangeEventHandler(
    object sender,
    dsIntermediaryContacts.tblIntermediariesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblIntermediaryContactsDataTable : 
    TypedTableBase<dsIntermediaryContacts.tblIntermediaryContactsRow>
  {
    private DataColumn columnIntermediaryContactGuid;
    private DataColumn columnIntermediaryID;
    private DataColumn columnSalutation;
    private DataColumn columnFName;
    private DataColumn columnLName;
    private DataColumn columnTitle;
    private DataColumn columnPhone;
    private DataColumn columnExtension;
    private DataColumn columnCell;
    private DataColumn columnFax;
    private DataColumn columnEmail;
    private DataColumn columnStatusID;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnName;
    private DataColumn columnContactSignature;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblIntermediaryContactsDataTable()
    {
      this.TableName = "tblIntermediaryContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblIntermediaryContactsDataTable(DataTable table)
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
    protected tblIntermediaryContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntermediaryContactGuidColumn => this.columnIntermediaryContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntermediaryIDColumn => this.columnIntermediaryID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FNameColumn => this.columnFName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LNameColumn => this.columnLName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExtensionColumn => this.columnExtension;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CellColumn => this.columnCell;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactSignatureColumn => this.columnContactSignature;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow this[int index]
    {
      get => (dsIntermediaryContacts.tblIntermediaryContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblIntermediaryContactsRow(
      dsIntermediaryContacts.tblIntermediaryContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow AddtblIntermediaryContactsRow(
      Guid IntermediaryContactGuid,
      dsIntermediaryContacts.tblIntermediariesRow parenttblIntermediariesRowBytblIntermediariestblIntermediaryContacts,
      string Salutation,
      string FName,
      string LName,
      string Title,
      string Phone,
      string Extension,
      string Cell,
      string Fax,
      string Email,
      dsIntermediaryContacts.lstStatusRow parentlstStatusRowBylstStatustblIntermediaryContacts,
      dsIntermediaryContacts.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblIntermediaryContacts,
      string Name,
      byte[] ContactSignature)
    {
      dsIntermediaryContacts.tblIntermediaryContactsRow row = (dsIntermediaryContacts.tblIntermediaryContactsRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) IntermediaryContactGuid,
        null,
        (object) Salutation,
        (object) FName,
        (object) LName,
        (object) Title,
        (object) Phone,
        (object) Extension,
        (object) Cell,
        (object) Fax,
        (object) Email,
        null,
        null,
        (object) Name,
        (object) ContactSignature
      };
      if (parenttblIntermediariesRowBytblIntermediariestblIntermediaryContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblIntermediariesRowBytblIntermediariestblIntermediaryContacts[0]);
      if (parentlstStatusRowBylstStatustblIntermediaryContacts != null)
        objArray[11] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblIntermediaryContacts[0]);
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblIntermediaryContacts != null)
        objArray[12] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblIntermediaryContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow FindByIntermediaryContactGuid(
      Guid IntermediaryContactGuid)
    {
      return (dsIntermediaryContacts.tblIntermediaryContactsRow) this.Rows.Find(new object[1]
      {
        (object) IntermediaryContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaryContacts.tblIntermediaryContactsDataTable contactsDataTable = (dsIntermediaryContacts.tblIntermediaryContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaryContacts.tblIntermediaryContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryContactGuid = this.Columns["IntermediaryContactGuid"];
      this.columnIntermediaryID = this.Columns["IntermediaryID"];
      this.columnSalutation = this.Columns["Salutation"];
      this.columnFName = this.Columns["FName"];
      this.columnLName = this.Columns["LName"];
      this.columnTitle = this.Columns["Title"];
      this.columnPhone = this.Columns["Phone"];
      this.columnExtension = this.Columns["Extension"];
      this.columnCell = this.Columns["Cell"];
      this.columnFax = this.Columns["Fax"];
      this.columnEmail = this.Columns["Email"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnName = this.Columns["Name"];
      this.columnContactSignature = this.Columns["ContactSignature"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryContactGuid = new DataColumn("IntermediaryContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryContactGuid);
      this.columnIntermediaryID = new DataColumn("IntermediaryID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryID);
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
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnContactSignature = new DataColumn("ContactSignature", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactSignature);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediaryContactsKey1", new DataColumn[1]
      {
        this.columnIntermediaryContactGuid
      }, true));
      this.columnIntermediaryContactGuid.AllowDBNull = false;
      this.columnIntermediaryContactGuid.Unique = true;
      this.columnIntermediaryID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow NewtblIntermediaryContactsRow()
    {
      return (dsIntermediaryContacts.tblIntermediaryContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaryContacts.tblIntermediaryContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsIntermediaryContacts.tblIntermediaryContactsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler contactsRowChangedEvent = this.tblIntermediaryContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsIntermediaryContacts.tblIntermediaryContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler rowChangingEvent = this.tblIntermediaryContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaryContacts.tblIntermediaryContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblIntermediaryContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsIntermediaryContacts.tblIntermediaryContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediaryContactsRowChangeEventHandler rowDeletingEvent = this.tblIntermediaryContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaryContacts.tblIntermediaryContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblIntermediaryContactsRow(
      dsIntermediaryContacts.tblIntermediaryContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
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
        FixedValue = intermediaryContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediaryContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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
  public class tblIntermediarySpecialContactsDataTable : 
    TypedTableBase<dsIntermediaryContacts.tblIntermediarySpecialContactsRow>
  {
    private DataColumn columnIntermediaryContactGuid;
    private DataColumn columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblIntermediarySpecialContactsDataTable()
    {
      this.TableName = "tblIntermediarySpecialContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblIntermediarySpecialContactsDataTable(DataTable table)
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
    protected tblIntermediarySpecialContactsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntermediaryContactGuidColumn => this.columnIntermediaryContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow this[int index]
    {
      get => (dsIntermediaryContacts.tblIntermediarySpecialContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler tblIntermediarySpecialContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler tblIntermediarySpecialContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler tblIntermediarySpecialContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler tblIntermediarySpecialContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblIntermediarySpecialContactsRow(
      dsIntermediaryContacts.tblIntermediarySpecialContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow AddtblIntermediarySpecialContactsRow(
      dsIntermediaryContacts.tblIntermediaryContactsRow parenttblIntermediaryContactsRowBytblIntermediaryContactstblIntermediarySpecialContacts,
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow parentlstIntermediarySpecialContactTypesRowBylstCompanySpecialContactTypestblIntermediarySpecialContacts)
    {
      dsIntermediaryContacts.tblIntermediarySpecialContactsRow row = (dsIntermediaryContacts.tblIntermediarySpecialContactsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblIntermediaryContactsRowBytblIntermediaryContactstblIntermediarySpecialContacts != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblIntermediaryContactsRowBytblIntermediaryContactstblIntermediarySpecialContacts[0]);
      if (parentlstIntermediarySpecialContactTypesRowBylstCompanySpecialContactTypestblIntermediarySpecialContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstIntermediarySpecialContactTypesRowBylstCompanySpecialContactTypestblIntermediarySpecialContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow FindByIntermediaryContactGuidSpecialContactTypeID(
      Guid IntermediaryContactGuid,
      int SpecialContactTypeID)
    {
      return (dsIntermediaryContacts.tblIntermediarySpecialContactsRow) this.Rows.Find(new object[2]
      {
        (object) IntermediaryContactGuid,
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable contactsDataTable = (dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryContactGuid = this.Columns["IntermediaryContactGuid"];
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryContactGuid = new DataColumn("IntermediaryContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryContactGuid);
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediaryContactsKey4", new DataColumn[2]
      {
        this.columnIntermediaryContactGuid,
        this.columnSpecialContactTypeID
      }, true));
      this.columnIntermediaryContactGuid.AllowDBNull = false;
      this.columnSpecialContactTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow NewtblIntermediarySpecialContactsRow()
    {
      return (dsIntermediaryContacts.tblIntermediarySpecialContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaryContacts.tblIntermediarySpecialContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsIntermediaryContacts.tblIntermediarySpecialContactsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediarySpecialContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler contactsRowChangedEvent = this.tblIntermediarySpecialContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediarySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediarySpecialContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler rowChangingEvent = this.tblIntermediarySpecialContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediarySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediarySpecialContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblIntermediarySpecialContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediarySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediarySpecialContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEventHandler rowDeletingEvent = this.tblIntermediarySpecialContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaryContacts.tblIntermediarySpecialContactsRowChangeEvent((dsIntermediaryContacts.tblIntermediarySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblIntermediarySpecialContactsRow(
      dsIntermediaryContacts.tblIntermediarySpecialContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
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
        FixedValue = intermediaryContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediarySpecialContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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
  public class lstDeliveryMethodDataTable : 
    TypedTableBase<dsIntermediaryContacts.lstDeliveryMethodRow>
  {
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstDeliveryMethodDataTable()
    {
      this.TableName = "lstDeliveryMethod";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstDeliveryMethodDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstDeliveryMethodRow this[int index]
    {
      get => (dsIntermediaryContacts.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstDeliveryMethodRow(dsIntermediaryContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsIntermediaryContacts.lstDeliveryMethodRow row = (dsIntermediaryContacts.lstDeliveryMethodRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsIntermediaryContacts.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaryContacts.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsIntermediaryContacts.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaryContacts.lstDeliveryMethodDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediaryContactsKey2", new DataColumn[1]
      {
        this.columnDeliveryMethodID
      }, true));
      this.columnDeliveryMethodID.AutoIncrement = true;
      this.columnDeliveryMethodID.AllowDBNull = false;
      this.columnDeliveryMethodID.ReadOnly = true;
      this.columnDeliveryMethodID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsIntermediaryContacts.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaryContacts.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsIntermediaryContacts.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsIntermediaryContacts.lstDeliveryMethodRowChangeEvent((dsIntermediaryContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaryContacts.lstDeliveryMethodRowChangeEvent((dsIntermediaryContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsIntermediaryContacts.lstDeliveryMethodRowChangeEvent((dsIntermediaryContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaryContacts.lstDeliveryMethodRowChangeEvent((dsIntermediaryContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsIntermediaryContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
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
        FixedValue = intermediaryContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsIntermediaryContacts.lstStatusRow>
  {
    private DataColumn columnStatusID;
    private DataColumn columnStatusCode;
    private DataColumn columnStatus;
    private DataColumn columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatusDataTable()
    {
      this.TableName = "lstStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusCodeColumn => this.columnStatusCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DisableColumn => this.columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstStatusRow this[int index]
    {
      get => (dsIntermediaryContacts.lstStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatusRow(dsIntermediaryContacts.lstStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstStatusRow AddlstStatusRow(
      int StatusID,
      string StatusCode,
      string Status,
      bool Disable)
    {
      dsIntermediaryContacts.lstStatusRow row = (dsIntermediaryContacts.lstStatusRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) StatusID,
        (object) StatusCode,
        (object) Status,
        (object) Disable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsIntermediaryContacts.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaryContacts.lstStatusDataTable lstStatusDataTable = (dsIntermediaryContacts.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaryContacts.lstStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatusCode = this.Columns["StatusCode"];
      this.columnStatus = this.Columns["Status"];
      this.columnDisable = this.Columns["Disable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnStatusCode = new DataColumn("StatusCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusCode);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDisable = new DataColumn("Disable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisable);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediaryContactsKey3", new DataColumn[1]
      {
        this.columnStatusID
      }, true));
      this.columnStatusID.AllowDBNull = false;
      this.columnStatusID.Unique = true;
      this.columnDisable.AllowDBNull = false;
      this.columnDisable.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstStatusRow NewlstStatusRow()
    {
      return (dsIntermediaryContacts.lstStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaryContacts.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsIntermediaryContacts.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsIntermediaryContacts.lstStatusRowChangeEvent((dsIntermediaryContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaryContacts.lstStatusRowChangeEvent((dsIntermediaryContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsIntermediaryContacts.lstStatusRowChangeEvent((dsIntermediaryContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaryContacts.lstStatusRowChangeEvent((dsIntermediaryContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatusRow(dsIntermediaryContacts.lstStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
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
        FixedValue = intermediaryContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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
  public class lstIntermediarySpecialContactTypesDataTable : 
    TypedTableBase<dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow>
  {
    private DataColumn columnSpecialContactTypeID;
    private DataColumn columnSpecialContactType;
    private DataColumn columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstIntermediarySpecialContactTypesDataTable()
    {
      this.TableName = "lstIntermediarySpecialContactTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstIntermediarySpecialContactTypesDataTable(DataTable table)
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
    protected lstIntermediarySpecialContactTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialContactTypeColumn => this.columnSpecialContactType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow this[int index]
    {
      get => (dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler lstIntermediarySpecialContactTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler lstIntermediarySpecialContactTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler lstIntermediarySpecialContactTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler lstIntermediarySpecialContactTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstIntermediarySpecialContactTypesRow(
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow AddlstIntermediarySpecialContactTypesRow(
      string SpecialContactType,
      bool Hidden)
    {
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow row = (dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow FindBySpecialContactTypeID(
      int SpecialContactTypeID)
    {
      return (dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) this.Rows.Find(new object[1]
      {
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable contactTypesDataTable = (dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable) base.Clone();
      contactTypesDataTable.InitVars();
      return (DataTable) contactTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
      this.columnSpecialContactType = this.Columns["SpecialContactType"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.columnSpecialContactType = new DataColumn("SpecialContactType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactType);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediaryContactsKey5", new DataColumn[1]
      {
        this.columnSpecialContactTypeID
      }, true));
      this.columnSpecialContactTypeID.AutoIncrement = true;
      this.columnSpecialContactTypeID.AllowDBNull = false;
      this.columnSpecialContactTypeID.ReadOnly = true;
      this.columnSpecialContactTypeID.Unique = true;
      this.columnSpecialContactType.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow NewlstIntermediarySpecialContactTypesRow()
    {
      return (dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIntermediarySpecialContactTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler typesRowChangedEvent = this.lstIntermediarySpecialContactTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEvent((dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIntermediarySpecialContactTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler rowChangingEvent = this.lstIntermediarySpecialContactTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEvent((dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIntermediarySpecialContactTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler typesRowDeletedEvent = this.lstIntermediarySpecialContactTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEvent((dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstIntermediarySpecialContactTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEventHandler rowDeletingEvent = this.lstIntermediarySpecialContactTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaryContacts.lstIntermediarySpecialContactTypesRowChangeEvent((dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstIntermediarySpecialContactTypesRow(
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
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
        FixedValue = intermediaryContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstIntermediarySpecialContactTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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
  public class tblIntermediariesDataTable : 
    TypedTableBase<dsIntermediaryContacts.tblIntermediariesRow>
  {
    private DataColumn columnIntermediaryID;
    private DataColumn columnIntermediaryName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblIntermediariesDataTable()
    {
      this.TableName = "tblIntermediaries";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblIntermediariesDataTable(DataTable table)
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
    protected tblIntermediariesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntermediaryIDColumn => this.columnIntermediaryID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IntermediaryNameColumn => this.columnIntermediaryName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediariesRow this[int index]
    {
      get => (dsIntermediaryContacts.tblIntermediariesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler tblIntermediariesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler tblIntermediariesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler tblIntermediariesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler tblIntermediariesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblIntermediariesRow(dsIntermediaryContacts.tblIntermediariesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediariesRow AddtblIntermediariesRow(
      string IntermediaryName)
    {
      dsIntermediaryContacts.tblIntermediariesRow row = (dsIntermediaryContacts.tblIntermediariesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) IntermediaryName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediariesRow FindByIntermediaryID(int IntermediaryID)
    {
      return (dsIntermediaryContacts.tblIntermediariesRow) this.Rows.Find(new object[1]
      {
        (object) IntermediaryID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaryContacts.tblIntermediariesDataTable intermediariesDataTable = (dsIntermediaryContacts.tblIntermediariesDataTable) base.Clone();
      intermediariesDataTable.InitVars();
      return (DataTable) intermediariesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaryContacts.tblIntermediariesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryID = this.Columns["IntermediaryID"];
      this.columnIntermediaryName = this.Columns["IntermediaryName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryID = new DataColumn("IntermediaryID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryID);
      this.columnIntermediaryName = new DataColumn("IntermediaryName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediaryContactsKey6", new DataColumn[1]
      {
        this.columnIntermediaryID
      }, true));
      this.columnIntermediaryID.AutoIncrement = true;
      this.columnIntermediaryID.AllowDBNull = false;
      this.columnIntermediaryID.ReadOnly = true;
      this.columnIntermediaryID.Unique = true;
      this.columnIntermediaryName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediariesRow NewtblIntermediariesRow()
    {
      return (dsIntermediaryContacts.tblIntermediariesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaryContacts.tblIntermediariesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsIntermediaryContacts.tblIntermediariesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler intermediariesRowChangedEvent = this.tblIntermediariesRowChangedEvent;
      if (intermediariesRowChangedEvent == null)
        return;
      intermediariesRowChangedEvent((object) this, new dsIntermediaryContacts.tblIntermediariesRowChangeEvent((dsIntermediaryContacts.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler rowChangingEvent = this.tblIntermediariesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaryContacts.tblIntermediariesRowChangeEvent((dsIntermediaryContacts.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler intermediariesRowDeletedEvent = this.tblIntermediariesRowDeletedEvent;
      if (intermediariesRowDeletedEvent == null)
        return;
      intermediariesRowDeletedEvent((object) this, new dsIntermediaryContacts.tblIntermediariesRowChangeEvent((dsIntermediaryContacts.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaryContacts.tblIntermediariesRowChangeEventHandler rowDeletingEvent = this.tblIntermediariesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaryContacts.tblIntermediariesRowChangeEvent((dsIntermediaryContacts.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblIntermediariesRow(dsIntermediaryContacts.tblIntermediariesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaryContacts intermediaryContacts = new dsIntermediaryContacts();
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
        FixedValue = intermediaryContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediariesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = intermediaryContacts.GetSchemaSerializable();
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

  public class tblIntermediaryContactsRow : DataRow
  {
    private dsIntermediaryContacts.tblIntermediaryContactsDataTable tabletblIntermediaryContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblIntermediaryContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediaryContacts = (dsIntermediaryContacts.tblIntermediaryContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid IntermediaryContactGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int IntermediaryID
    {
      get => Conversions.ToInteger(this[this.tabletblIntermediaryContacts.IntermediaryIDColumn]);
      set => this[this.tabletblIntermediaryContacts.IntermediaryIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Salutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.SalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Salutation' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.FNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FName' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.FNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.LNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LName' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.LNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Title
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.TitleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Title' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Extension
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.ExtensionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Extension' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.ExtensionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Cell
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.CellColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Cell' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.CellColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblIntermediaryContacts.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblIntermediaryContacts.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte[] ContactSignature
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblIntermediaryContacts.ContactSignatureColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactSignature' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.ContactSignatureColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediariesRow tblIntermediariesRow
    {
      get
      {
        return (dsIntermediaryContacts.tblIntermediariesRow) this.GetParentRow(this.Table.ParentRelations["tblIntermediariestblIntermediaryContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblIntermediariestblIntermediaryContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsIntermediaryContacts.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblIntermediaryContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblIntermediaryContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsIntermediaryContacts.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblIntermediaryContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblIntermediaryContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSalutationNull()
    {
      return this.IsNull(this.tabletblIntermediaryContacts.SalutationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSalutationNull()
    {
      this[this.tabletblIntermediaryContacts.SalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFNameNull() => this.IsNull(this.tabletblIntermediaryContacts.FNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFNameNull()
    {
      this[this.tabletblIntermediaryContacts.FNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLNameNull() => this.IsNull(this.tabletblIntermediaryContacts.LNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLNameNull()
    {
      this[this.tabletblIntermediaryContacts.LNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTitleNull() => this.IsNull(this.tabletblIntermediaryContacts.TitleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTitleNull()
    {
      this[this.tabletblIntermediaryContacts.TitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblIntermediaryContacts.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblIntermediaryContacts.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExtensionNull() => this.IsNull(this.tabletblIntermediaryContacts.ExtensionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExtensionNull()
    {
      this[this.tabletblIntermediaryContacts.ExtensionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCellNull() => this.IsNull(this.tabletblIntermediaryContacts.CellColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCellNull()
    {
      this[this.tabletblIntermediaryContacts.CellColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblIntermediaryContacts.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblIntermediaryContacts.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblIntermediaryContacts.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblIntermediaryContacts.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblIntermediaryContacts.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblIntermediaryContacts.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblIntermediaryContacts.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblIntermediaryContacts.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblIntermediaryContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblIntermediaryContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactSignatureNull()
    {
      return this.IsNull(this.tabletblIntermediaryContacts.ContactSignatureColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactSignatureNull()
    {
      this[this.tabletblIntermediaryContacts.ContactSignatureColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow[] GettblIntermediarySpecialContactsRows()
    {
      return this.Table.ChildRelations["tblIntermediaryContactstblIntermediarySpecialContacts"] != null ? (dsIntermediaryContacts.tblIntermediarySpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblIntermediaryContactstblIntermediarySpecialContacts"]) : new dsIntermediaryContacts.tblIntermediarySpecialContactsRow[0];
    }
  }

  public class tblIntermediarySpecialContactsRow : DataRow
  {
    private dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable tabletblIntermediarySpecialContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblIntermediarySpecialContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediarySpecialContacts = (dsIntermediaryContacts.tblIntermediarySpecialContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid IntermediaryContactGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediarySpecialContacts.IntermediaryContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set
      {
        this[this.tabletblIntermediarySpecialContacts.IntermediaryContactGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblIntermediarySpecialContacts.SpecialContactTypeIDColumn]);
      }
      set
      {
        this[this.tabletblIntermediarySpecialContacts.SpecialContactTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow lstIntermediarySpecialContactTypesRow
    {
      get
      {
        return (dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) this.GetParentRow(this.Table.ParentRelations["lstCompanySpecialContactTypestblIntermediarySpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstCompanySpecialContactTypestblIntermediarySpecialContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow tblIntermediaryContactsRow
    {
      get
      {
        return (dsIntermediaryContacts.tblIntermediaryContactsRow) this.GetParentRow(this.Table.ParentRelations["tblIntermediaryContactstblIntermediarySpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblIntermediaryContactstblIntermediarySpecialContacts"]);
      }
    }
  }

  public class lstDeliveryMethodRow : DataRow
  {
    private dsIntermediaryContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsIntermediaryContacts.lstDeliveryMethodDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int DeliveryMethodID
    {
      get => Conversions.ToInteger(this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn]);
      set => this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstDeliveryMethod.DescriptionColumn]);
      set => this[this.tablelstDeliveryMethod.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow[] GettblIntermediaryContactsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblIntermediaryContacts"] != null ? (dsIntermediaryContacts.tblIntermediaryContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblIntermediaryContacts"]) : new dsIntermediaryContacts.tblIntermediaryContactsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsIntermediaryContacts.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsIntermediaryContacts.lstStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tablelstStatus.StatusIDColumn]);
      set => this[this.tablelstStatus.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StatusCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstStatus.StatusCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusCode' in table 'lstStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStatus.StatusCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Disable
    {
      get => Conversions.ToBoolean(this[this.tablelstStatus.DisableColumn]);
      set => this[this.tablelstStatus.DisableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusCodeNull() => this.IsNull(this.tablelstStatus.StatusCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusCodeNull()
    {
      this[this.tablelstStatus.StatusCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow[] GettblIntermediaryContactsRows()
    {
      return this.Table.ChildRelations["lstStatustblIntermediaryContacts"] != null ? (dsIntermediaryContacts.tblIntermediaryContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblIntermediaryContacts"]) : new dsIntermediaryContacts.tblIntermediaryContactsRow[0];
    }
  }

  public class lstIntermediarySpecialContactTypesRow : DataRow
  {
    private dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable tablelstIntermediarySpecialContactTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstIntermediarySpecialContactTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstIntermediarySpecialContactTypes = (dsIntermediaryContacts.lstIntermediarySpecialContactTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstIntermediarySpecialContactTypes.SpecialContactTypeIDColumn]);
      }
      set
      {
        this[this.tablelstIntermediarySpecialContactTypes.SpecialContactTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SpecialContactType
    {
      get
      {
        return Conversions.ToString(this[this.tablelstIntermediarySpecialContactTypes.SpecialContactTypeColumn]);
      }
      set
      {
        this[this.tablelstIntermediarySpecialContactTypes.SpecialContactTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tablelstIntermediarySpecialContactTypes.HiddenColumn]);
      set => this[this.tablelstIntermediarySpecialContactTypes.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow[] GettblIntermediarySpecialContactsRows()
    {
      return this.Table.ChildRelations["lstCompanySpecialContactTypestblIntermediarySpecialContacts"] != null ? (dsIntermediaryContacts.tblIntermediarySpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstCompanySpecialContactTypestblIntermediarySpecialContacts"]) : new dsIntermediaryContacts.tblIntermediarySpecialContactsRow[0];
    }
  }

  public class tblIntermediariesRow : DataRow
  {
    private dsIntermediaryContacts.tblIntermediariesDataTable tabletblIntermediaries;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblIntermediariesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediaries = (dsIntermediaryContacts.tblIntermediariesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int IntermediaryID
    {
      get => Conversions.ToInteger(this[this.tabletblIntermediaries.IntermediaryIDColumn]);
      set => this[this.tabletblIntermediaries.IntermediaryIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string IntermediaryName
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.IntermediaryNameColumn]);
      set => this[this.tabletblIntermediaries.IntermediaryNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow[] GettblIntermediaryContactsRows()
    {
      return this.Table.ChildRelations["tblIntermediariestblIntermediaryContacts"] != null ? (dsIntermediaryContacts.tblIntermediaryContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblIntermediariestblIntermediaryContacts"]) : new dsIntermediaryContacts.tblIntermediaryContactsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblIntermediaryContactsRowChangeEvent : EventArgs
  {
    private dsIntermediaryContacts.tblIntermediaryContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblIntermediaryContactsRowChangeEvent(
      dsIntermediaryContacts.tblIntermediaryContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediaryContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblIntermediarySpecialContactsRowChangeEvent : EventArgs
  {
    private dsIntermediaryContacts.tblIntermediarySpecialContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblIntermediarySpecialContactsRowChangeEvent(
      dsIntermediaryContacts.tblIntermediarySpecialContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediarySpecialContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsIntermediaryContacts.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(
      dsIntermediaryContacts.lstDeliveryMethodRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsIntermediaryContacts.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatusRowChangeEvent(dsIntermediaryContacts.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstIntermediarySpecialContactTypesRowChangeEvent : EventArgs
  {
    private dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstIntermediarySpecialContactTypesRowChangeEvent(
      dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblIntermediariesRowChangeEvent : EventArgs
  {
    private dsIntermediaryContacts.tblIntermediariesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblIntermediariesRowChangeEvent(
      dsIntermediaryContacts.tblIntermediariesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsIntermediaryContacts.tblIntermediariesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
