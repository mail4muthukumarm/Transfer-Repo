// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.GenericComboBox
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class GenericComboBox : BaseReportControl
{
  private IContainer components;
  private Type _returnType;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("combo")]
  internal virtual MGASimpleComboBox combo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.combo = new MGASimpleComboBox();
    ((ISupportInitialize) this.combo).BeginInit();
    this.SuspendLayout();
    ((Control) this.combo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.combo.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.combo).Location = new Point(88, 6);
    ((Control) this.combo).Name = "combo";
    ((Control) this.combo).Size = new Size(300, 20);
    ((Control) this.combo).TabIndex = 1;
    ((UltraControlBase) this.combo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.combo).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.combo);
    this.Name = nameof (GenericComboBox);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public GenericComboBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    Type returnType,
    int width,
    int dropdownwidth)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    ComboBox comboBox = new ComboBox();
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery(SQLText);
    this.Width -= ((Control) this.combo).Width - width;
    ((UltraDropDownBase) this.combo).DisplayMember = DisplayMember;
    ((UltraDropDownBase) this.combo).ValueMember = ValueMember;
    ((Control) this.combo).Width = width;
    ((UltraDropDownBase) this.combo).DropDownWidth = dropdownwidth;
    ((UltraGridBase) this.combo).DataSource = (object) dataTable;
    this._returnType = returnType;
    if (((UltraGridBase) this.combo).Rows.Count > 0)
      this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public GenericComboBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    Type returnType)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    ComboBox comboBox = new ComboBox();
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery(SQLText);
    ((UltraDropDownBase) this.combo).DisplayMember = DisplayMember;
    ((UltraDropDownBase) this.combo).ValueMember = ValueMember;
    ((UltraGridBase) this.combo).DataSource = (object) dataTable;
    this._returnType = returnType;
    if (((UltraGridBase) this.combo).Rows.Count > 0)
      this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public GenericComboBox(
    string LabelText,
    int Width,
    int dropdownwidth,
    Type returnType,
    params object[] args)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    ComboBox comboBox = new ComboBox();
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("displaymember", typeof (string));
    dataTable.Columns.Add("valuemember", returnType);
    int num = args.Length - 1;
    for (int index = 0; index <= num; index += 2)
      dataTable.Rows.Add((object) args[index].ToString(), args[index + 1]);
    this.Width -= ((Control) this.combo).Width - Width;
    ((UltraDropDownBase) this.combo).DisplayMember = "displaymember";
    ((UltraDropDownBase) this.combo).ValueMember = "valuemember";
    ((Control) this.combo).Width = Width;
    ((UltraDropDownBase) this.combo).DropDownWidth = dropdownwidth;
    ((UltraGridBase) this.combo).DataSource = (object) dataTable;
    this._returnType = returnType;
    if (((UltraGridBase) this.combo).Rows.Count > 0)
      this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get
    {
      object obj;
      try
      {
        obj = this.combo.Value == null || this.combo.Value.GetType() == this._returnType ? this.combo.Value : (!(this.combo.Value is string) || !(this._returnType == typeof (Guid)) ? (!(this.combo.Value is IConvertible) ? this.combo.Value : Convert.ChangeType(RuntimeHelpers.GetObjectValue(this.combo.Value), this._returnType)) : (object) new Guid(this.combo.Value as string));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = this.combo.Value;
        ProjectData.ClearProjectError();
      }
      return obj;
    }
    set => this.combo.Value = RuntimeHelpers.GetObjectValue(value);
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Height = ((Control) this.combo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.combo).Height;
  }
}
