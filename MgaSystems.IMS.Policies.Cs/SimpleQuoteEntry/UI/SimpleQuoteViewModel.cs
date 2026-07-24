// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.UI.SimpleQuoteViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Data.Binding;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.UI;

public abstract class SimpleQuoteViewModel : BindingObject
{
  protected IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual SimpleQuote SimpleQuote { get; set; }

  [NotificationProperty]
  public virtual SuggestionProducer SelectedProducer { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource QuotingOfficeCVS { get; set; } = new CollectionViewSource();

  [NotificationProperty]
  public virtual CollectionViewSource LineCVS { get; set; } = new CollectionViewSource();

  [NotificationProperty]
  public virtual CollectionViewSource ProgramCodeCVS { get; set; } = new CollectionViewSource();

  [NotificationProperty]
  public virtual Guid QuotingOfficeGuid { get; set; }

  [NotificationProperty]
  public virtual Line SelectedLine { get; set; }

  [NotificationProperty]
  public virtual string StateID { get; set; }

  [NotificationProperty]
  public virtual CompanyLocation SelectedCompanyLocation { get; set; }

  [NotificationProperty]
  public virtual int BillingTypeID { get; set; }

  [NotificationProperty]
  public virtual Guid IssuingOfficeGuid { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.States> States { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<Underwriter> Underwriters { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<CompanyLocation> CompanyLocations { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.BillingTypes> BillingTypes { get; set; }

  [NotificationProperty]
  public virtual ProgramCode SelectedProgramCode { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency> Currencies { get; set; }

  public ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Statuses> Statuses { get; } = CodeRetrieval.GetStatuses();

  public ObservableCollection<Title> Titles { get; } = CodeRetrieval.GetTitles();

  public ObservableCollection<ISOCountry> Countries { get; } = CodeRetrieval.GetCountries();

  public ObservableCollection<DeliveryMethod> DeliveryMethods { get; } = CodeRetrieval.GetDeliveryMethods();

  public ObservableCollection<OfficeType> OfficeTypes { get; } = CodeRetrieval.GetOfficeTypes();

  public ObservableCollection<Gender> Genders { get; } = CodeRetrieval.GetGenders();

  public static SimpleQuoteViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<SimpleQuoteViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public SimpleQuoteViewModel(IWinMsgBoxService msgBoxService)
  {
    this._msgBoxSvc = msgBoxService;
    this.CreateSimpleQuoteObject();
    this.QuotingOfficeGuid = Guid.Empty;
    this.QuotingOfficeCVS.Source = (object) this.SimpleQuote.Submission.QuoteEditCode.QuotingOffices;
    this.QuotingOfficeCVS.Filter += (FilterEventHandler) ((s, e) =>
    {
      if (CurrentUser.Instance.IsAccountingPackageActive)
      {
        ClientOffice clientOffice = e.Item as ClientOffice;
        e.Accepted = clientOffice.HasChartOfAccounts;
      }
      else
        e.Accepted = true;
    });
    this.LineCVS.Source = (object) this.SimpleQuote.Submission.QuoteEditCode.Lines;
    this.LineCVS.Filter += (FilterEventHandler) ((s, e) =>
    {
      Line line = e.Item as Line;
      e.Accepted = line.OfficeGuid.Equals(Guid.Empty) || line.OfficeGuid.Equals(this.QuotingOfficeGuid);
    });
  }

  public virtual void CreateSimpleQuoteObject() => this.SimpleQuote = SimpleQuote.Create();

  public RelayCommand<object> CreateQuoteCommand
  {
    get
    {
      return new RelayCommand<object>((Action<object>) (obj =>
      {
        List<string> values = this.SimpleQuote.ValidateSimpleQuote();
        if (values.Count > 0)
        {
          int num1 = (int) this._msgBoxSvc.ShowMessageBox(string.Join(Environment.NewLine, (IEnumerable<string>) values), "Create Simple Quote", MessageBoxButton.OK);
        }
        else
        {
          if (!this.IsUniqueInsured())
            return;
          this.SimpleQuote.Submission.SaveNewInsured();
          if (!string.IsNullOrEmpty(this.SimpleQuote.Submission.OfacMessage))
          {
            int num2 = (int) this._msgBoxSvc.ShowMessageBox(this.SimpleQuote.Submission.OfacMessage, "Score Greater Than Threshold", MessageBoxButton.OK);
          }
          bool flag = true;
          if (this.SimpleQuote.Submission.DoesSubmissionGroupForDateExist() && this._msgBoxSvc.ShowMessageBox("A submission already exists from this producer on this date.\n\nAre you sure you want to add this new submission?", "Submission Exists", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            flag = false;
          if (!flag)
            return;
          this.SimpleQuote.CreateQuote();
          if (this.SimpleQuote.ControlNo <= -1)
            return;
          ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.frmControlNumberJump").GetMethod("LaunchAppropriateQuoteForm", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Invoke((object) null, new object[1]
          {
            (object) this.SimpleQuote.ControlNo
          });
          if (!(obj is MgaMdiChild mgaMdiChild2))
            return;
          mgaMdiChild2.Form.Close();
        }
      }), (Predicate<object>) (obj => true));
    }
  }

  public RelayCommand SetInsuredNameCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.SimpleQuote.Submission.SetInsuredName()), (Func<bool>) (() => true));
    }
  }

  protected virtual bool IsUniqueInsured()
  {
    DataTable similarInsureds = this.SimpleQuote.Submission.GetSimilarInsureds();
    if (similarInsureds.Rows.Count > 0)
    {
      using (frmInsuredSoundexMatches insuredSoundexMatches = (frmInsuredSoundexMatches) FormSettings.ShowFormDialog(typeof (frmInsuredSoundexMatches), (object) similarInsureds))
      {
        if (!insuredSoundexMatches.Saved)
          return false;
      }
    }
    return true;
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    switch (propertyName)
    {
      case "SelectedProducer":
        if (this.SelectedProducer == null)
          break;
        this.SimpleQuote.Submission.SetProducer(this.SelectedProducer);
        this.QuotingOfficeCVS.Source = (object) this.SimpleQuote.Submission.QuoteEditCode.QuotingOffices;
        this.LineCVS.Source = (object) this.SimpleQuote.Submission.QuoteEditCode.Lines;
        break;
      case "QuotingOfficeGuid":
        this.Currencies = CodeRetrieval.GetCurrencies(this.QuotingOfficeGuid);
        this.SimpleQuote.Quote.QuotingOfficeGuid = this.QuotingOfficeGuid;
        this.LineCVS.View.Refresh();
        if (this.Currencies.Count > 0)
          this.SimpleQuote.Quote.CurrencyCode = this.Currencies[0].CurrencyCode;
        CommandManager.InvalidateRequerySuggested();
        break;
      case "SelectedLine":
        this.SimpleQuote.Quote.LineGuid = this.SelectedLine.LineGuid;
        this.SimpleQuote.Quote.Line = this.SelectedLine.LineName;
        this.States = CodeRetrieval.GetStates(this.SelectedLine.LineGuid, this.SimpleQuote.Submission.ProducerLocationGuid);
        this.Underwriters = CodeRetrieval.GetUnderwriters(this.SelectedLine.LineGuid);
        this.SimpleQuote.SetProgramCode();
        break;
      case "StateID":
        this.SimpleQuote.Quote.StateID = this.StateID;
        this.CompanyLocations = CodeRetrieval.GetCompanyLocations(this.StateID, this.SimpleQuote.Submission.ProducerLocationGuid, this.SelectedLine.LineGuid, new Guid?(this.QuotingOfficeGuid));
        this.SimpleQuote.SetProgramCode();
        break;
      case "SelectedCompanyLocation":
        ((Collection<QuoteDetail>) this.SimpleQuote.Quote.QuoteDetails).Clear();
        this.SimpleQuote.Quote.Company = this.SelectedCompanyLocation.Name;
        this.SimpleQuote.Quote.CompanyLocationGuid = this.SelectedCompanyLocation.CompanyLocationGuid;
        if (this.SelectedCompanyLocation.CompanyLocationGuid.Equals(Guid.Empty))
          break;
        this.BillingTypes = CodeRetrieval.GetBillingTypes(this.SimpleQuote.Quote.CompanyLineGuid);
        this.SimpleQuote.Quote.SetMinimumEarned();
        this.ProgramCodeCVS.Source = (object) this.SimpleQuote.Submission.QuoteEditCode.ProgramCodes;
        this.ProgramCodeCVS.View.Refresh();
        this.SimpleQuote.SetProgramCode();
        break;
      case "BillingTypeID":
        this.SimpleQuote.Quote.BillingTypeID = this.BillingTypeID;
        break;
      case "IssuingOfficeGuid":
        this.SimpleQuote.Quote.IssuingOfficeGuid = this.IssuingOfficeGuid;
        this.SimpleQuote.SetProgramCode();
        break;
    }
  }
}
