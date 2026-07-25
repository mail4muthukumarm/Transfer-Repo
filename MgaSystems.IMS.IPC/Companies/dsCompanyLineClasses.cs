// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyLineClasses
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyLineClasses")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLineClasses : DataSet
{
  private dsCompanyLineClasses.lstClassCodesDataTable tablelstClassCodes;
  private dsCompanyLineClasses.tblCompanyClassCodesDataTable tabletblCompanyClassCodes;
  private dsCompanyLineClasses.lstGLExposureUnitDataTable tablelstGLExposureUnit;
  private dsCompanyLineClasses.AccessDataTable tableAccess;
  private dsCompanyLineClasses.lstStatesDataTable tablelstStates;
  private dsCompanyLineClasses.dtCodesDataTable tabledtCodes;
  private DataRelation relationlstClassCodestblCompanyClassCodes;
  private DataRelation relationAccesstblCompanyClassCodes;
  private DataRelation relationlstGLExposureUnittblCompanyClassCodes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyLineClasses()
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
  protected dsCompanyLineClasses(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstClassCodes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineClasses.lstClassCodesDataTable(dataSet.Tables[nameof (lstClassCodes)]));
        if (dataSet.Tables[nameof (tblCompanyClassCodes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineClasses.tblCompanyClassCodesDataTable(dataSet.Tables[nameof (tblCompanyClassCodes)]));
        if (dataSet.Tables[nameof (lstGLExposureUnit)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineClasses.lstGLExposureUnitDataTable(dataSet.Tables[nameof (lstGLExposureUnit)]));
        if (dataSet.Tables[nameof (Access)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineClasses.AccessDataTable(dataSet.Tables[nameof (Access)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineClasses.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (dtCodes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineClasses.dtCodesDataTable(dataSet.Tables[nameof (dtCodes)]));
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
  public dsCompanyLineClasses.lstClassCodesDataTable lstClassCodes => this.tablelstClassCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineClasses.tblCompanyClassCodesDataTable tblCompanyClassCodes
  {
    get => this.tabletblCompanyClassCodes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineClasses.lstGLExposureUnitDataTable lstGLExposureUnit
  {
    get => this.tablelstGLExposureUnit;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineClasses.AccessDataTable Access => this.tableAccess;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineClasses.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineClasses.dtCodesDataTable dtCodes => this.tabledtCodes;

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
    dsCompanyLineClasses companyLineClasses = (dsCompanyLineClasses) base.Clone();
    companyLineClasses.InitVars();
    companyLineClasses.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyLineClasses;
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
      if (dataSet.Tables["lstClassCodes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineClasses.lstClassCodesDataTable(dataSet.Tables["lstClassCodes"]));
      if (dataSet.Tables["tblCompanyClassCodes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineClasses.tblCompanyClassCodesDataTable(dataSet.Tables["tblCompanyClassCodes"]));
      if (dataSet.Tables["lstGLExposureUnit"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineClasses.lstGLExposureUnitDataTable(dataSet.Tables["lstGLExposureUnit"]));
      if (dataSet.Tables["Access"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineClasses.AccessDataTable(dataSet.Tables["Access"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineClasses.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["dtCodes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineClasses.dtCodesDataTable(dataSet.Tables["dtCodes"]));
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
    this.tablelstClassCodes = (dsCompanyLineClasses.lstClassCodesDataTable) base.Tables["lstClassCodes"];
    if (initTable && this.tablelstClassCodes != null)
      this.tablelstClassCodes.InitVars();
    this.tabletblCompanyClassCodes = (dsCompanyLineClasses.tblCompanyClassCodesDataTable) base.Tables["tblCompanyClassCodes"];
    if (initTable && this.tabletblCompanyClassCodes != null)
      this.tabletblCompanyClassCodes.InitVars();
    this.tablelstGLExposureUnit = (dsCompanyLineClasses.lstGLExposureUnitDataTable) base.Tables["lstGLExposureUnit"];
    if (initTable && this.tablelstGLExposureUnit != null)
      this.tablelstGLExposureUnit.InitVars();
    this.tableAccess = (dsCompanyLineClasses.AccessDataTable) base.Tables["Access"];
    if (initTable && this.tableAccess != null)
      this.tableAccess.InitVars();
    this.tablelstStates = (dsCompanyLineClasses.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tabledtCodes = (dsCompanyLineClasses.dtCodesDataTable) base.Tables["dtCodes"];
    if (initTable && this.tabledtCodes != null)
      this.tabledtCodes.InitVars();
    this.relationlstClassCodestblCompanyClassCodes = this.Relations["lstClassCodestblCompanyClassCodes"];
    this.relationAccesstblCompanyClassCodes = this.Relations["AccesstblCompanyClassCodes"];
    this.relationlstGLExposureUnittblCompanyClassCodes = this.Relations["lstGLExposureUnittblCompanyClassCodes"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLineClasses);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyLineClasses.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstClassCodes = new dsCompanyLineClasses.lstClassCodesDataTable();
    base.Tables.Add((DataTable) this.tablelstClassCodes);
    this.tabletblCompanyClassCodes = new dsCompanyLineClasses.tblCompanyClassCodesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyClassCodes);
    this.tablelstGLExposureUnit = new dsCompanyLineClasses.lstGLExposureUnitDataTable();
    base.Tables.Add((DataTable) this.tablelstGLExposureUnit);
    this.tableAccess = new dsCompanyLineClasses.AccessDataTable();
    base.Tables.Add((DataTable) this.tableAccess);
    this.tablelstStates = new dsCompanyLineClasses.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tabledtCodes = new dsCompanyLineClasses.dtCodesDataTable();
    base.Tables.Add((DataTable) this.tabledtCodes);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstClassCodestblCompanyClassCodes", new DataColumn[1]
    {
      this.tablelstClassCodes.ClassCodeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyClassCodes.ClassCodeIDColumn
    });
    this.tabletblCompanyClassCodes.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("AccesstblCompanyClassCodes", new DataColumn[1]
    {
      this.tableAccess.AccessColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyClassCodes.AccessColumn
    });
    this.tabletblCompanyClassCodes.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstGLExposureUnittblCompanyClassCodes", new DataColumn[1]
    {
      this.tablelstGLExposureUnit.ExposureUnitColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyClassCodes.DefaultGLExposureUnitColumn
    });
    this.tabletblCompanyClassCodes.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationlstClassCodestblCompanyClassCodes = new DataRelation("lstClassCodestblCompanyClassCodes", new DataColumn[1]
    {
      this.tablelstClassCodes.ClassCodeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyClassCodes.ClassCodeIDColumn
    }, false);
    this.Relations.Add(this.relationlstClassCodestblCompanyClassCodes);
    this.relationAccesstblCompanyClassCodes = new DataRelation("AccesstblCompanyClassCodes", new DataColumn[1]
    {
      this.tableAccess.AccessColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyClassCodes.AccessColumn
    }, false);
    this.Relations.Add(this.relationAccesstblCompanyClassCodes);
    this.relationlstGLExposureUnittblCompanyClassCodes = new DataRelation("lstGLExposureUnittblCompanyClassCodes", new DataColumn[1]
    {
      this.tablelstGLExposureUnit.ExposureUnitColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyClassCodes.DefaultGLExposureUnitColumn
    }, false);
    this.Relations.Add(this.relationlstGLExposureUnittblCompanyClassCodes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstClassCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyClassCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstGLExposureUnit() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAccess() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtCodes() => false;

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
    dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyLineClasses.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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
  public delegate void lstClassCodesRowChangeEventHandler(
    object sender,
    dsCompanyLineClasses.lstClassCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyClassCodesRowChangeEventHandler(
    object sender,
    dsCompanyLineClasses.tblCompanyClassCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstGLExposureUnitRowChangeEventHandler(
    object sender,
    dsCompanyLineClasses.lstGLExposureUnitRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void AccessRowChangeEventHandler(
    object sender,
    dsCompanyLineClasses.AccessRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsCompanyLineClasses.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtCodesRowChangeEventHandler(
    object sender,
    dsCompanyLineClasses.dtCodesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstClassCodesDataTable : TypedTableBase<dsCompanyLineClasses.lstClassCodesRow>
  {
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCode;
    private DataColumn columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstClassCodesDataTable()
    {
      this.TableName = "lstClassCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstClassCodesDataTable(DataTable table)
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
    protected lstClassCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstClassCodesRow this[int index]
    {
      get => (dsCompanyLineClasses.lstClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstClassCodesRow(dsCompanyLineClasses.lstClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstClassCodesRow AddlstClassCodesRow(
      int ClassCodeID,
      string ClassCode,
      string ClassCodeDescription)
    {
      dsCompanyLineClasses.lstClassCodesRow row = (dsCompanyLineClasses.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ClassCodeID,
        (object) ClassCode,
        (object) ClassCodeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstClassCodesRow FindByClassCodeID(int ClassCodeID)
    {
      return (dsCompanyLineClasses.lstClassCodesRow) this.Rows.Find(new object[1]
      {
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineClasses.lstClassCodesDataTable classCodesDataTable = (dsCompanyLineClasses.lstClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineClasses.lstClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyLineClassesKey4", new DataColumn[1]
      {
        this.columnClassCodeID
      }, true));
      this.columnClassCodeID.AllowDBNull = false;
      this.columnClassCodeID.ReadOnly = true;
      this.columnClassCodeID.Unique = true;
      this.columnClassCode.AllowDBNull = false;
      this.columnClassCode.ReadOnly = true;
      this.columnClassCodeDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstClassCodesRow NewlstClassCodesRow()
    {
      return (dsCompanyLineClasses.lstClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineClasses.lstClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineClasses.lstClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstClassCodesRowChangeEventHandler codesRowChangedEvent = this.lstClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsCompanyLineClasses.lstClassCodesRowChangeEvent((dsCompanyLineClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstClassCodesRowChangeEventHandler rowChangingEvent = this.lstClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineClasses.lstClassCodesRowChangeEvent((dsCompanyLineClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstClassCodesRowChangeEventHandler codesRowDeletedEvent = this.lstClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsCompanyLineClasses.lstClassCodesRowChangeEvent((dsCompanyLineClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstClassCodesRowChangeEventHandler rowDeletingEvent = this.lstClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineClasses.lstClassCodesRowChangeEvent((dsCompanyLineClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstClassCodesRow(dsCompanyLineClasses.lstClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
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
        FixedValue = companyLineClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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
  public class tblCompanyClassCodesDataTable : 
    TypedTableBase<dsCompanyLineClasses.tblCompanyClassCodesRow>
  {
    private DataColumn columnCompanyLineID;
    private DataColumn columnClassCodeID;
    private DataColumn columnDefaultGLExposureUnit;
    private DataColumn columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyClassCodesDataTable()
    {
      this.TableName = "tblCompanyClassCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyClassCodesDataTable(DataTable table)
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
    protected tblCompanyClassCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultGLExposureUnitColumn => this.columnDefaultGLExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessColumn => this.columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow this[int index]
    {
      get => (dsCompanyLineClasses.tblCompanyClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler tblCompanyClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler tblCompanyClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler tblCompanyClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler tblCompanyClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyClassCodesRow(dsCompanyLineClasses.tblCompanyClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow AddtblCompanyClassCodesRow(
      int CompanyLineID,
      dsCompanyLineClasses.lstClassCodesRow parentlstClassCodesRowBylstClassCodestblCompanyClassCodes,
      dsCompanyLineClasses.lstGLExposureUnitRow parentlstGLExposureUnitRowBylstGLExposureUnittblCompanyClassCodes,
      dsCompanyLineClasses.AccessRow parentAccessRowByAccesstblCompanyClassCodes)
    {
      dsCompanyLineClasses.tblCompanyClassCodesRow row = (dsCompanyLineClasses.tblCompanyClassCodesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CompanyLineID,
        null,
        null,
        null
      };
      if (parentlstClassCodesRowBylstClassCodestblCompanyClassCodes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstClassCodesRowBylstClassCodestblCompanyClassCodes[0]);
      if (parentlstGLExposureUnitRowBylstGLExposureUnittblCompanyClassCodes != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstGLExposureUnitRowBylstGLExposureUnittblCompanyClassCodes[0]);
      if (parentAccessRowByAccesstblCompanyClassCodes != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentAccessRowByAccesstblCompanyClassCodes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow FindByCompanyLineIDClassCodeID(
      int CompanyLineID,
      int ClassCodeID)
    {
      return (dsCompanyLineClasses.tblCompanyClassCodesRow) this.Rows.Find(new object[2]
      {
        (object) CompanyLineID,
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineClasses.tblCompanyClassCodesDataTable classCodesDataTable = (dsCompanyLineClasses.tblCompanyClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineClasses.tblCompanyClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnDefaultGLExposureUnit = this.Columns["DefaultGLExposureUnit"];
      this.columnAccess = this.Columns["Access"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnDefaultGLExposureUnit = new DataColumn("DefaultGLExposureUnit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultGLExposureUnit);
      this.columnAccess = new DataColumn("Access", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccess);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyLineClassesKey1", new DataColumn[2]
      {
        this.columnCompanyLineID,
        this.columnClassCodeID
      }, true));
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnClassCodeID.AllowDBNull = false;
      this.columnAccess.AllowDBNull = false;
      this.columnAccess.DefaultValue = (object) "A";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow NewtblCompanyClassCodesRow()
    {
      return (dsCompanyLineClasses.tblCompanyClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineClasses.tblCompanyClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineClasses.tblCompanyClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler codesRowChangedEvent = this.tblCompanyClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsCompanyLineClasses.tblCompanyClassCodesRowChangeEvent((dsCompanyLineClasses.tblCompanyClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyClassCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler rowChangingEvent = this.tblCompanyClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineClasses.tblCompanyClassCodesRowChangeEvent((dsCompanyLineClasses.tblCompanyClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyClassCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler codesRowDeletedEvent = this.tblCompanyClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsCompanyLineClasses.tblCompanyClassCodesRowChangeEvent((dsCompanyLineClasses.tblCompanyClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyClassCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.tblCompanyClassCodesRowChangeEventHandler rowDeletingEvent = this.tblCompanyClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineClasses.tblCompanyClassCodesRowChangeEvent((dsCompanyLineClasses.tblCompanyClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyClassCodesRow(dsCompanyLineClasses.tblCompanyClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
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
        FixedValue = companyLineClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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
  public class lstGLExposureUnitDataTable : TypedTableBase<dsCompanyLineClasses.lstGLExposureUnitRow>
  {
    private DataColumn columnExposureUnit;
    private DataColumn columnExposureDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstGLExposureUnitDataTable()
    {
      this.TableName = "lstGLExposureUnit";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstGLExposureUnitDataTable(DataTable table)
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
    protected lstGLExposureUnitDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureUnitColumn => this.columnExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureDescriptionColumn => this.columnExposureDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstGLExposureUnitRow this[int index]
    {
      get => (dsCompanyLineClasses.lstGLExposureUnitRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstGLExposureUnitRow(dsCompanyLineClasses.lstGLExposureUnitRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstGLExposureUnitRow AddlstGLExposureUnitRow(
      string ExposureUnit,
      string ExposureDescription)
    {
      dsCompanyLineClasses.lstGLExposureUnitRow row = (dsCompanyLineClasses.lstGLExposureUnitRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ExposureUnit,
        (object) ExposureDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstGLExposureUnitRow FindByExposureUnit(string ExposureUnit)
    {
      return (dsCompanyLineClasses.lstGLExposureUnitRow) this.Rows.Find(new object[1]
      {
        (object) ExposureUnit
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineClasses.lstGLExposureUnitDataTable exposureUnitDataTable = (dsCompanyLineClasses.lstGLExposureUnitDataTable) base.Clone();
      exposureUnitDataTable.InitVars();
      return (DataTable) exposureUnitDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineClasses.lstGLExposureUnitDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnExposureUnit = this.Columns["ExposureUnit"];
      this.columnExposureDescription = this.Columns["ExposureDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnExposureUnit = new DataColumn("ExposureUnit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureUnit);
      this.columnExposureDescription = new DataColumn("ExposureDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyLineClassesKey2", new DataColumn[1]
      {
        this.columnExposureUnit
      }, true));
      this.columnExposureUnit.AllowDBNull = false;
      this.columnExposureUnit.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstGLExposureUnitRow NewlstGLExposureUnitRow()
    {
      return (dsCompanyLineClasses.lstGLExposureUnitRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineClasses.lstGLExposureUnitRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineClasses.lstGLExposureUnitRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLExposureUnitRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler unitRowChangedEvent = this.lstGLExposureUnitRowChangedEvent;
      if (unitRowChangedEvent == null)
        return;
      unitRowChangedEvent((object) this, new dsCompanyLineClasses.lstGLExposureUnitRowChangeEvent((dsCompanyLineClasses.lstGLExposureUnitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLExposureUnitRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler rowChangingEvent = this.lstGLExposureUnitRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineClasses.lstGLExposureUnitRowChangeEvent((dsCompanyLineClasses.lstGLExposureUnitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLExposureUnitRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler unitRowDeletedEvent = this.lstGLExposureUnitRowDeletedEvent;
      if (unitRowDeletedEvent == null)
        return;
      unitRowDeletedEvent((object) this, new dsCompanyLineClasses.lstGLExposureUnitRowChangeEvent((dsCompanyLineClasses.lstGLExposureUnitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLExposureUnitRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstGLExposureUnitRowChangeEventHandler rowDeletingEvent = this.lstGLExposureUnitRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineClasses.lstGLExposureUnitRowChangeEvent((dsCompanyLineClasses.lstGLExposureUnitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstGLExposureUnitRow(dsCompanyLineClasses.lstGLExposureUnitRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
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
        FixedValue = companyLineClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstGLExposureUnitDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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
  public class AccessDataTable : TypedTableBase<dsCompanyLineClasses.AccessRow>
  {
    private DataColumn columnAccess;
    private DataColumn columnAccessDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccessDataTable()
    {
      this.TableName = "Access";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AccessDataTable(DataTable table)
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
    protected AccessDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessColumn => this.columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessDescriptionColumn => this.columnAccessDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.AccessRow this[int index]
    {
      get => (dsCompanyLineClasses.AccessRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.AccessRowChangeEventHandler AccessRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.AccessRowChangeEventHandler AccessRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.AccessRowChangeEventHandler AccessRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.AccessRowChangeEventHandler AccessRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAccessRow(dsCompanyLineClasses.AccessRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.AccessRow AddAccessRow(string Access, string AccessDescription)
    {
      dsCompanyLineClasses.AccessRow row = (dsCompanyLineClasses.AccessRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Access,
        (object) AccessDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.AccessRow FindByAccess(string Access)
    {
      return (dsCompanyLineClasses.AccessRow) this.Rows.Find(new object[1]
      {
        (object) Access
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineClasses.AccessDataTable accessDataTable = (dsCompanyLineClasses.AccessDataTable) base.Clone();
      accessDataTable.InitVars();
      return (DataTable) accessDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineClasses.AccessDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnAccess = this.Columns["Access"];
      this.columnAccessDescription = this.Columns["AccessDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnAccess = new DataColumn("Access", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccess);
      this.columnAccessDescription = new DataColumn("AccessDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccessDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyLineClassesKey3", new DataColumn[1]
      {
        this.columnAccess
      }, true));
      this.columnAccess.AllowDBNull = false;
      this.columnAccess.Unique = true;
      this.columnAccessDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.AccessRow NewAccessRow()
    {
      return (dsCompanyLineClasses.AccessRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineClasses.AccessRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineClasses.AccessRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccessRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.AccessRowChangeEventHandler accessRowChangedEvent = this.AccessRowChangedEvent;
      if (accessRowChangedEvent == null)
        return;
      accessRowChangedEvent((object) this, new dsCompanyLineClasses.AccessRowChangeEvent((dsCompanyLineClasses.AccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccessRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.AccessRowChangeEventHandler rowChangingEvent = this.AccessRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineClasses.AccessRowChangeEvent((dsCompanyLineClasses.AccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccessRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.AccessRowChangeEventHandler accessRowDeletedEvent = this.AccessRowDeletedEvent;
      if (accessRowDeletedEvent == null)
        return;
      accessRowDeletedEvent((object) this, new dsCompanyLineClasses.AccessRowChangeEvent((dsCompanyLineClasses.AccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccessRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.AccessRowChangeEventHandler rowDeletingEvent = this.AccessRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineClasses.AccessRowChangeEvent((dsCompanyLineClasses.AccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAccessRow(dsCompanyLineClasses.AccessRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
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
        FixedValue = companyLineClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AccessDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsCompanyLineClasses.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;
    private DataColumn columnCompanyLineID;
    private DataColumn columnParent;
    private DataColumn columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.lstStatesDataTable_ColumnChanging);
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.lstStatesDataTable_ColumnChanging);
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
      this.ColumnChanging += new DataColumnChangeEventHandler(this.lstStatesDataTable_ColumnChanging);
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
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParentColumn => this.columnParent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SelectColumn => this.columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstStatesRow this[int index]
    {
      get => (dsCompanyLineClasses.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatesRow(dsCompanyLineClasses.lstStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstStatesRow AddlstStatesRow(
      string StateID,
      string State,
      int CompanyLineID,
      bool Parent,
      bool _Select)
    {
      dsCompanyLineClasses.lstStatesRow row = (dsCompanyLineClasses.lstStatesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) StateID,
        (object) State,
        (object) CompanyLineID,
        (object) Parent,
        (object) _Select
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstStatesRow FindByCompanyLineID(int CompanyLineID)
    {
      return (dsCompanyLineClasses.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLineID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineClasses.lstStatesDataTable lstStatesDataTable = (dsCompanyLineClasses.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineClasses.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnParent = this.Columns["Parent"];
      this.columnSelect = this.Columns["Select"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnParent = new DataColumn("Parent", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParent);
      this.columnSelect = new DataColumn("Select", typeof (bool), (string) null, MappingType.Element);
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "SelectColumn");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnSelect");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Select");
      this.Columns.Add(this.columnSelect);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLineID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnCompanyLineID.Unique = true;
      this.columnSelect.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstStatesRow NewlstStatesRow()
    {
      return (dsCompanyLineClasses.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineClasses.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineClasses.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsCompanyLineClasses.lstStatesRowChangeEvent((dsCompanyLineClasses.lstStatesRow) e.Row, e.Action));
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
      dsCompanyLineClasses.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineClasses.lstStatesRowChangeEvent((dsCompanyLineClasses.lstStatesRow) e.Row, e.Action));
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
      dsCompanyLineClasses.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsCompanyLineClasses.lstStatesRowChangeEvent((dsCompanyLineClasses.lstStatesRow) e.Row, e.Action));
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
      dsCompanyLineClasses.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineClasses.lstStatesRowChangeEvent((dsCompanyLineClasses.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatesRow(dsCompanyLineClasses.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
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
        FixedValue = companyLineClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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

    private void lstStatesDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
    {
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtCodesDataTable : TypedTableBase<dsCompanyLineClasses.dtCodesRow>
  {
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCode;
    private DataColumn columnClassCodeDescription;
    private DataColumn columnDefaultGLExposureUnit;
    private DataColumn columnAccess;
    private DataColumn columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtCodesDataTable()
    {
      this.TableName = "dtCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtCodesDataTable(DataTable table)
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
    protected dtCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultGLExposureUnitColumn => this.columnDefaultGLExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessColumn => this.columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SelectColumn => this.columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.dtCodesRow this[int index]
    {
      get => (dsCompanyLineClasses.dtCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.dtCodesRowChangeEventHandler dtCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.dtCodesRowChangeEventHandler dtCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.dtCodesRowChangeEventHandler dtCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineClasses.dtCodesRowChangeEventHandler dtCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtCodesRow(dsCompanyLineClasses.dtCodesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.dtCodesRow AdddtCodesRow(
      int ClassCodeID,
      string ClassCode,
      string ClassCodeDescription,
      string DefaultGLExposureUnit,
      string Access,
      bool _Select)
    {
      dsCompanyLineClasses.dtCodesRow row = (dsCompanyLineClasses.dtCodesRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) ClassCodeID,
        (object) ClassCode,
        (object) ClassCodeDescription,
        (object) DefaultGLExposureUnit,
        (object) Access,
        (object) _Select
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.dtCodesRow FindByClassCodeID(int ClassCodeID)
    {
      return (dsCompanyLineClasses.dtCodesRow) this.Rows.Find(new object[1]
      {
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineClasses.dtCodesDataTable dtCodesDataTable = (dsCompanyLineClasses.dtCodesDataTable) base.Clone();
      dtCodesDataTable.InitVars();
      return (DataTable) dtCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineClasses.dtCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
      this.columnDefaultGLExposureUnit = this.Columns["DefaultGLExposureUnit"];
      this.columnAccess = this.Columns["Access"];
      this.columnSelect = this.Columns["Select"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.columnDefaultGLExposureUnit = new DataColumn("DefaultGLExposureUnit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultGLExposureUnit);
      this.columnAccess = new DataColumn("Access", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccess);
      this.columnSelect = new DataColumn("Select", typeof (bool), (string) null, MappingType.Element);
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "SelectColumn");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnSelect");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Select");
      this.Columns.Add(this.columnSelect);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClassCodeID
      }, true));
      this.columnClassCodeID.AllowDBNull = false;
      this.columnClassCodeID.Unique = true;
      this.columnSelect.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.dtCodesRow NewdtCodesRow()
    {
      return (dsCompanyLineClasses.dtCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineClasses.dtCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineClasses.dtCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.dtCodesRowChangeEventHandler codesRowChangedEvent = this.dtCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsCompanyLineClasses.dtCodesRowChangeEvent((dsCompanyLineClasses.dtCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.dtCodesRowChangeEventHandler rowChangingEvent = this.dtCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineClasses.dtCodesRowChangeEvent((dsCompanyLineClasses.dtCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.dtCodesRowChangeEventHandler codesRowDeletedEvent = this.dtCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsCompanyLineClasses.dtCodesRowChangeEvent((dsCompanyLineClasses.dtCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineClasses.dtCodesRowChangeEventHandler rowDeletingEvent = this.dtCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineClasses.dtCodesRowChangeEvent((dsCompanyLineClasses.dtCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtCodesRow(dsCompanyLineClasses.dtCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineClasses companyLineClasses = new dsCompanyLineClasses();
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
        FixedValue = companyLineClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineClasses.GetSchemaSerializable();
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

  public class lstClassCodesRow : DataRow
  {
    private dsCompanyLineClasses.lstClassCodesDataTable tablelstClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClassCodes = (dsCompanyLineClasses.lstClassCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClassCodeID
    {
      get => Conversions.ToInteger(this[this.tablelstClassCodes.ClassCodeIDColumn]);
      set => this[this.tablelstClassCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCode
    {
      get => Conversions.ToString(this[this.tablelstClassCodes.ClassCodeColumn]);
      set => this[this.tablelstClassCodes.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCodeDescription
    {
      get => Conversions.ToString(this[this.tablelstClassCodes.ClassCodeDescriptionColumn]);
      set => this[this.tablelstClassCodes.ClassCodeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow[] GettblCompanyClassCodesRows()
    {
      return this.Table.ChildRelations["lstClassCodestblCompanyClassCodes"] != null ? (dsCompanyLineClasses.tblCompanyClassCodesRow[]) this.GetChildRows(this.Table.ChildRelations["lstClassCodestblCompanyClassCodes"]) : new dsCompanyLineClasses.tblCompanyClassCodesRow[0];
    }
  }

  public class tblCompanyClassCodesRow : DataRow
  {
    private dsCompanyLineClasses.tblCompanyClassCodesDataTable tabletblCompanyClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyClassCodes = (dsCompanyLineClasses.tblCompanyClassCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompanyLineID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyClassCodes.CompanyLineIDColumn]);
      set => this[this.tabletblCompanyClassCodes.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClassCodeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyClassCodes.ClassCodeIDColumn]);
      set => this[this.tabletblCompanyClassCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DefaultGLExposureUnit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyClassCodes.DefaultGLExposureUnitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultGLExposureUnit' in table 'tblCompanyClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyClassCodes.DefaultGLExposureUnitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Access
    {
      get => Conversions.ToString(this[this.tabletblCompanyClassCodes.AccessColumn]);
      set => this[this.tabletblCompanyClassCodes.AccessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstClassCodesRow lstClassCodesRow
    {
      get
      {
        return (dsCompanyLineClasses.lstClassCodesRow) this.GetParentRow(this.Table.ParentRelations["lstClassCodestblCompanyClassCodes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstClassCodestblCompanyClassCodes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.AccessRow AccessRow
    {
      get
      {
        return (dsCompanyLineClasses.AccessRow) this.GetParentRow(this.Table.ParentRelations["AccesstblCompanyClassCodes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["AccesstblCompanyClassCodes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstGLExposureUnitRow lstGLExposureUnitRow
    {
      get
      {
        return (dsCompanyLineClasses.lstGLExposureUnitRow) this.GetParentRow(this.Table.ParentRelations["lstGLExposureUnittblCompanyClassCodes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstGLExposureUnittblCompanyClassCodes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDefaultGLExposureUnitNull()
    {
      return this.IsNull(this.tabletblCompanyClassCodes.DefaultGLExposureUnitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDefaultGLExposureUnitNull()
    {
      this[this.tabletblCompanyClassCodes.DefaultGLExposureUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstGLExposureUnitRow : DataRow
  {
    private dsCompanyLineClasses.lstGLExposureUnitDataTable tablelstGLExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstGLExposureUnitRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstGLExposureUnit = (dsCompanyLineClasses.lstGLExposureUnitDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ExposureUnit
    {
      get => Conversions.ToString(this[this.tablelstGLExposureUnit.ExposureUnitColumn]);
      set => this[this.tablelstGLExposureUnit.ExposureUnitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ExposureDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstGLExposureUnit.ExposureDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExposureDescription' in table 'lstGLExposureUnit' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstGLExposureUnit.ExposureDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExposureDescriptionNull()
    {
      return this.IsNull(this.tablelstGLExposureUnit.ExposureDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExposureDescriptionNull()
    {
      this[this.tablelstGLExposureUnit.ExposureDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow[] GettblCompanyClassCodesRows()
    {
      return this.Table.ChildRelations["lstGLExposureUnittblCompanyClassCodes"] != null ? (dsCompanyLineClasses.tblCompanyClassCodesRow[]) this.GetChildRows(this.Table.ChildRelations["lstGLExposureUnittblCompanyClassCodes"]) : new dsCompanyLineClasses.tblCompanyClassCodesRow[0];
    }
  }

  public class AccessRow : DataRow
  {
    private dsCompanyLineClasses.AccessDataTable tableAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AccessRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccess = (dsCompanyLineClasses.AccessDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Access
    {
      get => Conversions.ToString(this[this.tableAccess.AccessColumn]);
      set => this[this.tableAccess.AccessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AccessDescription
    {
      get => Conversions.ToString(this[this.tableAccess.AccessDescriptionColumn]);
      set => this[this.tableAccess.AccessDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow[] GettblCompanyClassCodesRows()
    {
      return this.Table.ChildRelations["AccesstblCompanyClassCodes"] != null ? (dsCompanyLineClasses.tblCompanyClassCodesRow[]) this.GetChildRows(this.Table.ChildRelations["AccesstblCompanyClassCodes"]) : new dsCompanyLineClasses.tblCompanyClassCodesRow[0];
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsCompanyLineClasses.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsCompanyLineClasses.lstStatesDataTable) this.Table;
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
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstStates.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'lstStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompanyLineID
    {
      get => Conversions.ToInteger(this[this.tablelstStates.CompanyLineIDColumn]);
      set => this[this.tablelstStates.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Parent
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstStates.ParentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Parent' in table 'lstStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStates.ParentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool _Select
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstStates.SelectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Select' in table 'lstStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStates.SelectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tablelstStates.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tablelstStates.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsParentNull() => this.IsNull(this.tablelstStates.ParentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetParentNull()
    {
      this[this.tablelstStates.ParentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_SelectNull() => this.IsNull(this.tablelstStates.SelectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_SelectNull()
    {
      this[this.tablelstStates.SelectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtCodesRow : DataRow
  {
    private dsCompanyLineClasses.dtCodesDataTable tabledtCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtCodes = (dsCompanyLineClasses.dtCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClassCodeID
    {
      get => Conversions.ToInteger(this[this.tabledtCodes.ClassCodeIDColumn]);
      set => this[this.tabledtCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCodes.ClassCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCode' in table 'dtCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCodes.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCodeDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCodes.ClassCodeDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeDescription' in table 'dtCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCodes.ClassCodeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DefaultGLExposureUnit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCodes.DefaultGLExposureUnitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultGLExposureUnit' in table 'dtCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCodes.DefaultGLExposureUnitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Access
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCodes.AccessColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Access' in table 'dtCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCodes.AccessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool _Select
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtCodes.SelectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Select' in table 'dtCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCodes.SelectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeNull() => this.IsNull(this.tabledtCodes.ClassCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeNull()
    {
      this[this.tabledtCodes.ClassCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeDescriptionNull()
    {
      return this.IsNull(this.tabledtCodes.ClassCodeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeDescriptionNull()
    {
      this[this.tabledtCodes.ClassCodeDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDefaultGLExposureUnitNull()
    {
      return this.IsNull(this.tabledtCodes.DefaultGLExposureUnitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDefaultGLExposureUnitNull()
    {
      this[this.tabledtCodes.DefaultGLExposureUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAccessNull() => this.IsNull(this.tabledtCodes.AccessColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccessNull()
    {
      this[this.tabledtCodes.AccessColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_SelectNull() => this.IsNull(this.tabledtCodes.SelectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_SelectNull()
    {
      this[this.tabledtCodes.SelectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstClassCodesRowChangeEvent : EventArgs
  {
    private dsCompanyLineClasses.lstClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstClassCodesRowChangeEvent(
      dsCompanyLineClasses.lstClassCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyClassCodesRowChangeEvent : EventArgs
  {
    private dsCompanyLineClasses.tblCompanyClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyClassCodesRowChangeEvent(
      dsCompanyLineClasses.tblCompanyClassCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.tblCompanyClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstGLExposureUnitRowChangeEvent : EventArgs
  {
    private dsCompanyLineClasses.lstGLExposureUnitRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstGLExposureUnitRowChangeEvent(
      dsCompanyLineClasses.lstGLExposureUnitRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstGLExposureUnitRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AccessRowChangeEvent : EventArgs
  {
    private dsCompanyLineClasses.AccessRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccessRowChangeEvent(dsCompanyLineClasses.AccessRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.AccessRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsCompanyLineClasses.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesRowChangeEvent(dsCompanyLineClasses.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtCodesRowChangeEvent : EventArgs
  {
    private dsCompanyLineClasses.dtCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtCodesRowChangeEvent(dsCompanyLineClasses.dtCodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineClasses.dtCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
