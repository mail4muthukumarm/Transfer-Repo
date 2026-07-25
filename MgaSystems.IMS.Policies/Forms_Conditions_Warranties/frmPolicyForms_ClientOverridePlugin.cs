// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Forms_Conditions_Warranties.frmPolicyForms_ClientOverridePlugin
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.UltraWinTabControl;
using System;

#nullable disable
namespace MGASystems.IMS.Policies.Forms_Conditions_Warranties;

public abstract class frmPolicyForms_ClientOverridePlugin : UltraTabPageControl
{
  private int _formId;

  protected int FormId => this._formId;

  public abstract void Save(object sender, EventArgs e);

  public virtual string GetTabName() => "Client Specific";

  public abstract void Fill();

  internal void Fill(int formId)
  {
    this._formId = formId;
    this.Fill();
  }
}
