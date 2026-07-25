// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.OrderBy
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class OrderBy : BaseReportControl
{
  private IContainer components;
  private DataTable _data;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lbValues")]
  internal virtual MGAListBox lbValues { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnUp
  {
    get => this._btnUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUp_Click);
      MGAButton btnUp1 = this._btnUp;
      if (btnUp1 != null)
        ((Control) btnUp1).Click -= eventHandler;
      this._btnUp = value;
      MGAButton btnUp2 = this._btnUp;
      if (btnUp2 == null)
        return;
      ((Control) btnUp2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnDown
  {
    get => this._btnDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDown_Click);
      MGAButton btnDown1 = this._btnDown;
      if (btnDown1 != null)
        ((Control) btnDown1).Click -= eventHandler;
      this._btnDown = value;
      MGAButton btnDown2 = this._btnDown;
      if (btnDown2 == null)
        return;
      ((Control) btnDown2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.lbValues = new MGAListBox();
    this.btnUp = new MGAButton();
    this.btnDown = new MGAButton();
    ((ISupportInitialize) this.lbValues).BeginInit();
    ((ISupportInitialize) this.btnUp).BeginInit();
    ((ISupportInitialize) this.btnDown).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, 1);
    this.lblDescription.Size = new Size(88, 65);
    this.lbValues.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lbValues.Location = new Point(88, 5);
    this.lbValues.Name = "lbValues";
    this.lbValues.Size = new Size(269, 54);
    this.lbValues.TabIndex = 1;
    ((Control) this.btnUp).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnUp).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnUp).Location = new Point(363, 6);
    ((Control) this.btnUp).Name = "btnUp";
    ((Control) this.btnUp).Size = new Size(24, 24);
    ((Control) this.btnUp).TabIndex = 2;
    this.btnUp.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDown).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnDown).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnDown).Location = new Point(363, 36);
    ((Control) this.btnDown).Name = "btnDown";
    ((Control) this.btnDown).Size = new Size(24, 24);
    ((Control) this.btnDown).TabIndex = 3;
    this.btnDown.UseOSThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.btnDown);
    this.Controls.Add((Control) this.btnUp);
    this.Controls.Add((Control) this.lbValues);
    this.Name = nameof (OrderBy);
    this.Size = new Size(392, 65);
    this.Controls.SetChildIndex((Control) this.lbValues, 0);
    this.Controls.SetChildIndex((Control) this.btnUp, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.btnDown, 0);
    ((ISupportInitialize) this.lbValues).EndInit();
    ((ISupportInitialize) this.btnUp).EndInit();
    ((ISupportInitialize) this.btnDown).EndInit();
    this.ResumeLayout(false);
  }

  public OrderBy(params string[] FieldsAndValues)
  {
    this.InitializeComponent();
    this.Description = "Sort By";
    ((ControlBase) this.btnUp).Appearance.Image = (object) ImageCache.Instance.ArrowUp;
    ((ControlBase) this.btnDown).Appearance.Image = (object) ImageCache.Instance.ArrowDown;
    ((ControlBase) this.btnUp).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUp).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnDown).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDown).Appearance.ImageHAlign = (HAlign) 2;
    this._data = new DataTable();
    this._data.Columns.Add("Order", typeof (int));
    this._data.Columns.Add("Display", typeof (string));
    this._data.Columns.Add(nameof (Value), typeof (string));
    int num = FieldsAndValues.Length - 1;
    for (int index = 0; index <= num; index += 2)
    {
      DataRow row = this._data.NewRow();
      row["Order"] = (object) this._data.Rows.Count;
      row["Display"] = (object) FieldsAndValues[index];
      row[nameof (Value)] = (object) FieldsAndValues[index + 1];
      this._data.Rows.Add(row);
    }
    this.UpdateValueDisplay();
    this.InitialSize = this.Size;
  }

  private void UpdateValueDisplay()
  {
    DataView dataView = new DataView(this._data, "", "Order ASC", DataViewRowState.CurrentRows);
    this.lbValues.DisplayMember = "Display";
    this.lbValues.ValueMember = "Value";
    this.lbValues.DataSource = (object) dataView;
  }

  private void btnUp_Click(object sender, EventArgs e)
  {
    int selectedIndex = this.lbValues.SelectedIndex;
    int num = selectedIndex - 1;
    if (selectedIndex == -1 || num < 0)
      return;
    this._data.Select($"Order = '{selectedIndex}'")[0]["Order"] = (object) -1;
    this._data.Select($"Order = '{num}'")[0]["Order"] = (object) selectedIndex;
    this._data.Select(string.Format("Order = '-1'", (object) selectedIndex))[0]["Order"] = (object) num;
    this.UpdateValueDisplay();
    this.lbValues.SelectedIndex = num;
  }

  private void btnDown_Click(object sender, EventArgs e)
  {
    int selectedIndex = this.lbValues.SelectedIndex;
    int num = selectedIndex + 1;
    if (selectedIndex == -1 || num >= this._data.Rows.Count)
      return;
    this._data.Select($"Order = '{selectedIndex}'")[0]["Order"] = (object) -1;
    this._data.Select($"Order = '{num}'")[0]["Order"] = (object) selectedIndex;
    this._data.Select(string.Format("Order = '-1'", (object) selectedIndex))[0]["Order"] = (object) num;
    this.UpdateValueDisplay();
    this.lbValues.SelectedIndex = num;
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      DataRow[] dataRowArray = this._data.Select("", "Order", DataViewRowState.CurrentRows);
      int index = 0;
      while (index < dataRowArray.Length)
      {
        DataRow dataRow = dataRowArray[index];
        if (empty.Length > 0)
          empty += ",";
        empty += dataRow[nameof (Value)].ToString();
        checked { ++index; }
      }
      return (object) empty;
    }
    set
    {
      string[] strArray = ((string) value).Split(',');
      int num = strArray.Length - 1;
      for (int index = 0; index <= num; ++index)
        this._data.Select($"Value = '{strArray[index]}'")[0]["Order"] = (object) index;
    }
  }

  public override void Compress()
  {
    this.lbValues.Top = 0;
    this.lblDescription.Height = this.lbValues.Height;
    this.lblDescription.Top = 0;
    ((Control) this.btnUp).Top = 0;
    ((Control) this.btnDown).Top = this.lbValues.Height - ((Control) this.btnDown).Height;
    this.Height = this.lbValues.Height;
  }
}
