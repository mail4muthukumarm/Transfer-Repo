// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Strings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Strings
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Strings()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (Strings.resourceMan == null)
        Strings.resourceMan = new ResourceManager("MGASystems.IMS.Accounting.Services.Strings", typeof (Strings).Assembly);
      return Strings.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Strings.resourceCulture;
    set => Strings.resourceCulture = value;
  }

  internal static string AllocatedAmountMustBeNumeric
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocatedAmountMustBeNumeric), Strings.resourceCulture);
    }
  }

  internal static string ALLOCATIONEXCEEDSEXPENSEEXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ALLOCATIONEXCEEDSEXPENSEEXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string AllocationGreaterThanExpense
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocationGreaterThanExpense), Strings.resourceCulture);
    }
  }

  internal static string AllocationLessThanZero
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocationLessThanZero), Strings.resourceCulture);
    }
  }

  internal static string AllocationWillExceedUnAllocatedBalance
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (AllocationWillExceedUnAllocatedBalance), Strings.resourceCulture);
    }
  }

  internal static string BankAccountRequiredToContinue
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (BankAccountRequiredToContinue), Strings.resourceCulture);
    }
  }

  internal static string CANNOT_SAVE_DETAILITEM
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (CANNOT_SAVE_DETAILITEM), Strings.resourceCulture);
    }
  }

  internal static string COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string COSTCENTER_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (COSTCENTER_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string DeleteExistingExpenseFor
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (DeleteExistingExpenseFor), Strings.resourceCulture);
    }
  }

  internal static string DeleteExpenseForHeader
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (DeleteExpenseForHeader), Strings.resourceCulture);
    }
  }

  internal static string EmptyString
  {
    get => Strings.ResourceManager.GetString(nameof (EmptyString), Strings.resourceCulture);
  }

  internal static string ERROR_LOADING_COSTCENTER
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ERROR_LOADING_COSTCENTER), Strings.resourceCulture);
    }
  }

  internal static string ErrorLoadingCostCenterAllocations
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ErrorLoadingCostCenterAllocations), Strings.resourceCulture);
    }
  }

  internal static string EXPENSE_DETAILITEM_EXISTS_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_DETAILITEM_EXISTS_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string EXPENSE_DETAILS_OBJECTS_INCOMPLETE
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_DETAILS_OBJECTS_INCOMPLETE), Strings.resourceCulture);
    }
  }

  internal static string EXPENSE_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string EXPENSE_SCHEDULER_HEADERTEXT
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EXPENSE_SCHEDULER_HEADERTEXT), Strings.resourceCulture);
    }
  }

  internal static string ExpenseAllocationNotComplete
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ExpenseAllocationNotComplete), Strings.resourceCulture);
    }
  }

  internal static string ExpenseMustBeFullyAllocated
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ExpenseMustBeFullyAllocated), Strings.resourceCulture);
    }
  }

  internal static string ExpenseRequiredToContinue
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ExpenseRequiredToContinue), Strings.resourceCulture);
    }
  }

  internal static string GetExpenseDefaultGlException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (GetExpenseDefaultGlException), Strings.resourceCulture);
    }
  }

  internal static string GL_ACCOUNT_REQUIRED
  {
    get => Strings.ResourceManager.GetString(nameof (GL_ACCOUNT_REQUIRED), Strings.resourceCulture);
  }

  internal static string InvalidAllocation
  {
    get => Strings.ResourceManager.GetString(nameof (InvalidAllocation), Strings.resourceCulture);
  }

  internal static string INVALIDENTRY
  {
    get => Strings.ResourceManager.GetString(nameof (INVALIDENTRY), Strings.resourceCulture);
  }

  internal static string InvalidFormOwnerException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (InvalidFormOwnerException), Strings.resourceCulture);
    }
  }

  internal static string NO_EXPENSE_DETAILS
  {
    get => Strings.ResourceManager.GetString(nameof (NO_EXPENSE_DETAILS), Strings.resourceCulture);
  }

  internal static string NO_EXPENSES_DEFINED
  {
    get => Strings.ResourceManager.GetString(nameof (NO_EXPENSES_DEFINED), Strings.resourceCulture);
  }

  internal static string NO_OFFICE_LOCATIONS
  {
    get => Strings.ResourceManager.GetString(nameof (NO_OFFICE_LOCATIONS), Strings.resourceCulture);
  }

  internal static string OFFICELOCATION_REQUIRED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OFFICELOCATION_REQUIRED), Strings.resourceCulture);
    }
  }

  internal static string OverwriteAllocationHeader
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OverwriteAllocationHeader), Strings.resourceCulture);
    }
  }

  internal static string OverwriteExistingCostCenterAllocations
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OverwriteExistingCostCenterAllocations), Strings.resourceCulture);
    }
  }

  internal static string PAYEEGUID_NOTSET_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (PAYEEGUID_NOTSET_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string PayeeRequiredToContinue
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (PayeeRequiredToContinue), Strings.resourceCulture);
    }
  }

  internal static string PURCHASEORDER_EXPENSE_DETAIL_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (PURCHASEORDER_EXPENSE_DETAIL_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string RequiredFieldMissing
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (RequiredFieldMissing), Strings.resourceCulture);
    }
  }

  internal static string SCHEDULEDETAIL_NOTFOUND_EXCEPTION
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (SCHEDULEDETAIL_NOTFOUND_EXCEPTION), Strings.resourceCulture);
    }
  }

  internal static string ValidDiscountAmountRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ValidDiscountAmountRequired), Strings.resourceCulture);
    }
  }

  internal static string ValidExpenseAmountRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ValidExpenseAmountRequired), Strings.resourceCulture);
    }
  }

  internal static string ZERO_EXPENSE_AMOUNT
  {
    get => Strings.ResourceManager.GetString(nameof (ZERO_EXPENSE_AMOUNT), Strings.resourceCulture);
  }

  internal static string ZERO_EXPENSE_AMOUNT_TITLE
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ZERO_EXPENSE_AMOUNT_TITLE), Strings.resourceCulture);
    }
  }

  internal static string ZeroDollarAmount
  {
    get => Strings.ResourceManager.GetString(nameof (ZeroDollarAmount), Strings.resourceCulture);
  }

  internal static string ZeroPercentage
  {
    get => Strings.ResourceManager.GetString(nameof (ZeroPercentage), Strings.resourceCulture);
  }
}
