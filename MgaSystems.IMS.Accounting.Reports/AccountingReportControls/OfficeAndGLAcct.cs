// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.OfficeAndGLAcct
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using Microsoft.VisualBasic;
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

public sealed class OfficeAndGLAcct : BaseReportControl
{
  private DataSet _ds;
  private DataTable _dtOfficeLocations;
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbOfficeLocation
  {
    get => this._cmbOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbOfficeLocation_ValueChanged);
      MGASimpleComboBox cmbOfficeLocation1 = this._cmbOfficeLocation;
      if (cmbOfficeLocation1 != null)
        cmbOfficeLocation1.ValueChanged -= eventHandler;
      this._cmbOfficeLocation = value;
      MGASimpleComboBox cmbOfficeLocation2 = this._cmbOfficeLocation;
      if (cmbOfficeLocation2 == null)
        return;
      cmbOfficeLocation2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cmbGLaccount")]
  internal virtual ExtendedTreeViewDropDown cmbGLaccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual CheckBox chkAll
  {
    get => this._chkAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkAll_CheckedChanged);
      CheckBox chkAll1 = this._chkAll;
      if (chkAll1 != null)
        chkAll1.CheckedChanged -= eventHandler;
      this._chkAll = value;
      CheckBox chkAll2 = this._chkAll;
      if (chkAll2 == null)
        return;
      chkAll2.CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.cmbOfficeLocation = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.cmbGLaccount = new ExtendedTreeViewDropDown();
    this.Label2 = new Label();
    this.chkAll = new CheckBox();
    ((ISupportInitialize) this.cmbOfficeLocation).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    this.lblDescription.Location = new Point(0, 6);
    this.lblDescription.Size = new Size(88, 20);
    this.lblDescription.Text = "Office Location:";
    ((Control) this.cmbOfficeLocation).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cmbOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocation).Location = new Point(88, 6);
    this.cmbOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocation).Name = "cmbOfficeLocation";
    ((Control) this.cmbOfficeLocation).Size = new Size(300, 20);
    ((Control) this.cmbOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.cmbOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(0, 30);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(80 /*0x50*/, 20);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "GL Account:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cmbGLaccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cmbGLaccount.DropDownHeight = 300;
    this.cmbGLaccount.DropDownWidth = 300;
    this.cmbGLaccount.Font = new Font("Tahoma", 8f);
    this.cmbGLaccount.Location = new Point(136, 30);
    this.cmbGLaccount.Name = "cmbGLaccount";
    this.cmbGLaccount.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.cmbGLaccount.ShowEquityAccounts = true;
    this.cmbGLaccount.ShowExpenseAccounts = true;
    this.cmbGLaccount.ShowIncomeAccounts = true;
    this.cmbGLaccount.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.cmbGLaccount.ShowSystemDefinedAccounts = true;
    this.cmbGLaccount.Size = new Size(252, 20);
    this.cmbGLaccount.TabIndex = 3;
    this.cmbGLaccount.UseCheckedStateSelectionOverride = false;
    this.Label2.Location = new Point(0, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(80 /*0x50*/, 23);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Location:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.chkAll.Checked = true;
    this.chkAll.CheckState = CheckState.Checked;
    this.chkAll.Location = new Point(88, 30);
    this.chkAll.Name = "chkAll";
    this.chkAll.Size = new Size(48 /*0x30*/, 20);
    this.chkAll.TabIndex = 5;
    this.chkAll.Text = "All";
    this.Controls.Add((Control) this.chkAll);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbGLaccount);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbOfficeLocation);
    this.Description = "Office Location:";
    this.Name = nameof (OfficeAndGLAcct);
    this.Size = new Size(392, 56);
    this.Controls.SetChildIndex((Control) this.cmbOfficeLocation, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.cmbGLaccount, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.chkAll, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.cmbOfficeLocation).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public OfficeAndGLAcct()
  {
    this.InitializeComponent();
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations", new object[4]
    {
      (object) "@userguid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@allOption",
      (object) false
    });
    this._dtOfficeLocations = this._ds.Tables[0];
    ((UltraDropDownBase) this.cmbOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.cmbOfficeLocation).ValueMember = "ID";
    ((UltraGridBase) this.cmbOfficeLocation).DataSource = (object) this._dtOfficeLocations;
    this.cmbOfficeLocation.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        this.cmbOfficeLocation.Value,
        Interaction.IIf(this.chkAll.Checked, (object) -1, (object) this.cmbGLaccount.GLAccountID)
      };
    }
    set => this.cmbOfficeLocation.Value = (object) (int) ((object[]) value)[0];
  }

  public override void Compress()
  {
    ((Control) this.cmbOfficeLocation).Top = 0;
    this.lblDescription.Top = 0;
    this.Label1.Top = ((Control) this.cmbOfficeLocation).Height;
    this.chkAll.Top = ((Control) this.cmbOfficeLocation).Height;
    this.cmbGLaccount.Top = ((Control) this.cmbOfficeLocation).Height;
    this.Height = checked (((Control) this.cmbOfficeLocation).Height + this.cmbGLaccount.Height);
  }

  private void LoadGLAccounts()
  {
    if (this.cmbOfficeLocation.Value == null || Conversions.ToInteger(this.cmbOfficeLocation.Value) == -1)
      return;
    Cursor.Current = Cursors.WaitCursor;
    this.cmbGLaccount.LoadGLAccounts(Conversions.ToInteger(this.cmbOfficeLocation.Value));
    Cursor.Current = Cursors.Default;
  }

  private void chkAll_CheckedChanged(object sender, EventArgs e)
  {
    this.cmbGLaccount.Enabled = !this.chkAll.Checked;
    if (this.chkAll.Checked)
      return;
    this.LoadGLAccounts();
  }

  private void cmbOfficeLocation_ValueChanged(object sender, EventArgs e)
  {
    if (this.cmbOfficeLocation.Value != null && Conversions.ToInteger(this.cmbOfficeLocation.Value) != -1)
    {
      this.chkAll.Enabled = true;
      this.cmbGLaccount.Enabled = !this.chkAll.Checked;
      if (this.chkAll.Checked)
        return;
      this.LoadGLAccounts();
    }
    else
    {
      this.chkAll.Enabled = false;
      this.cmbGLaccount.Enabled = false;
    }
  }
}
