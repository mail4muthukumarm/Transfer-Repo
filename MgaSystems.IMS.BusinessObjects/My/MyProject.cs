// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.My.MyProject
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.MGAInvoiceFactory;
using MGASystems.BusinessObjects.MGAWebServicesLogon;
using MGASystems.BusinessObjects.OFAC.IST;
using MGASystems.BusinessObjects.OFAC.PWS;
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
namespace MGASystems.BusinessObjects.My;

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
    public InvoiceFactory m_InvoiceFactory;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public InvoiceFactory_Fix m_InvoiceFactory_Fix;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ISTWatchWebService m_ISTWatchWebService;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Logon m_Logon;
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

    public InvoiceFactory InvoiceFactory
    {
      get
      {
        this.m_InvoiceFactory = MyProject.MyWebServices.Create__Instance__<InvoiceFactory>(this.m_InvoiceFactory);
        return this.m_InvoiceFactory;
      }
      set
      {
        if (value == this.m_InvoiceFactory)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<InvoiceFactory>(ref this.m_InvoiceFactory);
      }
    }

    public InvoiceFactory_Fix InvoiceFactory_Fix
    {
      get
      {
        this.m_InvoiceFactory_Fix = MyProject.MyWebServices.Create__Instance__<InvoiceFactory_Fix>(this.m_InvoiceFactory_Fix);
        return this.m_InvoiceFactory_Fix;
      }
      set
      {
        if (value == this.m_InvoiceFactory_Fix)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<InvoiceFactory_Fix>(ref this.m_InvoiceFactory_Fix);
      }
    }

    public ISTWatchWebService ISTWatchWebService
    {
      get
      {
        this.m_ISTWatchWebService = MyProject.MyWebServices.Create__Instance__<ISTWatchWebService>(this.m_ISTWatchWebService);
        return this.m_ISTWatchWebService;
      }
      set
      {
        if (value == this.m_ISTWatchWebService)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<ISTWatchWebService>(ref this.m_ISTWatchWebService);
      }
    }

    public Logon Logon
    {
      get
      {
        this.m_Logon = MyProject.MyWebServices.Create__Instance__<Logon>(this.m_Logon);
        return this.m_Logon;
      }
      set
      {
        if (value == this.m_Logon)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<Logon>(ref this.m_Logon);
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
