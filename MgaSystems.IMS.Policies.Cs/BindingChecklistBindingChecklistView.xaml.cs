// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BindingChecklistView
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.BindingChecklist;

public partial class BindingChecklistView : MgaMdiChild, IComponentConnector
{
  internal TextBlock lblRequirement;
  internal TextBox txtRequirement;
  internal CheckBox chkBind;
  internal CheckBox chkIssue;
  internal CheckBox chkQuote;
  internal TextBlock lblComment;
  internal TextBox txtComment;
  private bool _contentLoaded;

  public BindingChecklistView()
  {
    this.InitializeComponent();
    this.Title = "Administration Binding CheckList";
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/bindingchecklist/bindingchecklistview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.lblRequirement = (TextBlock) target;
        break;
      case 2:
        this.txtRequirement = (TextBox) target;
        break;
      case 3:
        this.chkBind = (CheckBox) target;
        break;
      case 4:
        this.chkIssue = (CheckBox) target;
        break;
      case 5:
        this.chkQuote = (CheckBox) target;
        break;
      case 6:
        this.lblComment = (TextBlock) target;
        break;
      case 7:
        this.txtComment = (TextBox) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}
