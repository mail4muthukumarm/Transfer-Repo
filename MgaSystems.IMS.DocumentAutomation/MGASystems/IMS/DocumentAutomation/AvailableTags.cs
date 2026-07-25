// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AvailableTags
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Interop;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[DesignerGenerated]
public class AvailableTags : MgaMdiChild, IComponentConnector
{
  private bool _contentLoaded;

  public AvailableTags() => this.InitializeComponent();

  [field: AccessedThroughProperty("AvailableTags")]
  internal virtual AvailableTags AvailableTags { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.DocumentAutomation;component/document%20automation/docautomationconditional/availabletags.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.AvailableTags = (AvailableTags) target;
    else
      this._contentLoaded = true;
  }
}
