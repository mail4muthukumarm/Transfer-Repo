// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Strings
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger;

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
        Strings.resourceMan = new ResourceManager("MGASystems.IMS.Accounting.GeneralLedger.Strings", typeof (Strings).Assembly);
      return Strings.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Strings.resourceCulture;
    set => Strings.resourceCulture = value;
  }

  internal static string AdjustmentEntry
  {
    get => Strings.ResourceManager.GetString(nameof (AdjustmentEntry), Strings.resourceCulture);
  }

  internal static string CancelJournalEntryWizard
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (CancelJournalEntryWizard), Strings.resourceCulture);
    }
  }

  internal static string CancelJournalEntryWizardMessageBoxCaption
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (CancelJournalEntryWizardMessageBoxCaption), Strings.resourceCulture);
    }
  }

  internal static string EmptyString
  {
    get => Strings.ResourceManager.GetString(nameof (EmptyString), Strings.resourceCulture);
  }

  internal static string EntryAmountInvalidNumber
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (EntryAmountInvalidNumber), Strings.resourceCulture);
    }
  }

  internal static string ErrorAddingJournalEntry
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (ErrorAddingJournalEntry), Strings.resourceCulture);
    }
  }

  internal static string FiscalDayRequired
  {
    get => Strings.ResourceManager.GetString(nameof (FiscalDayRequired), Strings.resourceCulture);
  }

  internal static string FiscalMonthRequired
  {
    get => Strings.ResourceManager.GetString(nameof (FiscalMonthRequired), Strings.resourceCulture);
  }

  internal static string GLAccountFullNameRetreivalException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (GLAccountFullNameRetreivalException), Strings.resourceCulture);
    }
  }

  internal static string GLAccountLoadException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (GLAccountLoadException), Strings.resourceCulture);
    }
  }

  internal static string GLAccountNotFound
  {
    get => Strings.ResourceManager.GetString(nameof (GLAccountNotFound), Strings.resourceCulture);
  }

  internal static string GLAccountTypeNameRetreivalException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (GLAccountTypeNameRetreivalException), Strings.resourceCulture);
    }
  }

  internal static string IndexExceptionString
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (IndexExceptionString), Strings.resourceCulture);
    }
  }

  internal static string InvalidCallerException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (InvalidCallerException), Strings.resourceCulture);
    }
  }

  internal static string InvalidEntryMessageBoxCaption
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (InvalidEntryMessageBoxCaption), Strings.resourceCulture);
    }
  }

  internal static string InvoiceCorrectionAdjustment
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (InvoiceCorrectionAdjustment), Strings.resourceCulture);
    }
  }

  internal static string INVOICELEDGER_AMOUNTINVALID
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (INVOICELEDGER_AMOUNTINVALID), Strings.resourceCulture);
    }
  }

  internal static string INVOICELEDGER_AMOUNTREQUIRED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (INVOICELEDGER_AMOUNTREQUIRED), Strings.resourceCulture);
    }
  }

  internal static string INVOICELEDGER_CHARGECODEREQUIRED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (INVOICELEDGER_CHARGECODEREQUIRED), Strings.resourceCulture);
    }
  }

  internal static string INVOICELEDGER_COMPANYLINEREQUIRED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (INVOICELEDGER_COMPANYLINEREQUIRED), Strings.resourceCulture);
    }
  }

  internal static string INVOICELEDGER_ENTRYTYPEREQURIED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (INVOICELEDGER_ENTRYTYPEREQURIED), Strings.resourceCulture);
    }
  }

  internal static string INVOICELEDGER_INVOICEREQUIRED
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (INVOICELEDGER_INVOICEREQUIRED), Strings.resourceCulture);
    }
  }

  internal static string JournalEntryAmountRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (JournalEntryAmountRequired), Strings.resourceCulture);
    }
  }

  internal static string JournalEntryNotInBalance
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (JournalEntryNotInBalance), Strings.resourceCulture);
    }
  }

  internal static string JournalEntryObjectNotSetException
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (JournalEntryObjectNotSetException), Strings.resourceCulture);
    }
  }

  internal static string LedgerAccountRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (LedgerAccountRequired), Strings.resourceCulture);
    }
  }

  internal static string NoEntriesSpecified
  {
    get => Strings.ResourceManager.GetString(nameof (NoEntriesSpecified), Strings.resourceCulture);
  }

  internal static string NoEntriesSpecifiedMessageBoxHeader
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (NoEntriesSpecifiedMessageBoxHeader), Strings.resourceCulture);
    }
  }

  internal static string OfficeLocationRequired
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (OfficeLocationRequired), Strings.resourceCulture);
    }
  }

  internal static string RequiredFieldMissingMessageBoxCaption
  {
    get
    {
      return Strings.ResourceManager.GetString(nameof (RequiredFieldMissingMessageBoxCaption), Strings.resourceCulture);
    }
  }
}
