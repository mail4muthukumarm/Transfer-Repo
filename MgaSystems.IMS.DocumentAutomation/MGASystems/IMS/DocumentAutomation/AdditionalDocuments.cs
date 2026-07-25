// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AdditionalDocuments
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class AdditionalDocuments : ISupportTemplateDocs, ISupportPolicyTemplateDocs
{
  private readonly Quote _quote;

  public int ControlNum => this._quote.ControlNo;

  public bool IsBound => this._quote.IsBound;

  public string PolicyNum => this._quote.PolicyNumber;

  public AdditionalDocuments(Quote qte)
  {
    this._quote = qte;
    FormSettings.ShowFormDialog(typeof (frmDocumentTemplates), (object) this, (object) true);
  }

  public List<int> SupportedTemplateGroupIDs
  {
    get => new List<int>() { 1 };
  }

  public object[] TagParserConstructorArgs(int automationDocGroupID)
  {
    object[] objArray;
    switch ((Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), automationDocGroupID.ToString()))
    {
      case Enums.AutomationDocGroups.PolicyDoc:
        objArray = new object[1]
        {
          (object) this._quote.QuoteGuid
        };
        break;
      case Enums.AutomationDocGroups.SubmissionDoc:
        objArray = new object[1]
        {
          (object) this._quote.SubmissionGroup.SubmissionGroupGuid
        };
        break;
      case Enums.AutomationDocGroups.InsuredLocationDoc:
        objArray = new object[1]
        {
          (object) this._quote.SubmissionGroup.InsuredLocation.InsuredLocationGuid
        };
        break;
      default:
        objArray = (object[]) null;
        break;
    }
    return objArray;
  }
}
