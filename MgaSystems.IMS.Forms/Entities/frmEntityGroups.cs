// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Entities.frmEntityGroups
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Entities;

[SecureResource("{D3284C4B-FEA4-4312-8FC9-5A630BC40676}", "Access User Groups / Entity Groups Screen", "Controls access to the User Group / Entity Group.", "Users")]
public class frmEntityGroups : Form
{
  public const string canViewEntityGroup = "{D3284C4B-FEA4-4312-8FC9-5A630BC40676}";
  private IContainer components;

  public frmEntityGroups()
  {
    this.Load += new EventHandler(this.frmEntityGroups_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(512 /*0x0200*/, 342);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmEntityGroups);
    this.Text = "User Groups / Cost Center Administration";
  }

  private void frmEntityGroups_Load(object sender, EventArgs e)
  {
    EntityGroups entityGroups = (EntityGroups) ObjectFactory.Instance.CreateObject(typeof (EntityGroups));
    this.Controls.Add((Control) entityGroups);
    entityGroups.Location = new Point(0, 0);
    entityGroups.Dock = DockStyle.Fill;
  }
}
