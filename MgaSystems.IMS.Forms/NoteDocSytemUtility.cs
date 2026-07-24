// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.NoteDocSytemUtility
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Forms;

[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class NoteDocSytemUtility
{
  public static void Initialize()
  {
    Utility.Initialize((IReportManager) ReportFactory.Instance, (IBroadcastMessageSender) new NoteDocSytemUtility.BroadcastMessageSenderHelper(), (IErrorHandler) new NoteDocSytemUtility.ErrorHelper());
  }

  private NoteDocSytemUtility()
  {
  }

  private class ErrorHelper : IErrorHandler
  {
    public void HandleError(Exception ex) => ErrorHandler.HandleError(ex);
  }

  private class BroadcastMessageSenderHelper : IBroadcastMessageSender
  {
    public void SendBroadcastMessage(Guid eventGuid, object context)
    {
      Messaging.SendBroadcastMessage(eventGuid, RuntimeHelpers.GetObjectValue(context));
    }
  }
}
