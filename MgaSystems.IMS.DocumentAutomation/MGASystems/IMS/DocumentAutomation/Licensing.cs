// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.Licensing
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.AsposeFacade.Email;
using MGASystems.AsposeFacade.PDF;
using MGASystems.AsposeFacade.Words;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[StandardModule]
public sealed class Licensing
{
  static Licensing() => Licensing.IsLicensed = false;

  public static bool IsLicensed { get; set; }

  public static void LicenseAsposeAssemblies()
  {
    if (!CompanyDocumentAutomation.BlackBoxMode)
      Thread.Sleep(5000);
    try
    {
      if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("Aspose_LegacyFontFallback", false))
        Document.SetLegacyFontFallback(true);
      Action<string, string, string> action;
      // ISSUE: reference to a compiler-generated field
      if (Licensing._Closure\u0024__.\u0024I5\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        action = Licensing._Closure\u0024__.\u0024I5\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Licensing._Closure\u0024__.\u0024I5\u002D0 = action = (Action<string, string, string>) ([SpecialName] (type, source, description) => ErrorHandler.SilentHandleError((Exception) new AsposeWarningException(type, source, description)));
      }
      Document.SetWarningCallback(action);
      new License().SetLicense();
      new License().SetLicense();
      new License().SetLicense();
      new License().SetLicense();
      Licensing.IsLicensed = true;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (CompanyDocumentAutomation.BlackBoxMode)
        throw;
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex2);
      ProjectData.ClearProjectError();
    }
  }
}
