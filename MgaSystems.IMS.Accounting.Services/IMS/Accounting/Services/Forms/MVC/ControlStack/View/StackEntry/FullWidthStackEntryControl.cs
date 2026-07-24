// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry.FullWidthStackEntryControl
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

public class FullWidthStackEntryControl : MGABaseUserControl, IStackEntryControl
{
  private TableLayoutPanel labelAndControlLayoutTable;
  private Label labelControlDisplayName;
  private readonly Control _valueControl;
  private readonly int _valueControlMaxWidth;
  private readonly bool _alignTextWithHorizontalControls;
  public static readonly int MarginBelowLabel = 1;
  public static readonly int MarginAboveStackEntry = 3;

  public FullWidthStackEntryControl(
    Control valueControl,
    string labelText,
    int valueControlMaxWidth,
    int controlHeight,
    bool alignTextWithHorizontalControls)
  {
    this._valueControl = valueControl ?? throw new ArgumentNullException(nameof (valueControl));
    this._valueControlMaxWidth = valueControlMaxWidth;
    this._alignTextWithHorizontalControls = alignTextWithHorizontalControls;
    this.InitializeComponent();
    this._valueControl.Dock = DockStyle.Top;
    this._valueControl.Margin = new Padding(0, 0, 0, 0);
    this._valueControl.MaximumSize = new Size(this._valueControlMaxWidth, controlHeight);
    this._valueControl.MinimumSize = new Size(this._valueControl.MinimumSize.Width, controlHeight);
    this._valueControl.Height = controlHeight;
    this.labelAndControlLayoutTable.Controls.Add(valueControl, 0, 1);
    this.labelControlDisplayName.Text = labelText;
    if (string.IsNullOrWhiteSpace(this.labelControlDisplayName.Text))
    {
      this.labelControlDisplayName.Visible = false;
      this.labelAndControlLayoutTable.RowStyles[0].SizeType = SizeType.Absolute;
      this.labelAndControlLayoutTable.RowStyles[0].Height = 0.0f;
    }
    this.labelControlDisplayName.AutoSize = false;
    if (this._alignTextWithHorizontalControls)
      this.labelControlDisplayName.Dock = DockStyle.Left;
    else
      this.labelControlDisplayName.Dock = DockStyle.Top;
  }

  public int GetControlWidth() => this._valueControlMaxWidth;

  public int GetPreferredTextWidth()
  {
    return !this._alignTextWithHorizontalControls ? 0 : this.labelControlDisplayName.GetPreferredWidth();
  }

  public int GetTextWidth()
  {
    return !this._alignTextWithHorizontalControls ? 0 : this.labelControlDisplayName.GetTotalWidth();
  }

  public void AdjustControlSizeToFitLabelOfMaximumWidth(int width)
  {
    if (this._alignTextWithHorizontalControls)
    {
      Size preferredSize = this.labelControlDisplayName.GetPreferredSize(new Size(width, 0));
      this.labelControlDisplayName.Width = width;
      this.labelControlDisplayName.Height = preferredSize.Height;
      this.labelAndControlLayoutTable.PerformLayout();
      this.labelControlDisplayName.PerformLayout();
    }
    else
      this.labelControlDisplayName.MaximumSize = new Size(this._valueControlMaxWidth + width, 0);
    this._valueControl.MaximumSize = new Size(this._valueControlMaxWidth + width, this._valueControl.MaximumSize.Height);
  }

  public void SetLabelWidth(int width)
  {
    if (this._alignTextWithHorizontalControls)
    {
      this.labelControlDisplayName.Width = width;
      this.labelControlDisplayName.Height = this.labelControlDisplayName.GetPreferredSize(new Size(width, 0)).Height;
      this.labelControlDisplayName.PerformLayout();
    }
    this.Height = this.GetIdealHeight();
  }

  public void SetStartingWidth(int startingWidth)
  {
    this.Width = startingWidth;
    this.labelAndControlLayoutTable.PerformLayout();
    this.labelControlDisplayName.Height = this.labelControlDisplayName.GetPreferredSize(new Size(this.labelControlDisplayName.Width, 0)).Height;
    this.Height = this.GetIdealHeight();
  }

  private int GetIdealHeight()
  {
    return (this.labelControlDisplayName.Visible ? this.labelControlDisplayName.GetTotalHeight() : 0) + this._valueControl.GetTotalHeight();
  }

  private void labelControlDisplayName_SizeChanged(object sender, EventArgs e)
  {
    if (this._alignTextWithHorizontalControls)
      return;
    this.ForceResizeControl();
  }

  private void ForceResizeControl()
  {
    this.labelControlDisplayName.Height = this.labelControlDisplayName.GetPreferredSize(new Size(this.labelControlDisplayName.Width, 0)).Height;
    this.Height = this.GetIdealHeight();
  }

  private void InitializeComponent()
  {
    this.labelAndControlLayoutTable = new TableLayoutPanel();
    this.labelControlDisplayName = new Label();
    this.labelAndControlLayoutTable.SuspendLayout();
    this.SuspendLayout();
    this.labelAndControlLayoutTable.BackColor = SystemColors.Control;
    this.labelAndControlLayoutTable.TabStop = false;
    this.labelAndControlLayoutTable.ColumnCount = 1;
    this.labelAndControlLayoutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.labelAndControlLayoutTable.Controls.Add((Control) this.labelControlDisplayName, 0, 0);
    this.labelAndControlLayoutTable.Dock = DockStyle.Fill;
    this.labelAndControlLayoutTable.Location = new Point(0, 0);
    this.labelAndControlLayoutTable.Margin = new Padding(0);
    this.labelAndControlLayoutTable.Name = "labelAndControlLayoutTable";
    this.labelAndControlLayoutTable.RowCount = 2;
    this.labelAndControlLayoutTable.RowStyles.Add(new RowStyle());
    this.labelAndControlLayoutTable.RowStyles.Add(new RowStyle());
    this.labelAndControlLayoutTable.Size = new Size(200, 40);
    this.labelAndControlLayoutTable.TabIndex = 0;
    this.labelControlDisplayName.AutoSize = true;
    this.labelControlDisplayName.TabStop = false;
    this.labelControlDisplayName.BackColor = SystemColors.Control;
    this.labelControlDisplayName.Dock = DockStyle.Left;
    this.labelControlDisplayName.Location = new Point(0, 0);
    this.labelControlDisplayName.Margin = new Padding(0, 0, 0, FullWidthStackEntryControl.MarginBelowLabel);
    this.labelControlDisplayName.Name = "labelControlDisplayName";
    this.labelControlDisplayName.Size = new Size(109, 13);
    this.labelControlDisplayName.TabIndex = 0;
    this.labelControlDisplayName.Text = "Control Display Name";
    this.labelControlDisplayName.SizeChanged += new EventHandler(this.labelControlDisplayName_SizeChanged);
    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.BackColor = SystemColors.Control;
    this.TabStop = false;
    this.Controls.Add((Control) this.labelAndControlLayoutTable);
    this.Margin = new Padding(0, FullWidthStackEntryControl.MarginAboveStackEntry, 0, 0);
    this.MaximumSize = new Size(2000, 500);
    this.MinimumSize = new Size(20, 10);
    this.Name = nameof (FullWidthStackEntryControl);
    this.Size = new Size(200, 40);
    this.labelAndControlLayoutTable.ResumeLayout(false);
    this.labelAndControlLayoutTable.PerformLayout();
    this.ResumeLayout(false);
  }

  int IStackEntryControl.get_Width() => this.Width;

  void IStackEntryControl.set_Width(int value) => this.Width = value;

  int IStackEntryControl.get_Height() => this.Height;

  Padding IStackEntryControl.get_Margin() => this.Margin;
}
