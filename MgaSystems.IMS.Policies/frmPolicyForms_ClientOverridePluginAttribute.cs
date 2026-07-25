// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmPolicyForms_ClientOverridePluginAttribute
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System;

#nullable disable
namespace MGASystems.IMS.Policies;

[AttributeUsage(AttributeTargets.Class)]
public class frmPolicyForms_ClientOverridePluginAttribute : Attribute
{
  private string _key;
  private string _pluginTitle;

  public frmPolicyForms_ClientOverridePluginAttribute()
  {
  }

  public frmPolicyForms_ClientOverridePluginAttribute(string key, string pluginTitle)
    : this()
  {
    this._key = key;
    this._pluginTitle = pluginTitle;
  }

  public string Key => this._key;

  public string Title => this._pluginTitle;

  public override bool Match(object obj) => obj is frmPolicyForms_ClientOverridePluginAttribute;
}
