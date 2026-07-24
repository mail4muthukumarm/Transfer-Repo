// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Envelopes.dsEnvelopes
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
namespace MGASystems.IMS.Forms.Envelopes;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsEnvelopes")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsEnvelopes : DataSet
{
  private dsEnvelopes.tblEnvelopeTypesDataTable tabletblEnvelopeTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsEnvelopes()
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
  protected dsEnvelopes(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblEnvelopeTypes)] != null)
          base.Tables.Add((DataTable) new dsEnvelopes.tblEnvelopeTypesDataTable(dataSet.Tables[nameof (tblEnvelopeTypes)]));
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
  public dsEnvelopes.tblEnvelopeTypesDataTable tblEnvelopeTypes => this.tabletblEnvelopeTypes;

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
    dsEnvelopes dsEnvelopes = (dsEnvelopes) base.Clone();
    dsEnvelopes.InitVars();
    dsEnvelopes.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsEnvelopes;
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
      if (dataSet.Tables["tblEnvelopeTypes"] != null)
        base.Tables.Add((DataTable) new dsEnvelopes.tblEnvelopeTypesDataTable(dataSet.Tables["tblEnvelopeTypes"]));
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
    this.tabletblEnvelopeTypes = (dsEnvelopes.tblEnvelopeTypesDataTable) base.Tables["tblEnvelopeTypes"];
    if (!initTable || this.tabletblEnvelopeTypes == null)
      return;
    this.tabletblEnvelopeTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsEnvelopes);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsEnvelopes.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblEnvelopeTypes = new dsEnvelopes.tblEnvelopeTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblEnvelopeTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblEnvelopeTypes() => false;

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
    dsEnvelopes dsEnvelopes = new dsEnvelopes();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsEnvelopes.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsEnvelopes.GetSchemaSerializable();
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
  public delegate void tblEnvelopeTypesRowChangeEventHandler(
    object sender,
    dsEnvelopes.tblEnvelopeTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblEnvelopeTypesDataTable : TypedTableBase<dsEnvelopes.tblEnvelopeTypesRow>
  {
    private DataColumn columnEnvelopeTypeID;
    private DataColumn columnDescription;
    private DataColumn columnHeight;
    private DataColumn columnWidth;
    private DataColumn columnDeliveryAddressFromLeft;
    private DataColumn columnDeliveryAddressFromTop;
    private DataColumn columnDeliveryAddressFromLeftMAX;
    private DataColumn columnDeliveryAddressFromTopMAX;
    private DataColumn columnDeliveryAddressFromLeftMIN;
    private DataColumn columnDeliveryAddressFromTopMIN;
    private DataColumn columnReturnAddressFromLeft;
    private DataColumn columnReturnAddressFromTop;
    private DataColumn columnReturnAddressFromLeftMAX;
    private DataColumn columnReturnAddressFromTopMAX;
    private DataColumn columnReturnAddressFromLeftMIN;
    private DataColumn columnReturnAddressFromTopMIN;
    private DataColumn columnDefaultEnvelope;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblEnvelopeTypesDataTable()
    {
      this.TableName = "tblEnvelopeTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblEnvelopeTypesDataTable(DataTable table)
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
    protected tblEnvelopeTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EnvelopeTypeIDColumn => this.columnEnvelopeTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HeightColumn => this.columnHeight;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WidthColumn => this.columnWidth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryAddressFromLeftColumn => this.columnDeliveryAddressFromLeft;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryAddressFromTopColumn => this.columnDeliveryAddressFromTop;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryAddressFromLeftMAXColumn => this.columnDeliveryAddressFromLeftMAX;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryAddressFromTopMAXColumn => this.columnDeliveryAddressFromTopMAX;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryAddressFromLeftMINColumn => this.columnDeliveryAddressFromLeftMIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryAddressFromTopMINColumn => this.columnDeliveryAddressFromTopMIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReturnAddressFromLeftColumn => this.columnReturnAddressFromLeft;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReturnAddressFromTopColumn => this.columnReturnAddressFromTop;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReturnAddressFromLeftMAXColumn => this.columnReturnAddressFromLeftMAX;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReturnAddressFromTopMAXColumn => this.columnReturnAddressFromTopMAX;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReturnAddressFromLeftMINColumn => this.columnReturnAddressFromLeftMIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReturnAddressFromTopMINColumn => this.columnReturnAddressFromTopMIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultEnvelopeColumn => this.columnDefaultEnvelope;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEnvelopes.tblEnvelopeTypesRow this[int index]
    {
      get => (dsEnvelopes.tblEnvelopeTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler tblEnvelopeTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler tblEnvelopeTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler tblEnvelopeTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler tblEnvelopeTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblEnvelopeTypesRow(dsEnvelopes.tblEnvelopeTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEnvelopes.tblEnvelopeTypesRow AddtblEnvelopeTypesRow(
      string Description,
      Decimal Height,
      Decimal Width,
      Decimal DeliveryAddressFromLeft,
      Decimal DeliveryAddressFromTop,
      Decimal DeliveryAddressFromLeftMAX,
      Decimal DeliveryAddressFromTopMAX,
      Decimal DeliveryAddressFromLeftMIN,
      Decimal DeliveryAddressFromTopMIN,
      Decimal ReturnAddressFromLeft,
      Decimal ReturnAddressFromTop,
      Decimal ReturnAddressFromLeftMAX,
      Decimal ReturnAddressFromTopMAX,
      Decimal ReturnAddressFromLeftMIN,
      Decimal ReturnAddressFromTopMIN,
      bool DefaultEnvelope)
    {
      dsEnvelopes.tblEnvelopeTypesRow row = (dsEnvelopes.tblEnvelopeTypesRow) this.NewRow();
      object[] objArray = new object[17]
      {
        null,
        (object) Description,
        (object) Height,
        (object) Width,
        (object) DeliveryAddressFromLeft,
        (object) DeliveryAddressFromTop,
        (object) DeliveryAddressFromLeftMAX,
        (object) DeliveryAddressFromTopMAX,
        (object) DeliveryAddressFromLeftMIN,
        (object) DeliveryAddressFromTopMIN,
        (object) ReturnAddressFromLeft,
        (object) ReturnAddressFromTop,
        (object) ReturnAddressFromLeftMAX,
        (object) ReturnAddressFromTopMAX,
        (object) ReturnAddressFromLeftMIN,
        (object) ReturnAddressFromTopMIN,
        (object) DefaultEnvelope
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEnvelopes.tblEnvelopeTypesRow FindByEnvelopeTypeID(int EnvelopeTypeID)
    {
      return (dsEnvelopes.tblEnvelopeTypesRow) this.Rows.Find(new object[1]
      {
        (object) EnvelopeTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsEnvelopes.tblEnvelopeTypesDataTable envelopeTypesDataTable = (dsEnvelopes.tblEnvelopeTypesDataTable) base.Clone();
      envelopeTypesDataTable.InitVars();
      return (DataTable) envelopeTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsEnvelopes.tblEnvelopeTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEnvelopeTypeID = this.Columns["EnvelopeTypeID"];
      this.columnDescription = this.Columns["Description"];
      this.columnHeight = this.Columns["Height"];
      this.columnWidth = this.Columns["Width"];
      this.columnDeliveryAddressFromLeft = this.Columns["DeliveryAddressFromLeft"];
      this.columnDeliveryAddressFromTop = this.Columns["DeliveryAddressFromTop"];
      this.columnDeliveryAddressFromLeftMAX = this.Columns["DeliveryAddressFromLeftMAX"];
      this.columnDeliveryAddressFromTopMAX = this.Columns["DeliveryAddressFromTopMAX"];
      this.columnDeliveryAddressFromLeftMIN = this.Columns["DeliveryAddressFromLeftMIN"];
      this.columnDeliveryAddressFromTopMIN = this.Columns["DeliveryAddressFromTopMIN"];
      this.columnReturnAddressFromLeft = this.Columns["ReturnAddressFromLeft"];
      this.columnReturnAddressFromTop = this.Columns["ReturnAddressFromTop"];
      this.columnReturnAddressFromLeftMAX = this.Columns["ReturnAddressFromLeftMAX"];
      this.columnReturnAddressFromTopMAX = this.Columns["ReturnAddressFromTopMAX"];
      this.columnReturnAddressFromLeftMIN = this.Columns["ReturnAddressFromLeftMIN"];
      this.columnReturnAddressFromTopMIN = this.Columns["ReturnAddressFromTopMIN"];
      this.columnDefaultEnvelope = this.Columns["DefaultEnvelope"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEnvelopeTypeID = new DataColumn("EnvelopeTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnvelopeTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnHeight = new DataColumn("Height", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHeight);
      this.columnWidth = new DataColumn("Width", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWidth);
      this.columnDeliveryAddressFromLeft = new DataColumn("DeliveryAddressFromLeft", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryAddressFromLeft);
      this.columnDeliveryAddressFromTop = new DataColumn("DeliveryAddressFromTop", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryAddressFromTop);
      this.columnDeliveryAddressFromLeftMAX = new DataColumn("DeliveryAddressFromLeftMAX", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryAddressFromLeftMAX);
      this.columnDeliveryAddressFromTopMAX = new DataColumn("DeliveryAddressFromTopMAX", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryAddressFromTopMAX);
      this.columnDeliveryAddressFromLeftMIN = new DataColumn("DeliveryAddressFromLeftMIN", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryAddressFromLeftMIN);
      this.columnDeliveryAddressFromTopMIN = new DataColumn("DeliveryAddressFromTopMIN", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryAddressFromTopMIN);
      this.columnReturnAddressFromLeft = new DataColumn("ReturnAddressFromLeft", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnAddressFromLeft);
      this.columnReturnAddressFromTop = new DataColumn("ReturnAddressFromTop", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnAddressFromTop);
      this.columnReturnAddressFromLeftMAX = new DataColumn("ReturnAddressFromLeftMAX", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnAddressFromLeftMAX);
      this.columnReturnAddressFromTopMAX = new DataColumn("ReturnAddressFromTopMAX", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnAddressFromTopMAX);
      this.columnReturnAddressFromLeftMIN = new DataColumn("ReturnAddressFromLeftMIN", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnAddressFromLeftMIN);
      this.columnReturnAddressFromTopMIN = new DataColumn("ReturnAddressFromTopMIN", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnAddressFromTopMIN);
      this.columnDefaultEnvelope = new DataColumn("DefaultEnvelope", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultEnvelope);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsEnvelopesKey1", new DataColumn[1]
      {
        this.columnEnvelopeTypeID
      }, true));
      this.columnEnvelopeTypeID.AutoIncrement = true;
      this.columnEnvelopeTypeID.AllowDBNull = false;
      this.columnEnvelopeTypeID.ReadOnly = true;
      this.columnEnvelopeTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnHeight.AllowDBNull = false;
      this.columnWidth.AllowDBNull = false;
      this.columnDeliveryAddressFromLeft.AllowDBNull = false;
      this.columnDeliveryAddressFromTop.AllowDBNull = false;
      this.columnDeliveryAddressFromLeftMAX.AllowDBNull = false;
      this.columnDeliveryAddressFromTopMAX.AllowDBNull = false;
      this.columnDeliveryAddressFromLeftMIN.AllowDBNull = false;
      this.columnDeliveryAddressFromTopMIN.AllowDBNull = false;
      this.columnReturnAddressFromLeft.AllowDBNull = false;
      this.columnReturnAddressFromTop.AllowDBNull = false;
      this.columnReturnAddressFromLeftMAX.AllowDBNull = false;
      this.columnReturnAddressFromTopMAX.AllowDBNull = false;
      this.columnReturnAddressFromLeftMIN.AllowDBNull = false;
      this.columnReturnAddressFromTopMIN.AllowDBNull = false;
      this.columnDefaultEnvelope.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEnvelopes.tblEnvelopeTypesRow NewtblEnvelopeTypesRow()
    {
      return (dsEnvelopes.tblEnvelopeTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsEnvelopes.tblEnvelopeTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsEnvelopes.tblEnvelopeTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEnvelopeTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler typesRowChangedEvent = this.tblEnvelopeTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsEnvelopes.tblEnvelopeTypesRowChangeEvent((dsEnvelopes.tblEnvelopeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEnvelopeTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler rowChangingEvent = this.tblEnvelopeTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsEnvelopes.tblEnvelopeTypesRowChangeEvent((dsEnvelopes.tblEnvelopeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEnvelopeTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler typesRowDeletedEvent = this.tblEnvelopeTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsEnvelopes.tblEnvelopeTypesRowChangeEvent((dsEnvelopes.tblEnvelopeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEnvelopeTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEnvelopes.tblEnvelopeTypesRowChangeEventHandler rowDeletingEvent = this.tblEnvelopeTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsEnvelopes.tblEnvelopeTypesRowChangeEvent((dsEnvelopes.tblEnvelopeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblEnvelopeTypesRow(dsEnvelopes.tblEnvelopeTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsEnvelopes dsEnvelopes = new dsEnvelopes();
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
        FixedValue = dsEnvelopes.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblEnvelopeTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsEnvelopes.GetSchemaSerializable();
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

  public class tblEnvelopeTypesRow : DataRow
  {
    private dsEnvelopes.tblEnvelopeTypesDataTable tabletblEnvelopeTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblEnvelopeTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblEnvelopeTypes = (dsEnvelopes.tblEnvelopeTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int EnvelopeTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblEnvelopeTypes.EnvelopeTypeIDColumn]);
      set => this[this.tabletblEnvelopeTypes.EnvelopeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tabletblEnvelopeTypes.DescriptionColumn]);
      set => this[this.tabletblEnvelopeTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Height
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.HeightColumn]);
      set => this[this.tabletblEnvelopeTypes.HeightColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Width
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.WidthColumn]);
      set => this[this.tabletblEnvelopeTypes.WidthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeliveryAddressFromLeft
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.DeliveryAddressFromLeftColumn]);
      set => this[this.tabletblEnvelopeTypes.DeliveryAddressFromLeftColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeliveryAddressFromTop
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.DeliveryAddressFromTopColumn]);
      set => this[this.tabletblEnvelopeTypes.DeliveryAddressFromTopColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeliveryAddressFromLeftMAX
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.DeliveryAddressFromLeftMAXColumn]);
      }
      set => this[this.tabletblEnvelopeTypes.DeliveryAddressFromLeftMAXColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeliveryAddressFromTopMAX
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.DeliveryAddressFromTopMAXColumn]);
      }
      set => this[this.tabletblEnvelopeTypes.DeliveryAddressFromTopMAXColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeliveryAddressFromLeftMIN
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.DeliveryAddressFromLeftMINColumn]);
      }
      set => this[this.tabletblEnvelopeTypes.DeliveryAddressFromLeftMINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DeliveryAddressFromTopMIN
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.DeliveryAddressFromTopMINColumn]);
      }
      set => this[this.tabletblEnvelopeTypes.DeliveryAddressFromTopMINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ReturnAddressFromLeft
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.ReturnAddressFromLeftColumn]);
      set => this[this.tabletblEnvelopeTypes.ReturnAddressFromLeftColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ReturnAddressFromTop
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.ReturnAddressFromTopColumn]);
      set => this[this.tabletblEnvelopeTypes.ReturnAddressFromTopColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ReturnAddressFromLeftMAX
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.ReturnAddressFromLeftMAXColumn]);
      set => this[this.tabletblEnvelopeTypes.ReturnAddressFromLeftMAXColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ReturnAddressFromTopMAX
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.ReturnAddressFromTopMAXColumn]);
      set => this[this.tabletblEnvelopeTypes.ReturnAddressFromTopMAXColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ReturnAddressFromLeftMIN
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.ReturnAddressFromLeftMINColumn]);
      set => this[this.tabletblEnvelopeTypes.ReturnAddressFromLeftMINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ReturnAddressFromTopMIN
    {
      get => Conversions.ToDecimal(this[this.tabletblEnvelopeTypes.ReturnAddressFromTopMINColumn]);
      set => this[this.tabletblEnvelopeTypes.ReturnAddressFromTopMINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool DefaultEnvelope
    {
      get => Conversions.ToBoolean(this[this.tabletblEnvelopeTypes.DefaultEnvelopeColumn]);
      set => this[this.tabletblEnvelopeTypes.DefaultEnvelopeColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblEnvelopeTypesRowChangeEvent : EventArgs
  {
    private dsEnvelopes.tblEnvelopeTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblEnvelopeTypesRowChangeEvent(dsEnvelopes.tblEnvelopeTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEnvelopes.tblEnvelopeTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
