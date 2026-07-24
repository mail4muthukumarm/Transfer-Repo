// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Entities.AccountingSearchEntity
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
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Forms.Entities;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("AccountingSearchEntity")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class AccountingSearchEntity : DataSet
{
  private AccountingSearchEntity.spFin_SearchEntityDataTable tablespFin_SearchEntity;
  private AccountingSearchEntity.Table1DataTable tableTable1;
  private AccountingSearchEntity.Table2DataTable tableTable2;
  private AccountingSearchEntity.Table3DataTable tableTable3;
  private AccountingSearchEntity.Table4DataTable tableTable4;
  private AccountingSearchEntity.Table5DataTable tableTable5;
  private AccountingSearchEntity.Table6DataTable tableTable6;
  private AccountingSearchEntity.Table7DataTable tableTable7;
  private AccountingSearchEntity.Table8DataTable tableTable8;
  private AccountingSearchEntity.Table9DataTable tableTable9;
  private AccountingSearchEntity.BankInfoDataTable tableBankInfo;
  private AccountingSearchEntity._TableDataTable table_Table;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public AccountingSearchEntity()
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
  protected AccountingSearchEntity(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (spFin_SearchEntity)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.spFin_SearchEntityDataTable(dataSet.Tables[nameof (spFin_SearchEntity)]));
        if (dataSet.Tables[nameof (Table1)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table1DataTable(dataSet.Tables[nameof (Table1)]));
        if (dataSet.Tables[nameof (Table2)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table2DataTable(dataSet.Tables[nameof (Table2)]));
        if (dataSet.Tables[nameof (Table3)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table3DataTable(dataSet.Tables[nameof (Table3)]));
        if (dataSet.Tables[nameof (Table4)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table4DataTable(dataSet.Tables[nameof (Table4)]));
        if (dataSet.Tables[nameof (Table5)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table5DataTable(dataSet.Tables[nameof (Table5)]));
        if (dataSet.Tables[nameof (Table6)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table6DataTable(dataSet.Tables[nameof (Table6)]));
        if (dataSet.Tables[nameof (Table7)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table7DataTable(dataSet.Tables[nameof (Table7)]));
        if (dataSet.Tables[nameof (Table8)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table8DataTable(dataSet.Tables[nameof (Table8)]));
        if (dataSet.Tables[nameof (Table9)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.Table9DataTable(dataSet.Tables[nameof (Table9)]));
        if (dataSet.Tables[nameof (BankInfo)] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity.BankInfoDataTable(dataSet.Tables[nameof (BankInfo)]));
        if (dataSet.Tables["Table"] != null)
          base.Tables.Add((DataTable) new AccountingSearchEntity._TableDataTable(dataSet.Tables["Table"]));
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
  public AccountingSearchEntity.spFin_SearchEntityDataTable spFin_SearchEntity
  {
    get => this.tablespFin_SearchEntity;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table1DataTable Table1 => this.tableTable1;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table2DataTable Table2 => this.tableTable2;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table3DataTable Table3 => this.tableTable3;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table4DataTable Table4 => this.tableTable4;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table5DataTable Table5 => this.tableTable5;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table6DataTable Table6 => this.tableTable6;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table7DataTable Table7 => this.tableTable7;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table8DataTable Table8 => this.tableTable8;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table9DataTable Table9 => this.tableTable9;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.BankInfoDataTable BankInfo => this.tableBankInfo;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity._TableDataTable _Table => this.table_Table;

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
    AccountingSearchEntity accountingSearchEntity = (AccountingSearchEntity) base.Clone();
    accountingSearchEntity.InitVars();
    accountingSearchEntity.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) accountingSearchEntity;
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
      if (dataSet.Tables["spFin_SearchEntity"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.spFin_SearchEntityDataTable(dataSet.Tables["spFin_SearchEntity"]));
      if (dataSet.Tables["Table1"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table1DataTable(dataSet.Tables["Table1"]));
      if (dataSet.Tables["Table2"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table2DataTable(dataSet.Tables["Table2"]));
      if (dataSet.Tables["Table3"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table3DataTable(dataSet.Tables["Table3"]));
      if (dataSet.Tables["Table4"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table4DataTable(dataSet.Tables["Table4"]));
      if (dataSet.Tables["Table5"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table5DataTable(dataSet.Tables["Table5"]));
      if (dataSet.Tables["Table6"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table6DataTable(dataSet.Tables["Table6"]));
      if (dataSet.Tables["Table7"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table7DataTable(dataSet.Tables["Table7"]));
      if (dataSet.Tables["Table8"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table8DataTable(dataSet.Tables["Table8"]));
      if (dataSet.Tables["Table9"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.Table9DataTable(dataSet.Tables["Table9"]));
      if (dataSet.Tables["BankInfo"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity.BankInfoDataTable(dataSet.Tables["BankInfo"]));
      if (dataSet.Tables["Table"] != null)
        base.Tables.Add((DataTable) new AccountingSearchEntity._TableDataTable(dataSet.Tables["Table"]));
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
    this.tablespFin_SearchEntity = (AccountingSearchEntity.spFin_SearchEntityDataTable) base.Tables["spFin_SearchEntity"];
    if (initTable && this.tablespFin_SearchEntity != null)
      this.tablespFin_SearchEntity.InitVars();
    this.tableTable1 = (AccountingSearchEntity.Table1DataTable) base.Tables["Table1"];
    if (initTable && this.tableTable1 != null)
      this.tableTable1.InitVars();
    this.tableTable2 = (AccountingSearchEntity.Table2DataTable) base.Tables["Table2"];
    if (initTable && this.tableTable2 != null)
      this.tableTable2.InitVars();
    this.tableTable3 = (AccountingSearchEntity.Table3DataTable) base.Tables["Table3"];
    if (initTable && this.tableTable3 != null)
      this.tableTable3.InitVars();
    this.tableTable4 = (AccountingSearchEntity.Table4DataTable) base.Tables["Table4"];
    if (initTable && this.tableTable4 != null)
      this.tableTable4.InitVars();
    this.tableTable5 = (AccountingSearchEntity.Table5DataTable) base.Tables["Table5"];
    if (initTable && this.tableTable5 != null)
      this.tableTable5.InitVars();
    this.tableTable6 = (AccountingSearchEntity.Table6DataTable) base.Tables["Table6"];
    if (initTable && this.tableTable6 != null)
      this.tableTable6.InitVars();
    this.tableTable7 = (AccountingSearchEntity.Table7DataTable) base.Tables["Table7"];
    if (initTable && this.tableTable7 != null)
      this.tableTable7.InitVars();
    this.tableTable8 = (AccountingSearchEntity.Table8DataTable) base.Tables["Table8"];
    if (initTable && this.tableTable8 != null)
      this.tableTable8.InitVars();
    this.tableTable9 = (AccountingSearchEntity.Table9DataTable) base.Tables["Table9"];
    if (initTable && this.tableTable9 != null)
      this.tableTable9.InitVars();
    this.tableBankInfo = (AccountingSearchEntity.BankInfoDataTable) base.Tables["BankInfo"];
    if (initTable && this.tableBankInfo != null)
      this.tableBankInfo.InitVars();
    this.table_Table = (AccountingSearchEntity._TableDataTable) base.Tables["Table"];
    if (!initTable || this.table_Table == null)
      return;
    this.table_Table.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (AccountingSearchEntity);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/AccountingSearchEntity.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablespFin_SearchEntity = new AccountingSearchEntity.spFin_SearchEntityDataTable();
    base.Tables.Add((DataTable) this.tablespFin_SearchEntity);
    this.tableTable1 = new AccountingSearchEntity.Table1DataTable();
    base.Tables.Add((DataTable) this.tableTable1);
    this.tableTable2 = new AccountingSearchEntity.Table2DataTable();
    base.Tables.Add((DataTable) this.tableTable2);
    this.tableTable3 = new AccountingSearchEntity.Table3DataTable();
    base.Tables.Add((DataTable) this.tableTable3);
    this.tableTable4 = new AccountingSearchEntity.Table4DataTable();
    base.Tables.Add((DataTable) this.tableTable4);
    this.tableTable5 = new AccountingSearchEntity.Table5DataTable();
    base.Tables.Add((DataTable) this.tableTable5);
    this.tableTable6 = new AccountingSearchEntity.Table6DataTable();
    base.Tables.Add((DataTable) this.tableTable6);
    this.tableTable7 = new AccountingSearchEntity.Table7DataTable();
    base.Tables.Add((DataTable) this.tableTable7);
    this.tableTable8 = new AccountingSearchEntity.Table8DataTable();
    base.Tables.Add((DataTable) this.tableTable8);
    this.tableTable9 = new AccountingSearchEntity.Table9DataTable();
    base.Tables.Add((DataTable) this.tableTable9);
    this.tableBankInfo = new AccountingSearchEntity.BankInfoDataTable();
    base.Tables.Add((DataTable) this.tableBankInfo);
    this.table_Table = new AccountingSearchEntity._TableDataTable();
    base.Tables.Add((DataTable) this.table_Table);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializespFin_SearchEntity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable1() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable2() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable3() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable4() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable5() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable6() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable7() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable8() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTable9() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeBankInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerialize_Table() => false;

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
    AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = accountingSearchEntity.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public delegate void spFin_SearchEntityRowChangeEventHandler(
    object sender,
    AccountingSearchEntity.spFin_SearchEntityRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table1RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table1RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table2RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table2RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table3RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table3RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table4RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table4RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table5RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table5RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table6RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table6RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table7RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table7RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table8RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table8RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void Table9RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table9RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void BankInfoRowChangeEventHandler(
    object sender,
    AccountingSearchEntity.BankInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void _TableRowChangeEventHandler(
    object sender,
    AccountingSearchEntity._TableRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class spFin_SearchEntityDataTable : 
    TypedTableBase<AccountingSearchEntity.spFin_SearchEntityRow>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spFin_SearchEntityDataTable()
    {
      this.TableName = "spFin_SearchEntity";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spFin_SearchEntityDataTable(DataTable table)
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
    protected spFin_SearchEntityDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.spFin_SearchEntityRow this[int index]
    {
      get => (AccountingSearchEntity.spFin_SearchEntityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddspFin_SearchEntityRow(AccountingSearchEntity.spFin_SearchEntityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.spFin_SearchEntityRow AddspFin_SearchEntityRow(
      string Entity_Name,
      Guid EntityGUID)
    {
      AccountingSearchEntity.spFin_SearchEntityRow row = (AccountingSearchEntity.spFin_SearchEntityRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.spFin_SearchEntityDataTable searchEntityDataTable = (AccountingSearchEntity.spFin_SearchEntityDataTable) base.Clone();
      searchEntityDataTable.InitVars();
      return (DataTable) searchEntityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.spFin_SearchEntityDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.ReadOnly = true;
      this.columnEntityGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.spFin_SearchEntityRow NewspFin_SearchEntityRow()
    {
      return (AccountingSearchEntity.spFin_SearchEntityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.spFin_SearchEntityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.spFin_SearchEntityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler entityRowChangedEvent = this.spFin_SearchEntityRowChangedEvent;
      if (entityRowChangedEvent == null)
        return;
      entityRowChangedEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler rowChangingEvent = this.spFin_SearchEntityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler entityRowDeletedEvent = this.spFin_SearchEntityRowDeletedEvent;
      if (entityRowDeletedEvent == null)
        return;
      entityRowDeletedEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler rowDeletingEvent = this.spFin_SearchEntityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovespFin_SearchEntityRow(AccountingSearchEntity.spFin_SearchEntityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_SearchEntityDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table1DataTable : TypedTableBase<AccountingSearchEntity.Table1Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table1DataTable()
    {
      this.TableName = "Table1";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table1DataTable(DataTable table)
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
    protected Table1DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table1Row this[int index]
    {
      get => (AccountingSearchEntity.Table1Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable1Row(AccountingSearchEntity.Table1Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table1Row AddTable1Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table1Row row = (AccountingSearchEntity.Table1Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table1DataTable table1DataTable = (AccountingSearchEntity.Table1DataTable) base.Clone();
      table1DataTable.InitVars();
      return (DataTable) table1DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table1DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.ReadOnly = true;
      this.columnEntityGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table1Row NewTable1Row()
    {
      return (AccountingSearchEntity.Table1Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table1Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table1Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler table1RowChangedEvent = this.Table1RowChangedEvent;
      if (table1RowChangedEvent == null)
        return;
      table1RowChangedEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler rowChangingEvent = this.Table1RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler table1RowDeletedEvent = this.Table1RowDeletedEvent;
      if (table1RowDeletedEvent == null)
        return;
      table1RowDeletedEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler rowDeletingEvent = this.Table1RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable1Row(AccountingSearchEntity.Table1Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table1DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table2DataTable : TypedTableBase<AccountingSearchEntity.Table2Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table2DataTable()
    {
      this.TableName = "Table2";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table2DataTable(DataTable table)
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
    protected Table2DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table2Row this[int index]
    {
      get => (AccountingSearchEntity.Table2Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable2Row(AccountingSearchEntity.Table2Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table2Row AddTable2Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table2Row row = (AccountingSearchEntity.Table2Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table2Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table2Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table2DataTable table2DataTable = (AccountingSearchEntity.Table2DataTable) base.Clone();
      table2DataTable.InitVars();
      return (DataTable) table2DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table2DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table2Row NewTable2Row()
    {
      return (AccountingSearchEntity.Table2Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table2Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table2Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler table2RowChangedEvent = this.Table2RowChangedEvent;
      if (table2RowChangedEvent == null)
        return;
      table2RowChangedEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler rowChangingEvent = this.Table2RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler table2RowDeletedEvent = this.Table2RowDeletedEvent;
      if (table2RowDeletedEvent == null)
        return;
      table2RowDeletedEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler rowDeletingEvent = this.Table2RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable2Row(AccountingSearchEntity.Table2Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table2DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table3DataTable : TypedTableBase<AccountingSearchEntity.Table3Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table3DataTable()
    {
      this.TableName = "Table3";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table3DataTable(DataTable table)
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
    protected Table3DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table3Row this[int index]
    {
      get => (AccountingSearchEntity.Table3Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable3Row(AccountingSearchEntity.Table3Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table3Row AddTable3Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table3Row row = (AccountingSearchEntity.Table3Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table3Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table3Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table3DataTable table3DataTable = (AccountingSearchEntity.Table3DataTable) base.Clone();
      table3DataTable.InitVars();
      return (DataTable) table3DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table3DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table3Row NewTable3Row()
    {
      return (AccountingSearchEntity.Table3Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table3Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table3Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler table3RowChangedEvent = this.Table3RowChangedEvent;
      if (table3RowChangedEvent == null)
        return;
      table3RowChangedEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler rowChangingEvent = this.Table3RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler table3RowDeletedEvent = this.Table3RowDeletedEvent;
      if (table3RowDeletedEvent == null)
        return;
      table3RowDeletedEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler rowDeletingEvent = this.Table3RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable3Row(AccountingSearchEntity.Table3Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table3DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table4DataTable : TypedTableBase<AccountingSearchEntity.Table4Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table4DataTable()
    {
      this.TableName = "Table4";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table4DataTable(DataTable table)
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
    protected Table4DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table4Row this[int index]
    {
      get => (AccountingSearchEntity.Table4Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable4Row(AccountingSearchEntity.Table4Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table4Row AddTable4Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table4Row row = (AccountingSearchEntity.Table4Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table4Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table4Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table4DataTable table4DataTable = (AccountingSearchEntity.Table4DataTable) base.Clone();
      table4DataTable.InitVars();
      return (DataTable) table4DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table4DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table4Row NewTable4Row()
    {
      return (AccountingSearchEntity.Table4Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table4Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table4Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler table4RowChangedEvent = this.Table4RowChangedEvent;
      if (table4RowChangedEvent == null)
        return;
      table4RowChangedEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler rowChangingEvent = this.Table4RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler table4RowDeletedEvent = this.Table4RowDeletedEvent;
      if (table4RowDeletedEvent == null)
        return;
      table4RowDeletedEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler rowDeletingEvent = this.Table4RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable4Row(AccountingSearchEntity.Table4Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table4DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table5DataTable : TypedTableBase<AccountingSearchEntity.Table5Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table5DataTable()
    {
      this.TableName = "Table5";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table5DataTable(DataTable table)
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
    protected Table5DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table5Row this[int index]
    {
      get => (AccountingSearchEntity.Table5Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable5Row(AccountingSearchEntity.Table5Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table5Row AddTable5Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table5Row row = (AccountingSearchEntity.Table5Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table5Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table5Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table5DataTable table5DataTable = (AccountingSearchEntity.Table5DataTable) base.Clone();
      table5DataTable.InitVars();
      return (DataTable) table5DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table5DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table5Row NewTable5Row()
    {
      return (AccountingSearchEntity.Table5Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table5Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table5Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler table5RowChangedEvent = this.Table5RowChangedEvent;
      if (table5RowChangedEvent == null)
        return;
      table5RowChangedEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler rowChangingEvent = this.Table5RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler table5RowDeletedEvent = this.Table5RowDeletedEvent;
      if (table5RowDeletedEvent == null)
        return;
      table5RowDeletedEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler rowDeletingEvent = this.Table5RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable5Row(AccountingSearchEntity.Table5Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table5DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table6DataTable : TypedTableBase<AccountingSearchEntity.Table6Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table6DataTable()
    {
      this.TableName = "Table6";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table6DataTable(DataTable table)
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
    protected Table6DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table6Row this[int index]
    {
      get => (AccountingSearchEntity.Table6Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable6Row(AccountingSearchEntity.Table6Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table6Row AddTable6Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table6Row row = (AccountingSearchEntity.Table6Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table6Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table6Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table6DataTable table6DataTable = (AccountingSearchEntity.Table6DataTable) base.Clone();
      table6DataTable.InitVars();
      return (DataTable) table6DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table6DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table6Row NewTable6Row()
    {
      return (AccountingSearchEntity.Table6Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table6Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table6Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler table6RowChangedEvent = this.Table6RowChangedEvent;
      if (table6RowChangedEvent == null)
        return;
      table6RowChangedEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler rowChangingEvent = this.Table6RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler table6RowDeletedEvent = this.Table6RowDeletedEvent;
      if (table6RowDeletedEvent == null)
        return;
      table6RowDeletedEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler rowDeletingEvent = this.Table6RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable6Row(AccountingSearchEntity.Table6Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table6DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table7DataTable : TypedTableBase<AccountingSearchEntity.Table7Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table7DataTable()
    {
      this.TableName = "Table7";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table7DataTable(DataTable table)
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
    protected Table7DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table7Row this[int index]
    {
      get => (AccountingSearchEntity.Table7Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable7Row(AccountingSearchEntity.Table7Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table7Row AddTable7Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table7Row row = (AccountingSearchEntity.Table7Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table7Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table7Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table7DataTable table7DataTable = (AccountingSearchEntity.Table7DataTable) base.Clone();
      table7DataTable.InitVars();
      return (DataTable) table7DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table7DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table7Row NewTable7Row()
    {
      return (AccountingSearchEntity.Table7Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table7Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table7Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler table7RowChangedEvent = this.Table7RowChangedEvent;
      if (table7RowChangedEvent == null)
        return;
      table7RowChangedEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler rowChangingEvent = this.Table7RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler table7RowDeletedEvent = this.Table7RowDeletedEvent;
      if (table7RowDeletedEvent == null)
        return;
      table7RowDeletedEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler rowDeletingEvent = this.Table7RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable7Row(AccountingSearchEntity.Table7Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table7DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table8DataTable : TypedTableBase<AccountingSearchEntity.Table8Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table8DataTable()
    {
      this.TableName = "Table8";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table8DataTable(DataTable table)
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
    protected Table8DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table8Row this[int index]
    {
      get => (AccountingSearchEntity.Table8Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable8Row(AccountingSearchEntity.Table8Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table8Row AddTable8Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table8Row row = (AccountingSearchEntity.Table8Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table8DataTable table8DataTable = (AccountingSearchEntity.Table8DataTable) base.Clone();
      table8DataTable.InitVars();
      return (DataTable) table8DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table8DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table8Row NewTable8Row()
    {
      return (AccountingSearchEntity.Table8Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table8Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table8Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler table8RowChangedEvent = this.Table8RowChangedEvent;
      if (table8RowChangedEvent == null)
        return;
      table8RowChangedEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler rowChangingEvent = this.Table8RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler table8RowDeletedEvent = this.Table8RowDeletedEvent;
      if (table8RowDeletedEvent == null)
        return;
      table8RowDeletedEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler rowDeletingEvent = this.Table8RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable8Row(AccountingSearchEntity.Table8Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table8DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class Table9DataTable : TypedTableBase<AccountingSearchEntity.Table9Row>
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table9DataTable()
    {
      this.TableName = "Table9";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table9DataTable(DataTable table)
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
    protected Table9DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Entity_NameColumn => this.columnEntity_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table9Row this[int index]
    {
      get => (AccountingSearchEntity.Table9Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTable9Row(AccountingSearchEntity.Table9Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table9Row AddTable9Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table9Row row = (AccountingSearchEntity.Table9Row) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.Table9DataTable table9DataTable = (AccountingSearchEntity.Table9DataTable) base.Clone();
      table9DataTable.InitVars();
      return (DataTable) table9DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table9DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table9Row NewTable9Row()
    {
      return (AccountingSearchEntity.Table9Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table9Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table9Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler table9RowChangedEvent = this.Table9RowChangedEvent;
      if (table9RowChangedEvent == null)
        return;
      table9RowChangedEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler rowChangingEvent = this.Table9RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler table9RowDeletedEvent = this.Table9RowDeletedEvent;
      if (table9RowDeletedEvent == null)
        return;
      table9RowDeletedEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler rowDeletingEvent = this.Table9RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTable9Row(AccountingSearchEntity.Table9Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Table9DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class BankInfoDataTable : TypedTableBase<AccountingSearchEntity.BankInfoRow>
  {
    private DataColumn columnBankAcctTypeID;
    private DataColumn columnBankAcctNum;
    private DataColumn columnABARouteNum;
    private DataColumn columnGLAcctID;
    private DataColumn columnNextCheckNum;
    private DataColumn columnBankName;
    private DataColumn columnAddr1;
    private DataColumn columnAddr2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnZipExt;
    private DataColumn columnContactName;
    private DataColumn columnContactFax;
    private DataColumn columnContactPhone;
    private DataColumn columnContactEmail;
    private DataColumn columnUpdated;
    private DataColumn columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public BankInfoDataTable()
    {
      this.TableName = "BankInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal BankInfoDataTable(DataTable table)
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
    protected BankInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BankAcctTypeIDColumn => this.columnBankAcctTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BankAcctNumColumn => this.columnBankAcctNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ABARouteNumColumn => this.columnABARouteNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAcctIDColumn => this.columnGLAcctID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NextCheckNumColumn => this.columnNextCheckNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BankNameColumn => this.columnBankName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Addr1Column => this.columnAddr1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Addr2Column => this.columnAddr2;

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
    public DataColumn ZipExtColumn => this.columnZipExt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactNameColumn => this.columnContactName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactFaxColumn => this.columnContactFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactPhoneColumn => this.columnContactPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactEmailColumn => this.columnContactEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UpdatedColumn => this.columnUpdated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.BankInfoRow this[int index]
    {
      get => (AccountingSearchEntity.BankInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddBankInfoRow(AccountingSearchEntity.BankInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.BankInfoRow AddBankInfoRow(
      string BankAcctTypeID,
      string BankAcctNum,
      string ABARouteNum,
      int GLAcctID,
      int NextCheckNum,
      string BankName,
      string Addr1,
      string Addr2,
      string City,
      string State,
      string Zip,
      string ZipExt,
      string ContactName,
      string ContactFax,
      string ContactPhone,
      string ContactEmail,
      DateTime Updated,
      Guid UserGUID)
    {
      AccountingSearchEntity.BankInfoRow row = (AccountingSearchEntity.BankInfoRow) this.NewRow();
      object[] objArray = new object[18]
      {
        (object) BankAcctTypeID,
        (object) BankAcctNum,
        (object) ABARouteNum,
        (object) GLAcctID,
        (object) NextCheckNum,
        (object) BankName,
        (object) Addr1,
        (object) Addr2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ZipExt,
        (object) ContactName,
        (object) ContactFax,
        (object) ContactPhone,
        (object) ContactEmail,
        (object) Updated,
        (object) UserGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.BankInfoRow FindByBankAcctTypeIDBankAcctNum(
      string BankAcctTypeID,
      string BankAcctNum)
    {
      return (AccountingSearchEntity.BankInfoRow) this.Rows.Find(new object[2]
      {
        (object) BankAcctTypeID,
        (object) BankAcctNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity.BankInfoDataTable bankInfoDataTable = (AccountingSearchEntity.BankInfoDataTable) base.Clone();
      bankInfoDataTable.InitVars();
      return (DataTable) bankInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.BankInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnBankAcctTypeID = this.Columns["BankAcctTypeID"];
      this.columnBankAcctNum = this.Columns["BankAcctNum"];
      this.columnABARouteNum = this.Columns["ABARouteNum"];
      this.columnGLAcctID = this.Columns["GLAcctID"];
      this.columnNextCheckNum = this.Columns["NextCheckNum"];
      this.columnBankName = this.Columns["BankName"];
      this.columnAddr1 = this.Columns["Addr1"];
      this.columnAddr2 = this.Columns["Addr2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnZipExt = this.Columns["ZipExt"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnContactFax = this.Columns["ContactFax"];
      this.columnContactPhone = this.Columns["ContactPhone"];
      this.columnContactEmail = this.Columns["ContactEmail"];
      this.columnUpdated = this.Columns["Updated"];
      this.columnUserGUID = this.Columns["UserGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnBankAcctTypeID = new DataColumn("BankAcctTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctTypeID);
      this.columnBankAcctNum = new DataColumn("BankAcctNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctNum);
      this.columnABARouteNum = new DataColumn("ABARouteNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnABARouteNum);
      this.columnGLAcctID = new DataColumn("GLAcctID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctID);
      this.columnNextCheckNum = new DataColumn("NextCheckNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNextCheckNum);
      this.columnBankName = new DataColumn("BankName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankName);
      this.columnAddr1 = new DataColumn("Addr1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddr1);
      this.columnAddr2 = new DataColumn("Addr2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddr2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnZipExt = new DataColumn("ZipExt", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipExt);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnContactFax = new DataColumn("ContactFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactFax);
      this.columnContactPhone = new DataColumn("ContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactPhone);
      this.columnContactEmail = new DataColumn("ContactEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactEmail);
      this.columnUpdated = new DataColumn("Updated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUpdated);
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnBankAcctTypeID,
        this.columnBankAcctNum
      }, true));
      this.columnBankAcctTypeID.AllowDBNull = false;
      this.columnBankAcctNum.AllowDBNull = false;
      this.columnGLAcctID.AllowDBNull = false;
      this.columnBankName.AllowDBNull = false;
      this.columnAddr1.AllowDBNull = false;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnZip.AllowDBNull = false;
      this.columnUpdated.AllowDBNull = false;
      this.columnUserGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.BankInfoRow NewBankInfoRow()
    {
      return (AccountingSearchEntity.BankInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.BankInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity.BankInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler infoRowChangedEvent = this.BankInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler rowChangingEvent = this.BankInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler infoRowDeletedEvent = this.BankInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler rowDeletingEvent = this.BankInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveBankInfoRow(AccountingSearchEntity.BankInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (BankInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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
  public class _TableDataTable : TypedTableBase<AccountingSearchEntity._TableRow>
  {
    private DataColumn columnBankAcctTypeID;
    private DataColumn columnBankAcctType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public _TableDataTable()
    {
      this.TableName = "Table";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal _TableDataTable(DataTable table)
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
    protected _TableDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BankAcctTypeIDColumn => this.columnBankAcctTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BankAcctTypeColumn => this.columnBankAcctType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity._TableRow this[int index]
    {
      get => (AccountingSearchEntity._TableRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Add_TableRow(AccountingSearchEntity._TableRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity._TableRow Add_TableRow(string BankAcctTypeID, string BankAcctType)
    {
      AccountingSearchEntity._TableRow row = (AccountingSearchEntity._TableRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) BankAcctTypeID,
        (object) BankAcctType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity._TableRow FindByBankAcctTypeID(string BankAcctTypeID)
    {
      return (AccountingSearchEntity._TableRow) this.Rows.Find(new object[1]
      {
        (object) BankAcctTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      AccountingSearchEntity._TableDataTable tableDataTable = (AccountingSearchEntity._TableDataTable) base.Clone();
      tableDataTable.InitVars();
      return (DataTable) tableDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity._TableDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnBankAcctTypeID = this.Columns["BankAcctTypeID"];
      this.columnBankAcctType = this.Columns["BankAcctType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnBankAcctTypeID = new DataColumn("BankAcctTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctTypeID);
      this.columnBankAcctType = new DataColumn("BankAcctType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnBankAcctTypeID
      }, true));
      this.columnBankAcctTypeID.AllowDBNull = false;
      this.columnBankAcctTypeID.Unique = true;
      this.columnBankAcctType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity._TableRow New_TableRow()
    {
      return (AccountingSearchEntity._TableRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity._TableRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (AccountingSearchEntity._TableRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler tableRowChangedEvent = this._TableRowChangedEvent;
      if (tableRowChangedEvent == null)
        return;
      tableRowChangedEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler rowChangingEvent = this._TableRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler tableRowDeletedEvent = this._TableRowDeletedEvent;
      if (tableRowDeletedEvent == null)
        return;
      tableRowDeletedEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler rowDeletingEvent = this._TableRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Remove_TableRow(AccountingSearchEntity._TableRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      AccountingSearchEntity accountingSearchEntity = new AccountingSearchEntity();
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
        FixedValue = accountingSearchEntity.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (_TableDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountingSearchEntity.GetSchemaSerializable();
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

  public class spFin_SearchEntityRow : DataRow
  {
    private AccountingSearchEntity.spFin_SearchEntityDataTable tablespFin_SearchEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spFin_SearchEntityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_SearchEntity = (AccountingSearchEntity.spFin_SearchEntityDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_SearchEntity.Entity_NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Entity Name' in table 'spFin_SearchEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_SearchEntity.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tablespFin_SearchEntity.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablespFin_SearchEntity.EntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEntity_NameNull() => this.IsNull(this.tablespFin_SearchEntity.Entity_NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEntity_NameNull()
    {
      this[this.tablespFin_SearchEntity.Entity_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class Table1Row : DataRow
  {
    private AccountingSearchEntity.Table1DataTable tableTable1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table1Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable1 = (AccountingSearchEntity.Table1DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.Entity_NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Entity Name' in table 'Table1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable1.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable1.EntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEntity_NameNull() => this.IsNull(this.tableTable1.Entity_NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEntity_NameNull()
    {
      this[this.tableTable1.Entity_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class Table2Row : DataRow
  {
    private AccountingSearchEntity.Table2DataTable tableTable2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table2Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable2 = (AccountingSearchEntity.Table2DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable2.Entity_NameColumn]);
      set => this[this.tableTable2.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable2.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable2.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table3Row : DataRow
  {
    private AccountingSearchEntity.Table3DataTable tableTable3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table3Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable3 = (AccountingSearchEntity.Table3DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable3.Entity_NameColumn]);
      set => this[this.tableTable3.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable3.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable3.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table4Row : DataRow
  {
    private AccountingSearchEntity.Table4DataTable tableTable4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table4Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable4 = (AccountingSearchEntity.Table4DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable4.Entity_NameColumn]);
      set => this[this.tableTable4.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable4.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable4.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table5Row : DataRow
  {
    private AccountingSearchEntity.Table5DataTable tableTable5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table5Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable5 = (AccountingSearchEntity.Table5DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable5.Entity_NameColumn]);
      set => this[this.tableTable5.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable5.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable5.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table6Row : DataRow
  {
    private AccountingSearchEntity.Table6DataTable tableTable6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table6Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable6 = (AccountingSearchEntity.Table6DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable6.Entity_NameColumn]);
      set => this[this.tableTable6.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable6.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable6.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table7Row : DataRow
  {
    private AccountingSearchEntity.Table7DataTable tableTable7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table7Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable7 = (AccountingSearchEntity.Table7DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable7.Entity_NameColumn]);
      set => this[this.tableTable7.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable7.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable7.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table8Row : DataRow
  {
    private AccountingSearchEntity.Table8DataTable tableTable8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table8Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable8 = (AccountingSearchEntity.Table8DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable8.Entity_NameColumn]);
      set => this[this.tableTable8.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable8.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable8.EntityGUIDColumn] = (object) value;
    }
  }

  public class Table9Row : DataRow
  {
    private AccountingSearchEntity.Table9DataTable tableTable9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal Table9Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable9 = (AccountingSearchEntity.Table9DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable9.Entity_NameColumn]);
      set => this[this.tableTable9.Entity_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable9.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable9.EntityGUIDColumn] = (object) value;
    }
  }

  public class BankInfoRow : DataRow
  {
    private AccountingSearchEntity.BankInfoDataTable tableBankInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal BankInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBankInfo = (AccountingSearchEntity.BankInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BankAcctTypeID
    {
      get => Conversions.ToString(this[this.tableBankInfo.BankAcctTypeIDColumn]);
      set => this[this.tableBankInfo.BankAcctTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BankAcctNum
    {
      get => Conversions.ToString(this[this.tableBankInfo.BankAcctNumColumn]);
      set => this[this.tableBankInfo.BankAcctNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ABARouteNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ABARouteNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ABARouteNum' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ABARouteNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLAcctID
    {
      get => Conversions.ToInteger(this[this.tableBankInfo.GLAcctIDColumn]);
      set => this[this.tableBankInfo.GLAcctIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NextCheckNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableBankInfo.NextCheckNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NextCheckNum' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.NextCheckNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BankName
    {
      get => Conversions.ToString(this[this.tableBankInfo.BankNameColumn]);
      set => this[this.tableBankInfo.BankNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Addr1
    {
      get => Conversions.ToString(this[this.tableBankInfo.Addr1Column]);
      set => this[this.tableBankInfo.Addr1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Addr2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.Addr2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Addr2' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.Addr2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tableBankInfo.CityColumn]);
      set => this[this.tableBankInfo.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tableBankInfo.StateColumn]);
      set => this[this.tableBankInfo.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tableBankInfo.ZipColumn]);
      set => this[this.tableBankInfo.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipExt
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ZipExtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipExt' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ZipExtColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactName' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactFax' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactPhone' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactEmail' in table 'BankInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Updated
    {
      get => Conversions.ToDate(this[this.tableBankInfo.UpdatedColumn]);
      set => this[this.tableBankInfo.UpdatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tableBankInfo.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableBankInfo.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsABARouteNumNull() => this.IsNull(this.tableBankInfo.ABARouteNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetABARouteNumNull()
    {
      this[this.tableBankInfo.ABARouteNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNextCheckNumNull() => this.IsNull(this.tableBankInfo.NextCheckNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNextCheckNumNull()
    {
      this[this.tableBankInfo.NextCheckNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddr2Null() => this.IsNull(this.tableBankInfo.Addr2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddr2Null()
    {
      this[this.tableBankInfo.Addr2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipExtNull() => this.IsNull(this.tableBankInfo.ZipExtColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipExtNull()
    {
      this[this.tableBankInfo.ZipExtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactNameNull() => this.IsNull(this.tableBankInfo.ContactNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactNameNull()
    {
      this[this.tableBankInfo.ContactNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactFaxNull() => this.IsNull(this.tableBankInfo.ContactFaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactFaxNull()
    {
      this[this.tableBankInfo.ContactFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactPhoneNull() => this.IsNull(this.tableBankInfo.ContactPhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactPhoneNull()
    {
      this[this.tableBankInfo.ContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactEmailNull() => this.IsNull(this.tableBankInfo.ContactEmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactEmailNull()
    {
      this[this.tableBankInfo.ContactEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class _TableRow : DataRow
  {
    private AccountingSearchEntity._TableDataTable table_Table;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal _TableRow(DataRowBuilder rb)
      : base(rb)
    {
      this.table_Table = (AccountingSearchEntity._TableDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BankAcctTypeID
    {
      get => Conversions.ToString(this[this.table_Table.BankAcctTypeIDColumn]);
      set => this[this.table_Table.BankAcctTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BankAcctType
    {
      get => Conversions.ToString(this[this.table_Table.BankAcctTypeColumn]);
      set => this[this.table_Table.BankAcctTypeColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class spFin_SearchEntityRowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.spFin_SearchEntityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spFin_SearchEntityRowChangeEvent(
      AccountingSearchEntity.spFin_SearchEntityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.spFin_SearchEntityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table1RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table1Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table1RowChangeEvent(AccountingSearchEntity.Table1Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table1Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table2RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table2Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table2RowChangeEvent(AccountingSearchEntity.Table2Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table2Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table3RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table3Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table3RowChangeEvent(AccountingSearchEntity.Table3Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table3Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table4RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table4Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table4RowChangeEvent(AccountingSearchEntity.Table4Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table4Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table5RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table5Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table5RowChangeEvent(AccountingSearchEntity.Table5Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table5Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table6RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table6Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table6RowChangeEvent(AccountingSearchEntity.Table6Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table6Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table7RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table7Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table7RowChangeEvent(AccountingSearchEntity.Table7Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table7Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table8RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table8Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table8RowChangeEvent(AccountingSearchEntity.Table8Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table8Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class Table9RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table9Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Table9RowChangeEvent(AccountingSearchEntity.Table9Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.Table9Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class BankInfoRowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.BankInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public BankInfoRowChangeEvent(AccountingSearchEntity.BankInfoRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity.BankInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class _TableRowChangeEvent : EventArgs
  {
    private AccountingSearchEntity._TableRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public _TableRowChangeEvent(AccountingSearchEntity._TableRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountingSearchEntity._TableRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
