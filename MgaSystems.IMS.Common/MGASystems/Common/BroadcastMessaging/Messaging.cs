// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.BroadcastMessaging.Messaging
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.DockingManagement;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.BroadcastMessaging;

[StandardModule]
[LogCategory("MGASystems.Common.BroadcastMessage.Messaging", "MGASystems.Common.BroadcastMessage.Messaging")]
public sealed class Messaging
{
  internal const string LogKey = "MGASystems.Common.BroadcastMessage.Messaging";

  public static event Messaging.MessageSentEventHandler MessageSent;

  public static void SendBroadcastMessage(Guid eventGuid)
  {
    Messaging.SendBroadcastMessage(eventGuid, (object) null);
  }

  public static void SendBroadcastMessage(Guid eventGuid, object context)
  {
    Messaging.SendBroadcastMessage(eventGuid, RuntimeHelpers.GetObjectValue(context), BroadcastMessages.Translate(eventGuid));
  }

  public static void SendBroadcastMessage(Guid eventGuid, object context, string logMessage)
  {
    MDIControls instance = MDIControls.Instance;
    if ((instance != null ? (instance.BlackBoxMode ? 1 : 0) : 1) != 0 || MDIControls.Instance.MDIParent == null)
      return;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is IMessageListener messageListener)
        messageListener.OnMessageReceived(eventGuid, RuntimeHelpers.GetObjectValue(context));
      checked { ++index; }
    }
    DockingManager.SendMessageToTabs(eventGuid, RuntimeHelpers.GetObjectValue(context));
    Messaging.MessageEventArgs e = new Messaging.MessageEventArgs();
    e.Context = RuntimeHelpers.GetObjectValue(context);
    e.EventGuid = eventGuid;
    // ISSUE: reference to a compiler-generated field
    Messaging.MessageSentEventHandler messageSentEvent = Messaging.MessageSentEvent;
    if (messageSentEvent != null)
      messageSentEvent((object) null, e);
    Messaging.WriteLog(logMessage, RuntimeHelpers.GetObjectValue(context));
  }

  private static void WriteLog(string logMessage, object context)
  {
    if (Log.GetDestination("MGASystems.Common.BroadcastMessage.Messaging") == LogDestination.Disabled)
      return;
    if (context == null)
    {
      Log.Write(logMessage, "MGASystems.Common.BroadcastMessage.Messaging");
    }
    else
    {
      string str1 = context.ToString();
      string str2;
      try
      {
        using (StringWriter stringWriter = new StringWriter())
        {
          new XmlSerializer(context.GetType()).Serialize((TextWriter) stringWriter, RuntimeHelpers.GetObjectValue(context));
          str2 = stringWriter.ToString();
        }
        if (string.IsNullOrEmpty(str2))
          str2 = str1;
      }
      catch (SerializationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        str2 = str1;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str2 = "Could Not Serialize Context into XML";
        ProjectData.ClearProjectError();
      }
      Log.Write(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}, Context: {1}", (object) logMessage, (object) str2), "MGASystems.Common.BroadcastMessage.Messaging");
    }
  }

  public sealed class MessageEventArgs : EventArgs
  {
    private Guid _eventGuid;
    private object _context;

    public Guid EventGuid
    {
      get => this._eventGuid;
      set => this._eventGuid = value;
    }

    public object Context
    {
      get => this._context;
      set => this._context = RuntimeHelpers.GetObjectValue(value);
    }
  }

  public delegate void MessageSentEventHandler(object sender, Messaging.MessageEventArgs e);
}
