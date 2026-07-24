// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.panelBankAccounts
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[DesignerGenerated]
public class panelBankAccounts : UserControl
{
  private IContainer components;

  public panelBankAccounts() => this.InitializeComponent();

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.UltraFlowLayoutManager1 = new UltraFlowLayoutManager(this.components);
    ((ISupportInitialize) this.UltraFlowLayoutManager1).BeginInit();
    this.SuspendLayout();
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).ContainerControl = (Control) this;
    this.UltraFlowLayoutManager1.HorizontalAlignment = (DefaultableFlowLayoutAlignment) 1;
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).Margins.Bottom = 2;
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).Margins.Left = 4;
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).Margins.Right = 4;
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).Margins.Top = 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(200, 220, 245);
    this.Name = nameof (panelBankAccounts);
    this.Size = new Size(600, 120);
    ((ISupportInitialize) this.UltraFlowLayoutManager1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("UltraFlowLayoutManager1")]
  internal virtual UltraFlowLayoutManager UltraFlowLayoutManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
