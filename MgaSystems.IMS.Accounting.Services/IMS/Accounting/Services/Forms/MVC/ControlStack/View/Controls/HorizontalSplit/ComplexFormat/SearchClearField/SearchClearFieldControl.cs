// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.ComplexFormat.SearchClearField.SearchClearFieldControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Properties;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.HorizontalSplit.ComplexFormat.SearchClearField;

public class SearchClearFieldControl : MGABaseUserControl
{
  private Button bSearch;
  private MGATextBox fieldValue;
  private Button bClear;
  private BlockingRunner ValueUpdater = new BlockingRunner();
  private TableLayoutPanel tableLayout;

  public event EventHandler FieldValueChanged;

  public object Value { get; private set; }

  public Func<object, string> GetDisplayTextFromValue { get; set; }

  public Func<object, object> SearchAction { get; set; }

  public SearchClearFieldControl() => this.InitializeComponent();

  public void SetValue(object value)
  {
    this.Value = value;
    if (value == null)
    {
      ((Control) this.fieldValue).Text = string.Empty;
    }
    else
    {
      MGATextBox fieldValue = this.fieldValue;
      Func<object, string> displayTextFromValue = this.GetDisplayTextFromValue;
      string str = displayTextFromValue != null ? displayTextFromValue(value) : (string) null;
      ((Control) fieldValue).Text = str;
    }
  }

  private void bSearch_Clicked(object sender, EventArgs e)
  {
    Func<object, object> searchAction = this.SearchAction;
    this.SetValue(searchAction != null ? searchAction(this.Value) : (object) null);
  }

  private void bClearClicked(object sender, EventArgs e)
  {
    this.Value = (object) null;
    ((Control) this.fieldValue).Text = string.Empty;
  }

  private void FieldValue_TextChanged(object sender, EventArgs e)
  {
    EventHandler fieldValueChanged = this.FieldValueChanged;
    if (fieldValueChanged == null)
      return;
    fieldValueChanged((object) this, EventArgs.Empty);
  }

  private void InitializeComponent()
  {
    this.tableLayout = new TableLayoutPanel();
    this.bSearch = new Button();
    this.fieldValue = new MGATextBox();
    this.bClear = new Button();
    this.tableLayout.SuspendLayout();
    this.SuspendLayout();
    this.tableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.tableLayout.ColumnCount = 3;
    this.tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22f));
    this.tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22f));
    this.tableLayout.Controls.Add((Control) this.bSearch, 1, 0);
    this.tableLayout.Controls.Add((Control) this.fieldValue, 0, 0);
    this.tableLayout.Controls.Add((Control) this.bClear, 2, 0);
    this.tableLayout.Dock = DockStyle.Fill;
    this.tableLayout.Location = new Point(0, 0);
    this.tableLayout.Margin = new Padding(0);
    this.tableLayout.Name = "tableLayout";
    this.tableLayout.RowCount = 1;
    this.tableLayout.RowStyles.Add(new RowStyle());
    this.tableLayout.Size = new Size(200, 21);
    this.tableLayout.TabIndex = 0;
    this.bSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.bSearch.Dock = DockStyle.Top;
    this.bSearch.Image = (Image) Resources.magnifier;
    this.bSearch.Location = new Point(156, 0);
    this.bSearch.Margin = new Padding(0, 0, 1, 0);
    this.bSearch.Name = "bSearch";
    this.bSearch.Size = new Size(21, 21);
    this.bSearch.TabIndex = 0;
    this.bSearch.UseVisualStyleBackColor = true;
    this.bSearch.Click += new EventHandler(this.bSearch_Clicked);
    ((Control) this.fieldValue).Dock = DockStyle.Fill;
    ((Control) this.fieldValue).Enabled = false;
    ((Control) this.fieldValue).Location = new Point(0, 0);
    ((Control) this.fieldValue).Margin = new Padding(0, 0, 3, 0);
    ((Control) this.fieldValue).Name = "fieldValue";
    ((Control) this.fieldValue).Size = new Size(153, 21);
    ((Control) this.fieldValue).TabIndex = 0;
    ((Control) this.fieldValue).TabStop = false;
    ((Control) this.fieldValue).TextChanged += new EventHandler(this.FieldValue_TextChanged);
    this.bClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.bClear.Dock = DockStyle.Top;
    this.bClear.Image = (Image) Resources.cross;
    this.bClear.Location = new Point(179, 0);
    this.bClear.Margin = new Padding(1, 0, 0, 0);
    this.bClear.Name = "bClear";
    this.bClear.Size = new Size(21, 21);
    this.bClear.TabIndex = 1;
    this.bClear.UseVisualStyleBackColor = true;
    this.bClear.Click += new EventHandler(this.bClearClicked);
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.tableLayout);
    this.Margin = new Padding(0);
    this.Name = nameof (SearchClearFieldControl);
    this.Size = new Size(200, 21);
    this.tableLayout.ResumeLayout(false);
    this.tableLayout.PerformLayout();
    this.ResumeLayout(false);
  }
}
