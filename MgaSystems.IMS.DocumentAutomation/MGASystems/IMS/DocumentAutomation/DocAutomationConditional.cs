// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DocAutomationConditional
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
public class DocAutomationConditional : MgaMdiChild, IComponentConnector
{
  private bool _contentLoaded;

  public DocAutomationConditional() => this.InitializeComponent();

  [field: AccessedThroughProperty("mainWindow")]
  internal virtual DocAutomationConditional mainWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.DocumentAutomation;component/document%20automation/docautomationconditional/docautomationconditional.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.mainWindow = (DocAutomationConditional) target;
    else
      this._contentLoaded = true;
  }
}
