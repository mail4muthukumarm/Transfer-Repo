// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry.HorizontalSplitStackEntryControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.Utility;
using MGASystems.Tools.BaseClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;

public class HorizontalSplitStackEntryControl : MGABaseUserControl, IStackEntryControl
{
  private Label labelControlDisplayName;
  private TableLayoutPanel controlTableLayout;
  private TableLayoutPanel labelAndControlTableLayout;
  private Control _valueControl;
  private readonly int _valueControlWidth;
  public static readonly int MarginAboveStackEntry = 3;

  public HorizontalSplitStackEntryControl(
    Control valueControl,
    string labelText,
    int valueControlWidth)
  {
    this._valueControl = valueControl ?? throw new ArgumentNullException(nameof (valueControl));
    this._valueControlWidth = valueControlWidth;
    this.InitializeComponent();
    this._valueControl.Dock = DockStyle.Top;
    this._valueControl.Margin = new Padding(0, 0, 0, 0);
    this._valueControl.MaximumSize = new Size(this._valueControlWidth, this._valueControl.Height);
    this.controlTableLayout.Controls.Add(valueControl, 0, 1);
    if (string.IsNullOrWhiteSpace(labelText))
      this.labelControlDisplayName.Visible = false;
    else
      this.labelControlDisplayName.Text = labelText;
  }

  public int GetControlWidth() => this.Width - this._valueControl.Width + this._valueControlWidth;

  public int GetPreferredTextWidth()
  {
    return !this.labelControlDisplayName.Visible ? 0 : this.labelControlDisplayName.GetPreferredWidth();
  }

  public int GetTextWidth()
  {
    return !this.labelControlDisplayName.Visible ? 0 : (int) this.labelAndControlTableLayout.ColumnStyles[0].Width;
  }

  public void AdjustControlSizeToFitLabelOfMaximumWidth(int width)
  {
    this.labelAndControlTableLayout.ColumnStyles[0].Width = (float) width;
    this.labelAndControlTableLayout.PerformLayout();
    this.labelControlDisplayName.PerformLayout();
    this.Height = this.GetIdealHeight();
    this.labelAndControlTableLayout.ColumnStyles[0].Width = (float) (this.labelControlDisplayName.GetPreferredSize(new Size(this.labelControlDisplayName.Width, this.labelControlDisplayName.Height)).Width + this.labelControlDisplayName.Margin.Right + this.labelControlDisplayName.Margin.Left);
  }

  public void SetLabelWidth(int width)
  {
    this.labelAndControlTableLayout.ColumnStyles[0].Width = (float) width;
  }

  public void SetStartingWidth(int startingWidth) => this.Width = startingWidth;

  private int GetIdealHeight()
  {
    int totalHeight = this._valueControl.GetTotalHeight();
    if (!this.labelControlDisplayName.Visible)
      return totalHeight;
    int num = this.labelControlDisplayName.GetPreferredSize(new Size(this.labelControlDisplayName.Width, 0)).Height + this.labelControlDisplayName.Margin.Top + this.labelControlDisplayName.Margin.Bottom;
    return totalHeight <= num ? num : totalHeight;
  }

  private void InitializeComponent()
  {
    this.labelAndControlTableLayout = new TableLayoutPanel();
    this.labelControlDisplayName = new Label();
    this.controlTableLayout = new TableLayoutPanel();
    this.labelAndControlTableLayout.SuspendLayout();
    this.SuspendLayout();
    this.labelAndControlTableLayout.BackColor = Color.Transparent;
    this.labelAndControlTableLayout.TabStop = false;
    this.labelAndControlTableLayout.ColumnCount = 2;
    this.labelAndControlTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
    this.labelAndControlTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.labelAndControlTableLayout.Controls.Add((Control) this.labelControlDisplayName, 0, 0);
    this.labelAndControlTableLayout.Controls.Add((Control) this.controlTableLayout, 1, 0);
    this.labelAndControlTableLayout.Dock = DockStyle.Fill;
    this.labelAndControlTableLayout.Location = new Point(0, 0);
    this.labelAndControlTableLayout.Margin = new Padding(0);
    this.labelAndControlTableLayout.Name = "labelAndControlTableLayout";
    this.labelAndControlTableLayout.RowCount = 1;
    this.labelAndControlTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
    this.labelAndControlTableLayout.Size = new Size(200, 30);
    this.labelAndControlTableLayout.TabIndex = 0;
    this.labelControlDisplayName.AutoSize = true;
    this.labelControlDisplayName.TabStop = false;
    this.labelControlDisplayName.BackColor = SystemColors.Control;
    this.labelControlDisplayName.Dock = DockStyle.Fill;
    this.labelControlDisplayName.Location = new Point(0, 0);
    this.labelControlDisplayName.Margin = new Padding(0);
    this.labelControlDisplayName.Name = "labelControlDisplayName";
    this.labelControlDisplayName.Size = new Size(90, 30);
    this.labelControlDisplayName.TabIndex = 0;
    this.labelControlDisplayName.Text = "Control Display Name:";
    this.controlTableLayout.AutoSize = true;
    this.controlTableLayout.TabStop = false;
    this.controlTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.controlTableLayout.BackColor = SystemColors.Control;
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
    this.controlTableLayout.Size = new Size(110, 30);
    this.controlTableLayout.TabIndex = 1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.TabStop = false;
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.labelAndControlTableLayout);
    this.Margin = new Padding(0, HorizontalSplitStackEntryControl.MarginAboveStackEntry, 0, 0);
    this.MaximumSize = new Size(2000, 500);
    this.MinimumSize = new Size(20, 10);
    this.Name = nameof (HorizontalSplitStackEntryControl);
    this.Size = new Size(200, 30);
    this.labelAndControlTableLayout.ResumeLayout(false);
    this.labelAndControlTableLayout.PerformLayout();
    this.ResumeLayout(false);
  }

  int IStackEntryControl.get_Width() => this.Width;

  void IStackEntryControl.set_Width(int value) => this.Width = value;

  int IStackEntryControl.get_Height() => this.Height;

  Padding IStackEntryControl.get_Margin() => this.Margin;
}
