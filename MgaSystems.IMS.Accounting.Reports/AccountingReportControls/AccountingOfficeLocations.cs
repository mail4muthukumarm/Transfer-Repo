// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.AccountingOfficeLocations
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public sealed class AccountingOfficeLocations : BaseReportControl
{
  private IContainer components;
  private bool _GetLocationIDAsInteger;
  private DataSet _ds;

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
    this.Name = nameof (AccountingOfficeLocations);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public AccountingOfficeLocations(string LabelText, bool ShowAllOption)
  {
    this._GetLocationIDAsInteger = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocationGuids", new object[4]
    {
      (object) "@userguid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@allOption",
      (object) ShowAllOption
    });
    ((UltraDropDownBase) this.combo).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.combo).ValueMember = "OfficeGUID";
    ((UltraGridBase) this.combo).DataSource = (object) this._ds.Tables[0];
    this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public AccountingOfficeLocations(
    string LabelText,
    bool ShowAllOption,
    bool GetLocationIDAsInteger)
  {
    this._GetLocationIDAsInteger = false;
    this.InitializeComponent();
    this.Description = LabelText;
    if (GetLocationIDAsInteger)
    {
      this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations", new object[4]
      {
        (object) "@userguid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@allOption",
        (object) ShowAllOption
      });
      ((UltraDropDownBase) this.combo).ValueMember = "ID";
    }
    else
    {
      this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocationGuids", new object[4]
      {
        (object) "@userguid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@allOption",
        (object) ShowAllOption
      });
      ((UltraDropDownBase) this.combo).ValueMember = "OfficeGuid";
    }
    ((UltraDropDownBase) this.combo).DisplayMember = "Office Location";
    ((UltraGridBase) this.combo).DataSource = (object) this._ds.Tables[0];
    this.combo.SelectedIndex = 0;
    this._GetLocationIDAsInteger = GetLocationIDAsInteger;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => this.combo.Value;
    set
    {
      if (this._GetLocationIDAsInteger)
        this.combo.Value = (object) (int) value;
      else
        this.combo.Value = (object) (Guid) value;
    }
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Height = ((Control) this.combo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.combo).Height;
  }
}
