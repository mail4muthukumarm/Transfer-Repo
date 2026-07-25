// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormClaimsManagement
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.IMS.Claims;
using MgaSystems.Ims.Fortegra.Overrides.Claims.Claims_Administration;
using System.ComponentModel;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormClaimsManagement))]
public class Fortegra_FormClaimsManagement : FormClaimsManagement
{
  private IContainer components;

  public Fortegra_FormClaimsManagement() => this.InitializeComponent();

  protected override void LoadClaimsAdministrationPortal(
    ClaimsAdministrationPortal.AdministrationPortalType portalType)
  {
    if (this._claimsAdminPortal == null)
      this._claimsAdminPortal = (ClaimsAdministrationPortal) new Fortegra_ClaimsAdministrationPortal();
    base.LoadClaimsAdministrationPortal(portalType);
    if (!(this._claimsAdminPortal is Fortegra_ClaimsAdministrationPortal claimsAdminPortal))
      return;
    claimsAdminPortal.FormatReservePaymentFlagsPanel();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Text = nameof (Fortegra_FormClaimsManagement);
  }
}
