// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BindingChecklistQuoteView
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

public partial class BindingChecklistQuoteView : MgaMdiChild, IComponentConnector
{
  internal TextBlock lblRequirement;
  internal TextBox txComment;
  internal CheckBox txtcompleted;
  internal TextBlock lblBy;
  internal TextBlock By;
  internal TextBlock lbldate;
  internal TextBlock Date;
  private bool _contentLoaded;

  public BindingChecklistQuoteView()
  {
    this.InitializeComponent();
    this.Title = "Policy Binding CheckList";
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/bindingchecklist/bindingchecklistquoteview.xaml", UriKind.Relative));
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
        this.txComment = (TextBox) target;
        break;
      case 3:
        this.txtcompleted = (CheckBox) target;
        break;
      case 4:
        this.lblBy = (TextBlock) target;
        break;
      case 5:
        this.By = (TextBlock) target;
        break;
      case 6:
        this.lbldate = (TextBlock) target;
        break;
      case 7:
        this.Date = (TextBlock) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}
