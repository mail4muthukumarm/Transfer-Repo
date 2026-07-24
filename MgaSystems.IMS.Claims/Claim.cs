// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;

#nullable disable
namespace MGASystems.IMS.Claims;

public class Claim : IDisposable, INotifyChanges
{
  protected int? _claimId;
  private int _controlNumber;
  private int _numberingRuleId;
  private int _numericClaimNumber;
  protected NotificationCollection<ClaimEntity> _lines;
  private Guid _userGuid;
  private string _userName;
  private Guid _modifiedByUserGuid;
  private string _modifiedByUserName;
  private DateTime _modifiedDate;
  private Guid _quoteControlGuid;
  private string _claimNumber;
  protected DateTime _dateEntered;
  private DateTime _lossDate;
  private string _catastropheCode;
  private string _companyCatastropheCode;
  private NotificationCollection<Claimant> _claimants;
  private NotificationCollection<ClaimActivity> _claimAcitvities;
  private CancelEventArgs _loadingPolicyEventArgs;
  private ClaimPolicyInformation _policyInformation;
  protected DataSet _dsClaimants;
  private dsUnallocatedExpenses _unallocatedExpenses;
  private bool _isManualClaimNumber;
  public dsReservePaymentBreakout _reservePaymentsBreakout;
  private string _claimComments;
  private Guid _inhouseAdjusterGuid;
  private Guid _claimGuid;
  private AccidentInformation _accidentinfo;
  private ClaimPolicyAggregates _policyAggregates;
  private ClaimDriverInformation _driverInfo;
  protected bool _hasChanges;
  private List<string> _loggingList;

  public Claim()
  {
    this.InitializeObject();
    this._dateEntered = DateTime.Now;
    this._hasChanges = true;
  }

  public Claim(int claimId)
  {
    this.InitializeObject();
    this.LoadClaim(claimId);
    this._hasChanges = false;
  }

  public Claim(Guid claimGuid)
  {
    this.InitializeObject();
    this.LoadClaim(claimGuid);
    this._hasChanges = false;
  }

  protected dsUnallocatedExpenses Protected_UnallocatedExpenses => this._unallocatedExpenses;

  public Decimal UnsavedUnallocatedAmount
  {
    get
    {
      Decimal unallocatedAmount = 0M;
      foreach (dsUnallocatedExpenses.ExpenseListRow expense in (TypedTableBase<dsUnallocatedExpenses.ExpenseListRow>) this._unallocatedExpenses.ExpenseList)
      {
        if (expense.UAExpenseId == -1)
          unallocatedAmount += expense.TotalAmount;
      }
      return unallocatedAmount;
    }
  }

  private void HookUpEvents()
  {
    if (this._claimants == null)
      this._claimants = new NotificationCollection<Claimant>();
    this._claimants.CollectionChanged += new EventHandler<EventArgs>(this.ClaimantsChanged);
  }

  private void ClaimantsChanged(object sender, EventArgs e)
  {
    this.GenerateClaimantDataset();
    this.OnClaimantCollectionChanged();
  }

  internal event EventHandler<CancelEventArgs> LoadingPolicyInformation;

  internal event EventHandler<LoadedPolicyInformationEventArgs> LoadedPolicyInformation;

  internal event EventHandler<EventArgs> ClaimantCollectionChanged;

  internal event EventHandler<EventArgs> UnAllocatedExpensesLoaded;

  internal event EventHandler<EventArgs> UnAllocatedExpensesChanged;

  internal event EventHandler<EventArgs> ReservePaymentBreakoutLoaded;

  internal event EventHandler<EventArgs> AccidentInformationLoaded;

  public event EventHandler<CancelEventArgs> BeforeClaimVerifyCompleted;

  public event EventHandler<CancelEventArgs> BeforeSaveClaimCommitted;

  public event EventHandler<EventArgs> UpdateBroadcast;

  protected void OnUpdateBroadcast()
  {
    if (this.UpdateBroadcast == null)
      return;
    this.UpdateBroadcast((object) this, new EventArgs());
  }

  public bool OnBeforeSaveClaimCommitted()
  {
    CancelEventArgs e = new CancelEventArgs();
    if (this.BeforeSaveClaimCommitted == null)
      return true;
    this.BeforeSaveClaimCommitted((object) this, e);
    return !e.Cancel;
  }

  public bool OnBeforeClaimVerifyCompleted()
  {
    CancelEventArgs e = new CancelEventArgs();
    if (this.BeforeClaimVerifyCompleted == null)
      return true;
    this.BeforeClaimVerifyCompleted((object) this, e);
    return !e.Cancel;
  }

  private void OnLoadingPolicyInformation()
  {
    if (this.LoadingPolicyInformation == null)
      return;
    this.LoadingPolicyInformation((object) this, this._loadingPolicyEventArgs);
  }

  private void OnLoadedPolicyInformation()
  {
    if (this.LoadedPolicyInformation == null)
      return;
    this.LoadedPolicyInformation((object) this, new LoadedPolicyInformationEventArgs(this.PolicyInformation.PolicyNumber, this.PolicyInformation.InsuredName, this.PolicyInformation.ProducerLocationName, this.PolicyInformation.CompanyName, (Collection<ClaimEntity>) this.Lines));
  }

  protected void OnClaimantCollectionChanged()
  {
    if (this.ClaimantCollectionChanged != null)
      this.ClaimantCollectionChanged((object) this, new EventArgs());
    this._hasChanges = true;
  }

  protected void OnUnAllocatedExpensesLoaded()
  {
    if (this.UnAllocatedExpensesLoaded == null)
      return;
    this.UnAllocatedExpensesLoaded((object) this, new EventArgs());
  }

  public void OnReservePaymentBreakoutLoaded()
  {
    if (this.ReservePaymentBreakoutLoaded == null)
      return;
    this.ReservePaymentBreakoutLoaded((object) this, new EventArgs());
  }

  protected void OnUnAllocatedExpensesChanged()
  {
    if (this.UnAllocatedExpensesChanged != null)
      this.UnAllocatedExpensesChanged((object) this, new EventArgs());
    this._hasChanges = true;
  }

  private void OnAccidentInformationLoaded()
  {
    if (this.AccidentInformationLoaded == null)
      return;
    this.AccidentInformationLoaded((object) this, new EventArgs());
  }

  public int? ClaimId => this._claimId;

  public int ControlNumber
  {
    get => this._controlNumber;
    set => this._controlNumber = value;
  }

  protected internal Guid UserGuid => this._userGuid;

  protected internal string UserName => this._userName;

  protected internal Guid QuoteControlGuid
  {
    get => this._quoteControlGuid;
    set => this._quoteControlGuid = value;
  }

  public string ClaimNumber
  {
    get => this._claimNumber;
    protected internal set => this._claimNumber = value;
  }

  protected internal DateTime DateEntered
  {
    get => this._dateEntered;
    set => this._dateEntered = value;
  }

  public DateTime LossDate
  {
    get => this._lossDate;
    set => this._lossDate = value;
  }

  public string CatastropheCode
  {
    get => this._catastropheCode;
    set
    {
      if (!string.IsNullOrEmpty(this._catastropheCode) && !string.IsNullOrEmpty(value) && this._catastropheCode != value)
        this._hasChanges = true;
      this._catastropheCode = value;
    }
  }

  protected internal string CompanyCatastropheCode
  {
    get => this._companyCatastropheCode;
    set => this._companyCatastropheCode = value;
  }

  public NotificationCollection<Claimant> Claimants
  {
    get
    {
      if (this._claimants == null)
        this._claimants = new NotificationCollection<Claimant>();
      return this._claimants;
    }
  }

  public ClaimPolicyInformation PolicyInformation
  {
    get
    {
      if (this._policyInformation == null)
        this._policyInformation = new ClaimPolicyInformation();
      return this._policyInformation;
    }
  }

  protected internal NotificationCollection<ClaimEntity> Lines => this._lines;

  protected internal NotificationCollection<ClaimActivity> ClaimActivities
  {
    get
    {
      if (this._claimAcitvities == null)
        this._claimAcitvities = new NotificationCollection<ClaimActivity>();
      return this._claimAcitvities;
    }
  }

  protected internal DataSet ClaimantsDataset
  {
    get
    {
      if (this._dsClaimants == null)
        this.GenerateClaimantDataset();
      return this._dsClaimants;
    }
  }

  protected internal int NumberingRuleId => this._numberingRuleId;

  protected internal int NumericClaimNumber => this._numericClaimNumber;

  protected internal Guid ModifiedByUserGuid => this._modifiedByUserGuid;

  protected internal string ModifiedByUserName => this._modifiedByUserName;

  protected internal DateTime ModifiedDate => this._modifiedDate;

  public dsUnallocatedExpenses UnAllocatedExpenses => this._unallocatedExpenses;

  protected internal dsReservePaymentBreakout ReservePaymentBreakout
  {
    get => this._reservePaymentsBreakout;
  }

  public string ClaimComments
  {
    get => this._claimComments;
    protected internal set => this._claimComments = value;
  }

  protected internal Guid InhouseAdjusterGuid
  {
    get => this._inhouseAdjusterGuid;
    set => this._inhouseAdjusterGuid = value;
  }

  public Guid InhouseAdjuster => this._inhouseAdjusterGuid;

  public Guid ClaimGuid
  {
    get => this._claimGuid;
    set => this._claimGuid = value;
  }

  public AccidentInformation AccidentInfo
  {
    get
    {
      if (this._accidentinfo == null)
        this._accidentinfo = !this._claimId.HasValue ? new AccidentInformation() : new AccidentInformation(this._claimId.Value);
      return this._accidentinfo;
    }
  }

  public ClaimPolicyAggregates PolicyAggregates
  {
    get
    {
      if (this._policyAggregates == null)
        this._policyAggregates = new ClaimPolicyAggregates(this.ControlNumber);
      return this._policyAggregates;
    }
  }

  public ClaimDriverInformation DriverInfo
  {
    get
    {
      if (this._driverInfo == null)
        this._driverInfo = !this.ClaimId.HasValue ? new ClaimDriverInformation() : new ClaimDriverInformation(this.ClaimId.Value);
      return this._driverInfo;
    }
    set => this._driverInfo = value;
  }

  internal void CreateClaimForControlNumber(int controlNumber)
  {
    this._controlNumber = controlNumber;
    this._userGuid = CurrentUser.Instance.UserGUID;
    this._userName = CurrentUser.Instance.DisplayName;
    this._lossDate = DateTime.Now;
    this._loadingPolicyEventArgs = new CancelEventArgs();
    this.OnLoadingPolicyInformation();
    this.LoadPolicyInformation();
    this.IsManualClaimNumber = Utility.HasManualClaimNumberRule(this.PolicyInformation.CompanyGuid, this.PolicyInformation.CompanyLocationGuid, this.PolicyInformation.LineGuid, DateTime.Now);
    this.AddActivity(new ClaimActivity(Utility.ClaimActivityType.ClaimCreated, DateTime.Now, CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, Utility.ClaimStatus.Open));
    if (this._unallocatedExpenses == null)
      this._unallocatedExpenses = new dsUnallocatedExpenses();
    this.AddClaimCreatedExpense();
    this.OnLoadedPolicyInformation();
  }

  public virtual void AddExpense(
    Guid claimantGuid,
    string expenseDescription,
    string automationCode,
    bool automated,
    int? expenseId,
    Guid userGuid,
    string enteredBy,
    string comments,
    Decimal? hours,
    Decimal? hourlyRate,
    Decimal? equiptmentRate,
    Decimal? otherCost,
    Decimal? otherAmount,
    DateTime transactionDate)
  {
    if (string.IsNullOrEmpty(automationCode) && !expenseId.HasValue)
      throw new InvalidArgumentException(Resources.EXPENSE_INVALIDARGUMENT_IDENTIFIER);
    if (userGuid.Equals(Guid.Empty))
      throw new InvalidArgumentException(Resources.EXPENSE_INVALIDARGUMENT_USERGUID);
    if (this._unallocatedExpenses == null)
      this._unallocatedExpenses = new dsUnallocatedExpenses();
    dsUnallocatedExpenses.ExpenseListRow row = this._unallocatedExpenses.ExpenseList.NewExpenseListRow();
    row.DateEntered = transactionDate;
    row.Waived = false;
    row.ARCreated = false;
    if (this.ClaimId.HasValue)
      row.ClaimId = this.ClaimId.Value;
    if (!claimantGuid.Equals(Guid.Empty))
      row.ClaimantGuid = claimantGuid;
    row.ExpenseDescription = expenseDescription;
    if (!string.IsNullOrEmpty(automationCode))
      row.AutomationCode = automationCode;
    row.Automated = automated;
    if (expenseId.HasValue)
      row.ExpenseId = expenseId.Value;
    row.UserGuid = userGuid;
    row.EnteredBy = enteredBy;
    if (!string.IsNullOrEmpty(comments))
      row.Comments = comments;
    if (hours.HasValue && hourlyRate.HasValue)
    {
      row.HourlyRate = hourlyRate.Value;
      row.Hours = hours.Value;
      row.HourlyAmount = hourlyRate.Value * hours.Value;
      row.TotalAmount = hourlyRate.Value * hours.Value;
    }
    else
    {
      row.Hours = 0M;
      row.HourlyRate = 0M;
      row.HourlyAmount = 0M;
    }
    if (hours.HasValue && equiptmentRate.HasValue)
    {
      row.EquipmentRate = equiptmentRate.Value;
      row.EquipmentAmount = equiptmentRate.Value * hours.Value;
      row.TotalAmount += equiptmentRate.Value * hours.Value;
    }
    else
    {
      row.EquipmentRate = 0M;
      row.EquipmentAmount = 0M;
    }
    if (otherCost.HasValue && otherAmount.HasValue)
    {
      row.OtherCost = otherCost.Value;
      row.OtherCount = otherAmount.Value;
      row.OtherAmount = otherCost.Value * otherAmount.Value;
      row.TotalAmount += otherCost.Value * otherAmount.Value;
    }
    else
    {
      row.OtherCost = 0M;
      row.OtherCount = 0M;
      row.OtherAmount = 0M;
    }
    this._unallocatedExpenses.ExpenseList.AddExpenseListRow(row);
    this.OnUnAllocatedExpensesChanged();
  }

  public virtual void AddExpense(
    Guid claimantGuid,
    string expenseDescription,
    string automationCode,
    bool automated,
    int? expenseId,
    Guid userGuid,
    string enteredBy,
    string comments,
    Decimal? hours,
    Decimal? hourlyRate,
    Decimal? equiptmentRate,
    Decimal? otherCost,
    Decimal? otherAmount)
  {
    this.AddExpense(claimantGuid, expenseDescription, automationCode, automated, expenseId, userGuid, enteredBy, comments, hours, hourlyRate, equiptmentRate, otherCost, otherCost, DateTime.Now);
  }

  public Decimal UnAllocatedExpenseTotal()
  {
    return this.UnAllocatedExpenses == null || this.UnAllocatedExpenses.Tables[0].Rows.Count == 0 ? 0M : (Decimal) this.UnAllocatedExpenses.Tables[0].Compute("SUM(TOTALAMOUNT)", string.Empty);
  }

  protected internal bool IsManualClaimNumber
  {
    get => this._isManualClaimNumber;
    set => this._isManualClaimNumber = value;
  }

  public Claimant GetClaimant(Guid claimantGuid)
  {
    Claimant claimant1 = (Claimant) null;
    foreach (Claimant claimant2 in (Collection<Claimant>) this.Claimants)
    {
      if (claimant2.ClaimantGuid == claimantGuid)
      {
        claimant1 = claimant2;
        break;
      }
    }
    return claimant1;
  }

  protected void InitializeObject()
  {
    this._isManualClaimNumber = true;
    this.HookUpEvents();
  }

  public void ReloadClaim()
  {
    if (!this._claimId.HasValue)
      return;
    this.LoadClaim(this._claimId.Value);
  }

  protected virtual void LoadClaim(int claimId)
  {
    this._claimId = new int?(claimId);
    this.SetHeaderProperties(DefaultDatabase.ExecuteDataRow("spClaims_GetClaimHeader", new object[2]
    {
      (object) "@ClaimId",
      (object) this._claimId
    }) ?? throw new ClaimNotFoundException(Resources.EXCEPTION_CLAIMNOTFOUND));
    this.LoadUnallocatedExpenses();
    this.LoadClaimants();
    this.LoadClaimActivity();
    this.LoadReservePaymentBreakout();
    this.LoadAccidentInformation(this._claimId.Value);
  }

  protected virtual void LoadClaim(Guid claimGuid)
  {
    DataRow dr = DefaultDatabase.ExecuteDataRow("spClaims_GetClaimHeader", new object[2]
    {
      (object) "@ClaimGuid",
      (object) claimGuid
    });
    this._claimId = dr != null ? new int?((int) dr["claimid"]) : throw new ClaimNotFoundException(Resources.EXCEPTION_CLAIMNOTFOUND);
    this.SetHeaderProperties(dr);
    this.LoadUnallocatedExpenses();
    this.LoadClaimants();
    this.LoadClaimActivity();
    this.LoadReservePaymentBreakout();
    this.LoadAccidentInformation(this._claimId.Value);
  }

  protected void SetHeaderProperties(DataRow dr)
  {
    this._controlNumber = int.Parse(dr["ControlNo"].ToString());
    this._userGuid = new Guid(dr["UserGuid"].ToString());
    this._userName = dr["UserName"].ToString();
    this._claimNumber = dr["ClaimNumber"].ToString();
    this._dateEntered = (DateTime) dr["DateEntered"];
    this._lossDate = (DateTime) dr["LossDate"];
    this._catastropheCode = dr["CatastropheCode"].ToString();
    this._companyCatastropheCode = dr["CompanyCatastropheCode"].ToString();
    this._modifiedByUserGuid = new Guid(dr["ModifiedUserGuid"].ToString());
    this._modifiedByUserName = dr["ModifiedByUserName"].ToString();
    this._modifiedDate = (DateTime) dr["ModifiedDate"];
    this._claimComments = dr["ClaimComments"].ToString();
    this._claimGuid = new Guid(dr["ClaimGuid"].ToString());
    this._inhouseAdjusterGuid = dr["InhouseAdjuster"] == DBNull.Value ? new Guid(Guid.Empty.ToString()) : new Guid(dr["InhouseAdjuster"].ToString());
    this.SetPolicyInformationProperties(dr);
  }

  protected virtual void SetPolicyInformationProperties(DataRow dr)
  {
    this.PolicyInformation.PolicyNumber = dr["PolicyNumber"].ToString();
    this.PolicyInformation.CompanyGuid = new Guid(dr["CompanyGuid"].ToString());
    this.PolicyInformation.CompanyName = dr["CompanyName"].ToString();
    this.PolicyInformation.ProducerLocationGuid = new Guid(dr["ProducerLocationGuid"].ToString());
    this.PolicyInformation.ProducerLocationName = dr["ProducerLocationName"].ToString();
    this.PolicyInformation.InsuredGuid = new Guid(dr["InsuredGuid"].ToString());
    this.PolicyInformation.InsuredName = dr["InsuredName"].ToString();
    this.PolicyInformation.LineGuid = new Guid(dr["LineGuid"].ToString());
    this.PolicyInformation.LineName = dr["LineName"].ToString();
    if (dr.Table.Columns.Contains("CompanyLocationGuid") && dr["CompanyLocationGuid"] != DBNull.Value)
      this.PolicyInformation.CompanyLocationGuid = new Guid(dr["CompanyLocationGuid"].ToString());
    if (this._lines == null)
      this._lines = new NotificationCollection<ClaimEntity>();
    this._lines.Add(new ClaimEntity(new Guid(dr["LineGuid"].ToString()), (string) dr["LineName"]));
  }

  private void LoadPolicyInformation()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetPolicyInformation", new object[2]
    {
      (object) "@controlNumber",
      (object) this.ControlNumber
    });
    if (dataTable.Rows.Count == 0)
      throw new ControlNumberNotFoundException(Resources.EXCEPTION_POLICYINFORMATIONNOTFOUND);
    this.SetPolicyInformationProperties(dataTable.Rows[0]);
  }

  protected virtual void LoadClaimants()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetClaimClaimants", new object[2]
    {
      (object) "@ClaimId",
      (object) this.ClaimId
    });
    if (dataTable == null)
      return;
    this.Claimants.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      this.Claimants.Add(this.CreateClaimant(row));
    this.GenerateClaimantDataset();
    this.OnClaimantCollectionChanged();
  }

  protected virtual void LoadUnallocatedExpenses()
  {
    if (this._unallocatedExpenses == null)
      this._unallocatedExpenses = new dsUnallocatedExpenses();
    else
      this._unallocatedExpenses.ExpenseList.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this._unallocatedExpenses.ExpenseList, "spClaims_GetClaimExpenses", new object[2]
    {
      (object) "@ClaimId",
      (object) this.ClaimId
    });
    this.OnUnAllocatedExpensesLoaded();
  }

  protected virtual void LoadClaimActivity()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetClaimActivity", new object[2]
    {
      (object) "@ClaimId",
      (object) this.ClaimId
    });
    if (dataTable == null || dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      this.AddActivity(new ClaimActivity((int) row["ClaimActivityId"], (Utility.ClaimActivityType) row["Activity"], (DateTime) row["ActivityDate"], new Guid(row["UserGuid"].ToString()), row["UserName"].ToString(), (Utility.ClaimStatus) row["ClaimStatus"]));
  }

  protected void LoadReservePaymentBreakout()
  {
    this._reservePaymentsBreakout = new dsReservePaymentBreakout();
    DefaultDatabase.LoadDataSet((DataSet) this._reservePaymentsBreakout, new string[2]
    {
      "ReservePaymentBreakout",
      "Claimants"
    }, "spClaims_GetReservePaymentBreakout", new object[2]
    {
      (object) "@claimid",
      (object) this._claimId
    });
    this.OnReservePaymentBreakoutLoaded();
  }

  protected void LoadAccidentInformation(int claimId)
  {
    this._accidentinfo = new AccidentInformation(claimId);
    this.OnAccidentInformationLoaded();
  }

  internal void ReloadUnallocatedExpenses() => this.LoadUnallocatedExpenses();

  public virtual void AddActivity(ClaimActivity activity) => this.ClaimActivities.Add(activity);

  internal void AddClaimant(Claimant claimant)
  {
    this.Claimants.Add(claimant);
    this.GenerateClaimantDataset();
    this.OnClaimantCollectionChanged();
  }

  protected virtual void GenerateClaimantDataset()
  {
    if (this._dsClaimants == null)
    {
      this._dsClaimants = new DataSet();
      DataTable table = new DataTable();
      DataColumn column1 = new DataColumn("ClaimantGuid", typeof (Guid));
      table.Columns.Add(column1);
      DataColumn column2 = new DataColumn("#", typeof (int));
      table.Columns.Add(column2);
      DataColumn column3 = new DataColumn("Claimant", typeof (string));
      table.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Reserves", typeof (int));
      table.Columns.Add(column4);
      DataColumn column5 = new DataColumn("Payments", typeof (int));
      table.Columns.Add(column5);
      DataColumn column6 = new DataColumn("Status", typeof (bool));
      table.Columns.Add(column6);
      this._dsClaimants.Tables.Add(table);
    }
    else
      this._dsClaimants.Tables[0].Clear();
    int count = this.Claimants.Count;
    foreach (Claimant claimant in (Collection<Claimant>) this.Claimants)
    {
      this._dsClaimants.Tables[0].Rows.Add((object) claimant.ClaimantGuid, (object) count, (object) claimant.DisplayName, (object) claimant.CountReserves(), (object) claimant.CountPayments(), (object) claimant.IsOpen);
      --count;
    }
  }

  protected virtual Claimant CreateClaimant(DataRow dr)
  {
    Claimant c = (Claimant) ObjectFactory.Instance.CreateObject(typeof (Claimant), new object[8]
    {
      (object) this,
      (object) new Guid(dr["ClaimantGuid"].ToString()),
      (object) new Guid(dr["EnteredBy"].ToString()),
      (object) dr["EnteredByUserName"].ToString(),
      (object) (DateTime) dr["DateEntered"],
      (object) new Guid(dr["ModifiedBy"].ToString()),
      (object) dr["ModifiedByUserName"].ToString(),
      (object) (DateTime) dr["DateModified"]
    });
    c.ClaimantInformation.CorporationName = dr["CorporationName"].ToString();
    c.ClaimantInformation.FirstName = dr["FirstName"].ToString();
    c.ClaimantInformation.MiddleName = dr["MiddleName"].ToString();
    c.ClaimantInformation.LastName = dr["LastName"].ToString();
    c.ClaimantInformation.Gender = (int) dr["Gender"];
    c.ClaimantInformation.SocialSecurityNumber = dr["SSN"].ToString();
    c.UserDefinedClaimantId = dr["UserDef_ClaimantId"].ToString();
    if (dr["dateReported"] != DBNull.Value)
      c.DateReported = new DateTime?((DateTime) dr["DateReported"]);
    if (dr["DOB"] != DBNull.Value)
      c.ClaimantInformation.DateOfBirth = new DateTime?((DateTime) dr["DOB"]);
    c.ClaimantInformation.Fein = dr["FEIN"].ToString();
    if (dr["DateDenied"] != DBNull.Value)
      c.DateDenied = (DateTime?) dr["DateDenied"];
    c.IsInsured = (bool) dr["IsInsured"];
    c.MedicareEligible = (bool) dr["MedicareEligible"];
    c.EmailAddress = dr["EmailAddress"].ToString();
    c.ManagedCareId = dr["ManagedCareId"] == DBNull.Value ? new int?() : (int?) dr["ManagedCareId"];
    c.LossTypeId = dr["LossTypeId"] == DBNull.Value ? new int?() : (int?) dr["LossTypeId"];
    c.AccidentTypeId = dr["AccidentTypeId"] == DBNull.Value ? new int?() : (int?) dr["AccidentTypeId"];
    c.OutsideInvestigator = dr["OutsideInvestigator"].ToString();
    if (dr["OutsideInvestigatorHireDate"] != DBNull.Value)
      c.OutsideInvestigatorHireDate = (DateTime?) dr["OutsideInvestigatorHireDate"];
    c.IsSettled = (bool) dr["IsSettled"];
    c.StatusId = (int) dr["StatusId"];
    c.SettlementTypeId = dr["SettlementTypeId"] == DBNull.Value ? new int?() : (int?) dr["SettlementTypeId"];
    c.ClaimantComments = dr["ClaimantComments"].ToString();
    c.OutsideAdjusterGuid = dr["OutsideAdjusterGuid"] == DBNull.Value ? Guid.Empty : new Guid(dr["OutsideAdjusterGuid"].ToString());
    this.CreateClaimantLegal(c);
    this.SetClaimantAddresses(c, dr);
    return c;
  }

  protected void SetClaimantAddresses(Claimant c, DataRow dr)
  {
    c.PrimaryAddress = new ClaimAddress((int) dr["AddressId"]);
    c.PrimaryAddress.IsoCountryCode = dr["PrimaryISOCountryCode"].ToString();
    c.PrimaryAddress.IsInternational = (bool) dr["PrimaryIsInternational"];
    c.PrimaryAddress.Address1 = dr["PrimaryAddress1"].ToString();
    c.PrimaryAddress.Address2 = dr["PrimaryAddress2"].ToString();
    c.PrimaryAddress.City = dr["PrimaryCity"].ToString();
    c.PrimaryAddress.State = dr["PrimaryState"].ToString();
    if (c.PrimaryAddress.IsoCountryCode == "USA")
    {
      c.PrimaryAddress.ZipCode = dr["PrimaryZipCode"].ToString();
      c.PrimaryAddress.ZipCodeExtension = dr["PrimaryZipCodeExtension"].ToString();
    }
    else
      c.PrimaryAddress.ZipCode = dr["PrimaryInternationalZipCode"].ToString();
    if (dr.Table.Columns.Contains("PrimaryCounty") && !Utility.IsNull(dr["PrimaryCounty"]))
      c.PrimaryAddress.County = dr["PrimaryCounty"].ToString();
    c.PrimaryAddress.LoadPhoneNumbers((int) dr["AddressId"]);
    if (dr["MailingAddressId"] == DBNull.Value)
      return;
    c.MailingAddress = new ClaimAddress((int) dr["MailingAddressId"]);
    c.MailingAddress.IsoCountryCode = dr["MailingISOCountryCode"].ToString();
    c.MailingAddress.IsInternational = dr["MailingIsInternational"] != DBNull.Value && (bool) dr["MailingIsInternational"];
    c.MailingAddress.Address1 = dr["MailingAddress1"].ToString();
    c.MailingAddress.Address2 = dr["MailingAddress2"].ToString();
    c.MailingAddress.City = dr["MailingCity"].ToString();
    c.MailingAddress.State = dr["MailingState"].ToString();
    if (c.MailingAddress.IsoCountryCode == "USA")
    {
      c.MailingAddress.ZipCode = dr["MailingZipCode"].ToString();
      c.MailingAddress.ZipCodeExtension = dr["MailingZipCodeExtension"].ToString();
    }
    else
      c.MailingAddress.ZipCode = dr["MailingInternationalZipCode"].ToString();
    if (dr.Table.Columns.Contains("MailingCounty") && !Utility.IsNull(dr["MailingCounty"]))
      c.MailingAddress.County = dr["MailingCounty"].ToString();
    c.MailingAddress.LoadPhoneNumbers((int) dr["MailingAddressId"]);
  }

  protected void CreateClaimantLegal(Claimant c)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetClaimantLegal", new object[2]
    {
      (object) "@ClaimantGuid",
      (object) c.ClaimantGuid
    });
    if (dataTable == null || dataTable.Rows.Count == 0)
      return;
    c.LegalInformation.DefenseAttorney = !Utility.IsNull(dataTable.Rows[0]["DefenseAttorney"]) ? dataTable.Rows[0].Field<string>("DefenseAttorney") : string.Empty;
    c.LegalInformation.DefenseFirm = !Utility.IsNull(dataTable.Rows[0]["DefenseFirm"]) ? dataTable.Rows[0].Field<string>("DefenseFirm") : string.Empty;
    if (c.LegalInformation.DefenseFirm.Length > 0 || c.LegalInformation.DefenseAttorney.Length > 0)
    {
      c.LegalInformation.DefenseAttorneyGuid = !Utility.IsNull(dataTable.Rows[0]["DefenseAttorneyGuid"]) ? dataTable.Rows[0].Field<Guid>("DefenseAttorneyGuid") : Guid.Empty;
      c.LegalInformation.DefenseAttorneyFeinSsn = dataTable.Rows[0].Field<string>("DefenseAttorneyFEINSSN");
      c.LegalInformation.DefenseFirmEntityType = dataTable.Rows[0].Field<string>("DefenseFirmEntityType") != "I" ? ClaimantLegalInformation.EntityType.Corporation : ClaimantLegalInformation.EntityType.Individual;
      if (!Utility.IsNull(dataTable.Rows[0]["DefenseAddressId"]))
      {
        c.LegalInformation.DefenseAttorneyAddress = new ClaimAddress((int) dataTable.Rows[0]["DefenseAddressId"]);
        c.LegalInformation.DefenseAttorneyAddress.IsoCountryCode = dataTable.Rows[0].Field<string>("Defense_ISOCountryCode");
        c.LegalInformation.DefenseAttorneyAddress.IsInternational = (bool) dataTable.Rows[0]["Defense_IsInternational"];
        c.LegalInformation.DefenseAttorneyAddress.Address1 = dataTable.Rows[0].Field<string>("Defense_Address1");
        c.LegalInformation.DefenseAttorneyAddress.Address2 = dataTable.Rows[0].Field<string>("Defense_Address2");
        c.LegalInformation.DefenseAttorneyAddress.City = dataTable.Rows[0].Field<string>("Defense_City");
        c.LegalInformation.DefenseAttorneyAddress.State = dataTable.Rows[0].Field<string>("Defense_State");
        if (c.LegalInformation.DefenseAttorneyAddress.IsoCountryCode == "USA")
        {
          c.LegalInformation.DefenseAttorneyAddress.ZipCode = dataTable.Rows[0].Field<string>("Defense_ZipCode");
          c.LegalInformation.DefenseAttorneyAddress.ZipCodeExtension = dataTable.Rows[0].Field<string>("Defense_ZipCodeExtension");
        }
        else
          c.LegalInformation.DefenseAttorneyAddress.ZipCode = dataTable.Rows[0].Field<string>("Defense_InternationalZipCode");
        c.LegalInformation.DefenseAttorneyAddress.LoadPhoneNumbers((int) dataTable.Rows[0]["DefenseAddressId"]);
      }
    }
    c.LegalInformation.ClaimantAttorney = !Utility.IsNull(dataTable.Rows[0]["ClaimantAttorney"]) ? dataTable.Rows[0].Field<string>("ClaimantAttorney") : string.Empty;
    c.LegalInformation.ClaimantLawFirm = !Utility.IsNull(dataTable.Rows[0]["ClaimantAttorneyFirm"]) ? dataTable.Rows[0].Field<string>("ClaimantAttorneyFirm") : string.Empty;
    if (c.LegalInformation.ClaimantLawFirm.Length > 0 || c.LegalInformation.ClaimantAttorney.Length > 0)
    {
      c.LegalInformation.ClaimantAttorneyGuid = !Utility.IsNull(dataTable.Rows[0]["ClaimantAttorneyGuid"]) ? dataTable.Rows[0].Field<Guid>("ClaimantAttorneyGuid") : Guid.Empty;
      c.LegalInformation.ClaimantAttorneyFeinSsn = dataTable.Rows[0].Field<string>("ClaimantAttorneyFEINSSN");
      c.LegalInformation.ClaimantAttorneyEntityType = dataTable.Rows[0].Field<string>("ClaimantAttorneyEntityType") != "I" ? ClaimantLegalInformation.EntityType.Corporation : ClaimantLegalInformation.EntityType.Individual;
      if (!Utility.IsNull(dataTable.Rows[0]["ClaimantAttorneyAddressId"]))
      {
        c.LegalInformation.ClaimantAttorneyAddress = new ClaimAddress((int) dataTable.Rows[0]["ClaimantAttorneyAddressId"]);
        c.LegalInformation.ClaimantAttorneyAddress.IsoCountryCode = dataTable.Rows[0].Field<string>("Claimant_ISOCountryCode");
        c.LegalInformation.ClaimantAttorneyAddress.IsInternational = (bool) dataTable.Rows[0]["Claimant_IsInternational"];
        c.LegalInformation.ClaimantAttorneyAddress.Address1 = dataTable.Rows[0].Field<string>("Claimant_Address1");
        c.LegalInformation.ClaimantAttorneyAddress.Address2 = dataTable.Rows[0].Field<string>("Claimant_Address2");
        c.LegalInformation.ClaimantAttorneyAddress.City = dataTable.Rows[0].Field<string>("Claimant_City");
        c.LegalInformation.ClaimantAttorneyAddress.State = dataTable.Rows[0].Field<string>("Claimant_State");
        if (c.LegalInformation.ClaimantAttorneyAddress.IsoCountryCode == "USA")
        {
          c.LegalInformation.ClaimantAttorneyAddress.ZipCode = dataTable.Rows[0].Field<string>("Claimant_ZipCode");
          c.LegalInformation.ClaimantAttorneyAddress.ZipCodeExtension = dataTable.Rows[0].Field<string>("Claimant_ZipCodeExtension");
        }
        else
          c.LegalInformation.ClaimantAttorneyAddress.ZipCode = dataTable.Rows[0].Field<string>("Claimant_InternationalZipCode");
        c.LegalInformation.ClaimantAttorneyAddress.LoadPhoneNumbers((int) dataTable.Rows[0]["ClaimantAttorneyAddressId"]);
      }
    }
    c.LegalInformation.Judge = dataTable.Rows[0].Field<string>("Judge");
    c.LegalInformation.PublishedDecision = (bool) dataTable.Rows[0]["PublishedDecision"];
    c.LegalInformation.SuitServed = (bool) dataTable.Rows[0]["SuitServed"];
    c.LegalInformation.DateServed = dataTable.Rows[0]["DateSuitServed"] == DBNull.Value ? new DateTime?() : (DateTime?) dataTable.Rows[0]["DateSuitServed"];
    c.LegalInformation.DateAnswered = dataTable.Rows[0]["DateSuitAnswered"] == DBNull.Value ? new DateTime?() : (DateTime?) dataTable.Rows[0]["DateSuitAnswered"];
  }

  private void AddAutomatedExpense(ExpenseAutomationSetting s)
  {
    if (s.Hours == 0M && s.Rate == 0M)
      this.AddExpense(Guid.Empty, s.Description, s.AutomationCode, true, new int?(), CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, string.Empty, new Decimal?((Decimal) 1), new Decimal?(s.FlatAmount), new Decimal?(), new Decimal?(), new Decimal?());
    else
      this.AddExpense(Guid.Empty, s.Description, s.AutomationCode, true, new int?(), CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, string.Empty, new Decimal?(s.Hours), new Decimal?(s.Rate), new Decimal?(), new Decimal?(), new Decimal?());
  }

  private void AddAutomatedExpense(ExpenseAutomationSetting s, Guid claimantGuid)
  {
    if (s.Hours == 0M && s.Rate == 0M)
      this.AddExpense(claimantGuid, s.Description, s.AutomationCode, true, new int?(), CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, string.Empty, new Decimal?((Decimal) 1), new Decimal?(s.FlatAmount), new Decimal?(), new Decimal?(), new Decimal?());
    else
      this.AddExpense(claimantGuid, s.Description, s.AutomationCode, true, new int?(), CurrentUser.Instance.UserGUID, CurrentUser.Instance.DisplayName, string.Empty, new Decimal?(s.Hours), new Decimal?(s.Rate), new Decimal?(), new Decimal?(), new Decimal?());
  }

  protected virtual void AddClaimCreatedExpense()
  {
    try
    {
      ExpenseAutomationSetting automationSetting = Utility.GetExpenseAutomationSetting("CLM");
      if (!automationSetting.IsActive)
        return;
      this.AddAutomatedExpense(automationSetting);
    }
    catch (AutomatedExpenseNotFoundException ex)
    {
      throw;
    }
  }

  public void AddClaimantCreatedExpense()
  {
    try
    {
      ExpenseAutomationSetting automationSetting = Utility.GetExpenseAutomationSetting("CLMT");
      if (!automationSetting.IsActive)
        return;
      this.AddAutomatedExpense(automationSetting);
    }
    catch (AutomatedExpenseNotFoundException ex)
    {
      throw;
    }
  }

  public void AddReserveCreatedExpense()
  {
    try
    {
      ExpenseAutomationSetting automationSetting = Utility.GetExpenseAutomationSetting("RESV");
      if (!automationSetting.IsActive)
        return;
      this.AddAutomatedExpense(automationSetting);
    }
    catch (AutomatedExpenseNotFoundException ex)
    {
      throw;
    }
  }

  public void AddPaymentCreatedExpense()
  {
    try
    {
      ExpenseAutomationSetting automationSetting = Utility.GetExpenseAutomationSetting("PYMT");
      if (!automationSetting.IsActive)
        return;
      this.AddAutomatedExpense(automationSetting);
    }
    catch (AutomatedExpenseNotFoundException ex)
    {
      throw;
    }
  }

  public virtual void AddClaimClosedExpense()
  {
    try
    {
      ExpenseAutomationSetting automationSetting = Utility.GetExpenseAutomationSetting("CLCL");
      if (!automationSetting.IsActive)
        return;
      this.AddAutomatedExpense(automationSetting);
    }
    catch (AutomatedExpenseNotFoundException ex)
    {
      throw;
    }
  }

  public bool Save()
  {
    if (this.Claimants.Count == 0)
      throw new NoClaimantsSpecifiedException(Resources.NOCLAIMANTS_SPECIFIED_EXCEPTION);
    bool subscribersSuccessful = true;
    try
    {
      if (DefaultDatabase.HasTransaction)
      {
        try
        {
          subscribersSuccessful = this.OnBeforeSaveClaimCommitted();
          if (subscribersSuccessful)
            this.SaveClaim();
        }
        catch (Exception ex)
        {
          throw;
        }
      }
      else
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
        {
          try
          {
            subscribersSuccessful = this.OnBeforeClaimVerifyCompleted();
            if (subscribersSuccessful)
            {
              this.SaveClaim();
              if (this.OnBeforeSaveClaimCommitted())
              {
                e.Transaction.Commit();
              }
              else
              {
                this._claimId = new int?();
                e.Transaction.Rollback();
              }
            }
            else
            {
              e.Transaction.Rollback();
              subscribersSuccessful = false;
            }
          }
          catch (Exception ex)
          {
            subscribersSuccessful = false;
            throw;
          }
        }));
      if (subscribersSuccessful)
        this.OnUpdateBroadcast();
      if (this._loggingList != null)
      {
        if (this._claimId.HasValue)
        {
          Utility.SaveLoggedActions(this._loggingList, this._claimId.Value);
          this._loggingList.Clear();
        }
      }
    }
    catch (Exception ex)
    {
      subscribersSuccessful = false;
      throw;
    }
    return subscribersSuccessful;
  }

  private void SaveClaim()
  {
    if (!this.ClaimId.HasValue)
    {
      try
      {
        this.GenerateClaimNumber();
      }
      catch (ClaimNumberingException ex)
      {
        throw;
      }
      this._claimId = new int?(this.SaveClaimHeader());
      Guid eventGuid = new Guid("{6300B08D-A940-46ed-9B86-03D27EF14C5C}");
      int? claimId = this.ClaimId;
      // ISSUE: variable of a boxed type
      __Boxed<Guid> claimGuid = (System.ValueType) Utility.GetClaimGuid(claimId.Value);
      Messaging.SendBroadcastMessage(eventGuid, (object) claimGuid);
      this.SavePolicyInformation();
      this.SaveClaimants();
      this.SaveClaimActivity();
      this.SaveClaimExpenses();
      this.SaveAccidentInformation();
      this.UpdateIMSClaimActivity();
      ClaimDriverInformation driverInfo = this.DriverInfo;
      claimId = this.ClaimId;
      int num = claimId.Value;
      driverInfo.ClaimId = num;
      this.DriverInfo.Save();
    }
    else
    {
      try
      {
        this.UpdateClaimHeader();
        this.SaveClaimActivity();
        this.SaveClaimants();
        this.SaveClaimExpenses();
        this.SaveAccidentInformation();
        this.UpdateIMSClaimActivity();
        this.UpdatePolicyAggregates();
        this.DriverInfo.ClaimId = this.ClaimId.Value;
        this.DriverInfo.Save();
      }
      catch (Exception ex)
      {
        throw;
      }
    }
    this._hasChanges = false;
  }

  private void UpdatePolicyAggregates()
  {
    this._policyAggregates = new ClaimPolicyAggregates(this.ControlNumber);
  }

  protected virtual void UpdateClaimHeader()
  {
    DefaultDatabase.ExecuteScalar("spClaims_UpdateClaim_Header", new object[14]
    {
      (object) "@ClaimId",
      (object) this.ClaimId,
      (object) "@userGuid",
      (object) this.UserGuid,
      (object) "@lossDate",
      (object) this.LossDate,
      (object) "@catastropheCode",
      (object) this.CatastropheCode,
      (object) "@companyCatastropheCode",
      (object) this.CompanyCatastropheCode,
      (object) "@ClaimComments",
      (object) this.ClaimComments,
      (object) "@InhouseAdjuster",
      (object) this.InhouseAdjuster
    });
  }

  protected virtual void UpdateIMSClaimActivity()
  {
    DefaultDatabase.ExecuteScalar("spClaims_TransferBase", new object[2]
    {
      (object) "@ClaimId",
      (object) this.ClaimId
    });
  }

  protected virtual int SaveClaimHeader()
  {
    return int.Parse(DefaultDatabase.ExecuteScalar("spClaims_InsertClaim_Header", new object[22]
    {
      (object) "@controlNo",
      (object) this.ControlNumber,
      (object) "@userGuid",
      (object) this.UserGuid,
      (object) "@claimNumber",
      (object) this.ClaimNumber,
      (object) "@lossDate",
      (object) this.LossDate,
      (object) "@catastropheCode",
      (object) this.CatastropheCode,
      (object) "@companyCatastropheCode",
      (object) this.CompanyCatastropheCode,
      (object) "@claimNumberRuleId",
      (object) this.NumberingRuleId,
      (object) "@numericClaimNumber",
      (object) this.NumericClaimNumber,
      (object) "@IsManualClaimNumber",
      (object) this.IsManualClaimNumber,
      (object) "@ClaimComments",
      (object) this.ClaimComments,
      (object) "@InhouseAdjuster",
      (object) this.InhouseAdjuster
    }).ToString());
  }

  private void SavePolicyInformation()
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertClaim_PolicyInformation", new object[16 /*0x10*/]
    {
      (object) "@claimId",
      (object) this.ClaimId,
      (object) "@policyNumber",
      (object) this.PolicyInformation.PolicyNumber,
      (object) "@companyGuid",
      (object) this.PolicyInformation.CompanyGuid,
      (object) "@producerLocationGuid",
      (object) this.PolicyInformation.ProducerLocationGuid,
      (object) "@insuredGuid",
      (object) this.PolicyInformation.InsuredGuid,
      (object) "@CompanylocationGuid",
      (object) this.PolicyInformation.CompanyLocationGuid,
      (object) "@lineGuid",
      (object) this.PolicyInformation.LineGuid,
      (object) "@ControlNumber",
      (object) this.ControlNumber
    });
  }

  private void SaveClaimants()
  {
    foreach (Claimant claimant in (Collection<Claimant>) this.Claimants)
    {
      if (claimant.EditState == Claimant.ClaimantState.New || claimant.EditState == Claimant.ClaimantState.UpdatedNew)
        claimant.Save(this._claimId.Value);
      if (claimant.EditState == Claimant.ClaimantState.Updated)
        claimant.Update();
    }
  }

  protected virtual void GenerateClaimNumber()
  {
    DataTable claimNumber = this.ExecuteGenerateClaimNumber();
    if (claimNumber.Rows.Count == 0)
      throw new ClaimNumberingException(Resources.CLAIMNUMBERING_NOACTIVERULES);
    this.SetClaimNumberValues(claimNumber);
  }

  protected virtual DataTable ExecuteGenerateClaimNumber()
  {
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.GenerateClaimNumber(@CompanyGuid, @CompanyLocationGuid, @LineGuid, @EffectiveDate)", new object[8]
    {
      (object) "@CompanyGuid",
      (object) this.PolicyInformation.CompanyGuid,
      (object) "@CompanyLocationGuid",
      (object) this.PolicyInformation.CompanyLocationGuid,
      (object) "@LineGuid",
      (object) this.PolicyInformation.LineGuid,
      (object) "@EffectiveDate",
      (object) DateTime.Now
    });
  }

  protected void SetClaimNumberValues(DataTable dt)
  {
    if (!(bool) dt.Rows[0]["IsManual"])
    {
      if (dt.Rows[0]["RuleId"] != null && !string.IsNullOrEmpty(dt.Rows[0]["RuleId"].ToString()))
        this._numberingRuleId = (int) dt.Rows[0]["RuleId"];
      this._numericClaimNumber = (int) dt.Rows[0]["NumericClaimNumber"];
      this._claimNumber = dt.Rows[0]["ClaimNumber"].ToString();
      this._isManualClaimNumber = false;
    }
    else
    {
      if (dt.Rows[0]["RuleId"] != null && !string.IsNullOrEmpty(dt.Rows[0]["RuleId"].ToString()))
        this._numberingRuleId = (int) dt.Rows[0]["RuleId"];
      this._numericClaimNumber = 0;
      this._isManualClaimNumber = true;
    }
  }

  private void SaveClaimActivity()
  {
    foreach (ClaimActivity claimActivity1 in (Collection<ClaimActivity>) this.ClaimActivities)
    {
      int? nullable = claimActivity1.ActivityId;
      if (!nullable.HasValue)
      {
        ClaimActivity claimActivity2 = claimActivity1;
        nullable = this.ClaimId;
        int claimId = nullable.Value;
        claimActivity2.Save(claimId);
      }
    }
  }

  private void SaveAccidentInformation()
  {
    this._accidentinfo.ClaimId = this._claimId.Value;
    this._accidentinfo.Save();
  }

  protected virtual void SaveClaimExpenses()
  {
    if (this._unallocatedExpenses == null)
      return;
    foreach (dsUnallocatedExpenses.ExpenseListRow expense in (TypedTableBase<dsUnallocatedExpenses.ExpenseListRow>) this._unallocatedExpenses.ExpenseList)
    {
      if (expense.UAExpenseId == -1)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertClaimExpense", new object[22]
        {
          (object) "@ClaimId",
          (object) this.ClaimId,
          (object) "@AutomationCode",
          (object) (string.IsNullOrEmpty(expense.AutomationCode) ? SqlString.Null : (SqlString) expense.AutomationCode),
          (object) "@ExpenseId",
          (object) (expense.ExpenseId == -1 ? SqlInt32.Null : (SqlInt32) expense.ExpenseId),
          (object) "@UserGuid",
          (object) expense.UserGuid,
          (object) "@Hours",
          (object) expense.Hours,
          (object) "@HourlyRate",
          (object) expense.HourlyRate,
          (object) "@EquipmentRate",
          (object) expense.EquipmentRate,
          (object) "@OtherRate",
          (object) expense.OtherCost,
          (object) "@OtherAmount",
          (object) expense.OtherCount,
          (object) "@Comments",
          (object) (string.IsNullOrEmpty(expense.Comments) ? SqlString.Null : (SqlString) expense.Comments),
          (object) "@trxDate",
          (object) expense.DateEntered
        });
    }
  }

  public void Dispose() => this._dsClaimants.Dispose();

  bool INotifyChanges.HasChanges
  {
    get => this._hasChanges;
    set => this._hasChanges = value;
  }

  public Decimal GetTotalReserves()
  {
    Decimal totalReserves = 0M;
    foreach (Claimant claimant in (Collection<Claimant>) this.Claimants)
      totalReserves += claimant.ReserveTotal();
    return totalReserves;
  }

  public Decimal GetTotalPayments()
  {
    Decimal totalPayments = 0M;
    foreach (Claimant claimant in (Collection<Claimant>) this.Claimants)
      totalPayments += claimant.PaymentTotal();
    return totalPayments;
  }

  public Decimal GetExpenseReserves()
  {
    Decimal expenseReserves = 0M;
    foreach (Claimant claimant in (Collection<Claimant>) this.Claimants)
      expenseReserves += claimant.ExpenseTotal();
    return expenseReserves;
  }

  public void InitiaiteUpdateBroadcast() => this.OnUpdateBroadcast();

  public List<string> LoggingList
  {
    get
    {
      if (this._loggingList == null)
        this._loggingList = new List<string>();
      return this._loggingList;
    }
  }
}
