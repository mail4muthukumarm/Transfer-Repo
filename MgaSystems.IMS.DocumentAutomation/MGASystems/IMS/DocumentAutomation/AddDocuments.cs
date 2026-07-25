// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AddDocuments
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Data.Binding;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[DesignerGenerated]
public class AddDocuments : MgaMdiChild, IComponentConnector, IStyleConnector
{
  private StringCollection _documentFileNames;
  private List<Guid> _newQuoteGuids;
  private Quote _quote;
  private bool _saved;
  private bool _contentLoaded;

  public StringCollection DocumentFileNames => this._documentFileNames;

  public bool Saved => this._saved;

  protected Quote Quote => this._quote;

  public AddDocuments(Quote quote)
    : this(quote, (List<Guid>) null)
  {
  }

  public AddDocuments(List<Guid> quoteGuids)
    : this((Quote) null, (List<Guid>) null)
  {
  }

  public AddDocuments(Quote quote, List<Guid> newQuoteGuids)
  {
    this._saved = false;
    this.InitializeComponent();
    this._quote = quote;
    this._newQuoteGuids = newQuoteGuids;
  }

  public AddDocuments Create(Quote quote, List<Guid> newQuoteGuids)
  {
    return NotifyProxyTypeManager.Allocate<AddDocuments>(new object[2]
    {
      (object) quote,
      (object) newQuoteGuids
    });
  }

  private void TextBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
  {
    TextBox relativeTo = (TextBox) sender;
    relativeTo.CaptureMouse();
    relativeTo.CaretIndex = relativeTo.GetCharacterIndexFromPoint(Mouse.GetPosition((IInputElement) relativeTo), true);
  }

  [field: AccessedThroughProperty("AddDocs")]
  internal virtual AddDocuments AddDocs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.DocumentAutomation;component/document%20automation/adddocs/adddocuments.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    if (connectionId == 1)
      this.AddDocs = (AddDocuments) target;
    else
      this._contentLoaded = true;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public void System_Windows_Markup_IStyleConnector_Connect(int connectionId, object target)
  {
    if (connectionId != 2)
      return;
    ((UIElement) target).MouseLeftButtonUp += new MouseButtonEventHandler(this.TextBox_MouseLeftButtonUp);
  }
}
