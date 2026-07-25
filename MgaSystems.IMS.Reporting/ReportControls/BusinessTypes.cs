// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.BusinessTypes
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class BusinessTypes : BaseReportControl
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
    ((Control) this.combo).Location = new Point(88, 8);
    ((Control) this.combo).Name = "combo";
    ((Control) this.combo).Size = new Size(300, 20);
    ((Control) this.combo).TabIndex = 1;
    ((UltraControlBase) this.combo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.combo).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.combo);
    this.Name = nameof (BusinessTypes);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public BusinessTypes(string LabelText, bool ShowAllOption)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT BusinessType, CAST(BusinessTypeID AS INT) AS BusinessTypeID FROM lstBusinessTypes WHERE (Hidden = 0) ORDER BY BusinessType");
    if (ShowAllOption)
    {
      DataRow row = dataTable.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Types",
        (object) -1
      };
      dataTable.Rows.InsertAt(row, 0);
    }
    ((UltraDropDownBase) this.combo).DisplayMember = "BusinessType";
    ((UltraDropDownBase) this.combo).ValueMember = "BusinessTypeID";
    ((UltraGridBase) this.combo).DataSource = (object) dataTable;
    this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => this.combo.Value;
    set => this.combo.Value = (object) Conversions.ToInteger(value);
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Height = ((Control) this.combo).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.combo).Height;
  }
}
