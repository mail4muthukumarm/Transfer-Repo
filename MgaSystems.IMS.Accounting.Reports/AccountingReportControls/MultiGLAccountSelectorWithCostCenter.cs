// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.MultiGLAccountSelectorWithCostCenter
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

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
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

[DesignerGenerated]
public class MultiGLAccountSelectorWithCostCenter : MultiGlAccountsSelector
{
  private IContainer components;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.comboCostCenters = new MGASimpleComboBox();
    this.labelCostCenter = new Label();
    this.checkUseCostCenter = new CheckBox();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    this.SuspendLayout();
    this.MultipleExtendedTreeViewDropDown1.Location = new Point(99, 59);
    this.lblDescription.Location = new Point(3, 59);
    this.lblDescription.Size = new Size(86, 21);
    this.comboCostCenters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenters.CharacterCasing = CharacterCasing.Normal;
    this.comboCostCenters.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Location = new Point(99, 34);
    this.comboCostCenters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(203, 20);
    ((Control) this.comboCostCenters).TabIndex = 5;
    ((UltraControlBase) this.comboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.labelCostCenter.AutoSize = true;
    this.labelCostCenter.Location = new Point(3, 34);
    this.labelCostCenter.Name = "labelCostCenter";
    this.labelCostCenter.Size = new Size(62, 13);
    this.labelCostCenter.TabIndex = 6;
    this.labelCostCenter.Text = "Cost Center";
    this.checkUseCostCenter.Enabled = false;
    this.checkUseCostCenter.FlatStyle = FlatStyle.Flat;
    this.checkUseCostCenter.Location = new Point(308, 30);
    this.checkUseCostCenter.Name = "checkUseCostCenter";
    this.checkUseCostCenter.Size = new Size(136, 24);
    this.checkUseCostCenter.TabIndex = 7;
    this.checkUseCostCenter.Text = "Limit By Cost Center";
    this.Controls.Add((Control) this.checkUseCostCenter);
    this.Controls.Add((Control) this.comboCostCenters);
    this.Controls.Add((Control) this.labelCostCenter);
    this.Name = nameof (MultiGLAccountSelectorWithCostCenter);
    this.Size = new Size(447, 85);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.labelCostCenter, 0);
    this.Controls.SetChildIndex((Control) this.comboCostCenters, 0);
    this.Controls.SetChildIndex((Control) this.MultipleExtendedTreeViewDropDown1, 0);
    this.Controls.SetChildIndex((Control) this.comboOfficeLocation, 0);
    this.Controls.SetChildIndex((Control) this.checkUseCostCenter, 0);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("comboCostCenters")]
  internal virtual MGASimpleComboBox comboCostCenters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelCostCenter")]
  internal virtual Label labelCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public MultiGLAccountSelectorWithCostCenter()
  {
    this.InitializeComponent();
    this.DoLoadCostCenters();
    ((Control) this.comboCostCenters).DataBindings.Add("Enabled", (object) this.checkUseCostCenter, "Checked");
  }

  private void checkUseCostCenter_CheckedChanged(object sender, EventArgs e)
  {
    if (this.checkUseCostCenter.Checked)
      return;
    ((Control) this.comboCostCenters).ResetText();
  }

  protected override void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    base.comboOfficeLocation_RowSelected(RuntimeHelpers.GetObjectValue(sender), e);
    this.DoLoadCostCenters();
  }

  private void DoLoadCostCenters()
  {
    if (this.checkUseCostCenter == null)
      return;
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
    if (this.comboCostCenters == null)
      return;
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) Database.Instance.QuerySP.PerformTableQuery("spFin_GetCostCentersList", (object) "@glcompanyid", (object) GlCompanyID);
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "CostCenterId";
  }

  public override object Value
  {
    get
    {
      int num = 0;
      if (((UltraDropDownBase) this.comboCostCenters).SelectedRow != null & this.checkUseCostCenter.Checked)
        num = Conversions.ToInteger(this.comboCostCenters.Value.ToString());
      return (object) new object[3]
      {
        this.comboOfficeLocation.Value,
        (object) num,
        (object) this.MultipleExtendedTreeViewDropDown1.SelectedGLAccountsAsString
      };
    }
    set
    {
      if (value == null)
        return;
      int integer1 = Conversions.ToInteger(NewLateBinding.LateIndexGet(value, new object[1]
      {
        (object) 0
      }, (string[]) null));
      int integer2 = Conversions.ToInteger(NewLateBinding.LateIndexGet(value, new object[1]
      {
        (object) 1
      }, (string[]) null));
      string str = NewLateBinding.LateIndexGet(value, new object[1]
      {
        (object) 2
      }, (string[]) null).ToString();
      if (integer2 == 0)
        this.checkUseCostCenter.Checked = false;
      else
        this.comboCostCenters.Value = (object) integer2;
      this.comboOfficeLocation.Value = (object) integer1;
      this.MultipleExtendedTreeViewDropDown1.SelectedGLAccountsAsString = str;
    }
  }

  protected internal override MGASimpleComboBox comboOfficeLocation
  {
    get => base.comboOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
      MGASimpleComboBox comboOfficeLocation1 = base.comboOfficeLocation;
      if (comboOfficeLocation1 != null)
        comboOfficeLocation1.RowSelected -= selectedEventHandler;
      base.comboOfficeLocation = value;
      MGASimpleComboBox comboOfficeLocation2 = base.comboOfficeLocation;
      if (comboOfficeLocation2 == null)
        return;
      comboOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }
}
