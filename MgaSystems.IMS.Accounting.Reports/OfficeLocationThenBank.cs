// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.OfficeLocationThenBank
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
namespace MGASystems.IMS.Accounting.Reports;

public class OfficeLocationThenBank : BaseReportControl
{
  private bool _ShowAllOfficeLocations;
  private bool _GetLocationIDAsInteger;
  private DataSet _ds;
  private DataSet _dsBanks;
  private DataView dvBanks;
  private IContainer components;

  public OfficeLocationThenBank()
  {
    this.Load += new EventHandler(this.OfficeLocationThenBank_Load);
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  public OfficeLocationThenBank(bool ShowAllOfficeLocations, bool GetLocationIDAsInteger)
  {
    this.Load += new EventHandler(this.OfficeLocationThenBank_Load);
    this.InitializeComponent();
    this._GetLocationIDAsInteger = GetLocationIDAsInteger;
    this._ShowAllOfficeLocations = ShowAllOfficeLocations;
    this.InitialSize = this.Size;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbOfficeLocations
  {
    get => this._cmbOfficeLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbOfficeLocations_ValueChanged);
      MGASimpleComboBox cmbOfficeLocations1 = this._cmbOfficeLocations;
      if (cmbOfficeLocations1 != null)
        cmbOfficeLocations1.ValueChanged -= eventHandler;
      this._cmbOfficeLocations = value;
      MGASimpleComboBox cmbOfficeLocations2 = this._cmbOfficeLocations;
      if (cmbOfficeLocations2 == null)
        return;
      cmbOfficeLocations2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cmbBanks")]
  internal virtual MGASimpleComboBox cmbBanks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.cmbOfficeLocations = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.cmbBanks = new MGASimpleComboBox();
    ((ISupportInitialize) this.cmbOfficeLocations).BeginInit();
    ((ISupportInitialize) this.cmbBanks).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, 6);
    this.lblDescription.Size = new Size(88, 9);
    this.lblDescription.Text = "Company";
    this.lblDescription.Visible = false;
    ((Control) this.cmbOfficeLocations).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cmbOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocations).Location = new Point(88, 6);
    ((Control) this.cmbOfficeLocations).Name = "cmbOfficeLocations";
    ((Control) this.cmbOfficeLocations).Size = new Size(300, 20);
    ((Control) this.cmbOfficeLocations).TabIndex = 0;
    ((UltraControlBase) this.cmbOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(0, 6);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(80 /*0x50*/, 20);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Office Location";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.Location = new Point(0, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(80 /*0x50*/, 20);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Bank";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cmbBanks).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cmbBanks.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBanks).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.cmbBanks).Name = "cmbBanks";
    ((Control) this.cmbBanks).Size = new Size(300, 20);
    ((Control) this.cmbBanks).TabIndex = 2;
    ((UltraControlBase) this.cmbBanks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbBanks).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbBanks);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbOfficeLocations);
    this.Description = "Company";
    this.Name = nameof (OfficeLocationThenBank);
    this.Size = new Size(392, 58);
    this.Controls.SetChildIndex((Control) this.cmbOfficeLocations, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.cmbBanks, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.cmbOfficeLocations).EndInit();
    ((ISupportInitialize) this.cmbBanks).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void OfficeLocationThenBank_Load(object sender, EventArgs e)
  {
    this._ds = new DataSet();
    this._dsBanks = new DataSet();
    if (this._GetLocationIDAsInteger)
    {
      this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations", new object[4]
      {
        (object) "@userguid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@allOption",
        (object) false
      });
      ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
      ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) this._ds.Tables[0];
      ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
      this._dsBanks = DefaultDatabase.ExecuteDataSet("spFin_GetBanks");
      this.dvBanks = new DataView();
      this.dvBanks.Table = this._dsBanks.Tables[0];
      ((UltraGridBase) this.cmbBanks).DataSource = (object) this.dvBanks;
      ((UltraDropDownBase) this.cmbBanks).DisplayMember = "BankName";
      ((UltraDropDownBase) this.cmbBanks).ValueMember = "GLAcctID";
      this.cmbOfficeLocations.SelectedIndex = 0;
      this.dvBanks.RowFilter = $"{((UltraDropDownBase) this.cmbOfficeLocations).ValueMember} = {RuntimeHelpers.GetObjectValue(this.cmbOfficeLocations.Value)}";
    }
    else
    {
      this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocationGuids", new object[4]
      {
        (object) "@userguid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@allOption",
        (object) false
      });
      ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "OfficeGuid";
      ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) this._ds.Tables[0];
      ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
      this._dsBanks = DefaultDatabase.ExecuteDataSet("spFin_GetBanks");
      this.dvBanks = new DataView();
      this.dvBanks.Table = this._dsBanks.Tables[0];
      ((UltraGridBase) this.cmbBanks).DataSource = (object) this.dvBanks;
      ((UltraDropDownBase) this.cmbBanks).DisplayMember = "BankName";
      ((UltraDropDownBase) this.cmbBanks).ValueMember = "GLAcctID";
      this.cmbOfficeLocations.SelectedIndex = 0;
    }
    ((UltraGridBase) this.cmbBanks).Refresh();
    if (((UltraGridBase) this.cmbBanks).Rows.Count <= 0)
      return;
    this.cmbBanks.SelectedIndex = 0;
  }

  private void cmbOfficeLocations_ValueChanged(object sender, EventArgs e)
  {
    if (this._GetLocationIDAsInteger)
      this.dvBanks.RowFilter = $"{((UltraDropDownBase) this.cmbOfficeLocations).ValueMember} = {RuntimeHelpers.GetObjectValue(this.cmbOfficeLocations.Value)}";
    ((UltraGridBase) this.cmbBanks).Refresh();
    if (((UltraGridBase) this.cmbBanks).Rows.Count <= 0)
      return;
    this.cmbBanks.SelectedIndex = 0;
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        this.cmbOfficeLocations.Value,
        this.cmbBanks.Value
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      if (this._GetLocationIDAsInteger)
      {
        this.cmbOfficeLocations.Value = (object) (int) objArray[0];
        this.cmbBanks.Value = (object) (int) objArray[1];
      }
      else
      {
        this.cmbOfficeLocations.Value = (object) (Guid) objArray[0];
        this.cmbBanks.Value = (object) (Guid) objArray[1];
      }
    }
  }

  public override void Compress()
  {
    ((Control) this.cmbOfficeLocations).Top = 0;
    this.Label1.Top = 0;
    ((Control) this.cmbBanks).Top = ((Control) this.cmbOfficeLocations).Height;
    this.Label2.Top = ((Control) this.cmbOfficeLocations).Height;
    this.Height = checked (((Control) this.cmbOfficeLocations).Height + ((Control) this.cmbBanks).Height);
  }
}
