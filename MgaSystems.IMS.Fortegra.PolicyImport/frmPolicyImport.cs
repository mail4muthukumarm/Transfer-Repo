// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.frmPolicyImport
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MgaSystems.Ims.Fortegra.PolicyImport.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport;

public class frmPolicyImport : Form
{
  private IContainer components;
  private ElementHost elementHost1;
  private PolicyImportSummaryView policyImport1;

  public frmPolicyImport()
  {
    this.InitializeComponent();
    PolicyImportSummaryView importSummaryView = MgaMdiChild.Create<PolicyImportSummaryView>(Array.Empty<object>());
    ((FrameworkElement) importSummaryView).DataContext = (object) PolicyImportSummaryViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
    importSummaryView.Form.MdiParent = MDIControls.Instance.MDIParent;
    importSummaryView.Form.Show();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.elementHost1 = new ElementHost();
    this.policyImport1 = new PolicyImportSummaryView();
    this.SuspendLayout();
    this.elementHost1.Location = new Point(12, 12);
    this.elementHost1.Name = "elementHost1";
    this.elementHost1.Size = new Size(776, 426);
    this.elementHost1.TabIndex = 0;
    this.elementHost1.Text = "elementHost1";
    this.elementHost1.Child = (UIElement) this.policyImport1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 450);
    this.Controls.Add((Control) this.elementHost1);
    this.Name = nameof (frmPolicyImport);
    this.Text = nameof (frmPolicyImport);
    this.ResumeLayout(false);
  }
}
