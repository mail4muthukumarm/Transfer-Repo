// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.DBSaveUI.DBSaveUI
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools.DBSaveUI;

[DefaultEvent("ClickedButton")]
[DefaultProperty("UIStyle")]
[ToolboxBitmap(typeof (Button))]
public class DBSaveUI : UserControl
{
  private IContainer components;
  private ToolTip ToolTip;
  private bool _freezeEvents;
  private UIState _uiState;
  private EditStyle _editStyle;
  private bool _initializedRowCount;
  private string _toolTipNew;
  private string _toolTipSave;
  private string _toolTipCancel;
  private string _toolTipDelete;
  private string _toolTipEdit;
  private bool _autoQueryRowCountOnLoad;

  public DBSaveUI()
  {
    this._freezeEvents = true;
    this._uiState = UIState.NoRecordsNotEditing;
    this._editStyle = EditStyle.SaveAlways;
    this._toolTipNew = "New";
    this._toolTipSave = "Save";
    this._toolTipCancel = "Cancel";
    this._toolTipDelete = "Delete";
    this._toolTipEdit = "Edit";
    this._autoQueryRowCountOnLoad = true;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNew
  {
    get => this._btnNew;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNew_Click);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.btnNew_MouseUp);
      MGAButton btnNew1 = this._btnNew;
      if (btnNew1 != null)
      {
        ((Control) btnNew1).Click -= eventHandler;
        ((Control) btnNew1).MouseUp -= mouseEventHandler;
      }
      this._btnNew = value;
      MGAButton btnNew2 = this._btnNew;
      if (btnNew2 == null)
        return;
      ((Control) btnNew2).Click += eventHandler;
      ((Control) btnNew2).MouseUp += mouseEventHandler;
    }
  }

  private virtual MGAButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      MGAButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      MGAButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.btnSave = new MGAButton();
    this.btnNew = new MGAButton();
    this.btnDelete = new MGAButton();
    this.ToolTip = new ToolTip(this.components);
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(21, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(40, 8);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(24, 24);
    ((Control) this.btnSave).TabIndex = 0;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNew).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnNew).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNew).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNew).Location = new Point(8, 8);
    ((Control) this.btnNew).Name = "btnNew";
    ((Control) this.btnNew).Size = new Size(24, 24);
    ((Control) this.btnNew).TabIndex = 1;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnDelete).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnDelete).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnDelete).Location = new Point(72, 8);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(24, 24);
    ((Control) this.btnDelete).TabIndex = 2;
    this.Controls.Add((Control) this.btnNew);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnDelete);
    this.Name = nameof (DBSaveUI);
    this.Size = new Size(112 /*0x70*/, 40);
    this.ResumeLayout(false);
  }

  public event CancelEventHandler ClickingNew;

  public event EventHandler ClickedNew;

  public event CancelEventHandler ClickingSave;

  public event EventHandler ClickedSave;

  public event CancelEventHandler ClickingDelete;

  public event EventHandler ClickedDelete;

  public event CancelEventHandler ClickingCancel;

  public event EventHandler ClickedCancel;

  public event CancelEventHandler ClickingEdit;

  public event EventHandler ClickedEdit;

  public event EventHandler UIStateChanged;

  public event EventHandler EditStyleChanged;

  public event EventHandler ClickedButton;

  public event QueryRowCountHandler QueryRowCount;

  public bool FreezeEvents
  {
    get => this._freezeEvents;
    set => this._freezeEvents = value;
  }

  public void PerformAction(DBSaveUIAction action)
  {
    switch (action)
    {
      case DBSaveUIAction.ClickNewButton:
        if (this.UIState == UIState.Editing)
          throw new ApplicationException("The DBSaveUI control cannot be in Edit mode when attempting to perform the ClickNewButton Action");
        this.btnNew_Click((object) this, EventArgs.Empty);
        break;
      case DBSaveUIAction.ClickSaveButton:
        if (this.UIState != UIState.Editing)
          throw new ApplicationException("The DBSaveUI control must be in Edit mode in order to perform the ClickSaveButton Action");
        this.btnSave_Click((object) this, EventArgs.Empty);
        break;
      case DBSaveUIAction.ClickDeleteButton:
        if (this.UIState == UIState.Editing)
          throw new ApplicationException("The DBSaveUI control cannot be in Edit mode when attempting to perform the ClickDeleteButton Action");
        this.btnDelete_Click((object) this, EventArgs.Empty);
        break;
      case DBSaveUIAction.ClickEditButton:
        if (this.UIState == UIState.Editing)
          throw new ApplicationException("The DBSaveUI control cannot be in Edit mode when attempting to perform the ClickEditButton Action");
        this.btnSave_Click((object) this, EventArgs.Empty);
        break;
      case DBSaveUIAction.ClickCancelButton:
        if (this.UIState != UIState.Editing)
          throw new ApplicationException("The DBSaveUI control must be in Edit mode when attempting to perform the ClickCancelButton Action");
        this.btnDelete_Click((object) this, EventArgs.Empty);
        break;
    }
  }

  public void ResetUI() => this.SetUIState();

  [DefaultValue(typeof (UIState), "NoRecordsNotEditing")]
  [Category("Appearance")]
  [Description("The UIState Gets/Sets the current state of the control.")]
  public UIState UIState
  {
    get => this._uiState;
    set
    {
      if (value == this._uiState)
        return;
      this._uiState = value;
      this.SetImages();
      this.OnUIStateChanged((object) this, EventArgs.Empty);
    }
  }

  [DefaultValue(typeof (EditStyle), "SaveAlways")]
  [Category("Appearance")]
  [Description("The EditStyle Gets/Sets whether or not the edit button will show when not editing. When the edit button does display you will get Edit* events.")]
  public EditStyle EditStyle
  {
    get => this._editStyle;
    set
    {
      if (value == this._editStyle)
        return;
      this._editStyle = value;
      this.SetImages();
      this.OnEditStyleChanged((object) this, EventArgs.Empty);
    }
  }

  [DefaultValue("New")]
  [Category("Appearance")]
  [Description("Gets/Sets the tooltip on the new button")]
  public string ToolTipNew
  {
    get => this._toolTipNew;
    set
    {
      if (Operators.CompareString(value, this._toolTipNew, false) == 0)
        return;
      this._toolTipNew = value;
    }
  }

  [DefaultValue("Save")]
  [Category("Appearance")]
  [Description("Gets/Sets the tooltip on the save button")]
  public string ToolTipSave
  {
    get => this._toolTipSave;
    set
    {
      if (Operators.CompareString(value, this._toolTipSave, false) == 0)
        return;
      this._toolTipSave = value;
    }
  }

  [DefaultValue("Cancel")]
  [Category("Appearance")]
  [Description("Gets/Sets the tooltip on the new button")]
  public string ToolTipCancel
  {
    get => this._toolTipCancel;
    set
    {
      if (Operators.CompareString(value, this._toolTipCancel, false) == 0)
        return;
      this._toolTipCancel = value;
    }
  }

  [DefaultValue("Delete")]
  [Category("Appearance")]
  [Description("Gets/Sets the tooltip on the new button")]
  public string ToolTipDelete
  {
    get => this._toolTipDelete;
    set
    {
      if (Operators.CompareString(value, this._toolTipDelete, false) == 0)
        return;
      this._toolTipDelete = value;
    }
  }

  [DefaultValue("Edit")]
  [Category("Appearance")]
  [Description("Gets/Sets the tooltip on the new button")]
  public string ToolTipEdit
  {
    get => this._toolTipEdit;
    set
    {
      if (Operators.CompareString(value, this._toolTipEdit, false) == 0)
        return;
      this._toolTipEdit = value;
    }
  }

  private void SetImages()
  {
    switch (this._uiState)
    {
      case UIState.NoRecordsNotEditing:
        ((ControlBase) this.btnNew).Appearance.Image = (object) ImageCache.Instance.NewImage;
        ((Control) this.btnNew).Enabled = true;
        this.ToolTip.SetToolTip((Control) this.btnNew, this.ToolTipNew);
        if (this.EditStyle == EditStyle.SaveAlways)
        {
          ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
          this.ToolTip.SetToolTip((Control) this.btnSave, this.ToolTipSave);
        }
        else
        {
          ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Edit;
          this.ToolTip.SetToolTip((Control) this.btnSave, this.ToolTipEdit);
        }
        ((Control) this.btnSave).Enabled = false;
        ((ControlBase) this.btnDelete).Appearance.Image = (object) ImageCache.Instance.Delete;
        ((Control) this.btnDelete).Enabled = false;
        this.ToolTip.SetToolTip((Control) this.btnDelete, this.ToolTipDelete);
        break;
      case UIState.HasRecordsNotEditing:
        ((ControlBase) this.btnNew).Appearance.Image = (object) ImageCache.Instance.NewImage;
        ((Control) this.btnNew).Enabled = true;
        if (this.EditStyle == EditStyle.SaveAlways)
        {
          ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
          this.ToolTip.SetToolTip((Control) this.btnSave, this.ToolTipSave);
        }
        else
        {
          ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Edit;
          this.ToolTip.SetToolTip((Control) this.btnSave, this.ToolTipEdit);
        }
        ((Control) this.btnSave).Enabled = true;
        ((ControlBase) this.btnDelete).Appearance.Image = (object) ImageCache.Instance.Delete;
        ((Control) this.btnDelete).Enabled = true;
        this.ToolTip.SetToolTip((Control) this.btnDelete, this.ToolTipDelete);
        break;
      case UIState.Editing:
        ((ControlBase) this.btnNew).Appearance.Image = (object) ImageCache.Instance.NewImage;
        ((Control) this.btnNew).Enabled = false;
        ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
        ((Control) this.btnSave).Enabled = true;
        this.ToolTip.SetToolTip((Control) this.btnSave, this.ToolTipSave);
        ((ControlBase) this.btnDelete).Appearance.Image = (object) ImageCache.Instance.Undo;
        ((Control) this.btnDelete).Enabled = true;
        this.ToolTip.SetToolTip((Control) this.btnDelete, this.ToolTipCancel);
        break;
    }
  }

  protected override void OnLoad(EventArgs e)
  {
    base.OnLoad(e);
    this.SetImages();
    this.OnSizeChanged(EventArgs.Empty);
  }

  private void btnNew_Click(object sender, EventArgs e)
  {
    CancelEventArgs e1 = new CancelEventArgs();
    this.OnClickingNew((object) this, e1);
    if (e1.Cancel)
      return;
    this.UIState = UIState.Editing;
    this.OnClickedNew((object) this, EventArgs.Empty);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    CancelEventArgs e1 = new CancelEventArgs();
    if (this.EditStyle == EditStyle.SaveAlways || this.UIState == UIState.Editing)
      this.OnClickingSave((object) this, e1);
    else
      this.OnClickingEdit((object) this, e1);
    if (e1.Cancel)
      return;
    if (this.EditStyle == EditStyle.SaveAlways || this.UIState == UIState.Editing)
    {
      this.SetUIState();
      this.OnClickedSave((object) this, EventArgs.Empty);
      this.SetUIState();
    }
    else
    {
      this.UIState = UIState.Editing;
      this.OnClickedEdit((object) this, EventArgs.Empty);
    }
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    CancelEventArgs e1 = new CancelEventArgs();
    bool flag = this._uiState == UIState.Editing;
    if (flag)
      this.OnClickingCancel((object) this, e1);
    else
      this.OnClickingDelete((object) this, e1);
    if (e1.Cancel)
      return;
    this.SetUIState();
    if (flag)
      this.OnClickedCancel((object) this, EventArgs.Empty);
    else
      this.OnClickedDelete((object) this, EventArgs.Empty);
  }

  protected virtual void OnClickingNew(object sender, CancelEventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler clickingNewEvent = this.ClickingNewEvent;
    if (clickingNewEvent == null)
      return;
    clickingNewEvent((object) this, e);
  }

  protected virtual void OnClickedNew(object sender, EventArgs e)
  {
    if (!this._freezeEvents)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler clickedNewEvent = this.ClickedNewEvent;
      if (clickedNewEvent != null)
        clickedNewEvent((object) this, e);
    }
    this.OnClickedButton((object) this, e);
  }

  protected virtual void OnClickingSave(object sender, CancelEventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler clickingSaveEvent = this.ClickingSaveEvent;
    if (clickingSaveEvent == null)
      return;
    clickingSaveEvent((object) this, e);
  }

  protected virtual void OnClickedSave(object sender, EventArgs e)
  {
    if (!this._freezeEvents)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler clickedSaveEvent = this.ClickedSaveEvent;
      if (clickedSaveEvent != null)
        clickedSaveEvent((object) this, e);
    }
    this.OnClickedButton((object) this, e);
  }

  protected virtual void OnClickingCancel(object sender, CancelEventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler clickingCancelEvent = this.ClickingCancelEvent;
    if (clickingCancelEvent == null)
      return;
    clickingCancelEvent((object) this, e);
  }

  protected virtual void OnClickedCancel(object sender, EventArgs e)
  {
    if (!this._freezeEvents)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler clickedCancelEvent = this.ClickedCancelEvent;
      if (clickedCancelEvent != null)
        clickedCancelEvent((object) this, e);
    }
    this.OnClickedButton((object) this, e);
  }

  protected virtual void OnClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler clickingDeleteEvent = this.ClickingDeleteEvent;
    if (clickingDeleteEvent == null)
      return;
    clickingDeleteEvent((object) this, e);
  }

  protected virtual void OnClickedDelete(object sender, EventArgs e)
  {
    if (!this._freezeEvents)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler clickedDeleteEvent = this.ClickedDeleteEvent;
      if (clickedDeleteEvent != null)
        clickedDeleteEvent((object) this, e);
    }
    this.OnClickedButton((object) this, e);
  }

  protected virtual void OnClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler clickingEditEvent = this.ClickingEditEvent;
    if (clickingEditEvent == null)
      return;
    clickingEditEvent((object) this, e);
  }

  protected virtual void OnClickedEdit(object sender, EventArgs e)
  {
    if (!this._freezeEvents)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler clickedEditEvent = this.ClickedEditEvent;
      if (clickedEditEvent != null)
        clickedEditEvent((object) this, e);
    }
    this.OnClickedButton((object) this, e);
  }

  protected virtual void OnUIStateChanged(object sender, EventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    EventHandler stateChangedEvent = this.UIStateChangedEvent;
    if (stateChangedEvent == null)
      return;
    stateChangedEvent((object) this, e);
  }

  protected virtual void OnEditStyleChanged(object sender, EventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    EventHandler styleChangedEvent = this.EditStyleChangedEvent;
    if (styleChangedEvent == null)
      return;
    styleChangedEvent((object) this, e);
  }

  protected virtual void OnClickedButton(object sender, EventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    EventHandler clickedButtonEvent = this.ClickedButtonEvent;
    if (clickedButtonEvent == null)
      return;
    clickedButtonEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnQueryRowCount(object sender, QueryRowCountEventArgs e)
  {
    if (this._freezeEvents)
      return;
    // ISSUE: reference to a compiler-generated field
    QueryRowCountHandler queryRowCountEvent = this.QueryRowCountEvent;
    if (queryRowCountEvent == null)
      return;
    queryRowCountEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected override Size DefaultSize => new Size(112 /*0x70*/, 40);

  private void SetUIState()
  {
    QueryRowCountEventArgs e = new QueryRowCountEventArgs();
    e.RowCount = 1;
    this.OnQueryRowCount((object) this, e);
    if (e.InternalRowCount == 0)
      this.UIState = UIState.NoRecordsNotEditing;
    else
      this.UIState = UIState.HasRecordsNotEditing;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);
    if (this._freezeEvents)
      this._freezeEvents = false;
    if (!this._initializedRowCount)
    {
      this._initializedRowCount = true;
      if (this.AutoQueryRowCountOnLoad)
        this.SetUIState();
    }
    double a = (double) (this.Width - 4) / 3.0;
    int num = this.Controls.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      Control control = this.Controls[index];
      control.Width = (int) Math.Round(a);
      control.Left = (int) Math.Round((double) index * (2.0 + a));
      control.Top = 0;
      control.Height = this.Height;
    }
  }

  [DefaultValue(true)]
  public bool AutoQueryRowCountOnLoad
  {
    get => this._autoQueryRowCountOnLoad;
    set => this._autoQueryRowCountOnLoad = value;
  }

  private void btnNew_MouseUp(object sender, MouseEventArgs e)
  {
  }
}
