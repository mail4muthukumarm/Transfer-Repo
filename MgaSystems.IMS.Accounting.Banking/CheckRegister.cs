// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.CheckRegister
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.Tools;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class CheckRegister : UserControl
{
  private IContainer components;
  private int _glCompanyId;

  public CheckRegister() => this.InitializeComponent();

  public CheckRegister(int glCompanyId)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.acrCheckRegister.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.acrCheckRegister.SearchButtonImage = ImageCache.Instance.Search;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("acrCheckRegister")]
  internal virtual AcctCheckRegister acrCheckRegister { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.acrCheckRegister = new AcctCheckRegister();
    this.SuspendLayout();
    this.acrCheckRegister.BankGLAcct = 0;
    this.acrCheckRegister.ConnectionString = (string) null;
    this.acrCheckRegister.Dock = DockStyle.Fill;
    this.acrCheckRegister.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.acrCheckRegister.Location = new Point(0, 0);
    this.acrCheckRegister.Name = "acrCheckRegister";
    this.acrCheckRegister.Size = new Size(744, 584);
    this.acrCheckRegister.TabIndex = 1;
    this.BackColor = Color.WhiteSmoke;
    this.Controls.Add((Control) this.acrCheckRegister);
    this.Name = nameof (CheckRegister);
    this.Size = new Size(744, 584);
    this.ResumeLayout(false);
  }
}
