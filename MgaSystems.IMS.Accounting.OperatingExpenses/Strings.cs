// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Strings
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Strings
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Strings()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public static ResourceManager ResourceManager
  {
    get
    {
      if (Strings.resourceMan == null)
        Strings.resourceMan = new ResourceManager("MGASystems.IMS.Accounting.OperatingExpenses.Strings", typeof (Strings).Assembly);
      return Strings.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public static CultureInfo Culture
  {
    get => Strings.resourceCulture;
    set => Strings.resourceCulture = value;
  }

  public static string AllocatedAmountMustBeNumeric
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocatedAmountMustBeNumeric), Strings.resourceCulture);
    }
  }

  public static string ALLOCATIONEXCEEDSEXPENSEEXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ALLOCATIONEXCEEDSEXPENSEEXCEPTION), Strings.resourceCulture);
    }
  }

  public static string AllocationGreaterThanExpense
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocationGreaterThanExpense), Strings.resourceCulture);
    }
  }

  public static string AllocationLessThanZero
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocationLessThanZero), Strings.resourceCulture);
    }
  }

  public static string AllocationWillExceedUnAllocatedBalance
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocationWillExceedUnAllocatedBalance), Strings.resourceCulture);
    }
  }

  public static string BankAccountRequiredToContinue
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (BankAccountRequiredToContinue), Strings.resourceCulture);
    }
  }

  public static string CANNOT_SAVE_DETAILITEM
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (CANNOT_SAVE_DETAILITEM), Strings.resourceCulture);
    }
  }

  public static string COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string COSTCENTER_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (COSTCENTER_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string DeleteExistingExpenseFor
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (DeleteExistingExpenseFor), Strings.resourceCulture);
    }
  }

  public static string DeleteExpenseForHeader
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (DeleteExpenseForHeader), Strings.resourceCulture);
    }
  }

  public static string EmptyString
  {
    get => Strings.ResourceManager.GetString(nameof (EmptyString), Strings.resourceCulture);
  }

  public static string ERROR_LOADING_COSTCENTER
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ERROR_LOADING_COSTCENTER), Strings.resourceCulture);
    }
  }

  public static string ErrorLoadingCostCenterAllocations
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ErrorLoadingCostCenterAllocations), Strings.resourceCulture);
    }
  }

  public static string EXPENSE_DETAILITEM_EXISTS_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_DETAILITEM_EXISTS_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string EXPENSE_DETAILS_OBJECTS_INCOMPLETE
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_DETAILS_OBJECTS_INCOMPLETE), Strings.resourceCulture);
    }
  }

  public static string EXPENSE_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string EXPENSE_SCHEDULER_HEADERTEXT
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_SCHEDULER_HEADERTEXT), Strings.resourceCulture);
    }
  }

  public static string ExpenseAllocationNotComplete
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ExpenseAllocationNotComplete), Strings.resourceCulture);
    }
  }

  public static string ExpenseMustBeFullyAllocated
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ExpenseMustBeFullyAllocated), Strings.resourceCulture);
    }
  }

  public static string ExpenseRequiredToContinue
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ExpenseRequiredToContinue), Strings.resourceCulture);
    }
  }

  public static string GetExpenseDefaultGlException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (GetExpenseDefaultGlException), Strings.resourceCulture);
    }
  }

  public static string GL_ACCOUNT_REQUIRED
  {
    get => Strings.ResourceManager.GetString(nameof (GL_ACCOUNT_REQUIRED), Strings.resourceCulture);
  }

  public static string InvalidAllocation
  {
    get => Strings.ResourceManager.GetString(nameof (InvalidAllocation), Strings.resourceCulture);
  }

  public static string INVALIDENTRY
  {
    get => Strings.ResourceManager.GetString(nameof (INVALIDENTRY), Strings.resourceCulture);
  }

  public static string InvalidFormOwnerException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (InvalidFormOwnerException), Strings.resourceCulture);
    }
  }

  public static string NO_EXPENSE_DETAILS
  {
    get => Strings.ResourceManager.GetString(nameof (NO_EXPENSE_DETAILS), Strings.resourceCulture);
  }

  public static string NO_EXPENSES_DEFINED
  {
    get => Strings.ResourceManager.GetString(nameof (NO_EXPENSES_DEFINED), Strings.resourceCulture);
  }

  public static string NO_OFFICE_LOCATIONS
  {
    get => Strings.ResourceManager.GetString(nameof (NO_OFFICE_LOCATIONS), Strings.resourceCulture);
  }

  public static string OFFICELOCATION_REQUIRED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OFFICELOCATION_REQUIRED), Strings.resourceCulture);
    }
  }

  public static string OverwriteAllocationHeader
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OverwriteAllocationHeader), Strings.resourceCulture);
    }
  }

  public static string OverwriteExistingCostCenterAllocations
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OverwriteExistingCostCenterAllocations), Strings.resourceCulture);
    }
  }

  public static string PAYEEGUID_NOTSET_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (PAYEEGUID_NOTSET_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string PayeeRequiredToContinue
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (PayeeRequiredToContinue), Strings.resourceCulture);
    }
  }

  public static string PURCHASEORDER_EXPENSE_DETAIL_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (PURCHASEORDER_EXPENSE_DETAIL_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string RequiredFieldMissing
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (RequiredFieldMissing), Strings.resourceCulture);
    }
  }

  public static string SCHEDULEDETAIL_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (SCHEDULEDETAIL_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  public static string ValidDiscountAmountRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ValidDiscountAmountRequired), Strings.resourceCulture);
    }
  }

  public static string ValidExpenseAmountRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ValidExpenseAmountRequired), Strings.resourceCulture);
    }
  }

  public static string ZERO_EXPENSE_AMOUNT
  {
    get => Strings.ResourceManager.GetString(nameof (ZERO_EXPENSE_AMOUNT), Strings.resourceCulture);
  }

  public static string ZERO_EXPENSE_AMOUNT_TITLE
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ZERO_EXPENSE_AMOUNT_TITLE), Strings.resourceCulture);
    }
  }

  public static string ZeroDollarAmount
  {
    get => Strings.ResourceManager.GetString(nameof (ZeroDollarAmount), Strings.resourceCulture);
  }

  public static string ZeroPercentage
  {
    get => Strings.ResourceManager.GetString(nameof (ZeroPercentage), Strings.resourceCulture);
  }
}
