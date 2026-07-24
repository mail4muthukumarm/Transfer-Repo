// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.dsSecurityTime
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsSecurityTime")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsSecurityTime : DataSet
{
  private dsSecurityTime.tblSecurityTimeRestrictionsDataTable tabletblSecurityTimeRestrictions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsSecurityTime()
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
  protected dsSecurityTime(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblSecurityTimeRestrictions)] != null)
          base.Tables.Add((DataTable) new dsSecurityTime.tblSecurityTimeRestrictionsDataTable(dataSet.Tables[nameof (tblSecurityTimeRestrictions)]));
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
  public dsSecurityTime.tblSecurityTimeRestrictionsDataTable tblSecurityTimeRestrictions
  {
    get => this.tabletblSecurityTimeRestrictions;
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
    dsSecurityTime dsSecurityTime = (dsSecurityTime) base.Clone();
    dsSecurityTime.InitVars();
    dsSecurityTime.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsSecurityTime;
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
      if (dataSet.Tables["tblSecurityTimeRestrictions"] != null)
        base.Tables.Add((DataTable) new dsSecurityTime.tblSecurityTimeRestrictionsDataTable(dataSet.Tables["tblSecurityTimeRestrictions"]));
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
    this.tabletblSecurityTimeRestrictions = (dsSecurityTime.tblSecurityTimeRestrictionsDataTable) base.Tables["tblSecurityTimeRestrictions"];
    if (!initTable || this.tabletblSecurityTimeRestrictions == null)
      return;
    this.tabletblSecurityTimeRestrictions.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsSecurityTime);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsSecurityTime.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblSecurityTimeRestrictions = new dsSecurityTime.tblSecurityTimeRestrictionsDataTable();
    base.Tables.Add((DataTable) this.tabletblSecurityTimeRestrictions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblSecurityTimeRestrictions() => false;

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
    dsSecurityTime dsSecurityTime = new dsSecurityTime();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsSecurityTime.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsSecurityTime.GetSchemaSerializable();
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
  public delegate void tblSecurityTimeRestrictionsRowChangeEventHandler(
    object sender,
    dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblSecurityTimeRestrictionsDataTable : 
    TypedTableBase<dsSecurityTime.tblSecurityTimeRestrictionsRow>
  {
    private DataColumn columnContextGuid;
    private DataColumn columnDayCode;
    private DataColumn columnt12am;
    private DataColumn columnt1am;
    private DataColumn columnt2am;
    private DataColumn columnt3am;
    private DataColumn columnt4am;
    private DataColumn columnt5am;
    private DataColumn columnt6am;
    private DataColumn columnt7am;
    private DataColumn columnt8am;
    private DataColumn columnt9am;
    private DataColumn columnt10am;
    private DataColumn columnt11am;
    private DataColumn columnt12pm;
    private DataColumn columnt1pm;
    private DataColumn columnt2pm;
    private DataColumn columnt3pm;
    private DataColumn columnt4pm;
    private DataColumn columnt5pm;
    private DataColumn columnt6pm;
    private DataColumn columnt7pm;
    private DataColumn columnt8pm;
    private DataColumn columnt9pm;
    private DataColumn columnt10pm;
    private DataColumn columnt11pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblSecurityTimeRestrictionsDataTable()
    {
      this.TableName = "tblSecurityTimeRestrictions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblSecurityTimeRestrictionsDataTable(DataTable table)
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
    protected tblSecurityTimeRestrictionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContextGuidColumn => this.columnContextGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DayCodeColumn => this.columnDayCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t12amColumn => this.columnt12am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t1amColumn => this.columnt1am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t2amColumn => this.columnt2am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t3amColumn => this.columnt3am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t4amColumn => this.columnt4am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t5amColumn => this.columnt5am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t6amColumn => this.columnt6am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t7amColumn => this.columnt7am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t8amColumn => this.columnt8am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t9amColumn => this.columnt9am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t10amColumn => this.columnt10am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t11amColumn => this.columnt11am;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t12pmColumn => this.columnt12pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t1pmColumn => this.columnt1pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t2pmColumn => this.columnt2pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t3pmColumn => this.columnt3pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t4pmColumn => this.columnt4pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t5pmColumn => this.columnt5pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t6pmColumn => this.columnt6pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t7pmColumn => this.columnt7pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t8pmColumn => this.columnt8pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t9pmColumn => this.columnt9pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t10pmColumn => this.columnt10pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn t11pmColumn => this.columnt11pm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsSecurityTime.tblSecurityTimeRestrictionsRow this[int index]
    {
      get => (dsSecurityTime.tblSecurityTimeRestrictionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler tblSecurityTimeRestrictionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler tblSecurityTimeRestrictionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler tblSecurityTimeRestrictionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler tblSecurityTimeRestrictionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblSecurityTimeRestrictionsRow(dsSecurityTime.tblSecurityTimeRestrictionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsSecurityTime.tblSecurityTimeRestrictionsRow AddtblSecurityTimeRestrictionsRow(
      Guid ContextGuid,
      int DayCode,
      bool t12am,
      bool t1am,
      bool t2am,
      bool t3am,
      bool t4am,
      bool t5am,
      bool t6am,
      bool t7am,
      bool t8am,
      bool t9am,
      bool t10am,
      bool t11am,
      bool t12pm,
      bool t1pm,
      bool t2pm,
      bool t3pm,
      bool t4pm,
      bool t5pm,
      bool t6pm,
      bool t7pm,
      bool t8pm,
      bool t9pm,
      bool t10pm,
      bool t11pm)
    {
      dsSecurityTime.tblSecurityTimeRestrictionsRow row = (dsSecurityTime.tblSecurityTimeRestrictionsRow) this.NewRow();
      object[] objArray = new object[26]
      {
        (object) ContextGuid,
        (object) DayCode,
        (object) t12am,
        (object) t1am,
        (object) t2am,
        (object) t3am,
        (object) t4am,
        (object) t5am,
        (object) t6am,
        (object) t7am,
        (object) t8am,
        (object) t9am,
        (object) t10am,
        (object) t11am,
        (object) t12pm,
        (object) t1pm,
        (object) t2pm,
        (object) t3pm,
        (object) t4pm,
        (object) t5pm,
        (object) t6pm,
        (object) t7pm,
        (object) t8pm,
        (object) t9pm,
        (object) t10pm,
        (object) t11pm
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsSecurityTime.tblSecurityTimeRestrictionsRow FindByContextGuidDayCode(
      Guid ContextGuid,
      int DayCode)
    {
      return (dsSecurityTime.tblSecurityTimeRestrictionsRow) this.Rows.Find(new object[2]
      {
        (object) ContextGuid,
        (object) DayCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsSecurityTime.tblSecurityTimeRestrictionsDataTable restrictionsDataTable = (dsSecurityTime.tblSecurityTimeRestrictionsDataTable) base.Clone();
      restrictionsDataTable.InitVars();
      return (DataTable) restrictionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsSecurityTime.tblSecurityTimeRestrictionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnContextGuid = this.Columns["ContextGuid"];
      this.columnDayCode = this.Columns["DayCode"];
      this.columnt12am = this.Columns["t12am"];
      this.columnt1am = this.Columns["t1am"];
      this.columnt2am = this.Columns["t2am"];
      this.columnt3am = this.Columns["t3am"];
      this.columnt4am = this.Columns["t4am"];
      this.columnt5am = this.Columns["t5am"];
      this.columnt6am = this.Columns["t6am"];
      this.columnt7am = this.Columns["t7am"];
      this.columnt8am = this.Columns["t8am"];
      this.columnt9am = this.Columns["t9am"];
      this.columnt10am = this.Columns["t10am"];
      this.columnt11am = this.Columns["t11am"];
      this.columnt12pm = this.Columns["t12pm"];
      this.columnt1pm = this.Columns["t1pm"];
      this.columnt2pm = this.Columns["t2pm"];
      this.columnt3pm = this.Columns["t3pm"];
      this.columnt4pm = this.Columns["t4pm"];
      this.columnt5pm = this.Columns["t5pm"];
      this.columnt6pm = this.Columns["t6pm"];
      this.columnt7pm = this.Columns["t7pm"];
      this.columnt8pm = this.Columns["t8pm"];
      this.columnt9pm = this.Columns["t9pm"];
      this.columnt10pm = this.Columns["t10pm"];
      this.columnt11pm = this.Columns["t11pm"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnContextGuid = new DataColumn("ContextGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContextGuid);
      this.columnDayCode = new DataColumn("DayCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDayCode);
      this.columnt12am = new DataColumn("t12am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt12am);
      this.columnt1am = new DataColumn("t1am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt1am);
      this.columnt2am = new DataColumn("t2am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt2am);
      this.columnt3am = new DataColumn("t3am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt3am);
      this.columnt4am = new DataColumn("t4am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt4am);
      this.columnt5am = new DataColumn("t5am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt5am);
      this.columnt6am = new DataColumn("t6am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt6am);
      this.columnt7am = new DataColumn("t7am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt7am);
      this.columnt8am = new DataColumn("t8am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt8am);
      this.columnt9am = new DataColumn("t9am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt9am);
      this.columnt10am = new DataColumn("t10am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt10am);
      this.columnt11am = new DataColumn("t11am", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt11am);
      this.columnt12pm = new DataColumn("t12pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt12pm);
      this.columnt1pm = new DataColumn("t1pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt1pm);
      this.columnt2pm = new DataColumn("t2pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt2pm);
      this.columnt3pm = new DataColumn("t3pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt3pm);
      this.columnt4pm = new DataColumn("t4pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt4pm);
      this.columnt5pm = new DataColumn("t5pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt5pm);
      this.columnt6pm = new DataColumn("t6pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt6pm);
      this.columnt7pm = new DataColumn("t7pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt7pm);
      this.columnt8pm = new DataColumn("t8pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt8pm);
      this.columnt9pm = new DataColumn("t9pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt9pm);
      this.columnt10pm = new DataColumn("t10pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt10pm);
      this.columnt11pm = new DataColumn("t11pm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnt11pm);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnContextGuid,
        this.columnDayCode
      }, true));
      this.columnContextGuid.AllowDBNull = false;
      this.columnDayCode.AllowDBNull = false;
      this.columnt12am.AllowDBNull = false;
      this.columnt1am.AllowDBNull = false;
      this.columnt2am.AllowDBNull = false;
      this.columnt3am.AllowDBNull = false;
      this.columnt4am.AllowDBNull = false;
      this.columnt5am.AllowDBNull = false;
      this.columnt6am.AllowDBNull = false;
      this.columnt7am.AllowDBNull = false;
      this.columnt8am.AllowDBNull = false;
      this.columnt9am.AllowDBNull = false;
      this.columnt10am.AllowDBNull = false;
      this.columnt11am.AllowDBNull = false;
      this.columnt12pm.AllowDBNull = false;
      this.columnt1pm.AllowDBNull = false;
      this.columnt2pm.AllowDBNull = false;
      this.columnt3pm.AllowDBNull = false;
      this.columnt4pm.AllowDBNull = false;
      this.columnt5pm.AllowDBNull = false;
      this.columnt6pm.AllowDBNull = false;
      this.columnt7pm.AllowDBNull = false;
      this.columnt8pm.AllowDBNull = false;
      this.columnt9pm.AllowDBNull = false;
      this.columnt10pm.AllowDBNull = false;
      this.columnt11pm.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsSecurityTime.tblSecurityTimeRestrictionsRow NewtblSecurityTimeRestrictionsRow()
    {
      return (dsSecurityTime.tblSecurityTimeRestrictionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsSecurityTime.tblSecurityTimeRestrictionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsSecurityTime.tblSecurityTimeRestrictionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSecurityTimeRestrictionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler restrictionsRowChangedEvent = this.tblSecurityTimeRestrictionsRowChangedEvent;
      if (restrictionsRowChangedEvent == null)
        return;
      restrictionsRowChangedEvent((object) this, new dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEvent((dsSecurityTime.tblSecurityTimeRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSecurityTimeRestrictionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler rowChangingEvent = this.tblSecurityTimeRestrictionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEvent((dsSecurityTime.tblSecurityTimeRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSecurityTimeRestrictionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler restrictionsRowDeletedEvent = this.tblSecurityTimeRestrictionsRowDeletedEvent;
      if (restrictionsRowDeletedEvent == null)
        return;
      restrictionsRowDeletedEvent((object) this, new dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEvent((dsSecurityTime.tblSecurityTimeRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSecurityTimeRestrictionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEventHandler rowDeletingEvent = this.tblSecurityTimeRestrictionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsSecurityTime.tblSecurityTimeRestrictionsRowChangeEvent((dsSecurityTime.tblSecurityTimeRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblSecurityTimeRestrictionsRow(
      dsSecurityTime.tblSecurityTimeRestrictionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsSecurityTime dsSecurityTime = new dsSecurityTime();
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
        FixedValue = dsSecurityTime.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblSecurityTimeRestrictionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsSecurityTime.GetSchemaSerializable();
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

  public class tblSecurityTimeRestrictionsRow : DataRow
  {
    private dsSecurityTime.tblSecurityTimeRestrictionsDataTable tabletblSecurityTimeRestrictions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblSecurityTimeRestrictionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblSecurityTimeRestrictions = (dsSecurityTime.tblSecurityTimeRestrictionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ContextGuid
    {
      get
      {
        object obj = this[this.tabletblSecurityTimeRestrictions.ContextGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblSecurityTimeRestrictions.ContextGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int DayCode
    {
      get => Conversions.ToInteger(this[this.tabletblSecurityTimeRestrictions.DayCodeColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.DayCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t12am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t12amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t12amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t1am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t1amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t1amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t2am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t2amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t2amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t3am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t3amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t3amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t4am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t4amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t4amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t5am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t5amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t5amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t6am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t6amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t6amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t7am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t7amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t7amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t8am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t8amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t8amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t9am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t9amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t9amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t10am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t10amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t10amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t11am
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t11amColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t11amColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t12pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t12pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t12pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t1pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t1pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t1pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t2pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t2pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t2pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t3pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t3pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t3pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t4pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t4pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t4pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t5pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t5pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t5pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t6pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t6pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t6pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t7pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t7pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t7pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t8pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t8pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t8pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t9pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t9pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t9pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t10pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t10pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t10pmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool t11pm
    {
      get => Conversions.ToBoolean(this[this.tabletblSecurityTimeRestrictions.t11pmColumn]);
      set => this[this.tabletblSecurityTimeRestrictions.t11pmColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblSecurityTimeRestrictionsRowChangeEvent : EventArgs
  {
    private dsSecurityTime.tblSecurityTimeRestrictionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblSecurityTimeRestrictionsRowChangeEvent(
      dsSecurityTime.tblSecurityTimeRestrictionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsSecurityTime.tblSecurityTimeRestrictionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
