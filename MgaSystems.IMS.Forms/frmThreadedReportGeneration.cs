// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmThreadedReportGeneration
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class frmThreadedReportGeneration : Form
{
  private IContainer components;
  private ProgressBar progressBar;
  private PictureBox pbBook;
  private Label lblAction;
  private Panel pnlBounce;
  private BouncingProgress BouncingProgress1;
  private Label Label1;
  private bool _exitWithOutMessage;
  private bool _reportIsComplete;
  private Type _rptType;
  private string _title;
  private Thread _reportThread;
  private Guid _adHocReportGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btn
  {
    get => this._btn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btn_Click);
      MGAButton btn1 = this._btn;
      if (btn1 != null)
        ((Control) btn1).Click -= eventHandler;
      this._btn = value;
      MGAButton btn2 = this._btn;
      if (btn2 == null)
        return;
      ((Control) btn2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmThreadedReportGeneration));
    this.btn = new MGAButton();
    this.progressBar = new ProgressBar();
    this.pbBook = new PictureBox();
    this.lblAction = new Label();
    this.pnlBounce = new Panel();
    this.Label1 = new Label();
    this.BouncingProgress1 = new BouncingProgress();
    ((ISupportInitialize) this.btn).BeginInit();
    ((ISupportInitialize) this.pbBook).BeginInit();
    this.pnlBounce.SuspendLayout();
    this.SuspendLayout();
    appearance.BackColor = Color.Gainsboro;
    appearance.BackColor2 = Color.White;
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.Gray;
    ((ControlBase) this.btn).Appearance = (AppearanceBase) appearance;
    ((Control) this.btn).Location = new Point(233, 51);
    ((Control) this.btn).Name = "btn";
    ((Control) this.btn).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.btn).TabIndex = 0;
    ((ControlBase) this.btn).Text = "Cancel";
    this.btn.UseOSThemes = (DefaultableBoolean) 2;
    this.progressBar.Location = new Point(64 /*0x40*/, 33);
    this.progressBar.Name = "progressBar";
    this.progressBar.Size = new Size(248, 10);
    this.progressBar.TabIndex = 1;
    this.progressBar.Text = "0%";
    this.progressBar.Style = ProgressBarStyle.Continuous;
    this.pbBook.Location = new Point(8, 8);
    this.pbBook.Name = "pbBook";
    this.pbBook.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.pbBook.TabIndex = 3;
    this.pbBook.TabStop = false;
    this.lblAction.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblAction.Location = new Point(64 /*0x40*/, 8);
    this.lblAction.Name = "lblAction";
    this.lblAction.Size = new Size(248, 24);
    this.lblAction.TabIndex = 4;
    this.lblAction.Text = "Initializing Report...";
    this.pnlBounce.Controls.Add((Control) this.Label1);
    this.pnlBounce.Controls.Add((Control) this.BouncingProgress1);
    this.pnlBounce.Location = new Point(56, 0);
    this.pnlBounce.Name = "pnlBounce";
    this.pnlBounce.Size = new Size(260, 48 /*0x30*/);
    this.pnlBounce.TabIndex = 5;
    this.pnlBounce.Visible = false;
    this.Label1.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(248, 24);
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Running...";
    this.BouncingProgress1.Border = BorderStyle.Fixed3D;
    this.BouncingProgress1.BorderColor = Color.DarkGray;
    this.BouncingProgress1.Bounce = false;
    this.BouncingProgress1.BounceColor = SystemColors.Highlight;
    this.BouncingProgress1.Location = new Point(8, 32 /*0x20*/);
    this.BouncingProgress1.Name = "BouncingProgress1";
    this.BouncingProgress1.Size = new Size(248, 10);
    this.BouncingProgress1.TabIndex = 0;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(322, 79);
    this.Controls.Add((Control) this.lblAction);
    this.Controls.Add((Control) this.pbBook);
    this.Controls.Add((Control) this.progressBar);
    this.Controls.Add((Control) this.btn);
    this.Controls.Add((Control) this.pnlBounce);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (frmThreadedReportGeneration);
    this.Text = "[GENERATING REPORT]";
    ((ISupportInitialize) this.btn).EndInit();
    ((ISupportInitialize) this.pbBook).EndInit();
    this.pnlBounce.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private virtual MGAReport _rpt
  {
    get => this.__rpt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MGAReport.IncreaseProgressbarEventEventHandler eventEventHandler1 = new MGAReport.IncreaseProgressbarEventEventHandler(this.IncreaseProgressBar);
      MGAReport.SetProgressbarMaximumEventEventHandler eventEventHandler2 = new MGAReport.SetProgressbarMaximumEventEventHandler(this.SetProgressBarMaximum);
      MGAReport.SetProgressbarStyleEventEventHandler eventEventHandler3 = new MGAReport.SetProgressbarStyleEventEventHandler(this.SetProgressBarStyle);
      MGAReport.SetStatusTextEventEventHandler eventEventHandler4 = new MGAReport.SetStatusTextEventEventHandler(this.SetProgressBarText);
      MGAReport.BouncingProgressEventEventHandler eventEventHandler5 = new MGAReport.BouncingProgressEventEventHandler(this._rpt_BouncingProgressEvent);
      MGAReport rpt1 = this.__rpt;
      if (rpt1 != null)
      {
        rpt1.IncreaseProgressbarEvent -= eventEventHandler1;
        rpt1.SetProgressbarMaximumEvent -= eventEventHandler2;
        rpt1.SetProgressbarStyleEvent -= eventEventHandler3;
        rpt1.SetStatusTextEvent -= eventEventHandler4;
        rpt1.BouncingProgressEvent -= eventEventHandler5;
      }
      this.__rpt = value;
      MGAReport rpt2 = this.__rpt;
      if (rpt2 == null)
        return;
      rpt2.IncreaseProgressbarEvent += eventEventHandler1;
      rpt2.SetProgressbarMaximumEvent += eventEventHandler2;
      rpt2.SetProgressbarStyleEvent += eventEventHandler3;
      rpt2.SetStatusTextEvent += eventEventHandler4;
      rpt2.BouncingProgressEvent += eventEventHandler5;
    }
  }

  public frmThreadedReportGeneration(Type rptType, string title)
  {
    this.Closing += new CancelEventHandler(this.frmThreadedReportGeneration_Closing);
    this.Load += new EventHandler(this.frmThreadedReportGeneration_Load);
    this._adHocReportGuid = Guid.Empty;
    this.InitializeComponent();
    this._rptType = rptType;
    this._title = title;
    this._rpt = (MGAReport) ObjectFactory.Instance.CreateObjectEX(this._rptType);
    this.pbBook.Image = ImageCache.Instance.ReportGeneration;
    this.Text = this._title;
  }

  public frmThreadedReportGeneration(Type rptType, ArrayList @params, string title)
    : this(rptType, @params, title, Guid.Empty)
  {
  }

  public frmThreadedReportGeneration(
    Type rptType,
    ArrayList @params,
    string title,
    Guid adhocReportGuid)
  {
    this.Closing += new CancelEventHandler(this.frmThreadedReportGeneration_Closing);
    this.Load += new EventHandler(this.frmThreadedReportGeneration_Load);
    this._adHocReportGuid = Guid.Empty;
    if (@params == null)
      throw new ArgumentNullException(nameof (@params));
    this.InitializeComponent();
    this._rptType = rptType;
    this._title = title;
    this._adHocReportGuid = adhocReportGuid;
    this._rpt = (MGAReport) ObjectFactory.Instance.CreateObjectEX(this._rptType, @params.ToArray());
    this.pbBook.Image = ImageCache.Instance.ReportGeneration;
    this.Text = this._title;
  }

  public MGAReport Report => this._rpt;

  public void ShowBouncingProgress(bool show) => this.showBouncingProgressBar(show);

  private void StartReportProcessing()
  {
    this._rpt.CurrentUserGuid = CurrentUser.Instance.UserGUID;
    this._rpt.Document.Printer.PrinterName = string.Empty;
    try
    {
      if (this._adHocReportGuid == Guid.Empty)
        ReportingTraceListener.RunCannedReportAndLogSqlDetails((SectionReport) this._rpt);
      else
        ReportingTraceListener.RunAdHocReportAndLogSqlDetails((SectionReport) this._rpt, this._title, this._adHocReportGuid);
    }
    catch (ThreadAbortException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (EvaluateException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ErrorHandling.ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ErrorHandling.ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ProjectData.ClearProjectError();
    }
    if (this.IsDisposed || !this.IsHandleCreated)
      return;
    if (!this._rpt.HasRecords)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new frmThreadedReportGeneration.delNoRecords(this.NoRecords));
      else
        this.NoRecords();
    }
    else if (this.InvokeRequired)
      this.Invoke((Delegate) new frmThreadedReportGeneration.ReportDone(this.setReportDone));
    else
      this.setReportDone();
  }

  private void showReport()
  {
    this._rpt.Document.Name = this.Text;
    ReportFactory.Instance.ShowReport((SectionReport) this._rpt);
  }

  private void setReportDone()
  {
    this.lblAction.Text = "Generating View...";
    this.progressBar.Value = this.progressBar.Maximum;
    this.setPercentageComplete();
    ((ControlBase) this.btn).Text = "Show Report";
    this.lblAction.Text = "Report Complete!";
    this.pnlBounce.Visible = false;
    this.pbBook.Image = ImageCache.Instance.ReportDone;
    this._reportIsComplete = true;
    this.WindowState = FormWindowState.Normal;
  }

  private static void ErrorHandler(Exception ex) => MGASystems.Common.ErrorHandling.ErrorHandler.HandleError(ex);

  private void showBouncingProgressBar(bool show)
  {
    this.pnlBounce.Visible = show;
    if (show)
    {
      this.BouncingProgress1.Bounce = true;
      this.pnlBounce.BringToFront();
    }
    else
    {
      this.BouncingProgress1.Bounce = false;
      this.pnlBounce.SendToBack();
    }
  }

  private void changeActionLabel(string message) => this.lblAction.Text = message;

  private void NoRecords()
  {
    this.Hide();
    int num = (int) MessageBox.Show($"No results were found for {this.Text}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private string getActionLabelText() => this.lblAction.Text;

  private void setPercentageComplete()
  {
    this.progressBar.Text = ((double) this.progressBar.Value / (double) this.progressBar.Maximum).ToString("%##0");
  }

  private int getProgressBarMaximum() => this.progressBar.Maximum;

  private int getProgressBarValue() => this.progressBar.Value;

  private void closeForm()
  {
    this._exitWithOutMessage = true;
    this.Close();
  }

  private void setProgressMaximum(int max) => this.progressBar.Maximum = max;

  private void increaseProgressBarValue(int amt)
  {
    if (this.progressBar.Value + amt <= this.progressBar.Maximum)
    {
      ProgressBar progressBar;
      int num = (progressBar = this.progressBar).Value + amt;
      progressBar.Value = num;
    }
    else
      this.progressBar.Value = this.progressBar.Maximum;
  }

  private void setProgressbarStyleValue(ProgressBarStyle style) => this.progressBar.Style = style;

  private void btn_Click(object sender, EventArgs e)
  {
    if (this._reportIsComplete)
    {
      Cursor.Current = Cursors.WaitCursor;
      this.showReport();
      Cursor.Current = Cursors.Default;
    }
    else
    {
      this._exitWithOutMessage = false;
      this.Close();
    }
  }

  private void frmThreadedReportGeneration_Closing(object sender, CancelEventArgs e)
  {
    if (!this._exitWithOutMessage && !this._reportIsComplete)
    {
      if (MessageBox.Show($"This will cancel the generation of '{this.Text}'.  Are you sure you want to do this?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
      {
        e.Cancel = true;
      }
      else
      {
        this.Visible = false;
        try
        {
          if (this._rpt != null)
            this._rpt.Dispose();
          this._reportThread.Abort();
        }
        catch (EvaluateException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      if (!this._exitWithOutMessage)
        return;
      this._rpt.Dispose();
      this._reportThread.Abort();
    }
  }

  private void IncreaseProgressBar(int Value)
  {
    if (this.IsDisposed || !this.IsHandleCreated)
      return;
    if (this.InvokeRequired)
    {
      this.BetterInvoke((Delegate) new frmThreadedReportGeneration.delIncreaseProgressBarValue(this.increaseProgressBarValue), (object) Value);
      this.BetterInvoke((Delegate) new frmThreadedReportGeneration.delSetPercentageComplete(this.setPercentageComplete));
    }
    else
    {
      this.increaseProgressBarValue(Value);
      this.setPercentageComplete();
    }
  }

  private void SetProgressBarMaximum(int Max)
  {
    if (this.IsDisposed || !this.IsHandleCreated)
      return;
    if (this.InvokeRequired)
      this.BetterInvoke((Delegate) new frmThreadedReportGeneration.delSetProgressMaximum(this.setProgressMaximum), (object) Max);
    else
      this.setProgressMaximum(Max);
  }

  private void SetProgressBarStyle(ProgressBarStyle Style)
  {
    if (this.IsDisposed || !this.IsHandleCreated)
      return;
    if (this.InvokeRequired)
      this.BetterInvoke((Delegate) new frmThreadedReportGeneration.delSetProgressbarStyleValue(this.setProgressbarStyleValue), (object) Style);
    else
      this.setProgressbarStyleValue(Style);
  }

  private void SetProgressBarText(string Text)
  {
    if (this.IsDisposed || !this.IsHandleCreated)
      return;
    if (this.InvokeRequired)
      this.BetterInvoke((Delegate) new frmThreadedReportGeneration.delChangeActionLabel(this.changeActionLabel), (object) Text);
    else
      this.changeActionLabel(Text);
  }

  private void _rpt_BouncingProgressEvent(bool Show)
  {
    if (this.IsDisposed || !this.IsHandleCreated)
      return;
    if (this.InvokeRequired)
      this.BetterInvoke((Delegate) new frmThreadedReportGeneration.delShowBouncingProgressBarHandler(this.showBouncingProgressBar), (object) Show);
    else
      this.showBouncingProgressBar(Show);
  }

  private void frmThreadedReportGeneration_Load(object sender, EventArgs e)
  {
    this._reportThread = new Thread(new ThreadStart(this.StartReportProcessing));
    this._reportThread.IsBackground = true;
    this._reportThread.Name = "Threaded Report Generation";
    this._reportThread.Start();
  }

  private delegate void ReportDone();

  private delegate void delErrorHandler(Exception ex);

  private delegate void delShowBouncingProgressBarHandler(bool show);

  private delegate void delChangeActionLabel(string message);

  private delegate void delNoRecords();

  private delegate string delGetActionLabelText();

  private delegate void delSetPercentageComplete();

  private delegate int delGetProgressBarMaximum();

  private delegate int delGetProgressBarValue();

  private delegate void delCloseForm();

  private delegate void delSetProgressMaximum(int amountToIncrease);

  private delegate void delIncreaseProgressBarValue(int amountToIncrease);

  private delegate void delSetProgressbarStyleValue(ProgressBarStyle style);
}
