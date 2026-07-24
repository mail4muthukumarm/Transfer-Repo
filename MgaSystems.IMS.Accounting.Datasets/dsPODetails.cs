// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[DebuggerStepThrough]
[ToolboxItem(true)]
[Serializable]
public class dsPODetails : DataSet
{
  private MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable tabledsPODetails;

  public dsPODetails()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPODetails(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (dsPODetails)] != null)
        this.Tables.Add((DataTable) new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable(dataSet.Tables[nameof (dsPODetails)]));
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
      this.InitClass();
    this.GetSerializationData(info, context);
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable dsPODetails
  {
    get => this.tabledsPODetails;
  }

  public override DataSet Clone()
  {
    MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails dsPoDetails = (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails) base.Clone();
    dsPoDetails.InitVars();
    return (DataSet) dsPoDetails;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables[nameof (dsPODetails)] != null)
      this.Tables.Add((DataTable) new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable(dataSet.Tables[nameof (dsPODetails)]));
    this.DataSetName = dataSet.DataSetName;
    this.Prefix = dataSet.Prefix;
    this.Namespace = dataSet.Namespace;
    this.Locale = dataSet.Locale;
    this.CaseSensitive = dataSet.CaseSensitive;
    this.EnforceConstraints = dataSet.EnforceConstraints;
    this.Merge(dataSet, false, MissingSchemaAction.Add);
    this.InitVars();
  }

  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  internal void InitVars()
  {
    this.tabledsPODetails = (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable) this.Tables[nameof (dsPODetails)];
    if (this.tabledsPODetails == null)
      return;
    this.tabledsPODetails.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPODetails);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPODetails.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tabledsPODetails = new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable();
    this.Tables.Add((DataTable) this.tabledsPODetails);
  }

  private bool ShouldSerializedsPODetails() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void dsPODetailsRowChangeEventHandler(
    object sender,
    MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEvent e);

  [DebuggerStepThrough]
  public class dsPODetailsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPONUM;
    private DataColumn columnEXPENSECODE;
    private DataColumn columnEXPENSENAME;
    private DataColumn columnGLACCTID;
    private DataColumn columnGLACCTFULLNAME;
    private DataColumn columnAMOUNT;
    private DataColumn columnDISCOUNT;
    private DataColumn columnGLCOMPANYID;
    private DataColumn columnCOSTCENTERID;
    private DataColumn columnEXPENSEFOR;
    private DataColumn columnEXPENSEDATE;
    private DataColumn columnCOSTCENTERNAME;
    private DataColumn columnISCOMMISSION;

    internal dsPODetailsDataTable()
      : base(nameof (dsPODetails))
    {
      this.InitClass();
    }

    internal dsPODetailsDataTable(DataTable table)
      : base(table.TableName)
    {
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
      this.DisplayExpression = table.DisplayExpression;
    }

    [Browsable(false)]
    public int Count => this.Rows.Count;

    internal DataColumn PONUMColumn => this.columnPONUM;

    internal DataColumn EXPENSECODEColumn => this.columnEXPENSECODE;

    internal DataColumn EXPENSENAMEColumn => this.columnEXPENSENAME;

    internal DataColumn GLACCTIDColumn => this.columnGLACCTID;

    internal DataColumn GLACCTFULLNAMEColumn => this.columnGLACCTFULLNAME;

    internal DataColumn AMOUNTColumn => this.columnAMOUNT;

    internal DataColumn DISCOUNTColumn => this.columnDISCOUNT;

    internal DataColumn GLCOMPANYIDColumn => this.columnGLCOMPANYID;

    internal DataColumn COSTCENTERIDColumn => this.columnCOSTCENTERID;

    internal DataColumn EXPENSEFORColumn => this.columnEXPENSEFOR;

    internal DataColumn EXPENSEDATEColumn => this.columnEXPENSEDATE;

    internal DataColumn COSTCENTERNAMEColumn => this.columnCOSTCENTERNAME;

    internal DataColumn ISCOMMISSIONColumn => this.columnISCOMMISSION;

    public MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow this[int index]
    {
      get => (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) this.Rows[index];
    }

    public event MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler dsPODetailsRowChanged;

    public event MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler dsPODetailsRowChanging;

    public event MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler dsPODetailsRowDeleted;

    public event MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler dsPODetailsRowDeleting;

    public void AdddsPODetailsRow(MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow AdddsPODetailsRow(
      int PONUM,
      int EXPENSECODE,
      string EXPENSENAME,
      int GLACCTID,
      string GLACCTFULLNAME,
      Decimal AMOUNT,
      Decimal DISCOUNT,
      int GLCOMPANYID,
      int COSTCENTERID,
      string EXPENSEFOR,
      DateTime EXPENSEDATE,
      string COSTCENTERNAME,
      bool ISCOMMISSION)
    {
      MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow row = (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) this.NewRow();
      row.ItemArray = new object[13]
      {
        (object) PONUM,
        (object) EXPENSECODE,
        (object) EXPENSENAME,
        (object) GLACCTID,
        (object) GLACCTFULLNAME,
        (object) AMOUNT,
        (object) DISCOUNT,
        (object) GLCOMPANYID,
        (object) COSTCENTERID,
        (object) EXPENSEFOR,
        (object) EXPENSEDATE,
        (object) COSTCENTERNAME,
        (object) ISCOMMISSION
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable detailsDataTable = (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable();
    }

    internal void InitVars()
    {
      this.columnPONUM = this.Columns["PONUM"];
      this.columnEXPENSECODE = this.Columns["EXPENSECODE"];
      this.columnEXPENSENAME = this.Columns["EXPENSENAME"];
      this.columnGLACCTID = this.Columns["GLACCTID"];
      this.columnGLACCTFULLNAME = this.Columns["GLACCTFULLNAME"];
      this.columnAMOUNT = this.Columns["AMOUNT"];
      this.columnDISCOUNT = this.Columns["DISCOUNT"];
      this.columnGLCOMPANYID = this.Columns["GLCOMPANYID"];
      this.columnCOSTCENTERID = this.Columns["COSTCENTERID"];
      this.columnEXPENSEFOR = this.Columns["EXPENSEFOR"];
      this.columnEXPENSEDATE = this.Columns["EXPENSEDATE"];
      this.columnCOSTCENTERNAME = this.Columns["COSTCENTERNAME"];
      this.columnISCOMMISSION = this.Columns["ISCOMMISSION"];
    }

    private void InitClass()
    {
      this.columnPONUM = new DataColumn("PONUM", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPONUM);
      this.columnEXPENSECODE = new DataColumn("EXPENSECODE", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPENSECODE);
      this.columnEXPENSENAME = new DataColumn("EXPENSENAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPENSENAME);
      this.columnGLACCTID = new DataColumn("GLACCTID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTID);
      this.columnGLACCTFULLNAME = new DataColumn("GLACCTFULLNAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTFULLNAME);
      this.columnAMOUNT = new DataColumn("AMOUNT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAMOUNT);
      this.columnDISCOUNT = new DataColumn("DISCOUNT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDISCOUNT);
      this.columnGLCOMPANYID = new DataColumn("GLCOMPANYID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCOMPANYID);
      this.columnCOSTCENTERID = new DataColumn("COSTCENTERID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCOSTCENTERID);
      this.columnEXPENSEFOR = new DataColumn("EXPENSEFOR", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPENSEFOR);
      this.columnEXPENSEDATE = new DataColumn("EXPENSEDATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPENSEDATE);
      this.columnCOSTCENTERNAME = new DataColumn("COSTCENTERNAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCOSTCENTERNAME);
      this.columnISCOMMISSION = new DataColumn("ISCOMMISSION", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISCOMMISSION);
    }

    public MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow NewdsPODetailsRow()
    {
      return (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow(builder);
    }

    protected override Type GetRowType() => typeof (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dsPODetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler detailsRowChangedEvent = this.dsPODetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEvent((MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dsPODetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler rowChangingEvent = this.dsPODetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEvent((MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dsPODetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler detailsRowDeletedEvent = this.dsPODetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEvent((MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dsPODetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEventHandler rowDeletingEvent = this.dsPODetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRowChangeEvent((MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow) e.Row, e.Action));
    }

    public void RemovedsPODetailsRow(MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class dsPODetailsRow : DataRow
  {
    private MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable tabledsPODetails;

    internal dsPODetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledsPODetails = (MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsDataTable) this.Table;
    }

    public int PONUM
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledsPODetails.PONUMColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.PONUMColumn] = (object) value;
    }

    public int EXPENSECODE
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledsPODetails.EXPENSECODEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.EXPENSECODEColumn] = (object) value;
    }

    public string EXPENSENAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledsPODetails.EXPENSENAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.EXPENSENAMEColumn] = (object) value;
    }

    public int GLACCTID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledsPODetails.GLACCTIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.GLACCTIDColumn] = (object) value;
    }

    public string GLACCTFULLNAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledsPODetails.GLACCTFULLNAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.GLACCTFULLNAMEColumn] = (object) value;
    }

    public Decimal AMOUNT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledsPODetails.AMOUNTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.AMOUNTColumn] = (object) value;
    }

    public Decimal DISCOUNT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledsPODetails.DISCOUNTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.DISCOUNTColumn] = (object) value;
    }

    public int GLCOMPANYID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledsPODetails.GLCOMPANYIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.GLCOMPANYIDColumn] = (object) value;
    }

    public int COSTCENTERID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledsPODetails.COSTCENTERIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.COSTCENTERIDColumn] = (object) value;
    }

    public string EXPENSEFOR
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledsPODetails.EXPENSEFORColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.EXPENSEFORColumn] = (object) value;
    }

    public DateTime EXPENSEDATE
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledsPODetails.EXPENSEDATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.EXPENSEDATEColumn] = (object) value;
    }

    public string COSTCENTERNAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledsPODetails.COSTCENTERNAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.COSTCENTERNAMEColumn] = (object) value;
    }

    public bool ISCOMMISSION
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledsPODetails.ISCOMMISSIONColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledsPODetails.ISCOMMISSIONColumn] = (object) value;
    }

    public bool IsPONUMNull() => this.IsNull(this.tabledsPODetails.PONUMColumn);

    public void SetPONUMNull()
    {
      this[this.tabledsPODetails.PONUMColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEXPENSECODENull() => this.IsNull(this.tabledsPODetails.EXPENSECODEColumn);

    public void SetEXPENSECODENull()
    {
      this[this.tabledsPODetails.EXPENSECODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEXPENSENAMENull() => this.IsNull(this.tabledsPODetails.EXPENSENAMEColumn);

    public void SetEXPENSENAMENull()
    {
      this[this.tabledsPODetails.EXPENSENAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLACCTIDNull() => this.IsNull(this.tabledsPODetails.GLACCTIDColumn);

    public void SetGLACCTIDNull()
    {
      this[this.tabledsPODetails.GLACCTIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLACCTFULLNAMENull() => this.IsNull(this.tabledsPODetails.GLACCTFULLNAMEColumn);

    public void SetGLACCTFULLNAMENull()
    {
      this[this.tabledsPODetails.GLACCTFULLNAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAMOUNTNull() => this.IsNull(this.tabledsPODetails.AMOUNTColumn);

    public void SetAMOUNTNull()
    {
      this[this.tabledsPODetails.AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDISCOUNTNull() => this.IsNull(this.tabledsPODetails.DISCOUNTColumn);

    public void SetDISCOUNTNull()
    {
      this[this.tabledsPODetails.DISCOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLCOMPANYIDNull() => this.IsNull(this.tabledsPODetails.GLCOMPANYIDColumn);

    public void SetGLCOMPANYIDNull()
    {
      this[this.tabledsPODetails.GLCOMPANYIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCOSTCENTERIDNull() => this.IsNull(this.tabledsPODetails.COSTCENTERIDColumn);

    public void SetCOSTCENTERIDNull()
    {
      this[this.tabledsPODetails.COSTCENTERIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEXPENSEFORNull() => this.IsNull(this.tabledsPODetails.EXPENSEFORColumn);

    public void SetEXPENSEFORNull()
    {
      this[this.tabledsPODetails.EXPENSEFORColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEXPENSEDATENull() => this.IsNull(this.tabledsPODetails.EXPENSEDATEColumn);

    public void SetEXPENSEDATENull()
    {
      this[this.tabledsPODetails.EXPENSEDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCOSTCENTERNAMENull() => this.IsNull(this.tabledsPODetails.COSTCENTERNAMEColumn);

    public void SetCOSTCENTERNAMENull()
    {
      this[this.tabledsPODetails.COSTCENTERNAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsISCOMMISSIONNull() => this.IsNull(this.tabledsPODetails.ISCOMMISSIONColumn);

    public void SetISCOMMISSIONNull()
    {
      this[this.tabledsPODetails.ISCOMMISSIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class dsPODetailsRowChangeEvent : EventArgs
  {
    private MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow eventRow;
    private DataRowAction eventAction;

    public dsPODetailsRowChangeEvent(MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public MGASystems.IMS.Accounting.AccountingDatasets.dsPODetails.dsPODetailsRow Row
    {
      get => this.eventRow;
    }

    public DataRowAction Action => this.eventAction;
  }
}
