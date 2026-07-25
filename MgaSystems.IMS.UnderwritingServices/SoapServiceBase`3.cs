// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.SoapServiceBase`3
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public abstract class SoapServiceBase<TService, TInterface, TClient>
  where TService : SoapServiceBase<TService, TInterface, TClient>
  where TInterface : class
  where TClient : ClientBase<TInterface>, TInterface
{
  private static readonly ConcurrentDictionary<string, ChannelFactory<TInterface>> _channelFactory = new ConcurrentDictionary<string, ChannelFactory<TInterface>>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  private static readonly Lazy<Func<string, TClient>> CachedClientCreator = new Lazy<Func<string, TClient>>((Func<Func<string, TClient>>) (() =>
  {
    try
    {
      System.Type clientType = typeof (TClient);
      ConstructorInfo constructor = clientType.GetConstructor(new System.Type[2]
      {
        typeof (Binding),
        typeof (EndpointAddress)
      });
      if (constructor == (ConstructorInfo) null)
        return (Func<string, TClient>) (uri => (TClient) Activator.CreateInstance(clientType, uri.StartsWith("https", StringComparison.OrdinalIgnoreCase) ? (object) new BasicHttpsBinding() : (object) new BasicHttpBinding(), (object) new EndpointAddress(uri)));
      ParameterExpression instance = Expression.Parameter(typeof (string), "applicationUri");
      ConditionalExpression conditionalExpression = Expression.Condition((Expression) Expression.Call((Expression) instance, "StartsWith", (System.Type[]) null, (Expression) Expression.Constant((object) "https", typeof (string)), (Expression) Expression.Constant((object) StringComparison.OrdinalIgnoreCase, typeof (StringComparison))), (Expression) Expression.Convert((Expression) Expression.New(typeof (BasicHttpsBinding)), typeof (Binding)), (Expression) Expression.Convert((Expression) Expression.New(typeof (BasicHttpBinding)), typeof (Binding)));
      NewExpression newExpression = Expression.New(typeof (EndpointAddress).GetConstructor(new System.Type[1]
      {
        typeof (string)
      }), (Expression) instance);
      return Expression.Lambda<Func<string, TClient>>((Expression) Expression.New(constructor, (Expression) conditionalExpression, (Expression) newExpression), instance).Compile();
    }
    catch
    {
    }
    return (Func<string, TClient>) (uri => default (TClient));
  }));

  protected IProgress<Exception> ErrorProgress { get; }

  protected IProgress<string> LogProgress { get; }

  protected Func<string, object> RequestSoapAction { get; private set; }

  protected Action<string, object> ResponseSoapAction { get; private set; }

  protected string ApplicationUri { get; }

  protected Uri BaseUri { get; }

  public TService SetRequestSoaplListener(Func<string, object> requestSoapListener)
  {
    this.RequestSoapAction = requestSoapListener;
    return (TService) this;
  }

  public TService SetResponseSoapListener(Action<string, object> responseSoapListener)
  {
    this.ResponseSoapAction = responseSoapListener;
    return (TService) this;
  }

  protected SoapServiceBase(
    string applicationUri,
    IProgress<string> logAction = null,
    IProgress<Exception> errorHandlingAction = null)
  {
    this.ApplicationUri = !string.IsNullOrEmpty(applicationUri) ? applicationUri : throw new ArgumentException(nameof (applicationUri));
    this.LogProgress = logAction;
    this.ErrorProgress = errorHandlingAction;
    this.BaseUri = new Uri(this.ApplicationUri);
    this.LogProgress?.Report($"{typeof (TService).Name} successfully initialized. Application Endpoint: {applicationUri}");
  }

  protected virtual object BeforeSendRequestMessage(Message request)
  {
    Func<string, object> requestSoapAction = this.RequestSoapAction;
    return (requestSoapAction != null ? requestSoapAction(request.ToString()) : (object) null) ?? (object) new Guid();
  }

  protected virtual void AfterReceiveResponseMessage(Message response, object correlatingId)
  {
    Action<string, object> responseSoapAction = this.ResponseSoapAction;
    if (responseSoapAction == null)
      return;
    responseSoapAction(response.ToString(), correlatingId);
  }

  private ChannelFactory<TInterface> GetChannelFactory()
  {
    return SoapServiceBase<TService, TInterface, TClient>._channelFactory.GetOrAdd(this.ApplicationUri, (Func<string, ChannelFactory<TInterface>>) (uri =>
    {
      return new ChannelFactory<TInterface>(uri.StartsWith("https", StringComparison.OrdinalIgnoreCase) ? (Binding) new BasicHttpsBinding() : (Binding) new BasicHttpBinding(), uri)
      {
        Endpoint = {
          Behaviors = {
            (IEndpointBehavior) new SoapListenerEndpointBehavior(new Func<Message, object>(this.BeforeSendRequestMessage), new Action<Message, object>(this.AfterReceiveResponseMessage))
          }
        }
      };
    }));
  }

  protected TInterface CreateChannel() => this.GetChannelFactory().CreateChannel();

  protected TInterface CreateChannel(string userName, string password, string domain = "")
  {
    ChannelFactory<TInterface> channelFactory = this.GetChannelFactory();
    ClientCredentials clientCredentials1 = channelFactory.Endpoint.Behaviors.Remove<ClientCredentials>();
    ClientCredentials clientCredentials2 = new ClientCredentials();
    clientCredentials2.Windows.ClientCredential = new NetworkCredential(userName, password, domain);
    channelFactory.Endpoint.Behaviors.Add((IEndpointBehavior) clientCredentials2);
    TInterface channel = channelFactory.CreateChannel();
    channelFactory.Endpoint.Behaviors.Remove((IEndpointBehavior) clientCredentials2);
    channelFactory.Endpoint.Behaviors.Add((IEndpointBehavior) clientCredentials1);
    return channel;
  }

  internal static TClient GetClient(string applicationUri)
  {
    return SoapServiceBase<TService, TInterface, TClient>.CachedClientCreator.Value(applicationUri);
  }

  protected TClient GetClient()
  {
    return SoapServiceBase<TService, TInterface, TClient>.GetClient(this.ApplicationUri);
  }

  protected TClient CreateClient()
  {
    TClient client = this.GetClient();
    if (client.Endpoint.Behaviors.Find<SoapListenerEndpointBehavior>() == null)
      client.Endpoint.Behaviors.Add((IEndpointBehavior) new SoapListenerEndpointBehavior(new Func<Message, object>(this.BeforeSendRequestMessage), new Action<Message, object>(this.AfterReceiveResponseMessage)));
    return client;
  }

  protected TClient CreateClient(string username, string password, string domain = "")
  {
    TClient client = this.CreateClient();
    client.ClientCredentials.Windows.ClientCredential = new NetworkCredential(username, password, domain);
    return client;
  }

  public delegate void MethodAndDataHandler(string method, string data)
    where TService : SoapServiceBase<TService, TInterface, TClient>
    where TInterface : class
    where TClient : ClientBase<TInterface>, TInterface;
}
