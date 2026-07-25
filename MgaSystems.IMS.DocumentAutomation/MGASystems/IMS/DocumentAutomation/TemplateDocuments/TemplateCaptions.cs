// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.TemplateCaptions
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class TemplateCaptions
{
  public virtual string GetMenuCaption(ISupportTemplateDocs frm, int automationGroupID)
  {
    if (frm == null)
      throw new ArgumentNullException(nameof (frm));
    string menuCaption = Database.Instance.QueryText.PerformScalarQuery("SELECT TemplateGroup FROM lstDocumentAutomationGroups WHERE ID=@ID", (object) "@ID", (object) automationGroupID).ToString();
    switch ((Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), automationGroupID.ToString()))
    {
      case Enums.AutomationDocGroups.PolicyDoc:
        try
        {
          ISupportPolicyTemplateDocs policyTemplateDocs = ObjectFactory.QueryInterface<ISupportPolicyTemplateDocs>((object) frm);
          if (policyTemplateDocs == null)
            throw new InvalidOperationException();
          menuCaption = !policyTemplateDocs.IsBound ? $"{menuCaption} for Control #{Conversions.ToString(policyTemplateDocs.ControlNum)}" : $"{menuCaption} for Policy #{policyTemplateDocs.PolicyNum}";
          break;
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (ex.Message.IndexOf("No quote selected") == -1)
            throw;
          ProjectData.ClearProjectError();
          break;
        }
      case Enums.AutomationDocGroups.InvoiceDoc:
        try
        {
          ISupportInvoiceTemplateDocs invoiceTemplateDocs = ObjectFactory.QueryInterface<ISupportInvoiceTemplateDocs>((object) frm);
          if (invoiceTemplateDocs != null)
          {
            menuCaption = $"{menuCaption} for Invoice #{invoiceTemplateDocs.OfficeInvoiceNum.ToString()}";
            break;
          }
          break;
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
          break;
        }
      case Enums.AutomationDocGroups.SubmissionDoc:
        try
        {
          menuCaption = !(frm is ISupportSubmissionTemplateDocs submissionTemplateDocs) ? string.Empty : $"{menuCaption} for the submission on  {submissionTemplateDocs.SubmissionDate.ToShortDateString()}";
          break;
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
          break;
        }
      case Enums.AutomationDocGroups.InsuredLocationDoc:
        menuCaption = $"{menuCaption} for {ObjectFactory.QueryInterface<ISupportInsuredLocationTemplateDocs>((object) frm).InsuredLocationName}";
        break;
    }
    return menuCaption;
  }
}
