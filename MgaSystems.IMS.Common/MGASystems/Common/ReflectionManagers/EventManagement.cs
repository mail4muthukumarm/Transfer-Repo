// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ReflectionManagers.EventManagement
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.ReflectionManagers;

[StandardModule]
public sealed class EventManagement
{
  public static void AddLateBoundHandler(
    object eventPublisher,
    string eventName,
    object eventSubscriber,
    string eventHandlerName)
  {
    EventManagement.ConfigureLateBoundHandler(RuntimeHelpers.GetObjectValue(eventPublisher), eventName, RuntimeHelpers.GetObjectValue(eventSubscriber), eventHandlerName, true);
  }

  public static void RemoveLateBoundHandler(
    object eventPublisher,
    string eventName,
    object eventSubscriber,
    string eventHandlerName)
  {
    EventManagement.ConfigureLateBoundHandler(RuntimeHelpers.GetObjectValue(eventPublisher), eventName, RuntimeHelpers.GetObjectValue(eventSubscriber), eventHandlerName, false);
  }

  private static void ConfigureLateBoundHandler(
    object eventPublisher,
    string eventName,
    object eventSubscriber,
    string eventHandlerName,
    bool connectHandler)
  {
    if (eventPublisher == null)
      throw new ArgumentNullException(nameof (eventPublisher));
    if (eventSubscriber == null)
      throw new ArgumentNullException(nameof (eventSubscriber));
    if (string.IsNullOrWhiteSpace(eventName))
      throw new ArgumentNullException(nameof (eventName));
    if (string.IsNullOrWhiteSpace(eventHandlerName))
      throw new ArgumentNullException(nameof (eventHandlerName));
    EventInfo eventInfo = eventPublisher.GetType().GetEvent(eventName);
    if ((object) eventInfo == null)
      throw new ArgumentException("Event Does not exist on the event publisher", nameof (eventName));
    Delegate handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, RuntimeHelpers.GetObjectValue(eventSubscriber), eventSubscriber.GetType().GetMethod(eventHandlerName, BindingFlags.Instance | BindingFlags.NonPublic) ?? throw new ArgumentException("Event Handler Method Does not exist on the event subscriber", nameof (eventHandlerName)));
    if ((object) handler == null)
      throw new InvalidOperationException($"ConfigureLateBoundHandler unable to create delegate for {eventHandlerName} event");
    if (connectHandler)
      eventInfo.AddEventHandler(RuntimeHelpers.GetObjectValue(eventPublisher), handler);
    else
      eventInfo.RemoveEventHandler(RuntimeHelpers.GetObjectValue(eventPublisher), handler);
  }
}
