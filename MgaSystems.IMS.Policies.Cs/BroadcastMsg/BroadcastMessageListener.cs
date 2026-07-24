// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BroadcastMsg.BroadcastMessageListener
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MgaSystems.IMS.Policies.AuthorityLimit.Lib;
using System;

#nullable disable
namespace MgaSystems.IMS.Policies.BroadcastMsg;

public class BroadcastMessageListener : IMessageListener, ISupportPreLoadCache
{
  internal void ReceiveMessage(object sender, Messaging.MessageEventArgs e)
  {
    this.OnMessageReceived(e.EventGuid, e.Context);
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (!(eventGuid == BroadcastMessages.AuthorityLimitNoteSent) || !(context is object[] objArray))
      return;
    Guid guid = (Guid) objArray[0];
    if (!(objArray[1] is AuthorityLimitsTaskHistory limitsTaskHistory))
      return;
    limitsTaskHistory.NoteGuid = guid;
    limitsTaskHistory.Update();
  }

  public void OnAsynchronousLoad(object sender, OnAsynchronousLoadEventArgs e)
  {
    Messaging.MessageSent += new Messaging.MessageSentEventHandler(new BroadcastMessageListener().ReceiveMessage);
  }

  public string PreLoadKey => string.Empty;
}
