// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Reports
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;

#nullable disable
namespace MGASystems.IMS.Forms;

[StandardModule]
public sealed class Reports
{
  public static void LaunchThreadedReport(
    Type rptType,
    ArrayList typedParamList,
    string windowTitle)
  {
    frmThreadedReportGeneration reportGeneration = new frmThreadedReportGeneration(rptType, typedParamList, windowTitle);
    reportGeneration.MdiParent = MDIControls.Instance.MDIParent;
    reportGeneration.Show();
  }

  public static void LaunchThreadedReport(Type rptType, string windowTitle)
  {
    Reports.LaunchThreadedReport(rptType, new ArrayList(), windowTitle);
  }
}
