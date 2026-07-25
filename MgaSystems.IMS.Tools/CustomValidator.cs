// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.CustomValidator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (System.Web.UI.WebControls.CustomValidator))]
[DefaultEvent("CustomValidate")]
public sealed class CustomValidator : ValidatorBase
{
  public event CustomValidator.ValidateEventHandler CustomValidate;

  protected internal override Type[] GetAcceptableFieldToValidateTypes()
  {
    return new Type[8]
    {
      typeof (string),
      typeof (int),
      typeof (double),
      typeof (DateTime),
      typeof (Decimal),
      typeof (object),
      typeof (long),
      typeof (float)
    };
  }

  public CustomValidator(IContainer container)
    : base(container)
  {
  }

  public CustomValidator()
  {
  }

  [SuppressMessage("Microsoft.Design", "CA1047:DoNotDeclareProtectedMembersInSealedTypes")]
  protected void OnCustomValidate(ValidateEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    CustomValidator.ValidateEventHandler customValidateEvent = this.CustomValidateEvent;
    if (customValidateEvent == null)
      return;
    customValidateEvent((object) this, e);
  }

  protected override bool EvaluateIsValid()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.ValueToTest);
    bool isValid;
    if (objectValue != null)
    {
      ValidateEventArgs e = new ValidateEventArgs(RuntimeHelpers.GetObjectValue(objectValue));
      this.OnCustomValidate(e);
      isValid = e.IsValid;
    }
    return isValid;
  }

  [SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")]
  public delegate void ValidateEventHandler(object sender, ValidateEventArgs e);
}
