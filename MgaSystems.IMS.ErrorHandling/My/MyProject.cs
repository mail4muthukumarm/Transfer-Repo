// Decompiled with JetBrains decompiler
// Type: MGASystems.ErrorHandling.My.MyProject
// Assembly: MgaSystems.IMS.ErrorHandling, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4686CAD5-B68D-4F03-A647-C480B9E54EB4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.ErrorHandling.dll

using MGASystems.ErrorHandling.MgaReportingServices;
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
namespace MGASystems.ErrorHandling.My;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [DebuggerNonUserCode]
  static MyProject()
  {
  }

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
    public MGAReportingServices m_MGAReportingServices;

    public MGAReportingServices MGAReportingServices
    {
      [DebuggerNonUserCode] get
      {
        this.m_MGAReportingServices = MyProject.MyWebServices.Create__Instance__<MGAReportingServices>(this.m_MGAReportingServices);
        return this.m_MGAReportingServices;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_MGAReportingServices)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<MGAReportingServices>(ref this.m_MGAReportingServices);
      }
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    internal new Type GetType() => typeof (MyProject.MyWebServices);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T Create__Instance__<T>(T instance) where T : new()
    {
      return (object) instance == null ? new T() : instance;
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public MyWebServices()
    {
    }
  }

  [ComVisible(false)]
  [EditorBrowsable(EditorBrowsableState.Never)]
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public ThreadSafeObjectProvider() => this.m_Context = new ContextValue<T>();
  }
}
