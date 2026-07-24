// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.Program
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new frmAdHocReportManager());
  }
}
