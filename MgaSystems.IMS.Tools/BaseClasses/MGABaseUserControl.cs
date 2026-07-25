// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.BaseClasses.MGABaseUserControl
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools.BaseClasses;

public class MGABaseUserControl : UserControl
{
  private IContainer components;

  public MGABaseUserControl() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.BackColor = Color.White;
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (MGABaseUserControl);
  }
}
