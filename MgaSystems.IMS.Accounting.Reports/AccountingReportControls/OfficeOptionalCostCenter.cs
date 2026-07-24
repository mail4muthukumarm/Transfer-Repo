// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.OfficeOptionalCostCenter
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Reporting.ReportControls;
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
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public class OfficeOptionalCostCenter : BaseReportControl
{
  private IContainer components;

  public OfficeOptionalCostCenter(string LabelText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this.LoadOfficeLocations();
    ((Control) this.comboCostCenters).DataBindings.Add("Enabled", (object) this.checkUseCostCenter, "Checked");
    this.InitialSize = this.Size;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGASimpleComboBox comboOfficeLocation
  {
    get => this._comboOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
      MGASimpleComboBox comboOfficeLocation1 = this._comboOfficeLocation;
      if (comboOfficeLocation1 != null)
        comboOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboOfficeLocation = value;
      MGASimpleComboBox comboOfficeLocation2 = this._comboOfficeLocation;
      if (comboOfficeLocation2 == null)
        return;
      comboOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual CheckBox checkUseCostCenter
  {
    get => this._checkUseCostCenter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkUseCostCenter_CheckedChanged);
      CheckBox checkUseCostCenter1 = this._checkUseCostCenter;
      if (checkUseCostCenter1 != null)
        checkUseCostCenter1.CheckedChanged -= eventHandler;
      this._checkUseCostCenter = value;
      CheckBox checkUseCostCenter2 = this._checkUseCostCenter;
      if (checkUseCostCenter2 == null)
        return;
      checkUseCostCenter2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("comboCostCenters")]
  internal virtual MGASimpleComboBox comboCostCenters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.comboCostCenters = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.checkUseCostCenter = new CheckBox();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(8, 6);
    this.lblDescription.Size = new Size(35, 14);
    this.lblDescription.Text = "Office";
    ((Control) this.comboOfficeLocation).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(88, 6);
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.comboCostCenters).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.comboCostCenters).TabIndex = 2;
    ((UltraControlBase) this.comboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(8, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 20);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Cost Center";
    this.checkUseCostCenter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.checkUseCostCenter.Enabled = false;
    this.checkUseCostCenter.FlatStyle = FlatStyle.Flat;
    this.checkUseCostCenter.Location = new Point(320, 32 /*0x20*/);
    this.checkUseCostCenter.Name = "checkUseCostCenter";
    this.checkUseCostCenter.Size = new Size(117, 20);
    this.checkUseCostCenter.TabIndex = 4;
    this.checkUseCostCenter.Text = "Limit By Cost Center";
    this.Controls.Add((Control) this.checkUseCostCenter);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.comboCostCenters);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Description = "Office";
    this.Name = nameof (OfficeOptionalCostCenter);
    this.Size = new Size(440, 58);
    this.Controls.SetChildIndex((Control) this.comboOfficeLocation, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.comboCostCenters, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.checkUseCostCenter, 0);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      if (((UltraGridBase) this.comboCostCenters).DataSource != null)
        ((DataTable) ((UltraGridBase) this.comboCostCenters).DataSource).Clear();
      this.checkUseCostCenter.Enabled = false;
    }
    else
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;
        this.LoadCostCenters(Conversions.ToInteger(this.comboOfficeLocation.Value.ToString()));
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
      this.checkUseCostCenter.Enabled = true;
    }
  }

  private void LoadCostCenters(int GlCompanyID)
  {
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) Database.Instance.QuerySP.PerformTableQuery("spFin_GetCostCentersList", (object) "@glcompanyid", (object) GlCompanyID);
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "CostCenterId";
  }

  private void checkUseCostCenter_CheckedChanged(object sender, EventArgs e)
  {
    if (this.checkUseCostCenter.Checked)
      return;
    ((Control) this.comboCostCenters).ResetText();
  }

  public override object Value
  {
    get
    {
      int num = 0;
      if (((UltraDropDownBase) this.comboCostCenters).SelectedRow != null & this.checkUseCostCenter.Checked)
        num = Conversions.ToInteger(this.comboCostCenters.Value.ToString());
      return (object) new object[2]
      {
        this.comboOfficeLocation.Value,
        (object) num
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      this.comboOfficeLocation.Value = (object) (int) objArray[0];
      if ((int) objArray[1] == 0)
      {
        this.checkUseCostCenter.Checked = false;
      }
      else
      {
        this.checkUseCostCenter.Checked = true;
        this.comboCostCenters.Value = (object) (int) objArray[1];
      }
    }
  }

  public override void Compress()
  {
    ((Control) this.comboOfficeLocation).Top = 0;
    this.lblDescription.Top = 0;
    this.Label1.Top = ((Control) this.comboOfficeLocation).Height;
    ((Control) this.comboCostCenters).Top = ((Control) this.comboOfficeLocation).Height;
    this.checkUseCostCenter.Top = ((Control) this.comboOfficeLocation).Height;
    this.Height = checked (this.checkUseCostCenter.Height + ((Control) this.comboOfficeLocation).Height);
  }
}
