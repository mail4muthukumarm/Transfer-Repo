// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.Producers_Multi
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

public class Producers_Multi : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private DataTable _dt;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGACheckedListBox clbProducers
  {
    get => this._clbProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbProducers_ItemCheck);
      MGACheckedListBox clbProducers1 = this._clbProducers;
      if (clbProducers1 != null)
        clbProducers1.ItemCheck -= checkEventHandler;
      this._clbProducers = value;
      MGACheckedListBox clbProducers2 = this._clbProducers;
      if (clbProducers2 == null)
        return;
      clbProducers2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbProducers = new MGACheckedListBox();
    ((ISupportInitialize) this.clbProducers).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 106);
    this.clbProducers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbProducers.CheckOnClick = true;
    this.clbProducers.Location = new Point(88, 6);
    this.clbProducers.Name = "clbProducers";
    this.clbProducers.Size = new Size(300, 94);
    this.clbProducers.TabIndex = 1;
    this.Controls.Add((Control) this.clbProducers);
    this.Name = nameof (Producers_Multi);
    this.Size = new Size(392, 106);
    this.Controls.SetChildIndex((Control) this.clbProducers, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbProducers).EndInit();
    this.ResumeLayout(false);
  }

  public Producers_Multi(string LabelText, bool ShowAllOption)
  {
    this.Load += new EventHandler(this.ProducerLocation_Multi_Load);
    this.InitializeComponent();
    this.Description = LabelText;
    this._ShowAll = ShowAllOption;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ProducerName, ProducerGUID from tblProducers WITH (NOLOCK) ORDER BY ProducerName");
    this._dt.Columns.Add("ControlIndex", typeof (int));
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Producers",
        (object) Guid.Empty
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.clbProducers.Items.Add((object) Strings.Trim(row["ProducerName"].ToString()));
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
    return this.clbProducers.Items.Count > 0 && this.clbProducers.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbProducers.Items[0])) && ((Guid) this._dt.Select("ControlIndex=0")[0]["ProducerGuid"]).Equals(Guid.Empty);
  }

  public override void Compress()
  {
    this.clbProducers.Top = 0;
    this.lblDescription.Height = this.clbProducers.Height;
    this.lblDescription.Top = 0;
    this.Height = this.clbProducers.Height;
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbProducers.CheckedItems.Count != 0 ? (this.clbProducers.CheckedItems.Count <= 200 || this.AllIsSelected() ? string.Empty : "Please select fewer then 200 producers.") : "Please select producer(s) from the list.";
    }
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (!this.AllIsSelected())
      {
        int num = this.clbProducers.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select($"ControlIndex={this.clbProducers.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.clbProducers.CheckedItems[index]))}")[0]["ProducerGuid"].ToString();
        }
      }
      return (object) empty;
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)))
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
      {
        this.clbProducers.SetItemChecked(0, true);
        int num = this.clbProducers.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.clbProducers.SetItemChecked(index, false);
      }
      else
      {
        int count = this._dt.Rows.Count;
        if (this._ShowAll)
          --count;
        string[] array = Strings.Split(value.ToString(), ",");
        if (array.Length == count)
        {
          this.clbProducers.SetItemChecked(0, true);
          int num = this.clbProducers.Items.Count - 1;
          for (int index = 1; index <= num; ++index)
            this.clbProducers.SetItemChecked(index, false);
        }
        else
        {
          try
          {
            foreach (DataRow row in this._dt.Rows)
            {
              int integer = Conversions.ToInteger(row["ControlIndex"]);
              if (Array.IndexOf<string>(array, row["ProducerGUID"].ToString()) > -1)
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

  private void ProducerLocation_Multi_Load(object sender, EventArgs e)
  {
    this.clbProducers.SetItemChecked(0, true);
  }
}
