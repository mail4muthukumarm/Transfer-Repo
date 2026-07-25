// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.Common
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[StandardModule]
public sealed class Common
{
  private static string _connectionString;
  private static Control _parentWindow;
  private static Guid _userGuid;

  internal static Control ParentWindow
  {
    get
    {
      return MGASystems.IMS.DocumentAutomation.Common._parentWindow != null || CompanyDocumentAutomation.BlackBoxMode ? MGASystems.IMS.DocumentAutomation.Common._parentWindow : throw new NotInitializedException();
    }
  }

  internal static string ConnectionString
  {
    get
    {
      return !string.IsNullOrEmpty(MGASystems.IMS.DocumentAutomation.Common._connectionString) ? MGASystems.IMS.DocumentAutomation.Common._connectionString : throw new NotInitializedException();
    }
  }

  internal static Guid UserGuid => MGASystems.IMS.DocumentAutomation.Common._userGuid;

  public static void Initialize(string connectionString, Control parentWindow, Guid userGuid)
  {
    MGASystems.IMS.DocumentAutomation.Common._connectionString = connectionString;
    MGASystems.IMS.DocumentAutomation.Common._parentWindow = parentWindow;
    MGASystems.IMS.DocumentAutomation.Common._userGuid = userGuid;
    if (!string.IsNullOrEmpty(CurrentUser.Instance.ConnectionString))
      return;
    CurrentUser.Instance.ConnectionString = connectionString;
  }
}
