// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormDisplayHtml
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Common.Controls.Forms;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class FormDisplayHtml : Form
{
  private readonly string _htmlText;

  private virtual MGAWebView mgaWebView2
  {
    get => this._mgaWebView2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mgaWebView2_BrowserInitialized);
      MGAWebView mgaWebView2_1 = this._mgaWebView2;
      if (mgaWebView2_1 != null)
        mgaWebView2_1.BrowserInitialized -= eventHandler;
      this._mgaWebView2 = value;
      MGAWebView mgaWebView2_2 = this._mgaWebView2;
      if (mgaWebView2_2 == null)
        return;
      mgaWebView2_2.BrowserInitialized += eventHandler;
    }
  }

  public FormDisplayHtml(string htmlText)
  {
    this.InitializeComponent();
    this._htmlText = htmlText;
  }

  private void mgaWebView2_BrowserInitialized(object sender, EventArgs e)
  {
    this.mgaWebView2.NavigateToString(this._htmlText);
  }

  private void InitializeComponent()
  {
    this.mgaWebView2 = new MGAWebView();
    this.SuspendLayout();
    ((ScrollableControl) this.mgaWebView2).AutoScroll = true;
    ((Control) this.mgaWebView2).Dock = DockStyle.Fill;
    ((Control) this.mgaWebView2).Location = new Point(0, 0);
    ((Control) this.mgaWebView2).Margin = new Padding(2);
    ((Control) this.mgaWebView2).MinimumSize = new Size(13, 13);
    ((Control) this.mgaWebView2).Name = "mgaWebView2";
    ((Control) this.mgaWebView2).Size = new Size(931, 589);
    ((Control) this.mgaWebView2).TabIndex = 11;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(931, 589);
    this.Controls.Add((Control) this.mgaWebView2);
    this.Margin = new Padding(2);
    this.Name = nameof (FormDisplayHtml);
    this.Text = "HTML Overview";
    this.ResumeLayout(false);
  }
}
