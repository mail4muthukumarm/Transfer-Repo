// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ToolbarForm`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;

public abstract class ToolbarForm<TController, TView, TModel> : FormBase
  where TController : class, ITopControlController, IMvcController
  where TView : class, IMvcView
  where TModel : class, IMvcModel
{
  private Thread _loadingThread;
  private IFormActionDurationStatisticsKeeper _formStatisticsKeeper;
  private LoadingPanelControl _loadingPanel;
  private readonly ToolbarEditControl cToolbarEdit = new ToolbarEditControl();

  private LoadingPanelControl LoadingPanel
  {
    get
    {
      if (this._loadingPanel == null)
      {
        this._loadingPanel = new LoadingPanelControl();
        this._loadingPanel.Location = new Point(0, 0);
        this._loadingPanel.Dock = DockStyle.Fill;
        this.Controls.Add((Control) this._loadingPanel);
      }
      return this._loadingPanel;
    }
  }

  protected TController Controller { get; private set; }

  protected TView View { get; private set; }

  protected TModel Model { get; private set; }

  protected virtual TController CreateController()
  {
    throw new ArgumentNullException("If a controller was not supplied in the constructor then CreateController() must be overriden to return one.");
  }

  protected virtual TView CreateView()
  {
    throw new ArgumentNullException("If a view was not supplied in the constructor then CreateView() must be overriden to return one.");
  }

  protected virtual TModel CreateModel()
  {
    throw new ArgumentNullException("If a model was not supplied in the constructor then CreateModel() must be overriden to return one.");
  }

  [Obsolete("Pass the model, view, controller into the constructor.")]
  protected ToolbarForm(TModel model, TController controller)
  {
    this.InitializeComponent();
    TController controller1 = controller;
    if ((object) controller1 == null)
      controller1 = this.CreateController() ?? throw new InvalidOperationException("CreateController must not return null.");
    this.Controller = controller1;
    this.View = this.CreateView() ?? throw new InvalidOperationException("CreateView must not return null.");
    TModel model1 = model;
    if ((object) model1 == null)
      model1 = this.CreateModel() ?? throw new ArgumentNullException(nameof (model));
    this.Model = model1;
  }

  protected ToolbarForm(TModel model = null, TView view = null, TController controller = null)
  {
    this.InitializeComponent();
    this.Model = model;
    this.View = view;
    this.Controller = controller;
    this._loadingThread = new Thread((ThreadStart) (() => this._formStatisticsKeeper.ExecuteAndTrackTime("Load", new Action(this.OnLoad))));
  }

  [Obsolete("Use ChildAfterLoad")]
  protected virtual void ChildLoad()
  {
  }

  protected virtual void ChildAfterLoad()
  {
  }

  protected void SetDisplayOptionsFromController()
  {
    IParentFormSettings parentFormSettings = this.Controller.ParentFormSettings;
    this.SuspendLayout();
    ((object) this.View as Control).SuspendLayout();
    this.ClientSize = new Size(parentFormSettings.Width, parentFormSettings.Height);
    this.FormBorderStyle = parentFormSettings.BorderStyle;
    this.MinimizeBox = parentFormSettings.Minimizeable;
    this.MaximizeBox = parentFormSettings.Maximizeable;
    this.Name = parentFormSettings.Name;
    this.Text = parentFormSettings.Name;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.cToolbarEdit);
    ((object) this.View as Control).ResumeLayout();
    this.ResumeLayout();
    this._formStatisticsKeeper = ObjectFactory.Instance.CreateObjectAs<IFormActionDurationStatisticsKeeper>((object) parentFormSettings.Name);
  }

  protected override bool ProcessCmdKey(ref Message message, Keys keys)
  {
    ShortcutAction[] shortcutActions = this.Controller.ParentFormSettings.ShortcutActions;
    int index = 0;
    while (index < shortcutActions.Length && !shortcutActions[index].ExecuteIfForThis(keys))
      ++index;
    return base.ProcessCmdKey(ref message, keys);
  }

  private void Form_SaveBase_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Model = this.Model ?? this.CreateModel();
    this.View = this.View ?? this.CreateView();
    this.Controller = this.Controller ?? this.CreateController();
    this.ChildBeforeLoad();
    this.cToolbarEdit.SetEditControl((IMvcView) this.View, (IMvcController) this.Controller, (IToolbarSettings) new ToolbarSettings(this.Controller.GetToolBarItems()));
    this.SetDisplayOptionsFromController();
    if (this._loadingThread.IsAlive)
      throw new InvalidOperationException("Cannot load while already loading.");
    this._loadingThread.Start();
  }

  protected virtual void ChildBeforeLoad()
  {
  }

  private void OnLoad()
  {
    if (this.Model is MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics.ILoadable model)
      model.Load();
    this.View.RequestClose += new Action<IMvcView, DialogResult>(this.OnViewRequestClose);
    this.cToolbarEdit.WireUpEditControl((IMvcModel) this.Model);
    this.Invoke((Delegate) (() =>
    {
      this.ChildLoad();
      this.ChildAfterLoad();
      this.FinishLoading();
      this.InitializeListeners();
    }));
  }

  protected virtual void InitializeListeners()
  {
  }

  private void OnViewRequestClose(IMvcView sender, DialogResult dialogResult)
  {
    this.DialogResult = dialogResult;
    this.Close();
  }

  private void SetLoading()
  {
    this.LoadingPanel.Visible = true;
    this.cToolbarEdit.Enabled = false;
  }

  private void FinishLoading()
  {
    this.LoadingPanel.Visible = false;
    this.cToolbarEdit.Enabled = true;
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.cToolbarEdit.BackColor = SystemColors.Control;
    this.cToolbarEdit.Dock = DockStyle.Fill;
    this.cToolbarEdit.Location = new Point(0, 0);
    this.cToolbarEdit.Name = "cToolbarEdit";
    this.cToolbarEdit.Size = new Size(604, 206);
    this.FormClosing += new FormClosingEventHandler(this.ToolbarForm_FormClosing);
    this.cToolbarEdit.TabIndex = 0;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.BackColor = SystemColors.Control;
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(500, 300);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MinimizeBox = true;
    this.MaximizeBox = true;
    this.Controls.Add((Control) this.cToolbarEdit);
    this.Name = "Failed to load form settings";
    this.Text = "Failed to load form settings";
    this.Load += new EventHandler(this.Form_SaveBase_Load);
    if (!this.DesignMode)
      this.SetLoading();
    this.ResumeLayout(false);
  }

  private void ToolbarForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this._loadingThread.IsAlive)
      this._loadingThread.Abort();
    this._loadingThread.Join();
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 33554432 /*0x02000000*/;
      return createParams;
    }
  }
}
