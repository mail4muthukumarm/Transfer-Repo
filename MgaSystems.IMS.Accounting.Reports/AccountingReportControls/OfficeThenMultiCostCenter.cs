// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.OfficeThenMultiCostCenter
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public class OfficeThenMultiCostCenter : BaseReportControl
{
  private DataSet _ds;
  private DataTable _dtCostCenters;
  private DataTable _dtOfficeLocations;
  private bool _returnAllCostCenters;
  private int _costCentersBoxWidth;
  private int _costCentersBoxHeight;
  private IContainer components;

  private void LoadOfficeLocations(bool allOfficeLocations)
  {
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations", new object[4]
    {
      (object) "@userguid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@allOption",
      (object) allOfficeLocations
    });
    this._dtOfficeLocations = this._ds.Tables[0];
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this._dtOfficeLocations;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.SelectedIndex = 0;
  }

  private void LoadCostCenters(int GlCompanyID)
  {
    if (GlCompanyID == -1)
      this._dtCostCenters = Database.Instance.QueryText.PerformTableQuery("SELECT GroupName As Name, GroupID As CostCenterId FROM tblEntityGroups ORDER BY GroupName");
    else
      this._dtCostCenters = Database.Instance.QuerySP.PerformTableQuery("spFin_GetCostCentersList", (object) "@glcompanyid", (object) GlCompanyID);
    DataRow row = this._dtCostCenters.NewRow();
    row["Name"] = (object) "All Cost Centers";
    row["CostCenterId"] = (object) -1;
    this._dtCostCenters.Rows.InsertAt(row, 0);
    this.clbCostCenters.DataSource = (object) this._dtCostCenters;
    this.clbCostCenters.DisplayMember = "Name";
    this.clbCostCenters.ValueMember = "CostCenterId";
    this.clbCostCenters.SetItemCheckState(0, CheckState.Checked);
    this.clbCostCenters.Width = this._costCentersBoxWidth;
    this.clbCostCenters.Height = this._costCentersBoxHeight;
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      if (this.clbCostCenters.DataSource == null)
        return;
      ((DataTable) this.clbCostCenters.DataSource).Clear();
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
    }
  }

  public OfficeThenMultiCostCenter(string Label)
  {
    this._costCentersBoxWidth = 300;
    this._costCentersBoxHeight = 169;
    this.InitializeComponent();
    this.Paint += new PaintEventHandler(this.OfficeThenMultiCostCenter_Paint);
    this.Description = Label;
    this.LoadOfficeLocations(false);
    this._returnAllCostCenters = true;
    this.InitialSize = this.Size;
  }

  public OfficeThenMultiCostCenter(string Label, bool ReturnAllCostCenters)
  {
    this._costCentersBoxWidth = 300;
    this._costCentersBoxHeight = 169;
    this.InitializeComponent();
    this.Paint += new PaintEventHandler(this.OfficeThenMultiCostCenter_Paint);
    this.Description = Label;
    this.LoadOfficeLocations(false);
    this._returnAllCostCenters = ReturnAllCostCenters;
    this.InitialSize = this.Size;
  }

  public OfficeThenMultiCostCenter(string Label, bool ReturnAllCostCenters, bool ReturnAllOffices)
  {
    this._costCentersBoxWidth = 300;
    this._costCentersBoxHeight = 169;
    this.InitializeComponent();
    this.Paint += new PaintEventHandler(this.OfficeThenMultiCostCenter_Paint);
    this.Description = Label;
    this.LoadOfficeLocations(ReturnAllOffices);
    this._returnAllCostCenters = ReturnAllCostCenters;
    this.InitialSize = this.Size;
  }

  public OfficeThenMultiCostCenter(
    string Label,
    bool ReturnAllCostCenters,
    int CostCentersBoxWidth,
    int CostCentersBoxHeight)
  {
    this._costCentersBoxWidth = 300;
    this._costCentersBoxHeight = 169;
    this.InitializeComponent();
    this.Paint += new PaintEventHandler(this.OfficeThenMultiCostCenter_Paint);
    this.Description = Label;
    this.LoadOfficeLocations(false);
    this._returnAllCostCenters = ReturnAllCostCenters;
    this._costCentersBoxWidth = CostCentersBoxWidth;
    this._costCentersBoxHeight = CostCentersBoxHeight;
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

  internal virtual MGASimpleComboBox comboOfficeLocation
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

  internal virtual MGACheckedListBox clbCostCenters
  {
    get => this._clbCostCenters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbCostCenters_ItemCheck);
      MGACheckedListBox clbCostCenters1 = this._clbCostCenters;
      if (clbCostCenters1 != null)
        clbCostCenters1.ItemCheck -= checkEventHandler;
      this._clbCostCenters = value;
      MGACheckedListBox clbCostCenters2 = this._clbCostCenters;
      if (clbCostCenters2 == null)
        return;
      clbCostCenters2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Label1 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.clbCostCenters = new MGACheckedListBox();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.clbCostCenters).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 205);
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(88, 205);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Cost Centers";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.comboOfficeLocation).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(88, 6);
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(300, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 2;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.clbCostCenters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbCostCenters.CheckOnClick = true;
    this.clbCostCenters.Location = new Point(88, 30);
    this.clbCostCenters.Name = "clbCostCenters";
    this.clbCostCenters.Size = new Size(300, 169);
    this.clbCostCenters.TabIndex = 3;
    this.Controls.Add((Control) this.clbCostCenters);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.Label1);
    this.Name = nameof (OfficeThenMultiCostCenter);
    this.Size = new Size(392, 205);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.comboOfficeLocation, 0);
    this.Controls.SetChildIndex((Control) this.clbCostCenters, 0);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.clbCostCenters).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private bool CostCenterAllIsSelected()
  {
    return this.clbCostCenters.Items.Count > 0 && this.clbCostCenters.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbCostCenters.Items[0])) && ((int) ((DataRowView) this.clbCostCenters.Items[0])["CostCenterId"]).Equals(-1);
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (this.CostCenterAllIsSelected())
      {
        if (this._returnAllCostCenters)
        {
          int num = checked (this.clbCostCenters.Items.Count - 1);
          int index = 1;
          while (index <= num)
          {
            if (!string.IsNullOrEmpty(empty))
              empty += ",";
            empty += ((DataRowView) this.clbCostCenters.Items[index])["CostCenterId"].ToString();
            checked { ++index; }
          }
        }
      }
      else
      {
        try
        {
          foreach (object checkedItem in this.clbCostCenters.CheckedItems)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(checkedItem);
            if (!string.IsNullOrEmpty(empty))
              empty += ",";
            empty = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) empty, ((DataRowView) objectValue)["CostCenterId"]));
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      return (object) new object[2]
      {
        this.comboOfficeLocation.Value,
        (object) empty
      };
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      object[] objArray = (object[]) value;
      this.comboOfficeLocation.Value = (object) (int) objArray[0];
      int num1 = checked (this._dtCostCenters.Rows.Count - 1 - 1);
      string[] array = Strings.Split((string) objArray[1], ",");
      if (array.Length == num1)
      {
        this.clbCostCenters.SetItemChecked(0, true);
        int num2 = checked (this.clbCostCenters.Items.Count - 1);
        int index = 1;
        while (index <= num2)
        {
          this.clbCostCenters.SetItemChecked(index, false);
          checked { ++index; }
        }
      }
      else
      {
        int num3 = checked (this.clbCostCenters.Items.Count - 1);
        int index = 0;
        while (index <= num3)
        {
          if (Array.IndexOf<string>(array, ((DataRowView) this.clbCostCenters.Items[index])["CostCenterId"].ToString()) > -1)
            this.clbCostCenters.SetItemChecked(index, true);
          else
            this.clbCostCenters.SetItemChecked(index, false);
          checked { ++index; }
        }
      }
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbCostCenters.Items.Count <= 0 || this.clbCostCenters.CheckedItems.Count != 0 ? string.Empty : "Please check at least one item from the list";
    }
  }

  private void OfficeThenMultiCostCenter_Paint(object sender, PaintEventArgs e)
  {
    this.clbCostCenters.SetItemCheckState(0, CheckState.Checked);
    this.Paint -= new PaintEventHandler(this.OfficeThenMultiCostCenter_Paint);
  }

  private void clbCostCenters_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (e.Index == 0 || e.CurrentValue != CheckState.Unchecked)
      return;
    this.clbCostCenters.SetItemCheckState(0, CheckState.Unchecked);
  }

  public override void Compress()
  {
    ((Control) this.comboOfficeLocation).Top = 0;
    this.clbCostCenters.Top = ((Control) this.comboOfficeLocation).Height;
    this.lblDescription.Height = checked (this.clbCostCenters.Height + ((Control) this.comboOfficeLocation).Height);
    this.Label1.Height = checked (this.clbCostCenters.Height + ((Control) this.comboOfficeLocation).Height);
    this.lblDescription.Top = 0;
    this.Height = checked (this.clbCostCenters.Height + ((Control) this.comboOfficeLocation).Height);
  }
}
