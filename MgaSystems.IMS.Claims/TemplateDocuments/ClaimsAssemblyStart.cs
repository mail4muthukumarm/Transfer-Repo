// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.TemplateDocuments.ClaimsAssemblyStart
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;

#nullable disable
namespace MGASystems.IMS.Claims.TemplateDocuments;

internal class ClaimsAssemblyStart : ISupportPreLoadCache
{
  void ISupportPreLoadCache.OnAsynchronousLoad(object sender, OnAsynchronousLoadEventArgs e)
  {
    Messaging.MessageSent += new Messaging.MessageSentEventHandler(new Claims_BroadcastMessageListener().ReceiveMessage);
  }

  string ISupportPreLoadCache.PreLoadKey => (string) null;
}
