// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCheckRegister
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{D5D93FFA-AED6-4175-B1F7-09984E2205BE}", "View Check Register Rights", "Secures the bank management check register. Only authorized users should have access to this resource.", "Accounting")]
public sealed class frmCheckRegister : Form, IMessageListener
{
  private IContainer components;

  public frmCheckRegister()
  {
    this.Load += new EventHandler(this.frmCheckRegister_Load);
    this.Activated += new EventHandler(this.frmCheckRegister_Activated);
    this.InitializeComponent();
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
    this.acrCheckRegister.ConnectionString = (string) null;
    this.acrCheckRegister.Dock = DockStyle.Fill;
    this.acrCheckRegister.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.acrCheckRegister.Location = new Point(0, 22);
    this.acrCheckRegister.Name = "acrCheckRegister";
    this.acrCheckRegister.Size = new Size(744, 585);
    this.acrCheckRegister.TabIndex = 0;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(744, 607);
    this.Controls.Add((Control) this.acrCheckRegister);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Location = new Point(750, 606);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.MinimumSize = new Size(750, 606);
    this.Name = nameof (frmCheckRegister);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Check Register";
    this.Controls.SetChildIndex((Control) this.acrCheckRegister, 0);
    this.ResumeLayout(false);
  }

  private void frmCheckRegister_Load(object sender, EventArgs e)
  {
  }

  private void frmCheckRegister_Activated(object sender, EventArgs e)
  {
    this.acrCheckRegister.RefreshData();
  }

  public void OnMessageReceived(Guid MessageGUID, object context)
  {
    if (!MessageGUID.Equals(MGASystems.IMS.Accounting.Utilities.BroadcastMessages.CloseAccounting) && !MessageGUID.Equals(MGASystems.IMS.Accounting.Utilities.BroadcastMessages.CloseAllForms))
      return;
    this.Close();
  }
}
