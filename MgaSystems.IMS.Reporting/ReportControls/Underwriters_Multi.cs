// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.Underwriters_Multi
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

public class Underwriters_Multi : BaseReportControl
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

  internal virtual MGACheckedListBox clbUnderwriters
  {
    get => this._clbUnderwriters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbProducers_ItemCheck);
      MGACheckedListBox clbUnderwriters1 = this._clbUnderwriters;
      if (clbUnderwriters1 != null)
        clbUnderwriters1.ItemCheck -= checkEventHandler;
      this._clbUnderwriters = value;
      MGACheckedListBox clbUnderwriters2 = this._clbUnderwriters;
      if (clbUnderwriters2 == null)
        return;
      clbUnderwriters2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbUnderwriters = new MGACheckedListBox();
    ((ISupportInitialize) this.clbUnderwriters).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 107);
    this.clbUnderwriters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbUnderwriters.CheckOnClick = true;
    this.clbUnderwriters.Location = new Point(88, 6);
    this.clbUnderwriters.Name = "clbUnderwriters";
    this.clbUnderwriters.Size = new Size(300, 94);
    this.clbUnderwriters.TabIndex = 1;
    this.Controls.Add((Control) this.clbUnderwriters);
    this.Name = nameof (Underwriters_Multi);
    this.Size = new Size(392, 107);
    this.Controls.SetChildIndex((Control) this.clbUnderwriters, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbUnderwriters).EndInit();
    this.ResumeLayout(false);
  }

  public Underwriters_Multi(string LabelText, bool ShowAllOption)
    : this(LabelText, ShowAllOption, Guid.Empty)
  {
  }

  public Underwriters_Multi(string LabelText, Guid UserGuid)
    : this(LabelText, false, UserGuid)
  {
  }

  public Underwriters_Multi(string LabelText, bool ShowAllOption, Guid UserGuid)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._ShowAll = ShowAllOption;
    if (UserGuid.Equals(Guid.Empty))
      this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT (LastName + @Comma + FirstName) As Name, UserGuid from dbo.tblUsers ORDER BY LastName, FirstName", new object[2]
      {
        (object) "@Comma",
        (object) ", "
      });
    else
      this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT (LastName + @Comma + FirstName) As Name, UserGuid from dbo.tblUsers WHERE UserGuid = @UserGuid ORDER BY LastName, FirstName", new object[4]
      {
        (object) "@Comma",
        (object) ", ",
        (object) "@UserGuid",
        (object) UserGuid
      });
    this._dt.Columns.Add("ControlIndex", typeof (int));
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Underwriters",
        (object) Guid.Empty
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.clbUnderwriters.Items.Add((object) Strings.Trim(row["Name"].ToString()));
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
    return this.clbUnderwriters.Items.Count > 0 && this.clbUnderwriters.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbUnderwriters.Items[0])) && ((Guid) this._dt.Select("ControlIndex=0")[0]["UserGuid"]).Equals(Guid.Empty);
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbUnderwriters.CheckedItems.Count != 0 ? (this.clbUnderwriters.CheckedItems.Count <= 200 || this.AllIsSelected() ? string.Empty : "Please select fewer then 200 underwriters.") : "Please select underwriter(s) from the list.";
    }
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (!this.AllIsSelected())
      {
        try
        {
          foreach (object checkedIndex in this.clbUnderwriters.CheckedIndices)
          {
            int integer = Conversions.ToInteger(checkedIndex);
            if (empty.Length > 0)
              empty += ",";
            string str = this._dt.Select($"ControlIndex={integer}")[0]["UserGuid"].ToString();
            empty += str;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
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
        this.clbUnderwriters.SetItemChecked(0, true);
        int num = this.clbUnderwriters.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.clbUnderwriters.SetItemChecked(index, false);
      }
      else
      {
        int count = this._dt.Rows.Count;
        if (this._ShowAll)
          --count;
        string[] array = Strings.Split(value.ToString(), ",");
        if (array.Length == count)
        {
          this.clbUnderwriters.SetItemChecked(0, true);
          int num = this.clbUnderwriters.Items.Count - 1;
          for (int index = 1; index <= num; ++index)
            this.clbUnderwriters.SetItemChecked(index, false);
        }
        else
        {
          try
          {
            foreach (DataRow row in this._dt.Rows)
            {
              int integer = Conversions.ToInteger(row["ControlIndex"]);
              if (Array.IndexOf<string>(array, row["UserGuid"].ToString()) > -1)
                this.clbUnderwriters.SetItemChecked(integer, true);
              else
                this.clbUnderwriters.SetItemChecked(integer, false);
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
    bool flag = Strings.InStr(Strings.UCase(this.clbUnderwriters.Items[0].ToString()), "ALL") > 0;
    if (flag && e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.clbUnderwriters.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked || !flag)
      return;
    int num = this.clbUnderwriters.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.clbUnderwriters.SetItemCheckState(index, CheckState.Unchecked);
  }

  public override void Compress()
  {
    this.clbUnderwriters.Top = 0;
    this.lblDescription.Height = this.clbUnderwriters.Height;
    this.lblDescription.Top = 0;
    this.Height = this.clbUnderwriters.Height;
  }
}
