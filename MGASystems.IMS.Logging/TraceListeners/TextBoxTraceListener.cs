// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Logging.TraceListeners.TextBoxTraceListener
// Assembly: MGASystems.IMS.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DEDE5ABB-2A35-47E4-BD3C-0B33B15168EB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Logging.dll

using System;
using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Logging.TraceListeners;

public class TextBoxTraceListener : TraceListener
{
  private readonly TextBox _target;
  private readonly Action<string> _invokeWrite;

  public TextBoxTraceListener(TextBox target)
  {
    this._target = target;
    this._invokeWrite = (Action<string>) (message => this._target.AppendText(message));
  }

  public override void Write(string message)
  {
    this._target.Invoke((Delegate) this._invokeWrite, (object) (message + Environment.NewLine));
  }

  public override void WriteLine(string message)
  {
    this._target.Invoke((Delegate) this._invokeWrite, (object) (message + Environment.NewLine));
  }

  public override void Write(object o, string category)
  {
    if (MGASystems.IMS.Logging.Log.GetDestination(category) != LogDestination.LiveLog)
      return;
    this.Write(o.ToString());
  }

  public override void WriteLine(object o, string category)
  {
    this.Write(o?.ToString() + Environment.NewLine, category);
  }

  public override bool IsThreadSafe => true;
}
