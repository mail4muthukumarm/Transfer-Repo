// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GlCompany
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Accounting;

public class GlCompany
{
  private int glCompanyId;
  private Guid glCompanyGuid;
  private string glCompanyName;
  private Utilities.AccountingMethod officeAccountingMethod;
  private int PrimaryBankGLAccountId;
  private int AgencyBillBankGLAccountId;
  private int DirectBillBankGLAccountId;
  private int OperatingBankGLAccountId;
  private int CommissonIncomeGLAccountId;
  private int CommissonPayableGLAccountId;
  private int FeesIncomeGLAccountId;
  private int RemitterCommissionIncomeGLAccountId;
  private int RemitterCommissionExpenseGLAccountId;
  private int AccruedExpenseAutomationGLAccountId;
  private int PrepaidExpenseAutomationGLAccountId;
  private Utilities.CommissionRecognition commRecognition;
  private Utilities.CommissionReconciliation commReconciliation;
  private GLAccount primaryBankAccount;
  private GLAccount agencyBillBankAccount;
  private GLAccount directBillBankAccount;
  private GLAccount operatingBankAccount;
  private GLAccount commissionIncomeAccount;
  private GLAccount feesIncomeAccount;
  private GLAccount remitterCommissionIncomeAccount;
  private GLAccount remitterCommissionExpenseAccount;
  private GLAccount accruedExpenseAutomationAccount;
  private GLAccount prepaidExpenseAutomationAccount;
  private GLAccount commissionsPayableAccount;
  private Decimal assetWriteOff;
  private Decimal liabilityWriteOff;
  private DateTime closeDate;
  private Utilities.CommissionReconciliation commissionReconcilation;
  private Utilities.CommissionRecognition commissionRecognition;
  private GLClass assetsClass;
  private GLClass expensesClass;
  private GLClass equityClass;
  private GLClass incomeClass;
  private GLClass liabilityClass;
  private int defaultCostCenterId;

  public int GlCompanyId => this.glCompanyId;

  public string GlCompanyName => this.glCompanyName;

  public Guid GlCompanyGuid => this.glCompanyGuid;

  public Utilities.AccountingMethod OfficeAccountingMethod => this.officeAccountingMethod;

  public GLAccount PrimaryBankAccount
  {
    get
    {
      if (this.primaryBankAccount == null)
      {
        if (this.PrimaryBankGLAccountId == 0)
          return (GLAccount) null;
        this.primaryBankAccount = new GLAccount(this.PrimaryBankGLAccountId);
      }
      return this.primaryBankAccount;
    }
  }

  public GLAccount AgencyBillBankAccount
  {
    get
    {
      if (this.agencyBillBankAccount == null)
      {
        if (this.AgencyBillBankGLAccountId == 0)
          return (GLAccount) null;
        this.agencyBillBankAccount = new GLAccount(this.AgencyBillBankGLAccountId);
      }
      return this.agencyBillBankAccount;
    }
  }

  public GLAccount DirectBillBankAccount
  {
    get
    {
      if (this.directBillBankAccount == null)
      {
        if (this.DirectBillBankGLAccountId == 0)
          return (GLAccount) null;
        this.directBillBankAccount = new GLAccount(this.DirectBillBankGLAccountId);
      }
      return this.directBillBankAccount;
    }
  }

  public GLAccount OperatingBankAccount
  {
    get
    {
      if (this.operatingBankAccount == null)
      {
        if (this.OperatingBankGLAccountId == 0)
          return (GLAccount) null;
        this.operatingBankAccount = new GLAccount(this.OperatingBankGLAccountId);
      }
      return this.operatingBankAccount;
    }
  }

  public GLAccount CommissionIncomeAccount
  {
    get
    {
      if (this.commissionIncomeAccount == null)
      {
        if (this.CommissonIncomeGLAccountId == 0)
          return (GLAccount) null;
        this.commissionIncomeAccount = new GLAccount(this.CommissonIncomeGLAccountId);
      }
      return this.operatingBankAccount;
    }
  }

  public GLAccount FeesIncomeAccount
  {
    get
    {
      if (this.feesIncomeAccount == null)
      {
        if (this.FeesIncomeGLAccountId == 0)
          return (GLAccount) null;
        this.feesIncomeAccount = new GLAccount(this.FeesIncomeGLAccountId);
      }
      return this.feesIncomeAccount;
    }
  }

  public GLAccount RemitterCommissionIncomeAccount
  {
    get
    {
      if (this.remitterCommissionIncomeAccount == null)
      {
        if (this.RemitterCommissionIncomeGLAccountId == 0)
          return (GLAccount) null;
        this.remitterCommissionIncomeAccount = new GLAccount(this.RemitterCommissionIncomeGLAccountId);
      }
      return this.remitterCommissionIncomeAccount;
    }
  }

  public GLAccount RemitterCommissionExpenseAccount
  {
    get
    {
      if (this.remitterCommissionExpenseAccount == null)
      {
        if (this.RemitterCommissionExpenseGLAccountId == 0)
          return (GLAccount) null;
        this.remitterCommissionExpenseAccount = new GLAccount(this.RemitterCommissionExpenseGLAccountId);
      }
      return this.remitterCommissionExpenseAccount;
    }
  }

  public GLAccount AccruedExpenseAutomationAccount
  {
    get
    {
      if (this.accruedExpenseAutomationAccount == null)
      {
        if (this.AccruedExpenseAutomationGLAccountId == 0)
          return (GLAccount) null;
        this.accruedExpenseAutomationAccount = new GLAccount(this.AccruedExpenseAutomationGLAccountId);
      }
      return this.accruedExpenseAutomationAccount;
    }
  }

  public GLAccount PrepaidExpenseAutomationAccount
  {
    get
    {
      if (this.prepaidExpenseAutomationAccount == null)
      {
        if (this.PrepaidExpenseAutomationGLAccountId == 0)
          return (GLAccount) null;
        this.prepaidExpenseAutomationAccount = new GLAccount(this.PrepaidExpenseAutomationGLAccountId);
      }
      return this.prepaidExpenseAutomationAccount;
    }
  }

  public GLAccount CommissionsPayableAccount
  {
    get
    {
      if (this.commissionsPayableAccount == null)
      {
        if (this.CommissonPayableGLAccountId == 0)
          return (GLAccount) null;
        this.commissionsPayableAccount = new GLAccount(this.CommissonPayableGLAccountId);
      }
      return this.commissionsPayableAccount;
    }
  }

  public Decimal AssetWriteOff => this.assetWriteOff;

  public Decimal LiabilityWriteOff => this.liabilityWriteOff;

  private Utilities.CommissionRecognition CommRecognition => this.commRecognition;

  private Utilities.CommissionReconciliation CommReconciliation => this.commReconciliation;

  public DateTime CloseDate => this.closeDate;

  public Utilities.CommissionReconciliation CommissionReconciliation
  {
    get => this.commissionReconcilation;
  }

  public Utilities.CommissionRecognition CommissionRecognition => this.commissionRecognition;

  public GLClass AssetsClass
  {
    get
    {
      if (this.assetsClass == null)
        this.assetsClass = new GLClass(GLAccountClassType.Assets, this.GlCompanyId);
      return this.assetsClass;
    }
  }

  public GLClass ExpensesClass
  {
    get
    {
      if (this.expensesClass == null)
        this.expensesClass = new GLClass(GLAccountClassType.Expenses, this.GlCompanyId);
      return this.expensesClass;
    }
  }

  public GLClass EquityClass
  {
    get
    {
      if (this.equityClass == null)
        this.equityClass = new GLClass(GLAccountClassType.Equity, this.GlCompanyId);
      return this.equityClass;
    }
  }

  public GLClass IncomeClass
  {
    get
    {
      if (this.incomeClass == null)
        this.incomeClass = new GLClass(GLAccountClassType.Income, this.GlCompanyId);
      return this.incomeClass;
    }
  }

  public GLClass LiabilityClass
  {
    get
    {
      if (this.liabilityClass == null)
        this.liabilityClass = new GLClass(GLAccountClassType.Liability, this.GlCompanyId);
      return this.liabilityClass;
    }
  }

  public int DefaultCostCenterId
  {
    get
    {
      if (this.defaultCostCenterId == 0)
        this.defaultCostCenterId = this.GetDefaultCostCenterId(this.GlCompanyId);
      return this.defaultCostCenterId;
    }
  }

  public GlCompany(int GlCompanyId)
  {
    this.glCompanyId = GlCompanyId;
    this.LoadOfficeLocation();
  }

  private void LoadOfficeLocation()
  {
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetGlCompany", (object) "@glCompanyId", (object) this.GlCompanyId);
    if (dataTable != null && dataTable.Rows.Count != 0)
    {
      int count = dataTable.Rows.Count;
    }
    this.glCompanyGuid = new Guid(dataTable.Rows[0]["officeguid"].ToString());
    this.glCompanyName = dataTable.Rows[0]["location"].ToString();
    this.assetWriteOff = Decimal.Parse(dataTable.Rows[0]["assetwriteoff"].ToString());
    this.liabilityWriteOff = Decimal.Parse(dataTable.Rows[0]["liabilitywriteoff"].ToString());
    this.commRecognition = !(dataTable.Rows[0]["commrecognition"].ToString() != "P") || !(dataTable.Rows[0]["commrecognition"].ToString() != "F") ? (!(dataTable.Rows[0]["commrecognition"].ToString() == "P") ? Utilities.CommissionRecognition.Full : Utilities.CommissionRecognition.Proportional) : Utilities.CommissionRecognition.None;
    this.commReconciliation = (Utilities.CommissionReconciliation) int.Parse(dataTable.Rows[0]["commreconciliation"].ToString(), NumberStyles.Float);
    if (!dataTable.Rows[0]["pba"].Equals((object) DBNull.Value) && !dataTable.Rows[0]["pba"].ToString().Equals(string.Empty))
      this.PrimaryBankGLAccountId = int.Parse(dataTable.Rows[0]["pba"].ToString());
    if (!dataTable.Rows[0]["abb"].Equals((object) DBNull.Value) && !dataTable.Rows[0]["abb"].ToString().Equals(string.Empty))
      this.AgencyBillBankGLAccountId = int.Parse(dataTable.Rows[0]["abb"].ToString());
    if (!dataTable.Rows[0]["dbb"].Equals((object) DBNull.Value) && !dataTable.Rows[0]["dbb"].ToString().Equals(string.Empty))
      this.DirectBillBankGLAccountId = int.Parse(dataTable.Rows[0]["dbb"].ToString());
    if (!dataTable.Rows[0]["oba"].Equals((object) DBNull.Value) && !dataTable.Rows[0]["oba"].ToString().Equals(string.Empty))
      this.OperatingBankGLAccountId = int.Parse(dataTable.Rows[0]["oba"].ToString());
    this.CommissonIncomeGLAccountId = int.Parse(dataTable.Rows[0]["mci"].ToString());
    this.FeesIncomeGLAccountId = int.Parse(dataTable.Rows[0]["fci"].ToString());
    this.RemitterCommissionIncomeGLAccountId = int.Parse(dataTable.Rows[0]["rci"].ToString());
    this.RemitterCommissionExpenseGLAccountId = int.Parse(dataTable.Rows[0]["rce"].ToString());
    this.CommissonPayableGLAccountId = int.Parse(dataTable.Rows[0]["apc"].ToString());
    if (!dataTable.Rows[0]["COMMRECONCILE"].Equals((object) DBNull.Value))
    {
      switch (int.Parse(dataTable.Rows[0]["COMMRECONCILE"].ToString()))
      {
        case 1:
          this.commissionReconcilation = Utilities.CommissionReconciliation.Receivables;
          break;
        case 2:
          this.commissionReconcilation = Utilities.CommissionReconciliation.Payables;
          break;
        default:
          this.commissionReconcilation = Utilities.CommissionReconciliation.None;
          break;
      }
    }
    else
      this.commissionReconcilation = Utilities.CommissionReconciliation.None;
    if (!dataTable.Rows[0]["COMMRECOG"].Equals((object) DBNull.Value))
    {
      switch (dataTable.Rows[0]["COMMRECOG"].ToString())
      {
        case "P":
          this.commissionRecognition = Utilities.CommissionRecognition.Proportional;
          break;
        case "F":
          this.commissionRecognition = Utilities.CommissionRecognition.Full;
          break;
        default:
          this.commissionRecognition = Utilities.CommissionRecognition.None;
          break;
      }
    }
    else
      this.commissionRecognition = Utilities.CommissionRecognition.None;
    if (!dataTable.Rows[0]["ppe"].ToString().Equals(string.Empty))
      this.PrepaidExpenseAutomationGLAccountId = int.Parse(dataTable.Rows[0]["ppe"].ToString());
    if (!dataTable.Rows[0]["ace"].ToString().Equals(string.Empty))
      this.AccruedExpenseAutomationGLAccountId = int.Parse(dataTable.Rows[0]["ace"].ToString());
    this.officeAccountingMethod = !(dataTable.Rows[0]["accountingmethod"].ToString() != "C") || !(dataTable.Rows[0]["accountingmethod"].ToString() != "A") ? (!(dataTable.Rows[0]["accountingmethod"].ToString() == "C") ? Utilities.AccountingMethod.Accrual : Utilities.AccountingMethod.Cash) : Utilities.AccountingMethod.NotDefined;
    this.closeDate = DateTime.Parse(dataTable.Rows[0]["closedDate"].ToString());
  }

  public bool ViolatesClosedDate(DateTime date) => date > this.CloseDate;

  public dsBankAccounts GetBankAccounts()
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetBankAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glCompanyId", (object) this.GlCompanyId);
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      dsBankAccounts bankAccounts = new dsBankAccounts();
      sqlDataAdapter.Fill((DataTable) bankAccounts.spFin_GetBankAccounts);
      return bankAccounts;
    }
  }

  private int GetDefaultCostCenterId(int glCompanyId)
  {
    using (SqlCommand sqlCommand = new SqlCommand("spFin_GetDefaultCostCenter", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
      return (int) sqlCommand.ExecuteScalar();
    }
  }
}
