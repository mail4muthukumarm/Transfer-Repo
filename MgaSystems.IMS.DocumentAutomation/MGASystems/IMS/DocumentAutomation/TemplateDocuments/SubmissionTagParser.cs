// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.SubmissionTagParser
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class SubmissionTagParser : InsuredLocationTagParser
{
  private Guid _submissionGroupGuid;

  public SubmissionTagParser(Guid submissionGroupGuid)
    : base(SubmissionTagParser.GetInsuredLocationGuid(submissionGroupGuid))
  {
    this._submissionGroupGuid = submissionGroupGuid;
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID)
  {
    SubmissionGroup submissionGroup = new SubmissionGroup(this._submissionGroupGuid);
    try
    {
      foreach (DocTag tag in tags)
      {
        string lower = tag.InnerTagName.ToLower();
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(lower))
        {
          case 761769495:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodfax", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerFax;
              continue;
            }
            continue;
          case 1154346715:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodcity", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerCity;
              continue;
            }
            continue;
          case 1357396007:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "producer", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerName;
              continue;
            }
            continue;
          case 1464755087:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pz", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerZipCode;
              continue;
            }
            continue;
          case 1582198420:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ps", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerState;
              continue;
            }
            continue;
          case 1869048429:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pzp", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerZipPlus4;
              continue;
            }
            continue;
          case 2199556118:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodcounty", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerCounty;
              continue;
            }
            continue;
          case 2747911410:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodloc", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerLocationName;
              continue;
            }
            continue;
          case 2756427968:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodad1", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerAddress1;
              continue;
            }
            continue;
          case 2806760825:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodad2", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerAddress2;
              continue;
            }
            continue;
          case 3044082032:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodphone", false) == 0)
            {
              tag.TagValue = submissionGroup.ProducerPhone;
              continue;
            }
            continue;
          case 3191096514:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "submitted", false) == 0)
            {
              tag.TagValue = submissionGroup.DateSubmitted.ToString();
              continue;
            }
            continue;
          case 3274059505:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "tacsri", false) == 0)
            {
              tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT tblUsers.Initials, tblSubmissionGroup.SubmissionGroupGUID FROM tblSubmissionGroup INNER JOIN tblUsers ON tblSubmissionGroup.TACSRUserGuid = tblUsers.UserGUID WHERE tblSubmissionGroup.SubmissionGroupGUID=@SubmissionGroupGUID", new object[2]
              {
                (object) "@SubmissionGroupGUID",
                (object) submissionGroup.SubmissionGroupGuid
              })), string.Empty);
              continue;
            }
            continue;
          case 3341000347:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "tacsrls", false) == 0)
            {
              tag.TagValue = submissionGroup.TACSRLast;
              continue;
            }
            continue;
          case 3473544013:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "tacsrfs", false) == 0)
            {
              tag.TagValue = submissionGroup.TACSRFirst;
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    tags = base.ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID);
    return tags;
  }

  private static Guid GetInsuredLocationGuid(Guid submissionGroupGuid)
  {
    return (DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT dbo.GetInsuredPrimaryLocation(@IG)", new object[2]
    {
      (object) "@IG",
      (object) DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT InsuredGuid FROM tblSubmissionGroup WHERE SubmissionGroupGuid=@SGG", new object[2]
      {
        (object) "@SGG",
        (object) submissionGroupGuid
      })
    }) ?? throw new InvalidOperationException("Insured does not have a Primary location")).Value;
  }
}
