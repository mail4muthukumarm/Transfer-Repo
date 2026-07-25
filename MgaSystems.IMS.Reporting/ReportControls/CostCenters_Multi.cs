// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CostCenters_Multi
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Data;
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
namespace MGASystems.IMS.Reporting.ReportControls;

public class CostCenters_Multi : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private bool _CheckAllItem;
  private DataTable _dt;

  public CostCenters_Multi()
  {
    this._CheckAllItem = false;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGACheckedListBox clbCostCenters
  {
    get => this._clbCostCenters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbCompanies_ItemCheck);
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
    this.clbCostCenters = new MGACheckedListBox();
    ((ISupportInitialize) this.clbCostCenters).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 119);
    this.clbCostCenters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbCostCenters.CheckOnClick = true;
    this.clbCostCenters.Location = new Point(88, 5);
    this.clbCostCenters.Name = "clbCostCenters";
    this.clbCostCenters.Size = new Size(300, 109);
    this.clbCostCenters.TabIndex = 1;
    this.Controls.Add((Control) this.clbCostCenters);
    this.Name = nameof (CostCenters_Multi);
    this.Size = new Size(392, 119);
    this.Controls.SetChildIndex((Control) this.clbCostCenters, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbCostCenters).EndInit();
    this.ResumeLayout(false);
  }

  public CostCenters_Multi(string LabelText, bool ShowAllOption, bool CheckAllItem)
  {
    this._CheckAllItem = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ShowAll = ShowAllOption;
    this._CheckAllItem = CheckAllItem;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT GroupName, GroupID FROM tblEntityGroups ORDER BY GroupName");
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Cost Centers",
        (object) 0
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.clbCostCenters.Items.Add((object) Strings.Trim(row["GroupName"].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (ShowAllOption && CheckAllItem)
      this.clbCostCenters.SetItemChecked(0, true);
    this.InitialSize = this.Size;
  }

  private bool AllIsSelected()
  {
    return this.clbCostCenters.Items.Count > 0 && this.clbCostCenters.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbCostCenters.Items[0])) && (int) this._dt.Select("ControlIndex=0")[0]["GroupID"] == 0;
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbCostCenters.CheckedItems.Count != 0 ? (this.clbCostCenters.CheckedItems.Count <= 200 || this.AllIsSelected() ? string.Empty : "Please select fewer then 200 companies.") : "Please select company(s) from the list.";
    }
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (!this.AllIsSelected())
      {
        int num = this.clbCostCenters.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select($"ControlIndex={this.clbCostCenters.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.clbCostCenters.CheckedItems[index]))}")[0]["GroupID"].ToString();
        }
      }
      return (object) empty;
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      int count = this._dt.Rows.Count;
      if (this._ShowAll)
        --count;
      string[] array = Strings.Split(value.ToString(), ",");
      if (array.Length == count)
      {
        this.clbCostCenters.SetItemChecked(0, true);
        int num = this.clbCostCenters.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.clbCostCenters.SetItemChecked(index, false);
      }
      else
      {
        try
        {
          foreach (DataRow row in this._dt.Rows)
          {
            int integer = Conversions.ToInteger(row["ControlIndex"]);
            if (Array.IndexOf<string>(array, row["GroupID"].ToString()) > -1)
              this.clbCostCenters.SetItemChecked(integer, true);
            else
              this.clbCostCenters.SetItemChecked(integer, false);
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

  private void clbCompanies_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    bool flag = Strings.InStr(Strings.UCase(this.clbCostCenters.Items[0].ToString()), "ALL") > 0;
    if (flag && e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.clbCostCenters.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked || !flag)
      return;
    int num = this.clbCostCenters.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.clbCostCenters.SetItemCheckState(index, CheckState.Unchecked);
  }

  public override void Compress()
  {
    this.clbCostCenters.Top = 0;
    this.lblDescription.Height = this.clbCostCenters.Height;
    this.lblDescription.Top = 0;
    this.Height = this.clbCostCenters.Height;
  }
}
