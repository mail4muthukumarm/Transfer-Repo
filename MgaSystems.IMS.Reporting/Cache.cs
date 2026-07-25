// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.Cache
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Reporting.Attributes;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Reporting;

[StandardModule]
public sealed class Cache
{
  private static Dictionary<Guid, Type> _automationReports = new Dictionary<Guid, Type>();
  private static Dictionary<Type, FinanceAgreementAttribute> _financeAgreements = new Dictionary<Type, FinanceAgreementAttribute>();

  public static Dictionary<Guid, Type> AutomationReportMap => Cache._automationReports;

  public static Dictionary<Type, FinanceAgreementAttribute> FinanceAgreementMap
  {
    get => Cache._financeAgreements;
  }

  static Cache()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new AutomationReportAttribute());
    int index = 0;
    while (index < typeArray.Length)
    {
      Type key = typeArray[index];
      AutomationReportAttribute automationReportAttribute = key.GetCustomAttributes(typeof (AutomationReportAttribute), false).OfType<AutomationReportAttribute>().FirstOrDefault<AutomationReportAttribute>();
      if (automationReportAttribute != null)
      {
        try
        {
          Cache._automationReports.Add(automationReportAttribute.AutomationReportGuid, key);
        }
        catch (ArgumentException ex1)
        {
          ProjectData.SetProjectError((Exception) ex1);
          ArgumentException innerException = ex1;
          if (key != Cache._automationReports[automationReportAttribute.AutomationReportGuid])
          {
            InvalidOperationException ex2 = new InvalidOperationException("Duplicate AutomationReportGuid", (Exception) innerException);
            ex2.Data.Add((object) "AutomationReportGuid", (object) automationReportAttribute.AutomationReportGuid);
            ex2.Data.Add((object) "AutomationReportIncoming", (object) key.FullName);
            ex2.Data.Add((object) "AutomationReportExisting", (object) Cache._automationReports[automationReportAttribute.AutomationReportGuid].FullName);
            ErrorHandler.SilentHandleError((Exception) ex2);
          }
          ProjectData.ClearProjectError();
        }
      }
      FinanceAgreementAttribute agreementAttribute = key.GetCustomAttributes(typeof (FinanceAgreementAttribute), false).OfType<FinanceAgreementAttribute>().FirstOrDefault<FinanceAgreementAttribute>();
      if (agreementAttribute != null)
      {
        try
        {
          Cache._financeAgreements.Add(key, agreementAttribute);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      checked { ++index; }
    }
  }
}
