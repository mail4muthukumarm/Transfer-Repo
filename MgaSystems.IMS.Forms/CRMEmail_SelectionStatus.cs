// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.CRMEmail_SelectionStatus
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class CRMEmail_SelectionStatus : UserControl
{
  private IContainer components;

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
    this.lblStateStatus = new Label();
    this.lblStateStatusHeader = new Label();
    this.LabelLOBHeader = new Label();
    this.lblLOBStatus = new Label();
    this.SuspendLayout();
    this.lblStateStatus.AutoSize = true;
    this.lblStateStatus.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblStateStatus.Location = new Point(6, 20);
    this.lblStateStatus.Margin = new Padding(3, 3, 3, 0);
    this.lblStateStatus.MaximumSize = new Size(300, 400);
    this.lblStateStatus.Name = "lblStateStatus";
    this.lblStateStatus.Size = new Size(0, 14);
    this.lblStateStatus.TabIndex = 15;
    this.lblStateStatusHeader.AutoSize = true;
    this.lblStateStatusHeader.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblStateStatusHeader.Location = new Point(3, 3);
    this.lblStateStatusHeader.Margin = new Padding(3, 3, 3, 0);
    this.lblStateStatusHeader.MaximumSize = new Size(300, 400);
    this.lblStateStatusHeader.Name = "lblStateStatusHeader";
    this.lblStateStatusHeader.Size = new Size(286, 14);
    this.lblStateStatusHeader.TabIndex = 14;
    this.lblStateStatusHeader.Text = "Your campaign  will be targeting Producers in";
    this.LabelLOBHeader.AutoSize = true;
    this.LabelLOBHeader.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.LabelLOBHeader.Location = new Point(3, 214);
    this.LabelLOBHeader.Margin = new Padding(3, 3, 3, 0);
    this.LabelLOBHeader.MaximumSize = new Size(300, 400);
    this.LabelLOBHeader.Name = "LabelLOBHeader";
    this.LabelLOBHeader.Size = new Size(292, 14);
    this.LabelLOBHeader.TabIndex = 16 /*0x10*/;
    this.LabelLOBHeader.Text = "Who can write business in the following Lines:";
    this.lblLOBStatus.AutoSize = true;
    this.lblLOBStatus.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLOBStatus.Location = new Point(6, 231);
    this.lblLOBStatus.Margin = new Padding(3, 3, 3, 0);
    this.lblLOBStatus.MaximumSize = new Size(300, 400);
    this.lblLOBStatus.Name = "lblLOBStatus";
    this.lblLOBStatus.Size = new Size(0, 14);
    this.lblLOBStatus.TabIndex = 17;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.lblLOBStatus);
    this.Controls.Add((Control) this.LabelLOBHeader);
    this.Controls.Add((Control) this.lblStateStatus);
    this.Controls.Add((Control) this.lblStateStatusHeader);
    this.Name = nameof (CRMEmail_SelectionStatus);
    this.Size = new Size(300, 400);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblStateStatus")]
  internal virtual Label lblStateStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStateStatusHeader")]
  internal virtual Label lblStateStatusHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LabelLOBHeader")]
  internal virtual Label LabelLOBHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLOBStatus")]
  internal virtual Label lblLOBStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public CRMEmail_SelectionStatus() => this.InitializeComponent();

  public CRMEmail_SelectionStatus(string StateSelection, string LOBSelection)
  {
    this.InitializeComponent();
  }
}
