// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.Controls.Expenses_Multi
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using MGASystems.Common.DataAccess;
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
namespace MGASystems.IMS.Accounting.Reports.Controls;

public class Expenses_Multi : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private DataTable _dtExpenses;

  public Expenses_Multi() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("cblExpenses")]
  internal virtual MGACheckedListBox cblExpenses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.cblExpenses = new MGACheckedListBox();
    ((ISupportInitialize) this.cblExpenses).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 107);
    this.cblExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cblExpenses.CheckOnClick = true;
    this.cblExpenses.Location = new Point(88, 6);
    this.cblExpenses.Name = "cblExpenses";
    this.cblExpenses.Size = new Size(300, 94);
    this.cblExpenses.TabIndex = 1;
    this.Controls.Add((Control) this.cblExpenses);
    this.Name = nameof (Expenses_Multi);
    this.Size = new Size(392, 107);
    this.Controls.SetChildIndex((Control) this.cblExpenses, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.cblExpenses).EndInit();
    this.ResumeLayout(false);
  }

  private bool AllIsSelected()
  {
    return this.cblExpenses.Items.Count > 0 && this.cblExpenses.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.cblExpenses.Items[0])) && ((int) this._dtExpenses.Select("ControlIndex=0")[0]["ExpenseCode"]).Equals(0);
  }

  public Expenses_Multi(string LabelText, bool ShowAllOption)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._ShowAll = ShowAllOption;
    this._dtExpenses = Database.Instance.QueryText.PerformTableQuery("SELECT ExpenseCode, ExpenseName FROM tblFin_Expenses ORDER BY ExpenseName");
    if (ShowAllOption)
    {
      DataRow row = this._dtExpenses.NewRow();
      row.ItemArray = new object[2]
      {
        (object) 0,
        (object) "All Expenses"
      };
      this._dtExpenses.Rows.InsertAt(row, 0);
    }
    this._dtExpenses.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dtExpenses.Rows)
        row["ControlIndex"] = (object) this.cblExpenses.Items.Add(RuntimeHelpers.GetObjectValue(row["ExpenseName"]));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (!this.AllIsSelected())
      {
        int num = checked (this.cblExpenses.CheckedItems.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dtExpenses.Select($"ControlIndex={this.cblExpenses.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.cblExpenses.CheckedItems[index]))}")[0]["ExpenseCode"].ToString();
          checked { ++index; }
        }
      }
      else
      {
        int num = checked (this.cblExpenses.Items.Count - 1);
        int index = 1;
        while (index <= num)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dtExpenses.Select($"ControlIndex={this.cblExpenses.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.cblExpenses.Items[index]))}")[0]["ExpenseCode"].ToString();
          checked { ++index; }
        }
      }
      return (object) empty;
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      int count = this._dtExpenses.Rows.Count;
      if (this._ShowAll)
        checked { --count; }
      string[] array = Strings.Split(value.ToString(), ",");
      if (array.Length == count)
      {
        this.cblExpenses.SetItemChecked(0, true);
        int num = checked (this.cblExpenses.Items.Count - 1);
        int index = 1;
        while (index <= num)
        {
          this.cblExpenses.SetItemChecked(index, false);
          checked { ++index; }
        }
      }
      else
      {
        try
        {
          foreach (DataRow row in this._dtExpenses.Rows)
          {
            int integer = Conversions.ToInteger(row["ControlIndex"]);
            if (Array.IndexOf<string>(array, row["ExpenseCode"].ToString()) > -1)
              this.cblExpenses.SetItemChecked(integer, true);
            else
              this.cblExpenses.SetItemChecked(integer, false);
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
    this.cblExpenses.Top = 0;
    this.lblDescription.Height = this.cblExpenses.Height;
    this.lblDescription.Top = 0;
    this.Height = this.cblExpenses.Height;
  }
}
