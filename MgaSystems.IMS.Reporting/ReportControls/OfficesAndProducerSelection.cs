// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.OfficesAndProducerSelection
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class OfficesAndProducerSelection : BaseReportControl
{
  private DataTable _dt;

  internal virtual CheckedListBox clbProducers
  {
    get => this._clbProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbProducers_ItemCheck);
      CheckedListBox clbProducers1 = this._clbProducers;
      if (clbProducers1 != null)
        clbProducers1.ItemCheck -= checkEventHandler;
      this._clbProducers = value;
      CheckedListBox clbProducers2 = this._clbProducers;
      if (clbProducers2 == null)
        return;
      clbProducers2.ItemCheck += checkEventHandler;
    }
  }

  internal virtual MGASimpleComboBox combo
  {
    get => this._combo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.combo_ValueChanged);
      MGASimpleComboBox combo1 = this._combo;
      if (combo1 != null)
        combo1.ValueChanged -= eventHandler;
      this._combo = value;
      MGASimpleComboBox combo2 = this._combo;
      if (combo2 == null)
        return;
      combo2.ValueChanged += eventHandler;
    }
  }

  public OfficesAndProducerSelection()
  {
    this.InitializeComponent();
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ProducerName, ProducerGUID from tblProducers ORDER BY ProducerName");
    ((UltraGridBase) this.combo).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "select Location, OfficeGuid from tblClientOffices ORDER BY Location");
    ((UltraDropDownBase) this.combo).DisplayMember = "Location";
    ((UltraDropDownBase) this.combo).ValueMember = "OfficeGuid";
    this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    this.combo = new MGASimpleComboBox();
    this.clbProducers = new CheckedListBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.combo).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, 6);
    this.lblDescription.Size = new Size(72, 20);
    this.lblDescription.Text = "Offices";
    ((Control) this.combo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.combo.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.combo).Location = new Point(88, 6);
    ((Control) this.combo).Name = "combo";
    ((Control) this.combo).Size = new Size(300, 20);
    ((Control) this.combo).TabIndex = 2;
    ((UltraControlBase) this.combo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.combo).UseOsThemes = (DefaultableBoolean) 2;
    this.clbProducers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbProducers.BorderStyle = BorderStyle.FixedSingle;
    this.clbProducers.CheckOnClick = true;
    this.clbProducers.Location = new Point(88, 32 /*0x20*/);
    this.clbProducers.Name = "clbProducers";
    this.clbProducers.Size = new Size(300, 107);
    this.clbProducers.TabIndex = 3;
    this.Label1.Location = new Point(0, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(72, 107);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Producers";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.clbProducers);
    this.Controls.Add((Control) this.combo);
    this.Description = "Offices";
    this.Name = nameof (OfficesAndProducerSelection);
    this.Size = new Size(400, 144 /*0x90*/);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.clbProducers, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void GetProducers(Guid OfficeGuid)
  {
    this._dt.Clear();
    this.clbProducers.Items.Clear();
    this._dt = DefaultDatabase.ExecuteDataTable("ProducerLocationsByOffice", new object[2]
    {
      (object) "@OfficeGuid",
      (object) OfficeGuid
    });
    this._dt.Columns.Add("ControlIndex", typeof (int));
    DataRow row1 = this._dt.NewRow();
    row1.ItemArray = new object[2]
    {
      (object) Guid.Empty,
      (object) "All Producers"
    };
    this._dt.Rows.InsertAt(row1, 0);
    try
    {
      foreach (DataRow row2 in this._dt.Rows)
        row2["ControlIndex"] = (object) this.clbProducers.Items.Add((object) Strings.Trim(row2["Name"].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private bool AllIsSelected()
  {
    bool flag;
    if (this.clbProducers.CheckedItems.Count > 0 && this.clbProducers.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbProducers.Items[0])))
      flag = this._dt.Select("ControlIndex=0")[0]["ProducerLocationGuid"].Equals((object) Guid.Empty);
    return flag;
  }

  private void combo_ValueChanged(object sender, EventArgs e)
  {
    this.GetProducers((Guid) this.combo.Value);
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      object objectValue = RuntimeHelpers.GetObjectValue(this.combo.Value);
      if (!this.AllIsSelected())
      {
        int num = this.clbProducers.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select($"ControlIndex={this.clbProducers.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.clbProducers.CheckedItems[index]))}")[0]["ProducerLocationGuid"].ToString();
        }
      }
      return (object) new object[2]
      {
        (object) (objectValue != null ? (Guid) objectValue : new Guid()),
        (object) empty
      };
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      object[] objArray = (object[]) value;
      this.combo.Value = RuntimeHelpers.GetObjectValue(objArray[0]);
      int num1 = this._dt.Rows.Count - 1 - 1;
      string[] array = Strings.Split((string) objArray[1], ",");
      if (array.Length == num1)
      {
        this.clbProducers.SetItemChecked(0, true);
        int num2 = this.clbProducers.Items.Count - 1;
        for (int index = 1; index <= num2; ++index)
          this.clbProducers.SetItemChecked(index, false);
      }
      else
      {
        try
        {
          foreach (DataRow row in this._dt.Rows)
          {
            int integer = Conversions.ToInteger(row["ControlIndex"]);
            if (Array.IndexOf<string>(array, row[0].ToString()) > -1)
              this.clbProducers.SetItemChecked(integer, true);
            else
              this.clbProducers.SetItemChecked(integer, false);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Top = 0;
    this.clbProducers.Top = ((Control) this.combo).Height;
    this.Label1.Top = ((Control) this.combo).Height;
    this.Height = ((Control) this.combo).Height;
  }

  private void clbProducers_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    bool flag = Strings.InStr(Strings.UCase(this.clbProducers.Items[0].ToString()), "ALL") > 0;
    if (flag && e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.clbProducers.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked || !flag)
      return;
    int num = this.clbProducers.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.clbProducers.SetItemCheckState(index, CheckState.Unchecked);
  }
}
