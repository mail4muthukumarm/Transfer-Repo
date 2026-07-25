// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.InsuredLocationTagParser
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class InsuredLocationTagParser : TagParserBase
{
  private Guid _insuredLocationGuid;
  private Client _client;
  private User _user;

  public InsuredLocationTagParser(Guid insuredLocationGuid)
  {
    this._insuredLocationGuid = insuredLocationGuid;
  }

  private Client Client
  {
    get
    {
      if (this._client == null)
        this._client = new Client();
      return this._client;
    }
  }

  private User User
  {
    get
    {
      if (this._user == null)
        this._user = new User(MGASystems.IMS.DocumentAutomation.Common.UserGuid);
      return this._user;
    }
  }

  public override bool SupportsQuoteOptionGuids() => false;

  public override List<DocTag> ProcessTags(List<DocTag> tags)
  {
    return this.ProcessTags(tags, (object) null);
  }

  public override List<DocTag> ProcessTags(List<DocTag> tags, object entityID)
  {
    return this.ProcessTags(tags, (object) null, -1);
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityID,
    int placedByCompanyLineID)
  {
    InsuredLocation insuredLocation = new InsuredLocation(this._insuredLocationGuid);
    try
    {
      foreach (DocTag tag in tags)
      {
        string lower = tag.InnerTagName.ToLower();
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(lower))
        {
          case 43273184:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsfein", false) == 0)
            {
              tag.TagValue = (string.IsNullOrEmpty(insuredLocation.Insured.FEIN?.Trim()) ? insuredLocation.Insured.SSN : insuredLocation.Insured.FEIN) ?? string.Empty;
              continue;
            }
            continue;
          case 81162757:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clossconl", false) == 0)
            {
              try
              {
                tag.TagValue = insuredLocation.GetContact("LOSSC").LastName;
                continue;
              }
              catch (SystemDefinedInsuredContactNotFoundException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                tag.TagValue = string.Empty;
                ProjectData.ClearProjectError();
                continue;
              }
            }
            else
              continue;
          case 124350222:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientphone", false) == 0)
            {
              tag.TagValue = this.Client.Phone;
              continue;
            }
            continue;
          case 134346516:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "usertitle", false) == 0)
            {
              tag.TagValue = this.User.Title;
              continue;
            }
            continue;
          case 181828471:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clossconf", false) == 0)
            {
              try
              {
                tag.TagValue = insuredLocation.GetContact("LOSSC").FirstName;
                continue;
              }
              catch (SystemDefinedInsuredContactNotFoundException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                tag.TagValue = string.Empty;
                ProjectData.ClearProjectError();
                continue;
              }
            }
            else
              continue;
          case 455054827:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientzip4", false) == 0)
            {
              tag.TagValue = this.Client.Zip4;
              continue;
            }
            continue;
          case 513322094:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insinspcontact_last", false) == 0)
              break;
            continue;
          case 565907636:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsured", false) == 0)
            {
              tag.TagValue = insuredLocation.Insured.Name;
              continue;
            }
            continue;
          case 591077479:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsadr", false) == 0)
            {
              tag.TagValue = (insuredLocation.Address1 ?? string.Empty).TrimEnd() + (string.IsNullOrEmpty(insuredLocation.Address2) ? string.Empty : ", " + insuredLocation.Address2);
              continue;
            }
            continue;
          case 638624931:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientstate", false) == 0)
            {
              tag.TagValue = this.Client.State;
              continue;
            }
            continue;
          case 682728183:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "now", false) == 0)
            {
              tag.TagValue = DateAndTime.Now.ToString();
              continue;
            }
            continue;
          case 704029309:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientname", false) == 0)
            {
              tag.TagValue = this.Client.Name;
              continue;
            }
            continue;
          case 779574265:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientcity", false) == 0)
            {
              tag.TagValue = this.Client.City;
              continue;
            }
            continue;
          case 788317099:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "user_signature", false) == 0)
            {
              byte[] userSignature = this.User.UserSignature;
              if (userSignature != null)
              {
                tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(userSignature));
                continue;
              }
              continue;
            }
            continue;
          case 804047986:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ucounty", false) == 0)
            {
              tag.TagValue = this.User.County;
              continue;
            }
            continue;
          case 836257900:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientaddress2", false) == 0)
            {
              tag.TagValue = this.Client.Address2;
              continue;
            }
            continue;
          case 886590757:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientaddress1", false) == 0)
            {
              tag.TagValue = this.Client.Address1;
              continue;
            }
            continue;
          case 1109790614:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsemail", false) == 0)
            {
              tag.TagValue = insuredLocation.Email;
              continue;
            }
            continue;
          case 1145082153:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientfax", false) == 0)
            {
              tag.TagValue = this.Client.Fax;
              continue;
            }
            continue;
          case 1286451075:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uzipplus", false) == 0)
            {
              tag.TagValue = this.User.ZipPlus;
              continue;
            }
            continue;
          case 1303424127:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "primary_contact_last", false) == 0)
              break;
            continue;
          case 1320097209:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "username", false) == 0)
            {
              tag.TagValue = $"{this.User.FirstName} {this.User.LastName}";
              continue;
            }
            continue;
          case 1466595602:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uinit", false) == 0)
            {
              tag.TagValue = this.User.Initials;
              continue;
            }
            continue;
          case 1534205069:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "userfax", false) == 0)
            {
              tag.TagValue = this.User.Fax;
              continue;
            }
            continue;
          case 1660585083:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "primary_contact_first", false) == 0)
              break;
            continue;
          case 1767647903:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ucity", false) == 0)
            {
              tag.TagValue = this.User.City;
              continue;
            }
            continue;
          case 1839352155:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsdba", false) == 0)
            {
              tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT DBA FROM tblInsureds I INNER JOIN tblInsuredLocations L ON I.InsuredGuid=L.InsuredGuid WHERE L.InsuredLocationGuid=@ILG", new object[2]
              {
                (object) "@ILG",
                (object) this._insuredLocationGuid
              }) ?? string.Empty;
              continue;
            }
            continue;
          case 2150816456:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinscounty", false) == 0)
            {
              tag.TagValue = insuredLocation.County;
              continue;
            }
            continue;
          case 2164357296:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinscountry", false) == 0)
            {
              tag.TagValue = insuredLocation.CountryName;
              continue;
            }
            continue;
          case 2306601765:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsfax", false) == 0)
            {
              tag.TagValue = insuredLocation.Fax;
              continue;
            }
            continue;
          case 2406691602:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "userphone", false) == 0)
            {
              tag.TagValue = this.User.Phone;
              continue;
            }
            continue;
          case 2538395641:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "userext", false) == 0)
            {
              tag.TagValue = this.User.ContactPhoneExtension;
              continue;
            }
            continue;
          case 2767311136:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsconf", false) == 0)
            {
              try
              {
                tag.TagValue = insuredLocation.GetContact("INSUR").FirstName;
                continue;
              }
              catch (SystemDefinedInsuredContactNotFoundException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                tag.TagValue = string.Empty;
                ProjectData.ClearProjectError();
                continue;
              }
            }
            else
              continue;
          case 2935087326:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsconl", false) == 0)
            {
              try
              {
                tag.TagValue = insuredLocation.GetContact("INSUR").LastName;
                continue;
              }
              catch (SystemDefinedInsuredContactNotFoundException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                tag.TagValue = string.Empty;
                ProjectData.ClearProjectError();
                continue;
              }
            }
            else
              continue;
          case 3047176383:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insbustype", false) == 0)
            {
              tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT lstBusinessTypes.BusinessType FROM tblInsureds INNER JOIN lstBusinessTypes ON tblInsureds.BusinessTypeID = lstBusinessTypes.BusinessTypeID INNER JOIN tblInsuredLocations ON tblInsureds.InsuredGUID = tblInsuredLocations.InsuredGUID WHERE tblInsuredLocations.InsuredLocationGuid = @InsuredLocationGuid", new object[2]
              {
                (object) "@InsuredLocationGuid",
                (object) this._insuredLocationGuid
              }) ?? string.Empty;
              continue;
            }
            continue;
          case 3167399864:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsmobilephone", false) == 0)
            {
              tag.TagValue = insuredLocation.MobileNumber;
              continue;
            }
            continue;
          case 3407078863:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsadr2", false) == 0)
            {
              tag.TagValue = insuredLocation.Address2;
              continue;
            }
            continue;
          case 3423856482:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsadr1", false) == 0)
            {
              tag.TagValue = insuredLocation.Address1;
              continue;
            }
            continue;
          case 3525718397:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientzip", false) == 0)
            {
              tag.TagValue = this.Client.Zip;
              continue;
            }
            continue;
          case 3697735699:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uaddress1", false) == 0)
            {
              tag.TagValue = this.User.Address1;
              continue;
            }
            continue;
          case 3714513318:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uaddress2", false) == 0)
            {
              tag.TagValue = this.User.Address2;
              continue;
            }
            continue;
          case 3902975314:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "userforeignphone", false) == 0)
            {
              tag.TagValue = this.User.ForeignPhone;
              continue;
            }
            continue;
          case 3922537460:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uregion", false) == 0)
            {
              tag.TagValue = this.User.Region;
              continue;
            }
            continue;
          case 3942221885:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinscity", false) == 0)
            {
              tag.TagValue = insuredLocation.City;
              continue;
            }
            continue;
          case 3956495942:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cizc", false) == 0)
            {
              tag.TagValue = insuredLocation.ZipCode;
              continue;
            }
            continue;
          case 4016950757:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ustate", false) == 0)
            {
              tag.TagValue = this.User.State;
              continue;
            }
            continue;
          case 4085761494:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cis", false) == 0)
            {
              tag.TagValue = insuredLocation.State;
              continue;
            }
            continue;
          case 4086105674:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsphone", false) == 0)
            {
              tag.TagValue = insuredLocation.Phone;
              continue;
            }
            continue;
          case 4118708062:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "useremail", false) == 0)
            {
              tag.TagValue = this.User.Email;
              continue;
            }
            continue;
          case 4201397520:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insinspcontact_first", false) == 0)
              break;
            continue;
          case 4204165898:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insinspcontact_phone", false) == 0)
              break;
            continue;
          case 4208160227:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cizp", false) == 0)
            {
              tag.TagValue = insuredLocation.ZipPlus;
              continue;
            }
            continue;
          case 4247027598:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uzipcode", false) == 0)
            {
              tag.TagValue = this.User.ZipCode;
              continue;
            }
            continue;
          case 4258327554:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cinsadrfull", false) == 0)
            {
              tag.TagValue = insuredLocation.FullAddress;
              continue;
            }
            continue;
          default:
            continue;
        }
        tag.TagValue = DefaultDatabase.ExecuteScalar<string>("dbo.spGetSpecialInsuredInfo", new object[4]
        {
          (object) "@insuredLocation",
          (object) this._insuredLocationGuid,
          (object) "@tagName",
          (object) tag.InnerTagName.ToLower()
        }) ?? string.Empty;
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.TagPostProcessing(tags);
    return tags;
  }
}
