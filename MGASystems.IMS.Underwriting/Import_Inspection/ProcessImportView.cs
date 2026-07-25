// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.ProcessImportView
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Mga.Wpf.Ims.Interop;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public class ProcessImportView : MgaMdiChild, IComponentConnector
{
  internal ProcessImportView mainWindow;
  private bool _contentLoaded;

  public ProcessImportView() => this.InitializeComponent();

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MGASystems.IMS.Underwriting;component/import%20inspection/processimportview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.mainWindow = (ProcessImportView) target;
    else
      this._contentLoaded = true;
  }
}
