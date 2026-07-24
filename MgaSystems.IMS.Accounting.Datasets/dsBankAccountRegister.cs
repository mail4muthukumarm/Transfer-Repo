// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankAccountRegister
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
public class dsBankAccountRegister : DataSet
{
  private dsBankAccountRegister.RegisterDataTable tableRegister;

  public dsBankAccountRegister()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankAccountRegister(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Register)] != null)
        this.Tables.Add((DataTable) new dsBankAccountRegister.RegisterDataTable(dataSet.Tables[nameof (Register)]));
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
  public dsBankAccountRegister.RegisterDataTable Register => this.tableRegister;

  public override DataSet Clone()
  {
    dsBankAccountRegister bankAccountRegister = (dsBankAccountRegister) base.Clone();
    bankAccountRegister.InitVars();
    return (DataSet) bankAccountRegister;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Register"] != null)
      this.Tables.Add((DataTable) new dsBankAccountRegister.RegisterDataTable(dataSet.Tables["Register"]));
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
    this.tableRegister = (dsBankAccountRegister.RegisterDataTable) this.Tables["Register"];
    if (this.tableRegister == null)
      return;
    this.tableRegister.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankAccountRegister);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankAccountRegister.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableRegister = new dsBankAccountRegister.RegisterDataTable();
    this.Tables.Add((DataTable) this.tableRegister);
  }

  private bool ShouldSerializeRegister() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void RegisterRowChangeEventHandler(
    object sender,
    dsBankAccountRegister.RegisterRowChangeEvent e);

  [DebuggerStepThrough]
  public class RegisterDataTable : DataTable, IEnumerable
  {
    private DataColumn columntransactNum;
    private DataColumn columntransactionDate;
    private DataColumn columnCheckOrRef;
    private DataColumn columnMethod;
    private DataColumn columnStatus;
    private DataColumn columnDescription;
    private DataColumn columnDebit;
    private DataColumn columnCredit;
    private DataColumn columnIsVoided;
    private DataColumn columnTrxType;
    private DataColumn columnIsReconciled;
    private DataColumn columnHasBouncedChecks;
    private DataColumn columnHasVoidedTransactions;

    internal RegisterDataTable()
      : base("Register")
    {
      this.InitClass();
    }

    internal RegisterDataTable(DataTable table)
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

    internal DataColumn transactNumColumn => this.columntransactNum;

    internal DataColumn transactionDateColumn => this.columntransactionDate;

    internal DataColumn CheckOrRefColumn => this.columnCheckOrRef;

    internal DataColumn MethodColumn => this.columnMethod;

    internal DataColumn StatusColumn => this.columnStatus;

    internal DataColumn DescriptionColumn => this.columnDescription;

    internal DataColumn DebitColumn => this.columnDebit;

    internal DataColumn CreditColumn => this.columnCredit;

    internal DataColumn IsVoidedColumn => this.columnIsVoided;

    internal DataColumn TrxTypeColumn => this.columnTrxType;

    internal DataColumn IsReconciledColumn => this.columnIsReconciled;

    internal DataColumn HasBouncedChecksColumn => this.columnHasBouncedChecks;

    internal DataColumn HasVoidedTransactionsColumn => this.columnHasVoidedTransactions;

    public dsBankAccountRegister.RegisterRow this[int index]
    {
      get => (dsBankAccountRegister.RegisterRow) this.Rows[index];
    }

    public event dsBankAccountRegister.RegisterRowChangeEventHandler RegisterRowChanged;

    public event dsBankAccountRegister.RegisterRowChangeEventHandler RegisterRowChanging;

    public event dsBankAccountRegister.RegisterRowChangeEventHandler RegisterRowDeleted;

    public event dsBankAccountRegister.RegisterRowChangeEventHandler RegisterRowDeleting;

    public void AddRegisterRow(dsBankAccountRegister.RegisterRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankAccountRegister.RegisterRow AddRegisterRow(
      int transactNum,
      DateTime transactionDate,
      string CheckOrRef,
      string Method,
      string Status,
      string Description,
      Decimal Debit,
      Decimal Credit,
      bool IsVoided,
      string TrxType,
      bool IsReconciled,
      string HasBouncedChecks,
      string HasVoidedTransactions)
    {
      dsBankAccountRegister.RegisterRow row = (dsBankAccountRegister.RegisterRow) this.NewRow();
      row.ItemArray = new object[13]
      {
        (object) transactNum,
        (object) transactionDate,
        (object) CheckOrRef,
        (object) Method,
        (object) Status,
        (object) Description,
        (object) Debit,
        (object) Credit,
        (object) IsVoided,
        (object) TrxType,
        (object) IsReconciled,
        (object) HasBouncedChecks,
        (object) HasVoidedTransactions
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankAccountRegister.RegisterDataTable registerDataTable = (dsBankAccountRegister.RegisterDataTable) base.Clone();
      registerDataTable.InitVars();
      return (DataTable) registerDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankAccountRegister.RegisterDataTable();
    }

    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columntransactionDate = this.Columns["transactionDate"];
      this.columnCheckOrRef = this.Columns["CheckOrRef"];
      this.columnMethod = this.Columns["Method"];
      this.columnStatus = this.Columns["Status"];
      this.columnDescription = this.Columns["Description"];
      this.columnDebit = this.Columns["Debit"];
      this.columnCredit = this.Columns["Credit"];
      this.columnIsVoided = this.Columns["IsVoided"];
      this.columnTrxType = this.Columns["TrxType"];
      this.columnIsReconciled = this.Columns["IsReconciled"];
      this.columnHasBouncedChecks = this.Columns["HasBouncedChecks"];
      this.columnHasVoidedTransactions = this.Columns["HasVoidedTransactions"];
    }

    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columntransactionDate = new DataColumn("transactionDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactionDate);
      this.columnCheckOrRef = new DataColumn("CheckOrRef", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckOrRef);
      this.columnMethod = new DataColumn("Method", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMethod);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnDebit = new DataColumn("Debit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDebit);
      this.columnCredit = new DataColumn("Credit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCredit);
      this.columnIsVoided = new DataColumn("IsVoided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsVoided);
      this.columnTrxType = new DataColumn("TrxType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTrxType);
      this.columnIsReconciled = new DataColumn("IsReconciled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsReconciled);
      this.columnHasBouncedChecks = new DataColumn("HasBouncedChecks", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHasBouncedChecks);
      this.columnHasVoidedTransactions = new DataColumn("HasVoidedTransactions", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHasVoidedTransactions);
    }

    public dsBankAccountRegister.RegisterRow NewRegisterRow()
    {
      return (dsBankAccountRegister.RegisterRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankAccountRegister.RegisterRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankAccountRegister.RegisterRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RegisterRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountRegister.RegisterRowChangeEventHandler registerRowChangedEvent = this.RegisterRowChangedEvent;
      if (registerRowChangedEvent == null)
        return;
      registerRowChangedEvent((object) this, new dsBankAccountRegister.RegisterRowChangeEvent((dsBankAccountRegister.RegisterRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RegisterRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountRegister.RegisterRowChangeEventHandler rowChangingEvent = this.RegisterRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankAccountRegister.RegisterRowChangeEvent((dsBankAccountRegister.RegisterRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RegisterRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountRegister.RegisterRowChangeEventHandler registerRowDeletedEvent = this.RegisterRowDeletedEvent;
      if (registerRowDeletedEvent == null)
        return;
      registerRowDeletedEvent((object) this, new dsBankAccountRegister.RegisterRowChangeEvent((dsBankAccountRegister.RegisterRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RegisterRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountRegister.RegisterRowChangeEventHandler rowDeletingEvent = this.RegisterRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankAccountRegister.RegisterRowChangeEvent((dsBankAccountRegister.RegisterRow) e.Row, e.Action));
    }

    public void RemoveRegisterRow(dsBankAccountRegister.RegisterRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class RegisterRow : DataRow
  {
    private dsBankAccountRegister.RegisterDataTable tableRegister;

    internal RegisterRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableRegister = (dsBankAccountRegister.RegisterDataTable) this.Table;
    }

    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableRegister.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.transactNumColumn] = (object) value;
    }

    public DateTime transactionDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableRegister.transactionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.transactionDateColumn] = (object) value;
    }

    public string CheckOrRef
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.CheckOrRefColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.CheckOrRefColumn] = (object) value;
    }

    public string Method
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.MethodColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.MethodColumn] = (object) value;
    }

    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.StatusColumn] = (object) value;
    }

    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.DescriptionColumn] = (object) value;
    }

    public Decimal Debit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableRegister.DebitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.DebitColumn] = (object) value;
    }

    public Decimal Credit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableRegister.CreditColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.CreditColumn] = (object) value;
    }

    public bool IsVoided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableRegister.IsVoidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.IsVoidedColumn] = (object) value;
    }

    public string TrxType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.TrxTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.TrxTypeColumn] = (object) value;
    }

    public bool IsReconciled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableRegister.IsReconciledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.IsReconciledColumn] = (object) value;
    }

    public string HasBouncedChecks
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.HasBouncedChecksColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.HasBouncedChecksColumn] = (object) value;
    }

    public string HasVoidedTransactions
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRegister.HasVoidedTransactionsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRegister.HasVoidedTransactionsColumn] = (object) value;
    }

    public bool IstransactNumNull() => this.IsNull(this.tableRegister.transactNumColumn);

    public void SettransactNumNull()
    {
      this[this.tableRegister.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IstransactionDateNull() => this.IsNull(this.tableRegister.transactionDateColumn);

    public void SettransactionDateNull()
    {
      this[this.tableRegister.transactionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckOrRefNull() => this.IsNull(this.tableRegister.CheckOrRefColumn);

    public void SetCheckOrRefNull()
    {
      this[this.tableRegister.CheckOrRefColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsMethodNull() => this.IsNull(this.tableRegister.MethodColumn);

    public void SetMethodNull()
    {
      this[this.tableRegister.MethodColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsStatusNull() => this.IsNull(this.tableRegister.StatusColumn);

    public void SetStatusNull()
    {
      this[this.tableRegister.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDescriptionNull() => this.IsNull(this.tableRegister.DescriptionColumn);

    public void SetDescriptionNull()
    {
      this[this.tableRegister.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDebitNull() => this.IsNull(this.tableRegister.DebitColumn);

    public void SetDebitNull()
    {
      this[this.tableRegister.DebitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCreditNull() => this.IsNull(this.tableRegister.CreditColumn);

    public void SetCreditNull()
    {
      this[this.tableRegister.CreditColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsIsVoidedNull() => this.IsNull(this.tableRegister.IsVoidedColumn);

    public void SetIsVoidedNull()
    {
      this[this.tableRegister.IsVoidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTrxTypeNull() => this.IsNull(this.tableRegister.TrxTypeColumn);

    public void SetTrxTypeNull()
    {
      this[this.tableRegister.TrxTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsIsReconciledNull() => this.IsNull(this.tableRegister.IsReconciledColumn);

    public void SetIsReconciledNull()
    {
      this[this.tableRegister.IsReconciledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsHasBouncedChecksNull() => this.IsNull(this.tableRegister.HasBouncedChecksColumn);

    public void SetHasBouncedChecksNull()
    {
      this[this.tableRegister.HasBouncedChecksColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsHasVoidedTransactionsNull()
    {
      return this.IsNull(this.tableRegister.HasVoidedTransactionsColumn);
    }

    public void SetHasVoidedTransactionsNull()
    {
      this[this.tableRegister.HasVoidedTransactionsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class RegisterRowChangeEvent : EventArgs
  {
    private dsBankAccountRegister.RegisterRow eventRow;
    private DataRowAction eventAction;

    public RegisterRowChangeEvent(dsBankAccountRegister.RegisterRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankAccountRegister.RegisterRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
