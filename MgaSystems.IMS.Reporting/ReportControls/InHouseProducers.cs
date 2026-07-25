// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.InHouseProducers
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
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

public class InHouseProducers : BaseReportControl
{
  private IContainer components;

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
    this.Name = nameof (InHouseProducers);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public InHouseProducers(string LabelText, bool ShowAllOption)
    : this(LabelText, ShowAllOption, Guid.Empty)
  {
  }

  public InHouseProducers(string LabelText, Guid UserGuid)
    : this(LabelText, false, UserGuid)
  {
  }

  private InHouseProducers(string LabelText, bool ShowAllOption, Guid UserGuid)
    : this(LabelText, ShowAllOption, UserGuid, false)
  {
  }

  public InHouseProducers(
    string LabelText,
    bool ShowAllOption,
    Guid UserGuid,
    bool ShowAllInHouseProducersInSameOffice)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    DataTable dataTable;
    if (UserGuid.Equals(Guid.Empty))
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT (LastName + @C + FirstName) As Name, UserGuid from tblUsers ORDER BY LastName, FirstName", new object[2]
      {
        (object) "@C",
        (object) ", "
      });
    else if (ShowAllInHouseProducersInSameOffice)
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT (LastName + @C + FirstName) As Name, UserGuid from tblUsers WHERE OfficeGUID in (SELECT OfficeGUID FROM tblUsers WHERE UserGuid = @UG) ORDER BY LastName, FirstName", new object[4]
      {
        (object) "@C",
        (object) ", ",
        (object) "@UG",
        (object) UserGuid
      });
    else
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT (LastName +  @C + FirstName) As Name, UserGuid from tblUsers WHERE UserGuid =  @UG ORDER BY LastName, FirstName", new object[4]
      {
        (object) "@C",
        (object) ", ",
        (object) "@UG",
        (object) UserGuid
      });
    if (ShowAllOption)
    {
      DataRow row = dataTable.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All In-House Producers",
        (object) Guid.Empty
      };
      dataTable.Rows.InsertAt(row, 0);
    }
    ((UltraDropDownBase) this.combo).DisplayMember = "Name";
    ((UltraDropDownBase) this.combo).ValueMember = nameof (UserGuid);
    ((UltraGridBase) this.combo).DataSource = (object) dataTable;
    this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => this.combo.Value;
    set => this.combo.Value = (object) (Guid) value;
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Height = ((Control) this.combo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.combo).Height;
  }
}
