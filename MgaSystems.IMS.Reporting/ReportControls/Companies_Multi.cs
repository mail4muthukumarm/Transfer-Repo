// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.Companies_Multi
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

public class Companies_Multi : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private DataTable _dt;

  public Companies_Multi()
  {
    this.Load += new EventHandler(this.Companies_Multi_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGACheckedListBox clbCompanies
  {
    get => this._clbCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbCompanies_ItemCheck);
      MGACheckedListBox clbCompanies1 = this._clbCompanies;
      if (clbCompanies1 != null)
        clbCompanies1.ItemCheck -= checkEventHandler;
      this._clbCompanies = value;
      MGACheckedListBox clbCompanies2 = this._clbCompanies;
      if (clbCompanies2 == null)
        return;
      clbCompanies2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbCompanies = new MGACheckedListBox();
    ((ISupportInitialize) this.clbCompanies).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 119);
    this.clbCompanies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbCompanies.CheckOnClick = true;
    this.clbCompanies.Location = new Point(88, 5);
    this.clbCompanies.Name = "clbCompanies";
    this.clbCompanies.Size = new Size(300, 109);
    this.clbCompanies.TabIndex = 1;
    this.Controls.Add((Control) this.clbCompanies);
    this.Name = nameof (Companies_Multi);
    this.Size = new Size(392, 119);
    this.Controls.SetChildIndex((Control) this.clbCompanies, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbCompanies).EndInit();
    this.ResumeLayout(false);
  }

  public Companies_Multi(string LabelText, bool ShowAllOption)
  {
    this.Load += new EventHandler(this.Companies_Multi_Load);
    this.InitializeComponent();
    this.Description = LabelText;
    this._ShowAll = ShowAllOption;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyName, CompanyGUID FROM tblCompanies ORDER BY Ltrim(CompanyName)");
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Companies",
        (object) Guid.Empty
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.clbCompanies.Items.Add((object) Strings.Trim(row["CompanyName"].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.InitialSize = this.Size;
  }

  private bool AllIsSelected()
  {
    return this.clbCompanies.Items.Count > 0 && this.clbCompanies.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbCompanies.Items[0])) && ((Guid) this._dt.Select("ControlIndex=0")[0]["CompanyGuid"]).Equals(Guid.Empty);
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbCompanies.CheckedItems.Count != 0 ? (this.clbCompanies.CheckedItems.Count <= 200 || this.AllIsSelected() ? string.Empty : "Please select fewer then 200 companies.") : "Please select company(s) from the list.";
    }
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (!this.AllIsSelected())
      {
        int num = this.clbCompanies.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select($"ControlIndex={this.clbCompanies.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.clbCompanies.CheckedItems[index]))}")[0]["CompanyGuid"].ToString();
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
        this.clbCompanies.SetItemChecked(0, true);
        int num = this.clbCompanies.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.clbCompanies.SetItemChecked(index, false);
      }
      else
      {
        try
        {
          foreach (DataRow row in this._dt.Rows)
          {
            int integer = Conversions.ToInteger(row["ControlIndex"]);
            if (Array.IndexOf<string>(array, row["CompanyGUID"].ToString()) > -1)
              this.clbCompanies.SetItemChecked(integer, true);
            else
              this.clbCompanies.SetItemChecked(integer, false);
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
    bool flag = Strings.InStr(Strings.UCase(this.clbCompanies.Items[0].ToString()), "ALL") > 0;
    if (flag && e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.clbCompanies.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked || !flag)
      return;
    int num = this.clbCompanies.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.clbCompanies.SetItemCheckState(index, CheckState.Unchecked);
  }

  public override void Compress()
  {
    this.clbCompanies.Top = 0;
    this.lblDescription.Height = this.clbCompanies.Height;
    this.lblDescription.Top = 0;
    this.Height = this.clbCompanies.Height;
  }

  private void Companies_Multi_Load(object sender, EventArgs e)
  {
    this.clbCompanies.SetItemChecked(0, true);
  }
}
