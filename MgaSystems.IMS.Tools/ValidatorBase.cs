// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ValidatorBase
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Web.UI;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[Designer(typeof (ValidatorBaseDesigner))]
public abstract class ValidatorBase : Component, IValidator, ISupportInitialize
{
  private IContainer components;
  private ErrorProvider _errorProvider;
  private string _errorMessage;
  private bool _isValid;
  private System.Windows.Forms.Control _controlToValidate;
  private string _fieldToValidate;
  private ValidationStyle _validationStyle;
  private bool _enabled;
  private bool _isDisposed;

  protected ValidatorBase(IContainer container)
    : this()
  {
    if (container == null)
      throw new ArgumentNullException(nameof (container));
    container.Add((IComponent) this);
  }

  protected ValidatorBase()
  {
    this._errorMessage = "Value is not valid";
    this._validationStyle = ValidationStyle.ValidateOnValidate;
    this._enabled = true;
    this.InitializeComponent();
  }

  [DebuggerStepThrough]
  private void InitializeComponent() => this.components = (IContainer) new System.ComponentModel.Container();

  public event CancelEventHandler Validating;

  public event EventHandler Validated;

  public event EventHandler ValidChanged;

  public event CancelEventHandler ValidChanging;

  protected ErrorProvider ErrorProvider
  {
    get
    {
      if (this._errorProvider == null)
        this._errorProvider = new ErrorProvider();
      return this._errorProvider;
    }
  }

  protected ToolTip ToolTip => (ToolTip) null;

  private void ControlToValidate_Validated(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Validate();
  }

  protected virtual void ControlToValidateChanged(System.Windows.Forms.Control oldControl)
  {
    if (oldControl != null)
      oldControl.Validated -= new EventHandler(this.ControlToValidate_Validated);
    if (this.ValidationStyle != ValidationStyle.ValidateOnValidate || this.ControlToValidate == null)
      return;
    this.ControlToValidate.Validated += new EventHandler(this.ControlToValidate_Validated);
  }

  [Category("Behavior")]
  [Description("Control to validate")]
  [RefreshProperties(RefreshProperties.All)]
  public System.Windows.Forms.Control ControlToValidate
  {
    get => this._controlToValidate;
    set
    {
      if (this._controlToValidate == value)
        return;
      System.Windows.Forms.Control controlToValidate = this._controlToValidate;
      this._controlToValidate = value;
      this.ControlToValidateChanged(controlToValidate);
    }
  }

  private void ResetControlToValidate() => this._controlToValidate = (System.Windows.Forms.Control) null;

  private bool ShouldSerializeControlToValidate() => this._controlToValidate != null;

  [Category("Appearance")]
  [Description("Message to display when control is not valid")]
  [DefaultValue("Value is not valid")]
  public virtual string ErrorMessage
  {
    get => this._errorMessage;
    set => this._errorMessage = value;
  }

  public bool Enabled
  {
    get => this._enabled;
    set
    {
      this._enabled = value;
      if (!value)
        return;
      this.IsValid = true;
    }
  }

  protected bool IsDisposed => this._isDisposed;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public bool IsValid
  {
    get => this._isValid;
    set
    {
      this._isValid = value;
      CancelEventArgs e = new CancelEventArgs(false);
      this.OnValidChanging(e);
      if (!e.Cancel)
        this.InternalOnValidChanged();
      this.OnValidChanged(EventArgs.Empty);
    }
  }

  public void Validate()
  {
    CancelEventArgs e = new CancelEventArgs(false);
    this.OnValidating(e);
    if (!e.Cancel)
      this.IsValid = !this.Enabled || !this.ControlToValidate.Enabled || this.EvaluateIsValid();
    this.OnValidated(EventArgs.Empty);
  }

  protected abstract bool EvaluateIsValid();

  [Category("Behavior")]
  [Description("Determines how the control validates itself")]
  [DefaultValue(typeof (ValidationStyle), "ValidateOnValidate")]
  public ValidationStyle ValidationStyle
  {
    get => this._validationStyle;
    set => this._validationStyle = value;
  }

  protected object ValueToTest
  {
    get
    {
      if (this.ControlToValidate == null)
        throw new ValidationException("ControlToValidate cannot be null");
      return ((this.FieldToValidate != null && Operators.CompareString(this.FieldToValidate, string.Empty, false) != 0 ? this.ControlToValidate.GetType().GetProperty(this.FieldToValidate) : throw new ValidationException("FieldToValidate cannot be null")) ?? throw new ValidationException(string.Format("{0} specified by the property FieldToValidate is not a valid property on {1} specified by ControlToValidate{2}Please choose a valid FieldToValidate from {1}", (object) this.FieldToValidate, (object) this.ControlToValidate.Name, (object) "\r\n"))).GetValue((object) this.ControlToValidate, (object[]) null);
    }
  }

  [Category("Behavior")]
  [Description("Field of the control to validate against")]
  [Editor(typeof (FieldToValidateUITypeEditor), typeof (UITypeEditor))]
  [DefaultValue("")]
  public string FieldToValidate
  {
    get => this._fieldToValidate;
    set
    {
      if ((object) this._fieldToValidate != (object) value)
        this._fieldToValidate = value;
      if (this._controlToValidate == null || this._fieldToValidate == null)
        return;
      this.ValidateTypeOfFieldToValidate();
    }
  }

  protected internal virtual Type[] GetAcceptableFieldToValidateTypes()
  {
    return new Type[7]
    {
      typeof (string),
      typeof (DateTime),
      typeof (int),
      typeof (long),
      typeof (float),
      typeof (double),
      typeof (Decimal)
    };
  }

  private void ValidateTypeOfFieldToValidate()
  {
    if (this.ValueToTest != null)
    {
      Type[] fieldToValidateTypes = this.GetAcceptableFieldToValidateTypes();
      int index = 0;
      while (index < fieldToValidateTypes.Length)
      {
        if (fieldToValidateTypes[index].Equals(this.ValueToTest.GetType()))
          return;
        checked { ++index; }
      }
      throw new ValidationException($"{this.ValueToTest.GetType()} is not an acceptable type for this validator.");
    }
  }

  protected virtual void OnValidating(CancelEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler validatingEvent = this.ValidatingEvent;
    if (validatingEvent == null)
      return;
    validatingEvent((object) this, e);
  }

  protected virtual void OnValidated(EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler validatedEvent = this.ValidatedEvent;
    if (validatedEvent == null)
      return;
    validatedEvent((object) this, e);
  }

  protected void OnValidChanged(EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler validChangedEvent = this.ValidChangedEvent;
    if (validChangedEvent == null)
      return;
    validChangedEvent((object) this, e);
  }

  protected void OnValidChanging(CancelEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler validChangingEvent = this.ValidChangingEvent;
    if (validChangingEvent == null)
      return;
    validChangingEvent((object) this, e);
  }

  protected virtual void InternalOnValidChanged()
  {
    if (this.ControlToValidate == null || this.IsDisposed)
      return;
    if (this.IsValid)
    {
      this.ErrorProvider.SetError(this.ControlToValidate, string.Empty);
    }
    else
    {
      int length = this.ErrorMessage.Length;
      this.ErrorProvider.SetError(this.ControlToValidate, this.ErrorMessage);
    }
  }

  public virtual void BeginInit()
  {
  }

  public virtual void EndInit()
  {
  }

  protected override void Dispose(bool disposing)
  {
    this._controlToValidate = (System.Windows.Forms.Control) null;
    this._isDisposed = true;
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public void ResetAllValidators()
  {
    ComponentCollection components = this.Site.Container.Components;
    try
    {
      foreach (Component component in (ReadOnlyCollectionBase) components)
      {
        if (component is ValidatorBase validatorBase)
          validatorBase.IsValid = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public bool IsAllValidatorsValid
  {
    get
    {
      ComponentCollection components = this.Site.Container.Components;
      bool allValidatorsValid = true;
      try
      {
        foreach (Component component in (ReadOnlyCollectionBase) components)
        {
          if (component is ValidatorBase validatorBase)
          {
            validatorBase.Validate();
            if (allValidatorsValid)
              allValidatorsValid = validatorBase.IsValid;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return allValidatorsValid;
    }
  }

  public void ToggleAllValidators()
  {
    ComponentCollection components = this.Site.Container.Components;
    try
    {
      foreach (Component component in (ReadOnlyCollectionBase) components)
      {
        if (component is ValidatorBase validatorBase)
          validatorBase.IsValid = !validatorBase.IsValid;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
