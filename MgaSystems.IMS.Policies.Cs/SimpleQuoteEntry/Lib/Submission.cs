// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.Submission
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public abstract class Submission : ValidatingDependentBindingObject
{
  public Guid InsuredGuid { get; set; }

  public string OfacMessage { get; set; }

  public Guid SubmissionGroupGuid { get; set; }

  public bool CanCreateSubmission { get; set; }

  [HasGuidValue(ErrorMessage = "Must choose Producer")]
  [NotificationProperty]
  public virtual Guid ProducerLocationGuid { get; set; }

  public int ProducerLocationID { get; set; }

  [NotificationProperty]
  public virtual int ProducerContactID { get; set; }

  public Guid ProducerContactGuid { get; set; }

  [Range(1, 2147483647 /*0x7FFFFFFF*/, ErrorMessage = "Must choose Type")]
  [NotificationProperty]
  public virtual byte InsuredTypeID { get; set; }

  [NotificationProperty]
  public virtual byte InsuredStatusID { get; set; }

  [NotificationProperty]
  public virtual string InsuredBusinessName { get; set; }

  [NotificationProperty]
  public virtual string PolicyName { get; set; }

  [NotificationProperty]
  public virtual string Salutation { get; set; }

  [NotificationProperty]
  public virtual string FirstName { get; set; }

  [NotificationProperty]
  public virtual string MiddleName { get; set; }

  [NotificationProperty]
  public virtual string LastName { get; set; }

  [NotificationProperty]
  public virtual string Description { get; set; }

  [NotificationProperty]
  public virtual string ISOCountryCode { get; set; }

  [NotificationProperty]
  public virtual string Address1 { get; set; }

  [NotificationProperty]
  public virtual string Address2 { get; set; }

  [NotificationProperty]
  public virtual string ZipCode { get; set; }

  [NotificationProperty]
  public virtual string ZipExt { get; set; }

  [NotificationProperty]
  public virtual string City { get; set; }

  [NotificationProperty]
  public virtual string State { get; set; }

  [NotificationProperty]
  public virtual string County { get; set; }

  [NotificationProperty]
  public virtual bool IsIndividual { get; set; }

  [NotificationProperty]
  public virtual string Soundex { get; set; }

  [NotificationProperty]
  public virtual QuoteEditCode QuoteEditCode { get; set; }

  [NotificationProperty]
  public virtual byte DeliveryMethodID { get; set; }

  [NotificationProperty]
  public virtual short LocationTypeID { get; set; }

  [NotificationProperty]
  public virtual int GenderID { get; set; }

  public ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.BusinessTypes> BusinessTypes { get; } = CodeRetrieval.GetBusinessTypes();

  internal static Submission Create() => NotifyProxyTypeManager.Allocate<Submission>();

  public Submission()
  {
    this.InsuredGuid = Guid.Empty;
    this.SubmissionGroupGuid = Guid.Empty;
    this.InsuredStatusID = (byte) 1;
    this.Description = "Mailing Address";
    this.ISOCountryCode = "USA";
    this.DeliveryMethodID = (byte) 1;
    this.LocationTypeID = (short) 1;
    this.GenderID = 0;
    this.QuoteEditCode = new QuoteEditCode();
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    ((DependentBindingObject) this).OnPropertyChanged(propertyName);
    switch (propertyName)
    {
      case "InsuredTypeID":
        this.IsIndividual = this.BusinessTypes.Where<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.BusinessTypes>((System.Func<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.BusinessTypes, bool>) (b => (int) b.BusinessTypeID == (int) this.InsuredTypeID && b.Individual)).SingleOrDefault<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.BusinessTypes>() != null;
        break;
      case "ProducerLocationGuid":
        this.QuoteEditCode = CodeRetrieval.QuoteEditDataRetrieval(this.ProducerLocationGuid);
        break;
    }
  }

  public void SetInsuredName()
  {
    if (this.IsIndividual)
    {
      string middleName = this.MiddleName;
      string str = (middleName != null ? (middleName.Trim().Length > 0 ? 1 : 0) : 0) != 0 ? this.MiddleName.Trim() + " " : "";
      this.PolicyName = $"{this.FirstName.Trim()} {str}{this.LastName}";
    }
    else
      this.PolicyName = this.InsuredBusinessName;
  }

  public void SaveNewInsured()
  {
    this.SetSoundex();
    bool flag = this.InsuredGuid == Guid.Empty;
    if (flag)
      this.InsuredGuid = Guid.NewGuid();
    Guid insuredLocationGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.StoredProcedure, "spInsuredsUpdate", new object[48 /*0x30*/]
    {
      (object) "@InsuredGuid",
      (object) this.InsuredGuid,
      (object) "@BusinessTypeID",
      (object) this.InsuredTypeID,
      (object) "@Name",
      (object) this.InsuredBusinessName,
      (object) "@CorporationName",
      this.IsIndividual ? (object) (string) null : (object) this.InsuredBusinessName,
      (object) "@PolicyName",
      (object) this.PolicyName,
      (object) "@Salutation",
      (object) this.Salutation,
      (object) "@FirstName",
      (object) this.FirstName,
      (object) "@MiddleName",
      (object) this.MiddleName,
      (object) "@LastName",
      (object) this.LastName,
      (object) "@StatusID",
      (object) this.InsuredStatusID,
      (object) "@Soundex",
      (object) this.Soundex,
      (object) "@LocationDescription",
      (object) this.Description,
      (object) "@Address1",
      (object) this.Address1,
      (object) "@Address2",
      (object) this.Address2,
      (object) "@City",
      (object) this.City,
      (object) "@County",
      (object) this.County,
      (object) "@State",
      (object) this.State,
      (object) "@ISOCountryCode",
      (object) this.ISOCountryCode,
      (object) "@ZipCode",
      (object) this.ZipCode,
      (object) "@ZipPlus",
      (object) this.ZipExt,
      (object) "@DeliveryMethodID",
      (object) this.DeliveryMethodID,
      (object) "@LocationTypeID",
      (object) this.LocationTypeID,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@GenderID",
      (object) this.GenderID
    });
    if (flag)
      Messaging.SendBroadcastMessage(BroadcastMessages.InsuredAdded, (object) this.InsuredGuid);
    try
    {
      if (!flag || !MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("OFAC.Insured.SkipOnNew", false))
        return;
      MDIControls.Instance.StatusBarText = "Running OFAC on insured ...";
      Insured i = new Insured(this.InsuredGuid);
      InsuredLocation il = new InsuredLocation(insuredLocationGuid);
      Task.Run<bool>((Func<bool>) (() => this.CheckOfac(il, i)));
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  public bool CheckOfac(InsuredLocation insLoc, Insured ins)
  {
    OfacSystem.OfacResult ofacResult = (OfacSystem.OfacResult) null;
    try
    {
      ofacResult = OfacSystem.Instance.CheckOfacResult<InsuredLocation>(insLoc);
      if (ofacResult == null)
        return false;
      if ("-1".Equals(ofacResult.ReturnCode))
        this.OnOfacError(ins, (Exception) null, ofacResult.OfacTypeID, ofacResult);
      if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("OFAC.Insured.ShowMessageOnHit", false))
      {
        if (ofacResult.OfacHit)
        {
          int setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<int>("ScoreNumber", 100);
          this.OfacMessage = $"Insured OFAC score of {ofacResult.ReturnScore} is greater than the threshold of {setting}";
        }
      }
    }
    catch (Exception ex)
    {
      this.OnOfacError(ins, ex, ofacResult != null ? ofacResult.OfacTypeID : -1, ofacResult);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
    }
    return true;
  }

  public void OnOfacError(
    Insured insured,
    Exception ex,
    int ofacType,
    OfacSystem.OfacResult ofacResult = null)
  {
    try
    {
      if (ofacType > 2 || !MGASystems.Common.SystemSettings.KeyExists("OfacErrorHandlingStoredProc"))
        return;
      string stringSetting = MGASystems.Common.SystemSettings.GetStringSetting("OfacErrorHandlingStoredProc");
      XElement xelement1 = new XElement((XName) "header", (object) new XElement((XName) "IMSError", (object) ex?.Message));
      if (ofacResult == null)
      {
        string str = "OFAC_XML";
        if (ofacType != 1)
          str = "pwsOFAC";
        string text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, $"SELECT {str} FROM dbo.tblinsureds WITH (NOLOCK) WHERE InsuredGuid=@IG", new object[2]
        {
          (object) "@IG",
          (object) insured.InsuredGuid
        });
        if (!string.IsNullOrEmpty(text))
        {
          try
          {
            XElement xelement2 = XElement.Parse(text);
            switch (ofacType)
            {
              case 1:
                xelement1.Add((object) new XElement((XName) "ServiceError"), (object) xelement2.Descendants((XName) "ERRORDESC").Select<XElement, string>((System.Func<XElement, string>) (xe => xe.Value)).FirstOrDefault<string>());
                break;
              case 2:
                xelement1.Add((object) new XElement((XName) "ServiceError"), (object) xelement2.Descendants((XName) "ReturnMessage").Select<XElement, string>((System.Func<XElement, string>) (xe => xe.Value)).FirstOrDefault<string>());
                break;
            }
          }
          catch (Exception ex1)
          {
            xelement1.Add((object) new XElement((XName) "XMLError", (object) ex1.Message));
          }
        }
      }
      else
        xelement1.Add((object) new XElement((XName) "ServiceError", (object) ofacResult.ErrorDescription));
      DefaultDatabase.ExecuteNonQuery(stringSetting, new object[4]
      {
        (object) "@InsuredGuid",
        (object) insured.InsuredGuid,
        (object) "@ErrorString",
        (object) xelement1.ToString()
      });
    }
    catch (Exception ex2)
    {
      ErrorHandler.SilentHandleError(ex2);
    }
  }

  public virtual DataTable GetSimilarInsureds()
  {
    if (this.PolicyName == null)
      this.SetInsuredName();
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT I.InsuredGUID, I.Name, IL.City, IL.State FROM tblInsureds I INNER JOIN tblInsuredLocations IL ON I.InsuredGUID = IL.InsuredGUID WHERE I.Soundex = dbo.SoundexAlphaFunction(@name)", new object[2]
    {
      (object) "@name",
      (object) this.PolicyName.Replace("'", "''")
    });
  }

  private void SetSoundex()
  {
    this.Soundex = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.SoundexAlphaFunction(@insuredName)", new object[2]
    {
      (object) "@insuredName",
      (object) this.PolicyName
    });
  }

  public bool DoesSubmissionGroupForDateExist()
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblSubmissionGroup WHERE InsuredGuid = @InsuredGuid AND CONVERT(datetime, CONVERT(varchar(11), DateSubmitted, 101)) = @SubmittedDate", new object[4]
    {
      (object) "@InsuredGuid",
      (object) this.InsuredGuid,
      (object) "@SubmittedDate",
      (object) DateTime.Now.ToShortDateString()
    }) > 0;
  }

  public void SetProducer(SuggestionProducer suggestionProducer)
  {
    this.ProducerLocationGuid = suggestionProducer.ProducerLocationGuid;
    this.ProducerContactID = suggestionProducer.ProducerContactID;
    this.ProducerContactGuid = suggestionProducer.ProducerContactGuid;
    this.ProducerLocationID = suggestionProducer.ProducerLocationID;
  }
}
