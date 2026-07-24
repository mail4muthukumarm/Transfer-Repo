// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.UI.SimpleQuoteDisplay
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using System;
using System.Windows;
using System.Windows.Controls;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.UI;

public class SimpleQuoteDisplay
{
  public virtual void ShowSimpleQuote()
  {
    SimpleQuoteView simpleQuoteView = MgaMdiChild.Create<SimpleQuoteView>(Array.Empty<object>());
    SimpleQuoteViewModel simpleQuoteViewModel = SimpleQuoteViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
    ((FrameworkElement) simpleQuoteView).DataContext = (object) simpleQuoteViewModel;
    simpleQuoteView.AddSubmissionControl((UserControl) new SubmissionView(simpleQuoteViewModel));
    simpleQuoteView.AddQuoteControl((UserControl) new QuoteView(simpleQuoteViewModel));
    simpleQuoteView.AddQuoteDetailControl((UserControl) new QuoteDetailView(simpleQuoteViewModel));
    simpleQuoteView.Form.MdiParent = MDIControls.Instance.MDIParent;
    simpleQuoteView.Form.Show();
  }
}
