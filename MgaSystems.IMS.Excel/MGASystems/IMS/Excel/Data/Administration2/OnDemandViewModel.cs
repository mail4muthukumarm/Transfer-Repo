// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.OnDemandViewModel
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

public abstract class OnDemandViewModel : DependentBindingObject
{
  public abstract bool FreezeChildNodeLoad { get; }

  public abstract bool LoadChildNodesOnThread { get; }

  public bool ChildNodesInitialized { get; private set; }

  [NotificationProperty]
  public virtual bool IsLoadingChildNodes { get; protected set; }

  public void EnsureChildNodesCreated() => this.InitializeChildNodes(false);

  protected void InitializeChildNodes() => this.InitializeChildNodes(this.LoadChildNodesOnThread);

  private void InitializeChildNodes(bool loadChildNodesOnThread)
  {
    if (Information.IsDesignMode || this.ChildNodesInitialized || this.FreezeChildNodeLoad)
      return;
    this.ChildNodesInitialized = true;
    this.IsLoadingChildNodes = true;
    this.PrepareFetchChildNodes();
    if (loadChildNodesOnThread)
    {
      Utility.ExecuteThread((DoWorkEventHandler) ((s, e) => e.Result = this.FetchChildNodes()), (RunWorkerCompletedEventHandler) ((s, e) =>
      {
        this.ProcessChildNodes(e.Result);
        this.IsLoadingChildNodes = false;
      }), (ProgressChangedEventHandler) null);
    }
    else
    {
      this.ProcessChildNodes(this.FetchChildNodes());
      this.IsLoadingChildNodes = false;
    }
  }

  protected virtual void PrepareFetchChildNodes()
  {
  }

  protected abstract object FetchChildNodes();

  protected abstract void ProcessChildNodes(object childNodes);
}
