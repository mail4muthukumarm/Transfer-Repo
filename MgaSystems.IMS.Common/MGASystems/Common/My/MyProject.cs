// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.My.MyProject
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.adrconnect;
using MGASystems.Common.AdrDemo;
using MGASystems.Common.iixService;
using MGASystems.Common.MgaReportingServices;
using MGASystems.Common.pws;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.Common.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [HelpKeyword("My.Computer")]
  internal static MyComputer Computer
  {
    [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Application")]
  internal static MyApplication Application
  {
    [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
  }

  [HelpKeyword("My.User")]
  internal static Microsoft.VisualBasic.ApplicationServices.User User
  {
    [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
  }

  [HelpKeyword("My.WebServices")]
  internal static MyProject.MyWebServices WebServices
  {
    [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  internal sealed class MyWebServices
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public AdrConnectWebService m_AdrConnectWebService;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public auth m_auth;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public BasicHttpBinding_IAdrConnectWebService m_BasicHttpBinding_IAdrConnectWebService;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public BasicHttpBinding_IAdrConnectWebService1 m_BasicHttpBinding_IAdrConnectWebService1;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public CriticalErrorService m_CriticalErrorService;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MGASystems.Common.Services.ISTWatchWebService.ISTWatchWebService m_ISTWatchWebService;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public PPWebServicePublic m_PPWebServicePublic;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    internal new Type GetType() => typeof (MyProject.MyWebServices);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T Create__Instance__<T>(T instance) where T : new()
    {
      return (object) instance != null ? instance : new T();
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MyWebServices()
    {
    }

    public AdrConnectWebService AdrConnectWebService
    {
      get
      {
        this.m_AdrConnectWebService = MyProject.MyWebServices.Create__Instance__<AdrConnectWebService>(this.m_AdrConnectWebService);
        return this.m_AdrConnectWebService;
      }
      set
      {
        if (value == this.m_AdrConnectWebService)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<AdrConnectWebService>(ref this.m_AdrConnectWebService);
      }
    }

    public auth auth
    {
      get
      {
        this.m_auth = MyProject.MyWebServices.Create__Instance__<auth>(this.m_auth);
        return this.m_auth;
      }
      set
      {
        if (value == this.m_auth)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<auth>(ref this.m_auth);
      }
    }

    public BasicHttpBinding_IAdrConnectWebService BasicHttpBinding_IAdrConnectWebService
    {
      get
      {
        this.m_BasicHttpBinding_IAdrConnectWebService = MyProject.MyWebServices.Create__Instance__<BasicHttpBinding_IAdrConnectWebService>(this.m_BasicHttpBinding_IAdrConnectWebService);
        return this.m_BasicHttpBinding_IAdrConnectWebService;
      }
      set
      {
        if (value == this.m_BasicHttpBinding_IAdrConnectWebService)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<BasicHttpBinding_IAdrConnectWebService>(ref this.m_BasicHttpBinding_IAdrConnectWebService);
      }
    }

    public BasicHttpBinding_IAdrConnectWebService1 BasicHttpBinding_IAdrConnectWebService1
    {
      get
      {
        this.m_BasicHttpBinding_IAdrConnectWebService1 = MyProject.MyWebServices.Create__Instance__<BasicHttpBinding_IAdrConnectWebService1>(this.m_BasicHttpBinding_IAdrConnectWebService1);
        return this.m_BasicHttpBinding_IAdrConnectWebService1;
      }
      set
      {
        if (value == this.m_BasicHttpBinding_IAdrConnectWebService1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<BasicHttpBinding_IAdrConnectWebService1>(ref this.m_BasicHttpBinding_IAdrConnectWebService1);
      }
    }

    public CriticalErrorService CriticalErrorService
    {
      get
      {
        this.m_CriticalErrorService = MyProject.MyWebServices.Create__Instance__<CriticalErrorService>(this.m_CriticalErrorService);
        return this.m_CriticalErrorService;
      }
      set
      {
        if (value == this.m_CriticalErrorService)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<CriticalErrorService>(ref this.m_CriticalErrorService);
      }
    }

    public MGASystems.Common.Services.ISTWatchWebService.ISTWatchWebService ISTWatchWebService
    {
      get
      {
        this.m_ISTWatchWebService = MyProject.MyWebServices.Create__Instance__<MGASystems.Common.Services.ISTWatchWebService.ISTWatchWebService>(this.m_ISTWatchWebService);
        return this.m_ISTWatchWebService;
      }
      set
      {
        if (value == this.m_ISTWatchWebService)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<MGASystems.Common.Services.ISTWatchWebService.ISTWatchWebService>(ref this.m_ISTWatchWebService);
      }
    }

    public PPWebServicePublic PPWebServicePublic
    {
      get
      {
        this.m_PPWebServicePublic = MyProject.MyWebServices.Create__Instance__<PPWebServicePublic>(this.m_PPWebServicePublic);
        return this.m_PPWebServicePublic;
      }
      set
      {
        if (value == this.m_PPWebServicePublic)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<PPWebServicePublic>(ref this.m_PPWebServicePublic);
      }
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [ComVisible(false)]
  internal sealed class ThreadSafeObjectProvider<T> where T : new()
  {
    private readonly ContextValue<T> m_Context;

    internal T GetInstance
    {
      [DebuggerHidden] get
      {
        T getInstance = this.m_Context.Value;
        if ((object) getInstance == null)
        {
          getInstance = new T();
          this.m_Context.Value = getInstance;
        }
        return getInstance;
      }
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ThreadSafeObjectProvider() => this.m_Context = new ContextValue<T>();
  }
}
