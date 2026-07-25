// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ValidatorBaseDesigner
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class ValidatorBaseDesigner : ComponentDesigner
{
  private DesignerVerbCollection _verbs;

  public override DesignerVerbCollection Verbs
  {
    get
    {
      if (this._verbs == null)
      {
        this._verbs = new DesignerVerbCollection();
        this._verbs.Add(new DesignerVerb("Validate", new EventHandler(this.Validate_Handler)));
        this._verbs.Add(new DesignerVerb("Reset", new EventHandler(this.Reset_Handler)));
        this._verbs.Add(new DesignerVerb("Toggle Valid State", new EventHandler(this.Invalid_Handler)));
        this._verbs.Add(new DesignerVerb("Reset All Validators", new EventHandler(this.ResetAll_Handler)));
        this._verbs.Add(new DesignerVerb("Toggle All Validators", new EventHandler(this.ToggleAll_Handler)));
      }
      return this._verbs;
    }
  }

  private void Validate_Handler(object sender, EventArgs e)
  {
    ((ValidatorBase) this.Component).Validate();
    if (((ValidatorBase) this.Component).IsValid)
    {
      int num1 = (int) MessageBox.Show("Value is valid", "Validation check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      int num2 = (int) MessageBox.Show(((ValidatorBase) this.Component).ErrorMessage, "Validation check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void Reset_Handler(object sender, EventArgs e)
  {
    ((ValidatorBase) this.Component).IsValid = true;
  }

  private void Invalid_Handler(object sender, EventArgs e)
  {
    ((ValidatorBase) this.Component).IsValid = !((ValidatorBase) this.Component).IsValid;
  }

  private void ToggleAll_Handler(object sender, EventArgs e)
  {
    ((ValidatorBase) this.Component).ToggleAllValidators();
  }

  private void ResetAll_Handler(object sender, EventArgs e)
  {
    ((ValidatorBase) this.Component).ResetAllValidators();
  }
}
