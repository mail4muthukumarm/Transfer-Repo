// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterWithUIBase
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public abstract class RaterWithUIBase : RaterBase
{
  private Form _frm;
  private bool disposedValue;

  protected Form frm
  {
    get => this._frm;
    set => this._frm = value;
  }

  public override string GetOptionDescription(Guid quoteOptionGuid) => (string) null;

  [EditorBrowsable(EditorBrowsableState.Never)]
  public override bool HasUI => true;

  [EditorBrowsable(EditorBrowsableState.Never)]
  public override void ShowUI()
  {
    if (this.frm == null)
    {
      this.frm = this.CreateUI();
      if (this.frm == null)
        throw new InvalidOperationException("CreateUI must return a valid form reference");
      if (this.frm is frmRaterBase)
        ((frmRaterBase) this.frm).Rater = (RaterBase) this;
      this.frm.Closed += new EventHandler(this.UI_Closed);
    }
    this.frm.MdiParent = MDIControls.Instance.MDIParent;
    this.frm.Show();
  }

  private void UI_Closed(object sender, EventArgs e)
  {
    this._frm.Closed -= new EventHandler(this.UI_Closed);
    this.OnUIClosed();
  }

  protected virtual Form CreateUI() => (Form) null;

  protected override void Dispose(bool disposing)
  {
    if (!this.disposedValue && disposing && this._frm != null && !this._frm.IsDisposed && this._frm.IsHandleCreated)
      this._frm.Dispose();
    this.disposedValue = true;
  }
}
