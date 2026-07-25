// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCompanyFinanceAgreement
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Services;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Reporting.GenericReport;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{23D883D8-3C13-412D-B62D-7F762B809645}", Enums.AutomationDocGroups.PolicyDoc, "Finance Agreement [Dynamic]", "Automatically resolves finance agreement based on selected finance company (if one is assigned).")]
public class rptCompanyFinanceAgreement : GenericAutomationReport
{
  public const string AutomationGuid = "{23D883D8-3C13-412D-B62D-7F762B809645}";
  private Guid _quoteGuid;

  public rptCompanyFinanceAgreement(Guid quoteGuid)
    : base((object) quoteGuid)
  {
    this._quoteGuid = quoteGuid;
  }

  protected override object OnGenerateReport(GenerateReportArgs reportArgs)
  {
    reportArgs.ReportType = GenericReportResultType.PDFByteArray;
    Guid runContext = (Guid) reportArgs.RunContext;
    Quote quote = new Quote(runContext);
    Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>("dbo.spFin_GetQuoteFinanceReport", new object[2]
    {
      (object) "@quoteGuid",
      (object) runContext
    });
    object report;
    if (!nullable.HasValue)
    {
      report = (object) null;
    }
    else
    {
      Type baseType = (Type) null;
      if (!Cache.AutomationReportMap.TryGetValue(nullable.Value, out baseType))
      {
        report = (object) null;
      }
      else
      {
        try
        {
          object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(baseType, (object) runContext));
          if (objectValue is IStateSpecific stateSpecific)
            stateSpecific.PlacedByCompanyLineID(quote.CompanyLine.CompanyLineID);
          if (objectValue is IQuoteDocument quoteDocument && quoteDocument.RequiresQuoteOptionGuids())
            quoteDocument.SetQuoteOptionGuids(this.QuoteOptionGuids.ToArray<Guid>());
          if (objectValue is SectionReport sectionReport)
          {
            reportArgs.ReportType = GenericReportResultType.ActiveReport;
            report = (object) sectionReport;
            goto label_18;
          }
          if (objectValue is IGenericReport genericReport)
          {
            RunCompletedResult runCompletedResult = genericReport.Run((object) runContext);
            reportArgs.ReportType = runCompletedResult.ResultType;
            report = runCompletedResult.Result;
            goto label_18;
          }
        }
        finally
        {
          bool? setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool?>("FinanceAgreements.General.CaptureSoap");
          if ((!setting.HasValue || setting.GetValueOrDefault()) && (!string.IsNullOrEmpty(SoapListenerExtension.LastRequestXML) || !string.IsNullOrEmpty(SoapListenerExtension.LastResponseXML)))
          {
            if (setting.HasValue)
            {
              try
              {
                DefaultDatabase.ExecuteNonQuery("dbo.spFinanceAgreements_LogFinanceReportSoapXml", new object[14]
                {
                  (object) "@quoteGuid",
                  (object) runContext,
                  (object) "@userGuid",
                  (object) CurrentUser.Instance.UserGUID,
                  (object) "@reportGuid",
                  (object) nullable,
                  (object) "@reportType",
                  (object) baseType.FullName,
                  (object) "@requestXml",
                  (object) SoapListenerExtension.LastRequestXML,
                  (object) "@requestUrl",
                  (object) SoapListenerExtension.LastRequestUrl,
                  (object) "@responseXml",
                  (object) SoapListenerExtension.LastResponseXML
                });
              }
              catch (Exception ex1)
              {
                ProjectData.SetProjectError(ex1);
                Exception ex2 = ex1;
                ex2.Data.Add((object) "QuoteGUID", (object) runContext);
                ex2.Data.Add((object) "ReportGUID", (object) nullable);
                ex2.Data.Add((object) "ReportType", (object) baseType.FullName);
                ErrorHandler.SilentHandleError(ex2);
                ProjectData.ClearProjectError();
              }
            }
          }
        }
        report = (object) null;
      }
    }
label_18:
    return report;
  }
}
