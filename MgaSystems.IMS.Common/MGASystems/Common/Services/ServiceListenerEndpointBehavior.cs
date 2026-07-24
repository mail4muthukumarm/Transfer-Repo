// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Services.ServiceListenerEndpointBehavior
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

#nullable disable
namespace MGASystems.Common.Services;

public class ServiceListenerEndpointBehavior : IEndpointBehavior
{
  private readonly Action<string> afterReceiveReplyAction;
  private readonly Action<string> beforeSendRequestAction;

  public ServiceListenerEndpointBehavior(
    Action<string> beforeSendRequestAction,
    Action<string> afterReceiveReplyAction)
  {
    this.beforeSendRequestAction = beforeSendRequestAction;
    this.afterReceiveReplyAction = afterReceiveReplyAction;
  }

  public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
  {
    clientRuntime.MessageInspectors.Add((IClientMessageInspector) new ServiceListenerEndpointBehavior.ServiceListenerMessageInspector(this.beforeSendRequestAction, this.afterReceiveReplyAction));
  }

  public void AddBindingParameters(
    ServiceEndpoint endpoint,
    BindingParameterCollection bindingParameters)
  {
  }

  public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
  {
  }

  public void Validate(ServiceEndpoint endpoint)
  {
  }

  private class ServiceListenerMessageInspector : IClientMessageInspector
  {
    private readonly Action<string> afterReceiveReplyAction;
    private readonly Action<string> beforeSendRequestAction;

    public ServiceListenerMessageInspector(
      Action<string> beforeSendRequestAction,
      Action<string> afterReceiveReplyAction)
    {
      this.afterReceiveReplyAction = afterReceiveReplyAction;
      this.beforeSendRequestAction = beforeSendRequestAction;
    }

    public void AfterReceiveReply(ref Message reply, object correlationState)
    {
      if (this.afterReceiveReplyAction == null || reply == null)
        return;
      this.afterReceiveReplyAction(reply.ToString());
    }

    public object BeforeSendRequest(ref Message request, IClientChannel channel)
    {
      if (this.beforeSendRequestAction != null && request != null)
        this.beforeSendRequestAction(request.ToString());
      return (object) null;
    }
  }
}
