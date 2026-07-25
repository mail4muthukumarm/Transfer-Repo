// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.AutomationEventAdmin.UI.AutomationEventView
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.TechTools.AutomationEventAdmin.UI;

public partial class AutomationEventView : MgaMdiChild, ITransactionLogFilter, IComponentConnector
{
  internal AutomationEventView mainWindow;
  private bool _contentLoaded;

  public Guid? LogIdentifier => new Guid?(new Guid("7108A0EC-F1A2-42F4-81E1-6DF428773C12"));

  public AutomationEventView() => this.InitializeComponent();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.TechTools;component/automationeventadmin/ui/automationeventview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.mainWindow = (AutomationEventView) target;
    else
      this._contentLoaded = true;
  }
}
