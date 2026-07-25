// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.OfficesAndUnderwriterAssistant
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

public class OfficesAndUnderwriterAssistant : BaseReportControl
{
  private DataTable _dataTable;

  private void InitializeComponent()
  {
    this.combo = new MGASimpleComboBox();
    this.underwriterSelection = new CheckedListBox();
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
    this.underwriterSelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.underwriterSelection.BorderStyle = BorderStyle.FixedSingle;
    this.underwriterSelection.CheckOnClick = true;
    this.underwriterSelection.Location = new Point(88, 32 /*0x20*/);
    this.underwriterSelection.Name = "underwriterSelection";
    this.underwriterSelection.Size = new Size(300, 107);
    this.underwriterSelection.TabIndex = 3;
    this.Label1.Location = new Point(0, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(72, 107);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Underwriter Assistants";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.underwriterSelection);
    this.Controls.Add((Control) this.combo);
    this.Description = "Offices";
    this.Name = nameof (OfficesAndUnderwriterAssistant);
    this.Size = new Size(400, 144 /*0x90*/);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    this.Controls.SetChildIndex((Control) this.underwriterSelection, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual CheckedListBox underwriterSelection
  {
    get => this._underwriterSelection;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbAssistants_ItemCheck);
      CheckedListBox underwriterSelection1 = this._underwriterSelection;
      if (underwriterSelection1 != null)
        underwriterSelection1.ItemCheck -= checkEventHandler;
      this._underwriterSelection = value;
      CheckedListBox underwriterSelection2 = this._underwriterSelection;
      if (underwriterSelection2 == null)
        return;
      underwriterSelection2.ItemCheck += checkEventHandler;
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

  public OfficesAndUnderwriterAssistant()
  {
    this.Load += new EventHandler(this.OfficesAndUnderwriterAssistant_Load);
    this.InitializeComponent();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void GetAssistants(Guid officeGuid)
  {
    this._dataTable.Clear();
    this.underwriterSelection.Items.Clear();
    this._dataTable = DefaultDatabase.ExecuteDataTable("UnderwriterAssistantsByOffice", new object[2]
    {
      (object) "@OfficeGuid",
      (object) officeGuid
    });
    this._dataTable.Columns.Add("ControlIndex", typeof (int));
    DataRow row1 = this._dataTable.NewRow();
    if (this._dataTable.Rows.Count == 0)
      row1.ItemArray = new object[2]
      {
        (object) "No Underwriters for Selected Office",
        (object) Guid.Empty
      };
    else
      row1.ItemArray = new object[2]
      {
        (object) "Select All",
        (object) Guid.Empty
      };
    this._dataTable.Rows.InsertAt(row1, 0);
    try
    {
      foreach (DataRow row2 in this._dataTable.Rows)
        row2["ControlIndex"] = (object) this.underwriterSelection.Items.Add((object) Strings.Trim(row2["Name"].ToString()));
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
    if (this.underwriterSelection.CheckedItems.Count > 0 && this.underwriterSelection.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.underwriterSelection.Items[0])))
      flag = this._dataTable.Select("ControlIndex=0")[0]["uGUID"].Equals((object) Guid.Empty);
    return flag;
  }

  private void combo_ValueChanged(object sender, EventArgs e)
  {
    this.GetAssistants((Guid) this.combo.Value);
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      object objectValue = RuntimeHelpers.GetObjectValue(this.combo.Value);
      if (!this.AllIsSelected())
      {
        int num = this.underwriterSelection.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dataTable.Select($"ControlIndex={this.underwriterSelection.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.underwriterSelection.CheckedItems[index]))}")[0]["uGUID"].ToString();
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
      string[] selectedCodes = Strings.Split((string) objArray[1], ",");
      int RecordCount = this._dataTable.Rows.Count - 2;
      int cIndex;
      this.CheckSelectAll(selectedCodes, ref cIndex, RecordCount);
    }
  }

  private void CheckSelectAll(string[] selectedCodes, ref int cIndex, int RecordCount)
  {
    if (selectedCodes.Length == RecordCount)
    {
      this.underwriterSelection.SetItemChecked(0, true);
      int num = this.underwriterSelection.Items.Count - 1;
      for (int index = 1; index <= num; ++index)
        this.underwriterSelection.SetItemChecked(index, false);
    }
    try
    {
      foreach (DataRow row in this._dataTable.Rows)
      {
        cIndex = Conversions.ToInteger(row["ControlIndex"]);
        if (Array.IndexOf<string>(selectedCodes, row[0].ToString()) > -1)
          this.underwriterSelection.SetItemChecked(cIndex, true);
        else
          this.underwriterSelection.SetItemChecked(cIndex, false);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    this.lblDescription.Top = 0;
    this.underwriterSelection.Top = ((Control) this.combo).Height;
    this.Label1.Top = ((Control) this.combo).Height;
    this.Height = ((Control) this.combo).Height;
  }

  private void clbAssistants_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (Strings.InStr(Strings.UCase(this.underwriterSelection.Items[0].ToString()), "ALL") <= 0)
      return;
    if (e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.underwriterSelection.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked)
      return;
    int num = this.underwriterSelection.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.underwriterSelection.SetItemCheckState(index, CheckState.Unchecked);
  }

  private void OfficesAndUnderwriterAssistant_Load(object sender, EventArgs e)
  {
    this.SetDataTable();
    this.SetOfficeLocations();
  }

  private void SetOfficeLocations()
  {
    ((UltraGridBase) this.combo).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "select @SelectAllText AS Location, @NullGuid AS OfficeGuid, 0 as OrderValue UNION SELECT Location, OfficeGuid, 1 as OrderValue from tblClientOffices ORDER BY OrderValue, Location", new object[4]
    {
      (object) "@SelectAllText",
      (object) "All Office Locations",
      (object) "@NullGuid",
      (object) "00000000-0000-0000-0000-000000000000"
    });
    ((UltraDropDownBase) this.combo).DisplayMember = "Location";
    ((UltraDropDownBase) this.combo).ValueMember = "OfficeGuid";
    this.combo.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  private void SetDataTable()
  {
    this._dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Name_FirstLast As [Name], CAST(UserGuid as varchar(36)) as uGUID FROM tblUsers  JOIN tblUserTypes ON tblUsers.UserID = tblUserTypes.UserID WHERE tblUserTypes.UserTypeID = 2");
  }
}
