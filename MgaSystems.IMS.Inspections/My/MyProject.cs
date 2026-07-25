// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.My.MyProject
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.IMS.Policies.Inspections.MajesticExpertInsp;
using MGASystems.IMS.Policies.Inspections.RegionalReporting;
using MGASystems.IMS.Policies.Inspections.Reliable;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
namespace MGASystems.IMS.Policies.Inspections.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
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
  internal static User User
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
    public MajesticExpertInspectWebService m_MajesticExpertInspectWebService;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Request m_Request;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Requests m_Requests;

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

    public MajesticExpertInspectWebService MajesticExpertInspectWebService
    {
      get
      {
        this.m_MajesticExpertInspectWebService = MyProject.MyWebServices.Create__Instance__<MajesticExpertInspectWebService>(this.m_MajesticExpertInspectWebService);
        return this.m_MajesticExpertInspectWebService;
      }
      set
      {
        if (value == this.m_MajesticExpertInspectWebService)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<MajesticExpertInspectWebService>(ref this.m_MajesticExpertInspectWebService);
      }
    }

    public Request Request
    {
      get
      {
        this.m_Request = MyProject.MyWebServices.Create__Instance__<Request>(this.m_Request);
        return this.m_Request;
      }
      set
      {
        if (value == this.m_Request)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<Request>(ref this.m_Request);
      }
    }

    public Requests Requests
    {
      get
      {
        this.m_Requests = MyProject.MyWebServices.Create__Instance__<Requests>(this.m_Requests);
        return this.m_Requests;
      }
      set
      {
        if (value == this.m_Requests)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<Requests>(ref this.m_Requests);
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
