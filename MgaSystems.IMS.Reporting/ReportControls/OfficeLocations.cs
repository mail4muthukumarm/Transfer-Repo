// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.OfficeLocations
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

public class OfficeLocations : BaseReportControl, IOfflineReportControl
{
  private IContainer components;
  private bool _GetLocationIDAsInteger;

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
    this.Name = nameof (OfficeLocations);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public OfficeLocations(string LabelText, bool ShowAllOption, bool GetLocationIDAsInteger)
    : this(LabelText, ShowAllOption, Guid.Empty, GetLocationIDAsInteger, OfficeLocations.RestrictOfficeBy.None, false)
  {
  }

  public OfficeLocations(string LabelText, bool ShowAllOption)
    : this(LabelText, ShowAllOption, Guid.Empty, false, OfficeLocations.RestrictOfficeBy.None, false)
  {
  }

  public OfficeLocations(string LabelText, Guid UserGuid)
    : this(LabelText, false, UserGuid, false, OfficeLocations.RestrictOfficeBy.None, false)
  {
  }

  public OfficeLocations(string LabelText, Guid UserGuid, bool GetLocationIDAsInteger)
    : this(LabelText, false, UserGuid, GetLocationIDAsInteger, OfficeLocations.RestrictOfficeBy.None, false)
  {
  }

  public OfficeLocations(
    string LabelText,
    Guid UserGuid,
    bool GetLocationIDAsInteger,
    OfficeLocations.RestrictOfficeBy RestrictByUserOfficeViewingRights)
    : this(LabelText, false, UserGuid, GetLocationIDAsInteger, RestrictByUserOfficeViewingRights, false)
  {
  }

  public OfficeLocations(
    string LabelText,
    Guid UserGuid,
    bool GetLocationIDAsInteger,
    OfficeLocations.RestrictOfficeBy RestrictByUserOfficeViewingRights,
    bool AccountingOfficesOnly)
    : this(LabelText, false, UserGuid, GetLocationIDAsInteger, RestrictByUserOfficeViewingRights, AccountingOfficesOnly)
  {
  }

  public OfficeLocations(
    string LabelText,
    Guid UserGuid,
    bool GetLocationIDAsInteger,
    OfficeLocations.RestrictOfficeBy RestrictByUserOfficeViewingRights,
    bool AccountingOfficesOnly,
    bool ShowAllOption)
    : this(LabelText, ShowAllOption, UserGuid, GetLocationIDAsInteger, RestrictByUserOfficeViewingRights, AccountingOfficesOnly)
  {
  }

  private OfficeLocations(
    string LabelText,
    bool ShowAllOption,
    Guid UserGuid,
    bool GetLocationIDAsInteger,
    OfficeLocations.RestrictOfficeBy RestrictByUserOfficeViewingRights,
    bool AccountingOfficesOnly)
  {
    this.InitializeComponent();
    this._GetLocationIDAsInteger = GetLocationIDAsInteger;
    this.Description = LabelText;
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string format;
    switch (RestrictByUserOfficeViewingRights)
    {
      case OfficeLocations.RestrictOfficeBy.None:
        format = UserGuid.Equals(Guid.Empty) ? "SELECT Location, OfficeGuid, OfficeId FROM tblClientOffices WHERE 1=1 {0} ORDER BY OfficeID" : "SELECT tblClientOffices.Location, tblClientOffices.OfficeGuid, tblClientOffices.OfficeID FROM dbo.tblClientOffices INNER JOIN tblUsers ON tblClientOffices.OfficeGUID = tblUsers.OfficeGUID WHERE tblUsers.UserGUID = @CurrentUserGuid {0} ORDER BY tblClientOffices.OfficeID";
        break;
      case OfficeLocations.RestrictOfficeBy.UserQuotingOfficeViewingRights:
        format = "SELECT Location, OfficeGuid, OfficeID FROM tblClientOffices WHERE    CASE WHEN exists(select OfficeGuid from  tblUserQuotingOffice where UserGuid = @CurrentUserGuid)    THEN         CASE WHEN exists(select OfficeGuid from  tblUserQuotingOffice where UserGuid = @CurrentUserGuid and tblClientOffices.OfficeGUID=tblUserQuotingOffice.OfficeGuid)         THEN 1 ELSE 0 END     ELSE 1 END = 1 {0} ORDER BY Location";
        if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblUserQuotingOffice WHERE tblUserQuotingOffice.UserGuid=@CurrentUserGuid", new object[2]
        {
          (object) "@CurrentUserGuid",
          (object) userGuid
        }) > 0)
        {
          ShowAllOption = false;
          break;
        }
        break;
      case OfficeLocations.RestrictOfficeBy.UserIssuingOfficeViewingRights:
        format = "SELECT Location, OfficeGuid, OfficeID FROM tblClientOffices WHERE    CASE WHEN exists(select OfficeGuid from  tblUserIssuingOffice where UserGuid = @CurrentUserGuid)    THEN         CASE WHEN exists(select OfficeGuid from  tblUserIssuingOffice where UserGuid = @CurrentUserGuid and tblClientOffices.OfficeGUID=tblUserIssuingOffice.OfficeGuid)         THEN 1 ELSE 0 END     ELSE 1 END = 1 {0} ORDER BY Location";
        if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblUserIssuingOffice WHERE tblUserIssuingOffice.UserGuid=@CurrentUserGuid", new object[2]
        {
          (object) "@CurrentUserGuid",
          (object) userGuid
        }) > 0)
        {
          ShowAllOption = false;
          break;
        }
        break;
      default:
        format = "SELECT Location, OfficeGuid, OfficeId FROM tblClientOffices WHERE 1=1 {0} ORDER BY OfficeID";
        break;
    }
    string str = !AccountingOfficesOnly ? string.Format(format, (object) "") : string.Format(format, (object) "AND AccountingOffice = 1 ");
    if (UserGuid.Equals(Guid.Empty))
      UserGuid = CurrentUser.Instance.UserGUID;
    DataTable dataTable;
    if (str.Contains("@CurrentUserGuid"))
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[2]
      {
        (object) "@CurrentUserGuid",
        (object) CurrentUser.Instance.UserGUID
      });
    else
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, str);
    if (ShowAllOption)
    {
      DataRow row = dataTable.NewRow();
      row.ItemArray = new object[3]
      {
        (object) "All Office Locations",
        (object) Guid.Empty,
        (object) -1
      };
      dataTable.Rows.InsertAt(row, 0);
    }
    ((UltraDropDownBase) this.combo).DisplayMember = "Location";
    if (GetLocationIDAsInteger)
      ((UltraDropDownBase) this.combo).ValueMember = "OfficeId";
    else
      ((UltraDropDownBase) this.combo).ValueMember = "OfficeGuid";
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
    set
    {
      if (this._GetLocationIDAsInteger)
        this.combo.Value = (object) (int) value;
      else
        this.combo.Value = (object) (Guid) value;
    }
  }

  public void SetReportControlValue(object value)
  {
    if (value == null)
      return;
    this.combo.Value = RuntimeHelpers.GetObjectValue(value);
  }

  public enum RestrictOfficeBy
  {
    None,
    UserQuotingOfficeViewingRights,
    UserIssuingOfficeViewingRights,
  }
}
