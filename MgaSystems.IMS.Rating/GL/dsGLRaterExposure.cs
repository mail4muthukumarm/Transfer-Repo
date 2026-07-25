// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GL.dsGLRaterExposure
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
namespace MGASystems.IMS.Policies.Rating.GL;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGLRaterExposure")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGLRaterExposure : DataSet
{
  private dsGLRaterExposure.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsGLRaterExposure.lstClassCodesDataTable tablelstClassCodes;
  private dsGLRaterExposure.tblGLExposuresDataTable tabletblGLExposures;
  private dsGLRaterExposure.lstGLExposureUnitDataTable tablelstGLExposureUnit;
  private dsGLRaterExposure.tblClientOfficesDataTable tabletblClientOffices;
  private dsGLRaterExposure.lstEndorsementCalculationTypesDataTable tablelstEndorsementCalculationTypes;
  private DataRelation relationlstEndorsementCalculationTypestblGLExposures;
  private DataRelation relationtblClientOfficestblGLExposures;
  private DataRelation relationtblUnderwritingLocationstblGLExposures;
  private DataRelation relationlstGLExposureUnittblGLExposures;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGLRaterExposure()
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
  protected dsGLRaterExposure(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsGLRaterExposure.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (lstClassCodes)] != null)
          base.Tables.Add((DataTable) new dsGLRaterExposure.lstClassCodesDataTable(dataSet.Tables[nameof (lstClassCodes)]));
        if (dataSet.Tables[nameof (tblGLExposures)] != null)
          base.Tables.Add((DataTable) new dsGLRaterExposure.tblGLExposuresDataTable(dataSet.Tables[nameof (tblGLExposures)]));
        if (dataSet.Tables[nameof (lstGLExposureUnit)] != null)
          base.Tables.Add((DataTable) new dsGLRaterExposure.lstGLExposureUnitDataTable(dataSet.Tables[nameof (lstGLExposureUnit)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsGLRaterExposure.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (lstEndorsementCalculationTypes)] != null)
          base.Tables.Add((DataTable) new dsGLRaterExposure.lstEndorsementCalculationTypesDataTable(dataSet.Tables[nameof (lstEndorsementCalculationTypes)]));
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
  public dsGLRaterExposure.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRaterExposure.lstClassCodesDataTable lstClassCodes => this.tablelstClassCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRaterExposure.tblGLExposuresDataTable tblGLExposures => this.tabletblGLExposures;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRaterExposure.lstGLExposureUnitDataTable lstGLExposureUnit
  {
    get => this.tablelstGLExposureUnit;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRaterExposure.tblClientOfficesDataTable tblClientOffices => this.tabletblClientOffices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRaterExposure.lstEndorsementCalculationTypesDataTable lstEndorsementCalculationTypes
  {
    get => this.tablelstEndorsementCalculationTypes;
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
    dsGLRaterExposure dsGlRaterExposure = (dsGLRaterExposure) base.Clone();
    dsGlRaterExposure.InitVars();
    dsGlRaterExposure.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsGlRaterExposure;
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
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsGLRaterExposure.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["lstClassCodes"] != null)
        base.Tables.Add((DataTable) new dsGLRaterExposure.lstClassCodesDataTable(dataSet.Tables["lstClassCodes"]));
      if (dataSet.Tables["tblGLExposures"] != null)
        base.Tables.Add((DataTable) new dsGLRaterExposure.tblGLExposuresDataTable(dataSet.Tables["tblGLExposures"]));
      if (dataSet.Tables["lstGLExposureUnit"] != null)
        base.Tables.Add((DataTable) new dsGLRaterExposure.lstGLExposureUnitDataTable(dataSet.Tables["lstGLExposureUnit"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsGLRaterExposure.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["lstEndorsementCalculationTypes"] != null)
        base.Tables.Add((DataTable) new dsGLRaterExposure.lstEndorsementCalculationTypesDataTable(dataSet.Tables["lstEndorsementCalculationTypes"]));
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
    this.tabletblUnderwritingLocations = (dsGLRaterExposure.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tablelstClassCodes = (dsGLRaterExposure.lstClassCodesDataTable) base.Tables["lstClassCodes"];
    if (initTable && this.tablelstClassCodes != null)
      this.tablelstClassCodes.InitVars();
    this.tabletblGLExposures = (dsGLRaterExposure.tblGLExposuresDataTable) base.Tables["tblGLExposures"];
    if (initTable && this.tabletblGLExposures != null)
      this.tabletblGLExposures.InitVars();
    this.tablelstGLExposureUnit = (dsGLRaterExposure.lstGLExposureUnitDataTable) base.Tables["lstGLExposureUnit"];
    if (initTable && this.tablelstGLExposureUnit != null)
      this.tablelstGLExposureUnit.InitVars();
    this.tabletblClientOffices = (dsGLRaterExposure.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tablelstEndorsementCalculationTypes = (dsGLRaterExposure.lstEndorsementCalculationTypesDataTable) base.Tables["lstEndorsementCalculationTypes"];
    if (initTable && this.tablelstEndorsementCalculationTypes != null)
      this.tablelstEndorsementCalculationTypes.InitVars();
    this.relationlstEndorsementCalculationTypestblGLExposures = this.Relations["lstEndorsementCalculationTypestblGLExposures"];
    this.relationtblClientOfficestblGLExposures = this.Relations["tblClientOfficestblGLExposures"];
    this.relationtblUnderwritingLocationstblGLExposures = this.Relations["tblUnderwritingLocationstblGLExposures"];
    this.relationlstGLExposureUnittblGLExposures = this.Relations["lstGLExposureUnittblGLExposures"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGLRaterExposure);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsGLRaterExposure.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblUnderwritingLocations = new dsGLRaterExposure.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tablelstClassCodes = new dsGLRaterExposure.lstClassCodesDataTable();
    base.Tables.Add((DataTable) this.tablelstClassCodes);
    this.tabletblGLExposures = new dsGLRaterExposure.tblGLExposuresDataTable();
    base.Tables.Add((DataTable) this.tabletblGLExposures);
    this.tablelstGLExposureUnit = new dsGLRaterExposure.lstGLExposureUnitDataTable();
    base.Tables.Add((DataTable) this.tablelstGLExposureUnit);
    this.tabletblClientOffices = new dsGLRaterExposure.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tablelstEndorsementCalculationTypes = new dsGLRaterExposure.lstEndorsementCalculationTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstEndorsementCalculationTypes);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstEndorsementCalculationTypestblGLExposures", new DataColumn[1]
    {
      this.tablelstEndorsementCalculationTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.EndorsementCalcTypeColumn
    });
    this.tabletblGLExposures.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblClientOfficestblGLExposures", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.OfficeIDColumn
    });
    this.tabletblGLExposures.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblUnderwritingLocationstblGLExposures", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.LocationIDColumn
    });
    this.tabletblGLExposures.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstGLExposureUnittblGLExposures", new DataColumn[1]
    {
      this.tablelstGLExposureUnit.ExposureUnitColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.ExposureUnitColumn
    });
    this.tabletblGLExposures.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    this.relationlstEndorsementCalculationTypestblGLExposures = new DataRelation("lstEndorsementCalculationTypestblGLExposures", new DataColumn[1]
    {
      this.tablelstEndorsementCalculationTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.EndorsementCalcTypeColumn
    }, false);
    this.Relations.Add(this.relationlstEndorsementCalculationTypestblGLExposures);
    this.relationtblClientOfficestblGLExposures = new DataRelation("tblClientOfficestblGLExposures", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.OfficeIDColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblGLExposures);
    this.relationtblUnderwritingLocationstblGLExposures = new DataRelation("tblUnderwritingLocationstblGLExposures", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.LocationIDColumn
    }, false);
    this.Relations.Add(this.relationtblUnderwritingLocationstblGLExposures);
    this.relationlstGLExposureUnittblGLExposures = new DataRelation("lstGLExposureUnittblGLExposures", new DataColumn[1]
    {
      this.tablelstGLExposureUnit.ExposureUnitColumn
    }, new DataColumn[1]
    {
      this.tabletblGLExposures.ExposureUnitColumn
    }, false);
    this.Relations.Add(this.relationlstGLExposureUnittblGLExposures);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstClassCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblGLExposures() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstGLExposureUnit() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstEndorsementCalculationTypes() => false;

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
    dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsGlRaterExposure.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsGLRaterExposure.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstClassCodesRowChangeEventHandler(
    object sender,
    dsGLRaterExposure.lstClassCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblGLExposuresRowChangeEventHandler(
    object sender,
    dsGLRaterExposure.tblGLExposuresRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstGLExposureUnitRowChangeEventHandler(
    object sender,
    dsGLRaterExposure.lstGLExposureUnitRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsGLRaterExposure.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstEndorsementCalculationTypesRowChangeEventHandler(
    object sender,
    dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsGLRaterExposure.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnLocationNo;
    private DataColumn columnBuildingNo;
    private DataColumn columnPhysicalBuildingNo;
    private DataColumn columnAddress;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsDataTable(DataTable table)
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
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhysicalBuildingNoColumn => this.columnPhysicalBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsGLRaterExposure.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblUnderwritingLocationsRow(dsGLRaterExposure.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      int LocationNo,
      string BuildingNo,
      string PhysicalBuildingNo,
      string Address,
      string City,
      string State,
      string Zip)
    {
      dsGLRaterExposure.tblUnderwritingLocationsRow row = (dsGLRaterExposure.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[8]
      {
        null,
        (object) LocationNo,
        (object) BuildingNo,
        (object) PhysicalBuildingNo,
        (object) Address,
        (object) City,
        (object) State,
        (object) Zip
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsGLRaterExposure.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRaterExposure.tblUnderwritingLocationsDataTable locationsDataTable = (dsGLRaterExposure.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRaterExposure.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnPhysicalBuildingNo = this.Columns["PhysicalBuildingNo"];
      this.columnAddress = this.Columns["Address"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnPhysicalBuildingNo = new DataColumn("PhysicalBuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysicalBuildingNo);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnLocationNo.AllowDBNull = false;
      this.columnBuildingNo.AllowDBNull = false;
      this.columnPhysicalBuildingNo.AllowDBNull = false;
      this.columnAddress.ReadOnly = true;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnZip.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsGLRaterExposure.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRaterExposure.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRaterExposure.tblUnderwritingLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsGLRaterExposure.tblUnderwritingLocationsRowChangeEvent((dsGLRaterExposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRaterExposure.tblUnderwritingLocationsRowChangeEvent((dsGLRaterExposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsGLRaterExposure.tblUnderwritingLocationsRowChangeEvent((dsGLRaterExposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRaterExposure.tblUnderwritingLocationsRowChangeEvent((dsGLRaterExposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(dsGLRaterExposure.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
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
        FixedValue = dsGlRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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
  public class lstClassCodesDataTable : TypedTableBase<dsGLRaterExposure.lstClassCodesRow>
  {
    private DataColumn columnClassCode;
    private DataColumn columnClassCodeDescription;
    private DataColumn columnAccess;
    private DataColumn columnGLExposureUnit;
    private DataColumn columnClassCodeID;

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
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessColumn => this.columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLExposureUnitColumn => this.columnGLExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstClassCodesRow this[int index]
    {
      get => (dsGLRaterExposure.lstClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstClassCodesRowChangeEventHandler lstClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstClassCodesRowChangeEventHandler lstClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstClassCodesRow(dsGLRaterExposure.lstClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstClassCodesRow AddlstClassCodesRow(
      string ClassCode,
      string ClassCodeDescription,
      string Access,
      string GLExposureUnit,
      int ClassCodeID)
    {
      dsGLRaterExposure.lstClassCodesRow row = (dsGLRaterExposure.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) ClassCode,
        (object) ClassCodeDescription,
        (object) Access,
        (object) GLExposureUnit,
        (object) ClassCodeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstClassCodesRow FindByClassCodeID(int ClassCodeID)
    {
      return (dsGLRaterExposure.lstClassCodesRow) this.Rows.Find(new object[1]
      {
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRaterExposure.lstClassCodesDataTable classCodesDataTable = (dsGLRaterExposure.lstClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRaterExposure.lstClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
      this.columnAccess = this.Columns["Access"];
      this.columnGLExposureUnit = this.Columns["GLExposureUnit"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.columnAccess = new DataColumn("Access", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccess);
      this.columnGLExposureUnit = new DataColumn("GLExposureUnit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLExposureUnit);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLRaterExposureKey3", new DataColumn[1]
      {
        this.columnClassCodeID
      }, true));
      this.columnClassCode.AllowDBNull = false;
      this.columnClassCodeDescription.AllowDBNull = false;
      this.columnClassCodeID.AllowDBNull = false;
      this.columnClassCodeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstClassCodesRow NewlstClassCodesRow()
    {
      return (dsGLRaterExposure.lstClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRaterExposure.lstClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRaterExposure.lstClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.lstClassCodesRowChangeEventHandler codesRowChangedEvent = this.lstClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsGLRaterExposure.lstClassCodesRowChangeEvent((dsGLRaterExposure.lstClassCodesRow) e.Row, e.Action));
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
      dsGLRaterExposure.lstClassCodesRowChangeEventHandler rowChangingEvent = this.lstClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRaterExposure.lstClassCodesRowChangeEvent((dsGLRaterExposure.lstClassCodesRow) e.Row, e.Action));
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
      dsGLRaterExposure.lstClassCodesRowChangeEventHandler codesRowDeletedEvent = this.lstClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsGLRaterExposure.lstClassCodesRowChangeEvent((dsGLRaterExposure.lstClassCodesRow) e.Row, e.Action));
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
      dsGLRaterExposure.lstClassCodesRowChangeEventHandler rowDeletingEvent = this.lstClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRaterExposure.lstClassCodesRowChangeEvent((dsGLRaterExposure.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstClassCodesRow(dsGLRaterExposure.lstClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
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
        FixedValue = dsGlRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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
  public class tblGLExposuresDataTable : TypedTableBase<dsGLRaterExposure.tblGLExposuresRow>
  {
    private DataColumn columnExposureID;
    private DataColumn columnOriginalExposureID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnLocationID;
    private DataColumn columnClassCodeID;
    private DataColumn columnExposure;
    private DataColumn columnExposureUnit;
    private DataColumn columnPremRate;
    private DataColumn columnProdRate;
    private DataColumn columnTerrRate;
    private DataColumn columnCombinedRate;
    private DataColumn columnPremPremium;
    private DataColumn columnProdPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnTotalPremium;
    private DataColumn columnUserAdded;
    private DataColumn columnOfficeID;
    private DataColumn columnModificationCode;
    private DataColumn columnEndorsementCalcType;
    private DataColumn columnEffectiveDate;
    private DataColumn columnFactor;
    private DataColumn columnUserOverrideFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGLExposuresDataTable()
    {
      this.TableName = "tblGLExposures";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGLExposuresDataTable(DataTable table)
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
    protected tblGLExposuresDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureIDColumn => this.columnExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OriginalExposureIDColumn => this.columnOriginalExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureColumn => this.columnExposure;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureUnitColumn => this.columnExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremRateColumn => this.columnPremRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProdRateColumn => this.columnProdRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrRateColumn => this.columnTerrRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CombinedRateColumn => this.columnCombinedRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremPremiumColumn => this.columnPremPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProdPremiumColumn => this.columnProdPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrPremiumColumn => this.columnTerrPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TotalPremiumColumn => this.columnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserAddedColumn => this.columnUserAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

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
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow this[int index]
    {
      get => (dsGLRaterExposure.tblGLExposuresRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblGLExposuresRowChangeEventHandler tblGLExposuresRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblGLExposuresRowChangeEventHandler tblGLExposuresRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblGLExposuresRowChangeEventHandler tblGLExposuresRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblGLExposuresRowChangeEventHandler tblGLExposuresRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblGLExposuresRow(dsGLRaterExposure.tblGLExposuresRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow AddtblGLExposuresRow(
      int OriginalExposureID,
      int QuoteOptionID,
      dsGLRaterExposure.tblUnderwritingLocationsRow parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblGLExposures,
      int ClassCodeID,
      int Exposure,
      dsGLRaterExposure.lstGLExposureUnitRow parentlstGLExposureUnitRowBylstGLExposureUnittblGLExposures,
      Decimal PremRate,
      Decimal ProdRate,
      Decimal TerrRate,
      Decimal CombinedRate,
      Decimal PremPremium,
      Decimal ProdPremium,
      Decimal TerrPremium,
      Decimal TotalPremium,
      Guid UserAdded,
      dsGLRaterExposure.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblGLExposures,
      string ModificationCode,
      dsGLRaterExposure.lstEndorsementCalculationTypesRow parentlstEndorsementCalculationTypesRowBylstEndorsementCalculationTypestblGLExposures,
      DateTime EffectiveDate,
      Decimal Factor,
      Decimal UserOverrideFactor)
    {
      dsGLRaterExposure.tblGLExposuresRow row = (dsGLRaterExposure.tblGLExposuresRow) this.NewRow();
      object[] objArray = new object[22]
      {
        null,
        (object) OriginalExposureID,
        (object) QuoteOptionID,
        null,
        (object) ClassCodeID,
        (object) Exposure,
        null,
        (object) PremRate,
        (object) ProdRate,
        (object) TerrRate,
        (object) CombinedRate,
        (object) PremPremium,
        (object) ProdPremium,
        (object) TerrPremium,
        (object) TotalPremium,
        (object) UserAdded,
        null,
        (object) ModificationCode,
        null,
        (object) EffectiveDate,
        (object) Factor,
        (object) UserOverrideFactor
      };
      if (parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblGLExposures != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblGLExposures[0]);
      if (parentlstGLExposureUnitRowBylstGLExposureUnittblGLExposures != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parentlstGLExposureUnitRowBylstGLExposureUnittblGLExposures[0]);
      if (parenttblClientOfficesRowBytblClientOfficestblGLExposures != null)
        objArray[16 /*0x10*/] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblGLExposures[0]);
      if (parentlstEndorsementCalculationTypesRowBylstEndorsementCalculationTypestblGLExposures != null)
        objArray[18] = RuntimeHelpers.GetObjectValue(parentlstEndorsementCalculationTypesRowBylstEndorsementCalculationTypestblGLExposures[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow FindByExposureID(int ExposureID)
    {
      return (dsGLRaterExposure.tblGLExposuresRow) this.Rows.Find(new object[1]
      {
        (object) ExposureID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRaterExposure.tblGLExposuresDataTable exposuresDataTable = (dsGLRaterExposure.tblGLExposuresDataTable) base.Clone();
      exposuresDataTable.InitVars();
      return (DataTable) exposuresDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRaterExposure.tblGLExposuresDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnExposureID = this.Columns["ExposureID"];
      this.columnOriginalExposureID = this.Columns["OriginalExposureID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnExposure = this.Columns["Exposure"];
      this.columnExposureUnit = this.Columns["ExposureUnit"];
      this.columnPremRate = this.Columns["PremRate"];
      this.columnProdRate = this.Columns["ProdRate"];
      this.columnTerrRate = this.Columns["TerrRate"];
      this.columnCombinedRate = this.Columns["CombinedRate"];
      this.columnPremPremium = this.Columns["PremPremium"];
      this.columnProdPremium = this.Columns["ProdPremium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnTotalPremium = this.Columns["TotalPremium"];
      this.columnUserAdded = this.Columns["UserAdded"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnModificationCode = this.Columns["ModificationCode"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnFactor = this.Columns["Factor"];
      this.columnUserOverrideFactor = this.Columns["UserOverrideFactor"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnExposureID = new DataColumn("ExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureID);
      this.columnOriginalExposureID = new DataColumn("OriginalExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalExposureID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnExposure = new DataColumn("Exposure", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposure);
      this.columnExposureUnit = new DataColumn("ExposureUnit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureUnit);
      this.columnPremRate = new DataColumn("PremRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremRate);
      this.columnProdRate = new DataColumn("ProdRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProdRate);
      this.columnTerrRate = new DataColumn("TerrRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrRate);
      this.columnCombinedRate = new DataColumn("CombinedRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCombinedRate);
      this.columnPremPremium = new DataColumn("PremPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremPremium);
      this.columnProdPremium = new DataColumn("ProdPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProdPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnTotalPremium = new DataColumn("TotalPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPremium);
      this.columnUserAdded = new DataColumn("UserAdded", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserAdded);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.columnUserOverrideFactor = new DataColumn("UserOverrideFactor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserOverrideFactor);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnExposureID
      }, true));
      this.columnExposureID.AutoIncrement = true;
      this.columnExposureID.AllowDBNull = false;
      this.columnExposureID.ReadOnly = true;
      this.columnExposureID.Unique = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnLocationID.AllowDBNull = false;
      this.columnExposure.AllowDBNull = false;
      this.columnExposure.DefaultValue = (object) 0;
      this.columnPremRate.AllowDBNull = false;
      this.columnPremRate.DefaultValue = (object) 0M;
      this.columnProdRate.AllowDBNull = false;
      this.columnProdRate.DefaultValue = (object) 0M;
      this.columnTerrRate.AllowDBNull = false;
      this.columnTerrRate.DefaultValue = (object) 0M;
      this.columnCombinedRate.AllowDBNull = false;
      this.columnCombinedRate.DefaultValue = (object) 0M;
      this.columnPremPremium.AllowDBNull = false;
      this.columnPremPremium.DefaultValue = (object) 0M;
      this.columnProdPremium.AllowDBNull = false;
      this.columnProdPremium.DefaultValue = (object) 0M;
      this.columnTerrPremium.AllowDBNull = false;
      this.columnTerrPremium.DefaultValue = (object) 0M;
      this.columnTotalPremium.AllowDBNull = false;
      this.columnTotalPremium.ReadOnly = true;
      this.columnTotalPremium.DefaultValue = (object) 0M;
      this.columnModificationCode.AllowDBNull = false;
      this.columnEffectiveDate.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow NewtblGLExposuresRow()
    {
      return (dsGLRaterExposure.tblGLExposuresRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRaterExposure.tblGLExposuresRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRaterExposure.tblGLExposuresRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLExposuresRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblGLExposuresRowChangeEventHandler exposuresRowChangedEvent = this.tblGLExposuresRowChangedEvent;
      if (exposuresRowChangedEvent == null)
        return;
      exposuresRowChangedEvent((object) this, new dsGLRaterExposure.tblGLExposuresRowChangeEvent((dsGLRaterExposure.tblGLExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLExposuresRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblGLExposuresRowChangeEventHandler rowChangingEvent = this.tblGLExposuresRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRaterExposure.tblGLExposuresRowChangeEvent((dsGLRaterExposure.tblGLExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLExposuresRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblGLExposuresRowChangeEventHandler exposuresRowDeletedEvent = this.tblGLExposuresRowDeletedEvent;
      if (exposuresRowDeletedEvent == null)
        return;
      exposuresRowDeletedEvent((object) this, new dsGLRaterExposure.tblGLExposuresRowChangeEvent((dsGLRaterExposure.tblGLExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLExposuresRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblGLExposuresRowChangeEventHandler rowDeletingEvent = this.tblGLExposuresRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRaterExposure.tblGLExposuresRowChangeEvent((dsGLRaterExposure.tblGLExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblGLExposuresRow(dsGLRaterExposure.tblGLExposuresRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
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
        FixedValue = dsGlRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGLExposuresDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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
  public class lstGLExposureUnitDataTable : TypedTableBase<dsGLRaterExposure.lstGLExposureUnitRow>
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
    public dsGLRaterExposure.lstGLExposureUnitRow this[int index]
    {
      get => (dsGLRaterExposure.lstGLExposureUnitRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler lstGLExposureUnitRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstGLExposureUnitRow(dsGLRaterExposure.lstGLExposureUnitRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstGLExposureUnitRow AddlstGLExposureUnitRow(
      string ExposureUnit,
      string ExposureDescription)
    {
      dsGLRaterExposure.lstGLExposureUnitRow row = (dsGLRaterExposure.lstGLExposureUnitRow) this.NewRow();
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
    public dsGLRaterExposure.lstGLExposureUnitRow FindByExposureUnit(string ExposureUnit)
    {
      return (dsGLRaterExposure.lstGLExposureUnitRow) this.Rows.Find(new object[1]
      {
        (object) ExposureUnit
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRaterExposure.lstGLExposureUnitDataTable exposureUnitDataTable = (dsGLRaterExposure.lstGLExposureUnitDataTable) base.Clone();
      exposureUnitDataTable.InitVars();
      return (DataTable) exposureUnitDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRaterExposure.lstGLExposureUnitDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnExposureUnit
      }, true));
      this.columnExposureUnit.AllowDBNull = false;
      this.columnExposureUnit.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstGLExposureUnitRow NewlstGLExposureUnitRow()
    {
      return (dsGLRaterExposure.lstGLExposureUnitRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRaterExposure.lstGLExposureUnitRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRaterExposure.lstGLExposureUnitRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLExposureUnitRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler unitRowChangedEvent = this.lstGLExposureUnitRowChangedEvent;
      if (unitRowChangedEvent == null)
        return;
      unitRowChangedEvent((object) this, new dsGLRaterExposure.lstGLExposureUnitRowChangeEvent((dsGLRaterExposure.lstGLExposureUnitRow) e.Row, e.Action));
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
      dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler rowChangingEvent = this.lstGLExposureUnitRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRaterExposure.lstGLExposureUnitRowChangeEvent((dsGLRaterExposure.lstGLExposureUnitRow) e.Row, e.Action));
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
      dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler unitRowDeletedEvent = this.lstGLExposureUnitRowDeletedEvent;
      if (unitRowDeletedEvent == null)
        return;
      unitRowDeletedEvent((object) this, new dsGLRaterExposure.lstGLExposureUnitRowChangeEvent((dsGLRaterExposure.lstGLExposureUnitRow) e.Row, e.Action));
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
      dsGLRaterExposure.lstGLExposureUnitRowChangeEventHandler rowDeletingEvent = this.lstGLExposureUnitRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRaterExposure.lstGLExposureUnitRowChangeEvent((dsGLRaterExposure.lstGLExposureUnitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstGLExposureUnitRow(dsGLRaterExposure.lstGLExposureUnitRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
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
        FixedValue = dsGlRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstGLExposureUnitDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsGLRaterExposure.tblClientOfficesRow>
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
    public dsGLRaterExposure.tblClientOfficesRow this[int index]
    {
      get => (dsGLRaterExposure.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblClientOfficesRow(dsGLRaterExposure.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblClientOfficesRow AddtblClientOfficesRow(string Location)
    {
      dsGLRaterExposure.tblClientOfficesRow row = (dsGLRaterExposure.tblClientOfficesRow) this.NewRow();
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
    public dsGLRaterExposure.tblClientOfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsGLRaterExposure.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRaterExposure.tblClientOfficesDataTable officesDataTable = (dsGLRaterExposure.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRaterExposure.tblClientOfficesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLRaterExposureKey2", new DataColumn[1]
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
    public dsGLRaterExposure.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsGLRaterExposure.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRaterExposure.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRaterExposure.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsGLRaterExposure.tblClientOfficesRowChangeEvent((dsGLRaterExposure.tblClientOfficesRow) e.Row, e.Action));
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
      dsGLRaterExposure.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRaterExposure.tblClientOfficesRowChangeEvent((dsGLRaterExposure.tblClientOfficesRow) e.Row, e.Action));
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
      dsGLRaterExposure.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsGLRaterExposure.tblClientOfficesRowChangeEvent((dsGLRaterExposure.tblClientOfficesRow) e.Row, e.Action));
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
      dsGLRaterExposure.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRaterExposure.tblClientOfficesRowChangeEvent((dsGLRaterExposure.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblClientOfficesRow(dsGLRaterExposure.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
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
        FixedValue = dsGlRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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
  public class lstEndorsementCalculationTypesDataTable : 
    TypedTableBase<dsGLRaterExposure.lstEndorsementCalculationTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstEndorsementCalculationTypesDataTable()
    {
      this.TableName = "lstEndorsementCalculationTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstEndorsementCalculationTypesDataTable(DataTable table)
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
    protected lstEndorsementCalculationTypesDataTable(
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
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstEndorsementCalculationTypesRow this[int index]
    {
      get => (dsGLRaterExposure.lstEndorsementCalculationTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstEndorsementCalculationTypesRow(
      dsGLRaterExposure.lstEndorsementCalculationTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstEndorsementCalculationTypesRow AddlstEndorsementCalculationTypesRow(
      string ID,
      string EndorsementCalcType)
    {
      dsGLRaterExposure.lstEndorsementCalculationTypesRow row = (dsGLRaterExposure.lstEndorsementCalculationTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) EndorsementCalcType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstEndorsementCalculationTypesRow FindByID(string ID)
    {
      return (dsGLRaterExposure.lstEndorsementCalculationTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRaterExposure.lstEndorsementCalculationTypesDataTable calculationTypesDataTable = (dsGLRaterExposure.lstEndorsementCalculationTypesDataTable) base.Clone();
      calculationTypesDataTable.InitVars();
      return (DataTable) calculationTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRaterExposure.lstEndorsementCalculationTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLRaterExposureKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnEndorsementCalcType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstEndorsementCalculationTypesRow NewlstEndorsementCalculationTypesRow()
    {
      return (dsGLRaterExposure.lstEndorsementCalculationTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRaterExposure.lstEndorsementCalculationTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsGLRaterExposure.lstEndorsementCalculationTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler typesRowChangedEvent = this.lstEndorsementCalculationTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEvent((dsGLRaterExposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler rowChangingEvent = this.lstEndorsementCalculationTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEvent((dsGLRaterExposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler typesRowDeletedEvent = this.lstEndorsementCalculationTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEvent((dsGLRaterExposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEventHandler rowDeletingEvent = this.lstEndorsementCalculationTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRaterExposure.lstEndorsementCalculationTypesRowChangeEvent((dsGLRaterExposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstEndorsementCalculationTypesRow(
      dsGLRaterExposure.lstEndorsementCalculationTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRaterExposure dsGlRaterExposure = new dsGLRaterExposure();
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
        FixedValue = dsGlRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstEndorsementCalculationTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRaterExposure.GetSchemaSerializable();
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

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsGLRaterExposure.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsGLRaterExposure.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationNo
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationNoColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BuildingNo
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.BuildingNoColumn]);
      set => this[this.tabletblUnderwritingLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PhysicalBuildingNo
    {
      get
      {
        return Conversions.ToString(this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn]);
      }
      set => this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipColumn]);
      set => this[this.tabletblUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tabletblUnderwritingLocations.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tabletblUnderwritingLocations.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow[] GettblGLExposuresRows()
    {
      return this.Table.ChildRelations["tblUnderwritingLocationstblGLExposures"] != null ? (dsGLRaterExposure.tblGLExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["tblUnderwritingLocationstblGLExposures"]) : new dsGLRaterExposure.tblGLExposuresRow[0];
    }
  }

  public class lstClassCodesRow : DataRow
  {
    private dsGLRaterExposure.lstClassCodesDataTable tablelstClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClassCodes = (dsGLRaterExposure.lstClassCodesDataTable) this.Table;
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
    public string Access
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClassCodes.AccessColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Access' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.AccessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GLExposureUnit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClassCodes.GLExposureUnitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLExposureUnit' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.GLExposureUnitColumn] = (object) value;
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
    public bool IsAccessNull() => this.IsNull(this.tablelstClassCodes.AccessColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccessNull()
    {
      this[this.tablelstClassCodes.AccessColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLExposureUnitNull() => this.IsNull(this.tablelstClassCodes.GLExposureUnitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLExposureUnitNull()
    {
      this[this.tablelstClassCodes.GLExposureUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblGLExposuresRow : DataRow
  {
    private dsGLRaterExposure.tblGLExposuresDataTable tabletblGLExposures;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGLExposuresRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGLExposures = (dsGLRaterExposure.tblGLExposuresDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ExposureID
    {
      get => Conversions.ToInteger(this[this.tabletblGLExposures.ExposureIDColumn]);
      set => this[this.tabletblGLExposures.ExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OriginalExposureID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGLExposures.OriginalExposureIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalExposureID' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.OriginalExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblGLExposures.QuoteOptionIDColumn]);
      set => this[this.tabletblGLExposures.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblGLExposures.LocationIDColumn]);
      set => this[this.tabletblGLExposures.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClassCodeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGLExposures.ClassCodeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeID' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Exposure
    {
      get => Conversions.ToInteger(this[this.tabletblGLExposures.ExposureColumn]);
      set => this[this.tabletblGLExposures.ExposureColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ExposureUnit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGLExposures.ExposureUnitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExposureUnit' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.ExposureUnitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PremRate
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.PremRateColumn]);
      set => this[this.tabletblGLExposures.PremRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ProdRate
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.ProdRateColumn]);
      set => this[this.tabletblGLExposures.ProdRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TerrRate
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.TerrRateColumn]);
      set => this[this.tabletblGLExposures.TerrRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal CombinedRate
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.CombinedRateColumn]);
      set => this[this.tabletblGLExposures.CombinedRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PremPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.PremPremiumColumn]);
      set => this[this.tabletblGLExposures.PremPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ProdPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.ProdPremiumColumn]);
      set => this[this.tabletblGLExposures.ProdPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TerrPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.TerrPremiumColumn]);
      set => this[this.tabletblGLExposures.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TotalPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblGLExposures.TotalPremiumColumn]);
      set => this[this.tabletblGLExposures.TotalPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserAdded
    {
      get
      {
        try
        {
          object obj = this[this.tabletblGLExposures.UserAddedColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserAdded' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.UserAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGLExposures.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ModificationCode
    {
      get => Conversions.ToString(this[this.tabletblGLExposures.ModificationCodeColumn]);
      set => this[this.tabletblGLExposures.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGLExposures.EndorsementCalcTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementCalcType' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.EndorsementCalcTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get => Conversions.ToDate(this[this.tabletblGLExposures.EffectiveDateColumn]);
      set => this[this.tabletblGLExposures.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGLExposures.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UserOverrideFactor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGLExposures.UserOverrideFactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserOverrideFactor' in table 'tblGLExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLExposures.UserOverrideFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstEndorsementCalculationTypesRow lstEndorsementCalculationTypesRow
    {
      get
      {
        return (dsGLRaterExposure.lstEndorsementCalculationTypesRow) this.GetParentRow(this.Table.ParentRelations["lstEndorsementCalculationTypestblGLExposures"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstEndorsementCalculationTypestblGLExposures"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsGLRaterExposure.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblGLExposures"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblGLExposures"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblUnderwritingLocationsRow tblUnderwritingLocationsRow
    {
      get
      {
        return (dsGLRaterExposure.tblUnderwritingLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblUnderwritingLocationstblGLExposures"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUnderwritingLocationstblGLExposures"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstGLExposureUnitRow lstGLExposureUnitRow
    {
      get
      {
        return (dsGLRaterExposure.lstGLExposureUnitRow) this.GetParentRow(this.Table.ParentRelations["lstGLExposureUnittblGLExposures"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstGLExposureUnittblGLExposures"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOriginalExposureIDNull()
    {
      return this.IsNull(this.tabletblGLExposures.OriginalExposureIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOriginalExposureIDNull()
    {
      this[this.tabletblGLExposures.OriginalExposureIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeIDNull() => this.IsNull(this.tabletblGLExposures.ClassCodeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeIDNull()
    {
      this[this.tabletblGLExposures.ClassCodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExposureUnitNull() => this.IsNull(this.tabletblGLExposures.ExposureUnitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExposureUnitNull()
    {
      this[this.tabletblGLExposures.ExposureUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserAddedNull() => this.IsNull(this.tabletblGLExposures.UserAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserAddedNull()
    {
      this[this.tabletblGLExposures.UserAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOfficeIDNull() => this.IsNull(this.tabletblGLExposures.OfficeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tabletblGLExposures.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEndorsementCalcTypeNull()
    {
      return this.IsNull(this.tabletblGLExposures.EndorsementCalcTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEndorsementCalcTypeNull()
    {
      this[this.tabletblGLExposures.EndorsementCalcTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblGLExposures.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblGLExposures.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserOverrideFactorNull()
    {
      return this.IsNull(this.tabletblGLExposures.UserOverrideFactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserOverrideFactorNull()
    {
      this[this.tabletblGLExposures.UserOverrideFactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstGLExposureUnitRow : DataRow
  {
    private dsGLRaterExposure.lstGLExposureUnitDataTable tablelstGLExposureUnit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstGLExposureUnitRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstGLExposureUnit = (dsGLRaterExposure.lstGLExposureUnitDataTable) this.Table;
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
    public dsGLRaterExposure.tblGLExposuresRow[] GettblGLExposuresRows()
    {
      return this.Table.ChildRelations["lstGLExposureUnittblGLExposures"] != null ? (dsGLRaterExposure.tblGLExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["lstGLExposureUnittblGLExposures"]) : new dsGLRaterExposure.tblGLExposuresRow[0];
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsGLRaterExposure.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsGLRaterExposure.tblClientOfficesDataTable) this.Table;
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
    public dsGLRaterExposure.tblGLExposuresRow[] GettblGLExposuresRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblGLExposures"] != null ? (dsGLRaterExposure.tblGLExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblGLExposures"]) : new dsGLRaterExposure.tblGLExposuresRow[0];
    }
  }

  public class lstEndorsementCalculationTypesRow : DataRow
  {
    private dsGLRaterExposure.lstEndorsementCalculationTypesDataTable tablelstEndorsementCalculationTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstEndorsementCalculationTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstEndorsementCalculationTypes = (dsGLRaterExposure.lstEndorsementCalculationTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstEndorsementCalculationTypes.IDColumn]);
      set => this[this.tablelstEndorsementCalculationTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        return Conversions.ToString(this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn]);
      }
      set
      {
        this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow[] GettblGLExposuresRows()
    {
      return this.Table.ChildRelations["lstEndorsementCalculationTypestblGLExposures"] != null ? (dsGLRaterExposure.tblGLExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["lstEndorsementCalculationTypestblGLExposures"]) : new dsGLRaterExposure.tblGLExposuresRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsGLRaterExposure.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsGLRaterExposure.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstClassCodesRowChangeEvent : EventArgs
  {
    private dsGLRaterExposure.lstClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstClassCodesRowChangeEvent(dsGLRaterExposure.lstClassCodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblGLExposuresRowChangeEvent : EventArgs
  {
    private dsGLRaterExposure.tblGLExposuresRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGLExposuresRowChangeEvent(
      dsGLRaterExposure.tblGLExposuresRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblGLExposuresRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstGLExposureUnitRowChangeEvent : EventArgs
  {
    private dsGLRaterExposure.lstGLExposureUnitRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstGLExposureUnitRowChangeEvent(
      dsGLRaterExposure.lstGLExposureUnitRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstGLExposureUnitRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsGLRaterExposure.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsGLRaterExposure.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstEndorsementCalculationTypesRowChangeEvent : EventArgs
  {
    private dsGLRaterExposure.lstEndorsementCalculationTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstEndorsementCalculationTypesRowChangeEvent(
      dsGLRaterExposure.lstEndorsementCalculationTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRaterExposure.lstEndorsementCalculationTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
