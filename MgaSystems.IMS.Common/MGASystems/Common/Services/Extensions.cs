// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Services.Extensions
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Web.Services.Configuration;
using System.Web.Services.Protocols;

#nullable disable
namespace MGASystems.Common.Services;

[StandardModule]
public sealed class Extensions
{
  private static readonly List<Type> RegisteredExtensions = new List<Type>();

  [ReflectionPermission(SecurityAction.Demand, Unrestricted = true)]
  public static void RegisterSoapExtension(Type type, int priority, PriorityGroup group)
  {
    if (!type.IsSubclassOf(typeof (SoapExtension)))
      throw new ArgumentException("Type must be derived from SoapException.", nameof (type));
    if (priority < 1)
      throw new ArgumentOutOfRangeException(nameof (priority), (object) priority, "Priority must be greater or equal to 1.");
    if (Extensions.RegisteredExtensions.Contains(type))
      return;
    Extensions.RegisteredExtensions.Add(type);
    WebServicesSection current = WebServicesSection.Current;
    typeof (ConfigurationElementCollection).GetField("bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) current.SoapExtensionTypes, (object) false);
    current.SoapExtensionTypes.Add(new SoapExtensionTypeElement(type, priority, group));
    typeof (ConfigurationElement).GetMethod("ResetModified", BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) current.SoapExtensionTypes, (object[]) null);
    typeof (ConfigurationElement).GetMethod("SetReadOnly", BindingFlags.Instance | BindingFlags.NonPublic).Invoke((object) current.SoapExtensionTypes, (object[]) null);
  }

  public static void RegisterSoapExtensionType(
    this Type soapExtension,
    int priority = 1,
    PriorityGroup group = PriorityGroup.Low)
  {
    if (!typeof (SoapExtension).IsAssignableFrom(soapExtension))
      return;
    Extensions.RegisterSoapExtension(soapExtension, priority, group);
  }

  public static void RegisterListenerAction(
    this SoapHttpClientProtocol soapClient,
    Action<string> requestAction,
    Action<string> responseAction,
    bool unregisterActionsAfterExecute = true)
  {
    if (Extensions.RegisteredExtensions.Count == 0)
      return;
    if (unregisterActionsAfterExecute)
    {
      if (requestAction != null)
      {
        Action<string> action = requestAction;
        SoapListenerExtension.RequestAction = (Action<string>) ([SpecialName] (str) =>
        {
          action(str);
          SoapListenerExtension.RequestAction = (Action<string>) null;
        });
      }
      if (responseAction == null)
        return;
      Action<string> action1 = responseAction;
      SoapListenerExtension.ResponseAction = (Action<string>) ([SpecialName] (str) =>
      {
        action1(str);
        SoapListenerExtension.ResponseAction = (Action<string>) null;
      });
    }
    else
    {
      SoapListenerExtension.RequestAction = requestAction;
      SoapListenerExtension.ResponseAction = responseAction;
    }
  }
}
