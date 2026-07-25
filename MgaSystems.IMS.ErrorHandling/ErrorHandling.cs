// Decompiled with JetBrains decompiler
// Type: MGASystems.ErrorHandling.ErrorHandling
// Assembly: MgaSystems.IMS.ErrorHandling, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4686CAD5-B68D-4F03-A647-C480B9E54EB4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.ErrorHandling.dll

using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.ErrorHandling;

[StandardModule]
public sealed class ErrorHandling
{
  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.HandleErrorOnThread instead")]
  public static void HandleErrorOnThread(Control uiContext, Exception ex)
  {
    ErrorHandler.HandleErrorOnThread(uiContext, ex);
  }

  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.SilentHandleError instead")]
  public static void SilentHandleError(Exception ex) => ErrorHandler.SilentHandleError(ex);

  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.SilentHandleError instead")]
  public static void SilentHandleError(Exception ex, int clientId, string userName)
  {
    ErrorHandler.SilentHandleError(ex, clientId, userName);
  }

  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.HandleError instead")]
  public static void HandleError(string newExceptionMessage, Exception innerException)
  {
    ErrorHandler.HandleError(newExceptionMessage, innerException);
  }

  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.HandleError instead")]
  public static void HandleError(Exception ex) => ErrorHandler.HandleError(ex);

  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.HandleError instead")]
  public static void HandleError(Exception ex, bool exitApplicationWhenDone)
  {
    ErrorHandler.HandleError(ex, exitApplicationWhenDone);
  }

  [Obsolete("Please use MGASystems.Common.ErrorHandling.ErrorHandler.ShowDataSetErrors instead")]
  public static void ShowDataSetErrors(DataSet ds, ConstraintException ex)
  {
    ErrorHandler.ShowDataSetErrors(ds, ex);
  }
}
