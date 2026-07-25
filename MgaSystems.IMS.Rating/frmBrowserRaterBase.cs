// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmBrowserRaterBase
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.Common.Controls;
using MGASystems.Common.Controls.Forms;
using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public abstract class frmBrowserRaterBase : frmRaterBase
{
  private IContainer components;
  private const string RatingMenu_CopyUrl = "Rating_CopyUrl";
  private const string RatingMenu_OpenUrl = "Rating_OpenUrl";
  private bool _clicked;
  private string _resolvedUrl;

  protected frmBrowserRaterBase()
  {
    this.Load += new EventHandler(this.frmBrowserRaterBase_Load);
    this._clicked = false;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.StatusBarProgress = new ToolStripProgressBar();
    this.StatusStripBar = new StatusStrip();
    this.StatusBarLabel = new ToolStripStatusLabel();
    this.MgaWebView1 = new MGAWebView();
    this.StatusStripBar.SuspendLayout();
    this.SuspendLayout();
    this.StatusBarProgress.Name = "StatusBarProgress";
    this.StatusBarProgress.Size = new Size(133, 23);
    this.StatusBarProgress.Style = ProgressBarStyle.Marquee;
    this.StatusStripBar.ImageScalingSize = new Size(20, 20);
    this.StatusStripBar.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.StatusBarLabel,
      (ToolStripItem) this.StatusBarProgress
    });
    this.StatusStripBar.Location = new Point(0, 625);
    this.StatusStripBar.Name = "StatusStripBar";
    this.StatusStripBar.Padding = new Padding(1, 0, 19, 0);
    this.StatusStripBar.Size = new Size(1057, 29);
    this.StatusStripBar.TabIndex = 13;
    this.StatusStripBar.Text = "statusStrip1";
    this.StatusBarLabel.Name = "StatusBarLabel";
    this.StatusBarLabel.Size = new Size(194, 24);
    this.StatusBarLabel.Text = "Please wait while document loads...";
    this.MgaWebView1.Dock = DockStyle.Fill;
    this.MgaWebView1.Location = new Point(12, 6);
    this.MgaWebView1.MinimumSize = new Size(20, 20);
    this.MgaWebView1.Name = "MgaWebView1";
    this.MgaWebView1.Size = new Size(779, 464);
    this.MgaWebView1.TabIndex = 14;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(793, 506);
    this.Controls.Add((Control) this.MgaWebView1);
    this.Controls.Add((Control) this.StatusStripBar);
    this.Name = nameof (frmBrowserRaterBase);
    this.Text = "Browser Rater";
    this.Controls.SetChildIndex((Control) this.StatusStripBar, 0);
    this.Controls.SetChildIndex((Control) this.MgaWebView1, 0);
    this.StatusStripBar.ResumeLayout(false);
    this.StatusStripBar.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("StatusStripBar")]
  protected virtual StatusStrip StatusStripBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("StatusBarProgress")]
  protected virtual ToolStripProgressBar StatusBarProgress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("StatusBarLabel")]
  protected virtual ToolStripStatusLabel StatusBarLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAWebView MgaWebView1
  {
    get => this._MgaWebView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.RaterBrowser_DocumentCompleted);
      EventHandler eventHandler2 = new EventHandler(this.frmBrowserRaterBase_BrowserInitialized);
      MGAWebView mgaWebView1_1 = this._MgaWebView1;
      if (mgaWebView1_1 != null)
      {
        mgaWebView1_1.LoadCompleted -= eventHandler1;
        mgaWebView1_1.BrowserInitialized -= eventHandler2;
      }
      this._MgaWebView1 = value;
      MGAWebView mgaWebView1_2 = this._MgaWebView1;
      if (mgaWebView1_2 == null)
        return;
      mgaWebView1_2.LoadCompleted += eventHandler1;
      mgaWebView1_2.BrowserInitialized += eventHandler2;
    }
  }

  private void Document_SubmitButtonClicked(object sender, MouseButtonClickedEventArgs e)
  {
    if (!this.RaterCloseCondition(e))
      return;
    this._clicked = true;
  }

  private void RaterBrowser_DocumentCompleted(object sender, EventArgs e)
  {
    if (!this._clicked)
    {
      this.StatusBarProgress.Visible = false;
      this.StatusBarLabel.Text = "Ready";
      this.MgaWebView1.MouseButtonClicked += new EventHandler<MouseButtonClickedEventArgs>(this.Document_SubmitButtonClicked);
    }
    else
      this.Close();
  }

  private void frmBrowserRaterBase_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Text = this.SafeRaterName;
  }

  private void frmBrowserRaterBase_BrowserInitialized(object sender, EventArgs e)
  {
    try
    {
      this._resolvedUrl = this.GetNavigateUrl(this.Rater);
      Dictionary<string, string> postParameters = this.GetPostParameters(this.Rater);
      if (postParameters != null && postParameters.Count > 0)
      {
        Dictionary<string, string> source = postParameters;
        Func<KeyValuePair<string, string>, string> selector;
        // ISSUE: reference to a compiler-generated field
        if (frmBrowserRaterBase._Closure\u0024__.\u0024I27\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = frmBrowserRaterBase._Closure\u0024__.\u0024I27\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmBrowserRaterBase._Closure\u0024__.\u0024I27\u002D0 = selector = (Func<KeyValuePair<string, string>, string>) ([SpecialName] (drEntry) => $"{drEntry.Key}={drEntry.Value}");
        }
        this.MgaWebView1.Navigate(this._resolvedUrl, Encoding.UTF8.GetBytes(string.Join("&", source.Select<KeyValuePair<string, string>, string>(selector))), "Content-Type: application/x-www-form-urlencoded");
      }
      else
        this.MgaWebView1.Navigate(this._resolvedUrl);
      Uri result = (Uri) null;
      if (string.IsNullOrEmpty(this._resolvedUrl) || !Uri.TryCreate(this._resolvedUrl, UriKind.Absolute, out result))
        return;
      this.AddRatingMenuTool("Rating_CopyUrl", "Copy Resolved Url", (Image) null);
      this.AddRatingMenuTool("Rating_OpenUrl", "Open in Browser", (Image) null);
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (MessageBox.Show($"Exception: {ex2.Message}.{"\n"}Submit error report?", this.SafeRaterName + " Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
        ErrorHandler.SilentHandleError(ex2);
      this.MdiParent.BeginInvoke((Delegate) new Action(((Form) this).Close));
      ProjectData.ClearProjectError();
    }
  }

  protected abstract bool RaterCloseCondition(MouseButtonClickedEventArgs elementClicked);

  protected abstract string GetNavigateUrl(RaterBase rater);

  protected abstract string SafeRaterName { get; }

  protected virtual Dictionary<string, string> GetPostParameters(RaterBase rater)
  {
    return (Dictionary<string, string>) null;
  }

  protected override void ClientMenuToolClick(string ToolKey)
  {
    string Left = ToolKey;
    if (Operators.CompareString(Left, "Rating_CopyUrl", false) != 0)
    {
      if (Operators.CompareString(Left, "Rating_OpenUrl", false) == 0)
        Process.Start(this._resolvedUrl);
    }
    else
      Clipboard.SetText(this._resolvedUrl);
    base.ClientMenuToolClick(ToolKey);
  }
}
