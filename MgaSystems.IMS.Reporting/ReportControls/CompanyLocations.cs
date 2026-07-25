// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CompanyLocations
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
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

public class CompanyLocations : BaseReportControl
{
  private IContainer components;
  private Guid[] LocationsList;
  private bool IsRestrictedByUserCompanyViewingRights;

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
    this.Name = nameof (CompanyLocations);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public CompanyLocations(string labelText, bool ShowAllOption)
  {
    this.IsRestrictedByUserCompanyViewingRights = false;
    this.InitializeComponent();
    this.CompanyLocationsNew(labelText, ShowAllOption, (Guid[]) null);
    this.InitialSize = this.Size;
  }

  public CompanyLocations(string labelText, bool ShowAllOption, int ControlWidth)
  {
    this.IsRestrictedByUserCompanyViewingRights = false;
    this.InitializeComponent();
    this.CompanyLocationsNew(labelText, ShowAllOption, (Guid[]) null);
    this.Width -= ((Control) this.combo).Width - ControlWidth;
    ((Control) this.combo).Width = ControlWidth;
    this.InitialSize = this.Size;
  }

  public CompanyLocations(string labelText, bool ShowAllOption, params Guid[] LocationsList)
  {
    this.IsRestrictedByUserCompanyViewingRights = false;
    this.InitializeComponent();
    this.CompanyLocationsNew(labelText, ShowAllOption, LocationsList);
    this.InitialSize = this.Size;
  }

  public CompanyLocations(
    string labelText,
    bool ShowAllOption,
    bool RestrictByUserCompanyViewingRights)
  {
    this.IsRestrictedByUserCompanyViewingRights = false;
    this.InitializeComponent();
    this.IsRestrictedByUserCompanyViewingRights = RestrictByUserCompanyViewingRights;
    this.CompanyLocationsNew(labelText, ShowAllOption, (Guid[]) null);
    this.InitialSize = this.Size;
  }

  public CompanyLocations(
    string labelText,
    bool ShowAllOption,
    bool RestrictByUserCompanyViewingRights,
    int ControlWidth)
  {
    this.IsRestrictedByUserCompanyViewingRights = false;
    this.InitializeComponent();
    this.IsRestrictedByUserCompanyViewingRights = RestrictByUserCompanyViewingRights;
    this.CompanyLocationsNew(labelText, ShowAllOption, (Guid[]) null);
    this.Width -= ((Control) this.combo).Width - ControlWidth;
    ((Control) this.combo).Width = ControlWidth;
    this.InitialSize = this.Size;
  }

  public void CompanyLocationsNew(
    string labelText,
    bool ShowAllOption,
    params Guid[] LocationsList)
  {
    this.Description = labelText;
    string str = string.Empty;
    if (LocationsList != null)
    {
      Guid[] guidArray = LocationsList;
      int index = 0;
      while (index < guidArray.Length)
      {
        object obj = (object) guidArray[index];
        str = $"{str}{obj.ToString()};";
        checked { ++index; }
      }
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("Report_GetCompanyLocations", new object[6]
    {
      (object) "@Guids",
      (object) str,
      (object) "@RestrictUsers",
      (object) this.IsRestrictedByUserCompanyViewingRights,
      (object) "@CurrentUserGUID",
      (object) CurrentUser.Instance.UserGUID
    });
    if (ShowAllOption)
    {
      DataRow row = dataTable.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Company Locations",
        (object) Guid.Empty
      };
      dataTable.Rows.InsertAt(row, 0);
    }
    ((UltraDropDownBase) this.combo).DisplayMember = "Name";
    ((UltraDropDownBase) this.combo).ValueMember = "CompanyLocationGUID";
    ((UltraGridBase) this.combo).DataSource = (object) dataTable;
    this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Height = ((Control) this.combo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.combo).Height;
  }

  public override object Value
  {
    get => this.combo.Value;
    set => this.combo.Value = (object) (Guid) value;
  }
}
