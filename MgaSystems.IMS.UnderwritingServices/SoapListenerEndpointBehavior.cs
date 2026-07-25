// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.SoapListenerEndpointBehavior
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public class SoapListenerEndpointBehavior : IEndpointBehavior
{
  private readonly Func<Message, object> _beforeSendRequestAction;
  private readonly Action<Message, object> _afterReceiveReplyAction;

  public SoapListenerEndpointBehavior(
    Func<Message, object> beforeRequestAction,
    Action<Message, object> afterReplyAction)
  {
    Func<Message, object> func = beforeRequestAction;
    Action<Message, object> action = afterReplyAction;
    this._beforeSendRequestAction = func;
    this._afterReceiveReplyAction = action;
  }

  void IEndpointBehavior.AddBindingParameters(
    ServiceEndpoint endpoint,
    BindingParameterCollection bindingParameters)
  {
  }

  void IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
  {
    clientRuntime.MessageInspectors.Add((IClientMessageInspector) new SoapListenerEndpointBehavior.SoapListenerMessageInspector(this._beforeSendRequestAction, this._afterReceiveReplyAction));
  }

  void IEndpointBehavior.ApplyDispatchBehavior(
    ServiceEndpoint endpoint,
    EndpointDispatcher endpointDispatcher)
  {
  }

  void IEndpointBehavior.Validate(ServiceEndpoint endpoint)
  {
  }

  private class SoapListenerMessageInspector : IClientMessageInspector
  {
    private readonly Func<Message, object> _beforeSendRequestAction;
    private readonly Action<Message, object> _afterReceiveReplyAction;

    public SoapListenerMessageInspector(
      Func<Message, object> beforeRequestAction,
      Action<Message, object> afterReplyAction)
    {
      Func<Message, object> func = beforeRequestAction;
      Action<Message, object> action = afterReplyAction;
      this._beforeSendRequestAction = func;
      this._afterReceiveReplyAction = action;
    }

    void IClientMessageInspector.AfterReceiveReply(ref Message reply, object correlationState)
    {
      Action<Message, object> receiveReplyAction = this._afterReceiveReplyAction;
      if (receiveReplyAction == null)
        return;
      receiveReplyAction(reply, correlationState);
    }

    object IClientMessageInspector.BeforeSendRequest(ref Message request, IClientChannel channel)
    {
      Func<Message, object> sendRequestAction = this._beforeSendRequestAction;
      return sendRequestAction == null ? (object) null : sendRequestAction(request);
    }
  }
}
