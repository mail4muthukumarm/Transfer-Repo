// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.BillingTypesListBox
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

public class BillingTypesListBox : BaseReportControl
{
  private readonly bool _SelectAllOption;
  private readonly DataTable _dt;
  private IContainer components;

  public BillingTypesListBox(string Label, bool ShowAll)
  {
    this.InitializeComponent();
    this.Description = Label;
    this._SelectAllOption = ShowAll;
    if (this._SelectAllOption)
      this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM ((SELECT -1 As Sort, -1 As ValueMember, @BT As DisplayMember) UNION (SELECT 1 As Sort, BillingTypeID As ValueMember, BillingType As DisplayMember FROM lstBillingTypes)) i ORDER BY Sort, Ltrim(DisplayMember)", new object[2]
      {
        (object) "@BT",
        (object) "All Billing Types"
      });
    else
      this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT BillingTypeID As ValueMember, BillingType As DisplayMember FROM lstBillingTypes");
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.MgaCheckedListBox1.Items.Add((object) Strings.Trim(row["DisplayMember"].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.InitialSize = this.Size;
    if (!this._SelectAllOption)
      return;
    this.MgaCheckedListBox1.SetItemChecked(0, true);
  }

  public BillingTypesListBox() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGACheckedListBox MgaCheckedListBox1
  {
    get => this._MgaCheckedListBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.MgaCheckedListBox1_ItemCheck);
      MGACheckedListBox mgaCheckedListBox1_1 = this._MgaCheckedListBox1;
      if (mgaCheckedListBox1_1 != null)
        mgaCheckedListBox1_1.ItemCheck -= checkEventHandler;
      this._MgaCheckedListBox1 = value;
      MGACheckedListBox mgaCheckedListBox1_2 = this._MgaCheckedListBox1;
      if (mgaCheckedListBox1_2 == null)
        return;
      mgaCheckedListBox1_2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.MgaCheckedListBox1 = new MGACheckedListBox();
    ((ISupportInitialize) this.MgaCheckedListBox1).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 76);
    this.MgaCheckedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.MgaCheckedListBox1.CheckOnClick = true;
    this.MgaCheckedListBox1.Location = new Point(88, 6);
    this.MgaCheckedListBox1.Name = "MgaCheckedListBox1";
    this.MgaCheckedListBox1.Size = new Size(300, 64 /*0x40*/);
    this.MgaCheckedListBox1.TabIndex = 1;
    this.Controls.Add((Control) this.MgaCheckedListBox1);
    this.Name = nameof (BillingTypesListBox);
    this.Size = new Size(392, 76);
    this.Controls.SetChildIndex((Control) this.MgaCheckedListBox1, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.MgaCheckedListBox1).EndInit();
    this.ResumeLayout(false);
  }

  public override object Value
  {
    get
    {
      string str = string.Empty;
      if (this.AllIsSelected())
      {
        str = (string) null;
      }
      else
      {
        int num = this.MgaCheckedListBox1.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (str.Length > 0)
            str += ",";
          str += this._dt.Select($"ControlIndex={this.MgaCheckedListBox1.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.MgaCheckedListBox1.CheckedItems[index]))}")[0]["ValueMember"].ToString();
        }
      }
      return (object) str;
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      int count = this._dt.Rows.Count;
      if (this._SelectAllOption)
        --count;
      string[] array = Strings.Split(value.ToString(), ",");
      if (array.Length == count)
      {
        this.MgaCheckedListBox1.SetItemChecked(0, true);
        int num = this.MgaCheckedListBox1.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.MgaCheckedListBox1.SetItemChecked(index, false);
      }
      else
      {
        try
        {
          foreach (DataRow row in this._dt.Rows)
          {
            int integer = Conversions.ToInteger(row["ControlIndex"]);
            if (Array.IndexOf<string>(array, row["ValueMember"].ToString()) > -1)
              this.MgaCheckedListBox1.SetItemChecked(integer, true);
            else
              this.MgaCheckedListBox1.SetItemChecked(integer, false);
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
    this.MgaCheckedListBox1.Top = 0;
    this.lblDescription.Height = this.MgaCheckedListBox1.Height;
    this.lblDescription.Top = 0;
    this.Height = this.MgaCheckedListBox1.Height;
  }

  private bool AllIsSelected()
  {
    return this.MgaCheckedListBox1.CheckedItems.Count > 0 && this.MgaCheckedListBox1.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.MgaCheckedListBox1.Items[0])) && ((int) this._dt.Select("ControlIndex=0")[0]["ValueMember"]).Equals(-1);
  }

  private void MgaCheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    bool flag = Strings.InStr(Strings.UCase(this.MgaCheckedListBox1.Items[0].ToString()), "ALL") > 0;
    if (flag && e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.MgaCheckedListBox1.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked || !flag)
      return;
    int num = this.MgaCheckedListBox1.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.MgaCheckedListBox1.SetItemCheckState(index, CheckState.Unchecked);
  }
}
