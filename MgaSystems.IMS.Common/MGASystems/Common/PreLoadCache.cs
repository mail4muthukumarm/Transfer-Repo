// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.PreLoadCache
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common;

public sealed class PreLoadCache : IDisposable
{
  private readonly Lazy<Hashtable> _cache;
  private readonly Lazy<ConcurrentDictionary<string, int>> _completedAsynchronousLoads;
  private static readonly Lazy<PreLoadCache> _preLoadCache = new Lazy<PreLoadCache>((Func<PreLoadCache>) ([SpecialName] () => new PreLoadCache()));
  private bool _preLoadComplete;

  public static PreLoadCache Instance => PreLoadCache._preLoadCache.Value;

  private PreLoadCache()
  {
    Func<Hashtable> valueFactory1;
    // ISSUE: reference to a compiler-generated field
    if (PreLoadCache._Closure\u0024__.\u0024I7\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory1 = PreLoadCache._Closure\u0024__.\u0024I7\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      PreLoadCache._Closure\u0024__.\u0024I7\u002D0 = valueFactory1 = (Func<Hashtable>) ([SpecialName] () => new Hashtable());
    }
    this._cache = new Lazy<Hashtable>(valueFactory1);
    Func<ConcurrentDictionary<string, int>> valueFactory2;
    // ISSUE: reference to a compiler-generated field
    if (PreLoadCache._Closure\u0024__.\u0024I7\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory2 = PreLoadCache._Closure\u0024__.\u0024I7\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      PreLoadCache._Closure\u0024__.\u0024I7\u002D1 = valueFactory2 = (Func<ConcurrentDictionary<string, int>>) ([SpecialName] () => new ConcurrentDictionary<string, int>());
    }
    this._completedAsynchronousLoads = new Lazy<ConcurrentDictionary<string, int>>(valueFactory2);
  }

  public void Dispose()
  {
    GC.SuppressFinalize((object) this);
    if (this._cache == null)
      return;
    if (this.Cache.Count <= 0)
      return;
    try
    {
      foreach (IDisposable disposable in this.Cache.Values.OfType<IDisposable>())
        disposable.Dispose();
    }
    finally
    {
      IEnumerator<IDisposable> enumerator;
      enumerator?.Dispose();
    }
    this.Cache.Clear();
    this.CompletedAsynchronousLoads.Clear();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public void DoPreLoad()
  {
    this._preLoadComplete = !this._preLoadComplete ? true : throw new InvalidOperationException("PreLoad may only be called once per application run");
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithInterface(typeof (ISupportPreLoadCache));
    int index = 0;
    while (index < typeArray.Length)
    {
      new Thread(new ThreadStart(new PreLoadCache.AsynchronousTypeLoader(typeArray[index], this).DoPreLoad))
      {
        IsBackground = true,
        Name = "Preload Cache Thread"
      }.Start();
      checked { ++index; }
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public List<Task> DoBlackboxPreload()
  {
    this._preLoadComplete = !this._preLoadComplete ? true : throw new InvalidOperationException("PreLoad may only be called once per application run");
    return ((IEnumerable<Type>) ObjectFactory.Instance.QueryTypesWithInterface(typeof (ISupportBlackboxPreload))).Select<Type, Task>((Func<Type, Task>) ([SpecialName] (preloadType) =>
    {
      TaskFactory factory = Task.Factory;
      Action<object> action;
      // ISSUE: reference to a compiler-generated field
      if (PreLoadCache._Closure\u0024__.\u0024I10\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        action = PreLoadCache._Closure\u0024__.\u0024I10\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        PreLoadCache._Closure\u0024__.\u0024I10\u002D1 = action = (Action<object>) ([SpecialName] (asyncLoader) =>
        {
          if (!(asyncLoader is PreLoadCache.AsynchronousTypeLoader asynchronousTypeLoader2))
            return;
          asynchronousTypeLoader2.DoPreLoad();
        });
      }
      PreLoadCache.AsynchronousTypeLoader state = new PreLoadCache.AsynchronousTypeLoader(preloadType, this, ObjectFactory.Instance);
      return factory.StartNew(action, (object) state);
    })).ToList<Task>();
  }

  public Hashtable Cache => this._cache.Value;

  public bool IsAsynchronousLoadCompleted(string preLoadKey)
  {
    return this.CompletedAsynchronousLoads.ContainsKey(preLoadKey);
  }

  private ConcurrentDictionary<string, int> CompletedAsynchronousLoads
  {
    get => this._completedAsynchronousLoads.Value;
  }

  private sealed class AsynchronousTypeLoader
  {
    private readonly Type _preLoadType;
    private readonly PreLoadCache _cacheInstance;
    private readonly ObjectFactory _objectFactory;
    private static readonly object _lockObject = RuntimeHelpers.GetObjectValue(new object());

    public AsynchronousTypeLoader(Type preLoadType, PreLoadCache cache, ObjectFactory objFactory = null)
    {
      this.ObjectInstance = new Lazy<object>((Func<object>) ([SpecialName] () => this._objectFactory.CreateObject(this._preLoadType)));
      this._preLoadType = preLoadType;
      this._cacheInstance = cache;
      this._objectFactory = objFactory ?? ObjectFactory.Instance;
    }

    private Lazy<object> ObjectInstance { get; }

    public void DoPreLoad()
    {
      try
      {
        object objectValue = RuntimeHelpers.GetObjectValue(this.ObjectInstance.Value);
        if (objectValue == null)
          return;
        if (objectValue is ISupportPreLoadCache supportPreLoadCache)
        {
          OnAsynchronousLoadEventArgs e = new OnAsynchronousLoadEventArgs();
          supportPreLoadCache.OnAsynchronousLoad((object) this, e);
          if (e.Cache.Count > 0)
            this.AddLoadedTypeKey(string.IsNullOrEmpty(supportPreLoadCache.PreLoadKey) ? supportPreLoadCache.GetType().FullName : supportPreLoadCache.PreLoadKey, e.Cache);
        }
        if (!(objectValue is IDisposable disposable))
          return;
        disposable.Dispose();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (MDIControls.Instance.BlackBoxMode)
        {
          ErrorHandler.SilentHandleError(ex2);
        }
        else
        {
          int num = (int) Interaction.MsgBox((object) ex2.Message);
        }
        ProjectData.ClearProjectError();
      }
    }

    private void AddLoadedTypeKey(string preloadKey, Hashtable ht)
    {
      // ISSUE: variable of a compiler-generated type
      PreLoadCache.AsynchronousTypeLoader._Closure\u0024__10\u002D0 closure100;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a boxed type
      __Boxed<int> orAdd = (ValueType) this._cacheInstance.CompletedAsynchronousLoads.GetOrAdd(preloadKey, new Func<string, int>(new PreLoadCache.AsynchronousTypeLoader._Closure\u0024__10\u002D0(closure100)
      {
        \u0024VB\u0024Me = this,
        \u0024VB\u0024Local_ht = ht
      }._Lambda\u0024__0));
    }
  }
}
