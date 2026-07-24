// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.MultiGlAccountsSelector
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
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

[DesignerGenerated]
public class MultiGlAccountsSelector : BaseReportControl
{
  private IContainer components;
  private DataSet _ds;
  private DataTable _dtOfficeLocations;

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
    this.MultipleExtendedTreeViewDropDown1 = new MultipleExtendedTreeViewDropDown();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Anchor = AnchorStyles.None;
    this.lblDescription.Location = new Point(3, 32 /*0x20*/);
    this.lblDescription.Size = new Size(82, 20);
    this.lblDescription.Text = "GL Accounts";
    this.MultipleExtendedTreeViewDropDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.MultipleExtendedTreeViewDropDown1.DropDownHeight = 100;
    this.MultipleExtendedTreeViewDropDown1.DropDownWidth = 201;
    this.MultipleExtendedTreeViewDropDown1.Font = new Font("Tahoma", 8f);
    this.MultipleExtendedTreeViewDropDown1.Location = new Point(88, 32 /*0x20*/);
    this.MultipleExtendedTreeViewDropDown1.Name = "MultipleExtendedTreeViewDropDown1";
    this.MultipleExtendedTreeViewDropDown1.SelectedGLAccountsAsString = "";
    this.MultipleExtendedTreeViewDropDown1.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.MultipleExtendedTreeViewDropDown1.ShowEquityAccounts = true;
    this.MultipleExtendedTreeViewDropDown1.ShowExpenseAccounts = true;
    this.MultipleExtendedTreeViewDropDown1.ShowIncomeAccounts = true;
    this.MultipleExtendedTreeViewDropDown1.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.MultipleExtendedTreeViewDropDown1.ShowSystemDefinedAccounts = true;
    this.MultipleExtendedTreeViewDropDown1.Size = new Size(300, 20);
    this.MultipleExtendedTreeViewDropDown1.TabIndex = 1;
    this.MultipleExtendedTreeViewDropDown1.UseCheckedStateSelectionOverride = false;
    ((Control) this.comboOfficeLocation).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(88, 6);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(300, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 3;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(3, 6);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(79, 20);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Office Location";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.MultipleExtendedTreeViewDropDown1);
    this.Description = "GL Accounts";
    this.Name = nameof (MultiGlAccountsSelector);
    this.Size = new Size(392, 57);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.MultipleExtendedTreeViewDropDown1, 0);
    this.Controls.SetChildIndex((Control) this.comboOfficeLocation, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MultipleExtendedTreeViewDropDown1")]
  protected internal virtual MultipleExtendedTreeViewDropDown MultipleExtendedTreeViewDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual MGASimpleComboBox comboOfficeLocation
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

  public MultiGlAccountsSelector()
  {
    this.InitializeComponent();
    if (!this.DesignMode)
      this.LoadOfficeLocations();
    this.InitialSize = this.Size;
  }

  private void LoadOfficeLocations()
  {
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations", new object[4]
    {
      (object) "@userguid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@allOption",
      (object) false
    });
    this._dtOfficeLocations = this._ds.Tables[0];
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this._dtOfficeLocations;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.SelectedIndex = 0;
  }

  protected virtual void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    this.Cursor = Cursors.WaitCursor;
    this.MultipleExtendedTreeViewDropDown1.LoadGLAccounts(int.Parse(this.comboOfficeLocation.Value.ToString()));
    this.Cursor = Cursors.Default;
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        this.comboOfficeLocation.Value,
        (object) this.MultipleExtendedTreeViewDropDown1.SelectedGLAccountsAsString
      };
    }
    set
    {
      int integer = Conversions.ToInteger(NewLateBinding.LateIndexGet(value, new object[1]
      {
        (object) 0
      }, (string[]) null));
      string str = Conversions.ToString(NewLateBinding.LateIndexGet(value, new object[1]
      {
        (object) 1
      }, (string[]) null));
      this.comboOfficeLocation.Value = (object) integer;
      this.MultipleExtendedTreeViewDropDown1.SelectedGLAccountsAsString = str;
    }
  }

  public override void Compress()
  {
    ((Control) this.comboOfficeLocation).Top = 0;
    this.Label1.Top = 0;
    this.lblDescription.Top = ((Control) this.comboOfficeLocation).Height;
    this.MultipleExtendedTreeViewDropDown1.Top = ((Control) this.comboOfficeLocation).Height;
    this.lblDescription.Height = this.MultipleExtendedTreeViewDropDown1.Height;
    this.Height = checked (((Control) this.comboOfficeLocation).Height + this.MultipleExtendedTreeViewDropDown1.Height);
  }
}
