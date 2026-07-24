// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.OptionStackOptionControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Tools.BaseClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack;

[Obsolete]
public class OptionStackOptionControl : MGABaseUserControl
{
  private Label labelControlDisplayName;
  private TableLayoutPanel controlTableLayout;
  private TableLayoutPanel tableLayout;

  public OptionStackOptionControl() => this.InitializeComponent();

  public void SetValueControl(Control control)
  {
    control.Anchor = AnchorStyles.None;
    control.Dock = DockStyle.Left;
    control.Margin = new Padding(1);
    this.controlTableLayout.Controls.Add(control, 0, 1);
  }

  public void SetDisplayText(string text) => this.labelControlDisplayName.Text = text;

  private void InitializeComponent()
  {
    this.tableLayout = new TableLayoutPanel();
    this.labelControlDisplayName = new Label();
    this.controlTableLayout = new TableLayoutPanel();
    this.tableLayout.SuspendLayout();
    this.SuspendLayout();
    this.tableLayout.BackColor = Color.Transparent;
    this.tableLayout.ColumnCount = 2;
    this.tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
    this.tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.tableLayout.Controls.Add((Control) this.labelControlDisplayName, 0, 0);
    this.tableLayout.Controls.Add((Control) this.controlTableLayout, 1, 0);
    this.tableLayout.Dock = DockStyle.Fill;
    this.tableLayout.Location = new Point(0, 0);
    this.tableLayout.Margin = new Padding(0);
    this.tableLayout.Name = "tableLayout";
    this.tableLayout.RowCount = 1;
    this.tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
    this.tableLayout.Size = new Size(500, 25);
    this.tableLayout.TabIndex = 0;
    this.labelControlDisplayName.AutoSize = true;
    this.labelControlDisplayName.BackColor = Color.Transparent;
    this.labelControlDisplayName.Dock = DockStyle.Fill;
    this.labelControlDisplayName.Location = new Point(3, 0);
    this.labelControlDisplayName.Name = "labelControlDisplayName";
    this.labelControlDisplayName.Size = new Size(84, 25);
    this.labelControlDisplayName.TabIndex = 0;
    this.labelControlDisplayName.Text = "Control Display Name:";
    this.labelControlDisplayName.TextAlign = ContentAlignment.MiddleLeft;
    this.controlTableLayout.ColumnCount = 1;
    this.controlTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.controlTableLayout.Dock = DockStyle.Fill;
    this.controlTableLayout.Location = new Point(90, 0);
    this.controlTableLayout.Margin = new Padding(0);
    this.controlTableLayout.Name = "controlTableLayout";
    this.controlTableLayout.RowCount = 3;
    this.controlTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.controlTableLayout.RowStyles.Add(new RowStyle());
    this.controlTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.controlTableLayout.Size = new Size(410, 25);
    this.controlTableLayout.TabIndex = 1;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.tableLayout);
    this.Name = nameof (OptionStackOptionControl);
    this.Size = new Size(500, 25);
    this.tableLayout.ResumeLayout(false);
    this.tableLayout.PerformLayout();
    this.ResumeLayout(false);
  }
}
