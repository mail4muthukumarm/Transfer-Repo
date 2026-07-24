// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DelayLoadUserControl
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class DelayLoadUserControl : UserControl
{
  private bool _painted;
  private bool _dirtyUI;
  private const int WM_PAINT = 15;

  public event EventHandler DelayLoad;

  public event EventHandler RefreshUI;

  public bool HasLoaded => this._painted;

  protected override void WndProc(ref Message m)
  {
    if (!this.DesignMode && m.Msg == 15 && !this._painted)
    {
      this._painted = true;
      this.OnDelayLoad(EventArgs.Empty);
    }
    base.WndProc(ref m);
  }

  protected virtual void OnDelayLoad(EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler delayLoadEvent = this.DelayLoadEvent;
    if (delayLoadEvent == null)
      return;
    delayLoadEvent((object) this, e);
  }

  protected virtual void OnRefreshUI(EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler refreshUiEvent = this.RefreshUIEvent;
    if (refreshUiEvent == null)
      return;
    refreshUiEvent((object) this, e);
  }

  protected override void OnVisibleChanged(EventArgs e)
  {
    base.OnVisibleChanged(e);
    if (this.DesignMode || !this.HasLoaded || !this._dirtyUI || !this.Visible || !this.IsHandleCreated)
      return;
    this.OnRefreshUI(EventArgs.Empty);
  }

  public void DirtyUI() => this._dirtyUI = true;
}
